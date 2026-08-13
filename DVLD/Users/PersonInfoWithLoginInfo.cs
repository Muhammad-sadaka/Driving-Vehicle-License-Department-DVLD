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

namespace DVLD.Users
{
    public partial class PersonInfoWithLoginInfo : UserControl
    {
        int _UserID = -1;
        clsUsers _UserInfo = new clsUsers();
        public int UserID { get { return _UserID; } }
        public PersonInfoWithLoginInfo()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID)
        {
            _UserInfo = clsUsers.GetUserInfoByID(UserID);
            if (_UserInfo == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No _User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }

        private void _FillUserInfo()
        {

            ctrlPersonInformation1._LoadPersonInfoData(_UserInfo.PersonID);
            lblUserID.Text = _UserInfo.UserID.ToString();
            lblUsername.Text = _UserInfo.UserName.ToString();

            if (_UserInfo.IsActive)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";

        }

        private void _ResetPersonInfo()
        {
            ctrlPersonInformation1.ResetPersonInfo();
            lblUserID.Text = "[???]";
            lblUsername.Text = "[???]";
            lblIsActive.Text = "[???]";
        }
    }
}
