namespace MainSystem
{
    partial class EnrollmentConsole
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfn = new System.Windows.Forms.TextBox();
            this.txtln = new System.Windows.Forms.TextBox();
            this.txtmi = new System.Windows.Forms.TextBox();
            this.txtsex = new System.Windows.Forms.TextBox();
            this.txtbd = new System.Windows.Forms.TextBox();
            this.txtbp = new System.Windows.Forms.TextBox();
            this.txtrel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdep = new System.Windows.Forms.TextBox();
            this.txtlev = new System.Windows.Forms.TextBox();
            this.txtsy = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblblb = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(351, 465);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 530);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(113, 34);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(131, 530);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 34);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(250, 530);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(113, 34);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(499, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 172);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Middle Initial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Birthdate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Birthplace:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sex:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Religion:";
            // 
            // txtfn
            // 
            this.txtfn.Location = new System.Drawing.Point(457, 259);
            this.txtfn.Name = "txtfn";
            this.txtfn.Size = new System.Drawing.Size(129, 20);
            this.txtfn.TabIndex = 14;
            this.txtfn.TextChanged += new System.EventHandler(this.txtfn_TextChanged);
            // 
            // txtln
            // 
            this.txtln.Location = new System.Drawing.Point(457, 285);
            this.txtln.Name = "txtln";
            this.txtln.Size = new System.Drawing.Size(129, 20);
            this.txtln.TabIndex = 15;
            // 
            // txtmi
            // 
            this.txtmi.Location = new System.Drawing.Point(457, 311);
            this.txtmi.Name = "txtmi";
            this.txtmi.Size = new System.Drawing.Size(129, 20);
            this.txtmi.TabIndex = 16;
            // 
            // txtsex
            // 
            this.txtsex.Location = new System.Drawing.Point(458, 389);
            this.txtsex.Name = "txtsex";
            this.txtsex.Size = new System.Drawing.Size(129, 20);
            this.txtsex.TabIndex = 17;
            // 
            // txtbd
            // 
            this.txtbd.Location = new System.Drawing.Point(457, 337);
            this.txtbd.Name = "txtbd";
            this.txtbd.Size = new System.Drawing.Size(129, 20);
            this.txtbd.TabIndex = 17;
            // 
            // txtbp
            // 
            this.txtbp.Location = new System.Drawing.Point(458, 363);
            this.txtbp.Name = "txtbp";
            this.txtbp.Size = new System.Drawing.Size(129, 20);
            this.txtbp.TabIndex = 18;
            // 
            // txtrel
            // 
            this.txtrel.Location = new System.Drawing.Point(458, 415);
            this.txtrel.Name = "txtrel";
            this.txtrel.Size = new System.Drawing.Size(129, 20);
            this.txtrel.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "USERNAME%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "DATETIME%";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "DASHBOARD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(394, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Nickname:";
            // 
            // txtnn
            // 
            this.txtnn.Location = new System.Drawing.Point(458, 440);
            this.txtnn.Name = "txtnn";
            this.txtnn.Size = new System.Drawing.Size(129, 20);
            this.txtnn.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "LELELEL";
            // 
            // txtdep
            // 
            this.txtdep.Location = new System.Drawing.Point(670, 259);
            this.txtdep.Name = "txtdep";
            this.txtdep.Size = new System.Drawing.Size(129, 20);
            this.txtdep.TabIndex = 26;
            // 
            // txtlev
            // 
            this.txtlev.Location = new System.Drawing.Point(670, 285);
            this.txtlev.Name = "txtlev";
            this.txtlev.Size = new System.Drawing.Size(129, 20);
            this.txtlev.TabIndex = 27;
            // 
            // txtsy
            // 
            this.txtsy.Location = new System.Drawing.Point(670, 311);
            this.txtsy.Name = "txtsy";
            this.txtsy.Size = new System.Drawing.Size(129, 20);
            this.txtsy.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(604, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Department:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(391, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "First Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(596, 314);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "School-Year:";
            // 
            // lblblb
            // 
            this.lblblb.AutoSize = true;
            this.lblblb.Location = new System.Drawing.Point(624, 340);
            this.lblblb.Name = "lblblb";
            this.lblblb.Size = new System.Drawing.Size(40, 13);
            this.lblblb.TabIndex = 32;
            this.lblblb.Text = "Status:";
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(670, 337);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(129, 20);
            this.txtstatus.TabIndex = 33;
            // 
            // EnrollmentConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 576);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.lblblb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtsy);
            this.Controls.Add(this.txtlev);
            this.Controls.Add(this.txtdep);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtnn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtrel);
            this.Controls.Add(this.txtbp);
            this.Controls.Add(this.txtbd);
            this.Controls.Add(this.txtsex);
            this.Controls.Add(this.txtmi);
            this.Controls.Add(this.txtln);
            this.Controls.Add(this.txtfn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EnrollmentConsole";
            this.Text = " ";
            this.Load += new System.EventHandler(this.EnrollmentConsole_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EnrollmentConsole_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtfn;
        private System.Windows.Forms.TextBox txtln;
        private System.Windows.Forms.TextBox txtmi;
        private System.Windows.Forms.TextBox txtsex;
        private System.Windows.Forms.TextBox txtbd;
        private System.Windows.Forms.TextBox txtbp;
        private System.Windows.Forms.TextBox txtrel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdep;
        private System.Windows.Forms.TextBox txtlev;
        private System.Windows.Forms.TextBox txtsy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblblb;
        private System.Windows.Forms.TextBox txtstatus;
    }
}