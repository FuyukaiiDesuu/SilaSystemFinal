namespace MainSystem.Accounting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataSearch = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnViewPaymentHistory = new System.Windows.Forms.Button();
            this.grpBalanceDetails = new System.Windows.Forms.GroupBox();
            this.dataBalanceDetails = new System.Windows.Forms.DataGridView();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnAddTransaction = new System.Windows.Forms.Button();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataFeeValue = new System.Windows.Forms.DataGridView();
            this.btnAddFee = new System.Windows.Forms.Button();
            this.btnUpdateFee = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblLoggedinas = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabStudentTransaction.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).BeginInit();
            this.grpBalanceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBalanceDetails)).BeginInit();
            this.grpStudentDetails.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFeeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabStudentTransaction);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(16, 36);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1241, 630);
            this.tabControl.TabIndex = 13;
            // 
            // tabStudentTransaction
            // 
            this.tabStudentTransaction.Controls.Add(this.groupBox1);
            this.tabStudentTransaction.Controls.Add(this.btnViewPaymentHistory);
            this.tabStudentTransaction.Controls.Add(this.grpBalanceDetails);
            this.tabStudentTransaction.Controls.Add(this.btnEditAccount);
            this.tabStudentTransaction.Controls.Add(this.btnAddTransaction);
            this.tabStudentTransaction.Controls.Add(this.grpStudentDetails);
            this.tabStudentTransaction.Location = new System.Drawing.Point(4, 25);
            this.tabStudentTransaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabStudentTransaction.Name = "tabStudentTransaction";
            this.tabStudentTransaction.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabStudentTransaction.Size = new System.Drawing.Size(1233, 601);
            this.tabStudentTransaction.TabIndex = 0;
            this.tabStudentTransaction.Text = "Student Transaction";
            this.tabStudentTransaction.UseVisualStyleBackColor = true;
            this.tabStudentTransaction.Click += new System.EventHandler(this.tabStudentTransaction_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(764, 241);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account List";
            // 
            // dataSearch
            // 
            this.dataSearch.AllowUserToAddRows = false;
            this.dataSearch.AllowUserToDeleteRows = false;
            this.dataSearch.AllowUserToResizeColumns = false;
            this.dataSearch.AllowUserToResizeRows = false;
            this.dataSearch.BackgroundColor = System.Drawing.Color.White;
            this.dataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearch.Location = new System.Drawing.Point(11, 52);
            this.dataSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataSearch.Name = "dataSearch";
            this.dataSearch.RowHeadersVisible = false;
            this.dataSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSearch.Size = new System.Drawing.Size(743, 181);
            this.dataSearch.TabIndex = 5;
            this.dataSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSearch_CellClick);
            this.dataSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSearch_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(11, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(307, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnViewPaymentHistory
            // 
            this.btnViewPaymentHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnViewPaymentHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnViewPaymentHistory.Location = new System.Drawing.Point(412, 537);
            this.btnViewPaymentHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewPaymentHistory.Name = "btnViewPaymentHistory";
            this.btnViewPaymentHistory.Size = new System.Drawing.Size(213, 55);
            this.btnViewPaymentHistory.TabIndex = 5;
            this.btnViewPaymentHistory.Text = "View Payment History";
            this.btnViewPaymentHistory.UseVisualStyleBackColor = false;
            this.btnViewPaymentHistory.Click += new System.EventHandler(this.btnViewPaymentHistory_Click);
            // 
            // grpBalanceDetails
            // 
            this.grpBalanceDetails.Controls.Add(this.dataBalanceDetails);
            this.grpBalanceDetails.Location = new System.Drawing.Point(784, 7);
            this.grpBalanceDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBalanceDetails.Name = "grpBalanceDetails";
            this.grpBalanceDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBalanceDetails.Size = new System.Drawing.Size(429, 522);
            this.grpBalanceDetails.TabIndex = 11;
            this.grpBalanceDetails.TabStop = false;
            this.grpBalanceDetails.Text = "Balance Details";
            // 
            // dataBalanceDetails
            // 
            this.dataBalanceDetails.AllowUserToAddRows = false;
            this.dataBalanceDetails.AllowUserToDeleteRows = false;
            this.dataBalanceDetails.AllowUserToResizeColumns = false;
            this.dataBalanceDetails.AllowUserToResizeRows = false;
            this.dataBalanceDetails.BackgroundColor = System.Drawing.Color.White;
            this.dataBalanceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBalanceDetails.Location = new System.Drawing.Point(9, 23);
            this.dataBalanceDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataBalanceDetails.Name = "dataBalanceDetails";
            this.dataBalanceDetails.RowHeadersVisible = false;
            this.dataBalanceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataBalanceDetails.Size = new System.Drawing.Size(407, 491);
            this.dataBalanceDetails.TabIndex = 0;
            this.dataBalanceDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBalanceDetails_CellContentClick);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Enabled = false;
            this.btnEditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAccount.Location = new System.Drawing.Point(187, 537);
            this.btnEditAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(219, 55);
            this.btnEditAccount.TabIndex = 3;
            this.btnEditAccount.Text = "Statement of Account";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Enabled = false;
            this.btnAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTransaction.Location = new System.Drawing.Point(12, 537);
            this.btnAddTransaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(167, 55);
            this.btnAddTransaction.TabIndex = 2;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
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
            this.grpStudentDetails.Location = new System.Drawing.Point(12, 254);
            this.grpStudentDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpStudentDetails.Name = "grpStudentDetails";
            this.grpStudentDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpStudentDetails.Size = new System.Drawing.Size(764, 276);
            this.grpStudentDetails.TabIndex = 4;
            this.grpStudentDetails.TabStop = false;
            this.grpStudentDetails.Text = "Student Details";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Location = new System.Drawing.Point(153, 164);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(239, 22);
            this.txtLastName.TabIndex = 22;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.Color.White;
            this.txtMiddleName.Location = new System.Drawing.Point(153, 119);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.ReadOnly = true;
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
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.BackColor = System.Drawing.Color.White;
            this.txtDateOfBirth.Location = new System.Drawing.Point(513, 32);
            this.txtDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.ReadOnly = true;
            this.txtDateOfBirth.Size = new System.Drawing.Size(239, 22);
            this.txtDateOfBirth.TabIndex = 18;
            // 
            // txtReligion
            // 
            this.txtReligion.BackColor = System.Drawing.Color.White;
            this.txtReligion.Location = new System.Drawing.Point(513, 122);
            this.txtReligion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.ReadOnly = true;
            this.txtReligion.Size = new System.Drawing.Size(239, 22);
            this.txtReligion.TabIndex = 17;
            // 
            // txtPlaceOfBirth
            // 
            this.txtPlaceOfBirth.BackColor = System.Drawing.Color.White;
            this.txtPlaceOfBirth.Location = new System.Drawing.Point(513, 76);
            this.txtPlaceOfBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlaceOfBirth.Name = "txtPlaceOfBirth";
            this.txtPlaceOfBirth.ReadOnly = true;
            this.txtPlaceOfBirth.Size = new System.Drawing.Size(239, 22);
            this.txtPlaceOfBirth.TabIndex = 16;
            // 
            // txtNickName
            // 
            this.txtNickName.BackColor = System.Drawing.Color.White;
            this.txtNickName.Location = new System.Drawing.Point(513, 167);
            this.txtNickName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.ReadOnly = true;
            this.txtNickName.Size = new System.Drawing.Size(239, 22);
            this.txtNickName.TabIndex = 15;
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.White;
            this.txtSex.Location = new System.Drawing.Point(153, 210);
            this.txtSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(239, 22);
            this.txtSex.TabIndex = 14;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(401, 37);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(105, 20);
            this.lblDateOfBirth.TabIndex = 13;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblPlaceOfBirth
            // 
            this.lblPlaceOfBirth.AutoSize = true;
            this.lblPlaceOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceOfBirth.Location = new System.Drawing.Point(401, 81);
            this.lblPlaceOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaceOfBirth.Name = "lblPlaceOfBirth";
            this.lblPlaceOfBirth.Size = new System.Drawing.Size(111, 20);
            this.lblPlaceOfBirth.TabIndex = 11;
            this.lblPlaceOfBirth.Text = "Place of Birth";
            // 
            // lblReligion
            // 
            this.lblReligion.AutoSize = true;
            this.lblReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReligion.Location = new System.Drawing.Point(401, 123);
            this.lblReligion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.Size = new System.Drawing.Size(69, 20);
            this.lblReligion.TabIndex = 9;
            this.lblReligion.Text = "Religion";
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickname.Location = new System.Drawing.Point(401, 169);
            this.lblNickname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(83, 20);
            this.lblNickname.TabIndex = 6;
            this.lblNickname.Text = "Nickname";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(21, 215);
            this.lblSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(37, 20);
            this.lblSex.TabIndex = 5;
            this.lblSex.Text = "Sex";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Location = new System.Drawing.Point(153, 76);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
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
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.White;
            this.txtStudentID.Location = new System.Drawing.Point(153, 32);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(239, 22);
            this.txtStudentID.TabIndex = 3;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(21, 37);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(26, 20);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "ID";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataFeeValue);
            this.tabPage1.Controls.Add(this.btnAddFee);
            this.tabPage1.Controls.Add(this.btnUpdateFee);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1233, 601);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Fee Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataFeeValue
            // 
            this.dataFeeValue.AllowUserToAddRows = false;
            this.dataFeeValue.AllowUserToDeleteRows = false;
            this.dataFeeValue.AllowUserToResizeColumns = false;
            this.dataFeeValue.AllowUserToResizeRows = false;
            this.dataFeeValue.BackgroundColor = System.Drawing.Color.White;
            this.dataFeeValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFeeValue.Location = new System.Drawing.Point(8, 7);
            this.dataFeeValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataFeeValue.Name = "dataFeeValue";
            this.dataFeeValue.RowHeadersVisible = false;
            this.dataFeeValue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFeeValue.Size = new System.Drawing.Size(1215, 524);
            this.dataFeeValue.TabIndex = 7;
            this.dataFeeValue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFeeValue_CellClick);
            this.dataFeeValue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFeeValue_CellContentClick);
            // 
            // btnAddFee
            // 
            this.btnAddFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFee.Location = new System.Drawing.Point(8, 539);
            this.btnAddFee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddFee.Name = "btnAddFee";
            this.btnAddFee.Size = new System.Drawing.Size(167, 34);
            this.btnAddFee.TabIndex = 5;
            this.btnAddFee.Text = "Add Fee";
            this.btnAddFee.UseVisualStyleBackColor = true;
            this.btnAddFee.Click += new System.EventHandler(this.btnAddFee_Click);
            // 
            // btnUpdateFee
            // 
            this.btnUpdateFee.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateFee.Enabled = false;
            this.btnUpdateFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdateFee.Location = new System.Drawing.Point(181, 539);
            this.btnUpdateFee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateFee.Name = "btnUpdateFee";
            this.btnUpdateFee.Size = new System.Drawing.Size(167, 34);
            this.btnUpdateFee.TabIndex = 6;
            this.btnUpdateFee.Text = "Update Fee";
            this.btnUpdateFee.UseVisualStyleBackColor = false;
            this.btnUpdateFee.Click += new System.EventHandler(this.btnUpdateFee_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(1124, 10);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(133, 46);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblLoggedinas
            // 
            this.lblLoggedinas.AutoSize = true;
            this.lblLoggedinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLoggedinas.Location = new System.Drawing.Point(12, 11);
            this.lblLoggedinas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoggedinas.Name = "lblLoggedinas";
            this.lblLoggedinas.Size = new System.Drawing.Size(115, 20);
            this.lblLoggedinas.TabIndex = 0;
            this.lblLoggedinas.Text = "Logged in as: ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUser.Location = new System.Drawing.Point(139, 11);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(55, 20);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "USER";
            // 
            // newfrmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1273, 681);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLoggedinas);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "newfrmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounting Management";
            this.Load += new System.EventHandler(this.newfrmAccount_Load);
            this.tabControl.ResumeLayout(false);
            this.tabStudentTransaction.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).EndInit();
            this.grpBalanceDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBalanceDetails)).EndInit();
            this.grpStudentDetails.ResumeLayout(false);
            this.grpStudentDetails.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFeeValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabStudentTransaction;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddTransaction;
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
        private System.Windows.Forms.GroupBox grpBalanceDetails;
        private System.Windows.Forms.Button btnViewPaymentHistory;
        public System.Windows.Forms.DataGridView dataSearch;
        public System.Windows.Forms.DataGridView dataBalanceDetails;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnUpdateFee;
        public System.Windows.Forms.DataGridView dataFeeValue;
        private System.Windows.Forms.Button btnAddFee;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}