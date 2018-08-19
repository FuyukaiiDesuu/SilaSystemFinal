namespace MainSystem.Accounting
{
    partial class newfrmEditAccount
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
            this.lblDate2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpStudentAccount = new System.Windows.Forms.GroupBox();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.txtCurrentBalance = new System.Windows.Forms.TextBox();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblDateDue = new System.Windows.Forms.Label();
            this.dateDateDue = new System.Windows.Forms.DateTimePicker();
            this.txtStudentAccountID = new System.Windows.Forms.TextBox();
            this.lblStudentAccountID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpStudentDetails = new System.Windows.Forms.GroupBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLoggedinas = new System.Windows.Forms.Label();
            this.grpDiscount = new System.Windows.Forms.GroupBox();
            this.txtDiscountDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDiscountPercentage = new System.Windows.Forms.TextBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.txtDiscountType = new System.Windows.Forms.TextBox();
            this.lblDiscountType = new System.Windows.Forms.Label();
            this.lblPaymentStatus2 = new System.Windows.Forms.Label();
            this.grpStudentAccount.SuspendLayout();
            this.grpStudentDetails.SuspendLayout();
            this.grpDiscount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate2.Location = new System.Drawing.Point(585, 9);
            this.lblDate2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(46, 17);
            this.lblDate2.TabIndex = 28;
            this.lblDate2.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate.Location = new System.Drawing.Point(448, 9);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 17);
            this.lblDate.TabIndex = 27;
            this.lblDate.Text = "label1";
            // 
            // grpStudentAccount
            // 
            this.grpStudentAccount.Controls.Add(this.lblPaymentStatus2);
            this.grpStudentAccount.Controls.Add(this.lblPaymentStatus);
            this.grpStudentAccount.Controls.Add(this.txtPaidAmount);
            this.grpStudentAccount.Controls.Add(this.lblPaidAmount);
            this.grpStudentAccount.Controls.Add(this.txtCurrentBalance);
            this.grpStudentAccount.Controls.Add(this.lblCurrentBalance);
            this.grpStudentAccount.Controls.Add(this.txtTotalAmount);
            this.grpStudentAccount.Controls.Add(this.lblTotalAmount);
            this.grpStudentAccount.Controls.Add(this.lblDateDue);
            this.grpStudentAccount.Controls.Add(this.dateDateDue);
            this.grpStudentAccount.Controls.Add(this.txtStudentAccountID);
            this.grpStudentAccount.Controls.Add(this.lblStudentAccountID);
            this.grpStudentAccount.Location = new System.Drawing.Point(12, 107);
            this.grpStudentAccount.Name = "grpStudentAccount";
            this.grpStudentAccount.Size = new System.Drawing.Size(597, 149);
            this.grpStudentAccount.TabIndex = 26;
            this.grpStudentAccount.TabStop = false;
            this.grpStudentAccount.Text = "Student Account";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatus.Location = new System.Drawing.Point(291, 114);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(101, 16);
            this.lblPaymentStatus.TabIndex = 16;
            this.lblPaymentStatus.Text = "Payment Status";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.BackColor = System.Drawing.Color.White;
            this.txtPaidAmount.Location = new System.Drawing.Point(132, 114);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.ReadOnly = true;
            this.txtPaidAmount.Size = new System.Drawing.Size(153, 20);
            this.txtPaidAmount.TabIndex = 15;
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidAmount.Location = new System.Drawing.Point(8, 114);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(84, 16);
            this.lblPaidAmount.TabIndex = 14;
            this.lblPaidAmount.Text = "Paid Amount";
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.BackColor = System.Drawing.Color.White;
            this.txtCurrentBalance.Location = new System.Drawing.Point(400, 72);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.ReadOnly = true;
            this.txtCurrentBalance.Size = new System.Drawing.Size(179, 20);
            this.txtCurrentBalance.TabIndex = 13;
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalance.Location = new System.Drawing.Point(291, 72);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(103, 16);
            this.lblCurrentBalance.TabIndex = 12;
            this.lblCurrentBalance.Text = "Current Balance";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.White;
            this.txtTotalAmount.Location = new System.Drawing.Point(132, 72);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(153, 20);
            this.txtTotalAmount.TabIndex = 11;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(8, 72);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(87, 16);
            this.lblTotalAmount.TabIndex = 10;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // lblDateDue
            // 
            this.lblDateDue.AutoSize = true;
            this.lblDateDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDue.Location = new System.Drawing.Point(291, 34);
            this.lblDateDue.Name = "lblDateDue";
            this.lblDateDue.Size = new System.Drawing.Size(65, 16);
            this.lblDateDue.TabIndex = 9;
            this.lblDateDue.Text = "Date Due";
            // 
            // dateDateDue
            // 
            this.dateDateDue.CustomFormat = "yyyy/MM/dd";
            this.dateDateDue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDateDue.Location = new System.Drawing.Point(400, 34);
            this.dateDateDue.Name = "dateDateDue";
            this.dateDateDue.Size = new System.Drawing.Size(179, 20);
            this.dateDateDue.TabIndex = 8;
            // 
            // txtStudentAccountID
            // 
            this.txtStudentAccountID.BackColor = System.Drawing.Color.White;
            this.txtStudentAccountID.Location = new System.Drawing.Point(132, 30);
            this.txtStudentAccountID.Name = "txtStudentAccountID";
            this.txtStudentAccountID.ReadOnly = true;
            this.txtStudentAccountID.Size = new System.Drawing.Size(153, 20);
            this.txtStudentAccountID.TabIndex = 7;
            // 
            // lblStudentAccountID
            // 
            this.lblStudentAccountID.AutoSize = true;
            this.lblStudentAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentAccountID.Location = new System.Drawing.Point(6, 30);
            this.lblStudentAccountID.Name = "lblStudentAccountID";
            this.lblStudentAccountID.Size = new System.Drawing.Size(120, 16);
            this.lblStudentAccountID.TabIndex = 6;
            this.lblStudentAccountID.Text = "Student Account ID";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 368);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 31);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // grpStudentDetails
            // 
            this.grpStudentDetails.Controls.Add(this.txtStudentName);
            this.grpStudentDetails.Controls.Add(this.lblStudentName);
            this.grpStudentDetails.Controls.Add(this.txtStudentID);
            this.grpStudentDetails.Controls.Add(this.lblStudentID);
            this.grpStudentDetails.Location = new System.Drawing.Point(12, 29);
            this.grpStudentDetails.Name = "grpStudentDetails";
            this.grpStudentDetails.Size = new System.Drawing.Size(597, 72);
            this.grpStudentDetails.TabIndex = 24;
            this.grpStudentDetails.TabStop = false;
            this.grpStudentDetails.Text = "Student Details";
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.White;
            this.txtStudentName.Location = new System.Drawing.Point(400, 33);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(179, 20);
            this.txtStudentName.TabIndex = 7;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(291, 34);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(45, 16);
            this.lblStudentName.TabIndex = 6;
            this.lblStudentName.Text = "Name";
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.White;
            this.txtStudentID.Location = new System.Drawing.Point(132, 34);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(153, 20);
            this.txtStudentID.TabIndex = 5;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(8, 33);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(21, 16);
            this.lblStudentID.TabIndex = 4;
            this.lblStudentID.Text = "ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(109, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 31);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUser.Location = new System.Drawing.Point(100, 9);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 17);
            this.lblUser.TabIndex = 30;
            this.lblUser.Text = "User";
            // 
            // lblLoggedinas
            // 
            this.lblLoggedinas.AutoSize = true;
            this.lblLoggedinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLoggedinas.Location = new System.Drawing.Point(9, 9);
            this.lblLoggedinas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoggedinas.Name = "lblLoggedinas";
            this.lblLoggedinas.Size = new System.Drawing.Size(94, 17);
            this.lblLoggedinas.TabIndex = 29;
            this.lblLoggedinas.Text = "Logged in as:";
            // 
            // grpDiscount
            // 
            this.grpDiscount.Controls.Add(this.txtDiscountDescription);
            this.grpDiscount.Controls.Add(this.lblDescription);
            this.grpDiscount.Controls.Add(this.txtDiscountPercentage);
            this.grpDiscount.Controls.Add(this.lblPercentage);
            this.grpDiscount.Controls.Add(this.txtDiscountType);
            this.grpDiscount.Controls.Add(this.lblDiscountType);
            this.grpDiscount.Location = new System.Drawing.Point(12, 262);
            this.grpDiscount.Name = "grpDiscount";
            this.grpDiscount.Size = new System.Drawing.Size(597, 100);
            this.grpDiscount.TabIndex = 31;
            this.grpDiscount.TabStop = false;
            this.grpDiscount.Text = "Discount ";
            // 
            // txtDiscountDescription
            // 
            this.txtDiscountDescription.BackColor = System.Drawing.Color.White;
            this.txtDiscountDescription.Location = new System.Drawing.Point(132, 61);
            this.txtDiscountDescription.Name = "txtDiscountDescription";
            this.txtDiscountDescription.ReadOnly = true;
            this.txtDiscountDescription.Size = new System.Drawing.Size(153, 20);
            this.txtDiscountDescription.TabIndex = 13;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(6, 61);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 16);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description";
            // 
            // txtDiscountPercentage
            // 
            this.txtDiscountPercentage.BackColor = System.Drawing.Color.White;
            this.txtDiscountPercentage.Location = new System.Drawing.Point(400, 21);
            this.txtDiscountPercentage.Name = "txtDiscountPercentage";
            this.txtDiscountPercentage.ReadOnly = true;
            this.txtDiscountPercentage.Size = new System.Drawing.Size(179, 20);
            this.txtDiscountPercentage.TabIndex = 11;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(291, 22);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(78, 16);
            this.lblPercentage.TabIndex = 10;
            this.lblPercentage.Text = "Percentage";
            // 
            // txtDiscountType
            // 
            this.txtDiscountType.BackColor = System.Drawing.Color.White;
            this.txtDiscountType.Location = new System.Drawing.Point(132, 21);
            this.txtDiscountType.Name = "txtDiscountType";
            this.txtDiscountType.ReadOnly = true;
            this.txtDiscountType.Size = new System.Drawing.Size(153, 20);
            this.txtDiscountType.TabIndex = 9;
            // 
            // lblDiscountType
            // 
            this.lblDiscountType.AutoSize = true;
            this.lblDiscountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountType.Location = new System.Drawing.Point(6, 25);
            this.lblDiscountType.Name = "lblDiscountType";
            this.lblDiscountType.Size = new System.Drawing.Size(95, 16);
            this.lblDiscountType.TabIndex = 8;
            this.lblDiscountType.Text = "Discount Type";
            // 
            // lblPaymentStatus2
            // 
            this.lblPaymentStatus2.AutoSize = true;
            this.lblPaymentStatus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatus2.Location = new System.Drawing.Point(397, 114);
            this.lblPaymentStatus2.Name = "lblPaymentStatus2";
            this.lblPaymentStatus2.Size = new System.Drawing.Size(114, 16);
            this.lblPaymentStatus2.TabIndex = 18;
            this.lblPaymentStatus2.Text = "PARTIALLY PAID";
            // 
            // newfrmEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 407);
            this.Controls.Add(this.grpDiscount);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLoggedinas);
            this.Controls.Add(this.lblDate2);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.grpStudentAccount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpStudentDetails);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "newfrmEditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statement of Account";
            this.Load += new System.EventHandler(this.newfrmEditAccount_Load);
            this.grpStudentAccount.ResumeLayout(false);
            this.grpStudentAccount.PerformLayout();
            this.grpStudentDetails.ResumeLayout(false);
            this.grpStudentDetails.PerformLayout();
            this.grpDiscount.ResumeLayout(false);
            this.grpDiscount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpStudentAccount;
        private System.Windows.Forms.Label lblPaymentStatus;
        public System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label lblPaidAmount;
        public System.Windows.Forms.TextBox txtCurrentBalance;
        private System.Windows.Forms.Label lblCurrentBalance;
        public System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblDateDue;
        private System.Windows.Forms.DateTimePicker dateDateDue;
        public System.Windows.Forms.TextBox txtStudentAccountID;
        private System.Windows.Forms.Label lblStudentAccountID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpStudentDetails;
        public System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentName;
        public System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLoggedinas;
        private System.Windows.Forms.GroupBox grpDiscount;
        public System.Windows.Forms.TextBox txtDiscountDescription;
        private System.Windows.Forms.Label lblDescription;
        public System.Windows.Forms.TextBox txtDiscountPercentage;
        private System.Windows.Forms.Label lblPercentage;
        public System.Windows.Forms.TextBox txtDiscountType;
        private System.Windows.Forms.Label lblDiscountType;
        private System.Windows.Forms.Label lblPaymentStatus2;
    }
}