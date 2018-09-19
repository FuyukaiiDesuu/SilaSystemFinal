namespace MainSystem
{
    partial class frmOrderList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataOrderList = new System.Windows.Forms.DataGridView();
            this.gboxitemdetails2 = new System.Windows.Forms.GroupBox();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.btnback = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.txtquantity2 = new System.Windows.Forms.TextBox();
            this.txtvendor = new System.Windows.Forms.TextBox();
            this.txtitemname2 = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.lblItemName2 = new System.Windows.Forms.Label();
            this.dataItemCreation = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSilaSchoolManagementSoftware = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrderList)).BeginInit();
            this.gboxitemdetails2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataItemCreation)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataOrderList
            // 
            this.dataOrderList.AllowUserToAddRows = false;
            this.dataOrderList.AllowUserToDeleteRows = false;
            this.dataOrderList.AllowUserToResizeColumns = false;
            this.dataOrderList.AllowUserToResizeRows = false;
            this.dataOrderList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bebas Neue", 13.8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bebas Neue", 13.8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataOrderList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataOrderList.Location = new System.Drawing.Point(6, 6);
            this.dataOrderList.Name = "dataOrderList";
            this.dataOrderList.ReadOnly = true;
            this.dataOrderList.RowHeadersVisible = false;
            this.dataOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOrderList.Size = new System.Drawing.Size(682, 340);
            this.dataOrderList.TabIndex = 0;
            this.dataOrderList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gboxitemdetails2
            // 
            this.gboxitemdetails2.Controls.Add(this.dateDate);
            this.gboxitemdetails2.Controls.Add(this.txtquantity2);
            this.gboxitemdetails2.Controls.Add(this.txtvendor);
            this.gboxitemdetails2.Controls.Add(this.txtitemname2);
            this.gboxitemdetails2.Controls.Add(this.lblQuantity);
            this.gboxitemdetails2.Controls.Add(this.lblVendor);
            this.gboxitemdetails2.Controls.Add(this.lblDate2);
            this.gboxitemdetails2.Controls.Add(this.lblItemName2);
            this.gboxitemdetails2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.gboxitemdetails2.Location = new System.Drawing.Point(6, 334);
            this.gboxitemdetails2.Name = "gboxitemdetails2";
            this.gboxitemdetails2.Size = new System.Drawing.Size(682, 172);
            this.gboxitemdetails2.TabIndex = 1;
            this.gboxitemdetails2.TabStop = false;
            this.gboxitemdetails2.Text = "Item Details";
            // 
            // dateDate
            // 
            this.dateDate.CustomFormat = "yyyy/MM/dd";
            this.dateDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.dateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDate.Location = new System.Drawing.Point(294, 60);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(290, 27);
            this.dateDate.TabIndex = 14;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.DarkRed;
            this.btnback.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.btnback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnback.Location = new System.Drawing.Point(580, 512);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(108, 36);
            this.btnback.TabIndex = 12;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnAdd2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(162)))), ((int)(((byte)(23)))));
            this.btnAdd2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(41)))));
            this.btnAdd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd2.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.btnAdd2.Location = new System.Drawing.Point(466, 512);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(108, 36);
            this.btnAdd2.TabIndex = 10;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = false;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // txtquantity2
            // 
            this.txtquantity2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtquantity2.Location = new System.Drawing.Point(294, 126);
            this.txtquantity2.Name = "txtquantity2";
            this.txtquantity2.Size = new System.Drawing.Size(290, 27);
            this.txtquantity2.TabIndex = 9;
            // 
            // txtvendor
            // 
            this.txtvendor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtvendor.Location = new System.Drawing.Point(294, 93);
            this.txtvendor.Name = "txtvendor";
            this.txtvendor.Size = new System.Drawing.Size(290, 27);
            this.txtvendor.TabIndex = 8;
            // 
            // txtitemname2
            // 
            this.txtitemname2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtitemname2.Location = new System.Drawing.Point(294, 27);
            this.txtitemname2.Name = "txtitemname2";
            this.txtitemname2.Size = new System.Drawing.Size(290, 27);
            this.txtitemname2.TabIndex = 5;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(138, 134);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(75, 19);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblVendor.ForeColor = System.Drawing.Color.White;
            this.lblVendor.Location = new System.Drawing.Point(138, 101);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(66, 19);
            this.lblVendor.TabIndex = 3;
            this.lblVendor.Text = "Vendor:";
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblDate2.ForeColor = System.Drawing.Color.White;
            this.lblDate2.Location = new System.Drawing.Point(138, 68);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(47, 19);
            this.lblDate2.TabIndex = 1;
            this.lblDate2.Text = "Date:";
            this.lblDate2.Click += new System.EventHandler(this.lblDate2_Click);
            // 
            // lblItemName2
            // 
            this.lblItemName2.AutoSize = true;
            this.lblItemName2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblItemName2.ForeColor = System.Drawing.Color.White;
            this.lblItemName2.Location = new System.Drawing.Point(138, 35);
            this.lblItemName2.Name = "lblItemName2";
            this.lblItemName2.Size = new System.Drawing.Size(94, 19);
            this.lblItemName2.TabIndex = 0;
            this.lblItemName2.Text = "Item Name:";
            // 
            // dataItemCreation
            // 
            this.dataItemCreation.AllowUserToAddRows = false;
            this.dataItemCreation.AllowUserToDeleteRows = false;
            this.dataItemCreation.AllowUserToResizeColumns = false;
            this.dataItemCreation.AllowUserToResizeRows = false;
            this.dataItemCreation.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bebas Neue", 13.8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataItemCreation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataItemCreation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bebas Neue", 13.8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataItemCreation.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataItemCreation.Location = new System.Drawing.Point(6, 6);
            this.dataItemCreation.Name = "dataItemCreation";
            this.dataItemCreation.ReadOnly = true;
            this.dataItemCreation.RowHeadersVisible = false;
            this.dataItemCreation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataItemCreation.Size = new System.Drawing.Size(682, 322);
            this.dataItemCreation.TabIndex = 3;
            this.dataItemCreation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataItemCreation_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Bebas Neue", 14.25F);
            this.tabControl1.Location = new System.Drawing.Point(12, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 591);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.tabPage1.Controls.Add(this.dataItemCreation);
            this.tabPage1.Controls.Add(this.btnback);
            this.tabPage1.Controls.Add(this.gboxitemdetails2);
            this.tabPage1.Controls.Add(this.btnAdd2);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(699, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Item Creation";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.tabPage2.Controls.Add(this.btnCancel);
            this.tabPage2.Controls.Add(this.dataOrderList);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(699, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order List";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnCancel.Location = new System.Drawing.Point(580, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 36);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblSilaSchoolManagementSoftware);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 34);
            this.panel1.TabIndex = 45;
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
            this.lblSilaSchoolManagementSoftware.Font = new System.Drawing.Font("Bebas Neue", 13.8F, System.Drawing.FontStyle.Italic);
            this.lblSilaSchoolManagementSoftware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lblSilaSchoolManagementSoftware.Location = new System.Drawing.Point(51, 8);
            this.lblSilaSchoolManagementSoftware.Name = "lblSilaSchoolManagementSoftware";
            this.lblSilaSchoolManagementSoftware.Size = new System.Drawing.Size(403, 23);
            this.lblSilaSchoolManagementSoftware.TabIndex = 0;
            this.lblSilaSchoolManagementSoftware.Text = "INVENTORY MANAGEMENT - S.I.L.A SCHOOL MANAGEMENT SOFTWARE";
            // 
            // frmOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(732, 674);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(748, 713);
            this.Name = "frmOrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrderList";
            this.Load += new System.EventHandler(this.frmOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOrderList)).EndInit();
            this.gboxitemdetails2.ResumeLayout(false);
            this.gboxitemdetails2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataItemCreation)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataOrderList;
        private System.Windows.Forms.GroupBox gboxitemdetails2;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Label lblItemName2;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.TextBox txtquantity2;
        private System.Windows.Forms.TextBox txtvendor;
        private System.Windows.Forms.TextBox txtitemname2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DateTimePicker dateDate;
        private System.Windows.Forms.DataGridView dataItemCreation;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSilaSchoolManagementSoftware;
    }
}