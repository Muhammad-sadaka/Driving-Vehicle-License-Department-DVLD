namespace DVLD
{
    partial class ManageDrivers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVManageDrivers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.lblManagePeople = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.lblResultRecords = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tBFilterValue = new System.Windows.Forms.TextBox();
            this.cBFilterBy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVManageDrivers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVManageDrivers
            // 
            this.DGVManageDrivers.AllowUserToAddRows = false;
            this.DGVManageDrivers.AllowUserToDeleteRows = false;
            this.DGVManageDrivers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVManageDrivers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVManageDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVManageDrivers.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVManageDrivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVManageDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVManageDrivers.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVManageDrivers.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVManageDrivers.Location = new System.Drawing.Point(2, 282);
            this.DGVManageDrivers.Name = "DGVManageDrivers";
            this.DGVManageDrivers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVManageDrivers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVManageDrivers.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DGVManageDrivers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVManageDrivers.RowTemplate.Height = 26;
            this.DGVManageDrivers.Size = new System.Drawing.Size(1161, 371);
            this.DGVManageDrivers.TabIndex = 0;
            this.DGVManageDrivers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVManageDrivers_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPersonInfo,
            this.ShowPersonLicenseHistory});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(347, 108);
            // 
            // ShowPersonInfo
            // 
            this.ShowPersonInfo.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.ShowPersonInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowPersonInfo.Name = "ShowPersonInfo";
            this.ShowPersonInfo.Size = new System.Drawing.Size(346, 38);
            this.ShowPersonInfo.Text = "Show Person Info";
            this.ShowPersonInfo.Click += new System.EventHandler(this.ShowPersonInfo_Click);
            // 
            // ShowPersonLicenseHistory
            // 
            this.ShowPersonLicenseHistory.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_32;
            this.ShowPersonLicenseHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowPersonLicenseHistory.Name = "ShowPersonLicenseHistory";
            this.ShowPersonLicenseHistory.Size = new System.Drawing.Size(346, 38);
            this.ShowPersonLicenseHistory.Text = "Show Person License History";
            this.ShowPersonLicenseHistory.Click += new System.EventHandler(this.ShowPersonLicenseHistory_Click);
            // 
            // lblManagePeople
            // 
            this.lblManagePeople.AutoSize = true;
            this.lblManagePeople.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagePeople.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblManagePeople.Location = new System.Drawing.Point(467, 194);
            this.lblManagePeople.Name = "lblManagePeople";
            this.lblManagePeople.Size = new System.Drawing.Size(251, 36);
            this.lblManagePeople.TabIndex = 7;
            this.lblManagePeople.Text = "Manage Drivers";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1010, 659);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 44);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(12, 242);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(102, 24);
            this.lblFilterBy.TabIndex = 10;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // lblResultRecords
            // 
            this.lblResultRecords.AutoSize = true;
            this.lblResultRecords.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultRecords.Location = new System.Drawing.Point(128, 669);
            this.lblResultRecords.Name = "lblResultRecords";
            this.lblResultRecords.Size = new System.Drawing.Size(23, 24);
            this.lblResultRecords.TabIndex = 14;
            this.lblResultRecords.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(12, 669);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(121, 24);
            this.lblRecords.TabIndex = 13;
            this.lblRecords.Text = "# Records:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Driver_Main;
            this.pictureBox1.Location = new System.Drawing.Point(508, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // tBFilterValue
            // 
            this.tBFilterValue.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tBFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBFilterValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBFilterValue.Location = new System.Drawing.Point(313, 240);
            this.tBFilterValue.Name = "tBFilterValue";
            this.tBFilterValue.Size = new System.Drawing.Size(188, 32);
            this.tBFilterValue.TabIndex = 22;
            this.tBFilterValue.Visible = false;
            this.tBFilterValue.TextChanged += new System.EventHandler(this.tBFilterValue_TextChanged);
            this.tBFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBFilterValue_KeyPress);
            // 
            // cBFilterBy
            // 
            this.cBFilterBy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cBFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBFilterBy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBFilterBy.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cBFilterBy.FormattingEnabled = true;
            this.cBFilterBy.Items.AddRange(new object[] {
            "None",
            "Driver ID",
            "_Person ID",
            "National No",
            "FullName"});
            this.cBFilterBy.Location = new System.Drawing.Point(116, 240);
            this.cBFilterBy.Name = "cBFilterBy";
            this.cBFilterBy.Size = new System.Drawing.Size(191, 32);
            this.cBFilterBy.TabIndex = 21;
            this.cBFilterBy.SelectedIndexChanged += new System.EventHandler(this.cBFilterBy_SelectedIndexChanged);
            // 
            // ManageDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1169, 706);
            this.Controls.Add(this.tBFilterValue);
            this.Controls.Add(this.cBFilterBy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResultRecords);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblManagePeople);
            this.Controls.Add(this.DGVManageDrivers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageDrivers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageDrivers";
            this.Load += new System.EventHandler(this.ManageDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVManageDrivers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVManageDrivers;
        private System.Windows.Forms.Label lblManagePeople;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.Label lblResultRecords;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tBFilterValue;
        private System.Windows.Forms.ComboBox cBFilterBy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonInfo;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonLicenseHistory;
    }
}