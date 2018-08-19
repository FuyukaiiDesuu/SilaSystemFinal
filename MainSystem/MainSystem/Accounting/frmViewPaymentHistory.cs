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
    public partial class frmViewPaymentHistory : Form
    {
        public Accounting.newfrmAccount reference { get; set; }
        Accounting.DbQueries dbquery = new Accounting.DbQueries();
        public string uname { get; set; }
        public frmViewPaymentHistory()
        {
            InitializeComponent();
        }

        private void frmViewPaymentHistory_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            loadStudentPaymentLog();
            lblUser.Text = uname;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }
        public void loadStudentPaymentLog()
        {
            DataTable studentpaymentlog = dbquery.StudentPaymentLog();
            this.dataPaymentHistory.DataSource = studentpaymentlog;

            dataPaymentHistory.Columns["student_id"].HeaderText = "Student ID";
            dataPaymentHistory.Columns["payment_id"].HeaderText = "Payment ID";
            dataPaymentHistory.Columns["date_created"].HeaderText = "Date Created";
            dataPaymentHistory.Columns["grade_level"].HeaderText = "Grade Level";
            dataPaymentHistory.Columns["current_balance"].HeaderText = "Current Balance";
            dataPaymentHistory.Columns["amount_paid"].HeaderText = "Amount Paid";
            dataPaymentHistory.Columns["payment_status"].HeaderText = "Payment Status";
            dataPaymentHistory.Columns["id"].Visible = false;

            dataPaymentHistory.ReadOnly = true;
            this.dataPaymentHistory.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            lblDate2.Text = DateTime.Now.ToString("tt");
            timer1.Start();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string student_id = txtSearch.Text;
            DataTable holder = dbquery.SearchPayment(student_id);
            dataPaymentHistory.DataSource = holder;
        }
    }
}
