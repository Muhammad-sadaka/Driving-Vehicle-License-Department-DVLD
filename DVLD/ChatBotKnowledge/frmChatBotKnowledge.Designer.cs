namespace DVLD
{
    partial class frmChatBotKnowledge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.tBQuestion = new System.Windows.Forms.TextBox();
            this.tBAnswer = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblManagePeople = new System.Windows.Forms.Label();
            this.btnAsk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(819, 592);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBQuestion
            // 
            this.tBQuestion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tBQuestion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBQuestion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tBQuestion.Location = new System.Drawing.Point(12, 216);
            this.tBQuestion.Multiline = true;
            this.tBQuestion.Name = "tBQuestion";
            this.tBQuestion.Size = new System.Drawing.Size(848, 33);
            this.tBQuestion.TabIndex = 1;
            this.tBQuestion.Text = "Type Your Message here";
            this.tBQuestion.Click += new System.EventHandler(this.tBQuestion_Click);
            this.tBQuestion.TextChanged += new System.EventHandler(this.tBQuestion_TextChanged);
            this.tBQuestion.Enter += new System.EventHandler(this.tBQuestion_Enter);
            // 
            // tBAnswer
            // 
            this.tBAnswer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tBAnswer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBAnswer.Location = new System.Drawing.Point(12, 258);
            this.tBAnswer.Multiline = true;
            this.tBAnswer.Name = "tBAnswer";
            this.tBAnswer.ReadOnly = true;
            this.tBAnswer.Size = new System.Drawing.Size(932, 328);
            this.tBAnswer.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources._1767711236952;
            this.pictureBox1.Location = new System.Drawing.Point(411, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblManagePeople
            // 
            this.lblManagePeople.AutoSize = true;
            this.lblManagePeople.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagePeople.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblManagePeople.Location = new System.Drawing.Point(427, 167);
            this.lblManagePeople.Name = "lblManagePeople";
            this.lblManagePeople.Size = new System.Drawing.Size(136, 36);
            this.lblManagePeople.TabIndex = 18;
            this.lblManagePeople.Text = "ChatBot";
            // 
            // btnAsk
            // 
            this.btnAsk.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsk.Location = new System.Drawing.Point(866, 216);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(78, 36);
            this.btnAsk.TabIndex = 1;
            this.btnAsk.Text = "Ask";
            this.btnAsk.UseVisualStyleBackColor = false;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click_1);
            // 
            // frmChatBotKnowledge
            // 
            this.AcceptButton = this.btnAsk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(956, 628);
            this.Controls.Add(this.btnAsk);
            this.Controls.Add(this.lblManagePeople);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tBAnswer);
            this.Controls.Add(this.tBQuestion);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmChatBotKnowledge";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChatBot";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tBQuestion;
        private System.Windows.Forms.TextBox tBAnswer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblManagePeople;
        private System.Windows.Forms.Button btnAsk;
    }
}