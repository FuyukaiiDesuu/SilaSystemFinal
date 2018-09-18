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
using System.Globalization;

namespace MainSystem.Accounting
{
    public partial class newfrmAddTransaction : Form
    {
        public Accounting.newfrmAccount reference { get; set; }
        public string syeartemp { get; set; }
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
            dgvcart.DefaultCellStyle.ForeColor = Color.Black;
        }
        private void textboxclr()
        {
            cmbPaymentTo.SelectedIndex = -1;
            //comboBox2.SelectedIndex = -1;
            txtAdditionalDetails.Text = "NONE";
            txtSubTotal.Text = "₱0.00";
            txtChequeNo.Clear();
            cmbPaymentType.SelectedIndex = -1;
        }
        private void newfrmAddTransaction_Load(object sender, EventArgs e)
        {
            txtTransactionNo.Text = SerialMaker();
            lblsy.Text = syeartemp;
            lblsy2.Text = syeartemp;
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
            txtSubTotal.Text = "₱0.00";
            txtAmount.Text = "₱0.00";
            txttendered.Text = "₱0.00";
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
           
            return date + a.ToString("10000");
        }

        private Boolean checker()
        {
            return false;
        }
        public TenderedForm tf;
        public void payQuery(IDictionary<string, string> dic1)
        {
            IDictionary<string, string> d = dic1;
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                string query2 = "INSERT INTO payment" +
                    "(payment_type, cheque_no, paymentStatus, amount_paid, date_paid, eid, adid, transaction_no, additional_details, payment_to, syear) " +
                    "VALUES(@pt, @cqno, @pstatus, @apaid, @dpaid, @eid, @adid, @tansaction_no, @adet, @pto, @sy);";
                using (var command2 = new MySqlCommand(query2, dbconnection))
                {
                    if (d["ptype"] == "Cheque")
                    {
                        command2.Parameters.AddWithValue("@pt", 2);
                        command2.Parameters.AddWithValue("@cqno", d["cno"]);
                        command2.Parameters.AddWithValue("@pstatus", 2);
                    }
                    else
                    {

                        command2.Parameters.AddWithValue("@pt", 1);
                        command2.Parameters.AddWithValue("@cqno", null);
                        command2.Parameters.AddWithValue("@pstatus", 1);
                    }
                    var a = d["adue"].TrimStart('₱');
                    command2.Parameters.AddWithValue("@apaid", a);
                    command2.Parameters.AddWithValue("@dpaid", d["pdate"]);
                    command2.Parameters.AddWithValue("@eid", eid);
                    command2.Parameters.AddWithValue("@adid", dic["adid"]);
                    command2.Parameters.AddWithValue("@tansaction_no", d["tno"]);
                    command2.Parameters.AddWithValue("@pto", d["pto"]);
                    command2.Parameters.AddWithValue("@adet", d["addet"]);
                    command2.Parameters.AddWithValue("@sy", d["sy"]);

                    command2.ExecuteNonQuery();
                }
            }
            if(d["ptype"] == "Cash")
            {
                checkpayer();
            }

        }
        public void payermechanism()
        {
            IDictionary<string, string> a = new Dictionary<string, string>();
            foreach(DataGridViewRow row in dgvcart.Rows)
            {
                a.Clear();
                a.Add("tno", row.Cells[0].Value.ToString());
                a.Add("ptype", row.Cells[1].Value.ToString());
                a.Add("cno", row.Cells[2].Value.ToString());
                a.Add("adue", row.Cells[3].Value.ToString());
                a.Add("pto", row.Cells[4].Value.ToString());
                a.Add("sname", row.Cells[5].Value.ToString());
                a.Add("sy", row.Cells[6].Value.ToString());
                a.Add("pdate", row.Cells[7].Value.ToString());
                a.Add("addet", row.Cells[8].Value.ToString());
                payQuery(a);
            }
           
        }
        public void checkpayer()
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                string queryy = "UPDATE accountdetails SET paid_amount = @paidamount WHERE adid = @ayd;";
                using (var command2 = new MySqlCommand(queryy, dbconnection))
                {
                    command2.Parameters.AddWithValue("@ayd", dic["adid"]);
                    command2.Parameters.AddWithValue("@paidamount", paidforaccount(decimal.Parse(txtAmount.Text.TrimStart('₱'))));
                    command2.ExecuteNonQuery();
                }   
            }
        }
        private Boolean dgvemptycheck()
        {
            if(dgvcart.Rows.Count == 0)
            {
                DialogResult result = MessageBox.Show("There Are Currently No Subtransactions!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else
            {
                return false;
            }
        }
        private Boolean finalamountcheck()
        {
            if (txttendered.Text == "₱0.00" || txttendered.Text == "₱0" || txttendered.Text == "₱" || txttendered.Text == "₱0." || txttendered.Text == "₱0.0")
            {
                MessageBox.Show("PLEASE CHECK TENDERED AMOUNT!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            if(!dgvemptycheck())
            {
                if(finalamountcheck())
                {
                    DialogResult result = MessageBox.Show("Do You Want To Proceed To Payment?", "CONFIRM ACTION!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        tf = new TenderedForm();
                        tf.amount = txtAmount.Text;
                        tf.tndr = txttendered.Text;
                        tf.reference = this;
                        if (tf.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("TRANSACTION SUCESSFULLY COMPLETED!");
                            payermechanism();
                            reference.Show();
                            //reference.loadBalanceDetails(id);
                            reference.loadBalanceDetails();
                            reference.loadPaymentDetails();
                            this.Close();
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DISCARD TRANSACTION?", "CONFIRM ACTION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
           
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

        private void label15_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close this application?", "S.I.L.A Enrollment and Accounting System", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text.Length <= 1)
            {
                txtAmount.Text = "₱";
                txtAmount.SelectionStart = txtAmount.Text.Length;
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (txtAmount.Text.Length <= 1)
            {
                txtAmount.Text = "₱0.00";
            }
            Decimal a = Decimal.Round(Decimal.Parse(txtAmount.Text.TrimStart('₱')), 2);
            txtAmount.Text = "₱" + a.ToString("0.##");
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txttendered_TextChanged(object sender, EventArgs e)
        {
            if (txttendered.Text.Length <= 1)
            {
                txttendered.Text = "₱";
                txttendered.SelectionStart = txtAmount.Text.Length;
            }
        }

        private void txttendered_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txttendered_Leave(object sender, EventArgs e)
        {
            if (txttendered.Text.Length <= 1)
            {
                txttendered.Text = "₱0.00";
            }
            Decimal a = Decimal.Round(Decimal.Parse(txttendered.Text.TrimStart('₱')), 2);
            txttendered.Text = "₱" + a.ToString("0.##");
        }

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {
            if (txtSubTotal.Text.Length <= 1)
            {
                txtSubTotal.Text = "₱";
                txtSubTotal.SelectionStart = txtAmount.Text.Length;
            }
        }

        private void txtSubTotal_Leave(object sender, EventArgs e)
        {
            if (txtSubTotal.Text.Length <= 1)
            {
                txtSubTotal.Text = "₱0.00";
            }
            Decimal a = Decimal.Round(Decimal.Parse(txtSubTotal.Text.TrimStart('₱')), 2);
            txtSubTotal.Text = "₱" + a.ToString("0.##");
        }

        private void txtSubTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void textboxadder(string subtotal)
        {
            Decimal b = Decimal.Round(Decimal.Parse(txtAmount.Text.TrimStart('₱')), 2);
            Decimal a = Decimal.Round(Decimal.Parse(subtotal.ToString().TrimStart('₱')),2);
            txtAmount.Text = "₱" + (a + b).ToString();
        }
        private void txtboxminus(string subtotal)
        {
            Decimal b = Decimal.Round(Decimal.Parse(txtAmount.Text.TrimStart('₱')), 2);
            Decimal a = Decimal.Round(Decimal.Parse(subtotal.ToString().TrimStart('₱')), 2);
            txtAmount.Text = "₱" + (b - a).ToString();
        }
        private Boolean addcarttxtvalidate()
        {
            if(txtTransactionNo.Text == "" || cmbPaymentType.Text == "" || txtSubTotal.Text == "" || cmbPaymentTo.Text == "" || txtStudentName.Text == "" || txtAdditionalDetails.Text == "")
            {
                MessageBox.Show("PLEASE FILL ALL NECESSARY FIELDS!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private Boolean subtotalCheck()
        {
            if (txtSubTotal.Text == "₱0.00" || txtSubTotal.Text == "₱0" || txtSubTotal.Text == "₱" || txtSubTotal.Text == "₱0." || txtSubTotal.Text == "₱0.0")
            {
                MessageBox.Show("PLEASE CHECK ENTERED SUBTOTAL AMOUNT!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnADDTOCART_Click(object sender, EventArgs e)
        {
            if(addcarttxtvalidate())
            {
                if(subtotalCheck())
                {
                    DialogResult rs = MessageBox.Show("This Sub-transaction Will Be Added! Proceed?", "WARNING!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (rs == DialogResult.OK)
                    {
                        int rowindex = dgvcart.Rows.Add();
                        dgvcart.Rows[rowindex].Cells[0].Value = txtTransactionNo.Text;
                        dgvcart.Rows[rowindex].Cells[1].Value = cmbPaymentType.Text;
                        dgvcart.Rows[rowindex].Cells[2].Value = txtChequeNo.Text;
                        dgvcart.Rows[rowindex].Cells[3].Value = txtSubTotal.Text;
                        textboxadder(txtSubTotal.Text);
                        dgvcart.Rows[rowindex].Cells[4].Value = cmbPaymentTo.Text;
                        dgvcart.Rows[rowindex].Cells[5].Value = txtStudentName.Text;
                        dgvcart.Rows[rowindex].Cells[6].Value = lblsy2.Text;
                        dgvcart.Rows[rowindex].Cells[7].Value = lblPaymentDate2.Text;
                        dgvcart.Rows[rowindex].Cells[8].Value = txtAdditionalDetails.Text;
                        textboxclr();
                        MessageBox.Show("Sub-transaction Added!");
                    }
                }
            }
            //ADD DIALOG BOX!
            
        }

        private void btnremovecart_Click(object sender, EventArgs e)
        {
            if(!dgvemptycheck())
            {
                DialogResult rs = MessageBox.Show("This Sub-transaction will be deleted! Proceed?", "WARNING!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (rs == DialogResult.OK)
                {
                    foreach (DataGridViewRow item in this.dgvcart.SelectedRows)
                    {
                        txtboxminus(dgvcart.Rows[item.Index].Cells[3].Value.ToString());
                        dgvcart.Rows.RemoveAt(item.Index);
                        MessageBox.Show("Sub-transaction Removed!");
                    }
                }
            }
        }

        private void grpNewPayment_Enter(object sender, EventArgs e)
        {

        }
    }
}
