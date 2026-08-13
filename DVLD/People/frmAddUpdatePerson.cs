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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Runtime.ConstrainedExecution;

using DVLD.Global_Classes;

namespace DVLD.People
{
    public partial class frmAddUpdatePerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler PersonIDDataBack;


        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGender { Male = 0, Female = 1 };
        enMode _Mode = enMode.AddNew;
        private int _PersonID = -1;
        clsPeople _Person = new clsPeople();

        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = PersonID;
        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResestDefualtValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void _FillCountriesInComboBox()
        {
            DataTable dtCountries = clsCountries.GetAllCountries();
            foreach (DataRow row in dtCountries.Rows)
            {
                cBCountries.Items.Add(row["CountryName"]);
            }
        }

        private void _SelectDateTime()
        {
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);
            dateTimePicker1.MinDate = DateTime.Today.AddYears(-100);
            dateTimePicker1.Value = dateTimePicker1.MaxDate;
        }

        private void _ResestDefualtValues()
        {
            _FillCountriesInComboBox();

            if (_Mode == enMode.AddNew)
            {
                _Person = new clsPeople();
                lblTtile.Text = "Add new _Person";
            }
            else
                lblTtile.Text = "Update _Person";


            if (rBMale.Checked)
                pBPersonalImage.Image = Properties.Resources.male_v2;
            else
                pBPersonalImage.Image = Properties.Resources.female_v2;

            lbllinkRemove.Visible = (pBPersonalImage.ImageLocation != null);

            _SelectDateTime();

            cBCountries.SelectedIndex = cBCountries.FindString("Syria");

            tBNationalNo.Text = "";
            tBFirstName.Text = "";
            tBSecondName.Text = "";
            tBThirdName.Text = "";
            tBLastName.Text = "";
            tBEmail.Text = "";
            tBPhone.Text = "";
            tBAddress.Text = "";
            rBMale.Checked = true;
        }

        private void _LoadData()
        {
            _Person = clsPeople.FindByID(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because No _Person with ID = " + _PersonID);
                this.Close();
                return;
            }

            lblID.Text = _Person.PersonID.ToString();
            tBNationalNo.Text = _Person.NationalNo;
            tBFirstName.Text = _Person.FirstName;
            tBSecondName.Text = _Person.SecondName;
            tBThirdName.Text = _Person.ThirdName;
            tBLastName.Text = _Person.LastName;
            tBEmail.Text = _Person.Email;
            tBPhone.Text = _Person.Phone;
            tBAddress.Text = _Person.Address;
            dateTimePicker1.Value = _Person.DateOfBirth;
            cBCountries.SelectedIndex = cBCountries.FindString(_Person.CountryInfo.CountryName);

            if (_Person.Gender == 0)
                rBMale.Checked = true;
            else
                rBFemale.Checked = true;

            if (_Person.ImagePath != "" && _Person.ImagePath != null)
            {
                pBPersonalImage.ImageLocation = _Person.ImagePath;
            }
            lbllinkRemove.Visible = (_Person.ImagePath != "");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tBFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBFirstName.Text))
            {
                e.Cancel = true;
                tBFirstName.Focus();
                errorProvider1.SetError(tBFirstName, "FirstName should have a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tBFirstName, "");
            }
        }

        private void tBSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBSecondName.Text))
            {
                e.Cancel = true;
                tBSecondName.Focus();
                errorProvider1.SetError(tBSecondName, "SecondName should have a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tBSecondName, "");
            }
        }

        private void tBThirdName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBThirdName.Text))
            {
                e.Cancel = true;
                tBThirdName.Focus();
                errorProvider1.SetError(tBThirdName, "ThirdName should have a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tBThirdName, "");
            }
        }

        private void tBLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBLastName.Text))
            {
                e.Cancel = true;
                tBLastName.Focus();
                errorProvider1.SetError(tBLastName, "LastName should have a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tBLastName, "");
            }
        }

        private void tBNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBNationalNo.Text))
            {
                e.Cancel = true;
                tBNationalNo.Focus();
                errorProvider1.SetError(tBNationalNo, "National No should have a value");
            }
            if (clsPeople.FindByNationalNo(tBNationalNo.Text) != null)
            {
                e.Cancel = true;
                tBNationalNo.Focus();
                errorProvider1.SetError(tBNationalNo, "National No is already exist");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tBNationalNo, "");
            }
        }

        private void tBPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBPhone.Text))
            {
                e.Cancel = true;
                tBPhone.Focus();
                errorProvider1.SetError(tBPhone, "Phone should have a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tBPhone, "");
            }
        }

        private void tBAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBAddress.Text))
            {
                e.Cancel = true;
                tBAddress.Focus();
                errorProvider1.SetError(tBAddress, "Address should have a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tBAddress, "");
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rBMale_CheckedChanged(object sender, EventArgs e)
        {
            if (pBPersonalImage.ImageLocation == null)
            {
                if (rBMale.Checked)
                    pBPersonalImage.Image = Properties.Resources.male_v2;
                else
                    pBPersonalImage.Image = Properties.Resources.female_v2;
            }
        }

        private bool _HandlePersonImage()
        {
            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.

            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_Person.ImagePath != pBPersonalImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (pBPersonalImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pBPersonalImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pBPersonalImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                return;
            }

            if (!_HandlePersonImage())
                return;

            _Person.NationalityCountryID = clsCountries.FindConuntryByName(cBCountries.Text).CountryID;
            _Person.NationalNo = tBNationalNo.Text.Trim();
            _Person.FirstName = tBFirstName.Text.Trim();
            _Person.SecondName = tBSecondName.Text.Trim();
            _Person.ThirdName = tBThirdName.Text.Trim();
            _Person.LastName = tBLastName.Text.Trim();
            _Person.Email = tBEmail.Text.Trim();
            _Person.Phone = tBPhone.Text.Trim();
            _Person.Address = tBAddress.Text.Trim();
            _Person.DateOfBirth = dateTimePicker1.Value;

            if (rBMale.Checked)
                _Person.Gender = (short) enGender.Male;
            else
                _Person.Gender = (short) enGender.Female;

            if (pBPersonalImage.ImageLocation != null)
                _Person.ImagePath = pBPersonalImage.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
                lblID.Text = _Person.PersonID.ToString();
                _Mode = enMode.Update;
                lblTtile.Text = "Update Person";
                MessageBox.Show("Data Saved Successfully.");

                PersonIDDataBack?.Invoke(this, _PersonID);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.");
            }
        }

        private void linklblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pBPersonalImage.Load(selectedFilePath);
                lbllinkRemove.Visible = true;
                // ...
            }
        }

        private void lbllinkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pBPersonalImage.ImageLocation = null;
            lbllinkRemove.Visible = false;

            if (rBMale.Checked)
                pBPersonalImage.Image = Properties.Resources.male_v2;
            else
                pBPersonalImage.Image = Properties.Resources.female_v2;

        }

        private void tBFirstName_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBFirstName.Text.Trim()))
            {
                e.Cancel = true;
                tBFirstName.Focus();
                errorProvider1.SetError(tBFirstName, "FirstName should have a value");
            }
        }

        private void tBSecondName_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBSecondName.Text.Trim()))
            {
                e.Cancel = true;
                tBSecondName.Focus();
                errorProvider1.SetError(tBSecondName, "SecondName should have a value");
            }
        }

        private void tBLastName_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBLastName.Text.Trim()))
            {
                e.Cancel = true;
                tBLastName.Focus();
                errorProvider1.SetError(tBLastName, "LastName should have a value");
            }
        }

        private void tBEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBEmail.Text.Trim()))
                return;

            if (!clsValidation.ValidateEmail(tBEmail.Text))
            {
                e.Cancel = true;
                tBLastName.Focus();
                errorProvider1.SetError(tBEmail, "This is a wrong email format it should end with (@gmail.com).");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tBEmail, "");
            }
        }

        private void tBNationalNo_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                tBNationalNo.Focus();
                errorProvider1.SetError(tBNationalNo, "NationalNo should have a value");
            }
            else if (tBNationalNo.Text.Trim() != _Person.NationalNo && clsPeople.isPersonExist(tBNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                tBNationalNo.Focus();
                errorProvider1.SetError(tBNationalNo, "This NationalNo is already exist");
            }
        }

        private void tBAddress_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBAddress.Text.Trim()))
            {
                e.Cancel = true;
                tBAddress.Focus();
                errorProvider1.SetError(tBAddress, "Address should have a value");
            }
        }

        private void tBPhone_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBPhone.Text.Trim()))
            {
                e.Cancel = true;
                tBPhone.Focus();
                errorProvider1.SetError(tBPhone, "Phone should have a value");
            }
        }

        private void tBPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        //private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        //{

        //    // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
        //    TextBox Temp = ((TextBox)sender);
        //    if (string.IsNullOrEmpty(Temp.Text.Trim()))
        //    {
        //        e.Cancel = true;
        //        errorProvider1.SetError(Temp, "This field is required!");
        //    }
        //    else
        //    {
        //        //e.Cancel = false;
        //        errorProvider1.SetError(Temp, null);
        //    }

        //}
    }
}
