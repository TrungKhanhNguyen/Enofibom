using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task InsertToDB(MobiObject mobi)
        {
            await Task.Run(() =>
            {
                //
                using (MapOfflineEntities db = new MapOfflineEntities())
                {
                    var pos = new Position
                    {
                        CGI = mobi.CGI,
                        IMSI = mobi.IMSI,
                        Kind = mobi.Kind,
                        Lat = mobi.Lat,
                        Lon = mobi.Lng,
                        MSISDN = mobi.MSISDN,
                        PlanName = mobi.PlanName,
                        Radius = mobi.Radius,
                        RequestTime = DateTime.Now
                    };
                    db.Positions.Add(pos);
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

        public void InsertSyncToDB(Position mobi)
        {
            try
            {
                using (MapOfflineEntities db = new MapOfflineEntities())
                {
                    db.Positions.Add(mobi);
                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }
    }
}
