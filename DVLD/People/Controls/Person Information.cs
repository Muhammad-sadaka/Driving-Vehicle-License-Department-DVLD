using DVLD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using DVLDBusinessLayer;
using DVLD.People;
using DVLD.Global_Classes;

namespace DVLD
{
    public partial class ctrlPersonInformation : UserControl
    {

        clsPeople _Person;

        int _PersonID
        {
            get; set;
        }

        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPeople SelectedPersonInfo
        {
            get { return _Person; }
        }

        public string _NationalNo
        {
            get; set;
        }


        public ctrlPersonInformation()
        {
            InitializeComponent();
        }

        private void _FillPersonInfo()
        {
            lblEditPersonInfo.Enabled = true;
            _PersonID = _Person.PersonID;
            lblAddressData.Text = _Person.Address;
            lblDateOfBirthData.Text = _Person.DateOfBirth.ToString();
            lblEmailData.Text = _Person.Email;
            lblGenderData.Text = _Person.Gender == 0 ? "Male" : "Female";
            lblNameData.Text = _Person.FullName;
            lblNationalNoData.Text = _Person.NationalNo;
            lblPersonIDData.Text = _Person.PersonID.ToString();
            lblPhoneData.Text = _Person.Phone;
            lblCountryData.Text = clsCountries.FindConuntryByID(_Person.NationalityCountryID).CountryName;

            _LoadPersonImage();

        }

        public void _LoadPersonInfoData(int PersonID)
        {
            _Person = clsPeople.FindByID(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

         public void _LoadPersonInfoData(string NationalNo)
        {
                _Person = clsPeople.FindByNationalNo(NationalNo);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National No = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        private void _LoadPersonImage()
        {
            if (_Person.Gender == 0)
                pBPersonalImage.Image = Resources.male_v2;
            else
                pBPersonalImage.Image = Resources.female_v2;

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pBPersonalImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblEditPersonInfo.Enabled = false;
            lblPersonIDData.Text = "[????]";
            lblNationalNoData.Text = "[????]";
            lblNameData.Text = "[????]";
            pbGender.Image = Resources.Man32;
            lblGenderData.Text = "[????]";
            lblEmailData.Text = "[????]";
            lblPhoneData.Text = "[????]";
            lblDateOfBirthData.Text = "[????]";
            lblCountryData.Text = "[????]";
            lblAddressData.Text = "[????]";
            pBPersonalImage.Image = Resources.Person32;

        }


        private void lblEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (clsGlobal.CurrentUser.Permissions == 0)
            {
                frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
                frm.ShowDialog();
                _LoadPersonInfoData(_PersonID);
            }
            else
            {
                MessageBox.Show("You Don't Have Permission To Enter!, Contact Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
