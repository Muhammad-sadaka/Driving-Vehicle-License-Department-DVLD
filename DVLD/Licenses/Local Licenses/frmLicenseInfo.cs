using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLicenseInfo : Form
    {
        public frmLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            ctrlDriverLicenseInfo1.LoadInfo(LicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
