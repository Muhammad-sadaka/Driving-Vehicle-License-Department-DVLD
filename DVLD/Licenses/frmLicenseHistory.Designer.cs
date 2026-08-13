namespace DVLD
{
    partial class frmLicenseHistory
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
            this.lblPersonDetails = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlDriverLicenses1 = new DVLD.ctrlDriverLicenses();
            this.ctrlPersonInfoWithFilter1 = new DVLD.ctrlPersonInfoWithFilter();
            this.SuspendLayout();
            // 
            // lblPersonDetails
            // 
            this.lblPersonDetails.AutoSize = true;
            this.lblPersonDetails.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonDetails.Location = new System.Drawing.Point(383, 9);
            this.lblPersonDetails.Name = "lblPersonDetails";
            this.lblPersonDetails.Size = new System.Drawing.Size(244, 36);
            this.lblPersonDetails.TabIndex = 5;
            this.lblPersonDetails.Text = "License History";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(899, 919);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 42);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlDriverLicenses1
            // 
            this.ctrlDriverLicenses1.Location = new System.Drawing.Point(3, 562);
            this.ctrlDriverLicenses1.Name = "ctrlDriverLicenses1";
            this.ctrlDriverLicenses1.Size = new System.Drawing.Size(1037, 335);
            this.ctrlDriverLicenses1.TabIndex = 8;
            // 
            // ctrlPersonInfoWithFilter1
            // 
            this.ctrlPersonInfoWithFilter1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ctrlPersonInfoWithFilter1.FilterEnabled = true;
            this.ctrlPersonInfoWithFilter1.Location = new System.Drawing.Point(3, 59);
            this.ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
            this.ctrlPersonInfoWithFilter1.ShowAddPerson = true;
            this.ctrlPersonInfoWithFilter1.Size = new System.Drawing.Size(1037, 497);
            this.ctrlPersonInfoWithFilter1.TabIndex = 7;
            this.ctrlPersonInfoWithFilter1.OnSearchSelected += new System.Action<int>(this.ctrlPersonInfoWithFilter1_OnSearchSelected);
            // 
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1044, 960);
            this.Controls.Add(this.ctrlDriverLicenses1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPersonDetails);
            this.Controls.Add(this.ctrlPersonInfoWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLicenseHistory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "License History";
            this.Load += new System.EventHandler(this.frmLicenseHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonDetails;
        private System.Windows.Forms.Button btnClose;
        private ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
        private ctrlDriverLicenses ctrlDriverLicenses1;
    }
}