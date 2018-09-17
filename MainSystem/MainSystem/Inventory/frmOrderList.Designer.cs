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
            this.dataOrderList = new System.Windows.Forms.DataGridView();
            this.gboxitemdetails2 = new System.Windows.Forms.GroupBox();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.btnback = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.txtquantity2 = new System.Windows.Forms.TextBox();
            this.txtvendor = new System.Windows.Forms.TextBox();
            this.txtdatereq = new System.Windows.Forms.TextBox();
            this.txtitemname2 = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lbldateReq = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.lblItemName2 = new System.Windows.Forms.Label();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.dataItemCreation = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrderList)).BeginInit();
            this.gboxitemdetails2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataItemCreation)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataOrderList
            // 
            this.dataOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrderList.Location = new System.Drawing.Point(6, 6);
            this.dataOrderList.Name = "dataOrderList";
            this.dataOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOrderList.Size = new System.Drawing.Size(682, 340);
            this.dataOrderList.TabIndex = 0;
            this.dataOrderList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gboxitemdetails2
            // 
            this.gboxitemdetails2.Controls.Add(this.dateDate);
            this.gboxitemdetails2.Controls.Add(this.btnback);
            this.gboxitemdetails2.Controls.Add(this.btnAdd2);
            this.gboxitemdetails2.Controls.Add(this.txtquantity2);
            this.gboxitemdetails2.Controls.Add(this.txtvendor);
            this.gboxitemdetails2.Controls.Add(this.txtdatereq);
            this.gboxitemdetails2.Controls.Add(this.txtitemname2);
            this.gboxitemdetails2.Controls.Add(this.lblQuantity);
            this.gboxitemdetails2.Controls.Add(this.lblVendor);
            this.gboxitemdetails2.Controls.Add(this.lbldateReq);
            this.gboxitemdetails2.Controls.Add(this.lblDate2);
            this.gboxitemdetails2.Controls.Add(this.lblItemName2);
            this.gboxitemdetails2.Location = new System.Drawing.Point(6, 334);
            this.gboxitemdetails2.Name = "gboxitemdetails2";
            this.gboxitemdetails2.Size = new System.Drawing.Size(682, 213);
            this.gboxitemdetails2.TabIndex = 1;
            this.gboxitemdetails2.TabStop = false;
            this.gboxitemdetails2.Text = "Item Details";
            // 
            // dateDate
            // 
            this.dateDate.CustomFormat = "yyyy/MM/dd";
            this.dateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDate.Location = new System.Drawing.Point(91, 60);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(100, 20);
            this.dateDate.TabIndex = 14;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(87, 184);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 12;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(6, 184);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(75, 23);
            this.btnAdd2.TabIndex = 10;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // txtquantity2
            // 
            this.txtquantity2.Location = new System.Drawing.Point(91, 137);
            this.txtquantity2.Name = "txtquantity2";
            this.txtquantity2.Size = new System.Drawing.Size(100, 20);
            this.txtquantity2.TabIndex = 9;
            // 
            // txtvendor
            // 
            this.txtvendor.Location = new System.Drawing.Point(91, 112);
            this.txtvendor.Name = "txtvendor";
            this.txtvendor.Size = new System.Drawing.Size(100, 20);
            this.txtvendor.TabIndex = 8;
            // 
            // txtdatereq
            // 
            this.txtdatereq.Location = new System.Drawing.Point(91, 86);
            this.txtdatereq.Name = "txtdatereq";
            this.txtdatereq.Size = new System.Drawing.Size(100, 20);
            this.txtdatereq.TabIndex = 7;
            // 
            // txtitemname2
            // 
            this.txtitemname2.Location = new System.Drawing.Point(91, 31);
            this.txtitemname2.Name = "txtitemname2";
            this.txtitemname2.Size = new System.Drawing.Size(100, 20);
            this.txtitemname2.TabIndex = 5;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(6, 137);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Location = new System.Drawing.Point(6, 114);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(44, 13);
            this.lblVendor.TabIndex = 3;
            this.lblVendor.Text = "Vendor:";
            // 
            // lbldateReq
            // 
            this.lbldateReq.AutoSize = true;
            this.lbldateReq.Location = new System.Drawing.Point(6, 85);
            this.lbldateReq.Name = "lbldateReq";
            this.lbldateReq.Size = new System.Drawing.Size(79, 13);
            this.lbldateReq.TabIndex = 2;
            this.lbldateReq.Text = "Date Required:";
            this.lbldateReq.Click += new System.EventHandler(this.lbldateReq_Click);
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Location = new System.Drawing.Point(6, 62);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(33, 13);
            this.lblDate2.TabIndex = 1;
            this.lblDate2.Text = "Date:";
            this.lblDate2.Click += new System.EventHandler(this.lblDate2_Click);
            // 
            // lblItemName2
            // 
            this.lblItemName2.AutoSize = true;
            this.lblItemName2.Location = new System.Drawing.Point(6, 34);
            this.lblItemName2.Name = "lblItemName2";
            this.lblItemName2.Size = new System.Drawing.Size(61, 13);
            this.lblItemName2.TabIndex = 0;
            this.lblItemName2.Text = "Item Name:";
            // 
            // lblOrderList
            // 
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderList.Location = new System.Drawing.Point(302, 21);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(101, 24);
            this.lblOrderList.TabIndex = 2;
            this.lblOrderList.Text = "Order List";
            // 
            // dataItemCreation
            // 
            this.dataItemCreation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataItemCreation.Location = new System.Drawing.Point(6, 6);
            this.dataItemCreation.Name = "dataItemCreation";
            this.dataItemCreation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataItemCreation.Size = new System.Drawing.Size(682, 322);
            this.dataItemCreation.TabIndex = 3;
            this.dataItemCreation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataItemCreation_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(702, 579);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataItemCreation);
            this.tabPage1.Controls.Add(this.gboxitemdetails2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(694, 553);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Item Creation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCancel);
            this.tabPage2.Controls.Add(this.dataOrderList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(694, 553);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(6, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 639);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblOrderList);
            this.Name = "frmOrderList";
            this.Text = "frmOrderList";
            this.Load += new System.EventHandler(this.frmOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOrderList)).EndInit();
            this.gboxitemdetails2.ResumeLayout(false);
            this.gboxitemdetails2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataItemCreation)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataOrderList;
        private System.Windows.Forms.GroupBox gboxitemdetails2;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Label lblItemName2;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lbldateReq;
        private System.Windows.Forms.Label lblOrderList;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.TextBox txtquantity2;
        private System.Windows.Forms.TextBox txtvendor;
        private System.Windows.Forms.TextBox txtdatereq;
        private System.Windows.Forms.TextBox txtitemname2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DateTimePicker dateDate;
        private System.Windows.Forms.DataGridView dataItemCreation;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancel;
    }
}