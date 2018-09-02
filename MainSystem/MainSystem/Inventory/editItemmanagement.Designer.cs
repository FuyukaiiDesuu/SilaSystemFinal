namespace MainSystem
{
    partial class editItemmanagement
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
            this.lbledit = new System.Windows.Forms.Label();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.gbItemDetails2.SuspendLayout();
            this.SuspendLayout();
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
            this.gbItemDetails2.Location = new System.Drawing.Point(9, 35);
            this.gbItemDetails2.Name = "gbItemDetails2";
            this.gbItemDetails2.Size = new System.Drawing.Size(313, 223);
            this.gbItemDetails2.TabIndex = 2;
            this.gbItemDetails2.TabStop = false;
            this.gbItemDetails2.Text = "Item Details";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(14, 170);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(37, 13);
            this.lblstatus.TabIndex = 12;
            this.lblstatus.Text = "Staus:";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(90, 110);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(204, 46);
            this.txtdesc.TabIndex = 9;
            // 
            // txtitemname
            // 
            this.txtitemname.Location = new System.Drawing.Point(90, 197);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(204, 20);
            this.txtitemname.TabIndex = 8;
            // 
            // txtitemcode
            // 
            this.txtitemcode.Location = new System.Drawing.Point(90, 70);
            this.txtitemcode.Name = "txtitemcode";
            this.txtitemcode.Size = new System.Drawing.Size(204, 20);
            this.txtitemcode.TabIndex = 7;
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
            this.lbldesc.Location = new System.Drawing.Point(14, 113);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(63, 13);
            this.lbldesc.TabIndex = 4;
            this.lbldesc.Text = "Descrpition:";
            // 
            // lblitemname
            // 
            this.lblitemname.AutoSize = true;
            this.lblitemname.Location = new System.Drawing.Point(14, 197);
            this.lblitemname.Name = "lblitemname";
            this.lblitemname.Size = new System.Drawing.Size(61, 13);
            this.lblitemname.TabIndex = 3;
            this.lblitemname.Text = "Item Name:";
            // 
            // lblitemcode
            // 
            this.lblitemcode.AutoSize = true;
            this.lblitemcode.Location = new System.Drawing.Point(14, 77);
            this.lblitemcode.Name = "lblitemcode";
            this.lblitemcode.Size = new System.Drawing.Size(58, 13);
            this.lblitemcode.TabIndex = 2;
            this.lblitemcode.Text = "Item Code:";
            // 
            // lblitemid
            // 
            this.lblitemid.AutoSize = true;
            this.lblitemid.Location = new System.Drawing.Point(14, 42);
            this.lblitemid.Name = "lblitemid";
            this.lblitemid.Size = new System.Drawing.Size(44, 13);
            this.lblitemid.TabIndex = 1;
            this.lblitemid.Text = "Item ID:";
            // 
            // lbledit
            // 
            this.lbledit.AutoSize = true;
            this.lbledit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledit.Location = new System.Drawing.Point(5, 9);
            this.lbledit.Name = "lbledit";
            this.lbledit.Size = new System.Drawing.Size(91, 24);
            this.lbledit.TabIndex = 15;
            this.lbledit.Text = "Item Edit";
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(8, 264);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(75, 23);
            this.btnconfirm.TabIndex = 16;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(247, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 17;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // cmbstatus
            // 
            this.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "",
            "0",
            "1"});
            this.cmbstatus.Location = new System.Drawing.Point(90, 170);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(204, 21);
            this.cmbstatus.TabIndex = 13;
            // 
            // editItemmanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 296);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.lbledit);
            this.Controls.Add(this.gbItemDetails2);
            this.Name = "editItemmanagement";
            this.Text = "editItemmanagement";
            this.Load += new System.EventHandler(this.editItemmanagement_Load);
            this.gbItemDetails2.ResumeLayout(false);
            this.gbItemDetails2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbItemDetails2;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label lblitemname;
        private System.Windows.Forms.Label lblitemcode;
        private System.Windows.Forms.Label lblitemid;
        private System.Windows.Forms.Label lbledit;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button btnback;
        public System.Windows.Forms.TextBox txtdesc;
        public System.Windows.Forms.TextBox txtitemname;
        public System.Windows.Forms.TextBox txtitemcode;
        public System.Windows.Forms.TextBox txtitemid;
        public System.Windows.Forms.ComboBox cmbstatus;
    }
}