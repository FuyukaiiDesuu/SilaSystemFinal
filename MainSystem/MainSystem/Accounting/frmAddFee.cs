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
    public partial class frmAddFee : Form
    {
        public MySqlConnection dbconnection;
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;
        public Accounting.newfrmAccount reference { get; set; }

        public DataTable dtadd = null;
        DbQueries dbquery = new DbQueries();
        DataTable accountDetailsValues = null;
       
        bool checker;
        public string uname { get; set; }
        public IDictionary<string, string> d;
        public frmAddFee(bool feeCheck, IDictionary<string, string> dic)
        {
           
            InitializeComponent();
            checker = feeCheck;
            d = dic;
        }
        public frmAddFee(bool feeCheck)
        {

            InitializeComponent();
            checker = feeCheck;
        }
        public string ayd;
        public string dateC;
        private void textboxfiller(IDictionary<string, string> d)
        {
            dateC = d["dc"];
            ayd = d["fid"];
            cmbGradeLevel.Text = d["ftype"];
            if(d["fdesc"] == "Others")
            {
                textBox1.Enabled = true;
                textBox1.Text = d["mdesc"];
                comboBox1.Text = d["fdesc"];
            }
            else
            {
                comboBox1.Text = d["fdesc"];
            }
            txtAmount.Text = d["amount"];
            textBox2.Text = d["sy"];
        }
        private void frmAddFee_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            timer1.Enabled = true;
            lblUser.Text = uname;
            textBox2.Text = sygetter();

            if (checker == false)
            {
                textboxfiller(d);
                //cmbGradeLevel.Text = dtadd.Rows[0]["fee_type"].ToString();
                //txtAmount.Text = dtadd.Rows[0]["current_amount"].ToString();
                //txtFeeDescription.Text = dtadd.Rows[0]["fee_description"].ToString();
                //dateYearStart.Value = Convert.ToDateTime(dtadd.Rows[0]["school_year_start"]);
                //dateYearEnd.Value = Convert.ToDateTime(dtadd.Rows[0]["school_year_end"]);
                btnAdd.Text = "Update";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reference.Show();
            reference.dataSearch.ClearSelection();
            reference.dataBalanceDetails.ClearSelection();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            lblDate2.Text = DateTime.Now.ToString("tt");
            timer1.Start();
        }

        private string sygetter()
        {
            string sy;
            Int32 a = Convert.ToInt32(DateTime.Now.Year.ToString());
            Int32 b = Convert.ToInt32(DateTime.Now.Year.ToString()) + 1;
            return a.ToString() + " - " + b.ToString();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string s_key;
            if (cmbGradeLevel.Text == "Toddler")
            {
                s_key = "1";
            }
            else if (cmbGradeLevel.Text == "Nursery")
            {
                s_key = "2";
            }
            else if (cmbGradeLevel.Text == "Kindergarten")
            {
                s_key = "3";
            }
            else if (cmbGradeLevel.Text == "Preparatory")
            {
                s_key = "4";
            }
            else if (cmbGradeLevel.Text == "Grade 1")
            {
                s_key = "5";
            }
            else if (cmbGradeLevel.Text == "Grade 2")
            {
                s_key = "6";
            }
            else if (cmbGradeLevel.Text == "Grade 3")
            {
                s_key = "7";
            }
            else if (cmbGradeLevel.Text == "Grade 4")
            {
                s_key = "8";
            }
            else if (cmbGradeLevel.Text == "Grade 5")
            {
                s_key = "9";
            }
            else if (cmbGradeLevel.Text == "Grade 6")
            {
                s_key = "10";
            }
            else if (cmbGradeLevel.Text == "Grade 7")
            {
                s_key = "11";
            }
            else if (cmbGradeLevel.Text == "Grade 8")
            {
                s_key = "12";
            }
            else if (cmbGradeLevel.Text == "Grade 9")
            {
                s_key = "13";
            }
            else
            {
                s_key = "14";
            }
            if(checker)
            {
                var dbconnect = new dbConnector();
                using (dbconnection = dbconnect.connector())
                {
                    dbconnection.Open();
                    string query2 = "INSERT INTO feevalues" +
                        "(fee_type, fee_description, misc_desc, current_amount, date_created, f_key, Status, syear)" +
                        "VALUES(@ftype, @fdesc, @mdesc, @cmount, @dcrt, @fkey, @status, @sy);";
                    using (var command2 = new MySqlCommand(query2, dbconnection))
                    {
                        command2.Parameters.AddWithValue("@ftype", cmbGradeLevel.Text);
                        if(comboBox1.Text != "Others")
                        {
                            command2.Parameters.AddWithValue("@fdesc", comboBox1.Text);
                        }
                        else
                        {
                            command2.Parameters.AddWithValue("@mdesc", textBox1.Text);
                            command2.Parameters.AddWithValue("@fdesc", comboBox1.Text);
                        }
                        command2.Parameters.AddWithValue("@cmount", txtAmount.Text);
                        command2.Parameters.AddWithValue("@dcrt", lblDate.Text);
                        command2.Parameters.AddWithValue("@fkey", s_key);
                        command2.Parameters.AddWithValue("@status", 1);
                        command2.Parameters.AddWithValue("@sy", sygetter());

                        command2.ExecuteNonQuery();
                    }
                    MessageBox.Show("Successfully Added");
                    reference.Show();
                    reference.loadFeeDetails();
                    reference.dataBalanceDetails.ClearSelection();
                    reference.dataSearch.ClearSelection();
                    this.Close();

                }
            }
            if(!checker)
            {
                var dbconnect = new dbConnector();
                using (dbconnection = dbconnect.connector())
                {
                    dbconnection.Open();
                    string query2 = "UPDATE feevalues " +
                        "SET fee_type = @ftype, " +
                        "fee_description = @fdesc, " +
                        "misc_desc = @mdesc, " +
                        "current_amount = @cmount, " +
                        "date_created = @dcrt, " +
                        "date_modified = @dmod, " +
                        "f_key = @fkey, " +
                        "Status = @status, " +
                        "syear = @sy WHERE fid = @ayd;";
                    using (var command2 = new MySqlCommand(query2, dbconnection))
                    {
                        command2.Parameters.AddWithValue("@ftype", cmbGradeLevel.Text);
                        if (comboBox1.Text != "Others")
                        {
                            command2.Parameters.AddWithValue("@fdesc", comboBox1.Text);
                            command2.Parameters.AddWithValue("@mdesc", null);
                        }
                        else
                        {
                            command2.Parameters.AddWithValue("@mdesc", textBox1.Text);
                            command2.Parameters.AddWithValue("@fdesc", comboBox1.Text);
                        }
                        command2.Parameters.AddWithValue("@cmount", txtAmount.Text);
                        command2.Parameters.AddWithValue("@dcrt", dateC);
                        command2.Parameters.AddWithValue("@dmod", lblDate.Text);
                        command2.Parameters.AddWithValue("@fkey", s_key);
                        command2.Parameters.AddWithValue("@status", 1);
                        command2.Parameters.AddWithValue("@sy", sygetter());
                        command2.Parameters.AddWithValue("@ayd", ayd);

                        command2.ExecuteNonQuery();
                    }
                    MessageBox.Show("Successfully Updated");
                    reference.Show();
                    reference.loadFeeDetails();
                    reference.dataBalanceDetails.ClearSelection();
                    reference.dataSearch.ClearSelection();
                    this.Close();

                }
            }
            

            /*
            string balance = "";
            if (checker == true)
            {
                dbquery.updateFee(cmbGradeLevel.Text, txtFeeDescription.Text, txtAmount.Text, lblDate.Text, dateYearStart.Value.ToString("yyyy-MM-dd"), dateYearEnd.Value.ToString("yyyy-MM-dd"), s_key);
                DataTable fee_amount = dbquery.totalFeeAmount(cmbGradeLevel.Text);
                accountDetailsValues = dbquery.accountDetails(s_key);
                

                for (int i = 0; i < accountDetailsValues.Rows.Count; i++)
                {

                    if (Convert.ToInt32(accountDetailsValues.Rows[i]["current_balance"].ToString()) <= Convert.ToInt32(accountDetailsValues.Rows[i]["total_amount"].ToString()))
                    {
                        if (Convert.ToInt32(accountDetailsValues.Rows[i]["current_balance"].ToString()) <= 0)
                        {
                            balance = (Convert.ToInt32(accountDetailsValues.Rows[i]["current_balance"].ToString()) + Convert.ToInt32(txtAmount.Text)).ToString();
                        }
                        else
                        {
                            balance = (Convert.ToInt32(accountDetailsValues.Rows[i]["current_balance"].ToString()) + Convert.ToInt32(txtAmount.Text)).ToString();
                        }
                    }
                    else
                    {
                        balance = fee_amount.Rows[0][0].ToString();
                    }
                    dbquery.updateAccountDetailsFee(fee_amount.Rows[0][0].ToString(), balance, s_key);
                }
                MessageBox.Show("Successfully Added");
                reference.Show();
                reference.loadFeeDetails();
                reference.dataBalanceDetails.ClearSelection();
                reference.dataSearch.ClearSelection();
                this.Close();
            }
            else
            {

                dbquery.updateNewFee(dtadd.Rows[0]["fid"].ToString(), cmbGradeLevel.Text, txtFeeDescription.Text, txtAmount.Text, lblDate.Text, dateYearStart.Value.ToString("yyyy-MM-dd"), dateYearEnd.Value.ToString("yyyy-MM-dd"));
                DataTable fee_amount = dbquery.totalFeeAmount(cmbGradeLevel.Text);
                accountDetailsValues = dbquery.accountDetails(s_key);
                

                for (int i = 0; i < accountDetailsValues.Rows.Count; i++)
                {
                    if (Convert.ToInt32(accountDetailsValues.Rows[i]["current_balance"].ToString()) <= Convert.ToInt32(accountDetailsValues.Rows[i]["total_amount"].ToString()))
                    {
                        balance = (Convert.ToInt32(accountDetailsValues.Rows[i]["current_balance"].ToString()) + Convert.ToInt32(txtAmount.Text)).ToString();
                    }
                    else
                    {
                        balance = fee_amount.Rows[0][0].ToString();
                    }
                    dbquery.updateAccountDetailsFee(fee_amount.Rows[0][0].ToString(), balance, s_key);
                }
                MessageBox.Show("Successfully Updated");
                reference.Show();
                reference.loadFeeDetails();
                this.Close();
            }*/
        }

        private void dateYearStart_ValueChanged(object sender, EventArgs e)
        {
            /*
            dateYearEnd.Enabled = true;
            dateYearEnd.MinDate = dateYearStart.Value;*/
        }

        private void grpAddFee_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Others")
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }
    }
}
