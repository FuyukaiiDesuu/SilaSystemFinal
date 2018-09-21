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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gboxitemdetails = new System.Windows.Forms.GroupBox();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.txtsodate = new System.Windows.Forms.TextBox();
            this.lblsodate = new System.Windows.Forms.Label();
            this.txtsidate = new System.Windows.Forms.TextBox();
            this.lblsidate = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStockInOut = new System.Windows.Forms.Button();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSilaSchoolManagementSoftware = new System.Windows.Forms.Label();
            this.gboxitemdetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxitemdetails
            // 
            this.gboxitemdetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gboxitemdetails.Controls.Add(this.txtstatus);
            this.gboxitemdetails.Controls.Add(this.lblstatus);
            this.gboxitemdetails.Controls.Add(this.txtsodate);
            this.gboxitemdetails.Controls.Add(this.lblsodate);
            this.gboxitemdetails.Controls.Add(this.txtsidate);
            this.gboxitemdetails.Controls.Add(this.lblsidate);
            this.gboxitemdetails.Controls.Add(this.txtQuantity);
            this.gboxitemdetails.Controls.Add(this.txtItemCode);
            this.gboxitemdetails.Controls.Add(this.lblQuantity);
            this.gboxitemdetails.Controls.Add(this.lblItemCode);
            this.gboxitemdetails.Font = new System.Drawing.Font("Bebas Neue", 14.25F);
            this.gboxitemdetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.gboxitemdetails.Location = new System.Drawing.Point(12, 371);
            this.gboxitemdetails.Name = "gboxitemdetails";
            this.gboxitemdetails.Size = new System.Drawing.Size(761, 231);
            this.gboxitemdetails.TabIndex = 0;
            this.gboxitemdetails.TabStop = false;
            this.gboxitemdetails.Text = "Inventory Details";
            // 
            // txtstatus
            // 
            this.txtstatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtstatus.Location = new System.Drawing.Point(342, 180);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.ReadOnly = true;
            this.txtstatus.Size = new System.Drawing.Size(251, 27);
            this.txtstatus.TabIndex = 28;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblstatus.ForeColor = System.Drawing.Color.White;
            this.lblstatus.Location = new System.Drawing.Point(209, 187);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(58, 19);
            this.lblstatus.TabIndex = 27;
            this.lblstatus.Text = "Status:";
            // 
            // txtsodate
            // 
            this.txtsodate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtsodate.Location = new System.Drawing.Point(342, 108);
            this.txtsodate.Name = "txtsodate";
            this.txtsodate.ReadOnly = true;
            this.txtsodate.Size = new System.Drawing.Size(251, 27);
            this.txtsodate.TabIndex = 26;
            // 
            // lblsodate
            // 
            this.lblsodate.AutoSize = true;
            this.lblsodate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblsodate.ForeColor = System.Drawing.Color.White;
            this.lblsodate.Location = new System.Drawing.Point(209, 115);
            this.lblsodate.Name = "lblsodate";
            this.lblsodate.Size = new System.Drawing.Size(119, 19);
            this.lblsodate.TabIndex = 25;
            this.lblsodate.Text = "Stock-out Date:";
            this.lblsodate.Click += new System.EventHandler(this.lblsodate_Click);
            // 
            // txtsidate
            // 
            this.txtsidate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtsidate.Location = new System.Drawing.Point(342, 72);
            this.txtsidate.Name = "txtsidate";
            this.txtsidate.ReadOnly = true;
            this.txtsidate.Size = new System.Drawing.Size(251, 27);
            this.txtsidate.TabIndex = 20;
            // 
            // lblsidate
            // 
            this.lblsidate.AutoSize = true;
            this.lblsidate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblsidate.ForeColor = System.Drawing.Color.White;
            this.lblsidate.Location = new System.Drawing.Point(209, 79);
            this.lblsidate.Name = "lblsidate";
            this.lblsidate.Size = new System.Drawing.Size(109, 19);
            this.lblsidate.TabIndex = 19;
            this.lblsidate.Text = "Stock-in Date:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtQuantity.Location = new System.Drawing.Point(342, 144);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(251, 27);
            this.txtQuantity.TabIndex = 18;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtItemCode.Location = new System.Drawing.Point(342, 36);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(251, 27);
            this.txtItemCode.TabIndex = 13;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(209, 151);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(75, 19);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblItemCode.ForeColor = System.Drawing.Color.White;
            this.lblItemCode.Location = new System.Drawing.Point(209, 43);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(70, 19);
            this.lblItemCode.TabIndex = 0;
            this.lblItemCode.Text = "Item ID:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(162)))), ((int)(((byte)(23)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(41)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(653, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 49);
            this.button1.TabIndex = 29;
            this.button1.Text = "Stock-Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStockInOut
            // 
            this.btnStockInOut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStockInOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnStockInOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(162)))), ((int)(((byte)(23)))));
            this.btnStockInOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(41)))));
            this.btnStockInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockInOut.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.btnStockInOut.ForeColor = System.Drawing.Color.Black;
            this.btnStockInOut.Location = new System.Drawing.Point(536, 608);
            this.btnStockInOut.Name = "btnStockInOut";
            this.btnStockInOut.Size = new System.Drawing.Size(113, 49);
            this.btnStockInOut.TabIndex = 22;
            this.btnStockInOut.Text = "Stock-In";
            this.btnStockInOut.UseVisualStyleBackColor = false;
            this.btnStockInOut.Click += new System.EventHandler(this.btnStockInOut_Click);
            // 
            // btnOrderList
            // 
            this.btnOrderList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOrderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnOrderList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(162)))), ((int)(((byte)(23)))));
            this.btnOrderList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(41)))));
            this.btnOrderList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderList.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.btnOrderList.ForeColor = System.Drawing.Color.Black;
            this.btnOrderList.Location = new System.Drawing.Point(354, 608);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(176, 49);
            this.btnOrderList.TabIndex = 21;
            this.btnOrderList.Text = "Create Order List";
            this.btnOrderList.UseVisualStyleBackColor = false;
            this.btnOrderList.Click += new System.EventHandler(this.btnOrderList_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(162)))), ((int)(((byte)(23)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(41)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(603, 86);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 36);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Item Management";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeColumns = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bebas Neue", 13.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bebas Neue", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventory.Location = new System.Drawing.Point(12, 126);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(761, 239);
            this.dgvInventory.TabIndex = 1;
            this.dgvInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellClick);
            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.BackColor = System.Drawing.Color.DarkRed;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.btnDashboard.Location = new System.Drawing.Point(674, 40);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(112, 37);
            this.btnDashboard.TabIndex = 21;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Tahoma", 12F);
            this.search.Location = new System.Drawing.Point(12, 93);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(244, 27);
            this.search.TabIndex = 23;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblSilaSchoolManagementSoftware);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 34);
            this.panel1.TabIndex = 40;
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
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(786, 667);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnOrderList);
            this.Controls.Add(this.btnStockInOut);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gboxitemdetails);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.MinimumSize = new System.Drawing.Size(802, 706);
            this.Name = "FormInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            this.gboxitemdetails.ResumeLayout(false);
            this.gboxitemdetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label lblsodate;
        private System.Windows.Forms.TextBox txtsidate;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.TextBox txtsodate;
        private System.Windows.Forms.Button btnOrderList;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSilaSchoolManagementSoftware;
    }
}