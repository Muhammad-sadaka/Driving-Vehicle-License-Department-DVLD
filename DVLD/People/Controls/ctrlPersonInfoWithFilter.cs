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
using DVLD.People;

namespace DVLD
{
    public partial class ctrlPersonInfoWithFilter : UserControl
    {
        // Define a custom event handler delegate with parameter
        public event Action<int> OnSearchSelected; // When the UserControl Completed
        // Create a protected method to raise the event with a parameter
        protected virtual void SearchSelected(int PersonID)
        {
            Action<int> handler = OnSearchSelected;

            if (handler != null)
            {
                handler(PersonID);  // Raise the event with the parameter
            }
        }

        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }
            set
            {
                _ShowAddPerson = value;
                btnAdd.Visible = _ShowAddPerson;
            }
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
                gBFilter.Enabled = _FilterEnabled;
            }
        }

        public ctrlPersonInfoWithFilter()
        {
            InitializeComponent();
        }

        public int PersonID
        {
            get { return ctrlPersonInformation1.PersonID; }
        }

        public clsPeople SelectedPersonInfo
        {
            get { return ctrlPersonInformation1.SelectedPersonInfo; }
        }

   
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.PersonIDDataBack += SetPersonIDFromDataBack;// Subscribe to the event
            frm.ShowDialog();
        }

        private void SetPersonIDFromDataBack(object sender, int PersonID)
        {
            cBFindBy.SelectedIndex = 1;
            tBSearchValue.Text = PersonID.ToString();
            ctrlPersonInformation1._LoadPersonInfoData(PersonID);

        }

        private void FindNow()
        {
            switch (cBFindBy.SelectedIndex)
            {
                case 1:
                    ctrlPersonInformation1._LoadPersonInfoData(int.Parse(tBSearchValue.Text));

                    break;

                case 0:
                    ctrlPersonInformation1._LoadPersonInfoData(tBSearchValue.Text);
                    break;

                default:
                    break;
            }

            if (OnSearchSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnSearchSelected(ctrlPersonInformation1.PersonID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            FindNow();
        }

        public void LoadPersonInfo(int PersonID)
        {
            cBFindBy.SelectedIndex = 1;
            tBSearchValue.Text = PersonID.ToString();
            FindNow();
        }

        public void FilterFocus()
        {
            tBSearchValue.Focus();
        }

        private void tBSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnSearch.PerformClick();
            }

            //this will allow only digits if person id is selected
            if (cBFindBy.SelectedIndex == 1)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


        }

        private void tBSearchValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tBSearchValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tBSearchValue, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(tBSearchValue, null);
            }
        }

        private void ctrlPersonInfoWithFilter_Load(object sender, EventArgs e)
        {
            cBFindBy.SelectedIndex = 1;
            tBSearchValue.Focus();
        }

        private void cBFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBSearchValue.Clear();
            FilterFocus();
        }
    }
}
