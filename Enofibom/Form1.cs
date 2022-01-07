using Enofibom.Helper;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Timer = System.Windows.Forms.Timer;

namespace Enofibom
{
    public partial class Form1 : Form
    {
        GMapOverlay overlay = new GMapOverlay("ABCDS");
        List<Position> listObject = new List<Position>();
        private static string url = "https://10.3.64.246/mbfn/sb/lbs/sdk";
        System.Windows.Forms.Timer clockCount = new Timer();
        System.Windows.Forms.Timer timer1 = new Timer();
        Maper maper = new Maper();
        DBHelper helper = new DBHelper();
        private Random rd = new Random();
        GMapMarker currentMarker = null ;
        List<Position> listHistoryObject = new List<Position>();
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
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
            dataGridHistory.AutoGenerateColumns = false;

            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 60000;
            clockCount.Interval = 1000;
            clockCount.Tick += new EventHandler(clockCount_Tick);
            mapControl.Overlays.Add(overlay);

        }


       
        
        private void btnSearch_Click(object sender, EventArgs e)
        {

            #region[TestSearch]

            //var test1 = new MobiObject
            //{
            //    IMSI = "452019907817978",
            //    MSISDN = "84907055468",
            //    CGI = "4G:452-01-101175-11",
            //    Kind = "C4G",
            //    AngleStart = "",
            //    AngleEnd = "",
            //    Lat = "21022588".Insert(2, "."),
            //    Lng = "105843254".Insert(3, "."),
            //    PlanName = "GSM",
            //    Radius = "1000"

            //};

            //var test2 = new MobiObject
            //{
            //    IMSI = "452019939362924",
            //    MSISDN = "84904500084",
            //    CGI = "452-01-10050-14241",
            //    Kind = "C2G",
            //    AngleStart = "",
            //    AngleEnd = "",
            //    Lat = "21020864".Insert(2, "."),
            //    Lng = "105842030".Insert(3, "."),
            //    PlanName = "GSM",
            //    Radius = "500"

            //};
            //listObject.Add(test1);
            //listObject.Add(test2);
            #endregion
            GetLocation();
            
            
        }

        private async void GetLocation()
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
                        + "<m>" + sdt + "</m>"
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
                                    PlanName = planName
                                };
                                await helper.InsertPositionToDB(mobi);
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
            foreach (var item in listObject)
            {
                var marker1 = maper.GetMarkerFromData(item,count);
                var poly = maper.GetPolygonFromData(item);
                if (marker1 != null)
                    overlay.Markers.Add(marker1);
                if (poly != null)
                    overlay.Polygons.Add(poly);
                count++;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            ClearMap();
            /*=================Clear text==================*/
            ClearText();
        }

        private void ClearMap()
        {
            mapControl.Overlays.Clear();
            listObject = new List<Position>();
            overlay = new GMapOverlay(DateTime.Now.ToString());
            mapControl.Refresh();
        }
        private void ClearText()
        {
            txtCGI.Text = txtIMSI.Text = txtKind.Text = txtLat.Text = txtLon.Text = txtMSISDN.Text = txtPlanName.Text = txtRadius.Text = "";

            dataGrid1.DataSource = null;
            dataGrid1.Refresh();
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
                catch{ }
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

        private void mapControl_Load(object sender, EventArgs e)
        {

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
                }
                catch
                {

                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ClearMap();
            ClearText();
            GetLocation();
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
                GetLocation();
            }
            else
            {
                timer1.Stop();
                clockCount.Stop();
                current = firstTime;
                numericTimer.Value = firstTime;
            }
        }

        #region[Secondary Tab]
        private void btnClearMark_Click(object sender, EventArgs e)
        {
            //ClearMap();
            if(currentMarker != null)
            {
                overlay.Markers.Remove(currentMarker);
                currentMarker = null;
                btnClearMark.Enabled = false;
            }
        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtMarkLat.Text) && !String.IsNullOrEmpty(txtMarkLon.Text))
            {
                try
                {
                    var lat = Convert.ToDouble(txtMarkLat.Text);
                    var lon = Convert.ToDouble(txtMarkLon.Text);
                    var point = new PointLatLng(lat, lon);
                    GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);
                    marker.IsVisible = true;
                    var tooltiptext = Environment.NewLine +  "Lat=" + lat + "; Lon=" + lon;
                    marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    marker.ToolTipText = tooltiptext;
                    overlay.Markers.Add(marker);
                }
                catch { }
            }
        }
        #endregion

        private void mapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            currentMarker = item;
            btnClearMark.Enabled = true;
        }

        private void dataGridHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    txtHistoryCGI.Text = listHistoryObject[e.RowIndex].CGI;
                    txtHistoryIMSI.Text = listHistoryObject[e.RowIndex].IMSI;
                    txtHistoryMSISDN.Text = listHistoryObject[e.RowIndex].MSISDN;
                    txtHistoryLat.Text = listHistoryObject[e.RowIndex].Lat;
                    txtHistoryLon.Text = listHistoryObject[e.RowIndex].Lon;
                    txtHistoryRadius.Text = listHistoryObject[e.RowIndex].Radius;
                    txtHistoryPlaneName.Text = listHistoryObject[e.RowIndex].PlanName;
                    txtHistoryKind.Text = listHistoryObject[e.RowIndex].Kind;
                    txtHistoryReqTime.Text = listHistoryObject[e.RowIndex].RequestTime?.ToString("dd-MM-yyyy");
                }
                catch
                {

                }

            }
        }

        private void btnSearchHistory_Click(object sender, EventArgs e)
        {
            var sdt = txtSearchHistory.Text;
            listHistoryObject = helper.GetHistoryObject(sdt);
            dataGridHistory.DataSource = listHistoryObject;
            var count = 1;
            foreach (var item in listHistoryObject)
            {
                count++;
                var marker1 = maper.GetMarkerFromData(item,count);
                //var poly = maper.GetPolygonFromData(item);
                if (marker1 != null)
                    overlay.Markers.Add(marker1);
                //if (poly != null)
                //    overlay.Polygons.Add(poly);
            }

        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            ClearMap();
            listHistoryObject = new List<Position>();
        }
    }
}
