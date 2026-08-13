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
    public partial class frmListDetainedLicenses : Form
    {
        private DataTable _dtDetainedLicenses;

        public frmListDetainedLicenses()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
            frmListDetainedLicenses_Load(null, null);
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            Detain_License frm = new Detain_License();
            frm.ShowDialog();
            frmListDetainedLicenses_Load(null, null);
        }

        private void cBFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBFilterValue.Visible = !(cBFilterBy.SelectedIndex == 0 || cBFilterBy.SelectedIndex == 2);
            cBIsReleased.Visible = (cBFilterBy.SelectedIndex == 2);
            tBFilterValue.Focus();
            tBFilterValue.Clear();
        }

        private void tBFilterValue_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cBFilterBy.Text)
            {
                case "Detain ID":
                    FilterColumn = "DetainID";
                    break;
                case "Is Released":
                    {
                        FilterColumn = "IsReleased";
                        break;
                    };

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Release Application ID":
                    FilterColumn = "ReleaseApplicationID";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tBFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtDetainedLicenses.DefaultView.RowFilter = "";
                lblResultRecords.Text = DGVDetainedLicenses.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "DetainID" || FilterColumn == "ReleaseApplicationID")
                //in this case we deal with numbers not string.
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tBFilterValue.Text.Trim());
            else
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tBFilterValue.Text.Trim());

            lblResultRecords.Text = _dtDetainedLicenses.Rows.Count.ToString();

        }

        private void tBFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cBFilterBy.Text == "Detain ID" || cBFilterBy.Text == "Release Application ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void cBIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {

            string FilterColumn = "IsReleased";
            string FilterValue = cBIsReleased.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtDetainedLicenses.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblResultRecords.Text = _dtDetainedLicenses.Rows.Count.ToString();  
        }

        private void frmListDetainedLicenses_Load(object sender, EventArgs e)
        {

            cBFilterBy.SelectedIndex = 0;

            _dtDetainedLicenses = clsDetainedLicenses.GetAllDetainedLicenses();

            DGVDetainedLicenses.DataSource = _dtDetainedLicenses;
            lblResultRecords.Text = DGVDetainedLicenses.Rows.Count.ToString();

            if (DGVDetainedLicenses.Rows.Count > 0)
            {
                DGVDetainedLicenses.Columns[0].HeaderText = "D.ID";
                DGVDetainedLicenses.Columns[0].Width = 90;

                DGVDetainedLicenses.Columns[1].HeaderText = "L.ID";
                DGVDetainedLicenses.Columns[1].Width = 90;

                DGVDetainedLicenses.Columns[2].HeaderText = "D.Date";
                DGVDetainedLicenses.Columns[2].Width = 160;

                DGVDetainedLicenses.Columns[3].HeaderText = "Is Released";
                DGVDetainedLicenses.Columns[3].Width = 110;

                DGVDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
                DGVDetainedLicenses.Columns[4].Width = 110;

                DGVDetainedLicenses.Columns[5].HeaderText = "Release Date";
                DGVDetainedLicenses.Columns[5].Width = 160;

                DGVDetainedLicenses.Columns[6].HeaderText = "N.No.";
                DGVDetainedLicenses.Columns[6].Width = 90;

                DGVDetainedLicenses.Columns[7].HeaderText = "Full Name";
                DGVDetainedLicenses.Columns[7].Width = 330;

                DGVDetainedLicenses.Columns[8].HeaderText = "Rlease App.ID";
                DGVDetainedLicenses.Columns[8].Width = 150;

            }

        }

        private void ShowPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)DGVDetainedLicenses.CurrentRow.Cells[1].Value;
            int PersonID = clsLicenses.Find(LicenseID).DriverInfo.PersonID;
            Person_Details frm = new Person_Details(PersonID);
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseInfo frm = new frmLicenseInfo(((int)DGVDetainedLicenses.CurrentRow.Cells[1].Value));
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)DGVDetainedLicenses.CurrentRow.Cells[1].Value;
            int PersonID = clsLicenses.Find(LicenseID).DriverInfo.PersonID;
            frmLicenseHistory frm = new frmLicenseHistory(PersonID);
           frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense(((int)DGVDetainedLicenses.CurrentRow.Cells[1].Value));
            frm.ShowDialog();
            frmListDetainedLicenses_Load(null, null);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (DGVDetainedLicenses.Rows.Count < 1)
                return;
            releaseDetainedLicenseToolStripMenuItem.Enabled = !(bool)DGVDetainedLicenses.CurrentRow.Cells[3].Value;
        }
    }
}
