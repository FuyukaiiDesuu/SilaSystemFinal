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
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblChequeNo = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblPaymentTo = new System.Windows.Forms.Label();
            this.grpPaymentHistory = new System.Windows.Forms.GroupBox();
            this.dataPaymentHistory = new System.Windows.Forms.DataGridView();
            this.datePaymentDate = new System.Windows.Forms.DateTimePicker();
            this.cmbPaymentTo = new System.Windows.Forms.ComboBox();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtPaymentNo = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpNewPayment.SuspendLayout();
            this.grpPaymentHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaymentHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNewPayment
            // 
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
            this.grpNewPayment.Size = new System.Drawing.Size(346, 333);
            this.grpNewPayment.TabIndex = 0;
            this.grpNewPayment.TabStop = false;
            this.grpNewPayment.Text = " New Payment";
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
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(6, 157);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(96, 16);
            this.lblPaymentType.TabIndex = 2;
            this.lblPaymentType.Text = "Payment Type";
            // 
            // lblChequeNo
            // 
            this.lblChequeNo.AutoSize = true;
            this.lblChequeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChequeNo.Location = new System.Drawing.Point(6, 198);
            this.lblChequeNo.Name = "lblChequeNo";
            this.lblChequeNo.Size = new System.Drawing.Size(79, 16);
            this.lblChequeNo.TabIndex = 3;
            this.lblChequeNo.Text = "Cheque No.";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(6, 277);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(93, 16);
            this.lblPaymentDate.TabIndex = 4;
            this.lblPaymentDate.Text = "Payment Date";
            // 
            // lblPaymentTo
            // 
            this.lblPaymentTo.AutoSize = true;
            this.lblPaymentTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentTo.Location = new System.Drawing.Point(6, 238);
            this.lblPaymentTo.Name = "lblPaymentTo";
            this.lblPaymentTo.Size = new System.Drawing.Size(81, 16);
            this.lblPaymentTo.TabIndex = 5;
            this.lblPaymentTo.Text = "Payment To";
            // 
            // grpPaymentHistory
            // 
            this.grpPaymentHistory.Controls.Add(this.dataPaymentHistory);
            this.grpPaymentHistory.Location = new System.Drawing.Point(365, 30);
            this.grpPaymentHistory.Name = "grpPaymentHistory";
            this.grpPaymentHistory.Size = new System.Drawing.Size(423, 333);
            this.grpPaymentHistory.TabIndex = 1;
            this.grpPaymentHistory.TabStop = false;
            this.grpPaymentHistory.Text = "Payment History";
            // 
            // dataPaymentHistory
            // 
            this.dataPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPaymentHistory.Location = new System.Drawing.Point(7, 20);
            this.dataPaymentHistory.Name = "dataPaymentHistory";
            this.dataPaymentHistory.Size = new System.Drawing.Size(410, 307);
            this.dataPaymentHistory.TabIndex = 0;
            // 
            // datePaymentDate
            // 
            this.datePaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePaymentDate.Location = new System.Drawing.Point(121, 273);
            this.datePaymentDate.Name = "datePaymentDate";
            this.datePaymentDate.Size = new System.Drawing.Size(200, 20);
            this.datePaymentDate.TabIndex = 6;
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
            this.cmbPaymentTo.Location = new System.Drawing.Point(121, 237);
            this.cmbPaymentTo.Name = "cmbPaymentTo";
            this.cmbPaymentTo.Size = new System.Drawing.Size(200, 21);
            this.cmbPaymentTo.TabIndex = 7;
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "",
            "BANK",
            "CASH"});
            this.cmbPaymentType.Location = new System.Drawing.Point(121, 156);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(200, 21);
            this.cmbPaymentType.TabIndex = 8;
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.Location = new System.Drawing.Point(121, 197);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(200, 20);
            this.txtChequeNo.TabIndex = 9;
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
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(121, 116);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(200, 20);
            this.txtStudentID.TabIndex = 11;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(121, 73);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(200, 20);
            this.txtStudentName.TabIndex = 12;
            // 
            // txtPaymentNo
            // 
            this.txtPaymentNo.Location = new System.Drawing.Point(121, 33);
            this.txtPaymentNo.Name = "txtPaymentNo";
            this.txtPaymentNo.Size = new System.Drawing.Size(200, 20);
            this.txtPaymentNo.TabIndex = 13;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(13, 369);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(91, 31);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(110, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(207, 369);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(91, 31);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // frmAddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.grpPaymentHistory);
            this.Controls.Add(this.grpNewPayment);
            this.Name = "frmAddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Transaction";
            this.grpNewPayment.ResumeLayout(false);
            this.grpNewPayment.PerformLayout();
            this.grpPaymentHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPaymentHistory)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtPaymentNo;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtChequeNo;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.ComboBox cmbPaymentTo;
        private System.Windows.Forms.DateTimePicker datePaymentDate;
        private System.Windows.Forms.DataGridView dataPaymentHistory;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
    }
}