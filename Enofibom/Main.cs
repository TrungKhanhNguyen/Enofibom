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
            //mapUserControl1.Show();
            //mapUserControl1.BringToFront();
            //userManage1.Hide();
            //logCheck1.Hide();
            btnLogCheck.Visible = false;
            btnUserManage.Visible = false;
            string isAdmin = System.Configuration.ConfigurationManager.AppSettings[StaticKey.IsAdmin];
            string userLoggedIn = System.Configuration.ConfigurationManager.AppSettings[StaticKey.UserLoggedIn];
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
            
            logCheck2.Show();
            logCheck2.BringToFront();
            targetManage1.Hide();
        }

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDataOffline_Click(object sender, EventArgs e)
        {

        }

        private void btnDataOnline_Click(object sender, EventArgs e)
        {
            //mapUserControl1.Show();
            //mapUserControl1.BringToFront();
            //userManage1.Hide();
            //logCheck1.Hide();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            mapUserControl2.Hide();

            logCheck2.Hide();
            
            targetManage1.Show();
            targetManage1.BringToFront();
        }
    }
}
