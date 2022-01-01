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
            mapControl.Zoom = 13;
            mapControl.ShowCenter = false;


            
            //int segments = 500;

            //List<PointLatLng> gpollist = new List<PointLatLng>();

            //for (int i = 0; i < segments; i++)
            //    gpollist.Add(FindPointAtDistanceFrom(point, i, 1130.89 / 1000));

            //GMapPolygon gpol = new GMapPolygon(gpollist, "pol");
            //GMapOverlay markers = new GMapOverlay("ABCDS");

            //markers.Polygons.Add(gpol);
            //mapControl.Overlays.Add(markers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var point = new PointLatLng(21.020440, 105.843650);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = "dfdfdf" + Environment.NewLine + "yriryri";
            marker.IsVisible = true;




            var point2 = new PointLatLng(21.016830, 105.855760);
            var markerLoduc = new GMarkerGoogle(point2, GMarkerGoogleType.blue_dot);
            markerLoduc.IsVisible = true;
            markerLoduc.ToolTipMode = MarkerTooltipMode.Always;
            markerLoduc.ToolTipText = "Lò Đúc" + Environment.NewLine + "Hà Nội";


            GMapOverlay markers = new GMapOverlay("ABCDS");
            //GMapOverlay overlayloduc = new GMapOverlay("ABCDfdfdfdS");
            mapControl.Overlays.Add(markers);
            //mapControl.Overlays.Add(overlayloduc);


            markers.Markers.Add(marker);
            markers.Markers.Add(markerLoduc);


            //PointLatLng point = new PointLatLng(lat, lon);
           
            var polygon1 = CreateCircle(point.Lat, point.Lng, 500, 2);
            var polygon2 = CreateCircle(point2.Lat, point2.Lng, 1200, 2);

            markers.Polygons.Add(polygon1);
            markers.Polygons.Add(polygon2);
            

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

    }
}
