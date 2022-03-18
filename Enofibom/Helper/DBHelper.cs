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
        public List<Position> ConvertToListPosition(List<MobiObject> listObject)
        {
            var listPos = new List<Position>();
            foreach(var item in listObject)
            {
                var pos = new Position
                {
                    CGI = item.CGI,
                    IMSI = item.IMSI,
                    Kind = item.Kind,
                    Lat = item.Lat, Lon = item.Lng, MSISDN = item.MSISDN, PlanName = item.PlanName,Radius = item.Radius
                };
                listPos.Add(pos);
            }
            return listPos;
        }
        public List<LogEvent> GetLogByDate(DateTime frDate, DateTime toDate)
        {
            var listEvent = new List<LogEvent>();
            using (MapOfflineEntities db = new MapOfflineEntities())
            {
                listEvent = db.LogEvents.Where(m=>m.Id > 0 && DbFunctions.TruncateTime(m.EventDate) >= DbFunctions.TruncateTime(frDate) && DbFunctions.TruncateTime(m.EventDate) <= DbFunctions.TruncateTime(toDate)).ToList();
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
        


        public List<Position> GetHistoryObject(string phone)
        {
            var listObject = new List<Position>();
            using (MapOfflineEntities db = new MapOfflineEntities())
            {
                listObject = db.Positions.Where(m => m.MSISDN == phone).ToList();
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


        
    }
}
