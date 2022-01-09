using Enofibom.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Enofibom
{
    public partial class AutoRequestPosition : Form
    {
        System.Windows.Forms.Timer timer1 = new Timer();
        List<Position> listObject = new List<Position>();
        DBHelper helper = new DBHelper();
        public AutoRequestPosition()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void AutoRequestPosition_Load(object sender, EventArgs e)
        {
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
           
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = (int)numericUpDown1.Value * 60 * 1000;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            await GetLocationAsync();
        }
        private async Task GetLocationAsync()
        {
            var url = StaticKey.requestPositionUrl;
            listObject = new List<Position>();
            var listSDT = helper.GetAllActiveTarget();
            foreach (var sdt in listSDT)
            {
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
                        + "<m>" + sdt.MSISDN.Trim() + "</m>"
                        + "</explicit></msisdn></filter><options><subscriberFields>msisdn</subscriberFields><subscriberFields>imsi</subscriberFields><locationFields>location</locationFields></options></params></args></v1:pull.retrieveV3Req></soapenv:Body></soapenv:Envelope>";

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
                            var respon = contentReponse;

                            string imsi, msisdn, longitude, latitude, radius, cgi, kind, anglestart, angleend, planName;
                            imsi = msisdn = longitude = latitude = radius = cgi = kind = anglestart = angleend = planName = "";
                            if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "imsi").FirstOrDefault() != null)
                                imsi = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "imsi").FirstOrDefault().Value;

                            if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "msisdn").FirstOrDefault() != null)
                                msisdn = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "msisdn").FirstOrDefault().Value;

                            if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "longitude").FirstOrDefault() != null)
                                longitude = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "longitude").FirstOrDefault().Value;

                            if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "latitude").FirstOrDefault() != null)
                                latitude = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "latitude").FirstOrDefault().Value;

                            if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "radius").FirstOrDefault() != null)
                                radius = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "radius").FirstOrDefault().Value;

                            if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "cgi").FirstOrDefault() != null)
                                cgi = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "cgi").FirstOrDefault().Value;

                            if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "kind").FirstOrDefault() != null)
                                kind = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "kind").FirstOrDefault().Value;

                            if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "planName").FirstOrDefault() != null)
                                planName = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "planName").FirstOrDefault().Value;

                            if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "angleStart").FirstOrDefault() != null)
                                anglestart = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "angleStart").FirstOrDefault().Value;

                            if (XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "angleEnd").FirstOrDefault() != null)
                                angleend = XElement.Parse(respon).Descendants().Where(m => m.Name.LocalName.ToString() == "angleEnd").FirstOrDefault().Value;

                            if (!String.IsNullOrEmpty(latitude) && !String.IsNullOrEmpty(longitude))
                            {
                                var tempLong = ""; var tempLat = "";
                                tempLat = latitude.Insert(2, ".");
                                tempLong = longitude.Insert(3, ".");
                                var mobi = new Position
                                {
                                    AngleEnd = angleend,
                                    AngleStart = anglestart,
                                    CGI = cgi,
                                    IMSI = imsi,
                                    Kind = kind,
                                    Lat = tempLat,
                                    Lon = tempLong,
                                    MSISDN = msisdn,
                                    Radius = radius,
                                    PlanName = planName,
                                    RequestTime = DateTime.Now
                                };
                               
                                listObject.Add(mobi);
                            }
                        }

                    }
                }
                catch
                {

                }
                //Thread.Sleep(rd.Next(1000, 1500));
            }
           
            foreach (var item in listObject)
            {
                try
                {
                    await helper.InsertPositionToDB(item);
                }
                catch { }
                
            }
        }
    }
}
