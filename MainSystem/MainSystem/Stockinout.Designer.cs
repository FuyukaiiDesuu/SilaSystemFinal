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
            this.btnNewEntry = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.btnout = new System.Windows.Forms.Button();
            this.lblSinoutRecord = new System.Windows.Forms.Label();
            this.bntView = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewEntry
            // 
            this.btnNewEntry.Location = new System.Drawing.Point(31, 390);
            this.btnNewEntry.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewEntry.Name = "btnNewEntry";
            this.btnNewEntry.Size = new System.Drawing.Size(100, 28);
            this.btnNewEntry.TabIndex = 1;
            this.btnNewEntry.Text = "New Entry";
            this.btnNewEntry.UseVisualStyleBackColor = true;
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(169, 390);
            this.btnin.Margin = new System.Windows.Forms.Padding(4);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(100, 28);
            this.btnin.TabIndex = 2;
            this.btnin.Text = "IN";
            this.btnin.UseVisualStyleBackColor = true;
            // 
            // btnout
            // 
            this.btnout.Location = new System.Drawing.Point(304, 390);
            this.btnout.Margin = new System.Windows.Forms.Padding(4);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(100, 28);
            this.btnout.TabIndex = 3;
            this.btnout.Text = "OUT";
            this.btnout.UseVisualStyleBackColor = true;
            // 
            // lblSinoutRecord
            // 
            this.lblSinoutRecord.AutoSize = true;
            this.lblSinoutRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinoutRecord.Location = new System.Drawing.Point(16, 116);
            this.lblSinoutRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSinoutRecord.Name = "lblSinoutRecord";
            this.lblSinoutRecord.Size = new System.Drawing.Size(287, 29);
            this.lblSinoutRecord.TabIndex = 5;
            this.lblSinoutRecord.Text = "Stock in and Out record";
            // 
            // bntView
            // 
            this.bntView.Location = new System.Drawing.Point(453, 390);
            this.bntView.Margin = new System.Windows.Forms.Padding(4);
            this.bntView.Name = "bntView";
            this.bntView.Size = new System.Drawing.Size(100, 28);
            this.bntView.TabIndex = 6;
            this.bntView.Text = "View";
            this.bntView.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.test});
            this.dataGridView1.Location = new System.Drawing.Point(31, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(821, 218);
            this.dataGridView1.TabIndex = 7;
            // 
            // test
            // 
            this.test.HeaderText = "test";
            this.test.Name = "test";
            // 
            // Stockin_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bntView);
            this.Controls.Add(this.lblSinoutRecord);
            this.Controls.Add(this.btnout);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btnNewEntry);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Stockin_out";
            this.Text = "Stockin_out";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewEntry;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btnout;
        private System.Windows.Forms.Label lblSinoutRecord;
        private System.Windows.Forms.Button bntView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn test;
    }
}