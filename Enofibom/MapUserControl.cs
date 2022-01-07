using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Http;
using System.Net.Security;
using System.Threading;
using System.Xml.Linq;
using Timer = System.Windows.Forms.Timer;
using GMap.NET.WindowsForms;
using Enofibom.Helper;
using GMap.NET;
using GMap.NET.MapProviders;
using System.Net;

namespace Enofibom
{
    public partial class MapUserControl : UserControl
    {
        GMapOverlay overlay = new GMapOverlay("ABCDS");
        List<Position> listObject = new List<Position>();
        private static string url = "https://10.3.64.246/mbfn/sb/lbs/sdk";
        private static string urlIMEI = "https://10.3.64.246/mbfn/sb/adc/sendMessage?msisdn=";
        System.Windows.Forms.Timer clockCount = new Timer();
        System.Windows.Forms.Timer timer1 = new Timer();
        Maper maper = new Maper();
        DBHelper helper = new DBHelper();
        private Random rd = new Random();
        List<GMapMarker> currentListMarker = new List<GMapMarker>(); //List các marker đang hiển thị phần online
        List<GMapPolygon> currentListPolygon = new List<GMapPolygon>();//List các polygon đang hiển thị online
        List<Position> listHistoryObject = new List<Position>();//List các marker đang hiển thị phần offline
        List<IMEIObject> listIMEI = new List<IMEIObject>(); //list các imei đang hiển thị phần online
        bool isIMEILoaded = false;
        bool isLocationLoaded = false;
        public MapUserControl()
        {
            InitializeComponent();
        }

        private void MapUserControl_Load(object sender, EventArgs e)
        {
            var toDate = DateTime.Now;
            var fromDate = DateTime.Now;

            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            mapControl.CacheLocation = "C:/MapCache";

            mapControl.MapProvider = GMapProviders.GoogleMap;
            var point = new PointLatLng(21.020440, 105.843650);

            mapControl.Position = point;
            mapControl.DragButton = MouseButtons.Left;
            mapControl.MinZoom = 5;
            mapControl.MaxZoom = 22;
            mapControl.Zoom = 13;
            mapControl.ShowCenter = false;

            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
            dataGrid1.AutoGenerateColumns = false;
            //dataGridHistory.AutoGenerateColumns = false;

            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 60000;
            clockCount.Interval = 1000;
            clockCount.Tick += new EventHandler(clockCount_Tick);
            mapControl.Overlays.Add(overlay);

            dpToDate.Value = DateTime.Now;
            dpFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);

            lblFromDate.Text = dpFromDate.Value.ToString("dd/MM/yyyy");
            lblToDate.Text = dpToDate.Value.ToString("dd/MM/yyyy");

            //GetIMEI();
            //var test1 = new Position
            //{
            //    IMSI = "452019939362924",
            //    MSISDN = "84904500084",
            //    CGI = "452-01-10050-14241",
            //    Kind = "C2G",
            //    AngleStart = "",
            //    AngleEnd = "",
            //    Lat = "21020864".Insert(2, "."),
            //    Lon = "105842030".Insert(3, "."),
            //    PlanName = "GSM",
            //    Radius = "500"

            //};
            //listObject.Add(test1);
            //var marker1 = maper.GetMarkerFromData(test1, 2);
            //overlay.Markers.Add(marker1);
        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            isIMEILoaded = isLocationLoaded = false;
            GetIMEI();
            GetLocation();
        }

        private async void GetIMEI()
        {
            try
            {
                listIMEI = new List<IMEIObject>();
                var listSDT = txtSearchMSISDN.Text.Split(';');
                foreach (var sdt in listSDT)
                {
                    using (var client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Add("MobifoneKey", "74a5c84c-f2c3-4bbd-9819-5958094d604e");
                        var contentReponse = "";
                        using (HttpResponseMessage responseMessage = await client.GetAsync(urlIMEI + sdt.Trim()))
                        using (HttpContent content = responseMessage.Content)
                        {
                            if (responseMessage.StatusCode == HttpStatusCode.OK)
                            {
                                contentReponse = content.ReadAsStringAsync().Result;
                            }
                        }

                        if (!String.IsNullOrEmpty(contentReponse))
                        {
                            string imei, msisdn;
                            imei = msisdn = "";
                            XElement xml = XElement.Parse(contentReponse);
                            if (xml.Descendants("parm").Where(x => x.Attribute("name").Value == "sub.imei").FirstOrDefault() != null)
                                imei = xml.Descendants("parm").Where(x => x.Attribute("name").Value == "sub.imei").FirstOrDefault().Attribute("value").Value;

                            if (xml.Descendants("parm").Where(x => x.Attribute("name").Value == "MSISDN").FirstOrDefault() != null)
                                msisdn = xml.Descendants("parm").Where(x => x.Attribute("name").Value == "MSISDN").FirstOrDefault().Attribute("value").Value;
                            if (!String.IsNullOrEmpty(imei) && !String.IsNullOrEmpty(msisdn))
                            {
                                var imeiObj = new IMEIObject
                                {
                                    IMEI = imei,
                                    MSISDN = msisdn.Replace('+', ' ').Trim()
                                };

                                listIMEI.Add(imeiObj);
                                var mobiObj = listObject.Where(m => m.MSISDN == imeiObj.MSISDN).FirstOrDefault();
                                if (mobiObj != null)
                                    mobiObj.IMEI = imeiObj.IMEI;
                            }

                        }
                    }
                }
                isIMEILoaded = true;
                if (isIMEILoaded && isLocationLoaded)
                {
                    foreach(var item in listObject)
                    {
                        await helper.InsertPositionToDB (item);
                    }
                }
            }
            catch { }
            
        }

