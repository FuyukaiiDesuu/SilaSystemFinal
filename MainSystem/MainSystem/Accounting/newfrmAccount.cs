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
        //string fullname;
        public string eid;
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
        
        public newfrmAccount(string unam, string empid)
        {
            InitializeComponent();
            loadStudentProfileTable();
            eid = empid;
            lblUser.Text = unam;
            uname = unam;
        }

        private void newfrmAccount_Load(object sender, EventArgs e)
        {
            loadFeeDetails();
            loadDisbursementtbl();
            dataSearch.ClearSelection();
            dataFeeValue.ClearSelection();
            button1.Enabled = false;
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
        public string syeartempo = "2018 - 2019";
        public void loadDisbursementtbl()
        {
            using (MySqlConnection conn = connect.connector())
            {

                string query = "SELECT * FROM disbursement;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        public void loadBalanceDetails()
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
            string adid = dic2["adid"];
            using (MySqlConnection conn = connect.connector())
            {
              
                string query = "SELECT transaction_no, date_paid, amount_paid, cheque_no, payment_to, additional_details, syear FROM silasystemdb.payment WHERE adid = '" +adid+"' AND syear = '"+syeartempo+"' AND paymentStatus = 1;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataBalanceDetails.DataSource = dt;
            }
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT pid, transaction_no, payment_to, date_paid, amount_paid, cheque_no, additional_details, syear, paymentStatus FROM silasystemdb.payment WHERE adid = '" + adid + "' AND syear = '" + syeartempo + "' AND paymentStatus = 2;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dgvpending.DataSource = dt;
            }
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT pid, transaction_no, payment_to, date_paid, amount_paid, cheque_no, additional_details, syear, paymentStatus FROM silasystemdb.payment WHERE adid = '" + adid + "' AND syear = '" + syeartempo + "' AND paymentStatus = 3;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dgvvoid.DataSource = dt;
            }
            dgvvoid.ClearSelection();
            this.dgvvoid.Refresh();
            dgvpending.ClearSelection();
            this.dgvpending.Refresh();
            dataBalanceDetails.ClearSelection();
            this.dataBalanceDetails.Refresh();

            dgvpending.Columns["paymentStatus"].Visible = false;
            dgvvoid.Columns["paymentStatus"].Visible = false;
            dgvpending.Columns["pid"].Visible = false;
            dgvvoid.Columns["pid"].Visible = false;
        }
        public void loadPaymentDetails()
        {
           
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
                dic2.Add("fullname", dataSearch.Rows[e.RowIndex].Cells["LastName"].Value.ToString() + ", " + dataSearch.Rows[e.RowIndex].Cells["LastName"].Value.ToString() + " " + dataSearch.Rows[e.RowIndex].Cells["MiddleName"].Value.ToString());

                loadBalanceDetails();
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
            this.Dispose();
        }
        public Accounting.newfrmAddTransaction transac;
        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            /*
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
            transac.name = fullname.ToString();*/
            transac = new newfrmAddTransaction(dic2, eid, uname);
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

        private void dataBalanceDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public IDictionary<string, string> dicForPend;
        private void dgvpending_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            button1.Enabled = true;
            dicForPend = new Dictionary<string, string>();
            dicForPend.Add("cno", dgvpending.Rows[e.RowIndex].Cells["cheque_no"].Value.ToString());
            dicForPend.Add("tno", dgvpending.Rows[e.RowIndex].Cells["transaction_no"].Value.ToString());
            dicForPend.Add("apaid", dgvpending.Rows[e.RowIndex].Cells["amount_paid"].Value.ToString());
            dicForPend.Add("status", dgvpending.Rows[e.RowIndex].Cells["paymentStatus"].Value.ToString());
            dicForPend.Add("pid", dgvpending.Rows[e.RowIndex].Cells["pid"].Value.ToString());

            button1.Enabled = true;
            chqno.Text = dgvpending.Rows[e.RowIndex].Cells["cheque_no"].Value.ToString();
            tno.Text = dgvpending.Rows[e.RowIndex].Cells["transaction_no"].Value.ToString();
            amnt.Text = "₱ " + dgvpending.Rows[e.RowIndex].Cells["amount_paid"].Value.ToString();
        }
        public validateCheque vcform;
        private void button1_Click(object sender, EventArgs e)
        {
            vcform = new validateCheque(dicForPend);
            vcform.Show();
            vcform.reference = this;
            this.Hide();
        }

        private void dgvvoid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            button1.Enabled = false;
            dicForPend = new Dictionary<string, string>();
            dicForPend.Add("cno", dgvvoid.Rows[e.RowIndex].Cells["cheque_no"].Value.ToString());
            dicForPend.Add("tno", dgvvoid.Rows[e.RowIndex].Cells["transaction_no"].Value.ToString());
            dicForPend.Add("apaid", dgvvoid.Rows[e.RowIndex].Cells["cheque_no"].Value.ToString());
            dicForPend.Add("status", dgvvoid.Rows[e.RowIndex].Cells["paymentStatus"].Value.ToString());

            button1.Enabled = true;
            chqno.Text = dgvvoid.Rows[e.RowIndex].Cells["cheque_no"].Value.ToString();
            tno.Text = dgvvoid.Rows[e.RowIndex].Cells["transaction_no"].Value.ToString();
            amnt.Text = "₱ " + dgvvoid.Rows[e.RowIndex].Cells["amount_paid"].Value.ToString();

        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
         
            chqno.Clear();
            tno.Clear();
            amnt.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPage3")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
            dgvvoid.ClearSelection();
            dgvpending.ClearSelection();
        }
        public dailyCashFlow dcfform;
        private void button2_Click(object sender, EventArgs e)
        {
            dcfform = new dailyCashFlow();
            dcfform.reference = this;
            dcfform.Show();
            this.Hide();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        public frmCreatevoucher fcv;
        private void btnAddDisb_Click(object sender, EventArgs e)
        {
            fcv = new frmCreatevoucher(eid, uname);
            fcv.Show();
            fcv.reference = this;
            this.Hide();

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void dgvpending_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
