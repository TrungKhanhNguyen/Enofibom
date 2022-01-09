using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enofibom.Helper
{
    public class TargetHelper
    {
        DBHelper helper = new DBHelper();
        private int countListActive(List<Target> listTarget)
        {
            var tempList = listTarget.Where(m => m.IsActive == true).ToList();
            if (tempList != null)
                return tempList.Count();
            return 0;
        }
        public void AddTarget(List<Target> listTarget, string MSISDN, string name, string IMSI, string IMEI, bool isActive,string userLoggedIn)
        {
            try
            {
                
                var target = new Target
                {
                    IMEI = IMEI,
                    IMSI = IMSI,
                    IsActive = isActive,
                    MSISDN = MSISDN,
                    TargetName = name
                };
                if (!isActive || (countListActive(listTarget) < 500))
                {
                    helper.InsertTarget(target);
                    var tempLog = new LogEvent
                    {
                        EventDate = DateTime.Now,
                        User = userLoggedIn,
                        Task = "Add new target " + target.MSISDN + ", Target name " + name + ", IMEI " + IMEI +
                        ", IMSI " + IMSI + ", IsActive " + isActive
                    };
                    helper.InsertToLog(tempLog);
                }
            }
            catch { }
        }

        public void SaveTarget(List<Target> listTarget,string idTarget, string name, string IMSI, string IMEI, bool isActive, string userLoggedIn)
        {
            try
            {
                var id = Convert.ToInt32(idTarget);
                var mem = listTarget.Where(m => m.Id == id).FirstOrDefault();
                if (mem != null)
                {
                    if (!isActive || (countListActive(listTarget) < 500))
                    {
                        helper.UpdateTarget(mem, name,IMSI,IMEI,isActive);
                        

                        var tempLog = new LogEvent
                        {
                            EventDate = DateTime.Now,
                            User = userLoggedIn,
                            Task = "Edit target " + mem.MSISDN + ", Target name " + name + ", IMEI " + IMEI +
                            ", IMSI " + IMSI + ", IsActive " + isActive
                        };
                        helper.InsertToLog(tempLog);
                    }
                }
            }
            catch { }
        }

        public void DeleteTarget(List<Target> listTarget, string idTarget, string userLoggedIn)
        {
            try
            {
                var id = Convert.ToInt32(idTarget);
                var target = listTarget.Where(m => m.Id == id).FirstOrDefault();
                if (target != null)
                {
                    helper.DeleteTarget(target);
                    
                    var tempLog = new LogEvent
                    {
                        EventDate = DateTime.Now,
                        User = userLoggedIn,
                        Task = "Delete target " + target.MSISDN
                    };
                    helper.InsertToLog(tempLog);
                }
            }
            catch { }
        }
    }
}