        private async void GetLocation()
        {
            try
            {
                listObject = new List<Position>();
                var listSDT = txtSearchMSISDN.Text.Split(';');

                foreach (var sdt in listSDT)
                {
                    try
                    {
                        var handler = new HttpClientHandler() { };
                        using (var httpClient = new HttpClient(handler)
                        {
                            BaseAddress = new Uri(url),
                            Timeout = new TimeSpan(0, 2, 0)
                        })
                        {
                            var inputBody = "<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:v1='http://schema.intersec.com/igloo/sdk/v1.2'><soapenv:Header/><soapenv:Body><v1:pull.retrieveV3Req><args><params><filter><msisdn><explicit><kind>2</kind>"
                            + "<m>" + sdt.Trim() + "</m>"
                            + "</explicit></msisdn></filter><options><subscriberFields>msisdn</subscriberFields><subscriberFields>imsi</subscriberFields><locationFields>location</locationFields></options></params></args></v1:pull.retrieveV3Req></soapenv:Body></soapenv:Envelope>";

                            var httpContent = new StringContent(inputBody, Encoding.UTF8, "application/xml");
                            var request = new HttpRequestMessage();
                            request.Method = HttpMethod.Post;
                            request.RequestUri = new Uri(url);
                            request.Content = httpContent;
                            request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/xml");


                            var byteArray = Encoding.ASCII.GetBytes("tctk_api:$5$rounds=5000$bbf460274ac2fcd8$u0raxguDBJcCDUWKabiHX0LXjxuTszOnUJlZhqGXFQ2");
                            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                            httpClient.DefaultRequestHeaders.Add("MobifoneKey", "74a5c84c-f2c3-4bbd-9819-5958094d604e");

                            //var responseMessage = await httpClient.SendAsync(request);
                            var contentReponse = "";
                            using (HttpResponseMessage responseMessage = await httpClient.SendAsync(request))
                            using (HttpContent content = responseMessage.Content)
                            {
                                if (responseMessage.StatusCode == HttpStatusCode.OK)
                                {
                                    contentReponse = content.ReadAsStringAsync().Result;
                                }
                            }
                            //await Task.When
                            if (!String.IsNullOrEmpty(contentReponse))
                            {
                                var respon = contentReponse;

                                string imsi, msisdn, longitude, latitude, radius, cgi, kind, anglestart, angleend, planName;
                                imsi = msisdn = longitude = latitude = radius = cgi = kind = anglestart = angleend = planName = "";
                                if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "imsi").FirstOrDefault() != null)
                                    imsi = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "imsi").FirstOrDefault().Value;

                                if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "msisdn").FirstOrDefault() != null)
                                    msisdn = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "msisdn").FirstOrDefault().Value;

