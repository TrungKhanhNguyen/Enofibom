﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Http;
using System.Net.Security;
using System.Threading;
using System.Xml.Linq;
using Timer = System.Windows.Forms.Timer;
using GMap.NET.WindowsForms;
using Enofibom.Helper;
using GMap.NET;
using GMap.NET.MapProviders;
using System.Net;
using Enofibom.ApiHelper;
using System.Windows.Media.Animation;
using System.Collections.Specialized;
using Microsoft.VisualBasic;
using System.Windows.Forms.Design;
using RestSharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using FontAwesome.Sharp;
using System.IO;

namespace Enofibom
{
    public partial class MapUserControl : UserControl
    {
        GMapOverlay overlay = new GMapOverlay("ABCDS");
        List<Position> listObject = new List<Position>();
        
        System.Windows.Forms.Timer clockCount = new Timer();
        System.Windows.Forms.Timer timer1 = new Timer();
        Maper maper = new Maper();
        DBHelper helper = new DBHelper();
        List<GMapMarker> currentListMarker = new List<GMapMarker>(); //List các marker đang hiển thị phần online
        List<GMapPolygon> currentListPolygon = new List<GMapPolygon>();//List các polygon đang hiển thị online
        List<IMEIObject> listIMEI = new List<IMEIObject>(); //list các imei đang hiển thị phần online
        bool isIMEILoaded = false;
        bool isLocationLoaded = false;
        APIConnect api = new APIConnect();
        public MapUserControl()
        {
            InitializeComponent();
            //this.Parent.Width = Screen.FromHandle(this.Handle).WorkingArea.Width;
            //this.Parent.Height = Screen.FromHandle(this.Handle).WorkingArea.Height;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        }
        private void MapUserControl_Load(object sender, EventArgs e)
        {
            var toDate = DateTime.Now;
            var fromDate = DateTime.Now;
            

            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            mapControl.CacheLocation = "C:/MapCache";
            mapControl.MapProvider = GMapProviders.GoogleMap;
            var point = new PointLatLng(21.020440, 105.843650);
            mapControl.Position = point;
            mapControl.DragButton = MouseButtons.Left;
            mapControl.MinZoom = 5;
            mapControl.MaxZoom = 22;
            mapControl.Zoom = 12;
            mapControl.ShowCenter = false;

            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
            dataGrid1.AutoGenerateColumns = false;
            //dataGridHistory.AutoGenerateColumns = false;

            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 60000;
            clockCount.Interval = 1000;
            clockCount.Tick += new EventHandler(clockCount_Tick);
            mapControl.Overlays.Add(overlay);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            ClearText();
            LoadData();
            this.Cursor = Cursors.Default;

            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        }

        private void LoadData()
        {
            isIMEILoaded = isLocationLoaded = false;
            GetIMEI();
            Thread.Sleep(200);
            GetLocationTemp();
        }

        private async void GetIMEI()
        {
            try
            {
                listIMEI = new List<IMEIObject>();
                var listSDT = txtSearchMSISDN.Text.Split(';');
                foreach (var sdt in listSDT)
                {
                    var urlIMEI = StaticKey.requestIMEIUrl;
                    try
                    {
                        using (var client = new HttpClient())
                        {
                            client.DefaultRequestHeaders.Add("MobifoneKey", "74a5c84c-f2c3-4bbd-9819-5958094d604e");
                            var contentReponse = "";
                            using (HttpResponseMessage responseMessage = await client.GetAsync(urlIMEI + helper.ConvertPhoneNumber(sdt.Trim())))
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
                                    listIMEI.Add(imeiObj);
                                    var mobiObj = listObject.Where(m => m.MSISDN == imeiObj.MSISDN).FirstOrDefault();
                                    if (mobiObj != null)
                                        mobiObj.IMEI = imeiObj.IMEI;
                                }
                            }
                            
                        }
                    }
                    catch {  }
                    
                }
                isIMEILoaded = true;
                
            }
            catch { }
            
        }

