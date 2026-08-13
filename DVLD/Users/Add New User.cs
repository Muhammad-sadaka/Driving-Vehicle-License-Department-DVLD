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
    public partial class Add_New_User : Form
    {

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        int _UserID;
        clsUsers _User = new clsUsers();

        public Add_New_User()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public Add_New_User(int UserID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _UserID = UserID;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New _User";
                this.Text = "Add New _User";
                _User = new clsUsers();

                tabPage2.Enabled = false;

                ctrlPersonInfoWithFilter1.FilterFocus();
            }
            else
            {
                lblTitle.Text = "Update _User";
                this.Text = "Update _User";

                tabPage2.Enabled = true;
                btnSave.Enabled = true;


            }

            tBUserName.Text = "";
            tBPass.Text = "";
            tBConfirmPass.Text = "";
            chkIsActive.Checked = true;
            cBPermisssions.SelectedIndex = 2;


        }

        private void _LoadData()
        {
            _User = clsUsers.GetUserInfoByID(_UserID);
            if (!clsUsers.IsUserExist(_UserID))
            {
                MessageBox.Show("This form will be closed because No _User with ID = " + _UserID);
                this.Close();
                return;
            }

            lblUserID.Text = _UserID.ToString();
            tBUserName.Text = _User.UserName;
            tBPass.Text = _User.Password;
            tBConfirmPass.Text = _User.Password;
            cBPermisssions.SelectedIndex = _User.Permissions;
            chkIsActive.Checked = _User.IsActive;
            ctrlPersonInfoWithFilter1.LoadPersonInfo(_User.PersonID);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("There is an empty Feild.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.PersonID = ctrlPersonInfoWithFilter1.PersonID;
            _User.UserName = tBUserName.Text.Trim();
            _User.Password = tBPass.Text.Trim();
            _User.IsActive = chkIsActive.Checked;
            _User.Permissions = cBPermisssions.SelectedIndex;

            if (_User.Save())
            {
                MessageBox.Show("Data Saved Successfully.");

                lblUserID.Text = _User.UserID.ToString();
                _Mode = enMode.Update;
                lblTitle.Text = "Update _User";
                this.Text = "Update _User";
            }
            else
            {
                MessageBox.Show("Error: Data does not Saved Successfully.");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tabPage2.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
                return;
            }

            //incase of add new mode.
            if (ctrlPersonInfoWithFilter1.PersonID > 0)
            {
                if (clsUsers.IsUserExistByPersonID(ctrlPersonInfoWithFilter1.PersonID))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonInfoWithFilter1.FilterFocus();
                }

                else
                {
                    btnSave.Enabled = true;
                    tabPage2.Enabled = true;
                    tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
                }
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonInfoWithFilter1.FilterFocus();

            }
        }

        private void tBUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tBUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tBUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(tBUserName, null);
            };


            if (_Mode == enMode.AddNew)
            {

                if (clsUsers.IsUserExist(tBUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tBUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(tBUserName, null);
                };
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (_User.UserName != tBUserName.Text.Trim())
                {
                    if (clsUsers.IsUserExist(tBUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(tBUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(tBUserName, null);
                    };
                }
            }
        }

        private void tBPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBPass.Text.Trim()))
            {
                e.Cancel = true;
                tBPass.Focus();
                errorProvider1.SetError(tBPass, "NewPass should have a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tBPass, "");
            }

        }

        private void tBConfirmPass_Validating(object sender, CancelEventArgs e)
        {
            if (tBPass.Text != tBConfirmPass.Text)
            {
                e.Cancel = true;
                tBConfirmPass.Focus();
                errorProvider1.SetError(tBConfirmPass, "Confirm Password Should be the same value of New Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tBConfirmPass, "");
            }
        }

        private void Add_New_User_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }
    }
}
