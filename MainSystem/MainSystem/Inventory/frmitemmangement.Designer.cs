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
            this.btnback3 = new System.Windows.Forms.Button();
            this.gbItemDetails2 = new System.Windows.Forms.GroupBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.txtitemcode = new System.Windows.Forms.TextBox();
            this.txtitemid = new System.Windows.Forms.TextBox();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lblitemname = new System.Windows.Forms.Label();
            this.lblitemcode = new System.Windows.Forms.Label();
            this.lblitemid = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.gbItemDetails2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback3
            // 
            this.btnback3.Location = new System.Drawing.Point(331, 494);
            this.btnback3.Name = "btnback3";
            this.btnback3.Size = new System.Drawing.Size(75, 23);
            this.btnback3.TabIndex = 0;
            this.btnback3.Text = "Back";
            this.btnback3.UseVisualStyleBackColor = true;
            this.btnback3.Click += new System.EventHandler(this.btnback3_Click);
            // 
            // gbItemDetails2
            // 
            this.gbItemDetails2.Controls.Add(this.cmbstatus);
            this.gbItemDetails2.Controls.Add(this.lblstatus);
            this.gbItemDetails2.Controls.Add(this.txtdesc);
            this.gbItemDetails2.Controls.Add(this.txtitemname);
            this.gbItemDetails2.Controls.Add(this.txtitemcode);
            this.gbItemDetails2.Controls.Add(this.txtitemid);
            this.gbItemDetails2.Controls.Add(this.lbldesc);
            this.gbItemDetails2.Controls.Add(this.lblitemname);
            this.gbItemDetails2.Controls.Add(this.lblitemcode);
            this.gbItemDetails2.Controls.Add(this.lblitemid);
            this.gbItemDetails2.Location = new System.Drawing.Point(12, 297);
            this.gbItemDetails2.Name = "gbItemDetails2";
            this.gbItemDetails2.Size = new System.Drawing.Size(313, 223);
            this.gbItemDetails2.TabIndex = 1;
            this.gbItemDetails2.TabStop = false;
            this.gbItemDetails2.Text = "Item Details";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(14, 151);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(37, 13);
            this.lblstatus.TabIndex = 12;
            this.lblstatus.Text = "Staus:";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(90, 96);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(204, 46);
            this.txtdesc.TabIndex = 4;
            // 
            // txtitemname
            // 
            this.txtitemname.Location = new System.Drawing.Point(90, 174);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(204, 20);
            this.txtitemname.TabIndex = 3;
            // 
            // txtitemcode
            // 
            this.txtitemcode.Location = new System.Drawing.Point(90, 70);
            this.txtitemcode.Name = "txtitemcode";
            this.txtitemcode.Size = new System.Drawing.Size(204, 20);
            this.txtitemcode.TabIndex = 2;
            // 
            // txtitemid
            // 
            this.txtitemid.Location = new System.Drawing.Point(90, 35);
            this.txtitemid.Name = "txtitemid";
            this.txtitemid.ReadOnly = true;
            this.txtitemid.Size = new System.Drawing.Size(204, 20);
            this.txtitemid.TabIndex = 0;
            this.txtitemid.TabStop = false;
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Location = new System.Drawing.Point(14, 99);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(63, 13);
            this.lbldesc.TabIndex = 4;
            this.lbldesc.Text = "Descrpition:";
            // 
            // lblitemname
            // 
            this.lblitemname.AutoSize = true;
            this.lblitemname.Location = new System.Drawing.Point(14, 178);
            this.lblitemname.Name = "lblitemname";
            this.lblitemname.Size = new System.Drawing.Size(61, 13);
            this.lblitemname.TabIndex = 3;
            this.lblitemname.Text = "Item Name:";
            // 
            // lblitemcode
            // 
            this.lblitemcode.AutoSize = true;
            this.lblitemcode.Location = new System.Drawing.Point(14, 70);
            this.lblitemcode.Name = "lblitemcode";
            this.lblitemcode.Size = new System.Drawing.Size(58, 13);
            this.lblitemcode.TabIndex = 2;
            this.lblitemcode.Text = "Item Code:";
            // 
            // lblitemid
            // 
            this.lblitemid.AutoSize = true;
            this.lblitemid.Location = new System.Drawing.Point(14, 35);
            this.lblitemid.Name = "lblitemid";
            this.lblitemid.Size = new System.Drawing.Size(44, 13);
            this.lblitemid.TabIndex = 1;
            this.lblitemid.Text = "Item ID:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(331, 408);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(331, 465);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 15;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(331, 437);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(75, 23);
            this.btnview.TabIndex = 16;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(684, 202);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(12, 53);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(186, 20);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // cmbstatus
            // 
            this.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "",
            "0",
            "1"});
            this.cmbstatus.Location = new System.Drawing.Point(90, 149);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(204, 21);
            this.cmbstatus.TabIndex = 13;
            // 
            // frmitemmanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 530);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbItemDetails2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnback3);
            this.Name = "frmitemmanagement";
            this.Text = "Item management";
            this.Load += new System.EventHandler(this.frmItemCreate_Load);
            this.gbItemDetails2.ResumeLayout(false);
            this.gbItemDetails2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback3;
        private System.Windows.Forms.GroupBox gbItemDetails2;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label lblitemname;
        private System.Windows.Forms.Label lblitemcode;
        private System.Windows.Forms.Label lblitemid;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.TextBox txtitemcode;
        private System.Windows.Forms.TextBox txtitemid;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.TextBox txtsearch;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox cmbstatus;
    }
}