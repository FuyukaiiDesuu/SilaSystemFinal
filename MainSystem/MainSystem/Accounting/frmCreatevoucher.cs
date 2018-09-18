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
        public string syear { get; set; }
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
            lblsy.Text = syear;
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

        private Boolean textboxvalidate()
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnAddFee_Click(object sender, EventArgs e)
        {
            if(textboxvalidate())
            {
                DialogResult res = MessageBox.Show("PROCEED WITH CREATING VOUCHER?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    var dbconnect = new dbConnector();
                    using (dbconnection = dbconnect.connector())
                    {
                        dbconnection.Open();
                        string query2 = "INSERT INTO disbursement(Voucher_Number, Amount, Details, Date_recorded, empID, syear) VALUES(@vn, @amnt, @details, @date, @eid, @syear);";
                        using (var command2 = new MySqlCommand(query2, dbconnection))
                        {
                            command2.Parameters.AddWithValue("@vn", SerialMaker());
                            command2.Parameters.AddWithValue("@amnt", textBox2.Text);
                            command2.Parameters.AddWithValue("@details", textBox1.Text);
                            command2.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                            command2.Parameters.AddWithValue("@eid", empId);
                            command2.Parameters.AddWithValue("@syear", syear);
                            command2.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Voucher Created Sucessfully");
                    this.Close();
                    reference.loadDisbursementtbl();
                }
            }
            else
            {
                MessageBox.Show("PLEASE FILL ALL NECESSARY FIELDS!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("ARE YOU SURE YOU WANT TO CANCEL?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
                reference.Show();
                reference.loadDisbursementtbl();
            }

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
    }
}
