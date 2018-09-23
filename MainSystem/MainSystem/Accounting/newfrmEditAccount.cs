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
using System.Text.RegularExpressions;

namespace MainSystem.Accounting
{
    public partial class newfrmEditAccount : Form
    {
        public MySqlConnection dbconnection;
        public MySqlDataAdapter adapter;
        public DataTable dt;
        dbConnector connect = new dbConnector();
        public Accounting.newfrmAccount reference { get; set; }
        Accounting.DbQueries dbquery = new Accounting.DbQueries();
        //public DataTable editacc = null;
        //public string id { get; set; }
        //public string name { get; set; }
        //public string uname { get; set; }
        public IDictionary<string, string> dict;
        public string TEMPORARYSYEAR { get; set; }
        public newfrmEditAccount(IDictionary<string, string> d)
        {
            InitializeComponent();
            dict = d;
            defaulttext();
            //sygetter();
        }
        private void defaulttext()
        {

            txtStudentName.Text = dict["fullname"];
            txtsec.Text = dict["sect"];
            txtlvl.Text = dict["level"];
            txttpb.Text = "₱0.00";
            txtregp.Text = "₱0.00";
            //tuitiontxt.Text = "₱0.00";
            txtbp.Text = "₱0.00";
            txtmp.Text = "₱0.00";
            texttuiton.Text = "₱0.00";
            texttuiton.SelectionStart = texttuiton.Text.Length;
            textbooks.Text = "₱0.00";
            textmisc.Text = "₱0.00";
            textregis.Text = "₱0.00";

        }
        //string accid;
        private decimal balOthers()
        {
            decimal sum = 0.00M;
            using (MySqlConnection conn = connect.connector())
            {

                string query = "SELECT * FROM feevalues WHERE f_key = '" + dict["fid"] + "' " +
                    "AND fee_description = 'Others' " +
                    "AND Status = 1 " +
                    "AND syear = '" + TEMPORARYSYEAR + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        sum = sum + decimal.Round(decimal.Parse(row["current_amount"].ToString()), 2);
                    }

                }
                else
                {
                    sum = 0.00M;
                }

            }
            decimal sum2 = 0.00M;
            using (MySqlConnection conn = connect.connector())
            {

                string query = "SELECT * FROM payment WHERE adid = '" + dict["adid"] + "' " +
                    "AND payment_to = 'Others' AND paymentStatus = 1 AND syear = '" + TEMPORARYSYEAR + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        sum2 = sum2 + decimal.Round(decimal.Parse(row["amount_paid"].ToString()), 2);
                    }

                }
                else
                {
                    sum2 = 0.00M;
                }

            }
            return sum - sum2;
        }
        private decimal balTuition()
        {
            decimal totalpayablesum = 0.00M;
            decimal sum = 0.00M;
            using (MySqlConnection conn = connect.connector())
            {

                string query = "SELECT * FROM feevalues WHERE f_key = '" + dict["fid"] + "' " +
                    "AND fee_description = 'Tuition' " +
                    "AND Status = 1 " +
                    "AND syear = '" + TEMPORARYSYEAR + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        sum = sum + decimal.Round(decimal.Parse(row["current_amount"].ToString()), 2);
                    }

                }
                else
                {
                    sum = 0.00M;
                }

            }
            decimal sum2 = 0.00M;
            using (MySqlConnection conn = connect.connector())
            {

                string query = "SELECT * FROM payment WHERE adid = '" + dict["adid"] + "' " +
                    "AND payment_to = 'Tuition' AND paymentStatus = 1 AND syear = '" + TEMPORARYSYEAR + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        sum2 = sum2 + decimal.Round(decimal.Parse(row["amount_paid"].ToString()), 2);
                    }

                }
                else
                {
                    sum2 = 0.00M;
                }

            }
            totalpayablesum = sum * schoolMonths;
            return totalpayablesum - sum2;

        }
        private decimal balRegis()
        {
            decimal sum = 0.00M;
            using (MySqlConnection conn = connect.connector())
            {

                string query = "SELECT * FROM feevalues WHERE f_key = '" + dict["fid"] + "' " +
                    "AND fee_description = 'Registration' " +
                    "AND Status = 1 " +
                    "AND syear = '" + TEMPORARYSYEAR + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        sum = sum + decimal.Round(decimal.Parse(row["current_amount"].ToString()), 2);
                    }

                }
                else
                {
                    sum = 0.00M;
                }

            }
            decimal sum2 = 0.00M;
            using (MySqlConnection conn = connect.connector())
            {

                string query = "SELECT * FROM payment WHERE adid = '" + dict["adid"] + "' " +
                    "AND payment_to = 'Registration' AND paymentStatus = 1 AND syear = '" + TEMPORARYSYEAR + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        sum2 = sum2 + decimal.Round(decimal.Parse(row["amount_paid"].ToString()), 2);
                    }

                }
                else
                {
                    sum2 = 0.00M;
                }

            }
            return sum - sum2;
        }
        private decimal balBooks()
        {
            decimal sum = 0.00M;
            using (MySqlConnection conn = connect.connector())
            {

                string query = "SELECT * FROM feevalues WHERE f_key = '" + dict["fid"] + "' " +
                    "AND fee_description = 'Books' " +
                    "AND Status = 1 " +
                    "AND syear = '"+TEMPORARYSYEAR+"';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        sum = sum + decimal.Round(decimal.Parse(row["current_amount"].ToString()), 2);
                    }

                }
                else
                {
                    sum = 0.00M;
                }

            }
            decimal sum2 = 0.00M;
            using (MySqlConnection conn = connect.connector())
            {

                string query = "SELECT * FROM payment WHERE adid = '" + dict["adid"] + "' " +
                    "AND payment_to = 'Books' AND paymentStatus = 1 AND syear = '" + TEMPORARYSYEAR + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        sum2 = sum2 + decimal.Round(decimal.Parse(row["amount_paid"].ToString()), 2);
                    }

                }
                else
                {
                    sum2 = 0.00M;
                }

            }
            return sum - sum2;
        }
        public Int32 schoolMonths = 10;
        private void totalPayableTuition()
        {
            /*
            schoolMonths = 10;
            decimal sum = 0.00M;
            using (MySqlConnection conn = connect.connector())
            {

                string query = "SELECT * FROM feevalues WHERE f_key = '" + dict["fid"] + "' " +
                    "AND fee_description = 'Tuition' " +
                    "AND Status = 1;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        sum = sum + decimal.Round(decimal.Parse(row["current_amount"].ToString()), 2);
                    }
                    return sum * schoolMonths;
                }
                else
                {
                    return sum = 0.00M;
                }

            }*/

        }

        private decimal totalBalancePayable()
        {
            return balTuition() + balRegis() + balOthers() + balBooks();
        }

        private void textboxfill()
        {
            txttottu.Text = balTuition().ToString("C2", new CultureInfo("en-PH"));
            txtmp.Text = balOthers().ToString("C2", new CultureInfo("en-PH"));
            txttpb.Text = totalBalancePayable().ToString("C2", new CultureInfo("en-PH"));
            txtregp.Text = balRegis().ToString("C2", new CultureInfo("en-PH"));
            txtbp.Text = balBooks().ToString("C2", new CultureInfo("en-PH"));
        }
        private void tuitionBalanceCalculate()
        {
            /*
            using (MySqlConnection conn = connect.connector())
            {
                decimal sum = 0.00M;
                string query = "SELECT * FROM feevalues WHERE f_key = '" + dict["fid"] + "' " +
                    "AND fee_description = 'Tuition' " +
                    "AND Status = 1;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        sum = sum + decimal.Round(decimal.Parse(row["current_amount"].ToString()), 2);
                    }

                }
                else
                {
                    sum = 0.00M;
                }

                int astart = int.Parse(dateTimePicker2.Value.ToString("MM"));
                MessageBox.Show(astart.ToString());
                int aend = int.Parse(dateTimePicker3.Value.ToString("MM"));
                int yrs = int.Parse(dateTimePicker2.Value.ToString("MM"));
                int yre = int.Parse(dateTimePicker3.Value.ToString("MM"));
                int final = Math.Abs(((yrs - yre) * 12) + astart - aend);
                MessageBox.Show(final.ToString());
                decimal finalnajud = Convert.ToDecimal(final) * sum;

                return decimal.Round(finalnajud, 2);*/

        }
        private void newfrmEditAccount_Load(object sender, EventArgs e)
        {
            lblsy.Text = TEMPORARYSYEAR;
            //MessageBox.Show(TEMPORARYSYEAR);
            textboxfill();
            /*
            timer1.Enabled = true;
            lblUser.Text = uname;
            txtStudentID.Text = id;
            txtStudentName.Text = name;
            */
            //MessageBox.Show(balOthers().ToString());

            /*
            DataTable adid = dbquery.getAdid(id);
            txtStudentAccountID.Text = adid.Rows[0][0].ToString();
            txtDateDue.Text = adid.Rows[0][1].ToString();
            txtTotalAmount.Text = adid.Rows[0][2].ToString();
            txtCurrentBalance.Text = adid.Rows[0][3].ToString();
            txtPaidAmount.Text = adid.Rows[0][4].ToString();
            lblPaymentStatus2.Text = adid.Rows[0][5].ToString();
            TextColor();*/
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Details Will Be Discarded!, Proceed?", "WARNING!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                reference.Show();
                this.Close();
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        /*
        private void TextColor()
        {
            if (lblPaymentStatus2.Text == "PAID")
            {
                lblPaymentStatus2.Location = new Point(397, 114);
                lblPaymentStatus2.ForeColor = Color.Green;
            }
            else
            {
                lblPaymentStatus2.ForeColor = Color.Red;
            }
        }*/

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void sygetter()
        {

        }
        private void grpStudentDetails_Enter(object sender, EventArgs e)
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

        private void label13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public SOAccount soaform;
        public IDictionary<string, string> dicforsoaform;
        private Boolean txtboxvalidate()
        {
            if ((texttuiton.Text == "₱0.00"  || texttuiton.Text == "₱0") && (textbooks.Text == "₱0.00" || textbooks.Text == "₱0") && (textregis.Text == "₱0.00" || textregis.Text == "₱0" ) && (textmisc.Text == "₱0.00" || textmisc.Text == "₱0"))
            {
                MessageBox.Show("PLEASE FILL ALL NECESSARY FIELDS!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtboxvalidate())
            {
                DialogResult dialogResult = MessageBox.Show("Confirm Action!", "The Document Will Be Printed", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    dicforsoaform = new Dictionary<string, string>();
                    dicforsoaform.Add("tuition", texttuiton.Text);
                    dicforsoaform.Add("books", textbooks.Text);
                    dicforsoaform.Add("regis", textregis.Text);
                    dicforsoaform.Add("others", textmisc.Text);
                    dicforsoaform.Add("date", dateTimePicker1.Value.ToString("MMMM-dd-yyyy"));
                    dicforsoaform.Add("fullname", txtStudentName.Text);
                    dicforsoaform.Add("section", txtsec.Text);
                    dicforsoaform.Add("level", txtlvl.Text);

                    soaform = new SOAccount(dicforsoaform);
                    soaform.syear = lblsy.Text;
                    soaform.Show();
                }
            }
        }

        private void grpStudentAccount_Enter(object sender, EventArgs e)
        {

        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }
        private void textregis_TextChanged(object sender, EventArgs e)
        {
            if (textregis.Text.Length <= 1)
            {
                textregis.Text = "₱";
                textregis.SelectionStart = texttuiton.Text.Length;
            }
        }
        private void textregis_KeyPress(object sender, KeyPressEventArgs e)
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
        private void textregis_Leave(object sender, EventArgs e)
        {
            if (textregis.Text.Length <= 1)
            {
                textregis.Text = "₱0.00";
            }
            Decimal a = Decimal.Round(Decimal.Parse(textregis.Text.TrimStart('₱')), 2);
            textregis.Text = a.ToString("C2", new CultureInfo("en-PH"));
        }
        private void textbooks_Leave(object sender, EventArgs e)
        {
            if (textbooks.Text.Length <= 1)
            {
                textbooks.Text = "₱0.00";
            }
            Decimal a = Decimal.Round(Decimal.Parse(textbooks.Text.TrimStart('₱')), 2);
            textbooks.Text = a.ToString("C2", new CultureInfo("en-PH"));
        }
        private void textbooks_TextChanged(object sender, EventArgs e)
        {
            if (textbooks.Text.Length <= 1)
            {
                textbooks.Text = "₱";
                textbooks.SelectionStart = texttuiton.Text.Length;
            }
        }
        private void textbooks_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void textbooks_KeyPress(object sender, KeyPressEventArgs e)
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
        private void textmisc_Leave(object sender, EventArgs e)
        {
            if (textmisc.Text.Length <= 1)
            {
                textmisc.Text = "₱0.00";
            }
            Decimal a = Decimal.Round(Decimal.Parse(textmisc.Text.TrimStart('₱')), 2);
            textmisc.Text = a.ToString("C2", new CultureInfo("en-PH"));
        }
        private void textmisc_KeyPress(object sender, KeyPressEventArgs e)
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
        private void textmisc_TextChanged(object sender, EventArgs e)
        {
            if (textmisc.Text.Length <= 1)
            {
                textmisc.Text = "₱";
                textmisc.SelectionStart = textmisc.Text.Length;
            }
        }
        private void texttuiton_Leave(object sender, EventArgs e)
        {
            if(texttuiton.Text.Length <= 1)
            {
                texttuiton.Text = "₱0.00";
            }
            Decimal a = Decimal.Round(Decimal.Parse(texttuiton.Text.TrimStart('₱')), 2);
            texttuiton.Text = a.ToString("C2", new CultureInfo("en-PH"));
        }
        private void texttuiton_KeyPress(object sender, KeyPressEventArgs e)
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
        private void texttuiton_Enter(object sender, EventArgs e)
        {
            
        }
        private void texttuiton_TextChanged(object sender, EventArgs e)
        {
          if(texttuiton.Text.Length <= 1)
            {
                texttuiton.Text = "₱";
                texttuiton.SelectionStart = texttuiton.Text.Length;
            }
        }
    } 
}
