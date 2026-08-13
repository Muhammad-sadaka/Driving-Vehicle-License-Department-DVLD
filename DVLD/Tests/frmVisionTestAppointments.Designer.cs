namespace DVLD
{
    partial class frmTestAppointments
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblResultRecords = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVAppointments = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.pBTestType = new System.Windows.Forms.PictureBox();
            this.ctrlLocalDrivingLocalApplicationInfo1 = new DVLD.ctrlLocalDrivingLocalApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAppointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBTestType)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(365, 111);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(398, 36);
            this.lblTitle.TabIndex = 43;
            this.lblTitle.Text = "Vision Test Appointments";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(962, 897);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 34);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblResultRecords
            // 
            this.lblResultRecords.AutoSize = true;
            this.lblResultRecords.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultRecords.Location = new System.Drawing.Point(128, 902);
            this.lblResultRecords.Name = "lblResultRecords";
            this.lblResultRecords.Size = new System.Drawing.Size(23, 24);
            this.lblResultRecords.TabIndex = 49;
            this.lblResultRecords.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(12, 902);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(121, 24);
            this.lblRecords.TabIndex = 48;
            this.lblRecords.Text = "# Records:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 674);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Appointments:";
            // 
            // DGVAppointments
            // 
            this.DGVAppointments.AllowUserToAddRows = false;
            this.DGVAppointments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVAppointments.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAppointments.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVAppointments.Location = new System.Drawing.Point(3, 701);
            this.DGVAppointments.Name = "DGVAppointments";
            this.DGVAppointments.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVAppointments.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DGVAppointments.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVAppointments.RowTemplate.Height = 26;
            this.DGVAppointments.Size = new System.Drawing.Size(1100, 190);
            this.DGVAppointments.TabIndex = 52;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.TakeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 80);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.EditToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.EditToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(176, 38);
            this.EditToolStripMenuItem.Text = "Edit";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // TakeTestToolStripMenuItem
            // 
            this.TakeTestToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TakeTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Test_32;
            this.TakeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TakeTestToolStripMenuItem.Name = "TakeTestToolStripMenuItem";
            this.TakeTestToolStripMenuItem.Size = new System.Drawing.Size(176, 38);
            this.TakeTestToolStripMenuItem.Text = "Take Test";
            this.TakeTestToolStripMenuItem.Click += new System.EventHandler(this.TakeTestToolStripMenuItem_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackgroundImage = global::DVLD.Properties.Resources.Schedule_Test_32;
            this.btnAddAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Location = new System.Drawing.Point(1054, 653);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(49, 45);
            this.btnAddAppointment.TabIndex = 50;
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // pBTestType
            // 
            this.pBTestType.Image = global::DVLD.Properties.Resources.Vision_512;
            this.pBTestType.Location = new System.Drawing.Point(480, 12);
            this.pBTestType.Name = "pBTestType";
            this.pBTestType.Size = new System.Drawing.Size(163, 96);
            this.pBTestType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBTestType.TabIndex = 44;
            this.pBTestType.TabStop = false;
            // 
            // ctrlLocalDrivingLocalApplicationInfo1
            // 
            this.ctrlLocalDrivingLocalApplicationInfo1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ctrlLocalDrivingLocalApplicationInfo1.Location = new System.Drawing.Point(-8, 165);
            this.ctrlLocalDrivingLocalApplicationInfo1.Name = "ctrlLocalDrivingLocalApplicationInfo1";
            this.ctrlLocalDrivingLocalApplicationInfo1.Size = new System.Drawing.Size(1121, 488);
            this.ctrlLocalDrivingLocalApplicationInfo1.TabIndex = 53;
            // 
            // frmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1108, 933);
            this.Controls.Add(this.ctrlLocalDrivingLocalApplicationInfo1);
            this.Controls.Add(this.DGVAppointments);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultRecords);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pBTestType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTestAppointments";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vision Test Appointments";
            this.Load += new System.EventHandler(this.frmVisionTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAppointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBTestType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pBTestType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblResultRecords;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVAppointments;
        private ctrlLocalDrivingLocalApplicationInfo ctrlLocalDrivingLocalApplicationInfo1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TakeTestToolStripMenuItem;
    }
}