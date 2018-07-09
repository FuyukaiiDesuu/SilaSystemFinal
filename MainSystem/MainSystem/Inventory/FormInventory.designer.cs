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
            this.btnStockInOut = new System.Windows.Forms.Button();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.lblsidate = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblinvcode = new System.Windows.Forms.Label();
            this.txtinvcode = new System.Windows.Forms.TextBox();
            this.txtsidate = new System.Windows.Forms.TextBox();
            this.lblsodate = new System.Windows.Forms.Label();
            this.txtsodate = new System.Windows.Forms.TextBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.TextBox();
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
            this.gboxitemdetails.Controls.Add(this.btnView);
            this.gboxitemdetails.Controls.Add(this.btnUpdate);
            this.gboxitemdetails.Controls.Add(this.btnAdd);
            this.gboxitemdetails.Controls.Add(this.lblQuantity);
            this.gboxitemdetails.Controls.Add(this.lblItemCode);
            this.gboxitemdetails.Location = new System.Drawing.Point(12, 46);
            this.gboxitemdetails.Name = "gboxitemdetails";
            this.gboxitemdetails.Size = new System.Drawing.Size(365, 271);
            this.gboxitemdetails.TabIndex = 0;
            this.gboxitemdetails.TabStop = false;
            this.gboxitemdetails.Text = "Item Details";
            // 
            // btnStockInOut
            // 
            this.btnStockInOut.Location = new System.Drawing.Point(133, 237);
            this.btnStockInOut.Name = "btnStockInOut";
            this.btnStockInOut.Size = new System.Drawing.Size(87, 23);
            this.btnStockInOut.TabIndex = 22;
            this.btnStockInOut.Text = "Stock- in/Out";
            this.btnStockInOut.UseVisualStyleBackColor = true;
            this.btnStockInOut.Click += new System.EventHandler(this.btnStockInOut_Click);
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
            // lblsidate
            // 
            this.lblsidate.AutoSize = true;
            this.lblsidate.Location = new System.Drawing.Point(17, 99);
            this.lblsidate.Name = "lblsidate";
            this.lblsidate.Size = new System.Drawing.Size(75, 13);
            this.lblsidate.TabIndex = 19;
            this.lblsidate.Text = "Stock-in Date:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(64, 150);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(251, 20);
            this.txtQuantity.TabIndex = 18;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(80, 70);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(251, 20);
            this.txtItemCode.TabIndex = 13;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(277, 208);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(196, 208);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(115, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(13, 151);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(22, 70);
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
            this.dgvInventory.Size = new System.Drawing.Size(746, 271);
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
            // lblinvcode
            // 
            this.lblinvcode.AutoSize = true;
            this.lblinvcode.Location = new System.Drawing.Point(19, 36);
            this.lblinvcode.Name = "lblinvcode";
            this.lblinvcode.Size = new System.Drawing.Size(82, 13);
            this.lblinvcode.TabIndex = 23;
            this.lblinvcode.Text = "Inventory Code:";
            // 
            // txtinvcode
            // 
            this.txtinvcode.Location = new System.Drawing.Point(100, 33);
            this.txtinvcode.Name = "txtinvcode";
            this.txtinvcode.Size = new System.Drawing.Size(231, 20);
            this.txtinvcode.TabIndex = 24;
            // 
            // txtsidate
            // 
            this.txtsidate.Location = new System.Drawing.Point(98, 96);
            this.txtsidate.Name = "txtsidate";
            this.txtsidate.Size = new System.Drawing.Size(217, 20);
            this.txtsidate.TabIndex = 20;
            // 
            // lblsodate
            // 
            this.lblsodate.AutoSize = true;
            this.lblsodate.Location = new System.Drawing.Point(12, 127);
            this.lblsodate.Name = "lblsodate";
            this.lblsodate.Size = new System.Drawing.Size(82, 13);
            this.lblsodate.TabIndex = 25;
            this.lblsodate.Text = "Stock-out Date:";
            this.lblsodate.Click += new System.EventHandler(this.lblsodate_Click);
            // 
            // txtsodate
            // 
            this.txtsodate.Location = new System.Drawing.Point(98, 124);
            this.txtsodate.Name = "txtsodate";
            this.txtsodate.Size = new System.Drawing.Size(217, 20);
            this.txtsodate.TabIndex = 26;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(18, 179);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(40, 13);
            this.lblstatus.TabIndex = 27;
            this.lblstatus.Text = "Status:";
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(64, 176);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(251, 20);
            this.txtstatus.TabIndex = 28;
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 336);
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
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Label lblsidate;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnOrderList;
        private System.Windows.Forms.Button btnStockInOut;
        private System.Windows.Forms.TextBox txtinvcode;
        private System.Windows.Forms.Label lblinvcode;
        private System.Windows.Forms.Label lblsodate;
        private System.Windows.Forms.TextBox txtsidate;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.TextBox txtsodate;
    }
}