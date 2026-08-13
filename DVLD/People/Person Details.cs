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
    public partial class Person_Details : Form
    {
        public Person_Details(int PersonID)
        {
            InitializeComponent();
            ctrlPersonInformation1._LoadPersonInfoData(PersonID);
        }

        public Person_Details(string NationalNo)
        {
            InitializeComponent();
            ctrlPersonInformation1._LoadPersonInfoData(NationalNo);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
