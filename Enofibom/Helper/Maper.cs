using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Enofibom.Helper
{
    public class Maper
    {
        

        public GMapMarker GetMarkerFromData(Position temp, int numbers)
        {
            try
            {
                var tempLat = temp.Lat;
                var tempLng = temp.Lon;
                var realLat = Convert.ToDouble(tempLat);
                var realLng = Convert.ToDouble(tempLng);
                var rad = Convert.ToDouble(temp.Radius);
                var tooltiptext = Environment.NewLine + "IMSI=" + temp.IMSI + "; MSISDN=" + temp.MSISDN + Environment.NewLine +
                    ";CGI=" + temp.CGI + "; Kind=" + temp.Kind + Environment.NewLine +
                    "; Lat=" + temp.Lat + "; Lon=" + temp.Lon + "; Radius=" + temp.Radius + "; Req Time=" + temp.RequestTime?.ToString("dd/MM/yyyy HH:mm:ss");

                var point = new PointLatLng(realLat, realLng);
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
                switch (numbers)
                {
                    case 2: marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot); break;
                    case 3: marker = new GMarkerGoogle(point, GMarkerGoogleType.orange_dot); break;
                    case 4: marker = new GMarkerGoogle(point, GMarkerGoogleType.green_dot); break;
                    case 5: marker = new GMarkerGoogle(point, GMarkerGoogleType.pink_dot); break;
                    case 6: marker = new GMarkerGoogle(point, GMarkerGoogleType.purple_dot); break;
                    case 7: marker = new GMarkerGoogle(point, GMarkerGoogleType.lightblue_dot); break;
                }

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
        public GMapPolygon GetPolygonFromData(Position temp)
        {
            try
            {
                var tempLat = temp.Lat;
                var tempLng = temp.Lon;
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



        public GMapPolygon CreateCircle(Double lat, Double lon, double radius, int ColorIndex)
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

        private void DrawLine(GMapControl mapControl)
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
            //line_layer.Points.Add(new PointLatLng(21.016830, 105.855760));
            line_layer.Points.Add(new PointLatLng(21.001930, 105.846558));

            //To force the draw, you need to update the route
            mapControl.UpdateRouteLocalPosition(line_layer);

            
        }
    }
}
