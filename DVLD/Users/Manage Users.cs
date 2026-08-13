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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using DVLD.Global_Classes;


namespace DVLD
{
    public partial class Manage_Users : Form
    {
        private static DataTable _dtAllUsers;

        public Manage_Users()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Manage_Users_Load(object sender, EventArgs e)
        {
            _dtAllUsers = clsUsers.GetAllUsers();
            DGVManageUsers.DataSource = _dtAllUsers;
            cBFilterBy.SelectedIndex = 0;
            cBIsActive.SelectedIndex = 0;
            lblResultRecords.Text = DGVManageUsers.Rows.Count.ToString();

            DGVManageUsers.Columns[0].HeaderText = "User ID";
            DGVManageUsers.Columns[0].Width = 110;

            DGVManageUsers.Columns[1].HeaderText = "Person ID";
            DGVManageUsers.Columns[1].Width = 120;

            DGVManageUsers.Columns[2].HeaderText = "Full Name";
            DGVManageUsers.Columns[2].Width = 350;

            DGVManageUsers.Columns[3].HeaderText = "UserName";
            DGVManageUsers.Columns[3].Width = 120;

            DGVManageUsers.Columns[4].HeaderText = "Is Active";
            DGVManageUsers.Columns[4].Width = 120;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.Permissions == 0)
            {
                Add_New_User frm = new Add_New_User();
                frm.ShowDialog();
                Manage_Users_Load(null, null);
            }
            else
            {
                MessageBox.Show("You Don't Have Permission To Enter!, Contact Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
                UserInfo frm = new UserInfo((int)DGVManageUsers.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
            Manage_Users_Load(null, null);
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.Permissions == 0)
            {
                Add_New_User frm = new Add_New_User();
                frm.ShowDialog();
                Manage_Users_Load(null, null);
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
                Add_New_User frm = new Add_New_User((int)DGVManageUsers.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
                Manage_Users_Load(null, null);
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
                    if (clsUsers.DeleteUser((int)DGVManageUsers.CurrentRow.Cells[0].Value))
                    {
                       MessageBox.Show("User has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       Manage_Users_Load(null, null);
                    }
                    else
                       MessageBox.Show("User is not deleted to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               else
               {
                MessageBox.Show("You Don't Have Permission To Enter!, Contact Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.Permissions == 0)
            {
                Change_Password frm = new Change_Password((int)DGVManageUsers.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
                Manage_Users_Load(null, null);
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

        private void cBFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBFilterValue.Visible = !(cBFilterBy.SelectedIndex == 0 || cBFilterBy.SelectedIndex == 5);
            cBIsActive.Visible = (cBFilterBy.SelectedIndex == 5);
            tBFilterValue.Focus();
            tBFilterValue.Clear();
        }

        private void DGVManageUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                UserInfo frm = new UserInfo((int)DGVManageUsers.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
        }

        private void tBFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cBFilterBy.SelectedIndex)
            {
                case 1:
                    FilterColumn = "UserID";
                    break;
                case 2:
                    FilterColumn = "UserName";
                    break;

                case 3:
                    FilterColumn = "PersonID";
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
                _dtAllUsers.DefaultView.RowFilter = "";
                lblResultRecords.Text = DGVManageUsers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FullName" && FilterColumn != "UserName")
                //in this case we deal with numbers not string.
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tBFilterValue.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tBFilterValue.Text.Trim());

            lblResultRecords.Text = _dtAllUsers.Rows.Count.ToString();

        }

        private void cBIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {

            string FilterColumn = "All";

            switch (cBIsActive.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    FilterColumn = "1";
                    break;
                case 2:
                    FilterColumn = "0";
                    break;
            }

            if (FilterColumn == "All")
                _dtAllUsers.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", "IsActive", FilterColumn);

            lblResultRecords.Text = _dtAllUsers.Rows.Count.ToString();

        }

        private void tBFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cBFilterBy.SelectedIndex == 1 || cBFilterBy.SelectedIndex == 3)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}