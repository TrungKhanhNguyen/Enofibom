using Enofibom.ApiHelper;
using Enofibom.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enofibom
{
    public partial class AutoRequestControl : UserControl
    {
        System.Windows.Forms.Timer timer1 = new Timer();
        System.Windows.Forms.Timer timer2 = new Timer();
        System.Windows.Forms.Timer timer3 = new Timer();

        System.Windows.Forms.Timer clockCount1 = new Timer();
        System.Windows.Forms.Timer clockCount2 = new Timer();
        System.Windows.Forms.Timer clockCount3 = new Timer();

        DBHelper helper = new DBHelper();
        APIConnect api = new APIConnect();
        public AutoRequestControl()
        {
            InitializeComponent();
        }

        private async void GetLocationAsync(string phoneNumber)
        {
            try
            {
                var mobi = await api.GetLocation(phoneNumber);
                await helper.InsertPositionToDB(mobi);
            }
            catch
            {

            }
        }

        private int current1 = 1800;
        private int current2 = 1800;
        private int current3 = 1800;

        private int first1 = 1800;
        private int first2 = 1800;
        private int first3 = 1800;

        #region[btn1]

        private void clockCount1_Tick(object sender, EventArgs e)
        {
            if (current1 == 0)
                current1 = first1;
            txtNotify1.Text = current1.ToString();
            current1--;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= dpStart1.Value && DateTime.Now <= dpStop1.Value)
            {
                var phone1 = txtPhone1.Text;
                GetLocationAsync(phone1);
            }
            else
            {
                btnStop1.PerformClick();
            }

        }
        private void btnStart1_Click(object sender, EventArgs e)
        {
            current1 = first1 = (int)num1.Value * 60;
            timer1.Interval = (int)first1 * 1000;
            timer1.Start();
            lblNotify1.Visible = txtNotify1.Visible = true;
            clockCount1.Start();
            btnStart1.Enabled = false;
            btnStop1.Enabled = true;

            //var phone1 = txtPhone1.Text;
            //GetLocationAsync(phone1);
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            clockCount1.Stop();
            current1 = first1 = 1800;
            lblNotify1.Visible = txtNotify1.Visible = false;

            btnStart1.Enabled = true;
            btnStop1.Enabled = false;
        }
        #endregion

        #region[btn2]
        private void btnStart2_Click(object sender, EventArgs e)
        {
            current2 = first2 = (int)num2.Value * 60;
            timer2.Interval = (int)first2 * 1000;
            timer2.Start();
            lblNotify2.Visible = txtNotify2.Visible = true;
            clockCount2.Start();
            btnStart2.Enabled = false;
            btnStop2.Enabled = true;
        }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            clockCount2.Stop();
            current2 = first2 = 1800;
            lblNotify2.Visible = txtNotify2.Visible = false;
            btnStart2.Enabled = true;
            btnStop2.Enabled = false;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            var phone2 = txtPhone2.Text;
            GetLocationAsync(phone2);
        }

        private void clockCount2_Tick(object sender, EventArgs e)
        {
            if (current2 == 0)
                current2 = first2;
            txtNotify2.Text = current2.ToString();
            current2--;
        }
        #endregion

        #region[btn3]
        private void btnStart3_Click(object sender, EventArgs e)
        {
            current3 = first3 = (int)num3.Value * 60;
            timer3.Interval = (int)first3 * 1000;
            timer3.Start();
            lblNotify3.Visible = txtNotify3.Visible = true;
            clockCount3.Start();
            btnStart3.Enabled = false;
            btnStop3.Enabled = true;
        }

        private void btnStop3_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            clockCount3.Stop();
            current3 = first3 = 1800;
            lblNotify3.Visible = txtNotify3.Visible = false;
            btnStart3.Enabled = true;
            btnStop3.Enabled = false;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            var phone3 = txtPhone3.Text;
            GetLocationAsync(phone3);
        }

        private void clockCount3_Tick(object sender, EventArgs e)
        {
            if (current3 == 0)
                current3 = first3;
            txtNotify3.Text = current3.ToString();
            current3--;
        }
        #endregion

        private void AutoRequestControl_Load(object sender, EventArgs e)
        {
            lblNotify1.Visible = lblNotify2.Visible = lblNotify3.Visible = false;
            txtNotify1.Visible = txtNotify2.Visible = txtNotify3.Visible = false;

            dpStart1.Value = dpStart2.Value = dpStart3.Value = DateTime.Now;
            dpStop1.Value = dpStop2.Value = dpStop3.Value = DateTime.Now.AddHours(6);


            btnStop1.Enabled = btnStop2.Enabled = btnStop3.Enabled = false;

            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1800000;
            clockCount1.Interval = 1000;
            clockCount1.Tick += new EventHandler(clockCount1_Tick);

            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = 1800000;
            clockCount2.Interval = 1000;
            clockCount2.Tick += new EventHandler(clockCount2_Tick);

            timer3.Tick += new EventHandler(timer3_Tick);
            timer3.Interval = 1800000;
            clockCount3.Interval = 1000;
            clockCount3.Tick += new EventHandler(clockCount3_Tick);

            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
        }
    }
}
