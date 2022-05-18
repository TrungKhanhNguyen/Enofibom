using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Xml.Linq;

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

    }
}
