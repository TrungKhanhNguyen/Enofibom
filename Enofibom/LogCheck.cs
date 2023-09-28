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
    public partial class LogCheck : UserControl
    {
        DBHelper helper = new DBHelper();
        UserHelper userHelper = new UserHelper();
        public LogCheck()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var fromDate = dpFromDate.Value;
            var toDate = dpToDate.Value;
            var username = dropdownUser.Text;
            var listEvent = helper.GetLogByDate(fromDate, toDate,username);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = listEvent;
            lblTotalRecords.Text = listEvent.Count().ToString();
            lblTotalRecords.Visible = true;

        }
        
        private void LogCheck_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            dpFromDate.Value = DateTime.Today.AddDays(-3);
            dpToDate.Value = DateTime.Today.AddDays(1);
            var listUser = userHelper.GetAllMembers();
            var tempuser = new Member { Active = true, Username = "All user", Id = 0 };
            listUser.Insert(0, tempuser);
            dropdownUser.DataSource = listUser;
            dropdownUser.DisplayMember = "Username";
            dropdownUser.ValueMember = "Id";

            dataGridView1.DataSource = helper.GetRecentLogs() ;
            lblTotalRecords.Visible = false;

        }
    }
}
