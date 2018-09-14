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
            this.label2 = new System.Windows.Forms.Label();
            this.txttendered = new System.Windows.Forms.TextBox();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSilaSchoolManagementSoftware = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpNewPayment.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNewPayment
            // 
            this.grpNewPayment.Controls.Add(this.label1);
            this.grpNewPayment.Controls.Add(this.comboBox2);
            this.grpNewPayment.Controls.Add(this.lblPaymentDate2);
            this.grpNewPayment.Controls.Add(this.txtAdditionalDetails);
            this.grpNewPayment.Controls.Add(this.lblAddtionalDetails);
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
            this.grpNewPayment.Controls.Add(this.panel2);
            this.grpNewPayment.Font = new System.Drawing.Font("Bebas Neue", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNewPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.grpNewPayment.Location = new System.Drawing.Point(13, 76);
            this.grpNewPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNewPayment.Name = "grpNewPayment";
            this.grpNewPayment.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNewPayment.Size = new System.Drawing.Size(987, 462);
            this.grpNewPayment.TabIndex = 9;
            this.grpNewPayment.TabStop = false;
            this.grpNewPayment.Text = "Transaction Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "ENTER TENDERED AMOUNT:";
            // 
            // txttendered
            // 
            this.txttendered.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttendered.Location = new System.Drawing.Point(13, 130);
            this.txttendered.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttendered.Name = "txttendered";
            this.txttendered.Size = new System.Drawing.Size(397, 56);
            this.txttendered.TabIndex = 25;
            this.txttendered.TextChanged += new System.EventHandler(this.txttendered_TextChanged);
            this.txttendered.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttendered_KeyPress);
            this.txttendered.Leave += new System.EventHandler(this.txttendered_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 300);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "School Year:";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2018 - 2019",
            "2019 - 2020",
            "2020 - 2021",
            "2021 - 2022",
            "2022 - 2023"});
            this.comboBox2.Location = new System.Drawing.Point(199, 300);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(265, 32);
            this.comboBox2.TabIndex = 7;
            // 
            // lblPaymentDate2
            // 
            this.lblPaymentDate2.AutoSize = true;
            this.lblPaymentDate2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate2.Location = new System.Drawing.Point(198, 256);
            this.lblPaymentDate2.Name = "lblPaymentDate2";
            this.lblPaymentDate2.Size = new System.Drawing.Size(75, 29);
            this.lblPaymentDate2.TabIndex = 17;
            this.lblPaymentDate2.Text = "label1";
            // 
            // txtAdditionalDetails
            // 
            this.txtAdditionalDetails.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdditionalDetails.Location = new System.Drawing.Point(497, 85);
            this.txtAdditionalDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdditionalDetails.Multiline = true;
            this.txtAdditionalDetails.Name = "txtAdditionalDetails";
            this.txtAdditionalDetails.Size = new System.Drawing.Size(457, 154);
            this.txtAdditionalDetails.TabIndex = 8;
            this.txtAdditionalDetails.Text = "NONE";
            // 
            // lblAddtionalDetails
            // 
            this.lblAddtionalDetails.AutoSize = true;
            this.lblAddtionalDetails.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddtionalDetails.Location = new System.Drawing.Point(493, 49);
            this.lblAddtionalDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddtionalDetails.Name = "lblAddtionalDetails";
            this.lblAddtionalDetails.Size = new System.Drawing.Size(185, 32);
            this.lblAddtionalDetails.TabIndex = 15;
            this.lblAddtionalDetails.Text = "Additional Details:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(13, 43);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(397, 56);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(9, 16);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(206, 23);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.Text = "ENTER AMOUNT DUE:";
            // 
            // txtTransactionNo
            // 
            this.txtTransactionNo.BackColor = System.Drawing.Color.White;
            this.txtTransactionNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransactionNo.Location = new System.Drawing.Point(199, 51);
            this.txtTransactionNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTransactionNo.Name = "txtTransactionNo";
            this.txtTransactionNo.Size = new System.Drawing.Size(265, 32);
            this.txtTransactionNo.TabIndex = 1;
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.White;
            this.txtStudentName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(199, 90);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(265, 32);
            this.txtStudentName.TabIndex = 2;
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChequeNo.Location = new System.Drawing.Point(199, 171);
            this.txtChequeNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(265, 32);
            this.txtChequeNo.TabIndex = 4;
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.BackColor = System.Drawing.Color.White;
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.ItemHeight = 24;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Cheque"});
            this.cmbPaymentType.Location = new System.Drawing.Point(199, 131);
            this.cmbPaymentType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(265, 32);
            this.cmbPaymentType.TabIndex = 3;
            this.cmbPaymentType.TextChanged += new System.EventHandler(this.cmbPaymentType_TextChanged);
            // 
            // cmbPaymentTo
            // 
            this.cmbPaymentTo.BackColor = System.Drawing.Color.White;
            this.cmbPaymentTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentTo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentTo.FormattingEnabled = true;
            this.cmbPaymentTo.Items.AddRange(new object[] {
            "Tuition",
            "Books",
            "Registration",
            "Others"});
            this.cmbPaymentTo.Location = new System.Drawing.Point(199, 212);
            this.cmbPaymentTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPaymentTo.Name = "cmbPaymentTo";
            this.cmbPaymentTo.Size = new System.Drawing.Size(265, 32);
            this.cmbPaymentTo.TabIndex = 5;
            this.cmbPaymentTo.TextChanged += new System.EventHandler(this.cmbPaymentTo_TextChanged);
            // 
            // lblPaymentTo
            // 
            this.lblPaymentTo.AutoSize = true;
            this.lblPaymentTo.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentTo.Location = new System.Drawing.Point(68, 211);
            this.lblPaymentTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentTo.Name = "lblPaymentTo";
            this.lblPaymentTo.Size = new System.Drawing.Size(123, 32);
            this.lblPaymentTo.TabIndex = 5;
            this.lblPaymentTo.Text = "Payment To:";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(48, 256);
            this.lblPaymentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(143, 32);
            this.lblPaymentDate.TabIndex = 4;
            this.lblPaymentDate.Text = "Payment Date:";
            // 
            // lblChequeNo
            // 
            this.lblChequeNo.AutoSize = true;
            this.lblChequeNo.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChequeNo.Location = new System.Drawing.Point(80, 171);
            this.lblChequeNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChequeNo.Name = "lblChequeNo";
            this.lblChequeNo.Size = new System.Drawing.Size(111, 32);
            this.lblChequeNo.TabIndex = 3;
            this.lblChequeNo.Text = "Cheque No:";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(48, 130);
            this.lblPaymentType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(143, 32);
            this.lblPaymentType.TabIndex = 2;
            this.lblPaymentType.Text = "Payment Type:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(45, 89);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(146, 32);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Name:";
            // 
            // lblTransactionNo
            // 
            this.lblTransactionNo.AutoSize = true;
            this.lblTransactionNo.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionNo.Location = new System.Drawing.Point(31, 49);
            this.lblTransactionNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionNo.Name = "lblTransactionNo";
            this.lblTransactionNo.Size = new System.Drawing.Size(160, 32);
            this.lblTransactionNo.TabIndex = 0;
            this.lblTransactionNo.Text = "Transaction No:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Bebas Neue", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnCancel.Location = new System.Drawing.Point(794, 546);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(209, 62);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Bebas Neue", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.Black;
            this.btnPay.Location = new System.Drawing.Point(545, 546);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(241, 62);
            this.btnPay.TabIndex = 9;
            this.btnPay.Text = "PROCEED TO PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLoggedinas
            // 
            this.lblLoggedinas.AutoSize = true;
            this.lblLoggedinas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedinas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblLoggedinas.Location = new System.Drawing.Point(8, 42);
            this.lblLoggedinas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoggedinas.Name = "lblLoggedinas";
            this.lblLoggedinas.Size = new System.Drawing.Size(121, 21);
            this.lblLoggedinas.TabIndex = 15;
            this.lblLoggedinas.Text = "Logged in as:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblUser.Location = new System.Drawing.Point(124, 42);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(45, 21);
            this.lblUser.TabIndex = 16;
            this.lblUser.Text = "User";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblSilaSchoolManagementSoftware);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 38);
            this.panel1.TabIndex = 42;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MainSystem.Properties.Resources.starlogo2;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 38);
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
            this.lblSilaSchoolManagementSoftware.Location = new System.Drawing.Point(64, 6);
            this.lblSilaSchoolManagementSoftware.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSilaSchoolManagementSoftware.Name = "lblSilaSchoolManagementSoftware";
            this.lblSilaSchoolManagementSoftware.Size = new System.Drawing.Size(487, 28);
            this.lblSilaSchoolManagementSoftware.TabIndex = 0;
            this.lblSilaSchoolManagementSoftware.Text = "ACCOUNTING MANAGEMENT - S.I.L.A SCHOOL MANAGEMENT SOFTWARE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtAmount);
            this.panel2.Controls.Add(this.txttendered);
            this.panel2.Controls.Add(this.lblAmount);
            this.panel2.Location = new System.Drawing.Point(497, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 200);
            this.panel2.TabIndex = 27;
            // 
            // newfrmAddTransaction
            // 
            this.AcceptButton = this.btnPay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1019, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLoggedinas);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.grpNewPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "newfrmAddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Transaction";
            this.Load += new System.EventHandler(this.newfrmAddTransaction_Load);
            this.grpNewPayment.ResumeLayout(false);
            this.grpNewPayment.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSilaSchoolManagementSoftware;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txttendered;
        private System.Windows.Forms.Panel panel2;
    }
}