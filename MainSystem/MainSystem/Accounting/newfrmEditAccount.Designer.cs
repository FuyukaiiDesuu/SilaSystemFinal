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
            this.txtDateDue = new System.Windows.Forms.TextBox();
            this.lblPaymentStatus2 = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.txtCurrentBalance = new System.Windows.Forms.TextBox();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblDateDue = new System.Windows.Forms.Label();
            this.txtStudentAccountID = new System.Windows.Forms.TextBox();
            this.lblStudentAccountID = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpStudentDetails = new System.Windows.Forms.GroupBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLoggedinas = new System.Windows.Forms.Label();
            this.grpStudentAccount.SuspendLayout();
            this.grpStudentDetails.SuspendLayout();
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
            this.grpStudentAccount.Controls.Add(this.txtDateDue);
            this.grpStudentAccount.Controls.Add(this.lblPaymentStatus2);
            this.grpStudentAccount.Controls.Add(this.lblPaymentStatus);
            this.grpStudentAccount.Controls.Add(this.txtPaidAmount);
            this.grpStudentAccount.Controls.Add(this.lblPaidAmount);
            this.grpStudentAccount.Controls.Add(this.txtCurrentBalance);
            this.grpStudentAccount.Controls.Add(this.lblCurrentBalance);
            this.grpStudentAccount.Controls.Add(this.txtTotalAmount);
            this.grpStudentAccount.Controls.Add(this.lblTotalAmount);
            this.grpStudentAccount.Controls.Add(this.lblDateDue);
            this.grpStudentAccount.Controls.Add(this.txtStudentAccountID);
            this.grpStudentAccount.Controls.Add(this.lblStudentAccountID);
            this.grpStudentAccount.Location = new System.Drawing.Point(12, 107);
            this.grpStudentAccount.Name = "grpStudentAccount";
            this.grpStudentAccount.Size = new System.Drawing.Size(597, 149);
            this.grpStudentAccount.TabIndex = 26;
            this.grpStudentAccount.TabStop = false;
            this.grpStudentAccount.Text = "Student Account";
            // 
            // txtDateDue
            // 
            this.txtDateDue.BackColor = System.Drawing.Color.White;
            this.txtDateDue.Location = new System.Drawing.Point(400, 29);
            this.txtDateDue.Name = "txtDateDue";
            this.txtDateDue.ReadOnly = true;
            this.txtDateDue.Size = new System.Drawing.Size(179, 20);
            this.txtDateDue.TabIndex = 19;
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
            this.lblDateDue.Location = new System.Drawing.Point(291, 30);
            this.lblDateDue.Name = "lblDateDue";
            this.lblDateDue.Size = new System.Drawing.Size(65, 16);
            this.lblDateDue.TabIndex = 9;
            this.lblDateDue.Text = "Date Due";
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
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(12, 262);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(91, 31);
            this.btnPrint.TabIndex = 25;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
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
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(109, 262);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 31);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
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
            // newfrmEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 304);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLoggedinas);
            this.Controls.Add(this.lblDate2);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.grpStudentAccount);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grpStudentDetails);
            this.Controls.Add(this.btnClose);
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
        public System.Windows.Forms.TextBox txtStudentAccountID;
        private System.Windows.Forms.Label lblStudentAccountID;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox grpStudentDetails;
        public System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentName;
        public System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLoggedinas;
        private System.Windows.Forms.Label lblPaymentStatus2;
        public System.Windows.Forms.TextBox txtDateDue;
    }
}