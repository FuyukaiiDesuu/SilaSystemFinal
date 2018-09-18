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
            this.lblSY = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUserForm = new System.Windows.Forms.Button();
            this.btnInventoryForm = new System.Windows.Forms.Button();
            this.btnEmployeeForm = new System.Windows.Forms.Button();
            this.btnRegistrationForm = new System.Windows.Forms.Button();
            this.btnAccountForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSilaSchoolManagementSoftware
            // 
            this.lblSilaSchoolManagementSoftware.AutoSize = true;
            this.lblSilaSchoolManagementSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSilaSchoolManagementSoftware.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSilaSchoolManagementSoftware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblSilaSchoolManagementSoftware.Location = new System.Drawing.Point(45, 2);
            this.lblSilaSchoolManagementSoftware.Name = "lblSilaSchoolManagementSoftware";
            this.lblSilaSchoolManagementSoftware.Size = new System.Drawing.Size(275, 26);
            this.lblSilaSchoolManagementSoftware.TabIndex = 0;
            this.lblSilaSchoolManagementSoftware.Text = "S.I.L.A SCHOOL MANAGEMENT SOFTWARE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "LOGGED IN USER:";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblusername.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblusername.Location = new System.Drawing.Point(116, 45);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(112, 26);
            this.lblusername.TabIndex = 7;
            this.lblusername.Text = "%USERNAME%";
            this.lblusername.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLGOUT
            // 
            this.btnLGOUT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLGOUT.BackColor = System.Drawing.Color.DarkRed;
            this.btnLGOUT.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnLGOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLGOUT.Font = new System.Drawing.Font("Bebas Neue", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLGOUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnLGOUT.Location = new System.Drawing.Point(806, 37);
            this.btnLGOUT.Name = "btnLGOUT";
            this.btnLGOUT.Size = new System.Drawing.Size(172, 54);
            this.btnLGOUT.TabIndex = 8;
            this.btnLGOUT.Text = "Logout";
            this.btnLGOUT.UseVisualStyleBackColor = false;
            this.btnLGOUT.Click += new System.EventHandler(this.btnLGOUT_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSY);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblSilaSchoolManagementSoftware);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 31);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblSY
            // 
            this.lblSY.AutoSize = true;
            this.lblSY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSY.Font = new System.Drawing.Font("Bebas Neue", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblSY.Location = new System.Drawing.Point(884, 4);
            this.lblSY.Name = "lblSY";
            this.lblSY.Size = new System.Drawing.Size(87, 23);
            this.lblSY.TabIndex = 16;
            this.lblSY.Text = "CURRENT S.Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.label2.Location = new System.Drawing.Point(802, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "CURRENT S.Y:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Bebas Neue", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.label4.Location = new System.Drawing.Point(49, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Accounting Management";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Bebas Neue", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.label5.Location = new System.Drawing.Point(382, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enrollment Management";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Bebas Neue", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.label6.Location = new System.Drawing.Point(729, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Employee Management";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Bebas Neue", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.label7.Location = new System.Drawing.Point(216, 557);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Inventory Management";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Bebas Neue", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.label8.Location = new System.Drawing.Point(594, 557);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "User Management";
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
            // btnUserForm
            // 
            this.btnUserForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserForm.BackgroundImage = global::MainSystem.Properties.Resources.settings;
            this.btnUserForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUserForm.FlatAppearance.BorderSize = 0;
            this.btnUserForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserForm.Location = new System.Drawing.Point(585, 372);
            this.btnUserForm.Name = "btnUserForm";
            this.btnUserForm.Size = new System.Drawing.Size(205, 183);
            this.btnUserForm.TabIndex = 5;
            this.btnUserForm.UseVisualStyleBackColor = true;
            this.btnUserForm.Click += new System.EventHandler(this.btnUserForm_Click);
            // 
            // btnInventoryForm
            // 
            this.btnInventoryForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInventoryForm.BackgroundImage = global::MainSystem.Properties.Resources.box;
            this.btnInventoryForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInventoryForm.FlatAppearance.BorderSize = 0;
            this.btnInventoryForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryForm.Location = new System.Drawing.Point(233, 372);
            this.btnInventoryForm.Name = "btnInventoryForm";
            this.btnInventoryForm.Size = new System.Drawing.Size(200, 182);
            this.btnInventoryForm.TabIndex = 4;
            this.btnInventoryForm.UseVisualStyleBackColor = true;
            this.btnInventoryForm.Click += new System.EventHandler(this.btnInventoryForm_Click);
            // 
            // btnEmployeeForm
            // 
            this.btnEmployeeForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmployeeForm.BackgroundImage = global::MainSystem.Properties.Resources.student;
            this.btnEmployeeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmployeeForm.FlatAppearance.BorderSize = 0;
            this.btnEmployeeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeForm.Location = new System.Drawing.Point(749, 121);
            this.btnEmployeeForm.Name = "btnEmployeeForm";
            this.btnEmployeeForm.Size = new System.Drawing.Size(183, 177);
            this.btnEmployeeForm.TabIndex = 3;
            this.btnEmployeeForm.UseVisualStyleBackColor = true;
            this.btnEmployeeForm.Click += new System.EventHandler(this.btnEmployeeForm_Click);
            // 
            // btnRegistrationForm
            // 
            this.btnRegistrationForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrationForm.BackgroundImage = global::MainSystem.Properties.Resources.document;
            this.btnRegistrationForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegistrationForm.FlatAppearance.BorderSize = 0;
            this.btnRegistrationForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrationForm.Location = new System.Drawing.Point(420, 136);
            this.btnRegistrationForm.Name = "btnRegistrationForm";
            this.btnRegistrationForm.Size = new System.Drawing.Size(182, 162);
            this.btnRegistrationForm.TabIndex = 2;
            this.btnRegistrationForm.UseVisualStyleBackColor = true;
            this.btnRegistrationForm.Click += new System.EventHandler(this.btnEnrollmentForm_Click);
            // 
            // btnAccountForm
            // 
            this.btnAccountForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccountForm.BackgroundImage = global::MainSystem.Properties.Resources.piggy_bank;
            this.btnAccountForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAccountForm.FlatAppearance.BorderSize = 0;
            this.btnAccountForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountForm.Location = new System.Drawing.Point(66, 121);
            this.btnAccountForm.Name = "btnAccountForm";
            this.btnAccountForm.Size = new System.Drawing.Size(200, 177);
            this.btnAccountForm.TabIndex = 1;
            this.btnAccountForm.UseVisualStyleBackColor = true;
            this.btnAccountForm.Click += new System.EventHandler(this.btnAccountForm_Click);
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
        private System.Windows.Forms.Button btnLGOUT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusername;
    }
}