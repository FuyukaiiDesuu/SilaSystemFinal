using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem.Accounting
{
    public partial class newfrmAddTransaction : Form
    {
        public Accounting.newfrmAccount reference { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        Accounting.DbQueries dbquery = new Accounting.DbQueries();
        bool cmbChecker = false;

        public newfrmAddTransaction()
        {
            InitializeComponent();
        }

        private void newfrmAddTransaction_Load(object sender, EventArgs e)
        {
            txtStudentID.Text = id;
            txtStudentName.Text = name;
            timer1.Enabled = true;
            lblChequeNo.Visible = false;
            txtChequeNo.Visible = false;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            dbquery.updatePayments(txtTransactionNo.Text, cmbPaymentType.Text, txtChequeNo.Text, txtAmount.Text, lblPaymentDate2.Text, "1", "2");
            MessageBox.Show("Succesfully Paid");
            reference.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }

        private void cmbPaymentType_TextChanged(object sender, EventArgs e)
        {
            if (cmbPaymentType.Text == "Cheque")
            {
                lblChequeNo.Visible = true;
                txtChequeNo.Visible = true;
                cmbChecker = true;
            }
            else
            {
                lblChequeNo.Visible = false;
                txtChequeNo.Visible = false;
                cmbChecker = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblPaymentDate2.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            lblPaymentDate3.Text = DateTime.Now.ToString("tt");
            timer1.Start();
        }

    }
}
