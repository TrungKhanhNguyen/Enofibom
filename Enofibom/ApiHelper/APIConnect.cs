using Enofibom.Helper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Enofibom.ApiHelper
{
    public class APIConnect
    {
        public void GetLocation(string SDT)
        {
            //using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            //{
            //    client.BaseAddress = new Uri(StaticKey.API_GETLOCATION);
            //    HttpResponseMessage response = client.GetAsync(SDT).Result;
            //    response.EnsureSuccessStatusCode();
            //    string result = response.Content.ReadAsStringAsync().Result;
            //    //Console.WriteLine("Result: " + result);
            //}
            //var val1 = ConfigurationManager.AppSettings["COMMPORT"];
            try
            {
                using (SerialPort _serialPort = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One))
                {
                    _serialPort.Handshake = Handshake.None;
                    _serialPort.ReadTimeout = 400;
                    _serialPort.WriteTimeout = 400;
                    _serialPort.Open();
                    _serialPort.WriteLine("AT+CMGF=0" + Environment.NewLine);
                    Thread.Sleep(200);
                    _serialPort.WriteLine("AT+CMGS=" + 17 + Environment.NewLine);
                    Thread.Sleep(200);
                    var pduMsg = "00B1000B91" + SwapPosition(SDT) + "4000AA03201008";
                    _serialPort.WriteLine(pduMsg + char.ConvertFromUtf32(26));
                    Thread.Sleep(1000);
                    var returnValue = _serialPort.ReadExisting();
                    
                }
            }
            catch (Exception ex)
            { //return ex.Message; }
            }

        }
            public string SwapPosition(string _originalMsg)
            {

                var msg = _originalMsg.Substring(1);
                msg = "84" + msg + "F";
                string returnStr = "";
                for (int i = 0; i < msg.Count(); i++)
                {
                    if (i % 2 == 0)
                        returnStr += msg[i + 1];
                    else
                        returnStr += msg[i - 1];
                }
                return returnStr;
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

        }


    }
}
