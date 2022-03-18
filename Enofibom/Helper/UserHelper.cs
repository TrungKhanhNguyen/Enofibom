using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enofibom.Helper
{
    public class UserHelper
    {
        //DBHelper helper = new DBHelper();
        MapOfflineEntities db = new MapOfflineEntities();

        public List<Member> GetAllMembers()
        {
            List<Member> listMem = new List<Member>();
            try
            {
                listMem = db.Members.ToList();
            }
            catch { }
            return listMem;
        }
        public Member GetUser(string username, string password)
        {
            Member mem = null;
            try
            {
                mem = db.Members.Where(m => m.Username == username && m.Password.ToLower() == password).FirstOrDefault();
            }
            catch { }
            return mem;
        }

        public async void AddUser(string username, bool isActive, bool isAdmin, string userLoggedIn)
        {
            try
            {
               
                var newUser = new Member
                {
                    Username = username,
                    Password = StaticKey.CreateMD5("123456"),
                    Active = isActive,
                    IsAdmin = isAdmin
                };
                using (MapOfflineEntities db = new MapOfflineEntities())
                {
                    db.Members.Add(newUser);
                    db.SaveChanges();
                }
                var tempLog = new LogEvent
                {
                    EventDate = DateTime.Now,
                    User = userLoggedIn,
                    Task = "Add new user " + newUser.Username + ";IsAdmin:" + isAdmin + ";IsActive:" + isActive
                };
                await DBHelper.InsertToLog(tempLog);
            }
            catch { }
        }

        public async void UpdateUser(List<Member> listMember,string idTarget, bool isActive, bool isAdmin, string userLoggedIn)
        {
            try
            {
                var id = Convert.ToInt32(idTarget);
                var mem = listMember.Where(m => m.Id == id).FirstOrDefault();
                if (mem != null)
                {
                    using (MapOfflineEntities db = new MapOfflineEntities())
                    {
                        db.Entry(mem).State = EntityState.Modified;
                        mem.IsAdmin = isAdmin;
                        mem.Active = isActive;
                        db.SaveChanges();
                    }
                    var tempLog = new LogEvent
                    {
                        EventDate = DateTime.Now,
                        User = userLoggedIn,
                        Task = "Update user " + mem.Username + " info"
                    };
                    await DBHelper.InsertToLog(tempLog);
                }
            }
            catch { }
        }

        public void UpdatePassword(int id, string newpassword)
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
    }
}
