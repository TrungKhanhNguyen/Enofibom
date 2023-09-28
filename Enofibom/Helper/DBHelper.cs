using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Enofibom.Helper
{
    public class DBHelper
    {
        public MapOfflineEntities db = new MapOfflineEntities();
        
        public List<LogEvent> GetRecentLogs()
        {
            var listEvent = new List<LogEvent>();
            using (MapOfflineEntities db = new MapOfflineEntities())
            {
                listEvent = db.LogEvents.OrderByDescending(m => m.EventDate).Take(100).ToList();
            }
                return listEvent;
        }
        public List<LogEvent> GetLogByDate(DateTime frDate, DateTime toDate, string username)
        {
            var listEvent = new List<LogEvent>();
            using (MapOfflineEntities db = new MapOfflineEntities())
            {
                if (username == "All user")
                {
                    listEvent = db.LogEvents.Where(m => m.Id > 0 && DbFunctions.TruncateTime(m.EventDate) >= DbFunctions.TruncateTime(frDate) && DbFunctions.TruncateTime(m.EventDate) <= DbFunctions.TruncateTime(toDate)).ToList();
                }
                else
                {
                    listEvent = db.LogEvents.Where(m => m.Id > 0 && m.User == username && DbFunctions.TruncateTime(m.EventDate) >= DbFunctions.TruncateTime(frDate) && DbFunctions.TruncateTime(m.EventDate) <= DbFunctions.TruncateTime(toDate)).ToList();
                }
                
            }
            return listEvent;
        }

        public static async Task InsertToLog(LogEvent eventLog)
        {
            await Task.Run(() =>
            {
                //
                using (MapOfflineEntities db = new MapOfflineEntities())
                {
                    db.LogEvents.Add(eventLog);
                    db.SaveChanges();
                }
            });
        }

        public async Task InsertPositionToDB(Position mobi)
        {
            await Task.Run(() =>
             {
                //
                using (MapOfflineEntities db = new MapOfflineEntities())
                 {
                     db.Positions.Add(mobi);
                     db.SaveChanges();
                 }
             });
        }

        public string ConvertPhoneNumber(string phone)
        {
            var temp = phone.Substring(0, 2);
            if (temp != "84")
            {
                var returnPhone = "84" + phone.Substring(1);
                return returnPhone;
            }
            return phone;
        }

        public List<Position> GetHistoryObject(string phone)
        {
            var listObject = new List<Position>();
            using (MapOfflineEntities db = new MapOfflineEntities())
            {
                listObject = db.Positions.Where(m => m.MSISDN == phone).ToList();
            }
            return listObject;
        }
        public List<Position> GetListPositionByDate(DateTime fromDate, DateTime toDate)
        {
            var listObject = new List<Position>();
            var frDate = fromDate;
            var tDate = toDate;
            using (MapOfflineEntities db = new MapOfflineEntities())
            {
                listObject = db.Positions.Where(m => m.eventStamp >= frDate
                                                    && m.eventStamp <= tDate).ToList();
            }
            return listObject;
        }

        public List<Position> GetListPositionByDate(string[] listNumber, DateTime fromDate,DateTime toDate)
        {
            
            var listObject = new List<Position>();
            //var listAllDate =
            var frDate = fromDate;
            var tDate = toDate;
            using (MapOfflineEntities db = new MapOfflineEntities())
            {
                listObject = db.Positions.Where(m=> listNumber.Contains(m.MSISDN) == true && m.eventStamp >= frDate 
                                                    && m.eventStamp <= tDate).ToList();
            }
            return listObject;
        }

        public Position GetPositionObjectByContentReponse(string response)
        {
            try
            {
                string imsi, msisdn, longitude, latitude, radius, cgi, kind, anglestart, angleend, planName, presence, presentFlag, disappearedFlag;
                imsi = msisdn = longitude = latitude = radius = cgi = kind = anglestart = angleend = planName = presence = presentFlag = disappearedFlag = "";
                //string currLat, currLon;
                //currLat = currLon = "";
                XElement root = XElement.Parse(response);
                var currLocation = root.Descendants().Where(m => m.Name.LocalName.ToString() == "currLocation").FirstOrDefault();
                var prevNode = root.Descendants().Where(m => m.Name.LocalName.ToString() == "prevLocation").FirstOrDefault();

                var currLatObject = currLocation.Descendants("latitude").FirstOrDefault();
                var currLonObject = currLocation.Descendants("longitude").FirstOrDefault();
                XElement node;
                if (currLatObject != null && currLonObject != null)
                {
                    node = currLocation;

                    var currLat = currLocation.Descendants("latitude").FirstOrDefault().Value;
                    var currLon = currLocation.Descendants("longitude").FirstOrDefault().Value;

                    if (GetLastCharacter(currLat, 4) != "0000" && GetLastCharacter(currLon, 4) != "0000")
                    {
                        node = currLocation;
                    }
                    else
                    {
                        node = prevNode;
                    }
                }
                else
                {
                    node = prevNode;
                }
                
                imsi = root.Descendants("imsi").FirstOrDefault().Value;
                msisdn = root.Descendants("msisdn").FirstOrDefault().Value;

                DateTime eventStamp = new DateTime(); DateTime locStamp = new DateTime();

                cgi = node.Descendants("cgi").FirstOrDefault() == null ? string.Empty : node.Descendants("cgi").FirstOrDefault().Value;
                kind = node.Descendants("kind").FirstOrDefault() == null ? string.Empty : node.Descendants("kind").FirstOrDefault().Value;
                latitude = node.Descendants("latitude").FirstOrDefault() == null ? string.Empty : node.Descendants("latitude").FirstOrDefault().Value;
                longitude = node.Descendants("longitude").FirstOrDefault() == null ? string.Empty : node.Descendants("longitude").FirstOrDefault().Value;
                radius = node.Descendants("radius").FirstOrDefault() == null ? string.Empty : node.Descendants("radius").FirstOrDefault().Value;
                planName = node.Descendants("planName").FirstOrDefault() == null ? string.Empty : node.Descendants("planName").FirstOrDefault().Value;
                anglestart = node.Descendants("angleStart").FirstOrDefault() == null ? string.Empty : node.Descendants("angleStart").FirstOrDefault().Value;
                angleend = node.Descendants("angleEnd").FirstOrDefault() == null ? string.Empty : node.Descendants("angleEnd").FirstOrDefault().Value;

                presence = node.Descendants("presence").FirstOrDefault() == null ? string.Empty : node.Descendants("presence").FirstOrDefault().Value;
                presentFlag = node.Descendants("presentFlag").FirstOrDefault() == null ? string.Empty : node.Descendants("presentFlag").FirstOrDefault().Value;
                disappearedFlag = node.Descendants("disappearedFlag").FirstOrDefault() == null ? string.Empty : node.Descendants("disappearedFlag").FirstOrDefault().Value;


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
                        //eventStamp = eventStamp,
                        //locStamp = locStamp,
                        Presence = presence,
                        PresentFlag = presentFlag,
                        DisappearedFlag = disappearedFlag
                    };

                    var eventStampStr = node.Descendants("eventStamp").FirstOrDefault() == null ? string.Empty : node.Descendants("eventStamp").FirstOrDefault().Value;
                    var locStampStr = node.Descendants("locStamp").FirstOrDefault() == null ? string.Empty : node.Descendants("locStamp").FirstOrDefault().Value;
                    if (!String.IsNullOrEmpty(eventStampStr))
                    {
                        eventStamp = UnixTimeStampToDateTime(Convert.ToDouble(eventStampStr));
                        mobi.eventStamp = eventStamp;
                    }
                    if (!String.IsNullOrEmpty(locStampStr))
                    {
                        locStamp = UnixTimeStampToDateTime(Convert.ToDouble(locStampStr));
                        mobi.locStamp = locStamp;
                    }
                        
                    return mobi;
                }
                return null;
            }
            catch { return null; }

        }

        public Position GetObjectStampInfo(string response)
        {
            try
            {
                string imsi, msisdn, presence, presentFlag, disappearedFlag;
                imsi = msisdn = presence = presentFlag = disappearedFlag = "";
                //string currLat, currLon;
                //currLat = currLon = "";
                XElement root = XElement.Parse(response);
                var currLocation = root.Descendants().Where(m => m.Name.LocalName.ToString() == "currLocation").FirstOrDefault();
                var prevNode = root.Descendants().Where(m => m.Name.LocalName.ToString() == "prevLocation").FirstOrDefault();

                var currLatObject = currLocation.Descendants("latitude").FirstOrDefault();
                var currLonObject = currLocation.Descendants("longitude").FirstOrDefault();
                XElement node;
            
                    node = currLocation;

                   

                imsi = root.Descendants("imsi").FirstOrDefault().Value;
                msisdn = root.Descendants("msisdn").FirstOrDefault().Value;

                DateTime eventStamp = new DateTime(); DateTime locStamp = new DateTime();

                presence = node.Descendants("presence").FirstOrDefault() == null ? string.Empty : node.Descendants("presence").FirstOrDefault().Value;
                presentFlag = node.Descendants("presentFlag").FirstOrDefault() == null ? string.Empty : node.Descendants("presentFlag").FirstOrDefault().Value;
                disappearedFlag = node.Descendants("disappearedFlag").FirstOrDefault() == null ? string.Empty : node.Descendants("disappearedFlag").FirstOrDefault().Value;
                
                var mobi = new Position
                {
                    IMSI = imsi,
                    MSISDN = msisdn,
                    //eventStamp = eventStamp,
                    //locStamp = locStamp,
                    Presence = presence,
                    PresentFlag = presentFlag,
                    DisappearedFlag = disappearedFlag
                };

                var eventStampStr = node.Descendants("eventStamp").FirstOrDefault() == null ? string.Empty : node.Descendants("eventStamp").FirstOrDefault().Value;
                var locStampStr = node.Descendants("locStamp").FirstOrDefault() == null ? string.Empty : node.Descendants("locStamp").FirstOrDefault().Value;
                if (!String.IsNullOrEmpty(eventStampStr))
                {
                    eventStamp = UnixTimeStampToDateTime(Convert.ToDouble(eventStampStr));
                    mobi.eventStamp = eventStamp;
                }
                if (!String.IsNullOrEmpty(locStampStr))
                {
                    locStamp = UnixTimeStampToDateTime(Convert.ToDouble(locStampStr));
                    mobi.locStamp = locStamp;
                }

                return mobi;
                
                //return null;
            }
            catch { return null; }
        }

        public Position GetObjectLocationInfo(string response)
        {
            try
            {
                string imsi, msisdn, longitude, latitude, radius, cgi, kind, anglestart, angleend, planName;
                imsi = msisdn = longitude = latitude = radius = cgi = kind = anglestart = angleend = planName = "";
                //string currLat, currLon;
                //currLat = currLon = "";
                XElement root = XElement.Parse(response);
                var currLocation = root.Descendants().Where(m => m.Name.LocalName.ToString() == "currLocation").FirstOrDefault();
                var prevNode = root.Descendants().Where(m => m.Name.LocalName.ToString() == "prevLocation").FirstOrDefault();


                var currLatObject = currLocation.Descendants("latitude").FirstOrDefault();
                var currLonObject = currLocation.Descendants("longitude").FirstOrDefault();

                var currCGI = currLocation.Descendants("cgi").FirstOrDefault();

                XElement node;
                //if (currLatObject != null && currLonObject != null)
                //{
                //    node = currLocation;

                //    var currLat = currLocation.Descendants("latitude").FirstOrDefault().Value;
                //    var currLon = currLocation.Descendants("longitude").FirstOrDefault().Value;

                //    if (GetLastCharacter(currLat, 4) != "0000" && GetLastCharacter(currLon, 4) != "0000")
                //    {
                //        node = currLocation;
                //    }
                //    else
                //    {
                //        node = prevNode;
                //    }
                //}
                if (currCGI != null)
                {
                    node = currLocation;

                }
                else
                {
                    node = prevNode;
                }

                imsi = root.Descendants("imsi").FirstOrDefault().Value;
                msisdn = root.Descendants("msisdn").FirstOrDefault().Value;

                DateTime eventStamp = new DateTime(); DateTime locStamp = new DateTime();
                cgi = node.Descendants("cgi").FirstOrDefault() == null ? string.Empty : node.Descendants("cgi").FirstOrDefault().Value;
                kind = node.Descendants("kind").FirstOrDefault() == null ? string.Empty : node.Descendants("kind").FirstOrDefault().Value;
                latitude = node.Descendants("latitude").FirstOrDefault() == null ? string.Empty : node.Descendants("latitude").FirstOrDefault().Value;
                longitude = node.Descendants("longitude").FirstOrDefault() == null ? string.Empty : node.Descendants("longitude").FirstOrDefault().Value;
                radius = node.Descendants("radius").FirstOrDefault() == null ? string.Empty : node.Descendants("radius").FirstOrDefault().Value;
                planName = node.Descendants("planName").FirstOrDefault() == null ? string.Empty : node.Descendants("planName").FirstOrDefault().Value;
                anglestart = node.Descendants("angleStart").FirstOrDefault() == null ? string.Empty : node.Descendants("angleStart").FirstOrDefault().Value;
                angleend = node.Descendants("angleEnd").FirstOrDefault() == null ? string.Empty : node.Descendants("angleEnd").FirstOrDefault().Value;

                //if (!String.IsNullOrEmpty(latitude) && !String.IsNullOrEmpty(longitude))
                //{
                    var tempLong = ""; var tempLat = "";
                    tempLat = string.IsNullOrEmpty(latitude) == true ? "" : latitude.Insert(2, ".");
                    tempLong = string.IsNullOrEmpty(longitude) == true ? "" : longitude.Insert(3, ".");
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
                    };

                    var eventStampStr = node.Descendants("eventStamp").FirstOrDefault() == null ? string.Empty : node.Descendants("eventStamp").FirstOrDefault().Value;
                    var locStampStr = node.Descendants("locStamp").FirstOrDefault() == null ? string.Empty : node.Descendants("locStamp").FirstOrDefault().Value;
                    if (!String.IsNullOrEmpty(eventStampStr))
                    {
                        eventStamp = UnixTimeStampToDateTime(Convert.ToDouble(eventStampStr));
                        mobi.eventStamp = eventStamp;
                    }
                    if (!String.IsNullOrEmpty(locStampStr))
                    {
                        locStamp = UnixTimeStampToDateTime(Convert.ToDouble(locStampStr));
                        mobi.locStamp = locStamp;
                    }
                    return mobi;
                //}
                //return null;
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
