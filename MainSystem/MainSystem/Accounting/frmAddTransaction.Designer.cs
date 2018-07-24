namespace MainSystem
{
    partial class frmAddTransaction
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
            this.grpNewPayment = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtPaymentNo = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.cmbPaymentTo = new System.Windows.Forms.ComboBox();
            this.datePaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentTo = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblChequeNo = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.grpPaymentHistory = new System.Windows.Forms.GroupBox();
            this.dataPaymentHistory = new System.Windows.Forms.DataGridView();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.dataEmployeeDetails = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblAddtionalDetails = new System.Windows.Forms.Label();
            this.txtAdditionalDetails = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.grpNewPayment.SuspendLayout();
            this.grpPaymentHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaymentHistory)).BeginInit();
            this.grpEmployeeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployeeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNewPayment
            // 
            this.grpNewPayment.Controls.Add(this.txtEmployeeID);
            this.grpNewPayment.Controls.Add(this.lblEmployeeID);
            this.grpNewPayment.Controls.Add(this.txtAdditionalDetails);
            this.grpNewPayment.Controls.Add(this.lblAddtionalDetails);
            this.grpNewPayment.Controls.Add(this.txtAmount);
            this.grpNewPayment.Controls.Add(this.lblAmount);
            this.grpNewPayment.Controls.Add(this.txtPaymentNo);
            this.grpNewPayment.Controls.Add(this.txtStudentName);
            this.grpNewPayment.Controls.Add(this.txtStudentID);
            this.grpNewPayment.Controls.Add(this.lblStudentID);
            this.grpNewPayment.Controls.Add(this.txtChequeNo);
            this.grpNewPayment.Controls.Add(this.cmbPaymentType);
            this.grpNewPayment.Controls.Add(this.cmbPaymentTo);
            this.grpNewPayment.Controls.Add(this.datePaymentDate);
            this.grpNewPayment.Controls.Add(this.lblPaymentTo);
            this.grpNewPayment.Controls.Add(this.lblPaymentDate);
            this.grpNewPayment.Controls.Add(this.lblChequeNo);
            this.grpNewPayment.Controls.Add(this.lblPaymentType);
            this.grpNewPayment.Controls.Add(this.lblStudentName);
            this.grpNewPayment.Controls.Add(this.lblPayment);
            this.grpNewPayment.Location = new System.Drawing.Point(13, 30);
            this.grpNewPayment.Name = "grpNewPayment";
            this.grpNewPayment.Size = new System.Drawing.Size(346, 603);
            this.grpNewPayment.TabIndex = 0;
            this.grpNewPayment.TabStop = false;
            this.grpNewPayment.Text = " New Payment";
            this.grpNewPayment.Enter += new System.EventHandler(this.grpNewPayment_Enter);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(121, 571);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(6, 571);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(53, 16);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.Text = "Amount";
            // 
            // txtPaymentNo
            // 
            this.txtPaymentNo.Location = new System.Drawing.Point(121, 33);
            this.txtPaymentNo.Name = "txtPaymentNo";
            this.txtPaymentNo.ReadOnly = true;
            this.txtPaymentNo.Size = new System.Drawing.Size(200, 20);
            this.txtPaymentNo.TabIndex = 13;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(121, 73);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(200, 20);
            this.txtStudentName.TabIndex = 12;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(121, 116);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(200, 20);
            this.txtStudentID.TabIndex = 11;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(6, 117);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(69, 16);
            this.lblStudentID.TabIndex = 10;
            this.lblStudentID.Text = "Student ID";
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.Location = new System.Drawing.Point(121, 241);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(200, 20);
            this.txtChequeNo.TabIndex = 2;
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.ItemHeight = 13;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "",
            "CHEQUE",
            "CASH"});
            this.cmbPaymentType.Location = new System.Drawing.Point(121, 199);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(200, 21);
            this.cmbPaymentType.TabIndex = 8;
            this.cmbPaymentType.TextChanged += new System.EventHandler(this.cmbPaymentType_TextChanged);
            // 
            // cmbPaymentTo
            // 
            this.cmbPaymentTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentTo.FormattingEnabled = true;
            this.cmbPaymentTo.Items.AddRange(new object[] {
            "",
            "REGISTRATION",
            "TUITION",
            "BOOKS",
            "OTHERS"});
            this.cmbPaymentTo.Location = new System.Drawing.Point(121, 282);
            this.cmbPaymentTo.Name = "cmbPaymentTo";
            this.cmbPaymentTo.Size = new System.Drawing.Size(200, 21);
            this.cmbPaymentTo.TabIndex = 3;
            // 
            // datePaymentDate
            // 
            this.datePaymentDate.CustomFormat = "yyyy/MM/dd";
            this.datePaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePaymentDate.Location = new System.Drawing.Point(121, 322);
            this.datePaymentDate.Name = "datePaymentDate";
            this.datePaymentDate.Size = new System.Drawing.Size(200, 20);
            this.datePaymentDate.TabIndex = 4;
            // 
            // lblPaymentTo
            // 
            this.lblPaymentTo.AutoSize = true;
            this.lblPaymentTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentTo.Location = new System.Drawing.Point(6, 282);
            this.lblPaymentTo.Name = "lblPaymentTo";
            this.lblPaymentTo.Size = new System.Drawing.Size(81, 16);
            this.lblPaymentTo.TabIndex = 5;
            this.lblPaymentTo.Text = "Payment To";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(6, 322);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(93, 16);
            this.lblPaymentDate.TabIndex = 4;
            this.lblPaymentDate.Text = "Payment Date";
            // 
            // lblChequeNo
            // 
            this.lblChequeNo.AutoSize = true;
            this.lblChequeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChequeNo.Location = new System.Drawing.Point(6, 241);
            this.lblChequeNo.Name = "lblChequeNo";
            this.lblChequeNo.Size = new System.Drawing.Size(79, 16);
            this.lblChequeNo.TabIndex = 3;
            this.lblChequeNo.Text = "Cheque No.";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(6, 199);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(96, 16);
            this.lblPaymentType.TabIndex = 2;
            this.lblPaymentType.Text = "Payment Type";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(6, 74);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(93, 16);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(6, 34);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(85, 16);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "Payment No.";
            // 
            // grpPaymentHistory
            // 
            this.grpPaymentHistory.Controls.Add(this.dataPaymentHistory);
            this.grpPaymentHistory.Location = new System.Drawing.Point(365, 334);
            this.grpPaymentHistory.Name = "grpPaymentHistory";
            this.grpPaymentHistory.Size = new System.Drawing.Size(423, 299);
            this.grpPaymentHistory.TabIndex = 1;
            this.grpPaymentHistory.TabStop = false;
            this.grpPaymentHistory.Text = "Payment History";
            // 
            // dataPaymentHistory
            // 
            this.dataPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPaymentHistory.Location = new System.Drawing.Point(7, 19);
            this.dataPaymentHistory.Name = "dataPaymentHistory";
            this.dataPaymentHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPaymentHistory.Size = new System.Drawing.Size(410, 274);
            this.dataPaymentHistory.TabIndex = 0;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(13, 639);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(91, 31);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(110, 639);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(207, 639);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(91, 31);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // grpEmployeeDetails
            // 
            this.grpEmployeeDetails.Controls.Add(this.dataEmployeeDetails);
            this.grpEmployeeDetails.Location = new System.Drawing.Point(365, 30);
            this.grpEmployeeDetails.Name = "grpEmployeeDetails";
            this.grpEmployeeDetails.Size = new System.Drawing.Size(423, 303);
            this.grpEmployeeDetails.TabIndex = 5;
            this.grpEmployeeDetails.TabStop = false;
            this.grpEmployeeDetails.Text = "Employee Details";
            // 
            // dataEmployeeDetails
            // 
            this.dataEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmployeeDetails.Location = new System.Drawing.Point(7, 19);
            this.dataEmployeeDetails.Name = "dataEmployeeDetails";
            this.dataEmployeeDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEmployeeDetails.Size = new System.Drawing.Size(410, 278);
            this.dataEmployeeDetails.TabIndex = 0;
            this.dataEmployeeDetails.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataEmployeeDetails_MouseClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(637, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(151, 20);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblAddtionalDetails
            // 
            this.lblAddtionalDetails.AutoSize = true;
            this.lblAddtionalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddtionalDetails.Location = new System.Drawing.Point(6, 359);
            this.lblAddtionalDetails.Name = "lblAddtionalDetails";
            this.lblAddtionalDetails.Size = new System.Drawing.Size(113, 16);
            this.lblAddtionalDetails.TabIndex = 15;
            this.lblAddtionalDetails.Text = "Additional Details";
            // 
            // txtAdditionalDetails
            // 
            this.txtAdditionalDetails.Location = new System.Drawing.Point(121, 359);
            this.txtAdditionalDetails.Multiline = true;
            this.txtAdditionalDetails.Name = "txtAdditionalDetails";
            this.txtAdditionalDetails.Size = new System.Drawing.Size(200, 196);
            this.txtAdditionalDetails.TabIndex = 16;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(6, 159);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(86, 16);
            this.lblEmployeeID.TabIndex = 17;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(121, 159);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.ReadOnly = true;
            this.txtEmployeeID.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeID.TabIndex = 18;
            // 
            // frmAddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 683);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.grpEmployeeDetails);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.grpPaymentHistory);
            this.Controls.Add(this.grpNewPayment);
            this.Name = "frmAddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Transaction";
            this.Load += new System.EventHandler(this.frmAddTransaction_Load);
            this.grpNewPayment.ResumeLayout(false);
            this.grpNewPayment.PerformLayout();
            this.grpPaymentHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPaymentHistory)).EndInit();
            this.grpEmployeeDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployeeDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewPayment;
        private System.Windows.Forms.Label lblPaymentTo;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblChequeNo;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.GroupBox grpPaymentHistory;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.DataGridView dataPaymentHistory;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.TextBox txtPaymentNo;
        public System.Windows.Forms.TextBox txtStudentName;
        public System.Windows.Forms.TextBox txtStudentID;
        public System.Windows.Forms.TextBox txtChequeNo;
        public System.Windows.Forms.ComboBox cmbPaymentType;
        public System.Windows.Forms.ComboBox cmbPaymentTo;
        public System.Windows.Forms.DateTimePicker datePaymentDate;
        public System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        public System.Windows.Forms.TextBox txtAdditionalDetails;
        private System.Windows.Forms.Label lblAddtionalDetails;
        private System.Windows.Forms.GroupBox grpEmployeeDetails;
        private System.Windows.Forms.DataGridView dataEmployeeDetails;
        private System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
    }
}