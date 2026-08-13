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
    public partial class ctrlDriverLicenses : UserControl
    {
        private int _DriverID;
        private clsDrivers _Driver;
        private DataTable _dtDriverLocalLicensesHistory;
        private DataTable _dtDriverInternationalLicensesHistory;


        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }


        private void _LoadLocalLicenseInfo()
        {

            _dtDriverLocalLicensesHistory = clsDrivers.GetLicenses(_DriverID);


            DGVLocalLicenseHistory.DataSource = _dtDriverLocalLicensesHistory;
            //lblLocalLicensesRecords.Text = DGVLocalLicenseHistory.Rows.Count.ToString();

            if (DGVLocalLicenseHistory.Rows.Count > 0)
            {
                DGVLocalLicenseHistory.Columns[0].HeaderText = "Lic.ID";
                DGVLocalLicenseHistory.Columns[0].Width = 110;

                DGVLocalLicenseHistory.Columns[1].HeaderText = "App.ID";
                DGVLocalLicenseHistory.Columns[1].Width = 110;

                DGVLocalLicenseHistory.Columns[2].HeaderText = "Class Name";
                DGVLocalLicenseHistory.Columns[2].Width = 270;

                DGVLocalLicenseHistory.Columns[3].HeaderText = "Issue Date";
                DGVLocalLicenseHistory.Columns[3].Width = 170;

                DGVLocalLicenseHistory.Columns[4].HeaderText = "Expiration Date";
                DGVLocalLicenseHistory.Columns[4].Width = 170;

                DGVLocalLicenseHistory.Columns[5].HeaderText = "Is Active";
                DGVLocalLicenseHistory.Columns[5].Width = 110;

            }
        }

        private void _LoadInternationalLicenseInfo()
        {

            _dtDriverInternationalLicensesHistory = clsDrivers.GetInternationalLicenses(_DriverID);


            DGVinternationalLicenseHistory.DataSource = _dtDriverInternationalLicensesHistory;
            //lblInternationalLicensesRecords.Text = DGVinternationalLicenseHistory.Rows.Count.ToString();

            if (DGVinternationalLicenseHistory.Rows.Count > 0)
            {
                DGVinternationalLicenseHistory.Columns[0].HeaderText = "Int.License ID";
                DGVinternationalLicenseHistory.Columns[0].Width = 160;

                DGVinternationalLicenseHistory.Columns[1].HeaderText = "Application ID";
                DGVinternationalLicenseHistory.Columns[1].Width = 130;

                DGVinternationalLicenseHistory.Columns[2].HeaderText = "L.License ID";
                DGVinternationalLicenseHistory.Columns[2].Width = 130;

                DGVinternationalLicenseHistory.Columns[3].HeaderText = "Issue Date";
                DGVinternationalLicenseHistory.Columns[3].Width = 180;

                DGVinternationalLicenseHistory.Columns[4].HeaderText = "Expiration Date";
                DGVinternationalLicenseHistory.Columns[4].Width = 180;

                DGVinternationalLicenseHistory.Columns[5].HeaderText = "Is Active";
                DGVinternationalLicenseHistory.Columns[5].Width = 120;

            }
        }

        public void LoadInfo(int DriverID)
        {
            _DriverID = DriverID;
            _Driver = clsDrivers.FindByDriverID(_DriverID);
             
            if(_Driver == null)
            {
                MessageBox.Show("There is no driver with id = " + _DriverID,"Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
                return;
            }

            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();

        }

        public void LoadInfoByPersonID(int PersonID)
        {

            _Driver = clsDrivers.FindByPersonID(PersonID);
            if (_Driver == null)
            {
                return;
            }

            _DriverID = _Driver.DriverID;

            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();
        }

        public void Clear()
        {
            _dtDriverLocalLicensesHistory.Clear();
            _dtDriverInternationalLicensesHistory.Clear();
        }

        private void ShowLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)DGVLocalLicenseHistory.CurrentRow.Cells[0].Value;
            frmLicenseInfo frm = new frmLicenseInfo(LicenseID);
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            int InternationalLicenseID = (int)DGVinternationalLicenseHistory.CurrentRow.Cells[0].Value;
            frmInternationalDriverInfo frm = new frmInternationalDriverInfo(InternationalLicenseID);
            frm.ShowDialog();
        }
    }
}
