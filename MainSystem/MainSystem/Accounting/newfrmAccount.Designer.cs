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
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.searchtppending = new System.Windows.Forms.DateTimePicker();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.dgvpending = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRLDDGVOID = new System.Windows.Forms.Button();
            this.btnSRCDGVOID = new System.Windows.Forms.Button();
            this.searchtpvoided = new System.Windows.Forms.DateTimePicker();
            this.dgvvoid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfn = new System.Windows.Forms.TextBox();
            this.txtdp = new System.Windows.Forms.TextBox();
            this.dataSearch = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpBalanceDetails = new System.Windows.Forms.GroupBox();
            this.dataBalanceDetails = new System.Windows.Forms.DataGridView();
            this.searchpaymenttxtbox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtfeesearch = new System.Windows.Forms.TextBox();
            this.btnAddFee = new System.Windows.Forms.Button();
            this.btnUpdateFee = new System.Windows.Forms.Button();
            this.dataFeeValue = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddDisb = new System.Windows.Forms.Button();
            this.btnreldb = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsdb = new System.Windows.Forms.Button();
            this.searchtpexpense = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.btnViewPaymentHistory = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblLoggedinas = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsy = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSilaSchoolManagementSoftware = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabStudentTransaction.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpending)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvoid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).BeginInit();
            this.grpBalanceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBalanceDetails)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFeeValue)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabStudentTransaction);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(6, 69);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1252, 602);
            this.tabControl.TabIndex = 13;
            // 
            // tabStudentTransaction
            // 
            this.tabStudentTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.tabStudentTransaction.Controls.Add(this.btnAddTransaction);
            this.tabStudentTransaction.Controls.Add(this.groupBox2);
            this.tabStudentTransaction.Controls.Add(this.groupBox1);
            this.tabStudentTransaction.Controls.Add(this.grpBalanceDetails);
            this.tabStudentTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.tabStudentTransaction.Location = new System.Drawing.Point(4, 35);
            this.tabStudentTransaction.Name = "tabStudentTransaction";
            this.tabStudentTransaction.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentTransaction.Size = new System.Drawing.Size(1244, 563);
            this.tabStudentTransaction.TabIndex = 0;
            this.tabStudentTransaction.Text = "Student List";
            this.tabStudentTransaction.Click += new System.EventHandler(this.tabStudentTransaction_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTransaction.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddTransaction.Enabled = false;
            this.btnAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTransaction.Font = new System.Drawing.Font("Bebas Neue", 42F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTransaction.ForeColor = System.Drawing.Color.White;
            this.btnAddTransaction.Location = new System.Drawing.Point(917, 378);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(306, 173);
            this.btnAddTransaction.TabIndex = 2;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = false;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Bebas Neue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.groupBox2.Location = new System.Drawing.Point(542, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 358);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cheque Payments";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Bebas Neue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 272);
            this.tabControl1.TabIndex = 30;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.tabPage2.Controls.Add(this.searchtppending);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.dgvpending);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(661, 237);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "PENDING";
            // 
            // searchtppending
            // 
            this.searchtppending.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtppending.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtppending.Location = new System.Drawing.Point(6, 9);
            this.searchtppending.Name = "searchtppending";
            this.searchtppending.Size = new System.Drawing.Size(299, 27);
            this.searchtppending.TabIndex = 4;
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button10.BackgroundImage = global::MainSystem.Properties.Resources.refresh;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(337, 9);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(19, 26);
            this.button10.TabIndex = 33;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button11.BackgroundImage = global::MainSystem.Properties.Resources.magnifying_glass1;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(311, 9);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(20, 26);
            this.button11.TabIndex = 32;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // dgvpending
            // 
            this.dgvpending.AllowUserToAddRows = false;
            this.dgvpending.AllowUserToDeleteRows = false;
            this.dgvpending.AllowUserToResizeColumns = false;
            this.dgvpending.AllowUserToResizeRows = false;
            this.dgvpending.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvpending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpending.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvpending.ColumnHeadersHeight = 48;
            this.dgvpending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvpending.Location = new System.Drawing.Point(6, 41);
            this.dgvpending.Name = "dgvpending";
            this.dgvpending.RowHeadersVisible = false;
            this.dgvpending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpending.Size = new System.Drawing.Size(649, 190);
            this.dgvpending.TabIndex = 1;
            this.dgvpending.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpending_CellClick);
            this.dgvpending.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpending_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.tabPage3.Controls.Add(this.btnRLDDGVOID);
            this.tabPage3.Controls.Add(this.btnSRCDGVOID);
            this.tabPage3.Controls.Add(this.searchtpvoided);
            this.tabPage3.Controls.Add(this.dgvvoid);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(661, 237);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "VOIDED";
            // 
            // btnRLDDGVOID
            // 
            this.btnRLDDGVOID.BackgroundImage = global::MainSystem.Properties.Resources.refresh;
            this.btnRLDDGVOID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRLDDGVOID.Enabled = false;
            this.btnRLDDGVOID.FlatAppearance.BorderSize = 0;
            this.btnRLDDGVOID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRLDDGVOID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRLDDGVOID.Location = new System.Drawing.Point(337, 10);
            this.btnRLDDGVOID.Name = "btnRLDDGVOID";
            this.btnRLDDGVOID.Size = new System.Drawing.Size(19, 26);
            this.btnRLDDGVOID.TabIndex = 33;
            this.btnRLDDGVOID.UseVisualStyleBackColor = true;
            this.btnRLDDGVOID.Click += new System.EventHandler(this.btnRLDDGVOID_Click);
            // 
            // btnSRCDGVOID
            // 
            this.btnSRCDGVOID.BackgroundImage = global::MainSystem.Properties.Resources.magnifying_glass1;
            this.btnSRCDGVOID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSRCDGVOID.Enabled = false;
            this.btnSRCDGVOID.FlatAppearance.BorderSize = 0;
            this.btnSRCDGVOID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSRCDGVOID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSRCDGVOID.Location = new System.Drawing.Point(311, 10);
            this.btnSRCDGVOID.Name = "btnSRCDGVOID";
            this.btnSRCDGVOID.Size = new System.Drawing.Size(19, 26);
            this.btnSRCDGVOID.TabIndex = 32;
            this.btnSRCDGVOID.UseVisualStyleBackColor = true;
            this.btnSRCDGVOID.Click += new System.EventHandler(this.btnSRCDGVOID_Click);
            // 
            // searchtpvoided
            // 
            this.searchtpvoided.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtpvoided.Location = new System.Drawing.Point(6, 9);
            this.searchtpvoided.Name = "searchtpvoided";
            this.searchtpvoided.Size = new System.Drawing.Size(299, 27);
            this.searchtpvoided.TabIndex = 3;
            // 
            // dgvvoid
            // 
            this.dgvvoid.AllowUserToAddRows = false;
            this.dgvvoid.AllowUserToDeleteRows = false;
            this.dgvvoid.AllowUserToResizeColumns = false;
            this.dgvvoid.AllowUserToResizeRows = false;
            this.dgvvoid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvvoid.BackgroundColor = System.Drawing.Color.White;
            this.dgvvoid.ColumnHeadersHeight = 48;
            this.dgvvoid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvvoid.Location = new System.Drawing.Point(6, 41);
            this.dgvvoid.Name = "dgvvoid";
            this.dgvvoid.ReadOnly = true;
            this.dgvvoid.RowHeadersVisible = false;
            this.dgvvoid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvvoid.Size = new System.Drawing.Size(649, 190);
            this.dgvvoid.TabIndex = 2;
            this.dgvvoid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvoid_CellClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bebas Neue", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(7, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btnEditAccount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtfn);
            this.groupBox1.Controls.Add(this.txtdp);
            this.groupBox1.Controls.Add(this.dataSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Font = new System.Drawing.Font("Bebas Neue", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 355);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account List";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(352, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(165, 26);
            this.checkBox1.TabIndex = 55;
            this.checkBox1.Text = "VIEW INACTIVE STUDENTS";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditAccount.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEditAccount.Enabled = false;
            this.btnEditAccount.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnEditAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAccount.Font = new System.Drawing.Font("Bebas Neue", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAccount.ForeColor = System.Drawing.Color.White;
            this.btnEditAccount.Location = new System.Drawing.Point(323, 207);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(191, 141);
            this.btnEditAccount.TabIndex = 3;
            this.btnEditAccount.Text = "View Statement Of Accounts";
            this.btnEditAccount.UseVisualStyleBackColor = false;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Department:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "Full Name:";
            // 
            // txtfn
            // 
            this.txtfn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtfn.BackColor = System.Drawing.Color.White;
            this.txtfn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfn.Location = new System.Drawing.Point(121, 220);
            this.txtfn.Name = "txtfn";
            this.txtfn.ReadOnly = true;
            this.txtfn.Size = new System.Drawing.Size(187, 27);
            this.txtfn.TabIndex = 48;
            // 
            // txtdp
            // 
            this.txtdp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtdp.BackColor = System.Drawing.Color.White;
            this.txtdp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdp.Location = new System.Drawing.Point(121, 261);
            this.txtdp.Name = "txtdp";
            this.txtdp.ReadOnly = true;
            this.txtdp.Size = new System.Drawing.Size(187, 27);
            this.txtdp.TabIndex = 47;
            // 
            // dataSearch
            // 
            this.dataSearch.AllowUserToAddRows = false;
            this.dataSearch.AllowUserToDeleteRows = false;
            this.dataSearch.AllowUserToResizeColumns = false;
            this.dataSearch.AllowUserToResizeRows = false;
            this.dataSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSearch.BackgroundColor = System.Drawing.Color.White;
            this.dataSearch.ColumnHeadersHeight = 45;
            this.dataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataSearch.Location = new System.Drawing.Point(6, 59);
            this.dataSearch.Name = "dataSearch";
            this.dataSearch.ReadOnly = true;
            this.dataSearch.RowHeadersVisible = false;
            this.dataSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSearch.Size = new System.Drawing.Size(508, 142);
            this.dataSearch.TabIndex = 44;
            this.dataSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSearch_CellClick);
            this.dataSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSearch_CellContentClick_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 27);
            this.txtSearch.TabIndex = 43;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // grpBalanceDetails
            // 
            this.grpBalanceDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBalanceDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.grpBalanceDetails.Controls.Add(this.dataBalanceDetails);
            this.grpBalanceDetails.Controls.Add(this.searchpaymenttxtbox);
            this.grpBalanceDetails.Font = new System.Drawing.Font("Bebas Neue", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBalanceDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.grpBalanceDetails.Location = new System.Drawing.Point(6, 361);
            this.grpBalanceDetails.Name = "grpBalanceDetails";
            this.grpBalanceDetails.Size = new System.Drawing.Size(899, 200);
            this.grpBalanceDetails.TabIndex = 11;
            this.grpBalanceDetails.TabStop = false;
            this.grpBalanceDetails.Text = "Balance And Payment";
            this.grpBalanceDetails.Enter += new System.EventHandler(this.grpBalanceDetails_Enter);
            // 
            // dataBalanceDetails
            // 
            this.dataBalanceDetails.AllowUserToAddRows = false;
            this.dataBalanceDetails.AllowUserToDeleteRows = false;
            this.dataBalanceDetails.AllowUserToResizeColumns = false;
            this.dataBalanceDetails.AllowUserToResizeRows = false;
            this.dataBalanceDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBalanceDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBalanceDetails.BackgroundColor = System.Drawing.Color.White;
            this.dataBalanceDetails.ColumnHeadersHeight = 45;
            this.dataBalanceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataBalanceDetails.Location = new System.Drawing.Point(6, 54);
            this.dataBalanceDetails.Name = "dataBalanceDetails";
            this.dataBalanceDetails.ReadOnly = true;
            this.dataBalanceDetails.RowHeadersVisible = false;
            this.dataBalanceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataBalanceDetails.Size = new System.Drawing.Size(885, 136);
            this.dataBalanceDetails.TabIndex = 0;
            this.dataBalanceDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBalanceDetails_CellContentClick);
            // 
            // searchpaymenttxtbox
            // 
            this.searchpaymenttxtbox.Location = new System.Drawing.Point(8, 21);
            this.searchpaymenttxtbox.Name = "searchpaymenttxtbox";
            this.searchpaymenttxtbox.Size = new System.Drawing.Size(231, 29);
            this.searchpaymenttxtbox.TabIndex = 55;
            this.searchpaymenttxtbox.TextChanged += new System.EventHandler(this.searchpaymenttxtbox_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1244, 563);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Fee Management";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.button3.Location = new System.Drawing.Point(2061, 640);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 37);
            this.button3.TabIndex = 37;
            this.button3.Text = "Update Voucher";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtfeesearch);
            this.groupBox3.Controls.Add(this.btnAddFee);
            this.groupBox3.Controls.Add(this.btnUpdateFee);
            this.groupBox3.Controls.Add(this.dataFeeValue);
            this.groupBox3.Font = new System.Drawing.Font("Bebas Neue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1233, 553);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fee Management";
            // 
            // txtfeesearch
            // 
            this.txtfeesearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtfeesearch.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfeesearch.Location = new System.Drawing.Point(6, 29);
            this.txtfeesearch.Name = "txtfeesearch";
            this.txtfeesearch.Size = new System.Drawing.Size(248, 30);
            this.txtfeesearch.TabIndex = 44;
            this.txtfeesearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAddFee
            // 
            this.btnAddFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFee.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddFee.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFee.Font = new System.Drawing.Font("Bebas Neue", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFee.ForeColor = System.Drawing.Color.White;
            this.btnAddFee.Location = new System.Drawing.Point(905, 493);
            this.btnAddFee.Name = "btnAddFee";
            this.btnAddFee.Size = new System.Drawing.Size(156, 52);
            this.btnAddFee.TabIndex = 5;
            this.btnAddFee.Text = "Add Fee";
            this.btnAddFee.UseVisualStyleBackColor = false;
            this.btnAddFee.Click += new System.EventHandler(this.btnAddFee_Click);
            // 
            // btnUpdateFee
            // 
            this.btnUpdateFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateFee.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdateFee.Enabled = false;
            this.btnUpdateFee.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdateFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateFee.Font = new System.Drawing.Font("Bebas Neue", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFee.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateFee.Location = new System.Drawing.Point(1066, 492);
            this.btnUpdateFee.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateFee.Name = "btnUpdateFee";
            this.btnUpdateFee.Size = new System.Drawing.Size(161, 53);
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
            this.dataFeeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataFeeValue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFeeValue.BackgroundColor = System.Drawing.Color.White;
            this.dataFeeValue.ColumnHeadersHeight = 40;
            this.dataFeeValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataFeeValue.Location = new System.Drawing.Point(6, 63);
            this.dataFeeValue.Name = "dataFeeValue";
            this.dataFeeValue.RowHeadersVisible = false;
            this.dataFeeValue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFeeValue.Size = new System.Drawing.Size(1220, 424);
            this.dataFeeValue.TabIndex = 7;
            this.dataFeeValue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFeeValue_CellClick);
            this.dataFeeValue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFeeValue_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 35);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1244, 563);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "DISBURSEMENT";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnAddDisb);
            this.groupBox4.Controls.Add(this.btnreldb);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.btnsdb);
            this.groupBox4.Controls.Add(this.searchtpexpense);
            this.groupBox4.Font = new System.Drawing.Font("Bebas Neue", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.groupBox4.Location = new System.Drawing.Point(9, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1233, 545);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Disbursement Management";
            // 
            // btnAddDisb
            // 
            this.btnAddDisb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDisb.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddDisb.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddDisb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDisb.Font = new System.Drawing.Font("Bebas Neue", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDisb.ForeColor = System.Drawing.Color.White;
            this.btnAddDisb.Location = new System.Drawing.Point(975, 482);
            this.btnAddDisb.Name = "btnAddDisb";
            this.btnAddDisb.Size = new System.Drawing.Size(251, 55);
            this.btnAddDisb.TabIndex = 36;
            this.btnAddDisb.Text = "Create Voucher";
            this.btnAddDisb.UseVisualStyleBackColor = false;
            this.btnAddDisb.Click += new System.EventHandler(this.btnAddDisb_Click);
            // 
            // btnreldb
            // 
            this.btnreldb.BackgroundImage = global::MainSystem.Properties.Resources.refresh;
            this.btnreldb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnreldb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnreldb.FlatAppearance.BorderSize = 0;
            this.btnreldb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreldb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreldb.Location = new System.Drawing.Point(348, 28);
            this.btnreldb.Name = "btnreldb";
            this.btnreldb.Size = new System.Drawing.Size(26, 25);
            this.btnreldb.TabIndex = 40;
            this.btnreldb.UseVisualStyleBackColor = true;
            this.btnreldb.Click += new System.EventHandler(this.btnreldb_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(6, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1220, 416);
            this.dataGridView1.TabIndex = 35;
            // 
            // btnsdb
            // 
            this.btnsdb.BackgroundImage = global::MainSystem.Properties.Resources.magnifying_glass1;
            this.btnsdb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsdb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnsdb.FlatAppearance.BorderSize = 0;
            this.btnsdb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsdb.Location = new System.Drawing.Point(315, 28);
            this.btnsdb.Name = "btnsdb";
            this.btnsdb.Size = new System.Drawing.Size(26, 25);
            this.btnsdb.TabIndex = 39;
            this.btnsdb.UseVisualStyleBackColor = true;
            this.btnsdb.Click += new System.EventHandler(this.btnsdb_Click);
            // 
            // searchtpexpense
            // 
            this.searchtpexpense.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtpexpense.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtpexpense.Location = new System.Drawing.Point(6, 28);
            this.searchtpexpense.Name = "searchtpexpense";
            this.searchtpexpense.Size = new System.Drawing.Size(304, 27);
            this.searchtpexpense.TabIndex = 38;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(162)))), ((int)(((byte)(23)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(41)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(591, 32);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 48);
            this.button2.TabIndex = 13;
            this.button2.Text = "Generate DCF Report";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnViewPaymentHistory
            // 
            this.btnViewPaymentHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewPaymentHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnViewPaymentHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(162)))), ((int)(((byte)(23)))));
            this.btnViewPaymentHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(41)))));
            this.btnViewPaymentHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPaymentHistory.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPaymentHistory.ForeColor = System.Drawing.Color.Black;
            this.btnViewPaymentHistory.Location = new System.Drawing.Point(850, 32);
            this.btnViewPaymentHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewPaymentHistory.Name = "btnViewPaymentHistory";
            this.btnViewPaymentHistory.Size = new System.Drawing.Size(262, 48);
            this.btnViewPaymentHistory.TabIndex = 5;
            this.btnViewPaymentHistory.Text = "View Payment History";
            this.btnViewPaymentHistory.UseVisualStyleBackColor = false;
            this.btnViewPaymentHistory.Click += new System.EventHandler(this.btnViewPaymentHistory_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.BackColor = System.Drawing.Color.DarkRed;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnDashboard.Location = new System.Drawing.Point(1117, 34);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(147, 46);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblLoggedinas
            // 
            this.lblLoggedinas.AutoSize = true;
            this.lblLoggedinas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedinas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblLoggedinas.Location = new System.Drawing.Point(6, 34);
            this.lblLoggedinas.Name = "lblLoggedinas";
            this.lblLoggedinas.Size = new System.Drawing.Size(104, 19);
            this.lblLoggedinas.TabIndex = 0;
            this.lblLoggedinas.Text = "Logged in as: ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblUser.Location = new System.Drawing.Point(100, 34);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 19);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "USER";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblsy);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblSilaSchoolManagementSoftware);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 31);
            this.panel1.TabIndex = 41;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.label3.Location = new System.Drawing.Point(1079, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "CURRENT S.Y";
            // 
            // lblsy
            // 
            this.lblsy.AutoSize = true;
            this.lblsy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsy.Font = new System.Drawing.Font("Bebas Neue", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblsy.Location = new System.Drawing.Point(1159, 7);
            this.lblsy.Name = "lblsy";
            this.lblsy.Size = new System.Drawing.Size(30, 23);
            this.lblsy.TabIndex = 2;
            this.lblsy.Text = "S.Y ";
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
            this.lblSilaSchoolManagementSoftware.Font = new System.Drawing.Font("Bebas Neue", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSilaSchoolManagementSoftware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblSilaSchoolManagementSoftware.Location = new System.Drawing.Point(50, 7);
            this.lblSilaSchoolManagementSoftware.Name = "lblSilaSchoolManagementSoftware";
            this.lblSilaSchoolManagementSoftware.Size = new System.Drawing.Size(409, 23);
            this.lblSilaSchoolManagementSoftware.TabIndex = 0;
            this.lblSilaSchoolManagementSoftware.Text = "ACCOUNTING MANAGEMENT - S.I.L.A SCHOOL MANAGEMENT SOFTWARE";
            // 
            // newfrmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnViewPaymentHistory);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.lblLoggedinas);
            this.Controls.Add(this.tabControl);
            this.Name = "newfrmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounting Management";
            this.Load += new System.EventHandler(this.newfrmAccount_Load);
            this.tabControl.ResumeLayout(false);
            this.tabStudentTransaction.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpending)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvoid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).EndInit();
            this.grpBalanceDetails.ResumeLayout(false);
            this.grpBalanceDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBalanceDetails)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFeeValue)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabStudentTransaction;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblLoggedinas;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnViewPaymentHistory;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnUpdateFee;
        public System.Windows.Forms.DataGridView dataFeeValue;
        private System.Windows.Forms.Button btnAddFee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.DataGridView dgvvoid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSilaSchoolManagementSoftware;
        private System.Windows.Forms.GroupBox grpBalanceDetails;
        public System.Windows.Forms.DataGridView dataBalanceDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtfeesearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtfn;
        public System.Windows.Forms.TextBox txtdp;
        public System.Windows.Forms.DataGridView dataSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox searchpaymenttxtbox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddDisb;
        private System.Windows.Forms.Button btnreldb;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsdb;
        private System.Windows.Forms.DateTimePicker searchtpexpense;
        private System.Windows.Forms.Label lblsy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.DataGridView dgvpending;
        private System.Windows.Forms.DateTimePicker searchtppending;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnRLDDGVOID;
        private System.Windows.Forms.Button btnSRCDGVOID;
        private System.Windows.Forms.DateTimePicker searchtpvoided;
    }
}