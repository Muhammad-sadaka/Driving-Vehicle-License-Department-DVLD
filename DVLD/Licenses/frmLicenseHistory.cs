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
    public partial class frmLicenseHistory : Form
    {
        private int _PersonID = -1;

        public frmLicenseHistory()
        {
            InitializeComponent();
        }

        public frmLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            if (_PersonID > 0)
            {
                ctrlPersonInfoWithFilter1.LoadPersonInfo(_PersonID);
                ctrlPersonInfoWithFilter1.FilterEnabled = false;
                ctrlDriverLicenses1.LoadInfoByPersonID(_PersonID);
            }
            else
            {
                ctrlPersonInfoWithFilter1.Enabled = true;
                ctrlPersonInfoWithFilter1.FilterFocus();
            }
        }

        private void ctrlPersonInfoWithFilter1_OnSearchSelected(int obj)
        {
            _PersonID = obj;
            if (_PersonID == -1)
            {
                ctrlDriverLicenses1.Clear();
            }
            else
                ctrlDriverLicenses1.LoadInfoByPersonID(_PersonID);
        }
    }
}
