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
    public partial class Local_Driving_License_Applicarions : Form
    {
        private DataTable _dtAllLocalDrivingLicenseApplications;

        public Local_Driving_License_Applicarions()
        {
            InitializeComponent();
        }

        private void Local_Driving_License_Applicarions_Load(object sender, EventArgs e)
        {
            _dtAllLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
            DGVManageApplications.DataSource = _dtAllLocalDrivingLicenseApplications;

            lblResultRecords.Text = DGVManageApplications.Rows.Count.ToString();
            if (DGVManageApplications.Rows.Count > 0)
            {

                DGVManageApplications.Columns[0].HeaderText = "L.D.L.AppID";
                DGVManageApplications.Columns[0].Width = 120;

                DGVManageApplications.Columns[1].HeaderText = "Driving Class";
                DGVManageApplications.Columns[1].Width = 300;

                DGVManageApplications.Columns[2].HeaderText = "National No.";
                DGVManageApplications.Columns[2].Width = 150;

                DGVManageApplications.Columns[3].HeaderText = "Full Name";
                DGVManageApplications.Columns[3].Width = 350;

                DGVManageApplications.Columns[4].HeaderText = "Application Date";
                DGVManageApplications.Columns[4].Width = 170;

                DGVManageApplications.Columns[5].HeaderText = "Passed Tests";
                DGVManageApplications.Columns[5].Width = 150;
            }

            cBFilterBy.SelectedIndex = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewLicense_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicenseApplication frm = new NewLocalDrivingLicenseApplication();
                frm.ShowDialog();
            Local_Driving_License_Applicarions_Load(null,null);
        }

        private void cBFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tBFilterValue.Visible = !(cBFilterBy.SelectedIndex == 0);
            tBFilterValue.Focus();
            tBFilterValue.Clear();

            _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
            lblResultRecords.Text = DGVManageApplications.Rows.Count.ToString();

        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewLocalDrivingLicenseApplication frm = new NewLocalDrivingLicenseApplication((int)DGVManageApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            Local_Driving_License_Applicarions_Load(null,null);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)DGVManageApplications.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                    clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID
                                                    (LocalDrivingLicenseApplicationID);

            int TotalPassedTests = (int)DGVManageApplications.CurrentRow.Cells[5].Value;

            bool LicenseExists = LocalDrivingLicenseApplication.IsLicenseIssued();

            //Enabled only if person passed all tests and Does not have license. 
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = (TotalPassedTests == 3) && !LicenseExists;

            showLicenseToolStripMenuItem.Enabled = LicenseExists;
            editApplicationToolStripMenuItem.Enabled = !LicenseExists && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplications.enApplicationStatus.New);
            sechduleTestsToolStripMenuItem.Enabled = !LicenseExists;

            //Enable/Disable Cancel Menue Item
            //We only canel the applications with status=new.
            cancelApplicationToolStripMenuItem.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus == clsApplications.enApplicationStatus.New);

            //Enable/Disable Delete Menue Item
            //We only allow delete incase the application status is new not complete or Cancelled.
            deleteApplicationToolStripMenuItem.Enabled =
                (LocalDrivingLicenseApplication.ApplicationStatus == clsApplications.enApplicationStatus.New);



            //Enable Disable Schedule menue and it's sub menue
            bool PassedVisionTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestTypes.enTestType.VisionTest); ;
            bool PassedWrittenTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestTypes.enTestType.WrittenTest);
            bool PassedStreetTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestTypes.enTestType.StreetTest);

            sechduleTestsToolStripMenuItem.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplications.enApplicationStatus.New);

            if (sechduleTestsToolStripMenuItem.Enabled)
            {
                //To Allow Schdule vision test, Person must not passed the same test before.
                scheduleVisionTestToolStripMenuItem.Enabled = !PassedVisionTest;

                //To Allow Schdule written test, Person must pass the vision test and must not passed the same test before.
                scheduleWrittenTestToolStripMenuItem.Enabled = PassedVisionTest && !PassedWrittenTest;

                //To Allow Schdule steet test, Person must pass the vision * written tests, and must not passed the same test before.
                scheduleStreetTestToolStripMenuItem.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;

            }
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLocalApplicationInfo frm = new frmLocalDrivingLocalApplicationInfo((int)DGVManageApplications.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
            Local_Driving_License_Applicarions_Load(null, null);
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to delete this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseApplicationID = (int)DGVManageApplications.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            if (LocalDrivingLicenseApplication != null)
            {
                if (LocalDrivingLicenseApplication.Delete())
                {
                    MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh the form again.
                    Local_Driving_License_Applicarions_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Could not delete applicatoin, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseApplicationID = (int)DGVManageApplications.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            if (LocalDrivingLicenseApplication != null)
            {
                if (LocalDrivingLicenseApplication.Cancel())
                {
                    MessageBox.Show("Application Cancelled Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh the form again.
                    Local_Driving_License_Applicarions_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Could not cancel applicatoin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)DGVManageApplications.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            frmLicenseHistory frm = new frmLicenseHistory(localDrivingLicenseApplication.ApplicantPersonID);
            frm.ShowDialog();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)DGVManageApplications.CurrentRow.Cells[0].Value;

            int LicenseID = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(
               LocalDrivingLicenseApplicationID).GetActiveLicenseID();

            if (LicenseID != -1)
            {
                frmLicenseInfo frm = new frmLicenseInfo(LicenseID);
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("No License Found!", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _ScheduleTest(clsTestTypes.enTestType.VisionTest);
        }

        private void tBFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cBFilterBy.SelectedIndex == 1)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void tBFilterValue_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cBFilterBy.SelectedIndex)
            {
                case 1:
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;

                case 2:
                    FilterColumn = "NationalNo";
                    break;

                case 3:
                    FilterColumn = "FullName";
                    break;

                case 4:
                    FilterColumn = "Status";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tBFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
                lblResultRecords.Text = DGVManageApplications.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "LocalDrivingLicenseApplicationID")
                //in this case we deal with integer not string.
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tBFilterValue.Text.Trim());
            else
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tBFilterValue.Text.Trim());

            lblResultRecords.Text = DGVManageApplications.Rows.Count.ToString();
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _ScheduleTest(clsTestTypes.enTestType.StreetTest);
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _ScheduleTest(clsTestTypes.enTestType.WrittenTest);
        }

        private void _ScheduleTest(clsTestTypes.enTestType TestType)
        {

            int LocalDrivingLicenseApplicationID = (int)DGVManageApplications.CurrentRow.Cells[0].Value;
            frmTestAppointments frm = new frmTestAppointments(LocalDrivingLicenseApplicationID, TestType);
            frm.ShowDialog();
            //refresh
            Local_Driving_License_Applicarions_Load(null, null);

        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)DGVManageApplications.CurrentRow.Cells[0].Value;
            frmIssueDriverLicenseFirstTime frm = new frmIssueDriverLicenseFirstTime(LocalDrivingLicenseApplicationID);
            frm.ShowDialog();
            Local_Driving_License_Applicarions_Load(null,null);
        }
    }
}
