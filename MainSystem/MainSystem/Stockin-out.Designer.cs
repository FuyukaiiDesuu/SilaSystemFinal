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
            this.dgvInventory2 = new System.Windows.Forms.DataGridView();
            this.btnNewEntry = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.btnout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSinoutRecord = new System.Windows.Forms.Label();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventory2
            // 
            this.dgvInventory2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column1,
            this.Column5,
            this.Column6});
            this.dgvInventory2.Location = new System.Drawing.Point(12, 121);
            this.dgvInventory2.Name = "dgvInventory2";
            this.dgvInventory2.Size = new System.Drawing.Size(643, 181);
            this.dgvInventory2.TabIndex = 0;
            // 
            // btnNewEntry
            // 
            this.btnNewEntry.Location = new System.Drawing.Point(23, 317);
            this.btnNewEntry.Name = "btnNewEntry";
            this.btnNewEntry.Size = new System.Drawing.Size(75, 23);
            this.btnNewEntry.TabIndex = 1;
            this.btnNewEntry.Text = "New Entry";
            this.btnNewEntry.UseVisualStyleBackColor = true;
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(127, 317);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(75, 23);
            this.btnin.TabIndex = 2;
            this.btnin.Text = "IN";
            this.btnin.UseVisualStyleBackColor = true;
            // 
            // btnout
            // 
            this.btnout.Location = new System.Drawing.Point(228, 317);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(75, 23);
            this.btnout.TabIndex = 3;
            this.btnout.Text = "OUT";
            this.btnout.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(447, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblSinoutRecord
            // 
            this.lblSinoutRecord.AutoSize = true;
            this.lblSinoutRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinoutRecord.Location = new System.Drawing.Point(12, 94);
            this.lblSinoutRecord.Name = "lblSinoutRecord";
            this.lblSinoutRecord.Size = new System.Drawing.Size(231, 24);
            this.lblSinoutRecord.TabIndex = 5;
            this.lblSinoutRecord.Text = "Stock in and Out record";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item Name";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Code";
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "IN";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "OUT";
            this.Column6.Name = "Column6";
            // 
            // bntView
            // 
            this.bntView.Location = new System.Drawing.Point(340, 317);
            this.bntView.Name = "bntView";
            this.bntView.Size = new System.Drawing.Size(75, 23);
            this.bntView.TabIndex = 6;
            this.bntView.Text = "View";
            this.bntView.UseVisualStyleBackColor = true;
            // 
            // Stockin_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.bntView);
            this.Controls.Add(this.lblSinoutRecord);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnout);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btnNewEntry);
            this.Controls.Add(this.dgvInventory2);
            this.Name = "Stockin_out";
            this.Text = "Stockin_out";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory2;
        private System.Windows.Forms.Button btnNewEntry;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btnout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label lblSinoutRecord;
        private System.Windows.Forms.Button bntView;
    }
}