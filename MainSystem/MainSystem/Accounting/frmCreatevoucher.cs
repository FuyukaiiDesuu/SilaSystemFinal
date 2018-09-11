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
    public partial class frmCreatevoucher : Form
    {
        public MySqlConnection dbconnection;
        public MySqlDataAdapter adapter;
        public DataTable dt;
        public Accounting.newfrmAccount reference { get; set; }
        string username;
        string empId;
        public frmCreatevoucher(string empid, string uname)
        {
            InitializeComponent();
            empId = empid;
            username = uname;
        }

        private void frmCreatevoucher_Load(object sender, EventArgs e)
        {
            textBox3.Text = SerialMaker();
        }
        private string SerialMaker()
        {
            Int32 a;
            string date = DateTime.Now.ToString("yyyyMMdd");
            string query2 = "SELECT COUNT(*) FROM disbursement";
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                using (var command2 = new MySqlCommand(query2, dbconnection))
                {
                    dbconnection.Open();
                    a = Convert.ToInt32(command2.ExecuteScalar().ToString());
                }
            }

            return date + a.ToString("20000");
        }
        private void btnAddFee_Click(object sender, EventArgs e)
        {
            var dbconnect = new dbConnector();
            using (dbconnection = dbconnect.connector())
            {
                dbconnection.Open();
                string query2 = "INSERT INTO disbursement(Voucher_Number, Amount, Details, Date_recorded, empID) VALUES(@vn, @amnt, @details, @date, @eid);";
                using (var command2 = new MySqlCommand(query2, dbconnection))
                {
                    command2.Parameters.AddWithValue("@vn", SerialMaker());
                    command2.Parameters.AddWithValue("@amnt", textBox2.Text);
                    command2.Parameters.AddWithValue("@details", textBox1.Text);
                    command2.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                    command2.Parameters.AddWithValue("@eid", empId);
                    command2.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Voucher Created Sucessfully");
            this.Close();
            reference.Show();
            reference.loadDisbursementtbl();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            reference.Show();
            reference.loadDisbursementtbl();
        }
    }
}
