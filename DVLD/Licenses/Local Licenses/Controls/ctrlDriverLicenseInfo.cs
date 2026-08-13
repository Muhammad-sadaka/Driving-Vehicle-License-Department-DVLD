using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DVLDBusinessLayer;
using DVLD.Properties;
using DVLD.Global_Classes;

namespace DVLD
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        private int _LicenseID;
        private clsLicenses _License;

        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();

        }

        public int LicenseID
        {
            get { return _LicenseID; }
        }

        public clsLicenses SelectedLicenseInfo
        { get { return _License; } }

        private void _LoadPersonImage()
        {
            if (_License.DriverInfo.PersonInfo.Gender == 0)
                pBPersonalImage.Image = Resources.male_v2;
            else
                pBPersonalImage.Image = Resources.female_v2;

            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pBPersonalImage.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public void LoadInfo(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = clsLicenses.Find(_LicenseID);
            if (_License == null)
            {
                MessageBox.Show("Could not find License ID = " + _LicenseID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = -1;
                return;
            }

            lblLicenseID.Text = _License.LicenseID.ToString();
            lblIsActive.Text = _License.IsActive ? "Yes" : "No";
            lblIsDetained.Text = _License.IsDetained ? "Yes" : "No";
            lblClassName.Text = _License.LicenseClassIfo.ClassName;
            lblName.Text = _License.DriverInfo.PersonInfo.FullName;
            lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
            lblGender.Text = _License.DriverInfo.PersonInfo.Gender == 0 ? "Male" : "Female";
            lblDateOfBirth.Text = clsFormat.DateToShort(_License.DriverInfo.PersonInfo.DateOfBirth);

            lblDriverID.Text = _License.DriverID.ToString();
            lblIssueDate.Text = clsFormat.DateToShort(_License.IssueDate);
            lblExpirationDate.Text = clsFormat.DateToShort(_License.ExpirationDate);
            lblIssueReason.Text = _License.IssueReasonText;
            lblNotes.Text = _License.Notes == "" ? "No Notes" : _License.Notes;
            _LoadPersonImage();
        }
    }
}
