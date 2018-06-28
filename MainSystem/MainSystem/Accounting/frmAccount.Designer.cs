namespace MainSystem
{
    partial class frmAccount
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpStudentDetails = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.dataSearch = new System.Windows.Forms.DataGridView();
            this.grpBalanceDetails = new System.Windows.Forms.GroupBox();
            this.dataBalanceDetails = new System.Windows.Forms.DataGridView();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grpPaymentHistory = new System.Windows.Forms.GroupBox();
            this.dataPaymentHistory = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabStudentTransaction = new System.Windows.Forms.TabPage();
            this.tabBankTransaction = new System.Windows.Forms.TabPage();
            this.tabDisbursement = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.grpStudentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).BeginInit();
            this.grpBalanceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBalanceDetails)).BeginInit();
            this.grpPaymentHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaymentHistory)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabStudentTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 34);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(307, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(328, 33);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 25);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // grpStudentDetails
            // 
            this.grpStudentDetails.Controls.Add(this.txtLastName);
            this.grpStudentDetails.Controls.Add(this.txtMiddleName);
            this.grpStudentDetails.Controls.Add(this.lblLastName);
            this.grpStudentDetails.Controls.Add(this.lblMiddleName);
            this.grpStudentDetails.Controls.Add(this.txtSection);
            this.grpStudentDetails.Controls.Add(this.txtDepartment);
            this.grpStudentDetails.Controls.Add(this.txtLevel);
            this.grpStudentDetails.Controls.Add(this.txtStatus);
            this.grpStudentDetails.Controls.Add(this.txtGender);
            this.grpStudentDetails.Controls.Add(this.lblSection);
            this.grpStudentDetails.Controls.Add(this.lblLevel);
            this.grpStudentDetails.Controls.Add(this.lblDepartment);
            this.grpStudentDetails.Controls.Add(this.lblStatus);
            this.grpStudentDetails.Controls.Add(this.lblGender);
            this.grpStudentDetails.Controls.Add(this.txtFirstName);
            this.grpStudentDetails.Controls.Add(this.lblFirstName);
            this.grpStudentDetails.Controls.Add(this.txtID);
            this.grpStudentDetails.Controls.Add(this.lblID);
            this.grpStudentDetails.Location = new System.Drawing.Point(12, 254);
            this.grpStudentDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpStudentDetails.Name = "grpStudentDetails";
            this.grpStudentDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpStudentDetails.Size = new System.Drawing.Size(764, 276);
            this.grpStudentDetails.TabIndex = 4;
            this.grpStudentDetails.TabStop = false;
            this.grpStudentDetails.Text = "Student Details";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(153, 164);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(239, 22);
            this.txtLastName.TabIndex = 22;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(153, 119);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(239, 22);
            this.txtMiddleName.TabIndex = 21;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(21, 169);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(91, 20);
            this.lblLastName.TabIndex = 20;
            this.lblLastName.Text = "Last Name";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(21, 124);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(107, 20);
            this.lblMiddleName.TabIndex = 19;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(513, 32);
            this.txtSection.Margin = new System.Windows.Forms.Padding(4);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(239, 22);
            this.txtSection.TabIndex = 18;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(513, 122);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(239, 22);
            this.txtDepartment.TabIndex = 17;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(513, 76);
            this.txtLevel.Margin = new System.Windows.Forms.Padding(4);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(239, 22);
            this.txtLevel.TabIndex = 16;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(513, 167);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(239, 22);
            this.txtStatus.TabIndex = 15;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(153, 210);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(239, 22);
            this.txtGender.TabIndex = 14;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(401, 37);
            this.lblSection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(65, 20);
            this.lblSection.TabIndex = 13;
            this.lblSection.Text = "Section";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(401, 81);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(49, 20);
            this.lblLevel.TabIndex = 11;
            this.lblLevel.Text = "Level";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(401, 123);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(97, 20);
            this.lblDepartment.TabIndex = 9;
            this.lblDepartment.Text = "Department";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(401, 169);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 20);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(21, 215);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(64, 20);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(153, 76);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(239, 22);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(21, 81);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(92, 20);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(153, 32);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(239, 22);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(21, 37);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // dataSearch
            // 
            this.dataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearch.Location = new System.Drawing.Point(12, 65);
            this.dataSearch.Margin = new System.Windows.Forms.Padding(4);
            this.dataSearch.Name = "dataSearch";
            this.dataSearch.Size = new System.Drawing.Size(764, 181);
            this.dataSearch.TabIndex = 5;
            // 
            // grpBalanceDetails
            // 
            this.grpBalanceDetails.Controls.Add(this.dataBalanceDetails);
            this.grpBalanceDetails.Location = new System.Drawing.Point(784, 34);
            this.grpBalanceDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpBalanceDetails.Name = "grpBalanceDetails";
            this.grpBalanceDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpBalanceDetails.Size = new System.Drawing.Size(701, 220);
            this.grpBalanceDetails.TabIndex = 6;
            this.grpBalanceDetails.TabStop = false;
            this.grpBalanceDetails.Text = "Balance Details";
            // 
            // dataBalanceDetails
            // 
            this.dataBalanceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBalanceDetails.Location = new System.Drawing.Point(9, 32);
            this.dataBalanceDetails.Margin = new System.Windows.Forms.Padding(4);
            this.dataBalanceDetails.Name = "dataBalanceDetails";
            this.dataBalanceDetails.Size = new System.Drawing.Size(684, 181);
            this.dataBalanceDetails.TabIndex = 0;
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTransaction.Location = new System.Drawing.Point(12, 537);
            this.btnAddTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(167, 34);
            this.btnAddTransaction.TabIndex = 7;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(187, 537);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(167, 34);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // grpPaymentHistory
            // 
            this.grpPaymentHistory.Controls.Add(this.dataPaymentHistory);
            this.grpPaymentHistory.Location = new System.Drawing.Point(784, 254);
            this.grpPaymentHistory.Margin = new System.Windows.Forms.Padding(4);
            this.grpPaymentHistory.Name = "grpPaymentHistory";
            this.grpPaymentHistory.Padding = new System.Windows.Forms.Padding(4);
            this.grpPaymentHistory.Size = new System.Drawing.Size(701, 276);
            this.grpPaymentHistory.TabIndex = 9;
            this.grpPaymentHistory.TabStop = false;
            this.grpPaymentHistory.Text = "Payment History";
            // 
            // dataPaymentHistory
            // 
            this.dataPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPaymentHistory.Location = new System.Drawing.Point(9, 23);
            this.dataPaymentHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dataPaymentHistory.Name = "dataPaymentHistory";
            this.dataPaymentHistory.Size = new System.Drawing.Size(684, 238);
            this.dataPaymentHistory.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabStudentTransaction);
            this.tabControl.Controls.Add(this.tabBankTransaction);
            this.tabControl.Controls.Add(this.tabDisbursement);
            this.tabControl.Location = new System.Drawing.Point(23, 59);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1545, 613);
            this.tabControl.TabIndex = 10;
            // 
            // tabStudentTransaction
            // 
            this.tabStudentTransaction.Controls.Add(this.txtSearch);
            this.tabStudentTransaction.Controls.Add(this.btnEdit);
            this.tabStudentTransaction.Controls.Add(this.grpPaymentHistory);
            this.tabStudentTransaction.Controls.Add(this.btnAddTransaction);
            this.tabStudentTransaction.Controls.Add(this.btnSearch);
            this.tabStudentTransaction.Controls.Add(this.dataSearch);
            this.tabStudentTransaction.Controls.Add(this.grpStudentDetails);
            this.tabStudentTransaction.Controls.Add(this.grpBalanceDetails);
            this.tabStudentTransaction.Location = new System.Drawing.Point(4, 25);
            this.tabStudentTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.tabStudentTransaction.Name = "tabStudentTransaction";
            this.tabStudentTransaction.Padding = new System.Windows.Forms.Padding(4);
            this.tabStudentTransaction.Size = new System.Drawing.Size(1537, 584);
            this.tabStudentTransaction.TabIndex = 0;
            this.tabStudentTransaction.Text = "Student Transaction";
            this.tabStudentTransaction.UseVisualStyleBackColor = true;
            // 
            // tabBankTransaction
            // 
            this.tabBankTransaction.Location = new System.Drawing.Point(4, 25);
            this.tabBankTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.tabBankTransaction.Name = "tabBankTransaction";
            this.tabBankTransaction.Padding = new System.Windows.Forms.Padding(4);
            this.tabBankTransaction.Size = new System.Drawing.Size(1537, 584);
            this.tabBankTransaction.TabIndex = 1;
            this.tabBankTransaction.Text = "Bank Transaction";
            this.tabBankTransaction.UseVisualStyleBackColor = true;
            // 
            // tabDisbursement
            // 
            this.tabDisbursement.Location = new System.Drawing.Point(4, 25);
            this.tabDisbursement.Margin = new System.Windows.Forms.Padding(4);
            this.tabDisbursement.Name = "tabDisbursement";
            this.tabDisbursement.Padding = new System.Windows.Forms.Padding(4);
            this.tabDisbursement.Size = new System.Drawing.Size(1537, 584);
            this.tabDisbursement.TabIndex = 2;
            this.tabDisbursement.Text = "Disbursement";
            this.tabDisbursement.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1431, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "DASHBOARD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 687);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounting Management";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            this.grpStudentDetails.ResumeLayout(false);
            this.grpStudentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).EndInit();
            this.grpBalanceDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBalanceDetails)).EndInit();
            this.grpPaymentHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPaymentHistory)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabStudentTransaction.ResumeLayout(false);
            this.tabStudentTransaction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpStudentDetails;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dataSearch;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.GroupBox grpBalanceDetails;
        private System.Windows.Forms.DataGridView dataBalanceDetails;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox grpPaymentHistory;
        private System.Windows.Forms.DataGridView dataPaymentHistory;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabStudentTransaction;
        private System.Windows.Forms.TabPage tabBankTransaction;
        private System.Windows.Forms.TabPage tabDisbursement;
        private System.Windows.Forms.Button button1;
    }
}