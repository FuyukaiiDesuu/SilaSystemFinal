namespace MainSystem
{
    partial class frmNewEntry
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
            this.components = new System.ComponentModel.Container();
            this.btnback = new System.Windows.Forms.Button();
            this.gboxentry = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.lblquantity = new System.Windows.Forms.Label();
            this.lblmiscdesc = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblitemname = new System.Windows.Forms.Label();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtinvID = new System.Windows.Forms.TextBox();
            this.lblinvID = new System.Windows.Forms.Label();
            this.gboxentry.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(94, 240);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.button1_Click);
            // 
            // gboxentry
            // 
            this.gboxentry.Controls.Add(this.lblinvID);
            this.gboxentry.Controls.Add(this.txtinvID);
            this.gboxentry.Controls.Add(this.label2);
            this.gboxentry.Controls.Add(this.txtquantity);
            this.gboxentry.Controls.Add(this.txtdesc);
            this.gboxentry.Controls.Add(this.txtitemname);
            this.gboxentry.Controls.Add(this.lblquantity);
            this.gboxentry.Controls.Add(this.lblmiscdesc);
            this.gboxentry.Controls.Add(this.lbldate);
            this.gboxentry.Controls.Add(this.lblitemname);
            this.gboxentry.Controls.Add(this.btnconfirm);
            this.gboxentry.Controls.Add(this.btnback);
            this.gboxentry.Location = new System.Drawing.Point(13, 40);
            this.gboxentry.Name = "gboxentry";
            this.gboxentry.Size = new System.Drawing.Size(307, 279);
            this.gboxentry.TabIndex = 1;
            this.gboxentry.TabStop = false;
            this.gboxentry.Text = "New Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(79, 212);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(215, 20);
            this.txtquantity.TabIndex = 11;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(27, 146);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(267, 55);
            this.txtdesc.TabIndex = 10;
            // 
            // txtitemname
            // 
            this.txtitemname.Location = new System.Drawing.Point(94, 65);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(200, 20);
            this.txtitemname.TabIndex = 7;
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Location = new System.Drawing.Point(24, 215);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(49, 13);
            this.lblquantity.TabIndex = 6;
            this.lblquantity.Text = "Quantity:";
            // 
            // lblmiscdesc
            // 
            this.lblmiscdesc.AutoSize = true;
            this.lblmiscdesc.Location = new System.Drawing.Point(24, 130);
            this.lblmiscdesc.Name = "lblmiscdesc";
            this.lblmiscdesc.Size = new System.Drawing.Size(133, 13);
            this.lblmiscdesc.TabIndex = 5;
            this.lblmiscdesc.Text = "Miscellaneous Description:";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(55, 97);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(33, 13);
            this.lbldate.TabIndex = 4;
            this.lbldate.Text = "Date:";
            // 
            // lblitemname
            // 
            this.lblitemname.AutoSize = true;
            this.lblitemname.Location = new System.Drawing.Point(24, 68);
            this.lblitemname.Name = "lblitemname";
            this.lblitemname.Size = new System.Drawing.Size(61, 13);
            this.lblitemname.TabIndex = 2;
            this.lblitemname.Text = "Item Name:";
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(13, 240);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(75, 23);
            this.btnconfirm.TabIndex = 1;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Entry";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtinvID
            // 
            this.txtinvID.Location = new System.Drawing.Point(94, 39);
            this.txtinvID.Name = "txtinvID";
            this.txtinvID.Size = new System.Drawing.Size(200, 20);
            this.txtinvID.TabIndex = 13;
            // 
            // lblinvID
            // 
            this.lblinvID.AutoSize = true;
            this.lblinvID.Location = new System.Drawing.Point(24, 42);
            this.lblinvID.Name = "lblinvID";
            this.lblinvID.Size = new System.Drawing.Size(68, 13);
            this.lblinvID.TabIndex = 14;
            this.lblinvID.Text = "Inventory ID:";
            // 
            // frmNewEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gboxentry);
            this.Name = "frmNewEntry";
            this.Text = "frmNewEntry";
            this.Load += new System.EventHandler(this.frmNewEntry_Load);
            this.gboxentry.ResumeLayout(false);
            this.gboxentry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.GroupBox gboxentry;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Label lblmiscdesc;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblitemname;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtquantity;
        public System.Windows.Forms.TextBox txtdesc;
        public System.Windows.Forms.TextBox txtitemname;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblinvID;
        private System.Windows.Forms.TextBox txtinvID;
    }
}