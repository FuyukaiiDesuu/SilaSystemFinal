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
    public partial class newfrmAddTransaction : Form
    {
        public Accounting.newfrmAccount reference { get; set; }
        public MySqlConnection dbconnection;
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;
        //public DataTable balanceDisplay { get; set; }
        //public DataTable GradeLevelDisplay { get; set; }
        /*
        public string id { get; set; }
        public string name { get; set; }
        public string uname { get; set; }
        public string uid { get; set; }*/

        //Accounting.DbQueries dbquery = new Accounting.DbQueries();
        //bool cmbChecker = false;
        //int countPayment;
        public string eid;
        public IDictionary<string, string> dic;
        public newfrmAddTransaction(IDictionary<string, string> d, string empid, string uname)
        {
            InitializeComponent();
            dic = d;
            eid = empid;
            txtChequeNo.Enabled = false;
            lblUser.Text = uname;
            txtStudentName.Text = dic["fullname"];
        }

        private void newfrmAddTransaction_Load(object sender, EventArgs e)
        {
            txtTransactionNo.Text = SerialMaker();
            timer1.Enabled = true;
            /*
            txtStudentID.Text = id;
            lblUserID.Text = uid;
            txtStudentName.Text = name;
            
            txtChequeNo.Enabled = false;
            DataTable cntPayment = dbquery.countPayment();
            countPayment = cntPayment.Rows.Count + 1;
            txtTransactionNo.Text = countPayment.ToString().PadLeft(10, '0');
            txtAdditionalDetails.Enabled = false;
            DataTable adid = dbquery.getAdid(id);
            txtAccountID.Text = adid.Rows[0][0].ToString();
            lblUser.Text = uname;
            lblUserID.Visible = false;*/
        }
        private decimal paidforaccount(decimal amount)
        {
            decimal sum = 0.00M;
            using (MySqlConnection conn = connect.connector())
            {

                string query = "SELECT * FROM accountdetails WHERE adid = '" + dic["adid"] + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                sum = decimal.Round(amount, 2) + decimal.Round(decimal.Parse(dt.Rows[0]["paid_amount"].ToString()), 2);
            }
            return sum;
        }
        private string SerialMaker()
        {
            Int32 a;
            string date = DateTime.Now.ToString("yyyyMMdd");
            string query2 = "SELECT COUNT(*) FROM payment";
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                using (var command2 = new MySqlCommand(query2, dbconnection))
                {
                    dbconnection.Open();
                    a = Convert.ToInt32(command2.ExecuteScalar().ToString());
                }
            }
           
            return date + a.ToString("0000");
        }

        private Boolean checker()
        {

            return false;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                string query2 = "INSERT INTO payment" +
                    "(payment_type, cheque_no, paymentStatus, amount_paid, date_paid, eid, adid, transaction_no, additional_details, payment_to, syear) " +
                    "VALUES(@pt, @cqno, @pstatus, @apaid, @dpaid, @eid, @adid, @tansaction_no, @adet, @pto, @sy);";
                using (var command2 = new MySqlCommand(query2, dbconnection))
                {
                    if (cmbPaymentType.Text == "Cheque")
                    {
                        command2.Parameters.AddWithValue("@pt", 2);
                        command2.Parameters.AddWithValue("@cqno", txtChequeNo.Text);
                        command2.Parameters.AddWithValue("@pstatus", 2);
                    }
                    else
                    {

                        command2.Parameters.AddWithValue("@pt", 1);
                        command2.Parameters.AddWithValue("@cqno", null);
                        command2.Parameters.AddWithValue("@pstatus", 1);
                    }
                    command2.Parameters.AddWithValue("@apaid", txtAmount.Text);
                    command2.Parameters.AddWithValue("@dpaid", lblPaymentDate2.Text);
                    command2.Parameters.AddWithValue("@eid", eid);
                    command2.Parameters.AddWithValue("@adid", dic["adid"]);
                    command2.Parameters.AddWithValue("@tansaction_no", SerialMaker());
                    command2.Parameters.AddWithValue("@pto", cmbPaymentTo.Text);
                    command2.Parameters.AddWithValue("@adet", txtAdditionalDetails.Text);
                    command2.Parameters.AddWithValue("@sy", comboBox2.Text);

                    command2.ExecuteNonQuery();
                }
                using (dbconnection = dbconnect.connector())
                {
                    dbconnection.Open();
                    string queryy = "UPDATE accountdetails SET paid_amount = @paidamount WHERE adid = @ayd;";
                    using (var command2 = new MySqlCommand(queryy, dbconnection))
                    {
                        command2.Parameters.AddWithValue("@ayd", dic["adid"]);
                        command2.Parameters.AddWithValue("@paidamount", paidforaccount(decimal.Parse(txtAmount.Text)));
                        command2.ExecuteNonQuery();
                    }

                    /*
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
                    */

                    MessageBox.Show("Succesfully Paid");
                    reference.Show();
                    //reference.loadBalanceDetails(id);
                    reference.dataSearch.ClearSelection();
                    reference.dataBalanceDetails.ClearSelection();
                    this.Close();
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            reference.Show();
            reference.dataBalanceDetails.ClearSelection();
            reference.dataSearch.ClearSelection();
            this.Close();
        }

        private void cmbPaymentType_TextChanged(object sender, EventArgs e)
        {
            if (cmbPaymentType.Text == "Cheque")
            {
                txtChequeNo.Enabled = true;
            }
            else
            {
                txtChequeNo.Enabled = false;
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblPaymentDate2.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss ");
            //lblPaymentDate3.Text = DateTime.Now.ToString("tt");
            timer1.Start();
        }

        private void cmbPaymentTo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
