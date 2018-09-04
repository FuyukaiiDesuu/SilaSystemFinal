﻿using System;
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
        public newfrmEditAccount(IDictionary<string, string>d)
        {
            InitializeComponent();
            dict = d;
            defaulttext();
            textboxfill();
        }
        private void defaulttext()
        {
            txttpb.Text = "₱0";
            txtregp.Text = "₱0";
            tuitiontxt.Text = "₱0";
            txtbp.Text = "₱0";
            txtmp.Text = "₱0";
             
        }
        //string accid;
        private decimal balOthers()
        {

            using (MySqlConnection conn = connect.connector())
            {
                decimal sum = 0.00M;
                string query = "SELECT * FROM feevalues WHERE f_key = '" + dict["fid"] + "' " +
                    "AND fee_description = 'Others' " +
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
                    return sum;
                }
                else
                {
                    return 0.00M;
                }

            }
        }
        private decimal balTuition()
        {

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
                    return sum;
                }
                else
                {
                   return 0.00M;
                }

            }
            
        }
        private decimal balRegis()
        {
            decimal sum = 0.00M;
            using (MySqlConnection conn = connect.connector())
            {
                
                string query = "SELECT * FROM feevalues WHERE f_key = '" + dict["fid"] + "' " +
                    "AND fee_description = 'Registration' " +
                    "AND Status = 1;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
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
                    "AND payment_to = 'Registration';";
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

            using (MySqlConnection conn = connect.connector())
            {
                decimal sum = 0.00M;
                string query = "SELECT * FROM feevalues WHERE f_key = '" + dict["fid"] + "' " +
                    "AND fee_description = 'Books' " +
                    "AND Status = 1;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        sum = sum + decimal.Round(decimal.Parse(row["current_amount"].ToString()), 2);
                    }
                    return sum;
                }
                else
                {
                    return 0.00M;
                }

            }
        }
        public Int32 schoolMonths = 0;
        private decimal totalPayableTuition()
        {
            schoolMonths = 10;
            return balTuition() * schoolMonths;
        }

        private decimal totalBalancePayable()
        {
            return totalPayableTuition() + balRegis() + balOthers() + balBooks();
        }

        private void textboxfill()
        {
            tuitiontxt.Text = "₱" + balTuition().ToString();
            txtmp.Text = "₱" + balOthers().ToString();
            txttpb.Text = "₱" + totalBalancePayable().ToString();
            txttottu.Text = "₱" + totalPayableTuition().ToString();
            txtregp.Text = "₱" + balRegis().ToString();
            txtbp.Text = "₱" + balBooks().ToString();

        }
        private void newfrmEditAccount_Load(object sender, EventArgs e)
        {
            /*
            timer1.Enabled = true;
            lblUser.Text = uname;
            txtStudentID.Text = id;
            txtStudentName.Text = name;
            */
            dateTimePicker2.CustomFormat = "MMMM, yyyy";
            dateTimePicker3.CustomFormat = "MMMM, yyyy";
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
            reference.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            lblDate2.Text = DateTime.Now.ToString("tt");
            timer1.Start();
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

        private void grpStudentDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
