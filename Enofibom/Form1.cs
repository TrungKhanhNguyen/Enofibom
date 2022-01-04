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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Enofibom
{
    public partial class Form1 : Form
    {
        GMapOverlay overlay = new GMapOverlay("ABCDS");
        List<MobiObject> listObject = new List<MobiObject>();
        private static string url = "https://10.3.64.246/mbfn/sb/lbs/sdk";
        Timer clockCount = new Timer();
        Maper maper = new Maper();
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick);

            clockCount.Interval = 1000;
            clockCount.Tick += new EventHandler(clockCount_Tick);
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            //GMaps.Instance.Mode = AccessMode.ServerAndCache;
            //mapControl.CacheLocation = "C:/MapCache";

            mapControl.MapProvider = GMapProviders.GoogleMap;
            var point = new PointLatLng(21.020440, 105.843650);
            
            mapControl.Position = point;
            mapControl.DragButton = MouseButtons.Left;
            mapControl.MinZoom = 5; 
            mapControl.MaxZoom = 22;
            mapControl.Zoom = 13;
            mapControl.ShowCenter = false;

            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

        }



        
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            listObject = new List<MobiObject>();
            #region[TestSearch]

            //var test1 = new MobiObject
            //{
            //    IMSI = "452019907817978",
            //    MSISDN = "84907055468",
            //    CGI = "4G:452-01-101175-11",
            //    Kind = "C4G",
            //    AngleStart = "",
            //    AngleEnd = "",
            //    Lat = "21022588".Insert(2,"."),
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

            var listSDT = txtSearchMSISDN.Text.Split(';');
            foreach (var sdt in listSDT)
            {
                //try
                //{
                //    var handler = new HttpClientHandler() { };
                //    using (var httpClient = new HttpClient(handler)
                //    {
                //        BaseAddress = new Uri(url),
                //        Timeout = new TimeSpan(0, 2, 0)
                //    })
                //    {
                //        var inputBody = "<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:v1='http://schema.intersec.com/igloo/sdk/v1.2'><soapenv:Header/><soapenv:Body><v1:pull.retrieveV3Req><args><params><filter><msisdn><explicit><kind>2</kind>"
                //        + "<m>" + sdt + "</m>"
                //        + "</explicit></msisdn></filter><options><subscriberFields>msisdn</subscriberFields><subscriberFields>imsi</subscriberFields><locationFields>location</locationFields></options></params></args></v1:pull.retrieveV3Req></soapenv:Body></soapenv:Envelope>";

                //        var httpContent = new StringContent(inputBody, Encoding.UTF8, "application/xml");
                //        var request = new HttpRequestMessage();
                //        request.Method = HttpMethod.Post;
                //        request.RequestUri = new Uri(url);
                //        request.Content = httpContent;
                //        request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/xml");


                //        var byteArray = Encoding.ASCII.GetBytes("tctk_api:$5$rounds=5000$bbf460274ac2fcd8$u0raxguDBJcCDUWKabiHX0LXjxuTszOnUJlZhqGXFQ2");
                //        httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                //        httpClient.DefaultRequestHeaders.Add("MobifoneKey", "74a5c84c-f2c3-4bbd-9819-5958094d604e");

                //        var responseMessage = await httpClient.SendAsync(request);
                //        if (responseMessage.StatusCode == HttpStatusCode.OK)
                //        {
                //            var respon = await responseMessage.Content.ReadAsStringAsync();

                //            string imsi, msisdn, longitude, latitude, radius, cgi, kind, anglestart, angleend;
                //            imsi = msisdn = longitude = latitude = radius = cgi = kind = anglestart = angleend = "";
                //            if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "imsi").FirstOrDefault() != null)
                //                imsi = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "imsi").FirstOrDefault().Value;

                //            if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "msisdn").FirstOrDefault() != null)
                //                msisdn = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "msisdn").FirstOrDefault().Value;

                //            if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "longitude").FirstOrDefault() != null)
                //                longitude = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "longitude").FirstOrDefault().Value;

                //            if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "latitude").FirstOrDefault() != null)
                //                latitude = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "latitude").FirstOrDefault().Value;

                //            if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "radius").FirstOrDefault() != null)
                //                radius = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "radius").FirstOrDefault().Value;

                //            if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "cgi").FirstOrDefault() != null)
                //                cgi = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "cgi").FirstOrDefault().Value;

                //            if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "kind").FirstOrDefault() != null)
                //                kind = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "kind").FirstOrDefault().Value;

                //            if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "angleStart").FirstOrDefault() != null)
                //                anglestart = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "angleStart").FirstOrDefault().Value;

                //            if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "angleEnd").FirstOrDefault() != null)
                //                angleend = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "angleEnd").FirstOrDefault().Value;

                //            if (!String.IsNullOrEmpty(latitude) && !String.IsNullOrEmpty(longitude))
                //            {
                //                var tempLong = ""; var tempLat = "";
                //                tempLat = latitude.Insert(2, ".");
                //                tempLong = longitude.Insert(3, ".");
                //                var mobi = new MobiObject
                //                {
                //                    AngleEnd = angleend,
                //                    AngleStart = anglestart,
                //                    CGI = cgi,
                //                    IMSI = imsi,
                //                    Kind = kind,
                //                    Lat = tempLat,
                //                    Lng = tempLong,
                //                    MSISDN = msisdn,
                //                    Radius = radius
                //                };
                //                listObject.Add(mobi);
                //            }
                //        }

                //    }
                //}
                //catch
                //{

                //}
            }


            dataGrid1.AutoGenerateColumns = false;
            dataGrid1.DataSource = listObject;

            mapControl.Overlays.Add(overlay);

            foreach (var item in listObject)
            {
                var marker1 = maper.GetMarkerFromData(item);
                var poly = maper.GetPolygonFromData(item);
                if (marker1 != null)
                    overlay.Markers.Add(marker1);
                if (poly != null)
                    overlay.Polygons.Add(poly);

            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {

            //mapControl.Overlays.Remove(overlay);
            mapControl.Overlays.Clear();
            listObject = new List<MobiObject>();
            overlay =  new GMapOverlay(DateTime.Now.ToString());
            mapControl.Refresh();

            /*=================Clear text==================*/
            ClearText();
        }

        private void ClearText()
        {
            txtCGI.Text = txtIMSI.Text = txtKind.Text = txtLat.Text = txtLon.Text = txtMSISDN.Text = txtPlanName.Text = txtRadius.Text = "";

            dataGrid1.Rows.Clear();
            dataGrid1.Refresh();
        }

        private void dataGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    var valuelat = listObject[e.RowIndex].Lat;
                    var valuelng = listObject[e.RowIndex].Lng;
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

        private void DrawLine()
        {
            //PointLatLng point = new PointLatLng(lat, lon);

            GMapRoute line_layer;
            GMapOverlay line_overlay = new GMapOverlay();

            line_layer = new GMapRoute("single_line");
            line_layer.Stroke = new Pen(Brushes.Black, 2); //width and color of line

            line_overlay.Routes.Add(line_layer);
            mapControl.Overlays.Add(line_overlay);

            //Once the layer is created, simply add the two points you want

            line_layer.Points.Add(new PointLatLng(21.020440, 105.843650));
            line_layer.Points.Add(new PointLatLng(21.016830, 105.855760));
            line_layer.Points.Add(new PointLatLng(21.001930, 105.846558));

            //Note that if you are using the MouseEventArgs you need to use local coordinates and convert them:
            //line_layer.Points.Add(mapControl.FromLocalToLatLng(e.X, e.Y));

            //To force the draw, you need to update the route
            mapControl.UpdateRouteLocalPosition(line_layer);

            //you can even add markers at the end of the lines by adding markers to the same layer:

            GMapMarker marker_ = new GMarkerGoogle(new PointLatLng(21.020440, 105.843650),GMarkerGoogleType.arrow);

            GMapMarker marker2_ = new GMarkerGoogle(new PointLatLng(21.016830, 105.855760), GMarkerGoogleType.arrow);
            line_overlay.Markers.Add(marker_);
            line_overlay.Markers.Add(marker2_);
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
                    txtLon.Text = listObject[e.RowIndex].Lng;
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
            
        }

        private void clockCount_Tick(object sender, EventArgs e)
        {
            numericTimer.Value = GetCurrentTime();
        }

        private int current = 10;
        private int firstTime = 10;
        private int GetCurrentTime()
        {
            if (current == 1)
                current = firstTime; 
            else
                current--;
            return current;
        }

        private void checkAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAuto.Checked)
            {
                current = firstTime = (int)numericTimer.Value;
                timer1.Interval = (int)numericTimer.Value * 1000;
                timer1.Start();
                clockCount.Start();
               
            }
            else
            {
                timer1.Stop();
                clockCount.Stop();
                current = firstTime;
                numericTimer.Value = firstTime;
            }
        }
    }
}
