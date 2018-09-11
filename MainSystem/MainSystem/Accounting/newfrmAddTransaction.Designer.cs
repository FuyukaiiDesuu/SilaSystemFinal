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
            this.grpNewPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNewPayment
            // 
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
            this.grpNewPayment.Location = new System.Drawing.Point(12, 60);
            this.grpNewPayment.Name = "grpNewPayment";
            this.grpNewPayment.Size = new System.Drawing.Size(657, 306);
            this.grpNewPayment.TabIndex = 9;
            this.grpNewPayment.TabStop = false;
            this.grpNewPayment.Text = " New Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "School Year:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2018 - 2019",
            "2019 - 2020",
            "2020 - 2021",
            "2021 - 2022",
            "2022 - 2023"});
            this.comboBox2.Location = new System.Drawing.Point(445, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 23;
            // 
            // lblPaymentDate2
            // 
            this.lblPaymentDate2.AutoSize = true;
            this.lblPaymentDate2.Location = new System.Drawing.Point(462, 72);
            this.lblPaymentDate2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentDate2.Name = "lblPaymentDate2";
            this.lblPaymentDate2.Size = new System.Drawing.Size(35, 13);
            this.lblPaymentDate2.TabIndex = 17;
            this.lblPaymentDate2.Text = "label1";
            // 
            // txtAdditionalDetails
            // 
            this.txtAdditionalDetails.Location = new System.Drawing.Point(346, 134);
            this.txtAdditionalDetails.Multiline = true;
            this.txtAdditionalDetails.Name = "txtAdditionalDetails";
            this.txtAdditionalDetails.Size = new System.Drawing.Size(287, 156);
            this.txtAdditionalDetails.TabIndex = 4;
            this.txtAdditionalDetails.Text = "NONE";
            // 
            // lblAddtionalDetails
            // 
            this.lblAddtionalDetails.AutoSize = true;
            this.lblAddtionalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddtionalDetails.Location = new System.Drawing.Point(429, 105);
            this.lblAddtionalDetails.Name = "lblAddtionalDetails";
            this.lblAddtionalDetails.Size = new System.Drawing.Size(116, 16);
            this.lblAddtionalDetails.TabIndex = 15;
            this.lblAddtionalDetails.Text = "Additional Details:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(121, 246);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 44);
            this.txtAmount.TabIndex = 5;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(48, 246);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 16);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.Text = "Amount:";
            // 
            // txtTransactionNo
            // 
            this.txtTransactionNo.BackColor = System.Drawing.Color.White;
            this.txtTransactionNo.Location = new System.Drawing.Point(121, 33);
            this.txtTransactionNo.Name = "txtTransactionNo";
            this.txtTransactionNo.Size = new System.Drawing.Size(200, 20);
            this.txtTransactionNo.TabIndex = 13;
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.White;
            this.txtStudentName.Location = new System.Drawing.Point(120, 66);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(200, 20);
            this.txtStudentName.TabIndex = 12;
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.Location = new System.Drawing.Point(121, 143);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(50, 20);
            this.txtChequeNo.TabIndex = 2;
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.BackColor = System.Drawing.Color.White;
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.ItemHeight = 13;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Cheque"});
            this.cmbPaymentType.Location = new System.Drawing.Point(121, 116);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(200, 21);
            this.cmbPaymentType.TabIndex = 1;
            this.cmbPaymentType.TextChanged += new System.EventHandler(this.cmbPaymentType_TextChanged);
            // 
            // cmbPaymentTo
            // 
            this.cmbPaymentTo.BackColor = System.Drawing.Color.White;
            this.cmbPaymentTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentTo.FormattingEnabled = true;
            this.cmbPaymentTo.Items.AddRange(new object[] {
            "Tuition",
            "Books",
            "Registration",
            "Others"});
            this.cmbPaymentTo.Location = new System.Drawing.Point(121, 196);
            this.cmbPaymentTo.Name = "cmbPaymentTo";
            this.cmbPaymentTo.Size = new System.Drawing.Size(200, 21);
            this.cmbPaymentTo.TabIndex = 3;
            this.cmbPaymentTo.TextChanged += new System.EventHandler(this.cmbPaymentTo_TextChanged);
            // 
            // lblPaymentTo
            // 
            this.lblPaymentTo.AutoSize = true;
            this.lblPaymentTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentTo.Location = new System.Drawing.Point(20, 201);
            this.lblPaymentTo.Name = "lblPaymentTo";
            this.lblPaymentTo.Size = new System.Drawing.Size(84, 16);
            this.lblPaymentTo.TabIndex = 5;
            this.lblPaymentTo.Text = "Payment To:";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(361, 70);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(96, 16);
            this.lblPaymentDate.TabIndex = 4;
            this.lblPaymentDate.Text = "Payment Date:";
            // 
            // lblChequeNo
            // 
            this.lblChequeNo.AutoSize = true;
            this.lblChequeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChequeNo.Location = new System.Drawing.Point(25, 143);
            this.lblChequeNo.Name = "lblChequeNo";
            this.lblChequeNo.Size = new System.Drawing.Size(79, 16);
            this.lblChequeNo.TabIndex = 3;
            this.lblChequeNo.Text = "Cheque No:";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(10, 117);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(99, 16);
            this.lblPaymentType.TabIndex = 2;
            this.lblPaymentType.Text = "Payment Type:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(10, 67);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(96, 16);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Name:";
            // 
            // lblTransactionNo
            // 
            this.lblTransactionNo.AutoSize = true;
            this.lblTransactionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionNo.Location = new System.Drawing.Point(6, 34);
            this.lblTransactionNo.Name = "lblTransactionNo";
            this.lblTransactionNo.Size = new System.Drawing.Size(103, 16);
            this.lblTransactionNo.TabIndex = 0;
            this.lblTransactionNo.Text = "Transaction No:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(172, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 64);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(12, 372);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(154, 64);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Pay";
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
            this.lblLoggedinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLoggedinas.Location = new System.Drawing.Point(12, 23);
            this.lblLoggedinas.Name = "lblLoggedinas";
            this.lblLoggedinas.Size = new System.Drawing.Size(94, 17);
            this.lblLoggedinas.TabIndex = 15;
            this.lblLoggedinas.Text = "Logged in as:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUser.Location = new System.Drawing.Point(106, 23);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 17);
            this.lblUser.TabIndex = 16;
            this.lblUser.Text = "User";
            // 
            // newfrmAddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 448);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLoggedinas);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.grpNewPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "newfrmAddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Transaction";
            this.Load += new System.EventHandler(this.newfrmAddTransaction_Load);
            this.grpNewPayment.ResumeLayout(false);
            this.grpNewPayment.PerformLayout();
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
    }
}