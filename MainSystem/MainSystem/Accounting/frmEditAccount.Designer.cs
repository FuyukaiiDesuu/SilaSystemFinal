namespace MainSystem
{
    partial class frmEditAccount
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpStudentDetails = new System.Windows.Forms.GroupBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpStudentAccount = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataSearch = new System.Windows.Forms.DataGridView();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtStudentAccountID = new System.Windows.Forms.TextBox();
            this.lblStudentAccountID = new System.Windows.Forms.Label();
            this.dateDateCreated = new System.Windows.Forms.DateTimePicker();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.grpStudentDetails.SuspendLayout();
            this.grpStudentAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(109, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpStudentDetails
            // 
            this.grpStudentDetails.Controls.Add(this.txtStudentName);
            this.grpStudentDetails.Controls.Add(this.lblStudentName);
            this.grpStudentDetails.Controls.Add(this.txtStudentID);
            this.grpStudentDetails.Controls.Add(this.lblStudentID);
            this.grpStudentDetails.Location = new System.Drawing.Point(12, 232);
            this.grpStudentDetails.Name = "grpStudentDetails";
            this.grpStudentDetails.Size = new System.Drawing.Size(308, 135);
            this.grpStudentDetails.TabIndex = 8;
            this.grpStudentDetails.TabStop = false;
            this.grpStudentDetails.Text = "Student Details";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(59, 34);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(226, 20);
            this.txtStudentID.TabIndex = 5;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(8, 34);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(21, 16);
            this.lblStudentID.TabIndex = 4;
            this.lblStudentID.Text = "ID";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(59, 82);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(226, 20);
            this.txtStudentName.TabIndex = 7;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(8, 83);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(45, 16);
            this.lblStudentName.TabIndex = 6;
            this.lblStudentName.Text = "Name";
            this.lblStudentName.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 31);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpStudentAccount
            // 
            this.grpStudentAccount.Controls.Add(this.lblDateCreated);
            this.grpStudentAccount.Controls.Add(this.dateDateCreated);
            this.grpStudentAccount.Controls.Add(this.txtStudentAccountID);
            this.grpStudentAccount.Controls.Add(this.lblStudentAccountID);
            this.grpStudentAccount.Location = new System.Drawing.Point(326, 72);
            this.grpStudentAccount.Name = "grpStudentAccount";
            this.grpStudentAccount.Size = new System.Drawing.Size(288, 295);
            this.grpStudentAccount.TabIndex = 10;
            this.grpStudentAccount.TabStop = false;
            this.grpStudentAccount.Text = "Student Account";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 53);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 20);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataSearch
            // 
            this.dataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearch.Location = new System.Drawing.Point(12, 79);
            this.dataSearch.Name = "dataSearch";
            this.dataSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSearch.Size = new System.Drawing.Size(308, 147);
            this.dataSearch.TabIndex = 12;
            this.dataSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataSearch_MouseClick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 24);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(272, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 24);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtStudentAccountID
            // 
            this.txtStudentAccountID.Location = new System.Drawing.Point(132, 30);
            this.txtStudentAccountID.Name = "txtStudentAccountID";
            this.txtStudentAccountID.ReadOnly = true;
            this.txtStudentAccountID.Size = new System.Drawing.Size(136, 20);
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
            // dateDateCreated
            // 
            this.dateDateCreated.CustomFormat = "yyyy/MM/dd";
            this.dateDateCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDateCreated.Location = new System.Drawing.Point(132, 72);
            this.dateDateCreated.Name = "dateDateCreated";
            this.dateDateCreated.Size = new System.Drawing.Size(136, 20);
            this.dateDateCreated.TabIndex = 8;
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCreated.Location = new System.Drawing.Point(6, 72);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(88, 16);
            this.lblDateCreated.TabIndex = 9;
            this.lblDateCreated.Text = "Date Created";
            // 
            // frmEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 547);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataSearch);
            this.Controls.Add(this.grpStudentAccount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpStudentDetails);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmEditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Account";
            this.Load += new System.EventHandler(this.frmEditAccount_Load);
            this.grpStudentDetails.ResumeLayout(false);
            this.grpStudentDetails.PerformLayout();
            this.grpStudentAccount.ResumeLayout(false);
            this.grpStudentAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpStudentDetails;
        public System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentName;
        public System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpStudentAccount;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataSearch;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox txtStudentAccountID;
        private System.Windows.Forms.Label lblStudentAccountID;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.DateTimePicker dateDateCreated;
    }
}