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
    public partial class frmUpdateTestType : Form
    {
        private clsTestTypes.enTestType _TestTypeID = clsTestTypes.enTestType.VisionTest;
        private clsTestTypes _TestType;

        public frmUpdateTestType(clsTestTypes.enTestType TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
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

            _TestType.Title = tBTitle.Text.Trim();
            _TestType.Description = tBDescription.Text.Trim();
            _TestType.Fees = Convert.ToSingle(tBFees.Text.Trim());


            if (_TestType.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            _TestType = clsTestTypes.FindByID(_TestTypeID);

            if (_TestType != null)
            {


                lbl_ID.Text = ((int)_TestTypeID).ToString();
                tBTitle.Text = _TestType.Title;
                tBDescription.Text = _TestType.Description;
                tBFees.Text = _TestType.Fees.ToString();
            }

            else

            {
                MessageBox.Show("Could not find Test Type with id = " + _TestTypeID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }
        }

        private void tBTitle_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(tBTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tBTitle, "Title cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(tBTitle, null);
            };
        }

        private void tBDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tBDescription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tBDescription, "Description cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(tBDescription, null);
            };
        }

        private void tBFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tBFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tBFees, "Description cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(tBFees, null);
            };
        }
    }
}
