namespace MainSystem
{
    partial class Stockin_out
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
            this.btnin = new System.Windows.Forms.Button();
            this.lblSinoutRecord = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnback2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.search1 = new System.Windows.Forms.TextBox();
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.lblEnter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(279, 258);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(75, 23);
            this.btnin.TabIndex = 2;
            this.btnin.Text = "IN";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // lblSinoutRecord
            // 
            this.lblSinoutRecord.AutoSize = true;
            this.lblSinoutRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinoutRecord.Location = new System.Drawing.Point(256, 9);
            this.lblSinoutRecord.Name = "lblSinoutRecord";
            this.lblSinoutRecord.Size = new System.Drawing.Size(157, 24);
            this.lblSinoutRecord.TabIndex = 5;
            this.lblSinoutRecord.Text = "Stock In System";
            this.lblSinoutRecord.Click += new System.EventHandler(this.lblSinoutRecord_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 79);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 177);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnback2
            // 
            this.btnback2.Location = new System.Drawing.Point(98, 472);
            this.btnback2.Name = "btnback2";
            this.btnback2.Size = new System.Drawing.Size(75, 23);
            this.btnback2.TabIndex = 8;
            this.btnback2.Text = "Back";
            this.btnback2.UseVisualStyleBackColor = true;
            this.btnback2.Click += new System.EventHandler(this.btnback2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 289);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(644, 177);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // search1
            // 
            this.search1.Location = new System.Drawing.Point(17, 54);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(237, 20);
            this.search1.TabIndex = 11;
            this.search1.TextChanged += new System.EventHandler(this.search1_TextChanged);
            // 
            // txtEnter
            // 
            this.txtEnter.Location = new System.Drawing.Point(163, 260);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(100, 20);
            this.txtEnter.TabIndex = 12;
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(14, 263);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(129, 13);
            this.lblEnter.TabIndex = 13;
            this.lblEnter.Text = "Enter Quantity to Stock-In";
            // 
            // Stockin_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 504);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnback2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSinoutRecord);
            this.Controls.Add(this.btnin);
            this.Name = "Stockin_out";
            this.Text = "Stockin_out";
            this.Load += new System.EventHandler(this.Stockin_out_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Label lblSinoutRecord;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnback2;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox search1;
        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.Label lblEnter;
    }
}