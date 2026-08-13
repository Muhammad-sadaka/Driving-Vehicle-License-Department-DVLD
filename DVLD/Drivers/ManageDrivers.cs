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
    public partial class ManageDrivers : Form
    {
        private DataTable _dtAllDrivers;

        public ManageDrivers()
        {
            InitializeComponent();
        }

        private void ManageDrivers_Load(object sender, EventArgs e)
        {
            cBFilterBy.SelectedIndex = 0;
            _dtAllDrivers = clsDrivers.GetAllDrivers();
            DGVManageDrivers.DataSource = _dtAllDrivers;
            lblResultRecords.Text = DGVManageDrivers.Rows.Count.ToString();
            if (DGVManageDrivers.Rows.Count > 0)
            {
                DGVManageDrivers.Columns[0].HeaderText = "Driver ID";
                DGVManageDrivers.Columns[0].Width = 120;

                DGVManageDrivers.Columns[1].HeaderText = "Person ID";
                DGVManageDrivers.Columns[1].Width = 120;

                DGVManageDrivers.Columns[2].HeaderText = "National No.";
                DGVManageDrivers.Columns[2].Width = 140;

                DGVManageDrivers.Columns[3].HeaderText = "Full Name";
                DGVManageDrivers.Columns[3].Width = 320;

                DGVManageDrivers.Columns[4].HeaderText = "Date";
                DGVManageDrivers.Columns[4].Width = 170;

                DGVManageDrivers.Columns[5].HeaderText = "Active Licenses";
                DGVManageDrivers.Columns[5].Width = 150;
            }

        }

        private void cBFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBFilterValue.Visible = !(cBFilterBy.SelectedIndex == 0);
            tBFilterValue.Focus();
            tBFilterValue.Clear();
        }

        private void ShowPersonInfo_Click(object sender, EventArgs e)
        {
            Person_Details frm = new Person_Details((int)DGVManageDrivers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            ManageDrivers_Load(null,null);
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGVManageDrivers.CurrentRow != null)
            {
                MessageBox.Show("Sorry This Feuture is not implemented yet!", "Not ready!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory((int)DGVManageDrivers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            ManageDrivers_Load(null,null);
        }

        private void DGVManageDrivers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Person_Details frm = new Person_Details((int)DGVManageDrivers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            ManageDrivers_Load(null,null);
        }

        private void tBFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cBFilterBy.SelectedIndex == 1 || cBFilterBy.SelectedIndex == 2)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tBFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cBFilterBy.SelectedIndex)
            {
                case 1:
                    FilterColumn = "DriverID";
                    break;

                case 2:
                    FilterColumn = "PersonID";
                    break;

                case 3:
                    FilterColumn = "NationalNo";
                    break;

                case 4:
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tBFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllDrivers.DefaultView.RowFilter = "";
                lblResultRecords.Text = DGVManageDrivers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FullName" && FilterColumn != "NationalNo")
                //in this case we deal with numbers not string.
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tBFilterValue.Text.Trim());
            else
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tBFilterValue.Text.Trim());

            lblResultRecords.Text = _dtAllDrivers.Rows.Count.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
