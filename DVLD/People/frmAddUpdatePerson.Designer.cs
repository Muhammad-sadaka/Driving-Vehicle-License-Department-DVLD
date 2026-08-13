namespace DVLD.People
{
    partial class frmAddUpdatePerson
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbllinkRemove = new System.Windows.Forms.LinkLabel();
            this.cBCountries = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tBPhone = new System.Windows.Forms.TextBox();
            this.rBFemale = new System.Windows.Forms.RadioButton();
            this.rBMale = new System.Windows.Forms.RadioButton();
            this.linklblSetImage = new System.Windows.Forms.LinkLabel();
            this.tBAddress = new System.Windows.Forms.TextBox();
            this.tBEmail = new System.Windows.Forms.TextBox();
            this.tBNationalNo = new System.Windows.Forms.TextBox();
            this.tBLastName = new System.Windows.Forms.TextBox();
            this.tBThirdName = new System.Windows.Forms.TextBox();
            this.tBSecondName = new System.Windows.Forms.TextBox();
            this.tBFirstName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblNationalNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTtile = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pBPersonalImage = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBPersonalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbllinkRemove
            // 
            this.lbllinkRemove.AutoSize = true;
            this.lbllinkRemove.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllinkRemove.LinkColor = System.Drawing.Color.Purple;
            this.lbllinkRemove.Location = new System.Drawing.Point(977, 514);
            this.lbllinkRemove.Name = "lbllinkRemove";
            this.lbllinkRemove.Size = new System.Drawing.Size(92, 24);
            this.lbllinkRemove.TabIndex = 136;
            this.lbllinkRemove.TabStop = true;
            this.lbllinkRemove.Text = "Remove";
            this.lbllinkRemove.Visible = false;
            this.lbllinkRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllinkRemove_LinkClicked);
            // 
            // cBCountries
            // 
            this.cBCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCountries.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCountries.FormattingEnabled = true;
            this.cBCountries.Location = new System.Drawing.Point(675, 342);
            this.cBCountries.Name = "cBCountries";
            this.cBCountries.Size = new System.Drawing.Size(222, 32);
            this.cBCountries.TabIndex = 135;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(756, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 42);
            this.btnSave.TabIndex = 134;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(606, 527);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 42);
            this.btnClose.TabIndex = 133;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1001, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 24);
            this.label7.TabIndex = 132;
            this.label7.Text = "Last";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(767, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 131;
            this.label6.Text = "Third";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(531, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 130;
            this.label5.Text = "Second";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 129;
            this.label4.Text = "First";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(518, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 128;
            this.label3.Text = "Country:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 127;
            this.label2.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(466, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 24);
            this.label8.TabIndex = 126;
            this.label8.Text = "Date Of Birth:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(675, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 26);
            this.dateTimePicker1.TabIndex = 125;
            // 
            // tBPhone
            // 
            this.tBPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPhone.Location = new System.Drawing.Point(675, 283);
            this.tBPhone.Name = "tBPhone";
            this.tBPhone.Size = new System.Drawing.Size(222, 32);
            this.tBPhone.TabIndex = 124;
            this.tBPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPhone_KeyPress);
            this.tBPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tBPhone_Validating_1);
            // 
            // rBFemale
            // 
            this.rBFemale.AutoSize = true;
            this.rBFemale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBFemale.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBFemale.Location = new System.Drawing.Point(375, 280);
            this.rBFemale.Name = "rBFemale";
            this.rBFemale.Size = new System.Drawing.Size(103, 28);
            this.rBFemale.TabIndex = 123;
            this.rBFemale.Text = "Female";
            this.rBFemale.UseVisualStyleBackColor = true;
            // 
            // rBMale
            // 
            this.rBMale.AutoSize = true;
            this.rBMale.Checked = true;
            this.rBMale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBMale.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBMale.Location = new System.Drawing.Point(220, 280);
            this.rBMale.Name = "rBMale";
            this.rBMale.Size = new System.Drawing.Size(78, 28);
            this.rBMale.TabIndex = 122;
            this.rBMale.TabStop = true;
            this.rBMale.Text = "Male";
            this.rBMale.UseVisualStyleBackColor = true;
            this.rBMale.CheckedChanged += new System.EventHandler(this.rBMale_CheckedChanged);
            // 
            // linklblSetImage
            // 
            this.linklblSetImage.AutoSize = true;
            this.linklblSetImage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblSetImage.LinkColor = System.Drawing.Color.Purple;
            this.linklblSetImage.Location = new System.Drawing.Point(973, 483);
            this.linklblSetImage.Name = "linklblSetImage";
            this.linklblSetImage.Size = new System.Drawing.Size(115, 24);
            this.linklblSetImage.TabIndex = 121;
            this.linklblSetImage.TabStop = true;
            this.linklblSetImage.Text = "Set Image";
            this.linklblSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblSetImage_LinkClicked);
            // 
            // tBAddress
            // 
            this.tBAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBAddress.Location = new System.Drawing.Point(220, 404);
            this.tBAddress.Multiline = true;
            this.tBAddress.Name = "tBAddress";
            this.tBAddress.Size = new System.Drawing.Size(677, 117);
            this.tBAddress.TabIndex = 120;
            this.tBAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tBAddress_Validating_1);
            // 
            // tBEmail
            // 
            this.tBEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBEmail.Location = new System.Drawing.Point(220, 343);
            this.tBEmail.Name = "tBEmail";
            this.tBEmail.Size = new System.Drawing.Size(222, 32);
            this.tBEmail.TabIndex = 119;
            this.tBEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tBEmail_Validating);
            // 
            // tBNationalNo
            // 
            this.tBNationalNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNationalNo.Location = new System.Drawing.Point(220, 224);
            this.tBNationalNo.Name = "tBNationalNo";
            this.tBNationalNo.Size = new System.Drawing.Size(222, 32);
            this.tBNationalNo.TabIndex = 118;
            this.tBNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.tBNationalNo_Validating_1);
            // 
            // tBLastName
            // 
            this.tBLastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBLastName.Location = new System.Drawing.Point(928, 165);
            this.tBLastName.Name = "tBLastName";
            this.tBLastName.Size = new System.Drawing.Size(222, 32);
            this.tBLastName.TabIndex = 117;
            this.tBLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tBLastName_Validating_1);
            // 
            // tBThirdName
            // 
            this.tBThirdName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBThirdName.Location = new System.Drawing.Point(689, 165);
            this.tBThirdName.Name = "tBThirdName";
            this.tBThirdName.Size = new System.Drawing.Size(222, 32);
            this.tBThirdName.TabIndex = 116;
            // 
            // tBSecondName
            // 
            this.tBSecondName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSecondName.Location = new System.Drawing.Point(456, 165);
            this.tBSecondName.Name = "tBSecondName";
            this.tBSecondName.Size = new System.Drawing.Size(222, 32);
            this.tBSecondName.TabIndex = 115;
            this.tBSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.tBSecondName_Validating_1);
            // 
            // tBFirstName
            // 
            this.tBFirstName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBFirstName.Location = new System.Drawing.Point(220, 165);
            this.tBFirstName.Name = "tBFirstName";
            this.tBFirstName.Size = new System.Drawing.Size(222, 32);
            this.tBFirstName.TabIndex = 1;
            this.tBFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tBFirstName_Validating_1);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(38, 404);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(98, 24);
            this.lblAddress.TabIndex = 113;
            this.lblAddress.Text = "Address:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(64, 342);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 24);
            this.lblEmail.TabIndex = 112;
            this.lblEmail.Text = "Email:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(45, 283);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(91, 24);
            this.lblGender.TabIndex = 111;
            this.lblGender.Text = "Gender:";
            // 
            // lblNationalNo
            // 
            this.lblNationalNo.AutoSize = true;
            this.lblNationalNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalNo.Location = new System.Drawing.Point(21, 224);
            this.lblNationalNo.Name = "lblNationalNo";
            this.lblNationalNo.Size = new System.Drawing.Size(134, 24);
            this.lblNationalNo.TabIndex = 110;
            this.lblNationalNo.Text = "National No:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(61, 164);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 24);
            this.lblName.TabIndex = 109;
            this.lblName.Text = "Name:";
            // 
            // lblTtile
            // 
            this.lblTtile.AutoSize = true;
            this.lblTtile.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTtile.Location = new System.Drawing.Point(447, 24);
            this.lblTtile.Name = "lblTtile";
            this.lblTtile.Size = new System.Drawing.Size(264, 36);
            this.lblTtile.TabIndex = 108;
            this.lblTtile.Text = "Add New Person";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(247, 92);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(51, 24);
            this.lblID.TabIndex = 107;
            this.lblID.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 106;
            this.label1.Text = "Person ID:";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = global::DVLD.Properties.Resources.country_new;
            this.pictureBox11.Location = new System.Drawing.Point(624, 343);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(35, 33);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 147;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::DVLD.Properties.Resources.call32;
            this.pictureBox10.Location = new System.Drawing.Point(624, 283);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(35, 33);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 146;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::DVLD.Properties.Resources.Calendar32;
            this.pictureBox9.Location = new System.Drawing.Point(624, 224);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(35, 33);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 145;
            this.pictureBox9.TabStop = false;
            // 
            // pBPersonalImage
            // 
            this.pBPersonalImage.BackColor = System.Drawing.Color.Transparent;
            this.pBPersonalImage.Image = global::DVLD.Properties.Resources.male_v2;
            this.pBPersonalImage.Location = new System.Drawing.Point(928, 224);
            this.pBPersonalImage.Name = "pBPersonalImage";
            this.pBPersonalImage.Size = new System.Drawing.Size(222, 229);
            this.pBPersonalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBPersonalImage.TabIndex = 144;
            this.pBPersonalImage.TabStop = false;
            this.pBPersonalImage.Tag = "";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::DVLD.Properties.Resources.Woman32;
            this.pictureBox7.Location = new System.Drawing.Point(322, 280);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 33);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 143;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::DVLD.Properties.Resources.address_new;
            this.pictureBox6.Location = new System.Drawing.Point(162, 404);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 142;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::DVLD.Properties.Resources.email_new;
            this.pictureBox5.Location = new System.Drawing.Point(162, 342);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 141;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::DVLD.Properties.Resources.Man32;
            this.pictureBox4.Location = new System.Drawing.Point(162, 282);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 140;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::DVLD.Properties.Resources.number_new;
            this.pictureBox3.Location = new System.Drawing.Point(162, 224);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 139;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Person32;
            this.pictureBox1.Location = new System.Drawing.Point(162, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 138;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DVLD.Properties.Resources.number_new;
            this.pictureBox2.Location = new System.Drawing.Point(176, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 137;
            this.pictureBox2.TabStop = false;
            // 
            // frmAddUpdatePerson
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1162, 584);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pBPersonalImage);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbllinkRemove);
            this.Controls.Add(this.cBCountries);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tBPhone);
            this.Controls.Add(this.rBFemale);
            this.Controls.Add(this.rBMale);
            this.Controls.Add(this.linklblSetImage);
            this.Controls.Add(this.tBAddress);
            this.Controls.Add(this.tBEmail);
            this.Controls.Add(this.tBNationalNo);
            this.Controls.Add(this.tBLastName);
            this.Controls.Add(this.tBThirdName);
            this.Controls.Add(this.tBSecondName);
            this.Controls.Add(this.tBFirstName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblNationalNo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTtile);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdatePerson";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Update _Person";
            this.Load += new System.EventHandler(this.frmAddUpdatePerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBPersonalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pBPersonalImage;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel lbllinkRemove;
        private System.Windows.Forms.ComboBox cBCountries;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tBPhone;
        private System.Windows.Forms.RadioButton rBFemale;
        private System.Windows.Forms.RadioButton rBMale;
        private System.Windows.Forms.LinkLabel linklblSetImage;
        private System.Windows.Forms.TextBox tBAddress;
        private System.Windows.Forms.TextBox tBEmail;
        private System.Windows.Forms.TextBox tBNationalNo;
        private System.Windows.Forms.TextBox tBLastName;
        private System.Windows.Forms.TextBox tBThirdName;
        private System.Windows.Forms.TextBox tBSecondName;
        private System.Windows.Forms.TextBox tBFirstName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNationalNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTtile;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
    }
}