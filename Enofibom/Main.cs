using Enofibom.Helper;
using Enofibom.PageControls;
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
        UserControl mapUserControl = new MapUserControl();
        UserControl logUserControl = new LogCheck();
        UserControl userManageControl = new UserManage();
        UserControl changePasswordControl = new ChangePasswordControl();
        UserControl historyMapControl = new HistoryMap();
        UserControl autoRequestControl = new AutoRequestControl();
        public Main()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(mapUserControl);
            mapUserControl.Dock = DockStyle.Fill;

            btnLogCheck.Visible = false;
            btnUserManage.Visible = false;
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
            panel1.Controls.Clear();
            panel1.Controls.Add(logUserControl);
            logUserControl.Dock = DockStyle.Fill;
        }

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(userManageControl);
            userManageControl.Dock = DockStyle.Fill;
        }


        private void btnDataOnline_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(mapUserControl);
            mapUserControl.Dock = DockStyle.Fill;
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new SignIn();
            form1.Closed += (s, args) => { this.Close(); };
            form1.Show();
        }

        private void lblUserLoggedIn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(changePasswordControl);
            changePasswordControl.Dock = DockStyle.Fill;
        }

        private void btnHistoryCheck_Click(object sender, EventArgs e)
        {
            //mapUserControl2.Hide();
            //logCheck2.Hide();
            //changePasswordControl1.Hide();
            //autoRequestControl1.Hide();
            //historyMap1.Show();
            //historyMap1.BringToFront();
            panel1.Controls.Clear();
            panel1.Controls.Add(historyMapControl);
            historyMapControl.Dock = DockStyle.Fill;
        }

        private void btnAutoRequest_Click(object sender, EventArgs e)
        {
            //mapUserControl2.Hide();
            //logCheck2.Hide();
            //changePasswordControl1.Hide();
            //historyMap1.Hide();
            //autoRequestControl1.Show();
            //autoRequestControl1.BringToFront();
            panel1.Controls.Clear();
            panel1.Controls.Add(autoRequestControl);
            autoRequestControl.Dock = DockStyle.Fill;
        }
    }
}
