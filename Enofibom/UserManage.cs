using Enofibom.ApiHelper;
using Enofibom.Helper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Enofibom
{
    public partial class UserManage : UserControl
    {
        UserHelper helper = new UserHelper();
        List<Member> listMember = new List<Member>();
        string userLoggedIn = "";
        //UserHelper userHelper = new UserHelper();
        public UserManage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            helper.AddUser(txtUsername.Text, chkIsActive.Checked, chkIsAdmin.Checked, userLoggedIn);
            ReloadData();
        }

        private void ReloadData()
        {
            listMember = helper.GetAllMembers();
            dataGridView1.DataSource = listMember;
            dataGridView1.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            helper.UpdateUser(listMember, lblID.Text, chkIsActive.Checked, chkIsAdmin.Checked, userLoggedIn);
            ReloadData();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            lblID.Text = "";
            dataGridView1.ClearSelection();
            chkIsActive.Checked = true;
            chkIsAdmin.Checked = false;
        }

        private void UserManage_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            if (!this.DesignMode)
            {
                // Do stuff...
                ReloadData();
            }
            
            userLoggedIn = System.Configuration.ConfigurationManager.AppSettings[StaticKey.UserLoggedIn];
        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    chkIsAdmin.Checked = Convert.ToBoolean(listMember[e.RowIndex].IsAdmin);
                    chkIsActive.Checked = Convert.ToBoolean(listMember[e.RowIndex].Active);
                    txtUsername.Text = listMember[e.RowIndex].Username;
                    lblID.Text = listMember[e.RowIndex].Id.ToString();
                }
                catch { }
            }
        }
    }
}
