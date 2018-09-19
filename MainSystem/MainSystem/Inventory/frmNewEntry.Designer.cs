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
            this.lblinvID = new System.Windows.Forms.Label();
            this.txtinvID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.lblquantity = new System.Windows.Forms.Label();
            this.lblmiscdesc = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblitemname = new System.Windows.Forms.Label();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSilaSchoolManagementSoftware = new System.Windows.Forms.Label();
            this.gboxentry.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnback.BackColor = System.Drawing.Color.DarkRed;
            this.btnback.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.btnback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnback.Location = new System.Drawing.Point(441, 338);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(108, 36);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.button1_Click);
            // 
            // gboxentry
            // 
            this.gboxentry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboxentry.Controls.Add(this.lblinvID);
            this.gboxentry.Controls.Add(this.txtinvID);
            this.gboxentry.Controls.Add(this.txtquantity);
            this.gboxentry.Controls.Add(this.txtdesc);
            this.gboxentry.Controls.Add(this.txtitemname);
            this.gboxentry.Controls.Add(this.lblquantity);
            this.gboxentry.Controls.Add(this.lblmiscdesc);
            this.gboxentry.Controls.Add(this.lblitemname);
            this.gboxentry.Font = new System.Drawing.Font("Bebas Neue", 14.25F);
            this.gboxentry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.gboxentry.Location = new System.Drawing.Point(12, 86);
            this.gboxentry.Name = "gboxentry";
            this.gboxentry.Size = new System.Drawing.Size(537, 246);
            this.gboxentry.TabIndex = 1;
            this.gboxentry.TabStop = false;
            this.gboxentry.Text = "New Entry";
            this.gboxentry.Enter += new System.EventHandler(this.gboxentry_Enter);
            // 
            // lblinvID
            // 
            this.lblinvID.AutoSize = true;
            this.lblinvID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblinvID.ForeColor = System.Drawing.Color.White;
            this.lblinvID.Location = new System.Drawing.Point(24, 46);
            this.lblinvID.Name = "lblinvID";
            this.lblinvID.Size = new System.Drawing.Size(105, 19);
            this.lblinvID.TabIndex = 14;
            this.lblinvID.Text = "Inventory ID:";
            // 
            // txtinvID
            // 
            this.txtinvID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtinvID.Location = new System.Drawing.Point(231, 42);
            this.txtinvID.Name = "txtinvID";
            this.txtinvID.Size = new System.Drawing.Size(267, 27);
            this.txtinvID.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.label2.Location = new System.Drawing.Point(51, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtquantity.Location = new System.Drawing.Point(231, 185);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(267, 27);
            this.txtquantity.TabIndex = 11;
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtdesc.Location = new System.Drawing.Point(231, 108);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(267, 71);
            this.txtdesc.TabIndex = 10;
            // 
            // txtitemname
            // 
            this.txtitemname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtitemname.Location = new System.Drawing.Point(231, 75);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(267, 27);
            this.txtitemname.TabIndex = 7;
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblquantity.ForeColor = System.Drawing.Color.White;
            this.lblquantity.Location = new System.Drawing.Point(24, 189);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(75, 19);
            this.lblquantity.TabIndex = 6;
            this.lblquantity.Text = "Quantity:";
            // 
            // lblmiscdesc
            // 
            this.lblmiscdesc.AutoSize = true;
            this.lblmiscdesc.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblmiscdesc.ForeColor = System.Drawing.Color.White;
            this.lblmiscdesc.Location = new System.Drawing.Point(24, 156);
            this.lblmiscdesc.Name = "lblmiscdesc";
            this.lblmiscdesc.Size = new System.Drawing.Size(195, 19);
            this.lblmiscdesc.TabIndex = 5;
            this.lblmiscdesc.Text = "Miscellaneous Description:";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.lbldate.Location = new System.Drawing.Point(-2, 37);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(47, 19);
            this.lbldate.TabIndex = 4;
            this.lbldate.Text = "Date:";
            // 
            // lblitemname
            // 
            this.lblitemname.AutoSize = true;
            this.lblitemname.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblitemname.ForeColor = System.Drawing.Color.White;
            this.lblitemname.Location = new System.Drawing.Point(24, 79);
            this.lblitemname.Name = "lblitemname";
            this.lblitemname.Size = new System.Drawing.Size(94, 19);
            this.lblitemname.TabIndex = 2;
            this.lblitemname.Text = "Item Name:";
            // 
            // btnconfirm
            // 
            this.btnconfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnconfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(86)))));
            this.btnconfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(162)))), ((int)(((byte)(23)))));
            this.btnconfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(41)))));
            this.btnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirm.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.btnconfirm.Location = new System.Drawing.Point(327, 338);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(108, 36);
            this.btnconfirm.TabIndex = 1;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = false;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblSilaSchoolManagementSoftware);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 34);
            this.panel1.TabIndex = 44;
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
            // frmNewEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(567, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gboxentry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.lbldate);
            this.MinimumSize = new System.Drawing.Size(583, 432);
            this.Name = "frmNewEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Entry";
            this.Load += new System.EventHandler(this.frmNewEntry_Load);
            this.gboxentry.ResumeLayout(false);
            this.gboxentry.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        public System.Windows.Forms.TextBox txtquantity;
        public System.Windows.Forms.TextBox txtdesc;
        public System.Windows.Forms.TextBox txtitemname;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblinvID;
        private System.Windows.Forms.TextBox txtinvID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSilaSchoolManagementSoftware;
    }
}