using Enofibom.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enofibom
{
    public partial class Main : Form
    {
        string userLoggedIn = "";
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            mapUserControl2.Show();
            mapUserControl2.BringToFront();
            logCheck2.Hide();
            targetManage1.Hide();
            userManage1.Hide();
            changePasswordControl1.Hide();
            btnLogCheck.Visible = false;
            btnUserManage.Visible = false;
            btnTargetManage.Visible = false;
            string isAdmin = System.Configuration.ConfigurationManager.AppSettings[StaticKey.IsAdmin];
            userLoggedIn = System.Configuration.ConfigurationManager.AppSettings[StaticKey.UserLoggedIn];
            lblUserLoggedIn.Text = userLoggedIn;
            try
            {
                if (Convert.ToBoolean(isAdmin))
                {
                    btnLogCheck.Visible = true;
                    btnUserManage.Visible = true;
                }
                    
            }
            catch { }
        }

        private void btnLogCheck_Click(object sender, EventArgs e)
        {
           
            mapUserControl2.Hide();
            changePasswordControl1.Hide();
            logCheck2.Show();
            logCheck2.BringToFront();
            targetManage1.Hide();
        }

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            mapUserControl2.Hide();
            logCheck2.Hide();
            userManage1.Show();
            userManage1.BringToFront();
            targetManage1.Hide();
            changePasswordControl1.Hide();
        }


        private void btnDataOnline_Click(object sender, EventArgs e)
        {
            mapUserControl2.Show();
            mapUserControl2.BringToFront();
            logCheck2.Hide();
            targetManage1.Hide();
            userManage1.Hide();
            changePasswordControl1.Hide();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            mapUserControl2.Hide();

            logCheck2.Hide();
            changePasswordControl1.Hide();
            targetManage1.Show();
            targetManage1.BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new SignIn();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void lblUserLoggedIn_Click(object sender, EventArgs e)
        {
            mapUserControl2.Hide();
            logCheck2.Hide();
            targetManage1.Hide();
            changePasswordControl1.Show();
            changePasswordControl1.BringToFront();
        }
    }
}
