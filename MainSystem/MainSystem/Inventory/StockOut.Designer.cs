namespace MainSystem
{
    partial class StockOut
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
            this.search1 = new System.Windows.Forms.TextBox();
            this.lblSinoutRecord = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 56);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(649, 177);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // search1
            // 
            this.search1.Location = new System.Drawing.Point(12, 31);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(237, 20);
            this.search1.TabIndex = 13;
            // 
            // lblSinoutRecord
            // 
            this.lblSinoutRecord.AutoSize = true;
            this.lblSinoutRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinoutRecord.Location = new System.Drawing.Point(254, 9);
            this.lblSinoutRecord.Name = "lblSinoutRecord";
            this.lblSinoutRecord.Size = new System.Drawing.Size(157, 24);
            this.lblSinoutRecord.TabIndex = 12;
            this.lblSinoutRecord.Text = "Stock In System";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quantity:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 42);
            this.button1.TabIndex = 16;
            this.button1.Text = "OUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(146, 263);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(132, 42);
            this.btnback.TabIndex = 17;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.button2_Click);
            // 
            // StockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 315);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.lblSinoutRecord);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StockOut";
            this.Text = "StockOut";
            this.Load += new System.EventHandler(this.StockOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox search1;
        private System.Windows.Forms.Label lblSinoutRecord;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnback;
    }
}