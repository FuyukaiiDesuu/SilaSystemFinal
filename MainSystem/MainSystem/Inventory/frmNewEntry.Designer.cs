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
            this.btnback = new System.Windows.Forms.Button();
            this.gboxentry = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblquantity = new System.Windows.Forms.Label();
            this.lblmiscdesc = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblitemname = new System.Windows.Forms.Label();
            this.btnconfirm = new System.Windows.Forms.Button();
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
            this.gboxentry.Controls.Add(this.textBox5);
            this.gboxentry.Controls.Add(this.textBox4);
            this.gboxentry.Controls.Add(this.textBox3);
            this.gboxentry.Controls.Add(this.textBox1);
            this.gboxentry.Controls.Add(this.lblquantity);
            this.gboxentry.Controls.Add(this.lblmiscdesc);
            this.gboxentry.Controls.Add(this.lbldate);
            this.gboxentry.Controls.Add(this.lblitemname);
            this.gboxentry.Controls.Add(this.btnconfirm);
            this.gboxentry.Controls.Add(this.btnback);
            this.gboxentry.Location = new System.Drawing.Point(13, 40);
            this.gboxentry.Name = "gboxentry";
            this.gboxentry.Size = new System.Drawing.Size(221, 279);
            this.gboxentry.TabIndex = 1;
            this.gboxentry.TabStop = false;
            this.gboxentry.Text = "New Entry";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(79, 212);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(119, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(27, 146);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 55);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(104, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 7;
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
            // 
            // frmNewEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 328);
            this.Controls.Add(this.gboxentry);
            this.Name = "frmNewEntry";
            this.Text = "frmNewEntry";
            this.Load += new System.EventHandler(this.frmNewEntry_Load);
            this.gboxentry.ResumeLayout(false);
            this.gboxentry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.GroupBox gboxentry;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Label lblmiscdesc;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblitemname;
        private System.Windows.Forms.Button btnconfirm;
    }
}