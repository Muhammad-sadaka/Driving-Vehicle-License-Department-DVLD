namespace DVLD
{
    partial class ctrlPersonInfoWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tBSearchValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cBFindBy = new System.Windows.Forms.ComboBox();
            this.gBFilter = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonInformation1 = new DVLD.ctrlPersonInformation();
            this.gBFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tBSearchValue
            // 
            this.tBSearchValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearchValue.Location = new System.Drawing.Point(436, 28);
            this.tBSearchValue.Name = "tBSearchValue";
            this.tBSearchValue.Size = new System.Drawing.Size(222, 32);
            this.tBSearchValue.TabIndex = 160;
            this.tBSearchValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBSearchValue_KeyPress);
            this.tBSearchValue.Validating += new System.ComponentModel.CancelEventHandler(this.tBSearchValue_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 159;
            this.label2.Text = "Find By:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::DVLD.Properties.Resources.SearchPerson;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(664, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 49);
            this.btnSearch.TabIndex = 162;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::DVLD.Properties.Resources.AddPerson32__1_;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(723, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 49);
            this.btnAdd.TabIndex = 161;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cBFindBy
            // 
            this.cBFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBFindBy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBFindBy.FormattingEnabled = true;
            this.cBFindBy.Items.AddRange(new object[] {
            "National No",
            "Person ID"});
            this.cBFindBy.Location = new System.Drawing.Point(208, 28);
            this.cBFindBy.Name = "cBFindBy";
            this.cBFindBy.Size = new System.Drawing.Size(222, 32);
            this.cBFindBy.TabIndex = 164;
            this.cBFindBy.SelectedIndexChanged += new System.EventHandler(this.cBFindBy_SelectedIndexChanged);
            // 
            // gBFilter
            // 
            this.gBFilter.Controls.Add(this.cBFindBy);
            this.gBFilter.Controls.Add(this.label2);
            this.gBFilter.Controls.Add(this.btnSearch);
            this.gBFilter.Controls.Add(this.tBSearchValue);
            this.gBFilter.Controls.Add(this.btnAdd);
            this.gBFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBFilter.Location = new System.Drawing.Point(3, 6);
            this.gBFilter.Name = "gBFilter";
            this.gBFilter.Size = new System.Drawing.Size(1026, 78);
            this.gBFilter.TabIndex = 165;
            this.gBFilter.TabStop = false;
            this.gBFilter.Text = "Filter";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonInformation1
            // 
            this.ctrlPersonInformation1._NationalNo = null;
            this.ctrlPersonInformation1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ctrlPersonInformation1.Location = new System.Drawing.Point(3, 90);
            this.ctrlPersonInformation1.Name = "ctrlPersonInformation1";
            this.ctrlPersonInformation1.Size = new System.Drawing.Size(1026, 402);
            this.ctrlPersonInformation1.TabIndex = 157;
            // 
            // ctrlPersonInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gBFilter);
            this.Controls.Add(this.ctrlPersonInformation1);
            this.Name = "ctrlPersonInfoWithFilter";
            this.Size = new System.Drawing.Size(1033, 501);
            this.Load += new System.EventHandler(this.ctrlPersonInfoWithFilter_Load);
            this.gBFilter.ResumeLayout(false);
            this.gBFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tBSearchValue;
        private System.Windows.Forms.Label label2;
        private ctrlPersonInformation ctrlPersonInformation1;
        private System.Windows.Forms.ComboBox cBFindBy;
        private System.Windows.Forms.GroupBox gBFilter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
