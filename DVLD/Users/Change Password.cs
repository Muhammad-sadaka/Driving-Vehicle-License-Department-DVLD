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

namespace DVLD
{
    public partial class Change_Password : Form
    {
        int _UserID;
        clsUsers _User = new clsUsers();

        public Change_Password(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }
        private void _ResetDefualtValues()
        {
            tBCurrentPass.Text = "";
            tBNewPass.Text = "";
            tBConfirmPass.Text = "";
            tBCurrentPass.Focus();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tBCurrentPass.Text))
            {
                e.Cancel = true;
                tBCurrentPass.Focus();
                errorProvider1.SetError(tBCurrentPass, "Current Password should have a value");
                return;
            }
            else if(tBCurrentPass.Text != _User.Password)
            {
                e.Cancel = true;
                tBCurrentPass.Focus();
                errorProvider1.SetError(tBCurrentPass, "Current Password is Wrong");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tBCurrentPass, "");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tBConfirmPass_Validating(object sender, CancelEventArgs e)
        {
            if (tBNewPass.Text.Trim() != tBConfirmPass.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(tBConfirmPass, "Confirm Password Should be the same value of New Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tBConfirmPass, "");
            }
        }

        private void tBNewPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tBNewPass.Text))
            {
                e.Cancel = true;
                tBNewPass.Focus();
                errorProvider1.SetError(tBNewPass, "NewPass should have a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tBNewPass, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = tBNewPass.Text;

            if (_User.Save())
            {
                MessageBox.Show("Password Changed Successfully.",
                   "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefualtValues();
            }
            else
            {
                MessageBox.Show("An Erro Occured, Password did not change.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tBConfirmPass_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = (tBConfirmPass.Text == tBNewPass.Text) && (tBCurrentPass.Text == _User.Password);
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            _User = clsUsers.GetUserInfoByID(_UserID);

            if (_User == null)
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Could not Find User with id = " + _UserID,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;

            }
            personInfoWithLoginInfo1.LoadUserInfo(_UserID);
        }
    }
}
