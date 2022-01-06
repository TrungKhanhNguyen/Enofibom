using Enofibom.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enofibom
{
    public partial class SignIn : Form
    {
        DBHelper helper = new DBHelper();
        public SignIn()
        {
            InitializeComponent();
        }

        private async void btnLogIn_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = StaticKey.CreateMD5(txtPassword.Text);
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            try
            {
                var user = helper.GetUserLogin(username, password);
                if (user != null)
                {
                    configuration.AppSettings.Settings["IsAdmin"].Value = user.IsAdmin.ToString();
                    configuration.AppSettings.Settings["UserLoggedIn"].Value = username;
                    configuration.Save();
                    ConfigurationManager.RefreshSection("appSettings");

                    var eventLog = new LogEvent
                    {
                        EventDate = DateTime.Now,
                        User = username,
                        Task = "Logged in"
                    };
                    await helper.InsertToLog(eventLog);
                    this.Hide();
                    var form1 = new Main();
                    form1.Closed += (s, args) => this.Close();
                    form1.Show();
                }
                else
                {
                    lblNotify.Visible = true;
                    lblNotify.Text = "Invalid username or password!";
                }
            }
            catch
            {
                lblNotify.Visible = true;
                lblNotify.Text = "Cannot login!!!";
            }
            
        }

        

    }
}
