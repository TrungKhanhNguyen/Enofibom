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
        Maper maper = new Maper();
        DBHelper helper = new DBHelper();
        public HistoryMap()
        {
            InitializeComponent();
            dataGridView1.BringToFront();
        }

        private void ReloadTrackBar()
        {
            TimeSpan duration = new TimeSpan(dpToDate.Value.Ticks - dpFromDate.Value.Ticks);
            var totalCount = duration.TotalMinutes;
            trackBar1.Maximum = (int)totalCount;
            trackBar1.Refresh();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            ClearHistory();
            var trackValue = trackBar1.Value;
            var frDate = dpFromDate.Value;
            var toDate = frDate.AddMinutes(trackValue);
            listCurrentHistoryPosition = listHistoryPosition.Where(m => m.eventStamp >= frDate && m.eventStamp <= toDate).ToList();
            var listSDT = txtSearchHistory.Text.Split(';');
            txtCurrentValue.Text = toDate.ToString("dd/MM/yyyy HH:mm:ss");
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

                    if (listItem1.Count > 1)
                    {
                        for (int i = 0; i < listItem1.Count - 1; i++)
                        {
                            GMapRoute line_layer;
                            line_layer = new GMapRoute("single_line");
                            line_layer.Stroke = new Pen(Brushes.Black, 2); //width and color of line

                            overlay.Routes.Add(line_layer);

                            var lat1 = Convert.ToDouble(listItem1[i].Lat);
                            var lon1 = Convert.ToDouble(listItem1[i].Lon);

                            var lat2 = Convert.ToDouble(listItem1[i + 1].Lat);
                            var lon2 = Convert.ToDouble(listItem1[i + 1].Lon);

                            var point1 = new PointLatLng(lat1, lon1);
                            var point2 = new PointLatLng(lat2, lon2);

                            line_layer.Points.Add(point1);
                            line_layer.Points.Add(point2);
                            historyListRoute.Add(line_layer);
                            //To force the draw, you need to update the route
                            mapControl.UpdateRouteLocalPosition(line_layer);
                        }
                        //mapControl.Refresh();
                    }
                }
                count++;
            }
        }

        private void HistoryMap_Load(object sender, EventArgs e)
        {
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
            txtCurrentValue.Text = dpFromDate.Value.ToString("dd/MM/yyyy HH:mm:ss");
            lblFromDate.Text = dpFromDate.Value.ToString("dd/MM/yyyy");
            lblToDate.Text = dpToDate.Value.ToString("dd/MM/yyyy");

            
        }

        private void btnSearchHistory_Click(object sender, EventArgs e)
        {
            ClearHistory();

            historyListMarker = new List<GMapMarker>(); historyListPolygon = new List<GMapPolygon>();
            historyListRoute = new List<GMapRoute>();
            var listSDT = txtSearchHistory.Text.Split(';');
            List<string> listArraySDT = new List<string>();
            foreach (var item in listSDT)
            {
                listArraySDT.Add(item.Trim());
            }
            listHistoryPosition = helper.GetListPositionByDate(listArraySDT.ToArray(), dpFromDate.Value, dpToDate.Value);
            var count = 1;
            foreach (var item in listArraySDT)
            {
                var listItem1 = listHistoryPosition.Where(m => m.MSISDN == item).ToList();
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
                    if (listItem1.Count > 1)
                    {
                        for (int i = 0; i < listItem1.Count - 1; i++)
                        {
                            GMapRoute line_layer = new GMapRoute("single_line");
                            line_layer.Stroke = new Pen(Brushes.Black, 2); //width and color of line

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
                           
                        }
                    }
                    mapControl.Refresh();
                }
                count++;
            }
            //var kkk = historyListRoute;
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            ClearHistory();
            listHistoryPosition = new List<Position>();
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

       
    }
}
