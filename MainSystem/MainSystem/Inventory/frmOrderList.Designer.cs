﻿namespace MainSystem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gboxitemdetails2 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.txtquantity2 = new System.Windows.Forms.TextBox();
            this.txtvendor = new System.Windows.Forms.TextBox();
            this.txtdatereq = new System.Windows.Forms.TextBox();
            this.txtdate2 = new System.Windows.Forms.TextBox();
            this.txtitemname2 = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lbldateReq = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.lblItemName2 = new System.Windows.Forms.Label();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gboxitemdetails2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(362, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // gboxitemdetails2
            // 
            this.gboxitemdetails2.Controls.Add(this.btnback);
            this.gboxitemdetails2.Controls.Add(this.btnRemove);
            this.gboxitemdetails2.Controls.Add(this.btnAdd2);
            this.gboxitemdetails2.Controls.Add(this.txtquantity2);
            this.gboxitemdetails2.Controls.Add(this.txtvendor);
            this.gboxitemdetails2.Controls.Add(this.txtdatereq);
            this.gboxitemdetails2.Controls.Add(this.txtdate2);
            this.gboxitemdetails2.Controls.Add(this.txtitemname2);
            this.gboxitemdetails2.Controls.Add(this.lblQuantity);
            this.gboxitemdetails2.Controls.Add(this.lblVendor);
            this.gboxitemdetails2.Controls.Add(this.lbldateReq);
            this.gboxitemdetails2.Controls.Add(this.lblDate2);
            this.gboxitemdetails2.Controls.Add(this.lblItemName2);
            this.gboxitemdetails2.Location = new System.Drawing.Point(12, 80);
            this.gboxitemdetails2.Name = "gboxitemdetails2";
            this.gboxitemdetails2.Size = new System.Drawing.Size(334, 341);
            this.gboxitemdetails2.TabIndex = 1;
            this.gboxitemdetails2.TabStop = false;
            this.gboxitemdetails2.Text = "Item Details";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(100, 178);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(19, 178);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(75, 23);
            this.btnAdd2.TabIndex = 10;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = true;
            // 
            // txtquantity2
            // 
            this.txtquantity2.Location = new System.Drawing.Point(61, 137);
            this.txtquantity2.Name = "txtquantity2";
            this.txtquantity2.Size = new System.Drawing.Size(100, 20);
            this.txtquantity2.TabIndex = 9;
            // 
            // txtvendor
            // 
            this.txtvendor.Location = new System.Drawing.Point(56, 111);
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
            // txtdate2
            // 
            this.txtdate2.Location = new System.Drawing.Point(45, 60);
            this.txtdate2.Name = "txtdate2";
            this.txtdate2.Size = new System.Drawing.Size(100, 20);
            this.txtdate2.TabIndex = 6;
            // 
            // txtitemname2
            // 
            this.txtitemname2.Location = new System.Drawing.Point(73, 31);
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
            this.lblOrderList.Location = new System.Drawing.Point(370, 53);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(101, 24);
            this.lblOrderList.TabIndex = 2;
            this.lblOrderList.Text = "Order List";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(181, 178);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 12;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // frmOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 450);
            this.Controls.Add(this.lblOrderList);
            this.Controls.Add(this.gboxitemdetails2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmOrderList";
            this.Text = "frmOrderList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gboxitemdetails2.ResumeLayout(false);
            this.gboxitemdetails2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gboxitemdetails2;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Label lblItemName2;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lbldateReq;
        private System.Windows.Forms.Label lblOrderList;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.TextBox txtquantity2;
        private System.Windows.Forms.TextBox txtvendor;
        private System.Windows.Forms.TextBox txtdatereq;
        private System.Windows.Forms.TextBox txtdate2;
        private System.Windows.Forms.TextBox txtitemname2;
        private System.Windows.Forms.Button btnback;
    }
}