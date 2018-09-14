namespace MainSystem.Accounting
{
    partial class frmAddFee
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
            this.grpAddFee = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblFeeDescription = new System.Windows.Forms.Label();
            this.cmbGradeLevel = new System.Windows.Forms.ComboBox();
            this.lblGradeLevel = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLoggedinas = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDate2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSilaSchoolManagementSoftware = new System.Windows.Forms.Label();
            this.grpAddFee.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAddFee
            // 
            this.grpAddFee.Controls.Add(this.comboBox2);
            this.grpAddFee.Controls.Add(this.label1);
            this.grpAddFee.Controls.Add(this.label3);
            this.grpAddFee.Controls.Add(this.textBox1);
            this.grpAddFee.Controls.Add(this.comboBox1);
            this.grpAddFee.Controls.Add(this.txtAmount);
            this.grpAddFee.Controls.Add(this.lblAmount);
            this.grpAddFee.Controls.Add(this.lblFeeDescription);
            this.grpAddFee.Controls.Add(this.cmbGradeLevel);
            this.grpAddFee.Controls.Add(this.lblGradeLevel);
            this.grpAddFee.Font = new System.Drawing.Font("Bebas Neue", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.grpAddFee.Location = new System.Drawing.Point(17, 80);
            this.grpAddFee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAddFee.Name = "grpAddFee";
            this.grpAddFee.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAddFee.Size = new System.Drawing.Size(784, 313);
            this.grpAddFee.TabIndex = 0;
            this.grpAddFee.TabStop = false;
            this.grpAddFee.Text = "Add Fee";
            this.grpAddFee.Enter += new System.EventHandler(this.grpAddFee_Enter);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2018 - 2019",
            "2019 - 2020",
            "2020 - 2021",
            "2021 - 2022",
            "2022 - 2023"});
            this.comboBox2.Location = new System.Drawing.Point(343, 39);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(265, 32);
            this.comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "School Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "Others Please Specify:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(343, 168);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 67);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Registration",
            "Tuition",
            "Books",
            "Others"});
            this.comboBox1.Location = new System.Drawing.Point(344, 125);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(264, 32);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(343, 243);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(265, 32);
            this.txtAmount.TabIndex = 5;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(238, 237);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(89, 32);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.Text = "Amount:";
            // 
            // lblFeeDescription
            // 
            this.lblFeeDescription.AutoSize = true;
            this.lblFeeDescription.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeeDescription.Location = new System.Drawing.Point(167, 127);
            this.lblFeeDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeeDescription.Name = "lblFeeDescription";
            this.lblFeeDescription.Size = new System.Drawing.Size(158, 32);
            this.lblFeeDescription.TabIndex = 10;
            this.lblFeeDescription.Text = "Fee Description:";
            // 
            // cmbGradeLevel
            // 
            this.cmbGradeLevel.BackColor = System.Drawing.Color.White;
            this.cmbGradeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradeLevel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGradeLevel.FormattingEnabled = true;
            this.cmbGradeLevel.ItemHeight = 24;
            this.cmbGradeLevel.Items.AddRange(new object[] {
            "",
            "Toddler",
            "Nursery",
            "Kindergarten",
            "Preparatory",
            "Grade 1",
            "Grade 2",
            "Grade 3",
            "Grade 4",
            "Grade 5",
            "Grade 6",
            "Grade 7",
            "Grade 8",
            "Grade 9",
            "Grade 10",
            "Grade 11",
            "Grade 10"});
            this.cmbGradeLevel.Location = new System.Drawing.Point(343, 82);
            this.cmbGradeLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGradeLevel.Name = "cmbGradeLevel";
            this.cmbGradeLevel.Size = new System.Drawing.Size(265, 32);
            this.cmbGradeLevel.TabIndex = 2;
            // 
            // lblGradeLevel
            // 
            this.lblGradeLevel.AutoSize = true;
            this.lblGradeLevel.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeLevel.Location = new System.Drawing.Point(198, 86);
            this.lblGradeLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGradeLevel.Name = "lblGradeLevel";
            this.lblGradeLevel.Size = new System.Drawing.Size(127, 32);
            this.lblGradeLevel.TabIndex = 5;
            this.lblGradeLevel.Text = "Grade Level:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblDate.Location = new System.Drawing.Point(613, 42);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 24);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // lblLoggedinas
            // 
            this.lblLoggedinas.AutoSize = true;
            this.lblLoggedinas.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedinas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblLoggedinas.Location = new System.Drawing.Point(-5, 42);
            this.lblLoggedinas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoggedinas.Name = "lblLoggedinas";
            this.lblLoggedinas.Size = new System.Drawing.Size(94, 24);
            this.lblLoggedinas.TabIndex = 8;
            this.lblLoggedinas.Text = "Logged in as:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblUser.Location = new System.Drawing.Point(87, 42);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(40, 24);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "User";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnCancel.Location = new System.Drawing.Point(614, 400);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 67);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(416, 400);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(190, 67);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblDate2.Location = new System.Drawing.Point(744, 42);
            this.lblDate2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(39, 24);
            this.lblDate2.TabIndex = 16;
            this.lblDate2.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblSilaSchoolManagementSoftware);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 38);
            this.panel1.TabIndex = 38;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MainSystem.Properties.Resources.starlogo2;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lblSilaSchoolManagementSoftware
            // 
            this.lblSilaSchoolManagementSoftware.AutoSize = true;
            this.lblSilaSchoolManagementSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSilaSchoolManagementSoftware.Font = new System.Drawing.Font("Bebas Neue", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSilaSchoolManagementSoftware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblSilaSchoolManagementSoftware.Location = new System.Drawing.Point(65, 6);
            this.lblSilaSchoolManagementSoftware.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSilaSchoolManagementSoftware.Name = "lblSilaSchoolManagementSoftware";
            this.lblSilaSchoolManagementSoftware.Size = new System.Drawing.Size(487, 28);
            this.lblSilaSchoolManagementSoftware.TabIndex = 0;
            this.lblSilaSchoolManagementSoftware.Text = "ACCOUNTING MANAGEMENT - S.I.L.A SCHOOL MANAGEMENT SOFTWARE";
            // 
            // frmAddFee
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(817, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDate2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLoggedinas);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.grpAddFee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmAddFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Fee";
            this.Load += new System.EventHandler(this.frmAddFee_Load);
            this.grpAddFee.ResumeLayout(false);
            this.grpAddFee.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddFee;
        private System.Windows.Forms.Label lblGradeLevel;
        public System.Windows.Forms.ComboBox cmbGradeLevel;
        private System.Windows.Forms.Label lblFeeDescription;
        public System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLoggedinas;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSilaSchoolManagementSoftware;
    }
}