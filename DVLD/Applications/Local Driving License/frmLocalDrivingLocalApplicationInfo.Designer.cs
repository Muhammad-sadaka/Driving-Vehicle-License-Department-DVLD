namespace DVLD
{
    partial class frmLocalDrivingLocalApplicationInfo
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
            this.ctrlLocalDrivingLocalApplicationInfo1 = new DVLD.ctrlLocalDrivingLocalApplicationInfo();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(961, 469);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 42);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlLocalDrivingLocalApplicationInfo1
            // 
            this.ctrlLocalDrivingLocalApplicationInfo1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ctrlLocalDrivingLocalApplicationInfo1.Location = new System.Drawing.Point(-4, -11);
            this.ctrlLocalDrivingLocalApplicationInfo1.Name = "ctrlLocalDrivingLocalApplicationInfo1";
            this.ctrlLocalDrivingLocalApplicationInfo1.Size = new System.Drawing.Size(1121, 488);
            this.ctrlLocalDrivingLocalApplicationInfo1.TabIndex = 34;
            // 
            // frmLocalDrivingLocalApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1111, 509);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlLocalDrivingLocalApplicationInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLocalDrivingLocalApplicationInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Local Driving Local Application Info";
            this.Load += new System.EventHandler(this.frmLocalDrivingLocalApplicationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private ctrlLocalDrivingLocalApplicationInfo ctrlLocalDrivingLocalApplicationInfo1;
    }
}