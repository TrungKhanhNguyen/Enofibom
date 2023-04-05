using Enofibom.Helper;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Enofibom
{
    public partial class HistoryMap : UserControl
    {
        GMapOverlay overlay = new GMapOverlay("HISTORYOVERLAY");

        List<Position> listHistoryPosition = new List<Position>();
        List<GMapMarker> historyListMarker = new List<GMapMarker>();
        List<GMapPolygon> historyListPolygon = new List<GMapPolygon>();
        List<GMapRoute> historyListRoute = new List<GMapRoute>();

        List<Position> listCurrentHistoryPosition = new List<Position>();

        List<PositionObject> listConvertedObject = new List<PositionObject>();

        Maper maper = new Maper();
        DBHelper helper = new DBHelper();
        private bool sortAscending = false;

        List<string> listArraySDT = new List<string>();
        public HistoryMap()
        {
            InitializeComponent();
            dataGridView1.BringToFront();
            new ToolTip().SetToolTip(pictureBox1, "Display maximum 7 targets path.");
        }

        private List<PositionObject> ConvertToListPositionObject(List<Position> listObject)
        {
            var listConverted = new List<PositionObject>();
            try
            {
                foreach (var item in listObject)
                {

                    var temp = new PositionObject
                    {
                        Id = item.Id,
                       CGI = item.CGI,
                       AngleEnd = item.AngleEnd,
                       AngleStart = item.AngleStart,
                       CellName = item.CellName,
                       locStamp = item.locStamp,
                       eventStamp = item.eventStamp,
                       IMEI = item.IMEI,
                       IMSI = item.IMSI,
                       Kind = item.Kind,
                       Lat = item.Lat,
                       Lon = item.Lon,
                       MSISDN = item.MSISDN,
                       PlanName = item.PlanName,
                       Presence = item.Presence,
                       Radius = item.Radius,
                       TAC = item.TAC,
                       RequestTime = item.RequestTime,
                       PresentFlag = DBHelper.UnixTimeStampToDateTime(Convert.ToDouble(item.PresentFlag)),
                       DisappearedFlag = DBHelper.UnixTimeStampToDateTime(Convert.ToDouble(item.DisappearedFlag)),

                    };
                    listConverted.Add(temp);


                }
            }
            catch { }
            return listConverted;
        }

        private void ReloadTrackBar()
        {
            try
            {
                TimeSpan duration = new TimeSpan(dpToDate.Value.Ticks - dpFromDate.Value.Ticks);
                var totalCount = duration.TotalMinutes;
                trackBar1.Maximum = (int)totalCount;
                trackBar1.Refresh();
                var toDate = dpFromDate.Value.AddMinutes(trackBar1.Value);
                txtCurrentValue.Text = toDate.ToString("dd/MM/yyyy HH:mm");
            }
            catch (Exception ex)
            {

            }
            
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            ClearHistory();
            var trackValue = trackBar1.Value;
            var frDate = dpFromDate.Value;
            var toDate = frDate.AddMinutes(trackValue);
            listCurrentHistoryPosition = listHistoryPosition.Where(m => m.eventStamp >= frDate && m.eventStamp <= toDate).ToList();
            txtCurrentValue.Text = toDate.ToString("dd/MM/yyyy HH:mm");
            if (chkShowMap.Checked)
            {
                ShowPointsAndLines(listCurrentHistoryPosition);
            }
            txtRecords.Text = listCurrentHistoryPosition.Count().ToString();

            listConvertedObject = ConvertToListPositionObject(listCurrentHistoryPosition);
            dataGridView1.DataSource = listCurrentHistoryPosition;
        }

        private void HistoryMap_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            //Map Configure
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

            dpToDate.Value = DateTime.Now;
            dpFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            txtCurrentValue.Text = dpFromDate.Value.ToString("dd/MM/yyyy HH:mm");
            lblFromDate.Text = dpFromDate.Value.ToString("dd/MM/yyyy HH:mm");
            lblToDate.Text = dpToDate.Value.ToString("dd/MM/yyyy HH:mm");

            mapControl.Overlays.Add(overlay);
            chkShowMap.Checked = true;

            
        }
        
        private void btnSearchHistory_Click(object sender, EventArgs e)
        {
            try
            {
                ClearHistory();
                trackBar1.Value = 0;
                listArraySDT = new List<string>();
                historyListMarker = new List<GMapMarker>(); historyListPolygon = new List<GMapPolygon>();
                historyListRoute = new List<GMapRoute>();
                var listSDT = txtSearchHistory.Text.Split(';');
                if (string.IsNullOrEmpty(txtSearchHistory.Text))
                {
                    listHistoryPosition = helper.GetListPositionByDate(dpFromDate.Value, dpToDate.Value);
                }
                else {
                    foreach (var item in listSDT)
                    {
                        if (!String.IsNullOrEmpty(item))
                            listArraySDT.Add(helper.ConvertPhoneNumber(item.Trim()));
                        
                    }
                    listHistoryPosition = helper.GetListPositionByDate(listArraySDT.ToArray(), dpFromDate.Value, dpToDate.Value);
                }

                if (chkShowMap.Checked)
                {
                    ShowPointsAndLines(listHistoryPosition);
                }

                //var kkk = historyListRoute;
                txtRecords.Text = listHistoryPosition.Count().ToString();

                listConvertedObject = ConvertToListPositionObject(listHistoryPosition);
                dataGridView1.DataSource = listConvertedObject.OrderByDescending(m => m.eventStamp).ToList();
            }
            catch { }
            
        }

        private void ShowPointsAndLines(List<Position> listPos)
        {
            var count = 1;
            if (!String.IsNullOrEmpty(txtSearchHistory.Text))
            {
                foreach (var item in listArraySDT)
                {
                    var listItem1 = listPos.Where(m => m.MSISDN == item).ToList();
                    if (listItem1.Count > 0)
                    {
                        foreach (var itemPos in listItem1)
                        {
                            var marker1 = maper.GetMarkerFromData(itemPos, count);
                            //var poly = maper.GetPolygonFromData(itemPos);
                            if (marker1 != null)
                            {
                                overlay.Markers.Add(marker1);
                                historyListMarker.Add(marker1);
                            }
                            //if (poly != null)
                            //{

                            //    overlay.Polygons.Add(poly);
                            //    historyListPolygon.Add(poly);
                            //}
                        }
                        if (listItem1.Count > 1)
                        {
                            for (int i = 0; i < listItem1.Count - 1; i++)
                            {
                                GMapRoute line_layer = new GMapRoute("single_line");
                                line_layer.Stroke = new Pen(Brushes.Black, 1); //width and color of line

                                var lat1 = Convert.ToDouble(listItem1[i].Lat);
                                var lon1 = Convert.ToDouble(listItem1[i].Lon);

                                var lat2 = Convert.ToDouble(listItem1[i + 1].Lat);
                                var lon2 = Convert.ToDouble(listItem1[i + 1].Lon);

                                var point1 = new PointLatLng(lat1, lon1);
                                var point2 = new PointLatLng(lat2, lon2);

                                line_layer.Points.Add(point1);
                                line_layer.Points.Add(point2);
                                overlay.Routes.Add(line_layer);
                                historyListRoute.Add(line_layer);
                                mapControl.UpdateRouteLocalPosition(line_layer);
                            }
                        }
                        mapControl.Refresh();
                    }
                    count++;
                }
            }
            
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            ClearHistory();
            listHistoryPosition = new List<Position>();
            listConvertedObject = new List<PositionObject>();
            dataGridView1.DataSource = null;
            txtRecords.Text = "0";
        }

        private void dpFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (dpFromDate.Value.Date > dpToDate.Value.Date)
            {
                dpToDate.Value = dpFromDate.Value;
            }
            lblFromDate.Text = dpFromDate.Value.ToString("dd/MM/yyyy HH:mm");
            ReloadTrackBar();
        }

        private void dpToDate_ValueChanged(object sender, EventArgs e)
        {
            if (dpToDate.Value.Date < dpFromDate.Value.Date)
            {
                dpToDate.Value = dpFromDate.Value;
            }
            lblToDate.Text = dpToDate.Value.ToString("dd/MM/yyyy HH:mm");
            ReloadTrackBar();
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
            foreach (var item in historyListRoute)
            {
                overlay.Routes.Remove(item);
                mapControl.UpdateRouteLocalPosition(item);
            }

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sortAscending)
            {
                switch (dataGridView1.Columns[e.ColumnIndex].HeaderText)
                {
                    case "IMSI": listHistoryPosition = listHistoryPosition.OrderBy(m => m.IMSI).ToList(); break;
                    case "IMEI": listHistoryPosition = listHistoryPosition.OrderBy(m => m.IMEI).ToList(); break;
                    case "CGI": listHistoryPosition = listHistoryPosition.OrderBy(m => m.CGI).ToList(); break;
                    case "Kind": listHistoryPosition = listHistoryPosition.OrderBy(m => m.Kind).ToList(); break;
                    case "Lat": listHistoryPosition = listHistoryPosition.OrderBy(m => m.Lat).ToList(); break;
                    case "Lon": listHistoryPosition = listHistoryPosition.OrderBy(m => m.Lon).ToList(); break;
                    case "Radius": listHistoryPosition = listHistoryPosition.OrderBy(m => m.Radius).ToList(); break;
                    case "PlanName": listHistoryPosition = listHistoryPosition.OrderBy(m => m.PlanName).ToList(); break;
                    case "locStamp": listHistoryPosition = listHistoryPosition.OrderBy(m => m.locStamp).ToList(); break;
                    case "eventStamp": listHistoryPosition = listHistoryPosition.OrderBy(m => m.eventStamp).ToList(); break;
                    case "Presence": listHistoryPosition = listHistoryPosition.OrderBy(m => m.Presence).ToList(); break;
                    case "presentFlag": listHistoryPosition = listHistoryPosition.OrderBy(m => m.PresentFlag).ToList(); break;
                    case "disappearedFlag": listHistoryPosition = listHistoryPosition.OrderBy(m => m.DisappearedFlag).ToList(); break;
                        //default: listCurrentHistoryPosition = listCurrentHistoryPosition.OrderBy(m => m.eventStamp).ToList(); break;
                }
            }
            else
            {
                switch (dataGridView1.Columns[e.ColumnIndex].HeaderText)
                {
                    case "IMSI": listHistoryPosition = listHistoryPosition.OrderByDescending(m => m.IMSI).ToList(); break;
                    case "IMEI": listHistoryPosition = listHistoryPosition.OrderByDescending(m => m.IMEI).ToList(); break;
                    case "CGI": listHistoryPosition = listHistoryPosition.OrderByDescending(m => m.CGI).ToList(); break;
                    case "Kind": listHistoryPosition = listHistoryPosition.OrderByDescending(m => m.Kind).ToList(); break;
                    case "Lat": listHistoryPosition = listHistoryPosition.OrderByDescending(m => m.Lat).ToList(); break;
                    case "Lon": listHistoryPosition = listHistoryPosition.OrderByDescending(m => m.Lon).ToList(); break;
                    case "Radius": listHistoryPosition = listHistoryPosition.OrderByDescending(m => m.Radius).ToList(); break;
                    case "PlanName": listHistoryPosition = listHistoryPosition.OrderByDescending(m => m.PlanName).ToList(); break;
                    case "locStamp": listHistoryPosition = listHistoryPosition.OrderByDescending(m => m.locStamp).ToList(); break;
                    case "eventStamp": listHistoryPosition = listHistoryPosition.OrderByDescending(m => m.eventStamp).ToList(); break;
                    case "Presence": listHistoryPosition = listHistoryPosition.OrderByDescending(m => m.Presence).ToList(); break;
                    case "presentFlag": listHistoryPosition = listHistoryPosition.OrderByDescending(m => m.PresentFlag).ToList(); break;
                    case "disappearedFlag": listHistoryPosition = listHistoryPosition.OrderByDescending(m => m.DisappearedFlag).ToList(); break;
                }
            }
            sortAscending = !sortAscending;
            listConvertedObject = ConvertToListPositionObject(listHistoryPosition);
            dataGridView1.DataSource = listConvertedObject;
            dataGridView1.Refresh();
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    var valuelat = listHistoryPosition[e.RowIndex].Lat;
                    var valuelng = listHistoryPosition[e.RowIndex].Lon;
                    var valuemsisdn = listHistoryPosition[e.RowIndex].MSISDN;
                    if(txtSearchHistory.Text.Contains(valuemsisdn + ";") != true)
                    {
                        txtSearchHistory.Text += valuemsisdn + ";";
                    }
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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Height = 250;
        }

        //private void dataGridView1_MultiSelectChanged(object sender, EventArgs e)
        //{
        //    string s = "";
        //    foreach(DataGridViewRow tempRow in dataGridView1.Rows)
        //    {
        //        if (tempRow.Selected)
        //        {
        //            s += tempRow.Cells[0].ToString();
        //        }
        //    }
        //}
    }
}