                                if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "longitude").FirstOrDefault() != null)
                                    longitude = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "longitude").FirstOrDefault().Value;

                                if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "latitude").FirstOrDefault() != null)
                                    latitude = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "latitude").FirstOrDefault().Value;

                                if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "radius").FirstOrDefault() != null)
                                    radius = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "radius").FirstOrDefault().Value;

                                if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "cgi").FirstOrDefault() != null)
                                    cgi = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "cgi").FirstOrDefault().Value;

                                if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "kind").FirstOrDefault() != null)
                                    kind = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "kind").FirstOrDefault().Value;

                                if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "planName").FirstOrDefault() != null)
                                    planName = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "planName").FirstOrDefault().Value;

                                if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "angleStart").FirstOrDefault() != null)
                                    anglestart = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "angleStart").FirstOrDefault().Value;

                                if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "angleEnd").FirstOrDefault() != null)
                                    angleend = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "angleEnd").FirstOrDefault().Value;

                                if (!String.IsNullOrEmpty(latitude) && !String.IsNullOrEmpty(longitude))
                                {
                                    var tempLong = ""; var tempLat = "";
                                    tempLat = latitude.Insert(2, ".");
                                    tempLong = longitude.Insert(3, ".");
                                    var mobi = new Position
                                    {
                                        AngleEnd = angleend,
                                        AngleStart = anglestart,
                                        CGI = cgi,
                                        IMSI = imsi,
                                        Kind = kind,
                                        Lat = tempLat,
                                        Lon = tempLong,
                                        MSISDN = msisdn,
                                        Radius = radius,
                                        PlanName = planName,
                                        RequestTime = DateTime.Now
                                    };
                                    var imeiObj = listIMEI.Where(m => m.MSISDN == mobi.MSISDN).FirstOrDefault();
                                    if (imeiObj != null)
                                        mobi.IMEI = imeiObj.IMEI;
                                    listObject.Add(mobi);
                                }
                            }

                        }
                    }
                    catch
                    {

                    }
                    //Thread.Sleep(rd.Next(1000, 1500));
                }

                dataGrid1.DataSource = listObject;
                var count = 1;
                isLocationLoaded = true;
                foreach (var item in listObject)
                {
                    var marker1 = maper.GetMarkerFromData(item, count);
                    var poly = maper.GetPolygonFromData(item);
                    if (marker1 != null)
                    {
                        overlay.Markers.Add(marker1);
                        currentListMarker.Add(marker1);
                    }

                    if (poly != null)
                    {
                        overlay.Polygons.Add(poly);
                        currentListPolygon.Add(poly);
                    }
                    if (isLocationLoaded && isIMEILoaded)
                        await helper.InsertPositionToDB(item);
                    count++;
                }
                var userLoggedIn = System.Configuration.ConfigurationManager.AppSettings[StaticKey.UserLoggedIn];
                var tempLog = new LogEvent
                {
                    EventDate = DateTime.Now,
                    User = userLoggedIn,
                    Task = "Search number: " + txtSearchMSISDN.Text
                };
                await helper.InsertToLog(tempLog);
            }
            catch
            {

            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //ClearMap();
            foreach (var item in currentListMarker)
            {
                overlay.Markers.Remove(item);
            }
            foreach (var item in currentListPolygon)
            {
                overlay.Polygons.Remove(item);
            }
            ClearText();
        }

       
        private void ClearText()
        {
            txtCGI.Text = txtIMSI.Text = txtKind.Text = txtLat.Text = txtLon.Text = txtMSISDN.Text = txtPlanName.Text = txtRadius.Text = "";

            dataGrid1.DataSource = null;
            dataGrid1.Refresh();
        }


        private void dataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    txtCGI.Text = listObject[e.RowIndex].CGI;
                    txtIMSI.Text = listObject[e.RowIndex].IMSI;
                    txtMSISDN.Text = listObject[e.RowIndex].MSISDN;
                    txtLat.Text = listObject[e.RowIndex].Lat;
                    txtLon.Text = listObject[e.RowIndex].Lon;
                    txtRadius.Text = listObject[e.RowIndex].Radius;
                    txtPlanName.Text = listObject[e.RowIndex].PlanName;
                    txtKind.Text = listObject[e.RowIndex].Kind;
                    txtReqTime.Text = listObject[e.RowIndex].RequestTime?.ToString("dd/MM/yyyy HH:mm");
                    txtIMEI.Text = listObject[e.RowIndex].IMEI;
                }
                catch
                {

                }

            }
        }

        private void dataGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    var valuelat = listObject[e.RowIndex].Lat;
                    var valuelng = listObject[e.RowIndex].Lon;
                    //var valuemsisdn = listObject[e.RowIndex].MSISDN;
                    if (!String.IsNullOrEmpty(valuelat) && !String.IsNullOrEmpty(valuelng))
                    {
                        var realLat = Convert.ToDouble(valuelat);
                        var realLng = Convert.ToDouble(valuelng);
                        mapControl.Position = new PointLatLng(realLat, realLng);
                    }
                }
                catch { }
            }
        }

        private void txtSearchMSISDN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                txtSearchMSISDN.Text += ";";
                txtSearchMSISDN.Select(txtSearchMSISDN.Text.Length, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ClearMap();
            ClearText();
            LoadData();
        }

        private void clockCount_Tick(object sender, EventArgs e)
        {
            if (current == 0)
                current = firstTime * 60;
            lblCountLeft.Text = current.ToString();
            current--;
        }

        private int current = 5;
        private int firstTime = 5;


        private void checkAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAuto.Checked)
            {
                firstTime = (int)numericTimer.Value;
                current = firstTime * 60;
                timer1.Interval = firstTime * 60 * 1000;
                timer1.Start();
                clockCount.Start();

                LoadData();
            }
            else
            {
                timer1.Stop();
                clockCount.Stop();
                current = firstTime;
                numericTimer.Value = firstTime;
            }
        }

        
        List<Position> listHistoryPosition = new List<Position>();
        List<GMapMarker> historyListMarker = new List<GMapMarker>();
        List<GMapPolygon> historyListPolygon = new List<GMapPolygon>();


        List<Position> listCurrentHistoryPosition = new List<Position>();

        private void btnSearchHistory_Click(object sender, EventArgs e)
        {
            ClearHistory();
            
            historyListMarker = new List<GMapMarker>(); historyListPolygon = new List<GMapPolygon>();
            var listSDT = txtSearchHistory.Text.Split(';');
            List<string> listArraySDT = new List<string>();
            foreach(var item in listSDT)
            {
                listArraySDT.Add(item.Trim());
            }
            listHistoryPosition = helper.GetListPositionByDate(listArraySDT.ToArray(), dpFromDate.Value, dpToDate.Value);
            var count = 1;
            foreach (var item in listArraySDT)
            {
                var listItem1 = listHistoryPosition.Where(m => m.MSISDN == item).ToList();
                if(listItem1.Count > 0)
                {
                    foreach(var itemPos in listItem1)
                    {
                        var marker1 = maper.GetMarkerFromData(itemPos, count);
                        var poly = maper.GetPolygonFromData(itemPos);
                        if (marker1 != null)
                        {
                            overlay.Markers.Add(marker1);
                            historyListMarker.Add(marker1);
                        }
                        if (poly != null)
                        {

                            overlay.Polygons.Add(poly);
                            historyListPolygon.Add(poly);
                        }
                    }
                }
                count++;
            }
          
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            ClearHistory();
            var trackValue = trackBar1.Value;
            var frDate = dpFromDate.Value;
            var toDate = frDate.AddMinutes(trackValue);
            listCurrentHistoryPosition = listHistoryPosition.Where(m => m.RequestTime >= frDate && m.RequestTime <= toDate).ToList();
            var listSDT = txtSearchHistory.Text.Split(';');
           
            var count = 1;
            foreach (var item in listSDT)
            {
                var listItem1 = listCurrentHistoryPosition.Where(m => m.MSISDN == item.Trim()).ToList();
                if (listItem1.Count > 0)
                {
                    foreach (var itemPos in listItem1)
                    {
                        var marker1 = maper.GetMarkerFromData(itemPos, count);
                        var poly = maper.GetPolygonFromData(itemPos);
                        if (marker1 != null)
                        {
                            overlay.Markers.Add(marker1);
                            historyListMarker.Add(marker1);
                        }
                        if (poly != null)
                        {
                            overlay.Polygons.Add(poly);
                            historyListPolygon.Add(poly);
                        }
                    }
                }
                count++;
            }
           
        }

        private void ReloadTrackBar()
        {
            TimeSpan duration = new TimeSpan(dpToDate.Value.Ticks - dpFromDate.Value.Ticks);
            var totalCount = duration.TotalMinutes;
            trackBar1.Maximum = (int)totalCount;
            trackBar1.Refresh();
        }
        private void dpFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (dpFromDate.Value.Date > dpToDate.Value.Date)
            {
                dpToDate.Value = dpFromDate.Value;
            }
            lblFromDate.Text = dpFromDate.Value.ToString("dd/MM/yyyy");
            ReloadTrackBar();
        }

        private void dpToDate_ValueChanged(object sender, EventArgs e)
        {
            if (dpToDate.Value.Date < dpFromDate.Value.Date)
            {
                dpToDate.Value = dpFromDate.Value;
            }
            lblToDate.Text = dpToDate.Value.ToString("dd/MM/yyyy");
            ReloadTrackBar();
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            ClearHistory();
        }

        private void ClearHistory()
        {
            foreach (var item in historyListMarker)
            {
                overlay.Markers.Remove(item);
            }
            foreach (var item in historyListPolygon)
            {
                overlay.Polygons.Remove(item);
            }
        }

        private void txtSearchHistory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                txtSearchHistory.Text += ";";
                txtSearchHistory.Select(txtSearchHistory.Text.Length -1, 0);
            }
        }
    }
}
