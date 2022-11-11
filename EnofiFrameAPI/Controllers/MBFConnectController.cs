using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

using System.Web.Http.Description;
using System.Xml.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Configuration;
using System.Configuration;

namespace EnofiFrameAPI.Controllers
{
    public class MBFConnectController : ApiController
    {

        LocationHelper helper = new LocationHelper();

        [HttpGet]
        [ActionName("CheckBalance")]
        public IHttpActionResult CheckBalance()
        {
            var atd = helper.callATD();
            return Ok(atd);
        }

        [HttpGet]
        [ActionName("GetLocation")]
        public IHttpActionResult GetLocation(string id)
        {
            var res = helper.CallSilentMessage(id);
            return Ok(res);
        }

        [HttpGet]
        [ActionName("ClosePort")]
        public IHttpActionResult Closeport()
        {
            return Ok("Closed");
        }


        [HttpGet]
        [ActionName("UpdateCommPort")]
        public IHttpActionResult UpdateCommPort(string port)
        {
            try
            {
                Configuration configuration = WebConfigurationManager.OpenWebConfiguration("~");
                AppSettingsSection appSettingsSection = (AppSettingsSection)configuration.GetSection("appSettings");
                KeyValueConfigurationCollection settings = appSettingsSection.Settings;
                settings["COMMPORT"].Value = port;
                configuration.Save();
                return Ok("Updated");
            }
            catch
            {
                return Ok("Update Failed");
            }
            
        }

        [HttpGet]
        [ActionName("ShowCommPort")]
        public IHttpActionResult ShowCommPort()
        {
            try
            {
                var val1 = ConfigurationManager.AppSettings["COMMPORT"];
                return Ok(val1);
            }
            catch
            {
                return Ok("Cannot show commport");
            }

        }

    }
}
