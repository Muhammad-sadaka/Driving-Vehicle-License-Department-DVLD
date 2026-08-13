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
    public partial class Detain_License : Form
    {
        private int _DetainID = -1;
        private int _SelectedLicenseID = -1;

        public Detain_License()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnSearchSelected(int obj)
        {

            _SelectedLicenseID = obj;

            lblLicensID.Text = _SelectedLicenseID.ToString();

            KlblShowLicenseHistory.Enabled = (_SelectedLicenseID != -1);

            if (_SelectedLicenseID == -1)

            {
                return;
            }

            //ToDo: make sure the license is not detained already.
            if (ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License i already detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tBFineFees.Focus();
            btnDetain.Enabled = true;
        }

        private void KlblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void klblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(_SelectedLicenseID);
            frm.ShowDialog();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            //check the license is not Active.
            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;
                return;
            }

            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            _DetainID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Detain(Convert.ToSingle(tBFineFees.Text), clsGlobal.CurrentUser.UserID);
            if (_DetainID == -1)
            {
                MessageBox.Show("Faild to Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblDetainID.Text = _DetainID.ToString();
            MessageBox.Show("License Detained Successfully with ID=" + _DetainID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnDetain.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            tBFineFees.Enabled = false;
            klblShowLicenseInfo.Enabled = true;
        }

        private void tBFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tBFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tBFineFees, "Fees cannot be empty.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tBFineFees, "");
            }
        }

        private void Detain_License_Load(object sender, EventArgs e)
        {
            lblDetainDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
        }

        private void Detain_License_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
    }
}
