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
    public partial class newfrmEditAccount : Form
    {
        public MySqlConnection dbconnection;
        dbConnector connect = new dbConnector();
        public Accounting.newfrmAccount reference { get; set; }
        Accounting.DbQueries dbquery = new Accounting.DbQueries();
        public DataTable editacc = null;
        public string id { get; set; }
        public string name { get; set; }
        public string uname { get; set; }
        public newfrmEditAccount()
        {
            InitializeComponent();
        }

        private void newfrmEditAccount_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblUser.Text = uname;
            txtStudentID.Text = id;
            txtStudentName.Text = name;



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
        }
    }
}
