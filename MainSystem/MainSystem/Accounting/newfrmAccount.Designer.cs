﻿namespace MainSystem.Accounting
{
    partial class newfrmAccount
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabStudentTransaction = new System.Windows.Forms.TabPage();
            this.grpFeeValue = new System.Windows.Forms.GroupBox();
            this.btnUpdateFee = new System.Windows.Forms.Button();
            this.dataFeeValue = new System.Windows.Forms.DataGridView();
            this.grpBalanceDetails = new System.Windows.Forms.GroupBox();
            this.btnViewPaymentHistory = new System.Windows.Forms.Button();
            this.dataBalanceDetails = new System.Windows.Forms.DataGridView();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddFee = new System.Windows.Forms.Button();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.dataSearch = new System.Windows.Forms.DataGridView();
            this.grpStudentDetails = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtReligion = new System.Windows.Forms.TextBox();
            this.txtPlaceOfBirth = new System.Windows.Forms.TextBox();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblPlaceOfBirth = new System.Windows.Forms.Label();
            this.lblReligion = new System.Windows.Forms.Label();
            this.lblNickname = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblLoggedinas = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabStudentTransaction.SuspendLayout();
            this.grpFeeValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFeeValue)).BeginInit();
            this.grpBalanceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBalanceDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).BeginInit();
            this.grpStudentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabStudentTransaction);
            this.tabControl.Location = new System.Drawing.Point(12, 29);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(931, 498);
            this.tabControl.TabIndex = 13;
            // 
            // tabStudentTransaction
            // 
            this.tabStudentTransaction.Controls.Add(this.grpFeeValue);
            this.tabStudentTransaction.Controls.Add(this.grpBalanceDetails);
            this.tabStudentTransaction.Controls.Add(this.btnEditAccount);
            this.tabStudentTransaction.Controls.Add(this.txtSearch);
            this.tabStudentTransaction.Controls.Add(this.btnAddFee);
            this.tabStudentTransaction.Controls.Add(this.btnAddTransaction);
            this.tabStudentTransaction.Controls.Add(this.dataSearch);
            this.tabStudentTransaction.Controls.Add(this.grpStudentDetails);
            this.tabStudentTransaction.Location = new System.Drawing.Point(4, 22);
            this.tabStudentTransaction.Name = "tabStudentTransaction";
            this.tabStudentTransaction.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentTransaction.Size = new System.Drawing.Size(923, 472);
            this.tabStudentTransaction.TabIndex = 0;
            this.tabStudentTransaction.Text = "Student Transaction";
            this.tabStudentTransaction.UseVisualStyleBackColor = true;
            // 
            // grpFeeValue
            // 
            this.grpFeeValue.Controls.Add(this.btnUpdateFee);
            this.grpFeeValue.Controls.Add(this.dataFeeValue);
            this.grpFeeValue.Location = new System.Drawing.Point(588, 206);
            this.grpFeeValue.Name = "grpFeeValue";
            this.grpFeeValue.Size = new System.Drawing.Size(322, 224);
            this.grpFeeValue.TabIndex = 12;
            this.grpFeeValue.TabStop = false;
            this.grpFeeValue.Text = "Fee";
            // 
            // btnUpdateFee
            // 
            this.btnUpdateFee.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateFee.Enabled = false;
            this.btnUpdateFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdateFee.Location = new System.Drawing.Point(7, 176);
            this.btnUpdateFee.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateFee.Name = "btnUpdateFee";
            this.btnUpdateFee.Size = new System.Drawing.Size(305, 41);
            this.btnUpdateFee.TabIndex = 6;
            this.btnUpdateFee.Text = "Update Fee";
            this.btnUpdateFee.UseVisualStyleBackColor = false;
            this.btnUpdateFee.Click += new System.EventHandler(this.btnUpdateFee_Click);
            // 
            // dataFeeValue
            // 
            this.dataFeeValue.AllowUserToAddRows = false;
            this.dataFeeValue.AllowUserToDeleteRows = false;
            this.dataFeeValue.AllowUserToResizeColumns = false;
            this.dataFeeValue.AllowUserToResizeRows = false;
            this.dataFeeValue.BackgroundColor = System.Drawing.Color.White;
            this.dataFeeValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFeeValue.Location = new System.Drawing.Point(7, 25);
            this.dataFeeValue.Name = "dataFeeValue";
            this.dataFeeValue.RowHeadersVisible = false;
            this.dataFeeValue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFeeValue.Size = new System.Drawing.Size(305, 145);
            this.dataFeeValue.TabIndex = 1;
            this.dataFeeValue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFeeValue_CellClick);
            // 
            // grpBalanceDetails
            // 
            this.grpBalanceDetails.Controls.Add(this.btnViewPaymentHistory);
            this.grpBalanceDetails.Controls.Add(this.dataBalanceDetails);
            this.grpBalanceDetails.Location = new System.Drawing.Point(588, 28);
            this.grpBalanceDetails.Name = "grpBalanceDetails";
            this.grpBalanceDetails.Size = new System.Drawing.Size(322, 172);
            this.grpBalanceDetails.TabIndex = 11;
            this.grpBalanceDetails.TabStop = false;
            this.grpBalanceDetails.Text = "Balance Details";
            // 
            // btnViewPaymentHistory
            // 
            this.btnViewPaymentHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnViewPaymentHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnViewPaymentHistory.Location = new System.Drawing.Point(7, 125);
            this.btnViewPaymentHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewPaymentHistory.Name = "btnViewPaymentHistory";
            this.btnViewPaymentHistory.Size = new System.Drawing.Size(305, 41);
            this.btnViewPaymentHistory.TabIndex = 5;
            this.btnViewPaymentHistory.Text = "View Payment History";
            this.btnViewPaymentHistory.UseVisualStyleBackColor = false;
            this.btnViewPaymentHistory.Click += new System.EventHandler(this.btnViewPaymentHistory_Click);
            // 
            // dataBalanceDetails
            // 
            this.dataBalanceDetails.AllowUserToAddRows = false;
            this.dataBalanceDetails.AllowUserToDeleteRows = false;
            this.dataBalanceDetails.AllowUserToResizeColumns = false;
            this.dataBalanceDetails.AllowUserToResizeRows = false;
            this.dataBalanceDetails.BackgroundColor = System.Drawing.Color.White;
            this.dataBalanceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBalanceDetails.Location = new System.Drawing.Point(7, 25);
            this.dataBalanceDetails.Name = "dataBalanceDetails";
            this.dataBalanceDetails.RowHeadersVisible = false;
            this.dataBalanceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataBalanceDetails.Size = new System.Drawing.Size(305, 94);
            this.dataBalanceDetails.TabIndex = 0;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Enabled = false;
            this.btnEditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAccount.Location = new System.Drawing.Point(140, 436);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(164, 28);
            this.btnEditAccount.TabIndex = 3;
            this.btnEditAccount.Text = "Statement of Account";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(9, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddFee
            // 
            this.btnAddFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFee.Location = new System.Drawing.Point(310, 436);
            this.btnAddFee.Name = "btnAddFee";
            this.btnAddFee.Size = new System.Drawing.Size(125, 28);
            this.btnAddFee.TabIndex = 4;
            this.btnAddFee.Text = "Add Fee";
            this.btnAddFee.UseVisualStyleBackColor = true;
            this.btnAddFee.Click += new System.EventHandler(this.btnAddFee_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Enabled = false;
            this.btnAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTransaction.Location = new System.Drawing.Point(9, 436);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(125, 28);
            this.btnAddTransaction.TabIndex = 2;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // dataSearch
            // 
            this.dataSearch.AllowUserToAddRows = false;
            this.dataSearch.AllowUserToDeleteRows = false;
            this.dataSearch.AllowUserToResizeColumns = false;
            this.dataSearch.AllowUserToResizeRows = false;
            this.dataSearch.BackgroundColor = System.Drawing.Color.White;
            this.dataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearch.Location = new System.Drawing.Point(9, 53);
            this.dataSearch.Name = "dataSearch";
            this.dataSearch.RowHeadersVisible = false;
            this.dataSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSearch.Size = new System.Drawing.Size(573, 147);
            this.dataSearch.TabIndex = 5;
            this.dataSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSearch_CellClick);
            // 
            // grpStudentDetails
            // 
            this.grpStudentDetails.Controls.Add(this.txtLastName);
            this.grpStudentDetails.Controls.Add(this.txtMiddleName);
            this.grpStudentDetails.Controls.Add(this.lblLastName);
            this.grpStudentDetails.Controls.Add(this.lblMiddleName);
            this.grpStudentDetails.Controls.Add(this.txtDateOfBirth);
            this.grpStudentDetails.Controls.Add(this.txtReligion);
            this.grpStudentDetails.Controls.Add(this.txtPlaceOfBirth);
            this.grpStudentDetails.Controls.Add(this.txtNickName);
            this.grpStudentDetails.Controls.Add(this.txtSex);
            this.grpStudentDetails.Controls.Add(this.lblDateOfBirth);
            this.grpStudentDetails.Controls.Add(this.lblPlaceOfBirth);
            this.grpStudentDetails.Controls.Add(this.lblReligion);
            this.grpStudentDetails.Controls.Add(this.lblNickname);
            this.grpStudentDetails.Controls.Add(this.lblSex);
            this.grpStudentDetails.Controls.Add(this.txtFirstName);
            this.grpStudentDetails.Controls.Add(this.lblFirstName);
            this.grpStudentDetails.Controls.Add(this.txtStudentID);
            this.grpStudentDetails.Controls.Add(this.lblStudentID);
            this.grpStudentDetails.Location = new System.Drawing.Point(9, 206);
            this.grpStudentDetails.Name = "grpStudentDetails";
            this.grpStudentDetails.Size = new System.Drawing.Size(573, 224);
            this.grpStudentDetails.TabIndex = 4;
            this.grpStudentDetails.TabStop = false;
            this.grpStudentDetails.Text = "Student Details";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Location = new System.Drawing.Point(115, 133);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(180, 20);
            this.txtLastName.TabIndex = 22;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.Color.White;
            this.txtMiddleName.Location = new System.Drawing.Point(115, 97);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.ReadOnly = true;
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
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.BackColor = System.Drawing.Color.White;
            this.txtDateOfBirth.Location = new System.Drawing.Point(385, 26);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.ReadOnly = true;
            this.txtDateOfBirth.Size = new System.Drawing.Size(180, 20);
            this.txtDateOfBirth.TabIndex = 18;
            // 
            // txtReligion
            // 
            this.txtReligion.BackColor = System.Drawing.Color.White;
            this.txtReligion.Location = new System.Drawing.Point(385, 99);
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.ReadOnly = true;
            this.txtReligion.Size = new System.Drawing.Size(180, 20);
            this.txtReligion.TabIndex = 17;
            // 
            // txtPlaceOfBirth
            // 
            this.txtPlaceOfBirth.BackColor = System.Drawing.Color.White;
            this.txtPlaceOfBirth.Location = new System.Drawing.Point(385, 62);
            this.txtPlaceOfBirth.Name = "txtPlaceOfBirth";
            this.txtPlaceOfBirth.ReadOnly = true;
            this.txtPlaceOfBirth.Size = new System.Drawing.Size(180, 20);
            this.txtPlaceOfBirth.TabIndex = 16;
            // 
            // txtNickName
            // 
            this.txtNickName.BackColor = System.Drawing.Color.White;
            this.txtNickName.Location = new System.Drawing.Point(385, 136);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.ReadOnly = true;
            this.txtNickName.Size = new System.Drawing.Size(180, 20);
            this.txtNickName.TabIndex = 15;
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.White;
            this.txtSex.Location = new System.Drawing.Point(115, 171);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(180, 20);
            this.txtSex.TabIndex = 14;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(301, 30);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(80, 16);
            this.lblDateOfBirth.TabIndex = 13;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblPlaceOfBirth
            // 
            this.lblPlaceOfBirth.AutoSize = true;
            this.lblPlaceOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceOfBirth.Location = new System.Drawing.Point(301, 66);
            this.lblPlaceOfBirth.Name = "lblPlaceOfBirth";
            this.lblPlaceOfBirth.Size = new System.Drawing.Size(86, 16);
            this.lblPlaceOfBirth.TabIndex = 11;
            this.lblPlaceOfBirth.Text = "Place of Birth";
            // 
            // lblReligion
            // 
            this.lblReligion.AutoSize = true;
            this.lblReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReligion.Location = new System.Drawing.Point(301, 100);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.Size = new System.Drawing.Size(58, 16);
            this.lblReligion.TabIndex = 9;
            this.lblReligion.Text = "Religion";
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickname.Location = new System.Drawing.Point(301, 137);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(69, 16);
            this.lblNickname.TabIndex = 6;
            this.lblNickname.Text = "Nickname";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(16, 175);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(31, 16);
            this.lblSex.TabIndex = 5;
            this.lblSex.Text = "Sex";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Location = new System.Drawing.Point(115, 62);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
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
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.White;
            this.txtStudentID.Location = new System.Drawing.Point(115, 26);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(180, 20);
            this.txtStudentID.TabIndex = 3;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(16, 30);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(21, 16);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "ID";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(843, 8);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(100, 37);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblLoggedinas
            // 
            this.lblLoggedinas.AutoSize = true;
            this.lblLoggedinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLoggedinas.Location = new System.Drawing.Point(9, 9);
            this.lblLoggedinas.Name = "lblLoggedinas";
            this.lblLoggedinas.Size = new System.Drawing.Size(98, 17);
            this.lblLoggedinas.TabIndex = 0;
            this.lblLoggedinas.Text = "Logged in as: ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUser.Location = new System.Drawing.Point(104, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "USER";
            // 
            // newfrmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(955, 553);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLoggedinas);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.tabControl);
            this.Name = "newfrmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounting Management";
            this.Load += new System.EventHandler(this.newfrmAccount_Load);
            this.tabControl.ResumeLayout(false);
            this.tabStudentTransaction.ResumeLayout(false);
            this.tabStudentTransaction.PerformLayout();
            this.grpFeeValue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFeeValue)).EndInit();
            this.grpBalanceDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBalanceDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).EndInit();
            this.grpStudentDetails.ResumeLayout(false);
            this.grpStudentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabStudentTransaction;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddFee;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.DataGridView dataSearch;
        private System.Windows.Forms.GroupBox grpStudentDetails;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMiddleName;
        public System.Windows.Forms.TextBox txtDateOfBirth;
        public System.Windows.Forms.TextBox txtReligion;
        public System.Windows.Forms.TextBox txtPlaceOfBirth;
        public System.Windows.Forms.TextBox txtNickName;
        public System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblPlaceOfBirth;
        private System.Windows.Forms.Label lblReligion;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Label lblSex;
        public System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        public System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblLoggedinas;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.GroupBox grpFeeValue;
        private System.Windows.Forms.Button btnUpdateFee;
        public System.Windows.Forms.DataGridView dataFeeValue;
        private System.Windows.Forms.GroupBox grpBalanceDetails;
        private System.Windows.Forms.Button btnViewPaymentHistory;
        private System.Windows.Forms.DataGridView dataBalanceDetails;
    }
}