        private async void GetLocationTemp()
        {
            ServicePointManager.ServerCertificateValidationCallback +=
    new RemoteCertificateValidationCallback((sender, certificate, chain, policyErrors) => { return true; });
            try
            {
                listObject = new List<Position>();
                var listSDT = txtSearchMSISDN.Text.Split(';');

                foreach (var sdt in listSDT)
                {
                    try
                    {
                        //api.GetLocation(sdt);
                        Thread.Sleep(1500);
                        var inputBody = "<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:v1='http://schema.intersec.com/igloo/sdk/v1.2'><soapenv:Header/><soapenv:Body><v1:pull.retrieveV3Req><args><params><filter><msisdn><explicit><kind>2</kind>"
                            + "<m>" + sdt.Trim() + "</m>"
                            + "</explicit></msisdn></filter><options><subscriberFields>msisdn</subscriberFields><subscriberFields>imsi</subscriberFields><locationFields>location</locationFields></options></params></args></v1:pull.retrieveV3Req></soapenv:Body></soapenv:Envelope>";
                        //var ks = postXMLData(StaticKey.requestPositionUrl,inputBody);
                        var locationInfo = postXMLData(StaticKey.requestPositionUrl, inputBody);
                        if (!String.IsNullOrEmpty(locationInfo))
                        {
                            var mobi = helper.GetObjectLocationInfo(locationInfo);
                            var stampBody = "<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:v1='http://schema.intersec.com/igloo/sdk/v1.2'><soapenv:Header/><soapenv:Body><v1:pull.retrieveV3Req><args><params><filter><msisdn><explicit><kind>2</kind>"
                            + "<m>" + sdt.Trim() + "</m>"
                            + "</explicit></msisdn></filter><options><subscriberFields>msisdn</subscriberFields><subscriberFields>imsi</subscriberFields><locationFields>event</locationFields><locationFields>eventStamp</locationFields><locationFields>locStamp</locationFields><locationFields>presence</locationFields><locationFields>presenceStamp</locationFields></options></params></args></v1:pull.retrieveV3Req></soapenv:Body></soapenv:Envelope>";
                            var stampInfo = postXMLData(StaticKey.requestPositionUrl,stampBody);
                            var stampObject = helper.GetObjectStampInfo(stampInfo);
                            mobi.Presence = stampObject.Presence;
                            mobi.PresentFlag = stampObject.PresentFlag;
                            mobi.DisappearedFlag = stampObject.DisappearedFlag;
                            mobi.eventStamp = stampObject.eventStamp;
                            mobi.locStamp = stampObject.locStamp;
                            mobi.RequestTime = DateTime.Now;
                            if (mobi.Kind.Trim().Contains("C4G") == true)
                            {
                                try
                                {
                                    var result = mobi.CGI.Split('-');
                                    string lcrId = result[result.Length - 1];
                                    string btsId = result[result.Length - 2];
                                    using (MapOfflineEntities db = new MapOfflineEntities())
                                    {
                                        var cell = db.OperatorCells.Where(m => m.lcrId.ToLower() == lcrId && m.btsId.ToLower() == btsId.ToLower()).FirstOrDefault();
                                        if (cell != null)
                                        {
                                            if (!String.IsNullOrEmpty(cell.TAC))
                                                mobi.TAC = cell.TAC;
                                            if (!String.IsNullOrEmpty(cell.CellName))
                                                mobi.CellName = cell.CellName;
                                        }
                                    }
                                }
                                catch { }
                                //var cell = 
                            }
                            if (mobi != null)
                            {
                                var imeiObj = listIMEI.Where(m => m.MSISDN == mobi.MSISDN).FirstOrDefault();
                                if (imeiObj != null)
                                    mobi.IMEI = imeiObj.IMEI;
                                listObject.Add(mobi);
                            }
                        }
                    }
                    catch
                    {

                    }


                }

                dataGrid1.DataSource = listObject;
                var count = 1;
                isLocationLoaded = true;
                foreach (var item in listObject)
                {
                    var marker1 = maper.GetMarkerFromData(item, count);
                    var poly = maper.GetPolygonFromData(item);
                    if (marker1 != null)
                    {
                        overlay.Markers.Add(marker1);
                        currentListMarker.Add(marker1);
                    }

                    if (poly != null)
                    {
                        overlay.Polygons.Add(poly);
                        currentListPolygon.Add(poly);
                    }

                    if (listObject.Count == 1)
                    {
                        if(!String.IsNullOrEmpty(item.Lat) && !String.IsNullOrEmpty(item.Lat))
                        {
                            var lat = Convert.ToDouble(item.Lat);
                            var lon = Convert.ToDouble(item.Lon);
                            mapControl.Position = new PointLatLng(lat, lon);
                            mapControl.Refresh();
                        }
                        
                    }
                    else
                    {
                        mapControl.Position = new PointLatLng(13.769040, 109.228371);
                        mapControl.Zoom = 6;
                        mapControl.Refresh();
                    }

                    //if (isLocationLoaded && isIMEILoaded)
                    await helper.InsertPositionToDB(item);
                    count++;
                }
                if (listObject.Count > 0)
                {
                    var temp1 = listObject[0];
                    txtCGI.Text = temp1.CGI;
                    txtIMSI.Text = temp1.IMSI;
                    txtMSISDN.Text = temp1.MSISDN;
                    txtLat.Text = temp1.Lat;
                    txtLon.Text = temp1.Lon;
                    txtRadius.Text = temp1.Radius;
                    txtPlanName.Text = temp1.PlanName;
                    txtKind.Text = temp1.Kind;
                    txtLocationStamp.Text = temp1.locStamp?.ToString("dd/MM/yyyy HH:mm");
                    txtEventStamp.Text = temp1.eventStamp?.ToString("dd/MM/yyyy HH:mm");
                    txtIMEI.Text = temp1.IMEI;
                    txtTAC.Text = temp1.TAC;
                    txtCellName.Text = temp1.CellName;
                    txtPresence.Text = temp1.Presence;
                    txtReqTime.Text = temp1.RequestTime?.ToString("dd/MM/yyyy HH:mm");
                    try
                    {
                        txtPresentFlag.Text = DBHelper.UnixTimeStampToDateTime(Convert.ToDouble(temp1.PresentFlag)).ToString("dd/MM/yyyy HH:mm");
                        txtDisappearFlag.Text = DBHelper.UnixTimeStampToDateTime(Convert.ToDouble(temp1.DisappearedFlag)).ToString("dd/MM/yyyy HH:mm");
                    }
                    catch
                    {

                    }


                    dataGrid1.Rows[0].Selected = true;
                }
                if (!String.IsNullOrEmpty(txtSearchMSISDN.Text))
                {
                    var userLoggedIn = System.Configuration.ConfigurationManager.AppSettings[StaticKey.UserLoggedIn];
                    var tempLog = new LogEvent
                    {
                        EventDate = DateTime.Now,
                        User = userLoggedIn,
                        Task = "Search number: " + txtSearchMSISDN.Text
                    };
                    await DBHelper.InsertToLog(tempLog);
                }
                
            }
            catch
            {

            }

        }

