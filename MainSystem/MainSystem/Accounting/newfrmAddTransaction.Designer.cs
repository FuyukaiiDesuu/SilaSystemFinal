namespace MainSystem.Accounting
{
    partial class newfrmAddTransaction
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
            this.grpNewPayment = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttendered = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblPaymentDate2 = new System.Windows.Forms.Label();
            this.txtAdditionalDetails = new System.Windows.Forms.TextBox();
            this.lblAddtionalDetails = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtTransactionNo = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.cmbPaymentTo = new System.Windows.Forms.ComboBox();
            this.lblPaymentTo = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblChequeNo = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblTransactionNo = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLoggedinas = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSilaSchoolManagementSoftware = new System.Windows.Forms.Label();
            this.grpNewPayment.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNewPayment
            // 
            this.grpNewPayment.Controls.Add(this.label2);
            this.grpNewPayment.Controls.Add(this.txttendered);
            this.grpNewPayment.Controls.Add(this.label1);
            this.grpNewPayment.Controls.Add(this.comboBox2);
            this.grpNewPayment.Controls.Add(this.lblPaymentDate2);
            this.grpNewPayment.Controls.Add(this.txtAdditionalDetails);
            this.grpNewPayment.Controls.Add(this.lblAddtionalDetails);
            this.grpNewPayment.Controls.Add(this.txtAmount);
            this.grpNewPayment.Controls.Add(this.lblAmount);
            this.grpNewPayment.Controls.Add(this.txtTransactionNo);
            this.grpNewPayment.Controls.Add(this.txtStudentName);
            this.grpNewPayment.Controls.Add(this.txtChequeNo);
            this.grpNewPayment.Controls.Add(this.cmbPaymentType);
            this.grpNewPayment.Controls.Add(this.cmbPaymentTo);
            this.grpNewPayment.Controls.Add(this.lblPaymentTo);
            this.grpNewPayment.Controls.Add(this.lblPaymentDate);
            this.grpNewPayment.Controls.Add(this.lblChequeNo);
            this.grpNewPayment.Controls.Add(this.lblPaymentType);
            this.grpNewPayment.Controls.Add(this.lblStudentName);
            this.grpNewPayment.Controls.Add(this.lblTransactionNo);
            this.grpNewPayment.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.grpNewPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.grpNewPayment.Location = new System.Drawing.Point(12, 74);
            this.grpNewPayment.Name = "grpNewPayment";
            this.grpNewPayment.Size = new System.Drawing.Size(740, 375);
            this.grpNewPayment.TabIndex = 9;
            this.grpNewPayment.TabStop = false;
            this.grpNewPayment.Text = " New Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(103, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "ENTER TENDERED AMOUNT:";
            // 
            // txttendered
            // 
            this.txttendered.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.txttendered.Location = new System.Drawing.Point(114, 311);
            this.txttendered.Name = "txttendered";
            this.txttendered.Size = new System.Drawing.Size(200, 47);
            this.txttendered.TabIndex = 25;
            this.txttendered.TextChanged += new System.EventHandler(this.txttendered_TextChanged);
            this.txttendered.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttendered_KeyPress);
            this.txttendered.Leave += new System.EventHandler(this.txttendered_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(429, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "School Year:";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2018 - 2019",
            "2019 - 2020",
            "2020 - 2021",
            "2021 - 2022",
            "2022 - 2023"});
            this.comboBox2.Location = new System.Drawing.Point(574, 34);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 27);
            this.comboBox2.TabIndex = 7;
            // 
            // lblPaymentDate2
            // 
            this.lblPaymentDate2.AutoSize = true;
            this.lblPaymentDate2.Location = new System.Drawing.Point(570, 72);
            this.lblPaymentDate2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentDate2.Name = "lblPaymentDate2";
            this.lblPaymentDate2.Size = new System.Drawing.Size(57, 21);
            this.lblPaymentDate2.TabIndex = 17;
            this.lblPaymentDate2.Text = "label1";
            // 
            // txtAdditionalDetails
            // 
            this.txtAdditionalDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtAdditionalDetails.Location = new System.Drawing.Point(433, 138);
            this.txtAdditionalDetails.Multiline = true;
            this.txtAdditionalDetails.Name = "txtAdditionalDetails";
            this.txtAdditionalDetails.Size = new System.Drawing.Size(287, 107);
            this.txtAdditionalDetails.TabIndex = 8;
            this.txtAdditionalDetails.Text = "NONE";
            // 
            // lblAddtionalDetails
            // 
            this.lblAddtionalDetails.AutoSize = true;
            this.lblAddtionalDetails.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblAddtionalDetails.Location = new System.Drawing.Point(429, 105);
            this.lblAddtionalDetails.Name = "lblAddtionalDetails";
            this.lblAddtionalDetails.Size = new System.Drawing.Size(152, 21);
            this.lblAddtionalDetails.TabIndex = 15;
            this.lblAddtionalDetails.Text = "Additional Details:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.txtAmount.Location = new System.Drawing.Point(114, 227);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 47);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblAmount.Location = new System.Drawing.Point(123, 203);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(175, 21);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.Text = "ENTER AMOUNT DUE:";
            // 
            // txtTransactionNo
            // 
            this.txtTransactionNo.BackColor = System.Drawing.Color.White;
            this.txtTransactionNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtTransactionNo.Location = new System.Drawing.Point(172, 34);
            this.txtTransactionNo.Name = "txtTransactionNo";
            this.txtTransactionNo.Size = new System.Drawing.Size(200, 27);
            this.txtTransactionNo.TabIndex = 1;
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.White;
            this.txtStudentName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtStudentName.Location = new System.Drawing.Point(172, 66);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(200, 27);
            this.txtStudentName.TabIndex = 2;
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtChequeNo.Location = new System.Drawing.Point(248, 132);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(50, 27);
            this.txtChequeNo.TabIndex = 4;
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.BackColor = System.Drawing.Color.White;
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.ItemHeight = 19;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Cheque"});
            this.cmbPaymentType.Location = new System.Drawing.Point(172, 99);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(200, 27);
            this.cmbPaymentType.TabIndex = 3;
            this.cmbPaymentType.TextChanged += new System.EventHandler(this.cmbPaymentType_TextChanged);
            // 
            // cmbPaymentTo
            // 
            this.cmbPaymentTo.BackColor = System.Drawing.Color.White;
            this.cmbPaymentTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentTo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.cmbPaymentTo.FormattingEnabled = true;
            this.cmbPaymentTo.Items.AddRange(new object[] {
            "Tuition",
            "Books",
            "Registration",
            "Others"});
            this.cmbPaymentTo.Location = new System.Drawing.Point(172, 165);
            this.cmbPaymentTo.Name = "cmbPaymentTo";
            this.cmbPaymentTo.Size = new System.Drawing.Size(200, 27);
            this.cmbPaymentTo.TabIndex = 5;
            this.cmbPaymentTo.TextChanged += new System.EventHandler(this.cmbPaymentTo_TextChanged);
            // 
            // lblPaymentTo
            // 
            this.lblPaymentTo.AutoSize = true;
            this.lblPaymentTo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblPaymentTo.Location = new System.Drawing.Point(42, 171);
            this.lblPaymentTo.Name = "lblPaymentTo";
            this.lblPaymentTo.Size = new System.Drawing.Size(106, 21);
            this.lblPaymentTo.TabIndex = 5;
            this.lblPaymentTo.Text = "Payment To:";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblPaymentDate.Location = new System.Drawing.Point(429, 72);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(128, 21);
            this.lblPaymentDate.TabIndex = 4;
            this.lblPaymentDate.Text = "Payment Date:";
            // 
            // lblChequeNo
            // 
            this.lblChequeNo.AutoSize = true;
            this.lblChequeNo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblChequeNo.Location = new System.Drawing.Point(44, 140);
            this.lblChequeNo.Name = "lblChequeNo";
            this.lblChequeNo.Size = new System.Drawing.Size(104, 21);
            this.lblChequeNo.TabIndex = 3;
            this.lblChequeNo.Text = "Cheque No:";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblPaymentType.Location = new System.Drawing.Point(23, 105);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(125, 21);
            this.lblPaymentType.TabIndex = 2;
            this.lblPaymentType.Text = "Payment Type:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblStudentName.Location = new System.Drawing.Point(23, 72);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(129, 21);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Name:";
            // 
            // lblTransactionNo
            // 
            this.lblTransactionNo.AutoSize = true;
            this.lblTransactionNo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblTransactionNo.Location = new System.Drawing.Point(23, 40);
            this.lblTransactionNo.Name = "lblTransactionNo";
            this.lblTransactionNo.Size = new System.Drawing.Size(131, 21);
            this.lblTransactionNo.TabIndex = 0;
            this.lblTransactionNo.Text = "Transaction No:";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnCancel.Location = new System.Drawing.Point(586, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 39);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPay
            // 
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnPay.Location = new System.Drawing.Point(423, 455);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(157, 39);
            this.btnPay.TabIndex = 9;
            this.btnPay.Text = "PROCEED TO PAY";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLoggedinas
            // 
            this.lblLoggedinas.AutoSize = true;
            this.lblLoggedinas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblLoggedinas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblLoggedinas.Location = new System.Drawing.Point(-3, 34);
            this.lblLoggedinas.Name = "lblLoggedinas";
            this.lblLoggedinas.Size = new System.Drawing.Size(100, 19);
            this.lblLoggedinas.TabIndex = 15;
            this.lblLoggedinas.Text = "Logged in as:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblUser.Location = new System.Drawing.Point(97, 34);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(36, 19);
            this.lblUser.TabIndex = 16;
            this.lblUser.Text = "User";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblSilaSchoolManagementSoftware);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 31);
            this.panel1.TabIndex = 42;
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
            this.lblSilaSchoolManagementSoftware.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblSilaSchoolManagementSoftware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblSilaSchoolManagementSoftware.Location = new System.Drawing.Point(51, 9);
            this.lblSilaSchoolManagementSoftware.Name = "lblSilaSchoolManagementSoftware";
            this.lblSilaSchoolManagementSoftware.Size = new System.Drawing.Size(491, 19);
            this.lblSilaSchoolManagementSoftware.TabIndex = 0;
            this.lblSilaSchoolManagementSoftware.Text = "ACCOUNTING MANAGEMENT - S.I.L.A SCHOOL MANAGEMENT SOFTWARE";
            // 
            // newfrmAddTransaction
            // 
            this.AcceptButton = this.btnPay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(764, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLoggedinas);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.grpNewPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "newfrmAddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Transaction";
            this.Load += new System.EventHandler(this.newfrmAddTransaction_Load);
            this.grpNewPayment.ResumeLayout(false);
            this.grpNewPayment.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewPayment;
        private System.Windows.Forms.Label lblPaymentDate2;
        public System.Windows.Forms.TextBox txtAdditionalDetails;
        private System.Windows.Forms.Label lblAddtionalDetails;
        public System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        public System.Windows.Forms.TextBox txtTransactionNo;
        public System.Windows.Forms.TextBox txtStudentName;
        public System.Windows.Forms.TextBox txtChequeNo;
        public System.Windows.Forms.ComboBox cmbPaymentType;
        public System.Windows.Forms.ComboBox cmbPaymentTo;
        private System.Windows.Forms.Label lblPaymentTo;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblChequeNo;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblTransactionNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLoggedinas;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSilaSchoolManagementSoftware;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txttendered;
    }
}