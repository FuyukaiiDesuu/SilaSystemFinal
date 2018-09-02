namespace MainSystem
{
    partial class createItem
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
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.txtitemcode = new System.Windows.Forms.TextBox();
            this.txtitemid = new System.Windows.Forms.TextBox();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lblitemname = new System.Windows.Forms.Label();
            this.lblitemcode = new System.Windows.Forms.Label();
            this.lblitemid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.gbItemDetails2.Location = new System.Drawing.Point(5, 12);
            this.gbItemDetails2.Name = "gbItemDetails2";
            this.gbItemDetails2.Size = new System.Drawing.Size(313, 217);
            this.gbItemDetails2.TabIndex = 2;
            this.gbItemDetails2.TabStop = false;
            this.gbItemDetails2.Text = "Item Details";
            this.gbItemDetails2.Enter += new System.EventHandler(this.gbItemDetails2_Enter);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // createItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 274);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbItemDetails2);
            this.Name = "createItem";
            this.Text = "createItem";
            this.gbItemDetails2.ResumeLayout(false);
            this.gbItemDetails2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbItemDetails2;
        public System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.TextBox txtitemcode;
        private System.Windows.Forms.TextBox txtitemid;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label lblitemname;
        private System.Windows.Forms.Label lblitemcode;
        private System.Windows.Forms.Label lblitemid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}