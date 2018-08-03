﻿namespace MainSystem
{
    partial class FormInventory
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
            this.gboxitemdetails = new System.Windows.Forms.GroupBox();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.txtsodate = new System.Windows.Forms.TextBox();
            this.lblsodate = new System.Windows.Forms.Label();
            this.txtinvcode = new System.Windows.Forms.TextBox();
            this.lblinvcode = new System.Windows.Forms.Label();
            this.btnStockInOut = new System.Windows.Forms.Button();
            this.txtsidate = new System.Windows.Forms.TextBox();
            this.lblsidate = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.gboxitemdetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxitemdetails
            // 
            this.gboxitemdetails.Controls.Add(this.txtstatus);
            this.gboxitemdetails.Controls.Add(this.lblstatus);
            this.gboxitemdetails.Controls.Add(this.txtsodate);
            this.gboxitemdetails.Controls.Add(this.lblsodate);
            this.gboxitemdetails.Controls.Add(this.txtinvcode);
            this.gboxitemdetails.Controls.Add(this.lblinvcode);
            this.gboxitemdetails.Controls.Add(this.btnStockInOut);
            this.gboxitemdetails.Controls.Add(this.btnOrderList);
            this.gboxitemdetails.Controls.Add(this.txtsidate);
            this.gboxitemdetails.Controls.Add(this.lblsidate);
            this.gboxitemdetails.Controls.Add(this.txtQuantity);
            this.gboxitemdetails.Controls.Add(this.txtItemCode);
            this.gboxitemdetails.Controls.Add(this.lblQuantity);
            this.gboxitemdetails.Controls.Add(this.lblItemCode);
            this.gboxitemdetails.Location = new System.Drawing.Point(12, 46);
            this.gboxitemdetails.Name = "gboxitemdetails";
            this.gboxitemdetails.Size = new System.Drawing.Size(359, 242);
            this.gboxitemdetails.TabIndex = 0;
            this.gboxitemdetails.TabStop = false;
            this.gboxitemdetails.Text = "Inventory Details";
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(98, 174);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(251, 20);
            this.txtstatus.TabIndex = 28;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(52, 174);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(40, 13);
            this.lblstatus.TabIndex = 27;
            this.lblstatus.Text = "Status:";
            // 
            // txtsodate
            // 
            this.txtsodate.Location = new System.Drawing.Point(98, 124);
            this.txtsodate.Name = "txtsodate";
            this.txtsodate.Size = new System.Drawing.Size(251, 20);
            this.txtsodate.TabIndex = 26;
            // 
            // lblsodate
            // 
            this.lblsodate.AutoSize = true;
            this.lblsodate.Location = new System.Drawing.Point(13, 127);
            this.lblsodate.Name = "lblsodate";
            this.lblsodate.Size = new System.Drawing.Size(82, 13);
            this.lblsodate.TabIndex = 25;
            this.lblsodate.Text = "Stock-out Date:";
            this.lblsodate.Click += new System.EventHandler(this.lblsodate_Click);
            // 
            // txtinvcode
            // 
            this.txtinvcode.Location = new System.Drawing.Point(100, 33);
            this.txtinvcode.Name = "txtinvcode";
            this.txtinvcode.Size = new System.Drawing.Size(249, 20);
            this.txtinvcode.TabIndex = 24;
            // 
            // lblinvcode
            // 
            this.lblinvcode.AutoSize = true;
            this.lblinvcode.Location = new System.Drawing.Point(13, 36);
            this.lblinvcode.Name = "lblinvcode";
            this.lblinvcode.Size = new System.Drawing.Size(82, 13);
            this.lblinvcode.TabIndex = 23;
            this.lblinvcode.Text = "Inventory Code:";
            // 
            // btnStockInOut
            // 
            this.btnStockInOut.Location = new System.Drawing.Point(115, 208);
            this.btnStockInOut.Name = "btnStockInOut";
            this.btnStockInOut.Size = new System.Drawing.Size(87, 23);
            this.btnStockInOut.TabIndex = 22;
            this.btnStockInOut.Text = "Stock- in/Out";
            this.btnStockInOut.UseVisualStyleBackColor = true;
            this.btnStockInOut.Click += new System.EventHandler(this.btnStockInOut_Click);
            // 
            // txtsidate
            // 
            this.txtsidate.Location = new System.Drawing.Point(98, 92);
            this.txtsidate.Name = "txtsidate";
            this.txtsidate.Size = new System.Drawing.Size(251, 20);
            this.txtsidate.TabIndex = 20;
            // 
            // lblsidate
            // 
            this.lblsidate.AutoSize = true;
            this.lblsidate.Location = new System.Drawing.Point(20, 95);
            this.lblsidate.Name = "lblsidate";
            this.lblsidate.Size = new System.Drawing.Size(75, 13);
            this.lblsidate.TabIndex = 19;
            this.lblsidate.Text = "Stock-in Date:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(98, 148);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(251, 20);
            this.txtQuantity.TabIndex = 18;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(98, 59);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(251, 20);
            this.txtItemCode.TabIndex = 13;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(43, 151);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(37, 66);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(58, 13);
            this.lblItemCode.TabIndex = 0;
            this.lblItemCode.Text = "Item Code:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Item Management";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(377, 49);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.Size = new System.Drawing.Size(761, 239);
            this.dgvInventory.TabIndex = 1;
            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(1050, 14);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(88, 29);
            this.btnDashboard.TabIndex = 21;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Item Inventory";
            // 
            // btnOrderList
            // 
            this.btnOrderList.Location = new System.Drawing.Point(10, 208);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(99, 23);
            this.btnOrderList.TabIndex = 21;
            this.btnOrderList.Text = "Create Order List";
            this.btnOrderList.UseVisualStyleBackColor = true;
            this.btnOrderList.Click += new System.EventHandler(this.btnOrderList_Click);
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gboxitemdetails);
            this.Name = "FormInventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            this.gboxitemdetails.ResumeLayout(false);
            this.gboxitemdetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxitemdetails;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Label lblsidate;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnStockInOut;
        private System.Windows.Forms.TextBox txtinvcode;
        private System.Windows.Forms.Label lblinvcode;
        private System.Windows.Forms.Label lblsodate;
        private System.Windows.Forms.TextBox txtsidate;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.TextBox txtsodate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrderList;
    }
}