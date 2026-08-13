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
    public partial class ctrlApplicationBasicInfo : UserControl
    {
        clsApplications Application = new clsApplications();

        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            linkViewPersonInfo.Enabled = true;

            clsPeople Person = clsPeople.FindByID(Application.ApplicantPersonID);
            clsUsers User = clsUsers.GetUserInfoByID(Application.CreatedByUserID);

            lblID.Text = Application.ApplicationID.ToString();
            lblDate.Text = Application.ApplicationDate.ToString();
            lblFees.Text = Application.PaidFees.ToString();
            lblCreatedBy.Text = User.UserName;


            lblStatus.Text = Application.StatusText;
            lblApplicant.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName; ;
            lblType.Text = Application.ApplicationTypeID.ToString();
            lblStatusDate.Text = Application.LastStatusDate.ToString();
        }

        public void _LoadApplicationInfoData(int ApplicationID)
        {
            Application = clsApplications.FindBaseApplication(ApplicationID);
            _LoadData();
        }

        private void linkViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          Person_Details frm = new Person_Details(Application.ApplicantPersonID);
         // frm. += SetPersonIDFromDataBack;
          frm.ShowDialog();
        }

        private void SetPersonIDFromDataBack(object sender, int PersonID)
        {
            //_LoadPersonInfoData(PersonID);
        }

        public void ResetApplicationInfo()
        {
            lblStatus.Text = "[????]";
            lblApplicant.Text = "[????]";
            lblType.Text = "[????]";
            lblStatusDate.Text = "[????]";
            lblID.Text = "[????]";
            lblDate.Text = "[????]";
            lblFees.Text = "[????]";
            lblCreatedBy.Text = "[????]";
        }
    }
}
