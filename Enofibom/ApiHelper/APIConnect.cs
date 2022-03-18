using Enofibom.Helper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Enofibom.ApiHelper
{
    public class APIConnect
    {
        public async Task<Position> GetLocation(string SDT)
        {
            Position _mem = null;
            using (var httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));
                    
                    var response = httpClient.GetAsync(StaticKey.API_GETLOCATION + SDT);
                    var responseObj = await response.Result.Content.ReadAsStringAsync();
                    _mem = JsonConvert.DeserializeObject<Position>(responseObj);
                    return _mem;
                }
                catch { return null; }
            }
        }

        public async Task<IMEIObject> GetIMEI(string SDT)
        {
            IMEIObject _imei = null;
            using (var httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));

                    var response = httpClient.GetAsync(StaticKey.API_GETIMEI + SDT);
                    var responseObj = await response.Result.Content.ReadAsStringAsync();
                    _imei = JsonConvert.DeserializeObject<IMEIObject>(responseObj);
                    return _imei;
                }
                catch { return null; }
            }

            //using (var httpClient = new HttpClient())
            //{
            //    try
            //    {
            //        var password = StaticKey.CreateMD5("123456");
            //        httpClient.DefaultRequestHeaders.Accept.Clear();
            //        httpClient.DefaultRequestHeaders.Accept.Add(
            //            new MediaTypeWithQualityHeaderValue("application/json"));
            //        var mem = new Member { Username = username, Password = password, IsAdmin = isAdmin, Active = isActive };
            //        var content = new StringContent(JsonConvert.SerializeObject(mem), Encoding.UTF8, "application/json");
            //        var response = httpClient.PostAsync(StaticKey.API_ADDMEMBER, content);
            //        var responseObj = await response.Result.Content.ReadAsStringAsync();
            //        _mem = JsonConvert.DeserializeObject<Member>(responseObj);
            //    }
            //    catch { }

            //}
        }


    }
}
