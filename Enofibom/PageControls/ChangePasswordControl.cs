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

namespace Enofibom.PageControls
{
    public partial class ChangePasswordControl : UserControl
    {
        DBHelper helper = new DBHelper();
        string userLoggedIn = "";
        public ChangePasswordControl()
        {
            InitializeComponent();
        }

        private void ShowErrorNotify(string msg)
        {
            lblNotify.Text = msg;
            lblNotify.Visible = true;
            lblNotify.ForeColor = Color.Red;
        }

        private void ShowSuccessNotify(string msg)
        {
            lblNotify.Text = msg;
            lblNotify.Visible = true;
            lblNotify.ForeColor = Color.Green;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            var currentpassword = StaticKey.CreateMD5(txtOldpassword.Text);
            var newpassword = StaticKey.CreateMD5(txtNewpassword.Text);
            var retypePass = StaticKey.CreateMD5(txtRetypenewpassword.Text);
            var currUser = helper.GetUserLogin(userLoggedIn,currentpassword);
            if(currUser != null)
            {
                if (newpassword != currentpassword)
                {
                    if(newpassword == retypePass)
                    {
                        try
                        {
                            helper.UpdatePassword(currUser.Id, newpassword);
                            ShowSuccessNotify("Password changed!!!");
                            txtNewpassword.Text = txtOldpassword.Text = txtRetypenewpassword.Text = "";
                        }
                        catch
                        {
                            ShowErrorNotify("Error! Check Database connection!");
                        }
                    }
                    else
                    {
                        ShowErrorNotify("Retype password check!");
                    }
                }
                else
                {
                    ShowErrorNotify("New password must not be same old password!");
                }
            }
            else
            {
                ShowErrorNotify("Failed! Wrong password");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void ChangePasswordControl_Load(object sender, EventArgs e)
        {
            userLoggedIn = System.Configuration.ConfigurationManager.AppSettings[StaticKey.UserLoggedIn];
        }
    }
}
