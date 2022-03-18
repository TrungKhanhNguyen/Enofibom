using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        [ActionName("GetLocation")]
        public async Task<IHttpActionResult> GetLocation(string id)
        {
            var url = StaticKey.requestPositionUrl;
            try
            {
                var handler = new HttpClientHandler() { };
                using (var httpClient = new HttpClient(handler)
                {
                    BaseAddress = new Uri(url),
                    Timeout = new TimeSpan(0, 2, 0)
                })
                {
                    var inputBody = "<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:v1='http://schema.intersec.com/igloo/sdk/v1.2'><soapenv:Header/><soapenv:Body><v1:pull.retrieveV3Req><args><params><filter><msisdn><explicit><kind>2</kind>"
                    + "<m>" + id.Trim() + "</m>"
                    + "</explicit></msisdn></filter><options><subscriberFields>msisdn</subscriberFields><subscriberFields>imsi</subscriberFields><locationFields>location</locationFields><locationFields>event</locationFields><locationFields>eventStamp</locationFields><locationFields>locStamp</locationFields></options></params></args></v1:pull.retrieveV3Req></soapenv:Body></soapenv:Envelope>";

                    var httpContent = new StringContent(inputBody, Encoding.UTF8, "application/xml");
                    var request = new HttpRequestMessage();
                    request.Method = HttpMethod.Post;
                    request.RequestUri = new Uri(url);
                    request.Content = httpContent;
                    request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/xml");


                    var byteArray = Encoding.ASCII.GetBytes("tctk_api:$5$rounds=5000$bbf460274ac2fcd8$u0raxguDBJcCDUWKabiHX0LXjxuTszOnUJlZhqGXFQ2");
                    httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                    httpClient.DefaultRequestHeaders.Add("MobifoneKey", "74a5c84c-f2c3-4bbd-9819-5958094d604e");

                    //var responseMessage = await httpClient.SendAsync(request);
                    var contentReponse = "";
                    using (HttpResponseMessage responseMessage = await httpClient.SendAsync(request))
                    using (HttpContent content = responseMessage.Content)
                    {
                        if (responseMessage.StatusCode == HttpStatusCode.OK)
                        {
                            contentReponse = content.ReadAsStringAsync().Result;
                        }
                    }
                    //await Task.When
                    if (!String.IsNullOrEmpty(contentReponse))
                    {
                        var mobi = helper.GetPositionObjectByContentReponse(contentReponse);
                        return Ok(mobi);
                    }
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
        [HttpGet]
        [ActionName("GetIMEI")]
        public async Task<IHttpActionResult> GetIMEI(string id)
        {
            var urlIMEI = StaticKey.requestIMEIUrl;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("MobifoneKey", "74a5c84c-f2c3-4bbd-9819-5958094d604e");
                    var contentReponse = "";
                    using (HttpResponseMessage responseMessage = await client.GetAsync(urlIMEI + id.Trim()))
                    using (HttpContent content = responseMessage.Content)
                    {
                        if (responseMessage.StatusCode == HttpStatusCode.OK)
                        {
                            contentReponse = content.ReadAsStringAsync().Result;
                        }
                    }
                    if (!String.IsNullOrEmpty(contentReponse))
                    {
                        string imei, msisdn;
                        imei = msisdn = "";
                        XElement xml = XElement.Parse(contentReponse);
                        if (xml.Descendants("parm").Where(x => x.Attribute("name").Value == "sub.imei").FirstOrDefault() != null)
                            imei = xml.Descendants("parm").Where(x => x.Attribute("name").Value == "sub.imei").FirstOrDefault().Attribute("value").Value;

                        if (xml.Descendants("parm").Where(x => x.Attribute("name").Value == "MSISDN").FirstOrDefault() != null)
                            msisdn = xml.Descendants("parm").Where(x => x.Attribute("name").Value == "MSISDN").FirstOrDefault().Attribute("value").Value;
                        if (!String.IsNullOrEmpty(imei) && !String.IsNullOrEmpty(msisdn))
                        {
                            var imeiObj = new IMEIObject
                            {
                                IMEI = imei,
                                MSISDN = msisdn.Replace('+', ' ').Trim()
                            };
                            return Ok(imeiObj);
                        }
                    }
                    return null;
                }
            }
            catch { return null; }
            
        }
    }
}
