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
    public partial class UserManage : UserControl
    {
        DBHelper helper = new DBHelper();
        List<Member> listMember = new List<Member>();
        public UserManage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var username = txtUsername.Text;
                var chkActive = chkIsActive.Checked;
                var chkAdmin = chkIsAdmin.Checked;
                var newUser = new Member
                {
                    Username = username,
                    Password = StaticKey.CreateMD5("123456"),
                    Active = chkActive,
                    IsAdmin = chkAdmin
                };
                helper.InsertUser(newUser);
                ReloadData();
            }
            catch { }
            
            
        }

        private void ReloadData()
        {
            listMember = helper.GetAllMember();
            dataGridView1.DataSource = listMember;
            dataGridView1.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(lblID.Text);
                var mem = listMember.Where(m => m.Id == id).FirstOrDefault();
                if (mem != null)
                {
                    helper.UpdateUser(mem,chkIsActive.Checked, chkIsAdmin.Checked);
                    ReloadData();
                }
            }
            catch { }
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
            ReloadData();
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
