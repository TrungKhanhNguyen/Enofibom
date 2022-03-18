
using Enofibom.Helper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enofibom
{
    public partial class Form66 : Form
    {
        public Form66()
        {
            InitializeComponent();
        }

        private void Form66_Load(object sender, EventArgs e)
        {
            
        }
        
        private async void button1_Click(object sender, EventArgs e)
         {

            //SerialPort _serialPort;
            //_serialPort = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
            //_serialPort.Handshake = Handshake.None;
            //_serialPort.ReadTimeout = 400;
            //_serialPort.WriteTimeout = 400;
            //_serialPort.Open();

            //_serialPort.WriteLine("AT+CMGF=0" + Environment.NewLine);
            //Thread.Sleep(100);

            //_serialPort.WriteLine("AT+CMGS=" + 17 + Environment.NewLine);
            //Thread.Sleep(100);

            //_serialPort.WriteLine("00B1000B914809540080F44000AA03201008" + char.ConvertFromUtf32(26));
            //Thread.Sleep(2000);

            ////_serialPort.Write(new byte[] { 26 }, 0, 1);
            //Thread.Sleep(100);
            //var sdsd = _serialPort.ReadExisting();

            //_serialPort.Close();


            var ssss = await getAllMembers();

        }

        private async Task<string> getAllMembers()
        {
            var msg = "";
            var username = "rorrrot";
            var password = StaticKey.CreateMD5("123456").ToLower();
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Clear();

                httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                var mem = new Member { Username = username, Password = password };
                var content =  new StringContent(JsonConvert.SerializeObject(mem),Encoding.UTF8,"application/json");
                var response = httpClient.PostAsync("http://localhost:8088/api/Members", content);

                var responseObj = await response.Result.Content.ReadAsStringAsync();
                //Console.Write(msg);
                //var ksss = JsonConvert.DeserializeObject<List<Member>>(msg);
                var xyz = JsonConvert.DeserializeObject<Member>(responseObj);
            }
            return msg;
        }
       
    }
}
