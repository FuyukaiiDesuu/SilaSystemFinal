namespace MainSystem
{
    partial class frmMain
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
            this.lblSilaSchoolManagementSoftware = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.btnLGOUT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUserForm = new System.Windows.Forms.Button();
            this.btnInventoryForm = new System.Windows.Forms.Button();
            this.btnEmployeeForm = new System.Windows.Forms.Button();
            this.btnRegistrationForm = new System.Windows.Forms.Button();
            this.btnAccountForm = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSilaSchoolManagementSoftware
            // 
            this.lblSilaSchoolManagementSoftware.AutoSize = true;
            this.lblSilaSchoolManagementSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSilaSchoolManagementSoftware.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblSilaSchoolManagementSoftware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblSilaSchoolManagementSoftware.Location = new System.Drawing.Point(51, 9);
            this.lblSilaSchoolManagementSoftware.Name = "lblSilaSchoolManagementSoftware";
            this.lblSilaSchoolManagementSoftware.Size = new System.Drawing.Size(285, 19);
            this.lblSilaSchoolManagementSoftware.TabIndex = 0;
            this.lblSilaSchoolManagementSoftware.Text = "S.I.L.A SCHOOL MANAGEMENT SOFTWARE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.label1.Location = new System.Drawing.Point(-3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "LOGGED IN USER:";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblusername.Location = new System.Drawing.Point(127, 52);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(109, 16);
            this.lblusername.TabIndex = 7;
            this.lblusername.Text = "%USERNAME%";
            this.lblusername.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLGOUT
            // 
            this.btnLGOUT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLGOUT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnLGOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLGOUT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLGOUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnLGOUT.Location = new System.Drawing.Point(839, 32);
            this.btnLGOUT.Name = "btnLGOUT";
            this.btnLGOUT.Size = new System.Drawing.Size(144, 54);
            this.btnLGOUT.TabIndex = 8;
            this.btnLGOUT.Text = "Logout";
            this.btnLGOUT.UseVisualStyleBackColor = true;
            this.btnLGOUT.Click += new System.EventHandler(this.btnLGOUT_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblSilaSchoolManagementSoftware);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 31);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainSystem.Properties.Resources.starlogo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.label4.Location = new System.Drawing.Point(33, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Accounting Management";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.label5.Location = new System.Drawing.Point(374, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enrollment Management";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.label6.Location = new System.Drawing.Point(698, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Employee Management";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.label7.Location = new System.Drawing.Point(200, 539);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Inventory Management";
            // 
            // btnUserForm
            // 
            this.btnUserForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserForm.BackgroundImage = global::MainSystem.Properties.Resources.team;
            this.btnUserForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUserForm.FlatAppearance.BorderSize = 0;
            this.btnUserForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserForm.Location = new System.Drawing.Point(601, 374);
            this.btnUserForm.Name = "btnUserForm";
            this.btnUserForm.Size = new System.Drawing.Size(167, 141);
            this.btnUserForm.TabIndex = 5;
            this.btnUserForm.UseVisualStyleBackColor = true;
            this.btnUserForm.Click += new System.EventHandler(this.btnUserForm_Click);
            // 
            // btnInventoryForm
            // 
            this.btnInventoryForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInventoryForm.BackgroundImage = global::MainSystem.Properties.Resources.checklist;
            this.btnInventoryForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInventoryForm.FlatAppearance.BorderSize = 0;
            this.btnInventoryForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryForm.Location = new System.Drawing.Point(245, 374);
            this.btnInventoryForm.Name = "btnInventoryForm";
            this.btnInventoryForm.Size = new System.Drawing.Size(167, 141);
            this.btnInventoryForm.TabIndex = 4;
            this.btnInventoryForm.UseVisualStyleBackColor = true;
            this.btnInventoryForm.Click += new System.EventHandler(this.btnInventoryForm_Click);
            // 
            // btnEmployeeForm
            // 
            this.btnEmployeeForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmployeeForm.BackgroundImage = global::MainSystem.Properties.Resources.employees1;
            this.btnEmployeeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmployeeForm.FlatAppearance.BorderSize = 0;
            this.btnEmployeeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeForm.Location = new System.Drawing.Point(750, 124);
            this.btnEmployeeForm.Name = "btnEmployeeForm";
            this.btnEmployeeForm.Size = new System.Drawing.Size(167, 141);
            this.btnEmployeeForm.TabIndex = 3;
            this.btnEmployeeForm.UseVisualStyleBackColor = true;
            this.btnEmployeeForm.Click += new System.EventHandler(this.btnEmployeeForm_Click);
            // 
            // btnRegistrationForm
            // 
            this.btnRegistrationForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrationForm.BackgroundImage = global::MainSystem.Properties.Resources.edit1;
            this.btnRegistrationForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegistrationForm.FlatAppearance.BorderSize = 0;
            this.btnRegistrationForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrationForm.Location = new System.Drawing.Point(430, 124);
            this.btnRegistrationForm.Name = "btnRegistrationForm";
            this.btnRegistrationForm.Size = new System.Drawing.Size(167, 141);
            this.btnRegistrationForm.TabIndex = 2;
            this.btnRegistrationForm.UseVisualStyleBackColor = true;
            this.btnRegistrationForm.Click += new System.EventHandler(this.btnEnrollmentForm_Click);
            // 
            // btnAccountForm
            // 
            this.btnAccountForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccountForm.BackgroundImage = global::MainSystem.Properties.Resources.money1;
            this.btnAccountForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAccountForm.FlatAppearance.BorderSize = 0;
            this.btnAccountForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountForm.Location = new System.Drawing.Point(81, 124);
            this.btnAccountForm.Name = "btnAccountForm";
            this.btnAccountForm.Size = new System.Drawing.Size(167, 141);
            this.btnAccountForm.TabIndex = 1;
            this.btnAccountForm.UseVisualStyleBackColor = true;
            this.btnAccountForm.Click += new System.EventHandler(this.btnAccountForm_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.label8.Location = new System.Drawing.Point(582, 539);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "User Management";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(983, 614);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.btnLGOUT);
            this.Controls.Add(this.btnUserForm);
            this.Controls.Add(this.btnInventoryForm);
            this.Controls.Add(this.btnEmployeeForm);
            this.Controls.Add(this.btnRegistrationForm);
            this.Controls.Add(this.btnAccountForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccountForm;
        private System.Windows.Forms.Button btnRegistrationForm;
        private System.Windows.Forms.Button btnEmployeeForm;
        private System.Windows.Forms.Button btnInventoryForm;
        private System.Windows.Forms.Button btnUserForm;
        private System.Windows.Forms.Label lblSilaSchoolManagementSoftware;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Button btnLGOUT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}