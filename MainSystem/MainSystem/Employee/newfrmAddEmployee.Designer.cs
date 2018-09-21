namespace MainSystem.Employee
{
    partial class newfrmAddEmployee
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSpecify = new System.Windows.Forms.TextBox();
            this.grpPersonalDetails = new System.Windows.Forms.GroupBox();
            this.lblSpecify = new System.Windows.Forms.Label();
            this.cmbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.cmbReligion = new System.Windows.Forms.ComboBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.lblBirthPlace = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.dateBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.lblReligion = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.grpEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSilaSchoolManagementSoftware = new System.Windows.Forms.Label();
            this.grpPersonalDetails.SuspendLayout();
            this.grpEmployeeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnCancel.Location = new System.Drawing.Point(607, 363);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 37);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(162)))), ((int)(((byte)(23)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(41)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(496, 363);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 37);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSpecify
            // 
            this.txtSpecify.BackColor = System.Drawing.Color.White;
            this.txtSpecify.Enabled = false;
            this.txtSpecify.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtSpecify.Location = new System.Drawing.Point(132, 189);
            this.txtSpecify.Name = "txtSpecify";
            this.txtSpecify.Size = new System.Drawing.Size(180, 27);
            this.txtSpecify.TabIndex = 9;
            // 
            // grpPersonalDetails
            // 
            this.grpPersonalDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpPersonalDetails.Controls.Add(this.txtSpecify);
            this.grpPersonalDetails.Controls.Add(this.lblSpecify);
            this.grpPersonalDetails.Controls.Add(this.cmbMaritalStatus);
            this.grpPersonalDetails.Controls.Add(this.cmbReligion);
            this.grpPersonalDetails.Controls.Add(this.txtContactNo);
            this.grpPersonalDetails.Controls.Add(this.lblContactNo);
            this.grpPersonalDetails.Controls.Add(this.txtBirthPlace);
            this.grpPersonalDetails.Controls.Add(this.lblBirthPlace);
            this.grpPersonalDetails.Controls.Add(this.cmbSex);
            this.grpPersonalDetails.Controls.Add(this.dateBirthDate);
            this.grpPersonalDetails.Controls.Add(this.lblMaritalStatus);
            this.grpPersonalDetails.Controls.Add(this.lblReligion);
            this.grpPersonalDetails.Controls.Add(this.lblSex);
            this.grpPersonalDetails.Controls.Add(this.lblBirthDate);
            this.grpPersonalDetails.Font = new System.Drawing.Font("Bebas Neue", 14.25F);
            this.grpPersonalDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.grpPersonalDetails.Location = new System.Drawing.Point(380, 55);
            this.grpPersonalDetails.Name = "grpPersonalDetails";
            this.grpPersonalDetails.Size = new System.Drawing.Size(332, 302);
            this.grpPersonalDetails.TabIndex = 16;
            this.grpPersonalDetails.TabStop = false;
            this.grpPersonalDetails.Text = "Personal Details";
            // 
            // lblSpecify
            // 
            this.lblSpecify.AutoSize = true;
            this.lblSpecify.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblSpecify.ForeColor = System.Drawing.Color.White;
            this.lblSpecify.Location = new System.Drawing.Point(11, 195);
            this.lblSpecify.Name = "lblSpecify";
            this.lblSpecify.Size = new System.Drawing.Size(108, 19);
            this.lblSpecify.TabIndex = 0;
            this.lblSpecify.Text = "Please Specify";
            // 
            // cmbMaritalStatus
            // 
            this.cmbMaritalStatus.BackColor = System.Drawing.Color.White;
            this.cmbMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaritalStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cmbMaritalStatus.FormattingEnabled = true;
            this.cmbMaritalStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced"});
            this.cmbMaritalStatus.Location = new System.Drawing.Point(132, 222);
            this.cmbMaritalStatus.Name = "cmbMaritalStatus";
            this.cmbMaritalStatus.Size = new System.Drawing.Size(180, 27);
            this.cmbMaritalStatus.TabIndex = 10;
            this.cmbMaritalStatus.TextChanged += new System.EventHandler(this.cmbMaritalStatus_TextChanged);
            this.cmbMaritalStatus.Validating += new System.ComponentModel.CancelEventHandler(this.cmbMaritalStatus_Validating);
            // 
            // cmbReligion
            // 
            this.cmbReligion.BackColor = System.Drawing.Color.White;
            this.cmbReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReligion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cmbReligion.FormattingEnabled = true;
            this.cmbReligion.Items.AddRange(new object[] {
            "Roman Catholic",
            "Islam",
            "Iglesia Ni Cristo",
            "Jehovah\'s Witness",
            "Others"});
            this.cmbReligion.Location = new System.Drawing.Point(132, 156);
            this.cmbReligion.Name = "cmbReligion";
            this.cmbReligion.Size = new System.Drawing.Size(180, 27);
            this.cmbReligion.TabIndex = 8;
            this.cmbReligion.TextChanged += new System.EventHandler(this.cmbReligion_TextChanged);
            this.cmbReligion.Validating += new System.ComponentModel.CancelEventHandler(this.cmbReligion_Validating);
            // 
            // txtContactNo
            // 
            this.txtContactNo.BackColor = System.Drawing.Color.White;
            this.txtContactNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtContactNo.Location = new System.Drawing.Point(132, 90);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(180, 27);
            this.txtContactNo.TabIndex = 6;
            this.txtContactNo.TextChanged += new System.EventHandler(this.txtContactNo_TextChanged);
            this.txtContactNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtContactNo_Validating);
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblContactNo.ForeColor = System.Drawing.Color.White;
            this.lblContactNo.Location = new System.Drawing.Point(11, 96);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(87, 19);
            this.lblContactNo.TabIndex = 0;
            this.lblContactNo.Text = "Contact No";
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.BackColor = System.Drawing.Color.White;
            this.txtBirthPlace.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtBirthPlace.Location = new System.Drawing.Point(132, 57);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(180, 27);
            this.txtBirthPlace.TabIndex = 5;
            this.txtBirthPlace.TextChanged += new System.EventHandler(this.txtBirthPlace_TextChanged);
            this.txtBirthPlace.Validating += new System.ComponentModel.CancelEventHandler(this.txtBirthPlace_Validating);
            // 
            // lblBirthPlace
            // 
            this.lblBirthPlace.AutoSize = true;
            this.lblBirthPlace.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblBirthPlace.ForeColor = System.Drawing.Color.White;
            this.lblBirthPlace.Location = new System.Drawing.Point(11, 63);
            this.lblBirthPlace.Name = "lblBirthPlace";
            this.lblBirthPlace.Size = new System.Drawing.Size(83, 19);
            this.lblBirthPlace.TabIndex = 0;
            this.lblBirthPlace.Text = "Birth Place";
            // 
            // cmbSex
            // 
            this.cmbSex.BackColor = System.Drawing.Color.White;
            this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSex.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbSex.Location = new System.Drawing.Point(132, 123);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(180, 27);
            this.cmbSex.TabIndex = 7;
            this.cmbSex.TextChanged += new System.EventHandler(this.cmbSex_TextChanged);
            this.cmbSex.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSex_Validating);
            // 
            // dateBirthDate
            // 
            this.dateBirthDate.CustomFormat = "yyyy/MM/dd";
            this.dateBirthDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.dateBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBirthDate.Location = new System.Drawing.Point(132, 24);
            this.dateBirthDate.Name = "dateBirthDate";
            this.dateBirthDate.Size = new System.Drawing.Size(180, 27);
            this.dateBirthDate.TabIndex = 4;
            this.dateBirthDate.ValueChanged += new System.EventHandler(this.dateBirthDate_ValueChanged);
            this.dateBirthDate.Validating += new System.ComponentModel.CancelEventHandler(this.dateBirthDate_Validating);
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblMaritalStatus.ForeColor = System.Drawing.Color.White;
            this.lblMaritalStatus.Location = new System.Drawing.Point(11, 228);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(104, 19);
            this.lblMaritalStatus.TabIndex = 0;
            this.lblMaritalStatus.Text = "Marital Status";
            // 
            // lblReligion
            // 
            this.lblReligion.AutoSize = true;
            this.lblReligion.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblReligion.ForeColor = System.Drawing.Color.White;
            this.lblReligion.Location = new System.Drawing.Point(11, 162);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.Size = new System.Drawing.Size(66, 19);
            this.lblReligion.TabIndex = 0;
            this.lblReligion.Text = "Religion";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblSex.ForeColor = System.Drawing.Color.White;
            this.lblSex.Location = new System.Drawing.Point(11, 129);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(34, 19);
            this.lblSex.TabIndex = 0;
            this.lblSex.Text = "Sex";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblBirthDate.ForeColor = System.Drawing.Color.White;
            this.lblBirthDate.Location = new System.Drawing.Point(11, 30);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(79, 19);
            this.lblBirthDate.TabIndex = 0;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(16, 102);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(83, 19);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // grpEmployeeDetails
            // 
            this.grpEmployeeDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpEmployeeDetails.Controls.Add(this.cmbPosition);
            this.grpEmployeeDetails.Controls.Add(this.lblPosition);
            this.grpEmployeeDetails.Controls.Add(this.txtMiddleName);
            this.grpEmployeeDetails.Controls.Add(this.txtFirstName);
            this.grpEmployeeDetails.Controls.Add(this.lblMiddleName);
            this.grpEmployeeDetails.Controls.Add(this.lblFirstName);
            this.grpEmployeeDetails.Controls.Add(this.txtLastName);
            this.grpEmployeeDetails.Controls.Add(this.lblLastName);
            this.grpEmployeeDetails.Font = new System.Drawing.Font("Bebas Neue", 14.25F);
            this.grpEmployeeDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.grpEmployeeDetails.Location = new System.Drawing.Point(21, 55);
            this.grpEmployeeDetails.Name = "grpEmployeeDetails";
            this.grpEmployeeDetails.Size = new System.Drawing.Size(353, 302);
            this.grpEmployeeDetails.TabIndex = 15;
            this.grpEmployeeDetails.TabStop = false;
            this.grpEmployeeDetails.Text = "Employee Details";
            // 
            // cmbPosition
            // 
            this.cmbPosition.BackColor = System.Drawing.Color.White;
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "Admin",
            "Faculty",
            "Staff",
            "Teacher"});
            this.cmbPosition.Location = new System.Drawing.Point(136, 129);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(180, 27);
            this.cmbPosition.TabIndex = 11;
            this.cmbPosition.TextChanged += new System.EventHandler(this.cmbPosition_TextChanged);
            this.cmbPosition.Validating += new System.ComponentModel.CancelEventHandler(this.cmbPosition_Validating);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(16, 135);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(65, 19);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "Position";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.Color.White;
            this.txtMiddleName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtMiddleName.Location = new System.Drawing.Point(136, 63);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(180, 27);
            this.txtMiddleName.TabIndex = 2;
            this.txtMiddleName.TextChanged += new System.EventHandler(this.txtMiddleName_TextChanged);
            this.txtMiddleName.Validating += new System.ComponentModel.CancelEventHandler(this.txtMiddleName_Validating);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.Location = new System.Drawing.Point(136, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 27);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblMiddleName.ForeColor = System.Drawing.Color.White;
            this.lblMiddleName.Location = new System.Drawing.Point(16, 69);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(101, 19);
            this.lblMiddleName.TabIndex = 0;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(16, 36);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(85, 19);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtLastName.Location = new System.Drawing.Point(136, 96);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 27);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblSilaSchoolManagementSoftware);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 34);
            this.panel1.TabIndex = 38;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MainSystem.Properties.Resources.starlogo2;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lblSilaSchoolManagementSoftware
            // 
            this.lblSilaSchoolManagementSoftware.AutoSize = true;
            this.lblSilaSchoolManagementSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSilaSchoolManagementSoftware.Font = new System.Drawing.Font("Bebas Neue", 13.8F, System.Drawing.FontStyle.Italic);
            this.lblSilaSchoolManagementSoftware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblSilaSchoolManagementSoftware.Location = new System.Drawing.Point(51, 8);
            this.lblSilaSchoolManagementSoftware.Name = "lblSilaSchoolManagementSoftware";
            this.lblSilaSchoolManagementSoftware.Size = new System.Drawing.Size(399, 23);
            this.lblSilaSchoolManagementSoftware.TabIndex = 0;
            this.lblSilaSchoolManagementSoftware.Text = "EMPLOYEE MANAGEMENT - S.I.L.A SCHOOL MANAGEMENT SOFTWARE";
            // 
            // newfrmAddEmployee
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(724, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpPersonalDetails);
            this.Controls.Add(this.grpEmployeeDetails);
            this.MinimumSize = new System.Drawing.Size(740, 452);
            this.Name = "newfrmAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.newfrmAddEmployee_Load);
            this.grpPersonalDetails.ResumeLayout(false);
            this.grpPersonalDetails.PerformLayout();
            this.grpEmployeeDetails.ResumeLayout(false);
            this.grpEmployeeDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtSpecify;
        private System.Windows.Forms.GroupBox grpPersonalDetails;
        private System.Windows.Forms.Label lblSpecify;
        public System.Windows.Forms.ComboBox cmbMaritalStatus;
        public System.Windows.Forms.ComboBox cmbReligion;
        public System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label lblContactNo;
        public System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.Label lblBirthPlace;
        public System.Windows.Forms.ComboBox cmbSex;
        public System.Windows.Forms.DateTimePicker dateBirthDate;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.Label lblReligion;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.GroupBox grpEmployeeDetails;
        public System.Windows.Forms.TextBox txtMiddleName;
        public System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstName;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSilaSchoolManagementSoftware;
    }
}