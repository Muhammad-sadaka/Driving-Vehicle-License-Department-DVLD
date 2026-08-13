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
    public partial class ctrlDriverLicenseInfoWithFilter : UserControl
    {
        public event Action<int> OnSearchSelected; // When the UserControl Completed

        // Create a protected method to raise the event with a parameter
        protected virtual void SearchSelected(int LicenseID)
        {
            Action<int> handler = OnSearchSelected;

            if (handler != null)
            {
                handler(LicenseID);  // Raise the event with the parameter
            }
        }

        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }


        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }

        private int _LicenseID = -1;

        public int LicenseID
        {
            get { return ctrlDriverLicenseInfo1.LicenseID; }
        }

        public clsLicenses SelectedLicenseInfo
        { get { return ctrlDriverLicenseInfo1.SelectedLicenseInfo; } }

        public void LoadLicenseInfo(int LicenseID)
        {
            tBSearchLicense.Text = LicenseID.ToString();
            ctrlDriverLicenseInfo1.LoadInfo(LicenseID);
            _LicenseID = ctrlDriverLicenseInfo1.LicenseID;
            if (OnSearchSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnSearchSelected(_LicenseID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBSearchLicense.Focus();
                return;

            }
            _LicenseID = int.Parse(tBSearchLicense.Text);
            LoadLicenseInfo(_LicenseID);
        }
        public void txtLicenseIDFocus()
        {
            tBSearchLicense.Focus();
        }

        private void tBSearchLicense_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnSearch.PerformClick();
            }
        }

        private void tBSearchLicense_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tBSearchLicense.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tBSearchLicense, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(tBSearchLicense, null);
            }
        }
    }
}