        private async void GetLocation()
        {
            try
            {
                listObject = new List<Position>();
                var listSDT = txtSearchMSISDN.Text.Split(';');

                foreach (var sdt in listSDT)
                {
                    try
                    {
                        //api.GetLocation(sdt);
                        Thread.Sleep(1500);
                        var url = StaticKey.requestPositionUrl;
                        var handler = new HttpClientHandler() { };
                        using (var httpClient = new HttpClient(handler)
                        {
                            BaseAddress = new Uri(url),
                            Timeout = new TimeSpan(0, 0, 20)
                        })
                        {
                            var inputBody = "<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:v1='http://schema.intersec.com/igloo/sdk/v1.2'><soapenv:Header/><soapenv:Body><v1:pull.retrieveV3Req><args><params><filter><msisdn><explicit><kind>2</kind>"
                            + "<m>" + sdt.Trim() + "</m>"
                            + "</explicit></msisdn></filter><options><subscriberFields>msisdn</subscriberFields><subscriberFields>imsi</subscriberFields><locationFields>location</locationFields><locationFields>event</locationFields><locationFields>presence</locationFields></options></params></args></v1:pull.retrieveV3Req></soapenv:Body></soapenv:Envelope>";

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
                            //string testContent = "<?xml version='1.0' encoding='UTF-8'?><s:Envelope xmlns:s='http://schemas.xmlsoap.org/soap/envelope/' xmlns:n= 'http://schema.intersec.com/igloo/sdk/v1.2' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'><s:Body><n:pull.retrieveV3Res><result><subscriber><imsi>452019165202215</imsi><msisdn>84931111841</msisdn><imeiCur>356266761943221</imeiCur></subscriber><currLocation><planName>GSM</planName><location><cell><cgi>4G:452-01-685979-11</cgi><kind>UNKNOWN</kind></cell></location><locStamp>1670818691</locStamp><presence>DISAPPEARED</presence></currLocation><prevLocation><planName>GSM</planName><location><cell><cgi>452-01-44621-47047</cgi><kind>C3G</kind><geom><longitude>103959800</longitude><latitude>10215300</latitude><radius>3000</radius><angleStart>-15230769</angleStart><angleEnd>15230769</angleEnd></geom></cell></location><locStamp>1670818660</locStamp><presence>DISAPPEARED</presence></prevLocation></result></n:pull.retrieveV3Res></s:Body></s:Envelope>";
                            //await Task.When
                            if (!String.IsNullOrEmpty(contentReponse))
                            {
                                var mobi = helper.GetPositionObjectByContentReponse(contentReponse);
                                mobi.RequestTime = DateTime.Now;
                                if (mobi.Kind.Trim().Contains("C4G") == true)
                                {
                                    try
                                    {
                                        var result = mobi.CGI.Split('-');
                                        string lcrId = result[result.Length - 1];
                                        string btsId = result[result.Length - 2];
                                        using (MapOfflineEntities db = new MapOfflineEntities())
                                        {
                                            var cell = db.OperatorCells.Where(m => m.lcrId.ToLower() == lcrId && m.btsId.ToLower() == btsId.ToLower()).FirstOrDefault();
                                            if (cell != null)
                                            {
                                                if (!String.IsNullOrEmpty(cell.TAC))
                                                    mobi.TAC = cell.TAC;
                                                if (!String.IsNullOrEmpty(cell.CellName))
                                                    mobi.CellName = cell.CellName;
                                            }
                                        }
                                    }
                                    catch { }
                                    //var cell = 
                                }
                                if (mobi != null)
                                {
                                    var imeiObj = listIMEI.Where(m => m.MSISDN == mobi.MSISDN).FirstOrDefault();
                                    if (imeiObj != null)
                                        mobi.IMEI = imeiObj.IMEI;
                                    listObject.Add(mobi);
                                }

                            }
                            
                        }
                    }
                    catch
                    {
                        
                    }
                    
                   
                }

                dataGrid1.DataSource = listObject;
                var count = 1;
                isLocationLoaded = true;
                foreach (var item in listObject)
                {
                    var marker1 = maper.GetMarkerFromData(item, count);
                    var poly = maper.GetPolygonFromData(item);
                    if (marker1 != null)
                    {
                        overlay.Markers.Add(marker1);
                        currentListMarker.Add(marker1);
                    }

                    if (poly != null)
                    {
                        overlay.Polygons.Add(poly);
                        currentListPolygon.Add(poly);
                    }

                    if (listObject.Count == 1)
                    {
                        var lat = Convert.ToDouble(item.Lat);
                        var lon = Convert.ToDouble(item.Lon);
                        mapControl.Position = new PointLatLng(lat, lon);
                        mapControl.Refresh();
                    }
                    else
                    {
                        mapControl.Position = new PointLatLng(13.769040, 109.228371);
                        mapControl.Zoom = 6;
                        mapControl.Refresh();
                    }

                    //if (isLocationLoaded && isIMEILoaded)
                        await helper.InsertPositionToDB(item);
                    count++;
                }
                if (listObject.Count > 0)
                {
                    var temp1 = listObject[0];
                    txtCGI.Text = temp1.CGI;
                    txtIMSI.Text = temp1.IMSI;
                    txtMSISDN.Text = temp1.MSISDN;
                    txtLat.Text = temp1.Lat;
                    txtLon.Text = temp1.Lon;
                    txtRadius.Text = temp1.Radius;
                    txtPlanName.Text = temp1.PlanName;
                    txtKind.Text = temp1.Kind;
                    txtLocationStamp.Text = temp1.locStamp?.ToString("dd/MM/yyyy HH:mm");
                    txtEventStamp.Text = temp1.eventStamp?.ToString("dd/MM/yyyy HH:mm");
                    txtIMEI.Text = temp1.IMEI;
                    txtTAC.Text = temp1.TAC;
                    txtCellName.Text = temp1.CellName;
                    txtPresence.Text = temp1.Presence;
                    txtReqTime.Text = temp1.RequestTime?.ToString("dd/MM/yyyy HH:mm");
                    try
                    {
                        txtPresentFlag.Text = DBHelper.UnixTimeStampToDateTime(Convert.ToDouble(temp1.PresentFlag)).ToString("dd/MM/yyyy HH:mm");
                        txtDisappearFlag.Text = DBHelper.UnixTimeStampToDateTime(Convert.ToDouble(temp1.DisappearedFlag)).ToString("dd/MM/yyyy HH:mm");
                    }
                    catch {
                    
                    }
                    

                    dataGrid1.Rows[0].Selected = true;
                }
                var userLoggedIn = System.Configuration.ConfigurationManager.AppSettings[StaticKey.UserLoggedIn];
                var tempLog = new LogEvent
                {
                    EventDate = DateTime.Now,
                    User = userLoggedIn,
                    Task = "Search number: " + txtSearchMSISDN.Text
                };
                await DBHelper.InsertToLog(tempLog);
            }
            catch
            {

            }
            
        }

