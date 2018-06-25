namespace MainSystem
{
    partial class frmMain
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
            this.lblSilaSchoolManagementSoftware = new System.Windows.Forms.Label();
            this.btnUserForm = new System.Windows.Forms.Button();
            this.btnInventoryForm = new System.Windows.Forms.Button();
            this.btnEmployeeForm = new System.Windows.Forms.Button();
            this.btnEnrollmentForm = new System.Windows.Forms.Button();
            this.btnAccountForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSilaSchoolManagementSoftware
            // 
            this.lblSilaSchoolManagementSoftware.AutoSize = true;
            this.lblSilaSchoolManagementSoftware.Font = new System.Drawing.Font("Broadway", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSilaSchoolManagementSoftware.Location = new System.Drawing.Point(56, 44);
            this.lblSilaSchoolManagementSoftware.Name = "lblSilaSchoolManagementSoftware";
            this.lblSilaSchoolManagementSoftware.Size = new System.Drawing.Size(689, 32);
            this.lblSilaSchoolManagementSoftware.TabIndex = 0;
            this.lblSilaSchoolManagementSoftware.Text = "S.I.L.A SCHOOL MANAGEMENT SOFTWARE";
            // 
            // btnUserForm
            // 
            this.btnUserForm.BackgroundImage = global::MainSystem.Properties.Resources.user;
            this.btnUserForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUserForm.FlatAppearance.BorderSize = 0;
            this.btnUserForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserForm.Location = new System.Drawing.Point(453, 317);
            this.btnUserForm.Name = "btnUserForm";
            this.btnUserForm.Size = new System.Drawing.Size(167, 141);
            this.btnUserForm.TabIndex = 5;
            this.btnUserForm.UseVisualStyleBackColor = true;
            // 
            // btnInventoryForm
            // 
            this.btnInventoryForm.BackgroundImage = global::MainSystem.Properties.Resources.shopping_list;
            this.btnInventoryForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInventoryForm.FlatAppearance.BorderSize = 0;
            this.btnInventoryForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryForm.Location = new System.Drawing.Point(173, 317);
            this.btnInventoryForm.Name = "btnInventoryForm";
            this.btnInventoryForm.Size = new System.Drawing.Size(167, 141);
            this.btnInventoryForm.TabIndex = 4;
            this.btnInventoryForm.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeForm
            // 
            this.btnEmployeeForm.BackgroundImage = global::MainSystem.Properties.Resources.employees;
            this.btnEmployeeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmployeeForm.FlatAppearance.BorderSize = 0;
            this.btnEmployeeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeForm.Location = new System.Drawing.Point(589, 124);
            this.btnEmployeeForm.Name = "btnEmployeeForm";
            this.btnEmployeeForm.Size = new System.Drawing.Size(167, 141);
            this.btnEmployeeForm.TabIndex = 3;
            this.btnEmployeeForm.UseVisualStyleBackColor = true;
            this.btnEmployeeForm.Click += new System.EventHandler(this.btnEmployeeForm_Click);
            // 
            // btnEnrollmentForm
            // 
            this.btnEnrollmentForm.BackgroundImage = global::MainSystem.Properties.Resources.edit;
            this.btnEnrollmentForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnrollmentForm.FlatAppearance.BorderSize = 0;
            this.btnEnrollmentForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrollmentForm.Location = new System.Drawing.Point(314, 124);
            this.btnEnrollmentForm.Name = "btnEnrollmentForm";
            this.btnEnrollmentForm.Size = new System.Drawing.Size(167, 141);
            this.btnEnrollmentForm.TabIndex = 2;
            this.btnEnrollmentForm.UseVisualStyleBackColor = true;
            this.btnEnrollmentForm.Click += new System.EventHandler(this.btnEnrollmentForm_Click);
            // 
            // btnAccountForm
            // 
            this.btnAccountForm.BackgroundImage = global::MainSystem.Properties.Resources.money;
            this.btnAccountForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAccountForm.FlatAppearance.BorderSize = 0;
            this.btnAccountForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountForm.Location = new System.Drawing.Point(40, 124);
            this.btnAccountForm.Name = "btnAccountForm";
            this.btnAccountForm.Size = new System.Drawing.Size(167, 141);
            this.btnAccountForm.TabIndex = 1;
            this.btnAccountForm.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 515);
            this.Controls.Add(this.lblSilaSchoolManagementSoftware);
            this.Controls.Add(this.btnUserForm);
            this.Controls.Add(this.btnInventoryForm);
            this.Controls.Add(this.btnEmployeeForm);
            this.Controls.Add(this.btnEnrollmentForm);
            this.Controls.Add(this.btnAccountForm);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccountForm;
        private System.Windows.Forms.Button btnEnrollmentForm;
        private System.Windows.Forms.Button btnEmployeeForm;
        private System.Windows.Forms.Button btnInventoryForm;
        private System.Windows.Forms.Button btnUserForm;
        private System.Windows.Forms.Label lblSilaSchoolManagementSoftware;
    }
}