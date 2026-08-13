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
    public partial class ManageApplicationTypes : Form
    {
        private DataTable _dtAllApplicationTypes;

        public ManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void ManageApplicationTypes_Load(object sender, EventArgs e)
        {

            _dtAllApplicationTypes = clsApplicationTypes.GetAllApplicationTypes();
            DGVManageApplicationTypes.DataSource = _dtAllApplicationTypes;
            lblResultRecords.Text = DGVManageApplicationTypes.Rows.Count.ToString();

            DGVManageApplicationTypes.Columns[0].HeaderText = "ID";
            DGVManageApplicationTypes.Columns[0].Width = 110;

            DGVManageApplicationTypes.Columns[1].HeaderText = "Title";
            DGVManageApplicationTypes.Columns[1].Width = 400;

            DGVManageApplicationTypes.Columns[2].HeaderText = "Fees";
            DGVManageApplicationTypes.Columns[2].Width = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationType frm = new frmUpdateApplicationType((int)DGVManageApplicationTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            ManageApplicationTypes_Load(null,null);
        }

        private void DGVManageApplicationTypes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUpdateApplicationType frm = new frmUpdateApplicationType((int)DGVManageApplicationTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog(); 
            ManageApplicationTypes_Load(null, null);
        }
    }
}