        public string postXMLData(string destinationUrl, string requestXml)
        {
            var byteArray = Encoding.ASCII.GetBytes("tctk_api:$5$rounds=5000$bbf460274ac2fcd8$u0raxguDBJcCDUWKabiHX0LXjxuTszOnUJlZhqGXFQ2");
            string encoded = System.Convert.ToBase64String(byteArray);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(destinationUrl);
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.Headers.Add("MobifoneKey", "74a5c84c-f2c3-4bbd-9819-5958094d604e");
            byte[] bytes;
            bytes = System.Text.Encoding.ASCII.GetBytes(requestXml);
            request.ContentType = "text/xml; encoding='utf-8'";
            request.ContentLength = bytes.Length;
            request.Method = "POST";
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();
            HttpWebResponse response;
            response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream responseStream = response.GetResponseStream();
                string responseStr = new StreamReader(responseStream).ReadToEnd();
                return responseStr;
            }
            return null;
        }

        private async Task<string> SendRequestAsync(string inputBody)
        {

            //var postUrl = StaticKey.requestPositionUrl;
            ////string rawXml = "<note><to>Tove</to><from>Jani</from><heading>Reminder</heading><body>Don't forget me this weekend!</body></note>";

            //IRestClient client = new RestClient();
            //client.Authenticator = new HttpBasicAuthenticator("MobifoneKey", "74a5c84c-f2c3-4bbd-9819-5958094d604e");
            //IRestRequest request = new RestRequest
            //{
            //    Resource = postUrl
            //};

            //request.AddHeader("Content-Type", "text/xml");
            //request.AddHeader("Accept", "text/xml");
            //request.AddParameter("text/xml", inputBody, ParameterType.RequestBody);

            //var response = client.Post(request);
            //var sdsd = response.Content;
            //return sdsd.ToString();

            //var client = new RestClient(StaticKey.requestPositionUrl);
            //client.Authenticator = new HttpBasicAuthenticator("MobifoneKey", "74a5c84c-f2c3-4bbd-9819-5958094d604e");
            //var request = new RestRequest("resources",Method.POST);
            //// Json to post.
            ////string jsonToSend = JsonHelper.ToJson(json);

            //request.AddParameter("application/xml; charset=utf-8", inputBody, ParameterType.RequestBody);
            //request.RequestFormat = DataFormat.Xml;

            //try
            //{
            //    var sdsdsd = client.Execute(request);
            //    return sdsdsd.Content;
            //}
            //catch (Exception error)
            //{
            //    // Log
            //    return "";
            //}
            

            var url = StaticKey.requestPositionUrl;
            var handler = new HttpClientHandler() { };  
            //handler.ServerCertificateCustomValidationCallback = (request, cert, chain, errors) => true;
            using (var httpClient = new HttpClient(handler)
            {
                BaseAddress = new Uri(url),
                Timeout = new TimeSpan(0, 0, 20)
            })
            {

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
                if (!String.IsNullOrEmpty(contentReponse))
                {
                    return contentReponse;
                }
                else
                {
                    return "";
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //ClearMap();
            foreach (var item in currentListMarker)
            {
                overlay.Markers.Remove(item);
            }
            foreach (var item in currentListPolygon)
            {
                overlay.Polygons.Remove(item);
            }
            ClearText();
        }

       
        private void ClearText()
        {
            txtCGI.Text = txtIMSI.Text = txtKind.Text = txtLat.Text = txtLon.Text = txtMSISDN.Text = txtPlanName.Text = txtRadius.Text = "";
            txtLocationStamp.Text = txtEventStamp.Text = "";
            txtTAC.Text = ""; txtIMEI.Text = ""; txtCellName.Text = "";
            txtPresence.Text = txtPresentFlag.Text = txtDisappearFlag.Text = "";
            txtReqTime.Text = "";
            dataGrid1.DataSource = null;
            dataGrid1.Refresh();
        }


        private void dataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtCGI.Text = listObject[e.RowIndex].CGI;
                txtIMSI.Text = listObject[e.RowIndex].IMSI;
                txtMSISDN.Text = listObject[e.RowIndex].MSISDN;
                txtLat.Text = listObject[e.RowIndex].Lat;
                txtLon.Text = listObject[e.RowIndex].Lon;
                txtRadius.Text = listObject[e.RowIndex].Radius;
                txtPlanName.Text = listObject[e.RowIndex].PlanName;
                txtKind.Text = listObject[e.RowIndex].Kind;

                txtIMEI.Text = listObject[e.RowIndex].IMEI;
                txtTAC.Text = listObject[e.RowIndex].TAC;
                txtCellName.Text = listObject[e.RowIndex].CellName;
                txtReqTime.Text = listObject[e.RowIndex].RequestTime?.ToString("dd/MM/yyyy HH:mm");
                try
                {
                    txtLocationStamp.Text = listObject[e.RowIndex].locStamp?.ToString("dd/MM/yyyy HH:mm");
                    txtEventStamp.Text = listObject[e.RowIndex].eventStamp?.ToString("dd/MM/yyyy HH:mm");
                }
                catch
                {

                }

            }
        }

        private void dataGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    var valuelat = listObject[e.RowIndex].Lat;
                    var valuelng = listObject[e.RowIndex].Lon;
                    //var valuemsisdn = listObject[e.RowIndex].MSISDN;
                    if (!String.IsNullOrEmpty(valuelat) && !String.IsNullOrEmpty(valuelng))
                    {
                        var realLat = Convert.ToDouble(valuelat);
                        var realLng = Convert.ToDouble(valuelng);
                        mapControl.Position = new PointLatLng(realLat, realLng);
                    }
                }
                catch { }
            }
        }

        private void txtSearchMSISDN_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Space)
            //{
            //    txtSearchMSISDN.Text += ";";
            //    txtSearchMSISDN.Select(txtSearchMSISDN.Text.Length, 0);
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ClearMap();
            ClearText();
            LoadData();
        }

        private void clockCount_Tick(object sender, EventArgs e)
        {
            if (current == 0)
                current = firstTime * 60;
            lblCountLeft.Text = current.ToString();
            current--;
        }

        private int current = 5;
        private int firstTime = 5;


        private void checkAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAuto.Checked)
            {
                firstTime = (int)numericTimer.Value;
                current = firstTime * 60;
                timer1.Interval = firstTime * 60 * 1000;
                timer1.Start();
                clockCount.Start();

                LoadData();
            }
            else
            {
                timer1.Stop();
                clockCount.Stop();
                current = firstTime;
                numericTimer.Value = firstTime;
            }
        }

        
    }
}
