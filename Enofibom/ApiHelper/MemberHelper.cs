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
    public class MemberHelper
    {
        public async Task<Member> getMemberByUsernameAndPass(string username, string password)
        {
            Member _mem = null;
            using (var httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));
                    var mem = new Member { Username = username, Password = password };
                    var content = new StringContent(JsonConvert.SerializeObject(mem), Encoding.UTF8, "application/json");
                    var response = httpClient.PostAsync(StaticKey.API_GETLOGINMEMBER, content);
                    var responseObj = await response.Result.Content.ReadAsStringAsync();
                    _mem = JsonConvert.DeserializeObject<Member>(responseObj);
                }
                catch { return null; }
                
            }
            return _mem;
        }

        public async Task<List<Member>> GetAllMember()
        {
            var listMember = new List<Member>();
            using (var httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = httpClient.GetAsync(StaticKey.API_GETLOGINMEMBER);
                    var responseObj = await response.Result.Content.ReadAsStringAsync();
                    listMember = JsonConvert.DeserializeObject<List<Member>>(responseObj);
                }
                catch { }
            }
                
            return listMember;
        }
    }
}
