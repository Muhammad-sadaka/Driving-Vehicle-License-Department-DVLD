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
    public partial class frmUpdateApplicationType : Form
    {
        int _ApplicationTypeID = -1;
        clsApplicationTypes ApplicationType = new clsApplicationTypes();

        public frmUpdateApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID = ApplicationTypeID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            ApplicationType.Title = tBTitle.Text;
            ApplicationType.Fees = Convert.ToSingle(tBFees.Text.Trim());
            if (ApplicationType.Save())
                MessageBox.Show("Data Saved Successfully.");
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");
        }

        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            lbl_ID.Text = _ApplicationTypeID.ToString();
            ApplicationType = clsApplicationTypes.FindByID(_ApplicationTypeID);
            if (ApplicationType != null)
            {
                tBTitle.Text = ApplicationType.Title;
                tBFees.Text = ApplicationType.Fees.ToString();
            }
        }

        private void tBTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tBTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tBTitle, "Title cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(tBTitle, null);

            };
        }

        private void tBFees_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(tBFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tBFees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(tBFees, null);

            };
        }
    }
}
