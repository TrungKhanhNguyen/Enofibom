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
using Enofibom.ApiHelper;

namespace Enofibom
{
    public partial class MapUserControl : UserControl
    {
        GMapOverlay overlay = new GMapOverlay("ABCDS");
        List<Position> listObject = new List<Position>();
        
        System.Windows.Forms.Timer clockCount = new Timer();
        System.Windows.Forms.Timer timer1 = new Timer();
        Maper maper = new Maper();
        DBHelper helper = new DBHelper();
        List<GMapMarker> currentListMarker = new List<GMapMarker>(); //List các marker đang hiển thị phần online
        List<GMapPolygon> currentListPolygon = new List<GMapPolygon>();//List các polygon đang hiển thị online
        List<IMEIObject> listIMEI = new List<IMEIObject>(); //list các imei đang hiển thị phần online
        bool isIMEILoaded = false;
        bool isLocationLoaded = false;
        APIConnect api = new APIConnect();
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
            mapControl.Zoom = 12;
            mapControl.ShowCenter = false;

            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
            dataGrid1.AutoGenerateColumns = false;
            //dataGridHistory.AutoGenerateColumns = false;

            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 60000;
            clockCount.Interval = 1000;
            clockCount.Tick += new EventHandler(clockCount_Tick);
            mapControl.Overlays.Add(overlay);

            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            isIMEILoaded = isLocationLoaded = false;
            GetIMEI();
            Thread.Sleep(500);
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
                    var imeiObj = await api.GetIMEI(sdt);
                    listIMEI.Add(imeiObj);
                    var mobiObj = listObject.Where(m => m.MSISDN == imeiObj.MSISDN).FirstOrDefault();
                    if (mobiObj != null)
                        mobiObj.IMEI = imeiObj.IMEI;
                }
                isIMEILoaded = true;
                if (isIMEILoaded && isLocationLoaded)
                {
                    foreach(var item in listObject)
                    {
                        await helper.InsertPositionToDB(item);
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
                    var mobi = await api.GetLocation(sdt); 
                    if (mobi != null)
                    {
                        var imeiObj = listIMEI.Where(m => m.MSISDN == mobi.MSISDN).FirstOrDefault();
                        if (imeiObj != null)
                            mobi.IMEI = imeiObj.IMEI;
                        listObject.Add(mobi);
                    }
                   
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

                    if (listObject.Count == 1)
                    {
                        var lat = Convert.ToDouble(item.Lat);
                        var lon = Convert.ToDouble(item.Lon);
                        mapControl.Position = new PointLatLng(lat, lon);
                        mapControl.Refresh();
                    }
                    else
                    {
                        mapControl.Position = new PointLatLng(13.769040, 109.228371);
                        mapControl.Zoom = 6;
                        mapControl.Refresh();
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
                await DBHelper.InsertToLog(tempLog);
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
            txtLocationStamp.Text = txtEventStamp.Text = "";
            txtTAC.Text = "";
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
                    txtLocationStamp.Text = listObject[e.RowIndex].locStamp?.ToString("dd/MM/yyyy HH:mm");
                    txtEventStamp.Text = listObject[e.RowIndex].eventStamp?.ToString("dd/MM/yyyy HH:mm");
                    txtIMEI.Text = listObject[e.RowIndex].IMEI;
                    txtTAC.Text = listObject[e.RowIndex].TAC;
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

        
    }
}
