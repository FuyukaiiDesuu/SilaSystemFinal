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

namespace MainSystem
{
    public partial class validateCheque : Form
    {
        public MySqlConnection dbconnection;
        public MySqlDataAdapter adapter;
        public DataTable dt;
        public Accounting.newfrmAccount reference { get; set; }
        public IDictionary<string, string> dict;
        public validateCheque(IDictionary<string, string> d)
        {
            InitializeComponent();
            dict = d;
        }

        private void validateCheque_Load(object sender, EventArgs e)
        {
            tno.Text = dict["tno"];
            chqno.Text = dict["cno"];
            amnt.Text = "₱"+dict["apaid"];
            if (dict["status"] == "2")
            {
                comboBox1.Text = "Pending";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                string query2 = "UPDATE payment SET paymentStatus = @status WHERE pid = @ayd";
                using (var command2 = new MySqlCommand(query2, dbconnection))
                {
                    if(comboBox1.Text == "Validated")
                    {
                        command2.Parameters.AddWithValue("@status", 1);
                    }
                    else if(comboBox1.Text == "Pending")
                    {
                        command2.Parameters.AddWithValue("@status", 2);
                        
                    }
                    else
                    {
                        command2.Parameters.AddWithValue("@status", 3);
                    }
                    command2.Parameters.AddWithValue("@ayd", dict["pid"]);
                    command2.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Payment Validated!");
            this.Dispose();
            reference.Show();
            reference.loadBalanceDetails();
            reference.loadPaymentDetails();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Pending")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            reference.Show();
            reference.loadBalanceDetails();
            reference.loadPaymentDetails();
        }
    }
}
