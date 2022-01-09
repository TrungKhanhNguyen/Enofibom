using Enofibom.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enofibom
{
    public partial class TargetManage : UserControl
    {
        DBHelper helper = new DBHelper();
        TargetHelper targetHelper = new TargetHelper();
        List<Target> listTarget = new List<Target>();
        string userLoggedIn = "";
        public TargetManage()
        {
            InitializeComponent();
        }

        private void ReloadData()
        {
            listTarget = helper.GetAllTarget();
            dataGridView1.DataSource = listTarget;
            dataGridView1.Refresh();
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            targetHelper.AddTarget(listTarget, txtMSISDN.Text, txtTargetName.Text, txtIMSI.Text, txtIMEI.Text, chkActive.Checked, userLoggedIn);
            ReloadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            targetHelper.SaveTarget(listTarget, lblID.Text, txtTargetName.Text, txtIMSI.Text, txtIMEI.Text, chkActive.Checked, userLoggedIn);
            ReloadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            targetHelper.DeleteTarget(listTarget, lblID.Text, userLoggedIn);
            ReloadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblID.Text = "";
            dataGridView1.ClearSelection();
            chkActive.Checked = true;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    chkActive.Checked = Convert.ToBoolean(listTarget[e.RowIndex].IsActive);
                    
                    txtIMSI.Text = listTarget[e.RowIndex].IMSI;
                    txtIMEI.Text = listTarget[e.RowIndex].IMEI;
                    txtTargetName.Text = listTarget[e.RowIndex].TargetName;
                    txtMSISDN.Text = listTarget[e.RowIndex].MSISDN;
                    lblID.Text = listTarget[e.RowIndex].Id.ToString();
                }
                catch { }
            }
        }

        private void TargetManage_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            userLoggedIn = System.Configuration.ConfigurationManager.AppSettings[StaticKey.UserLoggedIn];
            if (!this.DesignMode)
            {
                ReloadData();
            }
                
            
        }
    }
}
