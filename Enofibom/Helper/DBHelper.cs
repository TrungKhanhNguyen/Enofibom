using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public List<LogEvent> GetLogByDate(DateTime frDate, DateTime toDate)
        {
            var listEvent = new List<LogEvent>();
            using (MapOfflineEntities db = new MapOfflineEntities())
            {
                listEvent = db.LogEvents.Where(m=>m.Id > 0 && DbFunctions.TruncateTime(m.EventDate) >= DbFunctions.TruncateTime(frDate) && DbFunctions.TruncateTime(m.EventDate) <= DbFunctions.TruncateTime(toDate)).ToList();
            }
            return listEvent;
        }

        public void InsertUser(Member member)
        {
            using (MapOfflineEntities db = new MapOfflineEntities())
            {
                db.Members.Add(member);
                db.SaveChanges();
            }
        }

        public void UpdateUser(Member member,bool isActive, bool isAdmin)
        {
            using (MapOfflineEntities db = new MapOfflineEntities())
            {
                db.Entry(member).State = EntityState.Modified;
                member.IsAdmin = isAdmin;
                member.Active = isActive;
                db.SaveChanges();
            }
        }

        public List<Member> GetAllMember()
        {
            var listMember = new List<Member>();
            using (MapOfflineEntities db = new MapOfflineEntities())
            {
                listMember = db.Members.ToList();
            }
            return listMember;
        }

        public void UpdatePassword(int id,string newpassword)
        {
            using (MapOfflineEntities db = new MapOfflineEntities())
            {
                var tempTarget = db.Members.Where(m => m.Id == id).FirstOrDefault();
                if (tempTarget != null)
                {
                   
                    tempTarget.Password = newpassword;
                    db.SaveChanges();
                }
            }
        }

        public Member GetUserLogin(string username, string password)
        {
            Member user = null;
            using (MapOfflineEntities db = new MapOfflineEntities())
            {
                var item = db.Members.Where(m => m.Username == username && m.Password == password && m.Active == true).FirstOrDefault();
                if (item != null)
                    user = item;
            }
            return user;
        }

        public async Task InsertToLog(LogEvent eventLog)
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
                listObject = db.Positions.Where(m=> listNumber.Contains(m.MSISDN) == true && m.RequestTime >= frDate 
                                                    && m.RequestTime <= tDate).ToList();
            }
            return listObject;
        }


        #region[Target]
        public List<Target> GetAllTarget()
        {
            var listTarget = new List<Target>();
            using (MapOfflineEntities db = new MapOfflineEntities())
            {
                listTarget = db.Targets.ToList();
            }
            return listTarget;
        }

        public List<Target> GetAllActiveTarget()
        {
            var listTarget = new List<Target>();
            using (MapOfflineEntities db = new MapOfflineEntities())
            {
                listTarget = db.Targets.Where(m=>m.IsActive == true).ToList();
            }
            return listTarget;
        }

        public void InsertTarget(Target target)
        {
            using (MapOfflineEntities db = new MapOfflineEntities())
            {
                db.Targets.Add(target);
                db.SaveChanges();
            }
        }
        public void UpdateTarget(Target target, string targetName, string IMSI, string IMEI, bool isActive)
        {
            using (MapOfflineEntities db = new MapOfflineEntities())
            {
                var tempTarget = db.Targets.Where(m => m.Id == target.Id).FirstOrDefault();
                if (tempTarget != null)
                {
                    tempTarget.IsActive = isActive;
                    tempTarget.IMEI = IMEI;
                    tempTarget.IMSI = IMSI;
                    tempTarget.TargetName = targetName;
                    db.SaveChanges();
                }
                
               
                
            }
        }

        public void DeleteTarget(Target target)
        {
            using (MapOfflineEntities db = new MapOfflineEntities())
            {
                db.Targets.Remove(target);
                db.SaveChanges();
            }
        }

        #endregion
    }
}
