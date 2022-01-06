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
        public LogCheck()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var fromDate = dpFromDate.Value;
            var toDate = dpToDate.Value;
            var listEvent = helper.GetLogByDate(fromDate, toDate);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = listEvent;
            
        }

    }
}
