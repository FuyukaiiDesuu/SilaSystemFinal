namespace MainSystem
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
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.btnStockInOut = new System.Windows.Forms.Button();
            this.gboxitemdetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxitemdetails
            // 
            this.gboxitemdetails.Controls.Add(this.btnStockInOut);
            this.gboxitemdetails.Controls.Add(this.btnOrderList);
            this.gboxitemdetails.Controls.Add(this.txtDate);
            this.gboxitemdetails.Controls.Add(this.lblDate);
            this.gboxitemdetails.Controls.Add(this.txtQuantity);
            this.gboxitemdetails.Controls.Add(this.txtPrice);
            this.gboxitemdetails.Controls.Add(this.txtDesc);
            this.gboxitemdetails.Controls.Add(this.txtItemName);
            this.gboxitemdetails.Controls.Add(this.txtItemCode);
            this.gboxitemdetails.Controls.Add(this.btnView);
            this.gboxitemdetails.Controls.Add(this.btnUpdate);
            this.gboxitemdetails.Controls.Add(this.btnAdd);
            this.gboxitemdetails.Controls.Add(this.lblQuantity);
            this.gboxitemdetails.Controls.Add(this.lblPrice);
            this.gboxitemdetails.Controls.Add(this.lblDesc);
            this.gboxitemdetails.Controls.Add(this.lblItemName);
            this.gboxitemdetails.Controls.Add(this.lblItemCode);
            this.gboxitemdetails.Location = new System.Drawing.Point(12, 46);
            this.gboxitemdetails.Name = "gboxitemdetails";
            this.gboxitemdetails.Size = new System.Drawing.Size(365, 321);
            this.gboxitemdetails.TabIndex = 0;
            this.gboxitemdetails.TabStop = false;
            this.gboxitemdetails.Text = "Item Details";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(80, 112);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(251, 20);
            this.txtDate.TabIndex = 20;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(33, 115);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Date:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(80, 233);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(251, 20);
            this.txtQuantity.TabIndex = 18;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(80, 199);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(251, 20);
            this.txtPrice.TabIndex = 17;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(80, 147);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(251, 35);
            this.txtDesc.TabIndex = 16;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(80, 76);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(251, 20);
            this.txtItemName.TabIndex = 14;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(80, 41);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(251, 20);
            this.txtItemCode.TabIndex = 13;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(277, 259);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(196, 259);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(115, 259);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(22, 233);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(32, 202);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(17, 157);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Description:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(19, 76);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(61, 13);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name:";
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(22, 41);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(58, 13);
            this.lblItemCode.TabIndex = 0;
            this.lblItemCode.Text = "Item Code:";
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(387, 46);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.Size = new System.Drawing.Size(746, 321);
            this.dgvInventory.TabIndex = 1;
            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(1045, 11);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(88, 29);
            this.btnDashboard.TabIndex = 21;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnOrderList
            // 
            this.btnOrderList.Location = new System.Drawing.Point(10, 259);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(99, 23);
            this.btnOrderList.TabIndex = 21;
            this.btnOrderList.Text = "Create Order List";
            this.btnOrderList.UseVisualStyleBackColor = true;
            this.btnOrderList.Click += new System.EventHandler(this.btnOrderList_Click);
            // 
            // btnStockInOut
            // 
            this.btnStockInOut.Location = new System.Drawing.Point(133, 288);
            this.btnStockInOut.Name = "btnStockInOut";
            this.btnStockInOut.Size = new System.Drawing.Size(87, 23);
            this.btnStockInOut.TabIndex = 22;
            this.btnStockInOut.Text = "Stock- in/Out";
            this.btnStockInOut.UseVisualStyleBackColor = true;
            this.btnStockInOut.Click += new System.EventHandler(this.btnStockInOut_Click);
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 376);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.gboxitemdetails);
            this.Name = "FormInventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            this.gboxitemdetails.ResumeLayout(false);
            this.gboxitemdetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxitemdetails;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnOrderList;
        private System.Windows.Forms.Button btnStockInOut;
    }
}