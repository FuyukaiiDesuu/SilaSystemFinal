using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MainSystem.Accounting
{
    public partial class frmViewPaymentHistory : Form
    {
        public Accounting.newfrmAccount reference { get; set; }
        Accounting.DbQueries dbquery = new Accounting.DbQueries();
        public string uname { get; set; }
        public IDictionary<string, string> d2;
        public MySqlConnection dbconnection;
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;
        public string syeartempo = "2018 - 2019";
        public frmViewPaymentHistory(IDictionary<string,string> dict)
        {
            InitializeComponent();
            d2 = dict;
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
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT transaction_no, date_paid, amount_paid, cheque_no, payment_to, additional_details, syear FROM silasystemdb.payment " +
                    "WHERE adid = '" + d2["adid"] + "' AND syear = '" + syeartempo + "' AND paymentStatus = 1;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataPaymentHistory.DataSource = dt;

                dataPaymentHistory.Columns["transaction_no"].HeaderText = "Transaction No.";
                dataPaymentHistory.Columns["date_paid"].HeaderText = "Date Paid";
                dataPaymentHistory.Columns["amount_paid"].HeaderText = "Amount Paid";
                dataPaymentHistory.Columns["cheque_no"].HeaderText = "Cheque No.";
                dataPaymentHistory.Columns["payment_to"].HeaderText = "Payment No.";
                dataPaymentHistory.Columns["additional_details"].HeaderText = "Additional Details";
                dataPaymentHistory.Columns["syear"].HeaderText = "School Year";
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
        
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
