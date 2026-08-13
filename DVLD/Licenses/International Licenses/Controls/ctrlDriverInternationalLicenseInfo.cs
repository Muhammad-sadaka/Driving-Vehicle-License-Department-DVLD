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
    public partial class ctrlDriverInternationalLicenseInfo : UserControl
    {
        clsInternationalLicenseApplications IntLicense = new clsInternationalLicenseApplications();
        public ctrlDriverInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        public void LoadIntLicenseInfoData(int IntLicenseID)
        {
            IntLicense = clsInternationalLicenseApplications.Find(IntLicenseID);
            if(IntLicense != null)
            {
                lblName.Text = IntLicense.ApplicantFullName;
                lblIntLicenseID.Text = IntLicense.InternationalLicenseID.ToString();
                lblLicenseID.Text = IntLicense.IssuedUsingLocalLicenseID.ToString();
                lblNationalNo.Text = IntLicense.DriverInfo.PersonInfo.NationalNo;
                lblGender.Text = IntLicense.DriverInfo.PersonInfo.Gender.ToString();
                lblIssueDate.Text = IntLicense.IssueDate.ToString();
                lblApplicationID.Text = IntLicense.ApplicationID.ToString();
                lblIsActive.Text = IntLicense.IsActive.ToString();
                lblDateOfBirth.Text = IntLicense.DriverInfo.PersonInfo.DateOfBirth.ToString();
                lblDriverID.Text = IntLicense.DriverID.ToString();
                lblExpariationDate.Text = IntLicense.ExpirationDate.ToString();
            } 
            else
                MessageBox.Show("Not Found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
