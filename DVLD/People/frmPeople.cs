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
using DVLD.Global_Classes;

namespace DVLD.People
{
    public partial class frmPeople : Form
    {
        private static DataTable _dtAllPeople = clsPeople.GetAllPeople();
        //only select the columns that you want to show in the grid
        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                         "FirstName", "SecondName", "ThirdName", "LastName",
                                                         "Gender", "DateOfBirth", "Nationality",
                                                         "Phone", "Email");

        public frmPeople()
        {
            InitializeComponent();
        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            DGVManagePeople.DataSource = _dtPeople;
            cBFilterBy.SelectedIndex = 0;
            lblResultRecords.Text = DGVManagePeople.Rows.Count.ToString();
            if (DGVManagePeople.Rows.Count > 0)
            {

                DGVManagePeople.Columns[0].HeaderText = "Person ID";
                DGVManagePeople.Columns[0].Width = 110;

                DGVManagePeople.Columns[1].HeaderText = "National No.";
                DGVManagePeople.Columns[1].Width = 120;


                DGVManagePeople.Columns[2].HeaderText = "First Name";
                DGVManagePeople.Columns[2].Width = 120;

                DGVManagePeople.Columns[3].HeaderText = "Second Name";
                DGVManagePeople.Columns[3].Width = 140;


                DGVManagePeople.Columns[4].HeaderText = "Third Name";
                DGVManagePeople.Columns[4].Width = 120;

                DGVManagePeople.Columns[5].HeaderText = "Last Name";
                DGVManagePeople.Columns[5].Width = 120;

                DGVManagePeople.Columns[6].HeaderText = "Gender";
                DGVManagePeople.Columns[6].Width = 120;

                DGVManagePeople.Columns[7].HeaderText = "Date Of Birth";
                DGVManagePeople.Columns[7].Width = 140;

                DGVManagePeople.Columns[8].HeaderText = "Nationality";
                DGVManagePeople.Columns[8].Width = 120;


                DGVManagePeople.Columns[9].HeaderText = "Phone";
                DGVManagePeople.Columns[9].Width = 120;


                DGVManagePeople.Columns[10].HeaderText = "Email";
                DGVManagePeople.Columns[10].Width = 170;
            }
        }

        private void _RefreshPeopleList()
        {
            _dtAllPeople = clsPeople.GetAllPeople();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "Gender", "DateOfBirth", "Nationality",
                                                       "Phone", "Email");

            DGVManagePeople.DataSource = _dtPeople;
            lblResultRecords.Text = DGVManagePeople.RowCount.ToString();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                Person_Details frm = new Person_Details((int)DGVManagePeople.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
                _RefreshPeopleList();
           
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.Permissions == 0 || clsGlobal.CurrentUser.Permissions == 1)
            {
                frmAddUpdatePerson frm = new frmAddUpdatePerson();
                frm.ShowDialog();
                _RefreshPeopleList();
            }
            else
            {
                MessageBox.Show("You Don't Have Permission To Enter!, Contact Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (clsGlobal.CurrentUser.Permissions == 0)
            {
                frmAddUpdatePerson frm = new frmAddUpdatePerson((int)DGVManagePeople.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
                _RefreshPeopleList();
            }
            else
            {
                MessageBox.Show("You Don't Have Permission To Enter!, Contact Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.Permissions == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete Person [" + DGVManagePeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

                {
                    if (clsPeople.DeletePerson((int)DGVManagePeople.CurrentRow.Cells[0].Value))
                    {
                        MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshPeopleList();
                    }
                    else
                        MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Don't Have Permission To Enter!, Contact Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Sorry This Feuture is not implemented yet!", "Not ready!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry This Feuture is not implemented yet!", "Not ready!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.Permissions == 0 || clsGlobal.CurrentUser.Permissions == 1)
            {
                frmAddUpdatePerson frm = new frmAddUpdatePerson();
                frm.ShowDialog();
                _RefreshPeopleList();
            }
            else
            {
                MessageBox.Show("You Don't Have Permission To Enter!, Contact Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cBFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBFilterValue.Visible =! (cBFilterBy.SelectedIndex == 0);
            tBFilterValue.Focus();
            tBFilterValue.Clear();
        }

        private void DGVManagePeople_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
               Person_Details frm = new Person_Details((int)DGVManagePeople.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
                _RefreshPeopleList();
        }

        private void tBFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cBFilterBy.SelectedIndex)
            {
                case 1:
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
                    {
                        e.Handled = true;
                    }
                    break;
                case 9:
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }

        private void tBFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = ""; 
            //Map Selected Filter to real Column name 
            switch (cBFilterBy.SelectedIndex)
            {
                case 1:
                    FilterColumn = "PersonID";
                    break;

                case 2:
                    FilterColumn = "NationalNo";
                    break;

                case 3:
                    FilterColumn = "FirstName";
                    break;

                case 4:
                    FilterColumn = "SecondName";
                    break;

                case 5:
                    FilterColumn = "ThirdName";
                    break;

                case 6:
                    FilterColumn = "LastName";
                    break;

                case 7:
                    FilterColumn = "Nationality";
                    break;

                case 8:
                    FilterColumn = "Gender";
                    break;

                case 9:
                    FilterColumn = "Phone";
                    break;

                case 10:
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tBFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblResultRecords.Text = DGVManagePeople.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "PersonID")
                //in this case we deal with integer not string.

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tBFilterValue.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tBFilterValue.Text.Trim());

            lblResultRecords.Text = DGVManagePeople.Rows.Count.ToString();

        }
    }
}
