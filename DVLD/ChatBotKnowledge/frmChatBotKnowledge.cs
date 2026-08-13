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
    public partial class frmChatBotKnowledge : Form
    {

        public frmChatBotKnowledge()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsk_Click_1(object sender, EventArgs e)
        {
            tBAnswer.Text = clsChatBot.GetBotResponse(tBQuestion.Text);
        }

        private void tBQuestion_TextChanged(object sender, EventArgs e)
        {
            tBQuestion.ForeColor = Color.Black;
        }

        private void tBQuestion_Enter(object sender, EventArgs e)
        {
            if (tBQuestion.Text == "Type Your Message here")
                tBQuestion.Clear();
        }

        private void tBQuestion_Click(object sender, EventArgs e)
        {
            if (tBQuestion.Text == "Type Your Message here")
                tBQuestion.Clear();
        }
    }
}
