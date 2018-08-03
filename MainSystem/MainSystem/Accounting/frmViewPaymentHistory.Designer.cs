namespace MainSystem.Accounting
{
    partial class frmViewPaymentHistory
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
            this.dataPaymentHistory2 = new System.Windows.Forms.DataGridView();
            this.dataPaymentHistory = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaymentHistory2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaymentHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPaymentHistory2
            // 
            this.dataPaymentHistory2.AllowUserToAddRows = false;
            this.dataPaymentHistory2.AllowUserToDeleteRows = false;
            this.dataPaymentHistory2.AllowUserToResizeColumns = false;
            this.dataPaymentHistory2.AllowUserToResizeRows = false;
            this.dataPaymentHistory2.BackgroundColor = System.Drawing.Color.White;
            this.dataPaymentHistory2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPaymentHistory2.Location = new System.Drawing.Point(236, 11);
            this.dataPaymentHistory2.Margin = new System.Windows.Forms.Padding(2);
            this.dataPaymentHistory2.Name = "dataPaymentHistory2";
            this.dataPaymentHistory2.RowHeadersVisible = false;
            this.dataPaymentHistory2.RowTemplate.Height = 24;
            this.dataPaymentHistory2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPaymentHistory2.Size = new System.Drawing.Size(202, 274);
            this.dataPaymentHistory2.TabIndex = 3;
            // 
            // dataPaymentHistory
            // 
            this.dataPaymentHistory.AllowUserToAddRows = false;
            this.dataPaymentHistory.AllowUserToDeleteRows = false;
            this.dataPaymentHistory.AllowUserToResizeColumns = false;
            this.dataPaymentHistory.AllowUserToResizeRows = false;
            this.dataPaymentHistory.BackgroundColor = System.Drawing.Color.White;
            this.dataPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPaymentHistory.Location = new System.Drawing.Point(13, 10);
            this.dataPaymentHistory.Margin = new System.Windows.Forms.Padding(2);
            this.dataPaymentHistory.Name = "dataPaymentHistory";
            this.dataPaymentHistory.RowHeadersVisible = false;
            this.dataPaymentHistory.RowTemplate.Height = 24;
            this.dataPaymentHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPaymentHistory.Size = new System.Drawing.Size(202, 274);
            this.dataPaymentHistory.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(372, 289);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 31);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmViewPaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 327);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataPaymentHistory2);
            this.Controls.Add(this.dataPaymentHistory);
            this.Name = "frmViewPaymentHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Payment History";
            this.Load += new System.EventHandler(this.frmViewPaymentHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPaymentHistory2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPaymentHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPaymentHistory2;
        private System.Windows.Forms.DataGridView dataPaymentHistory;
        private System.Windows.Forms.Button btnBack;
    }
}