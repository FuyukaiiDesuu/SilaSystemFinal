namespace MainSystem
{
    partial class frmAddTransaction
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
            this.grpNewPayment = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // grpNewPayment
            // 
            this.grpNewPayment.Location = new System.Drawing.Point(17, 37);
            this.grpNewPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNewPayment.Name = "grpNewPayment";
            this.grpNewPayment.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNewPayment.Size = new System.Drawing.Size(1033, 373);
            this.grpNewPayment.TabIndex = 0;
            this.grpNewPayment.TabStop = false;
            this.grpNewPayment.Text = "New Payment";
            // 
            // frmAddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpNewPayment);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Transaction";
            this.Load += new System.EventHandler(this.frmAddTransaction_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewPayment;
    }
}