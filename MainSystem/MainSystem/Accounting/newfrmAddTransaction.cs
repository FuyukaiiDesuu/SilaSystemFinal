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

        public DataTable balanceDisplay { get; set; }
        public DataTable GradeLevelDisplay { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string uname { get; set; }
        public string uid { get; set; }

        Accounting.DbQueries dbquery = new Accounting.DbQueries();
        bool cmbChecker = false;
        int countPayment;

        public newfrmAddTransaction()
        {
            InitializeComponent();
        }

        private void newfrmAddTransaction_Load(object sender, EventArgs e)
        {
            txtStudentID.Text = id;
            lblUserID.Text = uid;
            txtStudentName.Text = name;
            timer1.Enabled = true;
            txtChequeNo.Enabled = false;
            DataTable cntPayment = dbquery.countPayment();
            countPayment = cntPayment.Rows.Count + 1;
            txtTransactionNo.Text = countPayment.ToString().PadLeft(10, '0');
            txtAdditionalDetails.Enabled = false;
            DataTable adid = dbquery.getAdid(id);
            txtAccountID.Text = adid.Rows[0][0].ToString();
            lblUser.Text = uname;
            lblUserID.Visible = false;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            dbquery.updatePayments(txtTransactionNo.Text, cmbPaymentType.Text, txtChequeNo.Text, txtAmount.Text, lblPaymentDate2.Text, lblUserID.Text, txtAccountID.Text, txtAdditionalDetails.Text, cmbPaymentTo.Text, balanceDisplay.Rows[0]["fid"].ToString());

            string amount;
            if (balanceDisplay.Rows[0]["paid_amount"].ToString() == null || balanceDisplay.Rows[0]["paid_amount"].ToString() == "")
            {
                amount = txtAmount.Text;
            }
            else
            {
                if (Convert.ToInt32(balanceDisplay.Rows[0]["paid_amount"].ToString()) == 0)
                {
                    amount = txtAmount.Text;
                }
                else
                {
                    amount = (Convert.ToInt32(balanceDisplay.Rows[0]["paid_amount"].ToString()) + Convert.ToInt32(txtAmount.Text)).ToString();
                }
            }

            if (cmbPaymentTo.Text == "Others")
            {
                if (Convert.ToInt32(balanceDisplay.Rows[0]["current_balance"].ToString()) == 0 || Convert.ToInt32(balanceDisplay.Rows[0]["current_balance"].ToString()) < 0)
                {
                    dbquery.updateAccountDetails(txtAccountID.Text, balanceDisplay.Rows[0]["current_balance"].ToString(), amount, "PAID");
                    dbquery.updatePaymentLog(txtStudentID.Text, txtTransactionNo.Text, lblPaymentDate2.Text, GradeLevelDisplay.Rows[0]["fee_type"].ToString(), balanceDisplay.Rows[0]["current_balance"].ToString(), txtAmount.Text, "PAID", txtStudentName.Text);
                }
                else
                {
                    dbquery.updateAccountDetails(txtAccountID.Text, balanceDisplay.Rows[0]["current_balance"].ToString(), amount, "PARTIALLY PAID");
                    dbquery.updatePaymentLog(txtStudentID.Text, txtTransactionNo.Text, lblPaymentDate2.Text, GradeLevelDisplay.Rows[0]["fee_type"].ToString(), balanceDisplay.Rows[0]["current_balance"].ToString(), txtAmount.Text, "PARTIALLY PAID", txtStudentName.Text);
                }

            }
            else
            {
                string currentbal = (Convert.ToInt32(balanceDisplay.Rows[0]["current_balance"].ToString()) - Convert.ToInt32(txtAmount.Text)).ToString();
                if (Convert.ToInt32(currentbal) == 0 || Convert.ToInt32(currentbal) < 0)
                {
                    dbquery.updateAccountDetails(txtAccountID.Text, currentbal, amount, "PAID");
                    dbquery.updatePaymentLog(txtStudentID.Text, txtTransactionNo.Text, lblPaymentDate2.Text, GradeLevelDisplay.Rows[0]["fee_type"].ToString(), currentbal, txtAmount.Text, "PAID", txtStudentName.Text);
                }
                else
                {
                    dbquery.updateAccountDetails(txtAccountID.Text, currentbal, amount, "PARTIALLY PAID");
                    dbquery.updatePaymentLog(txtStudentID.Text, txtTransactionNo.Text, lblPaymentDate2.Text, GradeLevelDisplay.Rows[0]["fee_type"].ToString(), currentbal, txtAmount.Text, "PARTIALLY PAID", txtStudentName.Text);
                }
            }


            MessageBox.Show("Succesfully Paid");
            reference.Show();
            reference.loadBalanceDetails(id);
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
                txtChequeNo.Enabled = true;
                cmbChecker = true;
            }
            else
            {
                txtChequeNo.Enabled = false;
                cmbChecker = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblPaymentDate2.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            lblPaymentDate3.Text = DateTime.Now.ToString("tt");
            timer1.Start();
        }

        private void cmbPaymentTo_TextChanged(object sender, EventArgs e)
        {
            if(cmbPaymentTo.Text == "Others")
            {
                txtAdditionalDetails.Enabled = true;
            }
            else
            {
                txtAdditionalDetails.Enabled = false;
            }
        }
    }
}
