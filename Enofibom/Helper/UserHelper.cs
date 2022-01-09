using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enofibom.Helper
{
    public class UserHelper
    {
        DBHelper helper = new DBHelper();
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
                helper.InsertUser(newUser);
                var tempLog = new LogEvent
                {
                    EventDate = DateTime.Now,
                    User = userLoggedIn,
                    Task = "Add new user " + newUser.Username + ";IsAdmin:" + isAdmin + ";IsActive:" + isActive
                };
                await helper.InsertToLog(tempLog);
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
                    helper.UpdateUser(mem, isActive, isAdmin);    
                    var tempLog = new LogEvent
                    {
                        EventDate = DateTime.Now,
                        User = userLoggedIn,
                        Task = "Update user " + mem.Username + " info"
                    };
                    await helper.InsertToLog(tempLog);
                }
            }
            catch { }
        }
    }
}
