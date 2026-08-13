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
using DVLD.Global_Classes;

namespace DVLD
{
    public partial class NewLocalDrivingLicenseApplication : Form
    {
        int _LocalDrivingLicenseApplicationID = -1;
        private int _SelectedPersonID = -1;
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();

        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        public NewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public NewLocalDrivingLicenseApplication(int LDLApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LDLApplicationID;
            _Mode = enMode.Update;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (_SelectedPersonID != -1)
            {

                btnSave.Enabled = true;
                tabPage2.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];

            }

            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonInfoWithFilter1.FilterFocus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            int LicenseClassID = clsLicenseClasses.Find(cBLicenseClasses.Text).LicenseClassID;


            int ActiveApplicationID = clsApplications.GetActiveApplicationIDForLicenseClass(_SelectedPersonID, clsApplications.enApplicationType.NewDrivingLicense, LicenseClassID);

            if (ActiveApplicationID > 0)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBLicenseClasses.Focus();
                return;
            }


            //check if user already have issued license of the same driving  class.

            if (clsLicenses.IsLicenseExistByPersonID(ctrlPersonInfoWithFilter1.PersonID, LicenseClassID))
            {

                MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LocalDrivingLicenseApplication.ApplicantPersonID = ctrlPersonInfoWithFilter1.PersonID; ;
            _LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApplication.ApplicationTypeID = 1;
            _LocalDrivingLicenseApplication.ApplicationStatus = clsApplications.enApplicationStatus.New;
            _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            _LocalDrivingLicenseApplication.PaidFees = Convert.ToSingle(lblFees.Text);
            _LocalDrivingLicenseApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _LocalDrivingLicenseApplication.LicenseClassID = LicenseClassID;


            if (_LocalDrivingLicenseApplication.Save())
            {
                lblDLApplicationID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Local Driving License Application";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _FillLicenseClassesInComboBox()
        {
            DataTable dtLicenseClasses = clsLicenseClasses.GetAllLicenseClasses();
            foreach (DataRow row in dtLicenseClasses.Rows)
            {
                cBLicenseClasses.Items.Add(row["ClassName"]);
            }
            cBLicenseClasses.SelectedIndex = 2;
        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values
            _FillLicenseClassesInComboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "New Local Driving License Application";
                this.Text = "New Local Driving License Application";
                _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
                ctrlPersonInfoWithFilter1.FilterFocus();
                tabPage2.Enabled = false;

                cBLicenseClasses.SelectedIndex = 2;
                lblFees.Text = clsApplicationTypes.FindByID((int)clsApplications.enApplicationType.NewDrivingLicense).Fees.ToString();
                lblDateNow.Text = DateTime.Now.ToShortDateString();
                lblCurrentUser.Text = clsGlobal.CurrentUser.UserName;
            }
            else
            {
                lblTitle.Text = "Update Local Driving License Application";
                this.Text = "Update Local Driving License Application";
                tabPage2.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void _LoadData()
        {
            ctrlPersonInfoWithFilter1.FilterEnabled = false;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("No Application with ID = " + _LocalDrivingLicenseApplicationID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            ctrlPersonInfoWithFilter1.LoadPersonInfo(_LocalDrivingLicenseApplication.ApplicantPersonID);
            lblDLApplicationID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblDateNow.Text = clsFormat.DateToShort(_LocalDrivingLicenseApplication.ApplicationDate);
            //cBLicenseClasses.SelectedIndex = cBLicenseClasses.FindString(clsLicenseClasses.GetLicenseClassInfoByID(_LocalDrivingLicenseApplication.LicenseClassID).ClassName);
            lblFees.Text = _LocalDrivingLicenseApplication.PaidFees.ToString();
            lblCurrentUser.Text = clsUsers.GetUserInfoByID(_LocalDrivingLicenseApplication.CreatedByUserID).UserName;
        }

        private void ctrlPersonInfoWithFilter1_OnSearchSelected(int obj)
        {
            _SelectedPersonID = obj;
        }

        private void NewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
            {
                _LoadData();
            }
        }

        private void NewLocalDrivingLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlPersonInfoWithFilter1.FilterFocus();
        }
    }
}
