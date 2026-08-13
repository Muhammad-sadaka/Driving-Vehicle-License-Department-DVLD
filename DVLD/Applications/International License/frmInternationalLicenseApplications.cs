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
    public partial class frmInternationalLicenseApplications : Form
    {
        private DataTable _dtInternationalLicenseApplications;

        public frmInternationalLicenseApplications()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInternationalLicenseApplications_Load(object sender, EventArgs e)
        {

            _dtInternationalLicenseApplications =  clsInternationalLicenseApplications.GetAllInternationalLicenses();
            cBFilterBy.SelectedIndex = 0;

            DGVManageInternationalApplications.DataSource = _dtInternationalLicenseApplications;
            lblResultRecords.Text = DGVManageInternationalApplications.Rows.Count.ToString();

            if (DGVManageInternationalApplications.Rows.Count > 0)
            {
                DGVManageInternationalApplications.Columns[0].HeaderText = "Int.License ID";
                DGVManageInternationalApplications.Columns[0].Width = 160;

                DGVManageInternationalApplications.Columns[1].HeaderText = "Application ID";
                DGVManageInternationalApplications.Columns[1].Width = 150;

                DGVManageInternationalApplications.Columns[2].HeaderText = "Driver ID";
                DGVManageInternationalApplications.Columns[2].Width = 130;

                DGVManageInternationalApplications.Columns[3].HeaderText = "L.License ID";
                DGVManageInternationalApplications.Columns[3].Width = 130;

                DGVManageInternationalApplications.Columns[4].HeaderText = "Issue Date";
                DGVManageInternationalApplications.Columns[4].Width = 180;

                DGVManageInternationalApplications.Columns[5].HeaderText = "Expiration Date";
                DGVManageInternationalApplications.Columns[5].Width = 180;

                DGVManageInternationalApplications.Columns[6].HeaderText = "Is Active";
                DGVManageInternationalApplications.Columns[6].Width = 120;

            }
        }

        private void btnNewApplication_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplications frm = new frmNewInternationalLicenseApplications();
            frm.ShowDialog();
            frmInternationalLicenseApplications_Load(null,null);
        }

        private void ShowPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)DGVManageInternationalApplications.CurrentRow.Cells[2].Value;
            int PersonID = clsDrivers.FindByDriverID(DriverID).PersonID;

            Person_Details frm = new Person_Details(PersonID);
            frm.ShowDialog();
        }

        private void ShowLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalDriverInfo frm = new frmInternationalDriverInfo((int)DGVManageInternationalApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void ShowPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)DGVManageInternationalApplications.CurrentRow.Cells[2].Value;
            int PersonID = clsDrivers.FindByDriverID(DriverID).PersonID;
            frmLicenseHistory frm = new frmLicenseHistory(PersonID);
            frm.ShowDialog();
        }

        private void cBFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBFilterValue.Visible = !(cBFilterBy.SelectedIndex == 0 || cBFilterBy.SelectedIndex == 5);
            cBIsActive.Visible = (cBFilterBy.SelectedIndex == 5);
            tBFilterValue.Focus();
            tBFilterValue.Clear();
        }

        private void cBIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {

            string FilterColumn = "IsActive";
            string FilterValue = cBIsActive.Text;

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
                _dtInternationalLicenseApplications.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblResultRecords.Text = _dtInternationalLicenseApplications.Rows.Count.ToString();

        }

        private void tBFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
              if (!char.IsDigit(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
              {
                  e.Handled = true;
              }
        }

        private void tBFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cBFilterBy.Text)
            {
                case "International License ID":
                    FilterColumn = "InternationalLicenseID";
                    break;
                case "Application ID":
                    {
                        FilterColumn = "ApplicationID";
                        break;
                    };

                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;

                case "Local License ID":
                    FilterColumn = "IssuedUsingLocalLicenseID";
                    break;

                case "Is Active":
                    FilterColumn = "IsActive";
                    break;


                default:
                    FilterColumn = "None";
                    break;
            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tBFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtInternationalLicenseApplications.DefaultView.RowFilter = "";
                lblResultRecords.Text = DGVManageInternationalApplications.Rows.Count.ToString();
                return;
            }



            _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tBFilterValue.Text.Trim());

            lblResultRecords.Text = _dtInternationalLicenseApplications.Rows.Count.ToString();

        }
    }
}
