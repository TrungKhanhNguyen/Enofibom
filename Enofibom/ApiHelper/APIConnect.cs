using Enofibom.Helper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Enofibom.ApiHelper
{
    public class APIConnect
    {
        public void GetLocation(string SDT)
        {
            //using (var httpClient = new HttpClient())
            //{
            //    try
            //    {
            //        httpClient.DefaultRequestHeaders.Accept.Clear();
            //        httpClient.DefaultRequestHeaders.Accept.Add(
            //            new MediaTypeWithQualityHeaderValue("application/json"));

            //        var response = httpClient.GetAsync(StaticKey.API_GETLOCATION + SDT);
            //    }
            //    catch { }
            //}
            //var url = StaticKey.API_GETLOCATION + SDT;
            using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                client.BaseAddress = new Uri(StaticKey.API_GETLOCATION);
                HttpResponseMessage response = client.GetAsync(SDT).Result;
                response.EnsureSuccessStatusCode();
                string result = response.Content.ReadAsStringAsync().Result;
                //Console.WriteLine("Result: " + result);
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
