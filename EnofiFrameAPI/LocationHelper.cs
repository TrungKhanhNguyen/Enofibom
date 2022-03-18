using EnofiFrameAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace EnofiFrameAPI
{
    public class LocationHelper
    {
        public Position GetPositionObjectByContentReponse(string response)
        {
            try
            {
                string imsi, msisdn, longitude, latitude, radius, cgi, kind, anglestart, angleend, planName;
                imsi = msisdn = longitude = latitude = radius = cgi = kind = anglestart = angleend = planName = "";

                XElement root = XElement.Parse(response);
                var currLocation = root.Descendants().Where(m => m.Name.LocalName.ToString() == "currLocation").FirstOrDefault();
                var prevNode = root.Descendants().Where(m => m.Name.LocalName.ToString() == "prevLocation").FirstOrDefault();

                var currLat = currLocation.Descendants("latitude").FirstOrDefault().Value;
                var currLon = currLocation.Descendants("longitude").FirstOrDefault().Value;
                var currRadius = currLocation.Descendants("radius").FirstOrDefault().Value;

                imsi = root.Descendants("imsi").FirstOrDefault().Value;
                msisdn = root.Descendants("msisdn").FirstOrDefault().Value;

                DateTime eventStamp = new DateTime(); DateTime locStamp = new DateTime();
                if (!String.IsNullOrEmpty(currLat) && !String.IsNullOrEmpty(currLon))
                {
                    XElement node;
                    if (GetLastCharacter(currLat, 4) != "0000" && GetLastCharacter(currLon, 4) != "0000")
                    {
                        node = currLocation;
                    }
                    else
                    {
                        node = prevNode;
                    }
                    cgi = node.Descendants("cgi").FirstOrDefault().Value;
                    kind = node.Descendants("kind").FirstOrDefault().Value;
                    latitude = node.Descendants("latitude").FirstOrDefault().Value;
                    longitude = node.Descendants("longitude").FirstOrDefault().Value;
                    radius = node.Descendants("radius").FirstOrDefault().Value;
                    planName = node.Descendants("planName").FirstOrDefault().Value;
                    anglestart = node.Descendants("angleStart").FirstOrDefault().Value;
                    angleend = node.Descendants("angleEnd").FirstOrDefault().Value;
                    var eventStampStr = node.Descendants("eventStamp").FirstOrDefault().Value;
                    var locStampStr = node.Descendants("locStamp").FirstOrDefault().Value;
                    eventStamp = UnixTimeStampToDateTime(Convert.ToDouble(eventStampStr));
                    locStamp = UnixTimeStampToDateTime(Convert.ToDouble(locStampStr));
                }


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
                        eventStamp = eventStamp,
                        locStamp = locStamp
                    };
                    return mobi;
                }
                return null;
            }
            catch { return null; }

        }
        public string GetLastCharacter(string source, int length)
        {
            if (length >= source.Length)
                return source;
            return source.Substring(source.Length - length);
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }

    }
}