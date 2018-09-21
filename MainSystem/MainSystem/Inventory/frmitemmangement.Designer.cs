namespace MainSystem
{
    partial class frmitemmanagement
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
            this.btnback3 = new System.Windows.Forms.Button();
            this.gbItemDetails2 = new System.Windows.Forms.GroupBox();
            this.txtstat = new System.Windows.Forms.TextBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.txtitemcode = new System.Windows.Forms.TextBox();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lblitemname = new System.Windows.Forms.Label();
            this.lblitemcode = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSilaSchoolManagementSoftware = new System.Windows.Forms.Label();
            this.gbItemDetails2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback3
            // 
            this.btnback3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnback3.BackColor = System.Drawing.Color.DarkRed;
            this.btnback3.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnback3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback3.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.btnback3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnback3.Location = new System.Drawing.Point(613, 40);
            this.btnback3.Name = "btnback3";
            this.btnback3.Size = new System.Drawing.Size(108, 36);
            this.btnback3.TabIndex = 0;
            this.btnback3.Text = "Back";
            this.btnback3.UseVisualStyleBackColor = false;
            this.btnback3.Click += new System.EventHandler(this.btnback3_Click);
            // 
            // gbItemDetails2
            // 
            this.gbItemDetails2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbItemDetails2.Controls.Add(this.txtstat);
            this.gbItemDetails2.Controls.Add(this.lblstatus);
            this.gbItemDetails2.Controls.Add(this.txtdesc);
            this.gbItemDetails2.Controls.Add(this.txtitemname);
            this.gbItemDetails2.Controls.Add(this.txtitemcode);
            this.gbItemDetails2.Controls.Add(this.lbldesc);
            this.gbItemDetails2.Controls.Add(this.lblitemname);
            this.gbItemDetails2.Controls.Add(this.lblitemcode);
            this.gbItemDetails2.Font = new System.Drawing.Font("Bebas Neue", 14.25F);
            this.gbItemDetails2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.gbItemDetails2.Location = new System.Drawing.Point(12, 347);
            this.gbItemDetails2.Name = "gbItemDetails2";
            this.gbItemDetails2.Size = new System.Drawing.Size(684, 236);
            this.gbItemDetails2.TabIndex = 1;
            this.gbItemDetails2.TabStop = false;
            this.gbItemDetails2.Text = "Item Details";
            this.gbItemDetails2.Enter += new System.EventHandler(this.gbItemDetails2_Enter);
            // 
            // txtstat
            // 
            this.txtstat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtstat.Location = new System.Drawing.Point(264, 158);
            this.txtstat.Name = "txtstat";
            this.txtstat.Size = new System.Drawing.Size(340, 27);
            this.txtstat.TabIndex = 13;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblstatus.ForeColor = System.Drawing.Color.White;
            this.lblstatus.Location = new System.Drawing.Point(124, 162);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(53, 19);
            this.lblstatus.TabIndex = 12;
            this.lblstatus.Text = "Staus:";
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtdesc.Location = new System.Drawing.Point(264, 67);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(340, 85);
            this.txtdesc.TabIndex = 4;
            // 
            // txtitemname
            // 
            this.txtitemname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtitemname.Location = new System.Drawing.Point(264, 191);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(340, 27);
            this.txtitemname.TabIndex = 3;
            // 
            // txtitemcode
            // 
            this.txtitemcode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtitemcode.Location = new System.Drawing.Point(264, 34);
            this.txtitemcode.Name = "txtitemcode";
            this.txtitemcode.Size = new System.Drawing.Size(340, 27);
            this.txtitemcode.TabIndex = 2;
            this.txtitemcode.TextChanged += new System.EventHandler(this.txtitemcode_TextChanged);
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbldesc.ForeColor = System.Drawing.Color.White;
            this.lbldesc.Location = new System.Drawing.Point(124, 129);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(94, 19);
            this.lbldesc.TabIndex = 4;
            this.lbldesc.Text = "Descrpition:";
            // 
            // lblitemname
            // 
            this.lblitemname.AutoSize = true;
            this.lblitemname.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblitemname.ForeColor = System.Drawing.Color.White;
            this.lblitemname.Location = new System.Drawing.Point(124, 195);
            this.lblitemname.Name = "lblitemname";
            this.lblitemname.Size = new System.Drawing.Size(94, 19);
            this.lblitemname.TabIndex = 3;
            this.lblitemname.Text = "Item Name:";
            // 
            // lblitemcode
            // 
            this.lblitemcode.AutoSize = true;
            this.lblitemcode.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblitemcode.ForeColor = System.Drawing.Color.White;
            this.lblitemcode.Location = new System.Drawing.Point(124, 41);
            this.lblitemcode.Name = "lblitemcode";
            this.lblitemcode.Size = new System.Drawing.Size(89, 19);
            this.lblitemcode.TabIndex = 2;
            this.lblitemcode.Text = "Item Code:";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(162)))), ((int)(((byte)(23)))));
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(41)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreate.Location = new System.Drawing.Point(360, 589);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(108, 36);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnedit
            // 
            this.btnedit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnedit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(162)))), ((int)(((byte)(23)))));
            this.btnedit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(41)))));
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.btnedit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnedit.Location = new System.Drawing.Point(474, 589);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(108, 36);
            this.btnedit.TabIndex = 15;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnview
            // 
            this.btnview.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(162)))), ((int)(((byte)(23)))));
            this.btnview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(41)))));
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnview.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.btnview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnview.Location = new System.Drawing.Point(588, 589);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(108, 36);
            this.btnview.TabIndex = 16;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bebas Neue", 13.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bebas Neue", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(684, 202);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtsearch.Location = new System.Drawing.Point(12, 106);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(186, 27);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblSilaSchoolManagementSoftware);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 34);
            this.panel1.TabIndex = 43;
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
            // frmitemmanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(721, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbItemDetails2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnback3);
            this.MinimumSize = new System.Drawing.Size(737, 679);
            this.Name = "frmitemmanagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Management";
            this.Load += new System.EventHandler(this.frmItemCreate_Load);
            this.gbItemDetails2.ResumeLayout(false);
            this.gbItemDetails2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback3;
        private System.Windows.Forms.GroupBox gbItemDetails2;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label lblitemname;
        private System.Windows.Forms.Label lblitemcode;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.TextBox txtitemcode;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.TextBox txtsearch;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtstat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSilaSchoolManagementSoftware;
    }
}