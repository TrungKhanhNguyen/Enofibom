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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enofibom
{
    public partial class Form1 : Form
    {
        GMapOverlay overlay = new GMapOverlay("ABCDS");
        List<MobiObject> listObject = new List<MobiObject>();
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            mapControl.MapProvider = GMapProviders.GoogleMap;
            var point = new PointLatLng(21.020440, 105.843650);
            
            mapControl.Position = point;

            mapControl.DragButton = MouseButtons.Left;

            mapControl.MinZoom = 5; 
            mapControl.MaxZoom = 22;
            mapControl.Zoom = 11;
            mapControl.ShowCenter = false;

            //DrawLine();

        }

     

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listObject = new List<MobiObject>();
            var test1 = new MobiObject
            {
                IMSI = "452019907817978",
                MSISDN = "84907055468",
                CGI = "4G:452-01-101175-11",
                Kind = "C4G",
                AngleStart = "",
                AngleEnd = "",
                Lat = "21051360",
                Lng = "105744430",
                PlanName="GSM",
                Radius="1000"
               
            };

            var test2 = new MobiObject
            {
                IMSI = "452019939362924",
                MSISDN = "84904500084",
                CGI = "452-01-10050-14241",
                Kind = "C2G",
                AngleStart = "",
                AngleEnd = "",
                Lat = "21020440",
                Lng = "105843650",
                PlanName = "GSM",
                Radius = "500"
                
            };
            listObject.Add(test1);
            listObject.Add(test2);
            dataGrid1.AutoGenerateColumns = false;
            dataGrid1.DataSource = listObject;

            
            gunaDataGrid.DataSource = listObject;
            gunaDataGrid.AutoGenerateColumns = false;

            gunaDataGrid.Columns.Remove("Kind");
            //gunaDataGrid.Columns["Kind"].Visible = false;

            gunaDataGrid.Columns.Remove("CGI");
            gunaDataGrid.Columns.Remove("IMSI");
            gunaDataGrid.Columns.Remove("PlanName");
            gunaDataGrid.Columns.Remove("Radius");
            gunaDataGrid.Columns.Remove("AngleStart");
            gunaDataGrid.Columns.Remove("AngleEnd");
            //gunaDataGrid.Columns["CGI"].Visible = false;


            mapControl.Overlays.Add(overlay);

            foreach (var item in listObject)
            {
                var marker1 = GetMarkerFromData(item);
                var poly = GetPolygonFromData(item);
                if (marker1!=null)
                    overlay.Markers.Add(marker1);
                if (poly != null)
                    overlay.Polygons.Add(poly);

            }
         
        }

        private GMapMarker GetMarkerFromData(MobiObject temp)
        {
            try
            {
                var tempLat = temp.Lat.Insert(2, ".");
                var tempLng = temp.Lng.Insert(3, ".");
                var realLat = Convert.ToDouble(tempLat);
                var realLng = Convert.ToDouble(tempLng);
                var rad = Convert.ToDouble(temp.Radius);
                var tooltiptext = Environment.NewLine + "IMSI=" + temp.IMSI + "; MSISDN=" + temp.MSISDN + Environment.NewLine +
                    ";CGI=" + temp.CGI + "; Kind=" + temp.Kind + Environment.NewLine +
                    "; Lat=" + temp.Lat + "; Lon=" + temp.Lng + "; Radius=" + temp.Radius;

                var point = new PointLatLng(realLat, realLng);
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = tooltiptext;
                marker.IsVisible = true;
            
                return marker;
            }
            catch
            {
                return null;
            }
            
        }


        private GMapPolygon GetPolygonFromData(MobiObject temp)
        {
            try
            {
                var tempLat = temp.Lat.Insert(2, ".");
                var tempLng = temp.Lng.Insert(3, ".");
                var realLat = Convert.ToDouble(tempLat);
                var realLng = Convert.ToDouble(tempLng);
                var rad = Convert.ToDouble(temp.Radius);
                var polygon1 = CreateCircle(realLat, realLng, rad, 2);
                return polygon1;
            }
            catch
            {
                return null;
            }
            
        }

        private void RefreshMap()
        {
            //mapControl.Zoom = -13;
            //mapControl.Zoom = 13;
            mapControl.Refresh();
        }

        private GMapPolygon CreateCircle(Double lat, Double lon, double radius, int ColorIndex)
        {
            PointLatLng point = new PointLatLng(lat, lon);
            int segments = 1080;

            List<PointLatLng> gpollist = new List<PointLatLng>();

            for (int i = 0; i < segments; i++)
            {
                gpollist.Add(FindPointAtDistanceFrom(point, i * (Math.PI / 180), radius / 1000));
            }

            GMapPolygon polygon = new GMapPolygon(gpollist, "Circle");
            switch (ColorIndex)
            {

                case 1:
                    polygon.Fill = new SolidBrush(Color.FromArgb(65, Color.Red));
                    break;
                case 2:
                    polygon.Fill = new SolidBrush(Color.FromArgb(65, Color.Gray));
                    break;
                case 3:
                    polygon.Fill = new SolidBrush(Color.FromArgb(20, Color.Aqua));
                    break;
                default:
                    MessageBox.Show("No search zone found!");
                    break;
            }


            polygon.Stroke = new Pen(Color.Gray, 1);
            return polygon;
        }


        public static GMap.NET.PointLatLng FindPointAtDistanceFrom(GMap.NET.PointLatLng startPoint, double initialBearingRadians, double distanceKilometres)
        {
            const double radiusEarthKilometres = 6371.01;
            var distRatio = distanceKilometres / radiusEarthKilometres;
            var distRatioSine = Math.Sin(distRatio);
            var distRatioCosine = Math.Cos(distRatio);

            var startLatRad = DegreesToRadians(startPoint.Lat);
            var startLonRad = DegreesToRadians(startPoint.Lng);

            var startLatCos = Math.Cos(startLatRad);
            var startLatSin = Math.Sin(startLatRad);

            var endLatRads = Math.Asin((startLatSin * distRatioCosine) + (startLatCos * distRatioSine * Math.Cos(initialBearingRadians)));
            var endLonRads = startLonRad + Math.Atan2(Math.Sin(initialBearingRadians) * distRatioSine * startLatCos, distRatioCosine - startLatSin * Math.Sin(endLatRads));

            return new GMap.NET.PointLatLng(RadiansToDegrees(endLatRads), RadiansToDegrees(endLonRads));
        }

        public static double DegreesToRadians(double degrees)
        {
            const double degToRadFactor = Math.PI / 180;
            return degrees * degToRadFactor;
        }

        public static double RadiansToDegrees(double radians)
        {
            const double radToDegFactor = 180 / Math.PI;
            return radians * radToDegFactor;
        }



        public static double DistanceTwoPoint(double startLat, double startLong, double endLat, double endLong)
        {

            var startPoint = new GeoCoordinate(startLat, startLong);
            var endPoint = new GeoCoordinate(endLat, endLong);

            return startPoint.GetDistanceTo(endPoint);
        }

        private void guna2CustomCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (mapControl.Overlays.Count > 0)
            {
                mapControl.Overlays.RemoveAt(0);
                mapControl.Refresh();
            }
                
        }

        private void dataGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                
                var valuelat = listObject[e.RowIndex].Lat;
                var valuelng = listObject[e.RowIndex].Lng;
                if (!String.IsNullOrEmpty(valuelat)&& !String.IsNullOrEmpty(valuelng))
                {
                    var tempLat = valuelat.Insert(2, ".");
                    var tempLng = valuelng.Insert(3, ".");
                    var realLat = Convert.ToDouble(tempLat);
                    var realLng = Convert.ToDouble(tempLng);
                    //lat = Convert.ToDouble(valuelat);
                    //lng = Convert.ToDouble(valuelng);

                    mapControl.Position = new PointLatLng(realLat, realLng);
                }
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
    }
}
