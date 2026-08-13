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
using DVLD.Properties;

namespace DVLD
{
    public partial class frmTakeTest : Form
    {
        private int _AppointmentID;
        private clsTestTypes.enTestType _TestType;

        private int _TestID = -1;
        private clsTests _Test;

        public frmTakeTest(int AppointmentID, clsTestTypes.enTestType TestType)
        {
            InitializeComponent();
            _AppointmentID = AppointmentID;
            _TestType = TestType;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.",
                        "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No
               )
            {
                return;
            }

            _Test.TestAppointmentID = _AppointmentID;
            _Test.TestResult = rBPass.Checked;
            _Test.Notes = tBNotes.Text.Trim();
            _Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Test.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            LoadInfogBTestType();

            if (_TestID != -1)
            {
                _Test = clsTests.Find(_TestID);

                if (_Test.TestResult)
                    rBPass.Checked = true;
                else
                    rBFall.Checked = true;
                tBNotes.Text = _Test.Notes;

                btnSave.Enabled = false;
                lblLocked.Visible = true;
                rBFall.Enabled = false;
                rBPass.Enabled = false;
            }
            else
                _Test = new clsTests();
        }

        public void LoadInfogBTestType()
        {

            switch (_TestType)
            {

                case clsTestTypes.enTestType.VisionTest:
                    {
                        lblTitle.Text = "Vision Test";
                        pBTestType.Image = Resources.Vision_512;
                        break;
                    }

                case clsTestTypes.enTestType.WrittenTest:
                    {
                        lblTitle.Text = "Written Test";
                        pBTestType.Image = Resources.Written_Test_512;
                        break;
                    }
                case clsTestTypes.enTestType.StreetTest:
                    {
                        lblTitle.Text = "Street Test";
                        pBTestType.Image = Resources.driving_test_512;
                        break;

                    }
            }

            clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;


            int _LocalDrivingLicenseApplicationID = -1;
            clsTestAppointments _TestAppointment;


            if (_AppointmentID == -1)
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;


            _TestAppointment = clsTestAppointments.GetTestAppointmentInfoByID(_AppointmentID);

            //incase we did not find any appointment .
            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No  Appointment ID = " + _AppointmentID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _AppointmentID = -1;
                return;
            }

            _TestID = _TestAppointment.TestID;

            _LocalDrivingLicenseApplicationID = _TestAppointment.LDLApplicationID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalDrivingLicenseApplicationID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDLAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblDClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lblName.Text = _LocalDrivingLicenseApplication.PersonFullName;


            //this will show the trials for this test before 
            lblTrial.Text = _LocalDrivingLicenseApplication.TotalTrialsPerTest(_TestType).ToString();



            lblDate.Text = clsFormat.DateToShort(_TestAppointment.AppointmentDate);
            lblFees.Text = _TestAppointment.PaidFees.ToString();
            lblTestID.Text = (_TestAppointment.TestID == -1) ? "Not Taken Yet" : _TestAppointment.TestID.ToString();
        }
    }
}
