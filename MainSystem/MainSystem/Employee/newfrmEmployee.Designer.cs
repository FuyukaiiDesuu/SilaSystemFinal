﻿namespace MainSystem.Employee
{
    partial class newfrmEmployee
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
            this.lblLoggedinas = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.txtMaritalStatus = new System.Windows.Forms.TextBox();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.lblBirthPlace = new System.Windows.Forms.Label();
            this.txtReligion = new System.Windows.Forms.TextBox();
            this.lblReligion = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.grpPersonalDetails = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grpEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.dataSearch = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpPersonalDetails.SuspendLayout();
            this.grpEmployeeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoggedinas
            // 
            this.lblLoggedinas.AutoSize = true;
            this.lblLoggedinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLoggedinas.Location = new System.Drawing.Point(9, 5);
            this.lblLoggedinas.Name = "lblLoggedinas";
            this.lblLoggedinas.Size = new System.Drawing.Size(98, 17);
            this.lblLoggedinas.TabIndex = 27;
            this.lblLoggedinas.Text = "Logged in as: ";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(685, 24);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(100, 37);
            this.btnDashboard.TabIndex = 26;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // txtMaritalStatus
            // 
            this.txtMaritalStatus.BackColor = System.Drawing.Color.White;
            this.txtMaritalStatus.Location = new System.Drawing.Point(155, 221);
            this.txtMaritalStatus.Name = "txtMaritalStatus";
            this.txtMaritalStatus.ReadOnly = true;
            this.txtMaritalStatus.Size = new System.Drawing.Size(180, 20);
            this.txtMaritalStatus.TabIndex = 15;
            this.txtMaritalStatus.TabStop = false;
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaritalStatus.Location = new System.Drawing.Point(20, 222);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(88, 16);
            this.lblMaritalStatus.TabIndex = 14;
            this.lblMaritalStatus.Text = "Marital Status";
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.BackColor = System.Drawing.Color.White;
            this.txtBirthPlace.Location = new System.Drawing.Point(155, 74);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.ReadOnly = true;
            this.txtBirthPlace.Size = new System.Drawing.Size(180, 20);
            this.txtBirthPlace.TabIndex = 13;
            this.txtBirthPlace.TabStop = false;
            // 
            // lblBirthPlace
            // 
            this.lblBirthPlace.AutoSize = true;
            this.lblBirthPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthPlace.Location = new System.Drawing.Point(20, 69);
            this.lblBirthPlace.Name = "lblBirthPlace";
            this.lblBirthPlace.Size = new System.Drawing.Size(72, 16);
            this.lblBirthPlace.TabIndex = 12;
            this.lblBirthPlace.Text = "Birth Place";
            // 
            // txtReligion
            // 
            this.txtReligion.BackColor = System.Drawing.Color.White;
            this.txtReligion.Location = new System.Drawing.Point(155, 186);
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.ReadOnly = true;
            this.txtReligion.Size = new System.Drawing.Size(180, 20);
            this.txtReligion.TabIndex = 11;
            this.txtReligion.TabStop = false;
            // 
            // lblReligion
            // 
            this.lblReligion.AutoSize = true;
            this.lblReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReligion.Location = new System.Drawing.Point(20, 186);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.Size = new System.Drawing.Size(58, 16);
            this.lblReligion.TabIndex = 10;
            this.lblReligion.Text = "Religion";
            // 
            // txtContactNo
            // 
            this.txtContactNo.BackColor = System.Drawing.Color.White;
            this.txtContactNo.Location = new System.Drawing.Point(155, 110);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.ReadOnly = true;
            this.txtContactNo.Size = new System.Drawing.Size(180, 20);
            this.txtContactNo.TabIndex = 9;
            this.txtContactNo.TabStop = false;
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(20, 105);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(74, 16);
            this.lblContactNo.TabIndex = 8;
            this.lblContactNo.Text = "Contact No";
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.White;
            this.txtSex.Location = new System.Drawing.Point(155, 146);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(180, 20);
            this.txtSex.TabIndex = 7;
            this.txtSex.TabStop = false;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(20, 146);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(31, 16);
            this.lblSex.TabIndex = 6;
            this.lblSex.Text = "Sex";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.BackColor = System.Drawing.Color.White;
            this.txtBirthDate.Location = new System.Drawing.Point(155, 32);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.ReadOnly = true;
            this.txtBirthDate.Size = new System.Drawing.Size(180, 20);
            this.txtBirthDate.TabIndex = 5;
            this.txtBirthDate.TabStop = false;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(20, 36);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(66, 16);
            this.lblBirthDate.TabIndex = 4;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUser.Location = new System.Drawing.Point(105, 5);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 17);
            this.lblUser.TabIndex = 28;
            this.lblUser.Text = "USER";
            // 
            // grpPersonalDetails
            // 
            this.grpPersonalDetails.Controls.Add(this.txtMaritalStatus);
            this.grpPersonalDetails.Controls.Add(this.lblMaritalStatus);
            this.grpPersonalDetails.Controls.Add(this.txtBirthPlace);
            this.grpPersonalDetails.Controls.Add(this.lblBirthPlace);
            this.grpPersonalDetails.Controls.Add(this.txtReligion);
            this.grpPersonalDetails.Controls.Add(this.lblReligion);
            this.grpPersonalDetails.Controls.Add(this.txtContactNo);
            this.grpPersonalDetails.Controls.Add(this.lblContactNo);
            this.grpPersonalDetails.Controls.Add(this.txtSex);
            this.grpPersonalDetails.Controls.Add(this.lblSex);
            this.grpPersonalDetails.Controls.Add(this.txtBirthDate);
            this.grpPersonalDetails.Controls.Add(this.lblBirthDate);
            this.grpPersonalDetails.Location = new System.Drawing.Point(402, 238);
            this.grpPersonalDetails.Name = "grpPersonalDetails";
            this.grpPersonalDetails.Size = new System.Drawing.Size(383, 261);
            this.grpPersonalDetails.TabIndex = 25;
            this.grpPersonalDetails.TabStop = false;
            this.grpPersonalDetails.Text = "Personal Details";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(203, 505);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(89, 28);
            this.btnView.TabIndex = 24;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(13, 505);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 28);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.Color.White;
            this.txtMiddleName.Location = new System.Drawing.Point(154, 113);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.ReadOnly = true;
            this.txtMiddleName.Size = new System.Drawing.Size(180, 20);
            this.txtMiddleName.TabIndex = 22;
            this.txtMiddleName.TabStop = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Location = new System.Drawing.Point(154, 77);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(180, 20);
            this.txtFirstName.TabIndex = 21;
            this.txtFirstName.TabStop = false;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(22, 117);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(89, 16);
            this.lblMiddleName.TabIndex = 20;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(22, 81);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 16);
            this.lblFirstName.TabIndex = 19;
            this.lblFirstName.Text = "First Name";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.White;
            this.txtStatus.Location = new System.Drawing.Point(154, 192);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(180, 20);
            this.txtStatus.TabIndex = 16;
            this.txtStatus.TabStop = false;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Location = new System.Drawing.Point(154, 151);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(180, 20);
            this.txtLastName.TabIndex = 14;
            this.txtLastName.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(22, 192);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 16);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(22, 152);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 16);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BackColor = System.Drawing.Color.White;
            this.txtEmployeeID.Location = new System.Drawing.Point(154, 38);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.ReadOnly = true;
            this.txtEmployeeID.Size = new System.Drawing.Size(180, 20);
            this.txtEmployeeID.TabIndex = 0;
            this.txtEmployeeID.TabStop = false;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(22, 42);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(21, 16);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "ID";
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(108, 505);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 28);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // grpEmployeeDetails
            // 
            this.grpEmployeeDetails.Controls.Add(this.txtMiddleName);
            this.grpEmployeeDetails.Controls.Add(this.txtFirstName);
            this.grpEmployeeDetails.Controls.Add(this.lblMiddleName);
            this.grpEmployeeDetails.Controls.Add(this.lblFirstName);
            this.grpEmployeeDetails.Controls.Add(this.txtStatus);
            this.grpEmployeeDetails.Controls.Add(this.txtLastName);
            this.grpEmployeeDetails.Controls.Add(this.lblStatus);
            this.grpEmployeeDetails.Controls.Add(this.lblLastName);
            this.grpEmployeeDetails.Controls.Add(this.txtEmployeeID);
            this.grpEmployeeDetails.Controls.Add(this.lblEmployeeID);
            this.grpEmployeeDetails.Location = new System.Drawing.Point(13, 238);
            this.grpEmployeeDetails.Name = "grpEmployeeDetails";
            this.grpEmployeeDetails.Size = new System.Drawing.Size(383, 261);
            this.grpEmployeeDetails.TabIndex = 21;
            this.grpEmployeeDetails.TabStop = false;
            this.grpEmployeeDetails.Text = "Employee Details";
            // 
            // dataSearch
            // 
            this.dataSearch.AllowUserToAddRows = false;
            this.dataSearch.AllowUserToDeleteRows = false;
            this.dataSearch.AllowUserToResizeColumns = false;
            this.dataSearch.AllowUserToResizeRows = false;
            this.dataSearch.BackgroundColor = System.Drawing.Color.White;
            this.dataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearch.Location = new System.Drawing.Point(13, 67);
            this.dataSearch.Name = "dataSearch";
            this.dataSearch.RowHeadersVisible = false;
            this.dataSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSearch.Size = new System.Drawing.Size(772, 165);
            this.dataSearch.TabIndex = 20;
            this.dataSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSearch_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 20);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // newfrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 545);
            this.Controls.Add(this.lblLoggedinas);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.grpPersonalDetails);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.grpEmployeeDetails);
            this.Controls.Add(this.dataSearch);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "newfrmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management";
            this.Load += new System.EventHandler(this.newfrmEmployee_Load);
            this.grpPersonalDetails.ResumeLayout(false);
            this.grpPersonalDetails.PerformLayout();
            this.grpEmployeeDetails.ResumeLayout(false);
            this.grpEmployeeDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoggedinas;
        private System.Windows.Forms.Button btnDashboard;
        public System.Windows.Forms.TextBox txtMaritalStatus;
        private System.Windows.Forms.Label lblMaritalStatus;
        public System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.Label lblBirthPlace;
        public System.Windows.Forms.TextBox txtReligion;
        private System.Windows.Forms.Label lblReligion;
        public System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label lblContactNo;
        public System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label lblSex;
        public System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.GroupBox grpPersonalDetails;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox txtMiddleName;
        public System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstName;
        public System.Windows.Forms.TextBox txtStatus;
        public System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblLastName;
        public System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox grpEmployeeDetails;
        public System.Windows.Forms.DataGridView dataSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}