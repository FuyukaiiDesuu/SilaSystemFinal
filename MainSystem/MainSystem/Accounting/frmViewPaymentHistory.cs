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
using System.Text.RegularExpressions;

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
        public string syeartempo { get; set; }
        public frmViewPaymentHistory(IDictionary<string,string> dict)
        {
            InitializeComponent();
            d2 = dict;
        }

        private void frmViewPaymentHistory_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblUser.Text = uname;
            comboBox2.Text = syeartempo;
            loadStudentPaymentLog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("DO YOU WANT TO GO BACK?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                reference.Show();
                this.Close();
            }
           
        }
        public void loadStudentPaymentLog()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT FirstName, LastName, level_dummyval, transaction_no, date_paid, amount_paid, cheque_no, payment_to, additional_details, syear FROM silasystemdb.payment INNER JOIN accountdetails" +
                   " ON payment.adid = accountdetails.adid INNER JOIN studentprofile" +
                   " ON accountdetails.spid = studentprofile.idstudentprofile INNER JOIN studdetails ON studentprofile.idstuddet = studdetails.idstddet" +
                   " WHERE syear = '"+syeartempo+"'";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataPaymentHistory.DataSource = dt;
                dataPaymentHistory.Columns["level_dummyval"].HeaderText = "Level";
                dataPaymentHistory.Columns["transaction_no"].HeaderText = "Transaction No.";
                dataPaymentHistory.Columns["date_paid"].HeaderText = "Date Paid";
                dataPaymentHistory.Columns["amount_paid"].HeaderText = "Amount Paid";
                dataPaymentHistory.Columns["cheque_no"].HeaderText = "Cheque No.";
                dataPaymentHistory.Columns["payment_to"].HeaderText = "Payment No.";
                dataPaymentHistory.Columns["additional_details"].HeaderText = "Additional Details";
                dataPaymentHistory.Columns["syear"].HeaderText = "School Year";
            }
            
        }
        private void searchpayment()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT FirstName, LastName, level_dummyval, transaction_no, date_paid, amount_paid, cheque_no, payment_to, additional_details, syear FROM silasystemdb.payment INNER JOIN accountdetails" +
                    " ON payment.adid = accountdetails.adid INNER JOIN studentprofile" +
                    " ON accountdetails.spid = studentprofile.idstudentprofile INNER JOIN studdetails ON studentprofile.idstuddet = studdetails.idstddet" +
                    " WHERE FirstName LIKE '%" + txtSearch.Text + "%'" +
                    " AND syear = '" + comboBox2.Text + "'" +
                    " AND date_paid LIKE '%" + datetimesearch.Value.ToString("yyyy-MM-dd") + "%'" +
                    " OR LastName LIKE '%" + txtSearch.Text + "%'" +
                    " AND syear = '" + comboBox2.Text + "'" +
                    " AND date_paid LIKE '%" + datetimesearch.Value.ToString("yyyy-MM-dd") + "%'" +
                    " OR level_dummyval LIKE '%" + txtSearch.Text + "'" +
                    " AND syear = '" + comboBox2.Text + "'" +
                    " AND date_paid LIKE '%" + datetimesearch.Value.ToString("yyyy-MM-dd") + "%';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataPaymentHistory.DataSource = dt;
                dataPaymentHistory.Columns["level_dummyval"].HeaderText = "Level";
                dataPaymentHistory.Columns["transaction_no"].HeaderText = "Transaction No.";
                dataPaymentHistory.Columns["date_paid"].HeaderText = "Date Paid";
                dataPaymentHistory.Columns["amount_paid"].HeaderText = "Amount Paid";
                dataPaymentHistory.Columns["cheque_no"].HeaderText = "Cheque No.";
                dataPaymentHistory.Columns["payment_to"].HeaderText = "Payment To";
                dataPaymentHistory.Columns["additional_details"].HeaderText = "Additional Details";
                dataPaymentHistory.Columns["syear"].HeaderText = "School Year";
            }

        }
        private void searchpayment2()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT FirstName, LastName, level_dummyval, transaction_no, date_paid, amount_paid, cheque_no, payment_to, additional_details, syear FROM silasystemdb.payment INNER JOIN accountdetails" +
                    " ON payment.adid = accountdetails.adid INNER JOIN studentprofile" +
                    " ON accountdetails.spid = studentprofile.idstudentprofile INNER JOIN studdetails ON studentprofile.idstuddet = studdetails.idstddet" +
                    " WHERE FirstName LIKE '%" + txtSearch.Text + "%'" +
                    //" AND syear = '" + comboBox2.Text + "'" +
                    //" AND date_paid LIKE '%" + datetimesearch.Value.ToString("yyyy-MM-dd") + "%'" +
                    " OR LastName LIKE '%" + txtSearch.Text + "%'" +
                    //" AND syear = '" + comboBox2.Text + "'" +
                    //" AND date_paid LIKE '%" + datetimesearch.Value.ToString("yyyy-MM-dd") + "%'" +
                    " OR level_dummyval LIKE '%" + txtSearch.Text + "';";
                    //" AND syear = '" + comboBox2.Text + "';";
                    //" AND date_paid LIKE '%" + datetimesearch.Value.ToString("yyyy-MM-dd") + "%';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataPaymentHistory.DataSource = dt;
                dataPaymentHistory.Columns["level_dummyval"].HeaderText = "Level";
                dataPaymentHistory.Columns["transaction_no"].HeaderText = "Transaction No.";
                dataPaymentHistory.Columns["date_paid"].HeaderText = "Date Paid";
                dataPaymentHistory.Columns["amount_paid"].HeaderText = "Amount Paid";
                dataPaymentHistory.Columns["cheque_no"].HeaderText = "Cheque No.";
                dataPaymentHistory.Columns["payment_to"].HeaderText = "Payment To.";
                dataPaymentHistory.Columns["additional_details"].HeaderText = "Additional Details";
                dataPaymentHistory.Columns["syear"].HeaderText = "School Year";
            }

        }
        public string sy;
        public string date;
        private void searchpaymentsy()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT FirstName, LastName, level_dummyval, transaction_no, date_paid, amount_paid, cheque_no, payment_to, additional_details, syear FROM silasystemdb.payment INNER JOIN accountdetails" +
                   " ON payment.adid = accountdetails.adid INNER JOIN studentprofile" +
                   " ON accountdetails.spid = studentprofile.idstudentprofile INNER JOIN studdetails ON studentprofile.idstuddet = studdetails.idstddet" +
                   " WHERE FirstName LIKE '%" + txtSearch.Text + "%'" +
                   " AND syear = '" + comboBox2.Text + "'" +
                   //" AND date_paid LIKE '%" + datetimesearch.Value.ToString("yyyy-MM-dd") + "%'" +
                   " OR LastName LIKE '%" + txtSearch.Text + "%'" +
                   " AND syear = '" + comboBox2.Text + "'" +
                   //" AND date_paid LIKE '%" + datetimesearch.Value.ToString("yyyy-MM-dd") + "%'" +
                   " OR level_dummyval LIKE '%" + txtSearch.Text + "'" +
                   " AND syear = '" + comboBox2.Text + "';";
                   //" AND date_paid LIKE '%" + datetimesearch.Value.ToString("yyyy-MM-dd") + "%';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataPaymentHistory.DataSource = dt;
                dataPaymentHistory.Columns["level_dummyval"].HeaderText = "Level";
                dataPaymentHistory.Columns["transaction_no"].HeaderText = "Transaction No.";
                dataPaymentHistory.Columns["date_paid"].HeaderText = "Date Paid";
                dataPaymentHistory.Columns["amount_paid"].HeaderText = "Amount Paid";
                dataPaymentHistory.Columns["cheque_no"].HeaderText = "Cheque No.";
                dataPaymentHistory.Columns["payment_to"].HeaderText = "Payment No.";
                dataPaymentHistory.Columns["additional_details"].HeaderText = "Additional Details";
                dataPaymentHistory.Columns["syear"].HeaderText = "School Year";
            }
        }
        private void searchpaymenttime()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT FirstName, LastName, level_dummyval, transaction_no, date_paid, amount_paid, cheque_no, payment_to, additional_details, syear FROM silasystemdb.payment INNER JOIN accountdetails" +
                   " ON payment.adid = accountdetails.adid INNER JOIN studentprofile" +
                   " ON accountdetails.spid = studentprofile.idstudentprofile INNER JOIN studdetails ON studentprofile.idstuddet = studdetails.idstddet" +
                   " WHERE FirstName LIKE '%" + txtSearch.Text + "%'" +
                   //" AND syear = '" + comboBox2.Text + "'" +
                   " AND date_paid LIKE '%" + datetimesearch.Value.ToString("yyyy-MM-dd") + "%'" +
                   " OR LastName LIKE '%" + txtSearch.Text + "%'" +
                   //" AND syear = '" + comboBox2.Text + "'" +
                   " AND date_paid LIKE '%" + datetimesearch.Value.ToString("yyyy-MM-dd") + "%'" +
                   " OR level_dummyval LIKE '%" + txtSearch.Text + "'" +
                   //" AND syear = '" + comboBox2.Text + "'" +
                   " AND date_paid LIKE '%" + datetimesearch.Value.ToString("yyyy-MM-dd") + "%';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataPaymentHistory.DataSource = dt;
                dataPaymentHistory.Columns["level_dummyval"].HeaderText = "Level";
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void datetimesearch_ValueChanged(object sender, EventArgs e)
        {
            //date = datetimesearch.Value.ToString("yyyy-MM-dd");
            //searchpaymenttime();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
           
            if(checkBox1.Checked == false && checkBox2.Checked == false)
            {
                searchpayment2();
            }
            else if(checkBox1.Checked == true && checkBox2.Checked == false)
            {
                searchpaymentsy();
            }
            else
            {
                searchpayment();
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            searchpaymentsy();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                loadStudentPaymentLog();
                searchpaymentsy();
                comboBox2.Enabled = true;
                
            }
            else
            {
                loadStudentPaymentLog();
                comboBox2.Enabled = false;
                comboBox2.Text = syeartempo;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        { 
            if(checkBox2.Checked)
            {
                loadStudentPaymentLog();
                searchpaymenttime();
                datetimesearch.Enabled = true;
            }
            else
            {
                loadStudentPaymentLog();
                //searchpaymentsy();
                datetimesearch.Enabled = false;
                datetimesearch.Value = DateTime.Today;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s\b,.-]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                MessageBox.Show("The Text Must Can Only Consist Of Alphabets and Numbers, and The Characters: '-,.'", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
