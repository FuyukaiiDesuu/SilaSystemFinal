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
            this.txtSearch.Location = new System.Drawing.Point(9, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(246, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
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
            this.grpStudentDetails.Location = new System.Drawing.Point(9, 206);
            this.grpStudentDetails.Name = "grpStudentDetails";
            this.grpStudentDetails.Size = new System.Drawing.Size(573, 224);
            this.grpStudentDetails.TabIndex = 4;
            this.grpStudentDetails.TabStop = false;
            this.grpStudentDetails.Text = "Student Details";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(115, 133);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 20);
            this.txtLastName.TabIndex = 22;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(115, 97);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(180, 20);
            this.txtMiddleName.TabIndex = 21;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(16, 137);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 16);
            this.lblLastName.TabIndex = 20;
            this.lblLastName.Text = "Last Name";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(16, 101);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(89, 16);
            this.lblMiddleName.TabIndex = 19;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(385, 26);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(180, 20);
            this.txtSection.TabIndex = 18;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(385, 99);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(180, 20);
            this.txtDepartment.TabIndex = 17;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(385, 62);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(180, 20);
            this.txtLevel.TabIndex = 16;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(385, 136);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(180, 20);
            this.txtStatus.TabIndex = 15;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(115, 171);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(180, 20);
            this.txtGender.TabIndex = 14;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(301, 30);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(53, 16);
            this.lblSection.TabIndex = 13;
            this.lblSection.Text = "Section";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(301, 66);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(41, 16);
            this.lblLevel.TabIndex = 11;
            this.lblLevel.Text = "Level";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(301, 100);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(78, 16);
            this.lblDepartment.TabIndex = 9;
            this.lblDepartment.Text = "Department";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(301, 137);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 16);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(16, 175);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(53, 16);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(115, 62);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(16, 66);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 16);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(115, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(180, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(16, 30);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // dataSearch
            // 
            this.dataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearch.Location = new System.Drawing.Point(9, 53);
            this.dataSearch.Name = "dataSearch";
            this.dataSearch.Size = new System.Drawing.Size(573, 147);
            this.dataSearch.TabIndex = 5;
            // 
            // grpBalanceDetails
            // 
            this.grpBalanceDetails.Controls.Add(this.dataBalanceDetails);
            this.grpBalanceDetails.Location = new System.Drawing.Point(588, 28);
            this.grpBalanceDetails.Name = "grpBalanceDetails";
            this.grpBalanceDetails.Size = new System.Drawing.Size(526, 179);
            this.grpBalanceDetails.TabIndex = 6;
            this.grpBalanceDetails.TabStop = false;
            this.grpBalanceDetails.Text = "Balance Details";
            // 
            // dataBalanceDetails
            // 
            this.dataBalanceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBalanceDetails.Location = new System.Drawing.Point(7, 26);
            this.dataBalanceDetails.Name = "dataBalanceDetails";
            this.dataBalanceDetails.Size = new System.Drawing.Size(513, 147);
            this.dataBalanceDetails.TabIndex = 0;
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTransaction.Location = new System.Drawing.Point(9, 436);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(125, 28);
            this.btnAddTransaction.TabIndex = 7;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(140, 436);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 28);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // grpPaymentHistory
            // 
            this.grpPaymentHistory.Controls.Add(this.dataPaymentHistory);
            this.grpPaymentHistory.Location = new System.Drawing.Point(588, 206);
            this.grpPaymentHistory.Name = "grpPaymentHistory";
            this.grpPaymentHistory.Size = new System.Drawing.Size(526, 224);
            this.grpPaymentHistory.TabIndex = 9;
            this.grpPaymentHistory.TabStop = false;
            this.grpPaymentHistory.Text = "Payment History";
            // 
            // dataPaymentHistory
            // 
            this.dataPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPaymentHistory.Location = new System.Drawing.Point(7, 19);
            this.dataPaymentHistory.Name = "dataPaymentHistory";
            this.dataPaymentHistory.Size = new System.Drawing.Size(513, 193);
            this.dataPaymentHistory.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabStudentTransaction);
            this.tabControl.Controls.Add(this.tabBankTransaction);
            this.tabControl.Controls.Add(this.tabDisbursement);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1159, 498);
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
            this.tabStudentTransaction.Location = new System.Drawing.Point(4, 22);
            this.tabStudentTransaction.Name = "tabStudentTransaction";
            this.tabStudentTransaction.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentTransaction.Size = new System.Drawing.Size(1151, 472);
            this.tabStudentTransaction.TabIndex = 0;
            this.tabStudentTransaction.Text = "Student Transaction";
            this.tabStudentTransaction.UseVisualStyleBackColor = true;
            // 
            // tabBankTransaction
            // 
            this.tabBankTransaction.Location = new System.Drawing.Point(4, 22);
            this.tabBankTransaction.Name = "tabBankTransaction";
            this.tabBankTransaction.Padding = new System.Windows.Forms.Padding(3);
            this.tabBankTransaction.Size = new System.Drawing.Size(1151, 472);
            this.tabBankTransaction.TabIndex = 1;
            this.tabBankTransaction.Text = "Bank Transaction";
            this.tabBankTransaction.UseVisualStyleBackColor = true;
            // 
            // tabDisbursement
            // 
            this.tabDisbursement.Location = new System.Drawing.Point(4, 22);
            this.tabDisbursement.Name = "tabDisbursement";
            this.tabDisbursement.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisbursement.Size = new System.Drawing.Size(1151, 472);
            this.tabDisbursement.TabIndex = 2;
            this.tabDisbursement.Text = "Disbursement";
            this.tabDisbursement.UseVisualStyleBackColor = true;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 521);
            this.Controls.Add(this.tabControl);
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounting Management";
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
    }
}