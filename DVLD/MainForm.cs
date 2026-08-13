using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.People;
using DVLD.Global_Classes;

namespace DVLD
{
    public partial class MainForm : Form
    {
        Login _frmLogin;

        public MainForm(Login frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeople frm = new frmPeople();
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password frm = new Change_Password(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Users frm = new Manage_Users();
            frm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfo frm = new UserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.Permissions == 0 || clsGlobal.CurrentUser.Permissions == 1)
            {
                Detain_License frm = new Detain_License();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Don't Have Permission To Enter!, Contact Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.Permissions == 0 || clsGlobal.CurrentUser.Permissions == 1)
            {
                NewLocalDrivingLicenseApplication frm = new NewLocalDrivingLicenseApplication();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Don't Have Permission To Enter!, Contact Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Local_Driving_License_Applicarions frm = new Local_Driving_License_Applicarions();
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new ManageDrivers();
            frm.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageApplicationTypes frm = new ManageApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestTypes frm = new ManageTestTypes();
            frm.ShowDialog();
        }

        private void chatBotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChatBotKnowledge frm = new frmChatBotKnowledge();
            frm.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDetainedLicenses frm = new frmListDetainedLicenses();
            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.Permissions == 0)
            {
                frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Don't Have Permission To Enter!, Contact Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseApplications frm = new frmInternationalLicenseApplications();
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Local_Driving_License_Applicarions frm = new Local_Driving_License_Applicarions();
            frm.ShowDialog();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.Permissions == 0 || clsGlobal.CurrentUser.Permissions == 1)
            {
                frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Don't Have Permission To Enter!, Contact Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.Permissions == 0 || clsGlobal.CurrentUser.Permissions == 1)
            {
                frmReplacementForDamagedLicense frm = new frmReplacementForDamagedLicense();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Don't Have Permission To Enter!, Contact Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.Permissions == 0 || clsGlobal.CurrentUser.Permissions == 1)
            {
                frmRenewLicenseApplication frm = new frmRenewLicenseApplication();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Don't Have Permission To Enter!, Contact Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.Permissions == 0 || clsGlobal.CurrentUser.Permissions == 1)
            {
                frmNewInternationalLicenseApplications frm = new frmNewInternationalLicenseApplications();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("You Don't Have Permission To Enter!, Contact Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        }
    }
}
