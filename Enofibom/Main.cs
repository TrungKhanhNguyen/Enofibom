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
            userManage1.Show();
            userManage1.BringToFront();
            logCheck1.Hide();
        }

        private void btnLogCheck_Click(object sender, EventArgs e)
        {
            userManage1.Hide();
            logCheck1.Show();
            logCheck1.BringToFront();
        }

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            userManage1.Show();
            userManage1.BringToFront();
            logCheck1.Hide();
        }

        private void btnDataOffline_Click(object sender, EventArgs e)
        {

        }

        private void btnDataOnline_Click(object sender, EventArgs e)
        {

        }
    }
}
