namespace MainSystem.Accounting
{
    partial class frmAddFee
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
            this.grpAddFee = new System.Windows.Forms.GroupBox();
            this.dateYearEnd = new System.Windows.Forms.DateTimePicker();
            this.dateYearStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtFeeDescription = new System.Windows.Forms.TextBox();
            this.lblFeeDescription = new System.Windows.Forms.Label();
            this.cmbGradeLevel = new System.Windows.Forms.ComboBox();
            this.lblGradeLevel = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLoggedinas = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDate2 = new System.Windows.Forms.Label();
            this.grpAddFee.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddFee
            // 
            this.grpAddFee.Controls.Add(this.dateYearEnd);
            this.grpAddFee.Controls.Add(this.dateYearStart);
            this.grpAddFee.Controls.Add(this.label2);
            this.grpAddFee.Controls.Add(this.label1);
            this.grpAddFee.Controls.Add(this.txtAmount);
            this.grpAddFee.Controls.Add(this.lblAmount);
            this.grpAddFee.Controls.Add(this.txtFeeDescription);
            this.grpAddFee.Controls.Add(this.lblFeeDescription);
            this.grpAddFee.Controls.Add(this.cmbGradeLevel);
            this.grpAddFee.Controls.Add(this.lblGradeLevel);
            this.grpAddFee.Location = new System.Drawing.Point(12, 55);
            this.grpAddFee.Name = "grpAddFee";
            this.grpAddFee.Size = new System.Drawing.Size(566, 263);
            this.grpAddFee.TabIndex = 0;
            this.grpAddFee.TabStop = false;
            this.grpAddFee.Text = "Add Fee";
            // 
            // dateYearEnd
            // 
            this.dateYearEnd.CustomFormat = "yyyy/MM/dd";
            this.dateYearEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateYearEnd.Location = new System.Drawing.Point(448, 94);
            this.dateYearEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dateYearEnd.Name = "dateYearEnd";
            this.dateYearEnd.Size = new System.Drawing.Size(109, 20);
            this.dateYearEnd.TabIndex = 5;
            // 
            // dateYearStart
            // 
            this.dateYearStart.CustomFormat = "yyyy/MM/dd";
            this.dateYearStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateYearStart.Location = new System.Drawing.Point(448, 41);
            this.dateYearStart.Margin = new System.Windows.Forms.Padding(2);
            this.dateYearStart.Name = "dateYearStart";
            this.dateYearStart.Size = new System.Drawing.Size(109, 20);
            this.dateYearStart.TabIndex = 4;
            this.dateYearStart.ValueChanged += new System.EventHandler(this.dateYearStart_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "School Year End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "School Year Start";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(115, 222);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(6, 223);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(53, 16);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.Text = "Amount";
            // 
            // txtFeeDescription
            // 
            this.txtFeeDescription.Location = new System.Drawing.Point(115, 94);
            this.txtFeeDescription.Multiline = true;
            this.txtFeeDescription.Name = "txtFeeDescription";
            this.txtFeeDescription.Size = new System.Drawing.Size(200, 97);
            this.txtFeeDescription.TabIndex = 2;
            // 
            // lblFeeDescription
            // 
            this.lblFeeDescription.AutoSize = true;
            this.lblFeeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeeDescription.Location = new System.Drawing.Point(6, 94);
            this.lblFeeDescription.Name = "lblFeeDescription";
            this.lblFeeDescription.Size = new System.Drawing.Size(103, 16);
            this.lblFeeDescription.TabIndex = 10;
            this.lblFeeDescription.Text = "Fee Description";
            // 
            // cmbGradeLevel
            // 
            this.cmbGradeLevel.BackColor = System.Drawing.Color.White;
            this.cmbGradeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradeLevel.FormattingEnabled = true;
            this.cmbGradeLevel.ItemHeight = 13;
            this.cmbGradeLevel.Items.AddRange(new object[] {
            "",
            "Nursery",
            "Kindergarten",
            "Grade 1",
            "Grade 2",
            "Grade 3",
            "Grade 4",
            "Grade 5",
            "Grade 6",
            "Grade 7",
            "Grade 8",
            "Grade 9",
            "Grade 10"});
            this.cmbGradeLevel.Location = new System.Drawing.Point(115, 41);
            this.cmbGradeLevel.Name = "cmbGradeLevel";
            this.cmbGradeLevel.Size = new System.Drawing.Size(200, 21);
            this.cmbGradeLevel.TabIndex = 1;
            // 
            // lblGradeLevel
            // 
            this.lblGradeLevel.AutoSize = true;
            this.lblGradeLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeLevel.Location = new System.Drawing.Point(6, 42);
            this.lblGradeLevel.Name = "lblGradeLevel";
            this.lblGradeLevel.Size = new System.Drawing.Size(82, 16);
            this.lblGradeLevel.TabIndex = 5;
            this.lblGradeLevel.Text = "Grade Level";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate.Location = new System.Drawing.Point(413, 21);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // lblLoggedinas
            // 
            this.lblLoggedinas.AutoSize = true;
            this.lblLoggedinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLoggedinas.Location = new System.Drawing.Point(9, 21);
            this.lblLoggedinas.Name = "lblLoggedinas";
            this.lblLoggedinas.Size = new System.Drawing.Size(94, 17);
            this.lblLoggedinas.TabIndex = 8;
            this.lblLoggedinas.Text = "Logged in as:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUser.Location = new System.Drawing.Point(106, 21);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 17);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "User";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(109, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 31);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 31);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate2.Location = new System.Drawing.Point(551, 21);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(38, 17);
            this.lblDate2.TabIndex = 16;
            this.lblDate2.Text = "Date";
            // 
            // frmAddFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 367);
            this.Controls.Add(this.lblDate2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLoggedinas);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.grpAddFee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Fee";
            this.Load += new System.EventHandler(this.frmAddFee_Load);
            this.grpAddFee.ResumeLayout(false);
            this.grpAddFee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddFee;
        private System.Windows.Forms.Label lblGradeLevel;
        public System.Windows.Forms.ComboBox cmbGradeLevel;
        private System.Windows.Forms.Label lblFeeDescription;
        public System.Windows.Forms.TextBox txtFeeDescription;
        public System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLoggedinas;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.DateTimePicker dateYearEnd;
        private System.Windows.Forms.DateTimePicker dateYearStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}