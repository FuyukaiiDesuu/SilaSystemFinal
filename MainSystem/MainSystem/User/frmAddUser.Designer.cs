namespace MainSystem.User
{
    partial class frmAddUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSilaSchoolManagementSoftware = new System.Windows.Forms.Label();
            this.lblLoggedinas = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.grpEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPermissions = new System.Windows.Forms.Label();
            this.checkAccounting = new System.Windows.Forms.CheckBox();
            this.checkEmployee = new System.Windows.Forms.CheckBox();
            this.checkUser = new System.Windows.Forms.CheckBox();
            this.checkInventory = new System.Windows.Forms.CheckBox();
            this.checkRegistration = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpEmployeeDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lblSilaSchoolManagementSoftware);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 31);
            this.panel1.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DimGray;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label11.Location = new System.Drawing.Point(800, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "_";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Firebrick;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label15.Location = new System.Drawing.Point(826, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 23);
            this.label15.TabIndex = 11;
            this.label15.Text = "X";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // lblSilaSchoolManagementSoftware
            // 
            this.lblSilaSchoolManagementSoftware.AutoSize = true;
            this.lblSilaSchoolManagementSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSilaSchoolManagementSoftware.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblSilaSchoolManagementSoftware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblSilaSchoolManagementSoftware.Location = new System.Drawing.Point(51, 9);
            this.lblSilaSchoolManagementSoftware.Name = "lblSilaSchoolManagementSoftware";
            this.lblSilaSchoolManagementSoftware.Size = new System.Drawing.Size(432, 19);
            this.lblSilaSchoolManagementSoftware.TabIndex = 0;
            this.lblSilaSchoolManagementSoftware.Text = "USER MANAGEMENT - S.I.L.A SCHOOL MANAGEMENT SOFTWARE";
            // 
            // lblLoggedinas
            // 
            this.lblLoggedinas.AutoSize = true;
            this.lblLoggedinas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblLoggedinas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblLoggedinas.Location = new System.Drawing.Point(-4, 34);
            this.lblLoggedinas.Name = "lblLoggedinas";
            this.lblLoggedinas.Size = new System.Drawing.Size(104, 19);
            this.lblLoggedinas.TabIndex = 47;
            this.lblLoggedinas.Text = "Logged in as: ";
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnDashboard.Location = new System.Drawing.Point(743, 37);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(108, 37);
            this.btnDashboard.TabIndex = 46;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblUser.Location = new System.Drawing.Point(97, 34);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 19);
            this.lblUser.TabIndex = 48;
            this.lblUser.Text = "USER";
            // 
            // grpEmployeeDetails
            // 
            this.grpEmployeeDetails.Controls.Add(this.txtID);
            this.grpEmployeeDetails.Controls.Add(this.lblID);
            this.grpEmployeeDetails.Controls.Add(this.txtFullName);
            this.grpEmployeeDetails.Controls.Add(this.txtEmployeeID);
            this.grpEmployeeDetails.Controls.Add(this.lblFullName);
            this.grpEmployeeDetails.Controls.Add(this.lblEmployeeID);
            this.grpEmployeeDetails.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.grpEmployeeDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.grpEmployeeDetails.Location = new System.Drawing.Point(12, 82);
            this.grpEmployeeDetails.Name = "grpEmployeeDetails";
            this.grpEmployeeDetails.Size = new System.Drawing.Size(393, 354);
            this.grpEmployeeDetails.TabIndex = 49;
            this.grpEmployeeDetails.TabStop = false;
            this.grpEmployeeDetails.Text = "Employee Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkRegistration);
            this.groupBox1.Controls.Add(this.checkInventory);
            this.groupBox1.Controls.Add(this.checkUser);
            this.groupBox1.Controls.Add(this.checkEmployee);
            this.groupBox1.Controls.Add(this.checkAccounting);
            this.groupBox1.Controls.Add(this.lblPermissions);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.groupBox1.Location = new System.Drawing.Point(428, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 354);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Management";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(20, 144);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(107, 21);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(20, 213);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(86, 21);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(149, 138);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(215, 27);
            this.txtEmployeeID.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(149, 207);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(215, 27);
            this.txtFullName.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(142, 67);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(224, 27);
            this.txtUsername.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 73);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(88, 21);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(142, 138);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(224, 27);
            this.txtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 144);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 21);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblPermissions
            // 
            this.lblPermissions.AutoSize = true;
            this.lblPermissions.Location = new System.Drawing.Point(20, 213);
            this.lblPermissions.Name = "lblPermissions";
            this.lblPermissions.Size = new System.Drawing.Size(93, 21);
            this.lblPermissions.TabIndex = 7;
            this.lblPermissions.Text = "Permissions";
            // 
            // checkAccounting
            // 
            this.checkAccounting.AutoSize = true;
            this.checkAccounting.Location = new System.Drawing.Point(142, 195);
            this.checkAccounting.Name = "checkAccounting";
            this.checkAccounting.Size = new System.Drawing.Size(123, 25);
            this.checkAccounting.TabIndex = 8;
            this.checkAccounting.Text = "Accounting";
            this.checkAccounting.UseVisualStyleBackColor = true;
            // 
            // checkEmployee
            // 
            this.checkEmployee.AutoSize = true;
            this.checkEmployee.Location = new System.Drawing.Point(271, 195);
            this.checkEmployee.Name = "checkEmployee";
            this.checkEmployee.Size = new System.Drawing.Size(105, 25);
            this.checkEmployee.TabIndex = 9;
            this.checkEmployee.Text = "Employee";
            this.checkEmployee.UseVisualStyleBackColor = true;
            // 
            // checkUser
            // 
            this.checkUser.AutoSize = true;
            this.checkUser.Location = new System.Drawing.Point(142, 246);
            this.checkUser.Name = "checkUser";
            this.checkUser.Size = new System.Drawing.Size(61, 25);
            this.checkUser.TabIndex = 10;
            this.checkUser.Text = "User";
            this.checkUser.UseVisualStyleBackColor = true;
            // 
            // checkInventory
            // 
            this.checkInventory.AutoSize = true;
            this.checkInventory.Location = new System.Drawing.Point(271, 246);
            this.checkInventory.Name = "checkInventory";
            this.checkInventory.Size = new System.Drawing.Size(104, 25);
            this.checkInventory.TabIndex = 11;
            this.checkInventory.Text = "Inventory";
            this.checkInventory.UseVisualStyleBackColor = true;
            // 
            // checkRegistration
            // 
            this.checkRegistration.AutoSize = true;
            this.checkRegistration.Location = new System.Drawing.Point(190, 297);
            this.checkRegistration.Name = "checkRegistration";
            this.checkRegistration.Size = new System.Drawing.Size(122, 25);
            this.checkRegistration.TabIndex = 12;
            this.checkRegistration.Text = "Registration";
            this.checkRegistration.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnSave.Location = new System.Drawing.Point(12, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 28);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnCancel.Location = new System.Drawing.Point(124, 442);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 28);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(149, 67);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(215, 27);
            this.txtID.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(20, 73);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 21);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID";
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(851, 486);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpEmployeeDetails);
            this.Controls.Add(this.lblLoggedinas);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUser";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpEmployeeDetails.ResumeLayout(false);
            this.grpEmployeeDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSilaSchoolManagementSoftware;
        private System.Windows.Forms.Label lblLoggedinas;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.GroupBox grpEmployeeDetails;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkRegistration;
        private System.Windows.Forms.CheckBox checkInventory;
        private System.Windows.Forms.CheckBox checkUser;
        private System.Windows.Forms.CheckBox checkEmployee;
        private System.Windows.Forms.CheckBox checkAccounting;
        private System.Windows.Forms.Label lblPermissions;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
    }
}