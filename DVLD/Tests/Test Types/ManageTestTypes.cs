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
    public partial class ManageTestTypes : Form
    {
        private DataTable _dtAllTestTypes;

        public ManageTestTypes()
        {
            InitializeComponent();
        }

        private void ManageTestTypes_Load(object sender, EventArgs e)
        {
            _dtAllTestTypes = clsTestTypes.GetAllTestTypes();
            DGVTestTypes.DataSource = _dtAllTestTypes;
            lblResultRecords.Text = DGVTestTypes.Rows.Count.ToString();

            DGVTestTypes.Columns[0].HeaderText = "ID";
            DGVTestTypes.Columns[0].Width = 120;

            DGVTestTypes.Columns[1].HeaderText = "Title";
            DGVTestTypes.Columns[1].Width = 200;

            DGVTestTypes.Columns[2].HeaderText = "Description";
            DGVTestTypes.Columns[2].Width = 400;

            DGVTestTypes.Columns[3].HeaderText = "Fees";
            DGVTestTypes.Columns[3].Width = 100;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
                frmUpdateTestType frm = new frmUpdateTestType((clsTestTypes.enTestType)DGVTestTypes.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
            ManageTestTypes_Load(null,null);
        }

        private void DGVTestTypes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                frmUpdateTestType frm = new frmUpdateTestType((clsTestTypes.enTestType)DGVTestTypes.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
            ManageTestTypes_Load(null,null);
        }
    }
}
