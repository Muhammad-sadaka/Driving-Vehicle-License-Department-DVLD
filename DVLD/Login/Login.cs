using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;
using System.IO;
using DVLD.Global_Classes;

namespace DVLD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsUsers user = clsUsers.FindByUsernameAndPassword(tBUserName.Text.Trim(), tBPassword.Text.Trim());

            if (user != null)
            {

                if (ckbRememberMe.Checked)
                {
                    //store username and password
                    //clsGlobal.RememberUsernameAndPassword(tBUserName.Text.Trim(), tBPassword.Text.Trim());
                    clsGlobal.RememberUsernameAndPasswordRegistry(tBUserName.Text.Trim(), tBPassword.Text.Trim());
                }
                else
                {
                    //store empty username and password
                    clsGlobal.RememberUsernameAndPasswordRegistry("", "");

                }

                //incase the user is not active
                if (!user.IsActive)
                {

                    tBUserName.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsGlobal.CurrentUser = user;
                this.Hide();
                MainForm frm = new MainForm(this);
                frm.ShowDialog();
            }
            else
            {
                tBUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tBUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBUserName.Text))
            {
                e.Cancel = true;
                tBUserName.Focus();
                errorProvider1.SetError(tBUserName, "UserName should have a value");
            }
        }

        private void tBPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBPassword.Text))
            {
                e.Cancel = true;
                tBPassword.Focus();
                errorProvider1.SetError(tBPassword, "Password should have a value");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Old
            //string UserName = "", Password = "";

            //if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            //{
            //    tBUserName.Text = UserName;
            //    tBPassword.Text = Password;
            //    ckbRememberMe.Checked = true;
            //}
            //else
            //    ckbRememberMe.Checked = false;

            //New
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredentialRegistry(ref UserName, ref Password))
            {
                tBUserName.Text = UserName;
                tBPassword.Text = Password;
                ckbRememberMe.Checked = true;
            }
            else
                ckbRememberMe.Checked = false;
        }
    }
}
