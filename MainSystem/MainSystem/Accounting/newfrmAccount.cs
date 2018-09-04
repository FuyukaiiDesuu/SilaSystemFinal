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
    public partial class newfrmAccount : Form
    {
        public frmMain reference { get; set; }
        Accounting.DbQueries dbquery = new Accounting.DbQueries();
        public string uname;
        string fullname;
        public string uid;
        public MySqlConnection dbconnection;
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;

        /*
        string fee_type;
        string current_amount;
        string school_year_start;
        string school_year_end;
        string fid;
        string fee_description;*/
        
        public newfrmAccount(string uname)
        {
            InitializeComponent();
            loadStudentProfileTable();
            lblUser.Text = uname;
        }

        private void newfrmAccount_Load(object sender, EventArgs e)
        {
            loadFeeDetails();
            dataSearch.ClearSelection();
            dataFeeValue.ClearSelection();
        }

        public void loadStudentProfileTable()
        {
            DataTable studentDisplay = dbquery.studentProfileDisplay();
            this.dataSearch.DataSource = studentDisplay;

            dataSearch.Columns["idstudentprofile"].Visible = false;
            dataSearch.Columns["FirstName"].Visible = false;
            dataSearch.Columns["LastName"].Visible = false;
            dataSearch.Columns["MiddleName"].Visible = false;
            dataSearch.Columns["fullname"].HeaderText = "Full Name";
            dataSearch.Columns["DateOfBirth"].HeaderText = "Date Of Birth";
            dataSearch.Columns["PlaceOfBirth"].Visible = false;
            dataSearch.Columns["Sex"].HeaderText = "Sex";
            dataSearch.Columns["Religion"].Visible = false;
            dataSearch.Columns["NickName"].HeaderText = "Nickname";
            dataSearch.Columns["Status"].Visible = false;
            dataSearch.Columns["idstuddet"].Visible = false;
            dataSearch.Columns["adid"].Visible = false;
            dataSearch.Columns["paid_amount"].Visible = false;
            dataSearch.Columns["payment_status"].Visible = false;
            dataSearch.Columns["spid"].Visible = false;
            dataSearch.Columns["did"].Visible = false;
            dataSearch.Columns["fid"].Visible = false;



            dataSearch.Columns["fullname"].DisplayIndex = 4;

            dataSearch.ReadOnly = true;
            this.dataSearch.Columns["fullname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataSearch.Refresh();
        }

        public void loadBalanceDetails(string student_id)
        {
            /*
            DataTable balanceDisplay = dbquery.balanceDetails(student_id);
            this.dataBalanceDetails.DataSource = balanceDisplay;

            dataBalanceDetails.Columns["Name"].HeaderText = "Name";
            dataBalanceDetails.Columns["fee_type"].HeaderText = "Grade Level";
            dataBalanceDetails.Columns["current_balance"].HeaderText = "Current Balance";
            dataBalanceDetails.Columns["paid_amount"].HeaderText = "Amount Paid";
            dataBalanceDetails.Columns["payment_status"].HeaderText = "Payment Status";
            dataBalanceDetails.Columns["adid"].Visible = false;
            dataBalanceDetails.Columns["fid"].Visible = false;

            dataBalanceDetails.ReadOnly = true;*/
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT paid_amount, payment_status, spid, did, fid, FirstName, LastName, MiddleName, Status " +
                    "FROM accountdetails " +
                    "INNER JOIN studentprofile " +
                    "ON accountdetails.spid = studentprofile.idstudentprofile";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataBalanceDetails.DataSource = dt;
            }
            dataBalanceDetails.ClearSelection();
            this.dataBalanceDetails.Refresh();
        }
        public void loadPaymentDetails(string adid)
        {
            DataTable paymentDisplay = dbquery.paymentHistory(adid);
            this.dataFeeValue.DataSource = paymentDisplay;

            dataFeeValue.Columns["amount_paid"].HeaderText = "Amount Paid";
            dataFeeValue.Columns["current_balance"].HeaderText = "Current Balance";
            dataFeeValue.Columns["date_paid"].HeaderText = "Date Paid";
        }

        public void loadFeeDetails()
        {
            DataTable feeDisplay = dbquery.feevalues();
            this.dataFeeValue.DataSource = feeDisplay;

            dataFeeValue.Columns["fee_type"].HeaderText = "Fee Type";
            dataFeeValue.Columns["fee_description"].HeaderText = "Fee Description";
            dataFeeValue.Columns["current_amount"].HeaderText = "Current Amount";
            //dataFeeValue.Columns["school_year_start"].HeaderText = "School Year Start";
            // dataFeeValue.Columns["school_year_end"].HeaderText = "School Year End";

            dataFeeValue.Columns["Status"].Visible = false;
            dataFeeValue.Columns["fid"].Visible = false;
            dataFeeValue.Columns["date_modified"].Visible = false;
            dataFeeValue.Columns["date_created"].Visible = false;
            dataFeeValue.Columns["f_key"].Visible = false;

            this.dataFeeValue.Columns["fee_type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataFeeValue.ReadOnly = true;
            this.dataFeeValue.Refresh();
        }
        public IDictionary<string, string> dic2;
        private void dataSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                dic2 = new Dictionary<string, string>();
                dic2.Add("adid", dataSearch.Rows[e.RowIndex].Cells["adid"].Value.ToString());
                dic2.Add("pamnt", dataSearch.Rows[e.RowIndex].Cells["paid_amount"].Value.ToString());
                dic2.Add("pstat", dataSearch.Rows[e.RowIndex].Cells["payment_status"].Value.ToString());
                dic2.Add("spid", dataSearch.Rows[e.RowIndex].Cells["spid"].Value.ToString());
                dic2.Add("fid", dataSearch.Rows[e.RowIndex].Cells["fid"].Value.ToString());
                dic2.Add("did", dataSearch.Rows[e.RowIndex].Cells["did"].Value.ToString());

                loadBalanceDetails(txtStudentID.Text);
                dataFeeValue.Refresh();
                btnAddTransaction.Enabled = true;
                btnEditAccount.Enabled = true;
            }
            else
            { return; }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }
        public Accounting.newfrmAddTransaction transac;
        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            DataTable holder = dbquery.User(uname);
            DataTable holder2 = dbquery.UserID(uid);
            uid = holder2.Rows[0]["empID"].ToString();
            uname = holder.Rows[0]["last_name"].ToString() + ", " + holder.Rows[0]["first_name"].ToString();
            transac = new Accounting.newfrmAddTransaction();
            transac.uname = uname;
            transac.uid = uid;
            transac.id = txtStudentID.Text.ToString();
            transac.balanceDisplay = (dataBalanceDetails.DataSource as DataTable);
            transac.GradeLevelDisplay = (dataBalanceDetails.DataSource as DataTable);
            transac.name = fullname.ToString();
            transac.Show();
            transac.reference = this;
            this.Hide();
        }

        private void dataBalanceDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public Accounting.frmAddFee addfee;
        private void btnAddFee_Click(object sender, EventArgs e)
        {
            DataTable holder = dbquery.User(uname);
            uname = holder.Rows[0]["last_name"].ToString() + ", " + holder.Rows[0]["first_name"].ToString();
            addfee = new Accounting.frmAddFee(true);
            addfee.uname = uname;
            addfee.Show();
            addfee.reference = this;
            this.Hide();
        }

        public Accounting.newfrmEditAccount editaccount;
        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            /*
            DataTable holder = dbquery.User(uname);
            uname = holder.Rows[0]["last_name"].ToString() + ", " + holder.Rows[0]["first_name"].ToString();
            editaccount = new Accounting.newfrmEditAccount();
            editaccount.uname = uname;
            editaccount.id = txtStudentID.Text.ToString();
            editaccount.name = fullname.ToString();*/
            editaccount = new Accounting.newfrmEditAccount(dic2);
            editaccount.Show();
            editaccount.reference = this;
            this.Hide();
        }
        public IDictionary<string, string> dic;
        private void dataFeeValue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dic = new Dictionary<string, string>();
                dic.Add("fid", dataFeeValue.Rows[e.RowIndex].Cells["fid"].Value.ToString());
                dic.Add("dc", dataFeeValue.Rows[e.RowIndex].Cells["date_created"].Value.ToString());
                dic.Add("ftype", dataFeeValue.Rows[e.RowIndex].Cells["fee_type"].Value.ToString());
                dic.Add("amount", dataFeeValue.Rows[e.RowIndex].Cells["current_amount"].Value.ToString());
                dic.Add("fdesc", dataFeeValue.Rows[e.RowIndex].Cells["fee_description"].Value.ToString());
                dic.Add("mdesc", dataFeeValue.Rows[e.RowIndex].Cells["misc_desc"].Value.ToString());
                dic.Add("sy", dataFeeValue.Rows[e.RowIndex].Cells["syear"].Value.ToString());
                btnUpdateFee.Enabled = true;
               
            }
            else
            { return; }
        }

        public Accounting.frmViewPaymentHistory viewpaymenthistory;
        private void btnViewPaymentHistory_Click(object sender, EventArgs e)
        {
            DataTable holder = dbquery.User(uname);
            uname = holder.Rows[0]["last_name"].ToString() + ", " + holder.Rows[0]["first_name"].ToString();
            viewpaymenthistory = new Accounting.frmViewPaymentHistory();
            viewpaymenthistory.uname = uname;
            viewpaymenthistory.Show();
            viewpaymenthistory.reference = this;
            this.Hide();
        }

        private void btnUpdateFee_Click(object sender, EventArgs e)
        {
            addfee = new Accounting.frmAddFee(false, dic);
            addfee.uname = uname;
            addfee.dtadd = dt;
            addfee.Show();
            addfee.reference = this;
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string lastname = txtSearch.Text;
            DataTable holder = dbquery.SearchStudent(lastname);
            dataSearch.DataSource = holder;
        }

        private void tabStudentTransaction_Click(object sender, EventArgs e)
        {

        }

        private void dataFeeValue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
