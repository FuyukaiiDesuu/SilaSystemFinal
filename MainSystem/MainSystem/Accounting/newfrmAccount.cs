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
        public string syeartempo { get; set; }
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
            
            eid = empid;
            lblUser.Text = unam;
            uname = unam;
        }

        private void newfrmAccount_Load(object sender, EventArgs e)
        {
            lblsy.Text = syeartempo;
            loadStudentProfileTable();
            loadFeeDetails();
            loadDisbursementtbl();
            clearfields();
            dgvcolorsloader();
            button1.Enabled = false;
        }
        public void dgvcolorsloader()
        {
            dataSearch.DefaultCellStyle.ForeColor = Color.Black;
            dataBalanceDetails.DefaultCellStyle.ForeColor = Color.Black;
            dgvpending.DefaultCellStyle.ForeColor = Color.Black;
            dataFeeValue.DefaultCellStyle.ForeColor = Color.Black;
            dgvvoid.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataSearch.DefaultCellStyle.Font = new Font("Tahoma", 12f);
            dataBalanceDetails.DefaultCellStyle.Font = new Font("Tahoma", 12f);
            dgvpending.DefaultCellStyle.Font = new Font("Tahoma", 12f);
            dgvvoid.DefaultCellStyle.Font = new Font("Tahoma", 12f);
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12f);
            dataFeeValue.DefaultCellStyle.Font = new Font("Tahoma", 12f);
        }
        public void loadStudentProfileTable()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM studentprofile INNER JOIN studdetails ON studentprofile.idstuddet = studdetails.idstddet " +
                    "INNER JOIN accountdetails ON accountdetails.spid = studentprofile.idstudentprofile WHERE studentprofile.Status = 1 " +
                    "AND studdetails.school_year = '"+lblsy.Text+"';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataSearch.DataSource = dt;
            }
            dataSearch.Columns["idstudentprofile"].Visible = false;
            //dataSearch.Columns["FirstName"].Visible = false;
            //dataSearch.Columns["LastName"].Visible = false;
            //dataSearch.Columns["MiddleName"].Visible = false;
            //dataSearch.Columns["fullname"].Visible = false;
            dataSearch.Columns["DateOfBirth"].Visible = false;
            dataSearch.Columns["PlaceOfBirth"].Visible = false;
            dataSearch.Columns["Sex"].Visible = false;
            dataSearch.Columns["Religion"].Visible = false;
            dataSearch.Columns["NickName"].Visible = false;
            dataSearch.Columns["Status"].Visible = false;
            dataSearch.Columns["idstuddet"].Visible = false;
            dataSearch.Columns["adid"].Visible = false;
            dataSearch.Columns["paid_amount"].Visible = false;
            dataSearch.Columns["payment_status"].Visible = false;
            dataSearch.Columns["spid"].Visible = false;
            dataSearch.Columns["fid"].Visible = false;
            dataSearch.Columns["department"].Visible = false;
            dataSearch.Columns["sectionid"].Visible = false;
            //dataSearch.Columns["section"].Visible = false;
            dataSearch.Columns["level"].Visible = false;
            dataSearch.Columns["idstddet"].Visible = false;
            dataSearch.Columns["image_path"].Visible = false;
            dataSearch.Columns["level_dummyval"].HeaderText = "Level";
            dataSearch.ReadOnly = true;
            this.dataSearch.Refresh();
        }
       
        public void loadDisbursementtbl()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM disbursement WHERE syear = '"+syeartempo+"' AND Date_recorded = '"+DateTime.Now.ToString("yyyy-MM-dd")+"';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        public string adid;
        public void loadCpending()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT pid, transaction_no, payment_to, date_paid, amount_paid, cheque_no, additional_details, syear, adid, paymentStatus FROM silasystemdb.payment WHERE adid = '" + adid + "' AND syear = '" + syeartempo + "' AND paymentStatus = 2;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dgvpending.DataSource = dt;
            }
            dgvpending.Columns["transaction_no"].HeaderText = "Transaction No.";
            dgvpending.Columns["date_paid"].HeaderText = "Date Paid";
            dgvpending.Columns["amount_paid"].HeaderText = "Amount Paid";
            dgvpending.Columns["cheque_no"].HeaderText = "Cheque No.";
            dgvpending.Columns["payment_to"].HeaderText = "Payment No.";
            dgvpending.Columns["additional_details"].HeaderText = "Additional Details";
            dgvpending.Columns["syear"].HeaderText = "School Year";
            dgvpending.Columns["paymentStatus"].Visible = false;
            dgvpending.Columns["adid"].Visible = false;
            dgvpending.Columns["pid"].Visible = false;
        }
        public void loadCvoid()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT pid, transaction_no, payment_to, date_paid, amount_paid, cheque_no, additional_details, syear, adid, paymentStatus FROM silasystemdb.payment WHERE adid = '" + adid + "' AND syear = '" + syeartempo + "' AND paymentStatus = 3;";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dgvvoid.DataSource = dt;
            }
            dgvvoid.Columns["transaction_no"].HeaderText = "Transaction No.";
            dgvvoid.Columns["date_paid"].HeaderText = "Date Paid";
            dgvvoid.Columns["amount_paid"].HeaderText = "Amount Paid";
            dgvvoid.Columns["cheque_no"].HeaderText = "Cheque No.";
            dgvvoid.Columns["payment_to"].HeaderText = "Payment No.";
            dgvvoid.Columns["additional_details"].HeaderText = "Additional Details";
            dgvvoid.Columns["syear"].HeaderText = "School Year";
            dgvvoid.Columns["paymentStatus"].Visible = false;
            dgvvoid.Columns["adid"].Visible = false;
            dgvvoid.Columns["pid"].Visible = false;
        }
        public void loadPBalance()
        {
            using (MySqlConnection conn = connect.connector())
            {

                string query = "SELECT transaction_no, date_paid, amount_paid, cheque_no, payment_to, additional_details, syear FROM silasystemdb.payment " +
                    "WHERE adid = '" + adid + "' AND syear = '" + syeartempo + "' AND paymentStatus = 1 AND date_paid LIKE '%" + DateTime.Now.ToString("yyyy-MM-dd") + "%';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataBalanceDetails.DataSource = dt;
            }
            dataBalanceDetails.Columns["transaction_no"].HeaderText = "Transaction No.";
            dataBalanceDetails.Columns["date_paid"].HeaderText = "Date Paid";
            dataBalanceDetails.Columns["amount_paid"].HeaderText = "Amount Paid";
            dataBalanceDetails.Columns["cheque_no"].HeaderText = "Cheque No.";
            dataBalanceDetails.Columns["payment_to"].HeaderText = "Payment To:";
            dataBalanceDetails.Columns["additional_details"].HeaderText = "Additional Details";
            dataBalanceDetails.Columns["syear"].HeaderText = "School Year";
            dataBalanceDetails.Columns["amount_paid"].DefaultCellStyle.Format = "N2";
        }
        public void loadBalanceDetails()
        {
            adid = dic2["adid"];
            loadCpending();
            loadCvoid();
            loadPBalance();
        }
        public void loadPaymentDetails()
        {
           
        }

        public void loadFeeDetails()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM feevalues WHERE syear = '"+syeartempo+"';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataFeeValue.DataSource = dt;
            }
            dataFeeValue.Columns["current_amount"].DefaultCellStyle.Format = "N2";
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
            //dataFeeValue.ReadOnly = true;
            this.dataFeeValue.Refresh();
        }
        public IDictionary<string, string> studdetails(string dept, string level)
        {
            IDictionary<string, string> studdet = new Dictionary<string, string>();
            switch (dept)
            {
                case "1":
                    studdet.Add("dept", "Pre-school");
                    break;
                case "2":
                    studdet.Add("dept", "Grade-school");
                    break;
                case "3":
                    studdet.Add("dept", "Junior-Highschool");
                    break;
                case "4":
                    studdet.Add("dept", "Senior-Highschool");
                    break;
            }
            switch (level)
            {
                case "11":
                    studdet.Add("level", "Toddler");
                    break;
                case "12":
                    studdet.Add("level", "Nursery");
                    break;
                case "13":
                    studdet.Add("level", "Kinder");
                    break;
                case "14":
                    studdet.Add("level", "Preparatory");
                    break;
                case "21":
                    studdet.Add("level", "Grade 1");
                    break;
                case "22":
                    studdet.Add("level", "Grade 2");
                    break;
                case "23":
                    studdet.Add("level", "Grade 3");
                    break;
                case "24":
                    studdet.Add("level", "Grade 4");
                    break;
                case "25":
                    studdet.Add("level", "Grade 5");
                    break;
                case "26":
                    studdet.Add("level", "Grade 6");
                    break;
                case "31":
                    studdet.Add("level", "Grade 7");
                    break;
                case "32":
                    studdet.Add("level", "Grade 8");
                    break;
                case "33":
                    studdet.Add("level", "Grade 9");
                    break;
                case "34":
                    studdet.Add("level", "Grade 10");
                    break;
                case "41":
                    studdet.Add("level", "Grade 11");
                    break;
                case "42":
                    studdet.Add("level", "Grade 12");
                    break;
            }
           
            return studdet;
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
                dic2.Add("fullname", dataSearch.Rows[e.RowIndex].Cells["LastName"].Value.ToString() + ", " + dataSearch.Rows[e.RowIndex].Cells["FirstName"].Value.ToString() + " " + dataSearch.Rows[e.RowIndex].Cells["MiddleName"].Value.ToString());
                txtfn.Text = dataSearch.Rows[e.RowIndex].Cells["LastName"].Value.ToString() + ", " + dataSearch.Rows[e.RowIndex].Cells["FirstName"].Value.ToString() + " " + dataSearch.Rows[e.RowIndex].Cells["MiddleName"].Value.ToString();
                var studdetailss = studdetails(dataSearch.Rows[e.RowIndex].Cells["department"].Value.ToString(), dataSearch.Rows[e.RowIndex].Cells["level"].Value.ToString());
                txtdp.Text = studdetailss["dept"];
                //txtlvl.Text = studdetailss["level"];
                dic2.Add("level", studdetailss["level"]);
                dic2.Add("dept", studdetailss["dept"]);
                //dic2.Add("did", dataSearch.Rows[e.RowIndex].Cells["did"].Value.ToString());
                //txtsct.Text = dataSearch.Rows[e.RowIndex].Cells["section"].Value.ToString();
                dic2.Add("sect", dataSearch.Rows[e.RowIndex].Cells["section"].Value.ToString());
                loadBalanceDetails();
                dataFeeValue.Refresh();
                if(!checkBox1.Checked)
                {
                    btnAddTransaction.Enabled = true;
                    btnEditAccount.Enabled = true;
                    //btnViewPaymentHistory.Enabled = true;
                }
               
            }
            else
            { return; }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("DO YOU WANT TO GO BACK TO THE DASHBOARD?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                reference.Show();
                this.Dispose();
            }
        }
        public Accounting.newfrmAddTransaction transac;
        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            transac = new newfrmAddTransaction(dic2, eid, uname);
            transac.syeartemp = lblsy.Text;
            transac.Show();
            transac.reference = this;
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
            addfee.syear = lblsy.Text;
            addfee.uname = uname;
            addfee.Show();
            addfee.reference = this;
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
            editaccount.TEMPORARYSYEAR = lblsy.Text;
            editaccount.Show();
            editaccount.reference = this;
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
            viewpaymenthistory = new Accounting.frmViewPaymentHistory(dic2);
            viewpaymenthistory.uname = uname;
            viewpaymenthistory.syeartempo = lblsy.Text;
            viewpaymenthistory.Show();
            //this.Hide();
            viewpaymenthistory.reference = this;
        }

        private void btnUpdateFee_Click(object sender, EventArgs e)
        {
            addfee = new Accounting.frmAddFee(false, dic);
            addfee.uname = uname;
            addfee.syear = lblsy.Text;
            addfee.dtadd = dt;
            addfee.Show();
            addfee.reference = this;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string lastname = txtSearch.Text;
            DataTable holder = dbquery.SearchStudent(lastname);
            dataSearch.DataSource = holder;
        }

        private void tabStudentTransaction_Click(object sender, EventArgs e)
        {
            clearfields();
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
            dicForPend.Add("adid", dgvpending.Rows[e.RowIndex].Cells["adid"].Value.ToString());
            dicForPend.Add("cno", dgvpending.Rows[e.RowIndex].Cells["cheque_no"].Value.ToString());
            dicForPend.Add("tno", dgvpending.Rows[e.RowIndex].Cells["transaction_no"].Value.ToString());
            dicForPend.Add("apaid", dgvpending.Rows[e.RowIndex].Cells["amount_paid"].Value.ToString());
            dicForPend.Add("status", dgvpending.Rows[e.RowIndex].Cells["paymentStatus"].Value.ToString());
            dicForPend.Add("pid", dgvpending.Rows[e.RowIndex].Cells["pid"].Value.ToString());

            button1.Enabled = true;
            //chqno.Text = dgvpending.Rows[e.RowIndex].Cells["cheque_no"].Value.ToString();
            //tno.Text = dgvpending.Rows[e.RowIndex].Cells["transaction_no"].Value.ToString();
            //amnt.Text = "₱ " + dgvpending.Rows[e.RowIndex].Cells["amount_paid"].Value.ToString();
        }
        public validateCheque vcform;
        private void button1_Click(object sender, EventArgs e)
        {
            vcform = new validateCheque(dicForPend);
            vcform.Show();
            vcform.reference = this;
        }
        private void clearfields()
        {
           dgvvoid.ClearSelection();
           dgvpending.ClearSelection();
           dataBalanceDetails.ClearSelection();
           dataSearch.ClearSelection();
           dataFeeValue.ClearSelection();
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
            //chqno.Text = dgvvoid.Rows[e.RowIndex].Cells["cheque_no"].Value.ToString();
            //tno.Text = dgvvoid.Rows[e.RowIndex].Cells["transaction_no"].Value.ToString();
            //amnt.Text = "₱ " + dgvvoid.Rows[e.RowIndex].Cells["amount_paid"].Value.ToString();

        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
         
            //chqno.Clear();
            //tno.Clear();
            //amnt.Clear();
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
            fcv.syear = lblsy.Text;
            fcv.Show();
            fcv.reference = this;
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void dgvpending_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            loadStudentProfileTable();
        }

        private void dataSearch_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpBalanceDetails_Enter(object sender, EventArgs e)
        {

        }

        private void search_VALIDATECHEQUE(int i)
        {
            if(i == 1)
            {
                using (MySqlConnection conn = connect.connector())
                {
                    string query = "SELECT pid, transaction_no, payment_to, date_paid, amount_paid, cheque_no, additional_details, syear, paymentStatus, adid" +
                        " FROM silasystemdb.payment WHERE adid = '" + adid + "' AND syear = '" + syeartempo + "' AND paymentStatus = 2" +
                        " AND date_paid LIKE '%"+searchtppending.Value.ToString("yyyy-MM-dd")+"%';";
                    dt = new DataTable();
                    adapter = new MySqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                    dgvpending.DataSource = dt;
                    dgvpending.Columns["transaction_no"].HeaderText = "Transaction No.";
                    dgvpending.Columns["date_paid"].HeaderText = "Date Paid";
                    dgvpending.Columns["amount_paid"].HeaderText = "Amount Paid";
                    dgvpending.Columns["cheque_no"].HeaderText = "Cheque No.";
                    dgvpending.Columns["payment_to"].HeaderText = "Payment No.";
                    dgvpending.Columns["additional_details"].HeaderText = "Additional Details";
                    dgvpending.Columns["syear"].HeaderText = "School Year";
                    dgvpending.Columns["paymentStatus"].Visible = false;
                    dgvpending.Columns["pid"].Visible = false;
                    dgvpending.Columns["adid"].Visible = false;
                }
            }
            else
            {
                using (MySqlConnection conn = connect.connector())
                {
                    string query = "SELECT pid, transaction_no, payment_to, date_paid, amount_paid, cheque_no, additional_details, syear, paymentStatus, adid" +
                        " FROM silasystemdb.payment WHERE adid = '" + adid + "' AND syear = '" + syeartempo + "' AND paymentStatus = 2" +
                        " AND date_paid LIKE '%" + searchtppending.Value.ToString("yyyy-MM-dd") + "%';";
                    dt = new DataTable();
                    adapter = new MySqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                    dgvvoid.DataSource = dt;
                    dgvvoid.Columns["transaction_no"].HeaderText = "Transaction No.";
                    dgvvoid.Columns["date_paid"].HeaderText = "Date Paid";
                    dgvvoid.Columns["amount_paid"].HeaderText = "Amount Paid";
                    dgvvoid.Columns["cheque_no"].HeaderText = "Cheque No.";
                    dgvvoid.Columns["payment_to"].HeaderText = "Payment No.";
                    dgvvoid.Columns["additional_details"].HeaderText = "Additional Details";
                    dgvvoid.Columns["syear"].HeaderText = "School Year";
                    dgvvoid.Columns["paymentStatus"].Visible = false;
                    dgvvoid.Columns["pid"].Visible = false;
                    dgvvoid.Columns["adid"].Visible = false;
                }
            }
        }
        //DGV PENDING SHIZZZ
        private void button11_Click(object sender, EventArgs e)
        {
            search_VALIDATECHEQUE(1);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            loadCpending();
        }
        //DGV PENDING SHIZZZ

        private void btnSRCDGVOID_Click(object sender, EventArgs e)
        {
            search_VALIDATECHEQUE(2);
        }
        private void btnRLDDGVOID_Click(object sender, EventArgs e)
        {
            loadCvoid();
        }

        private void searchpaymenttxtbox_TextChanged(object sender, EventArgs e)
        {
            paymentSearch();
        }

        private void paymentSearch()
        {
            using (MySqlConnection conn = connect.connector())
            {

                string query = "SELECT transaction_no, date_paid, amount_paid, cheque_no, payment_to, additional_details, syear FROM silasystemdb.payment " +
                    "WHERE adid = '" + adid + "' AND syear = '" + syeartempo + "' AND paymentStatus = 1 AND date_paid LIKE '%" + DateTime.Now.ToString("yyyy-MM-dd") + "%'" +
                    " AND payment_to LIKE '%" + searchpaymenttxtbox.Text + "%';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataBalanceDetails.DataSource = dt;
            }
            dataBalanceDetails.Columns["transaction_no"].HeaderText = "Transaction No.";
            dataBalanceDetails.Columns["date_paid"].HeaderText = "Date Paid";
            dataBalanceDetails.Columns["amount_paid"].HeaderText = "Amount Paid";
            dataBalanceDetails.Columns["cheque_no"].HeaderText = "Cheque No.";
            dataBalanceDetails.Columns["payment_to"].HeaderText = "Payment To:";
            dataBalanceDetails.Columns["additional_details"].HeaderText = "Additional Details";
            dataBalanceDetails.Columns["syear"].HeaderText = "School Year";
        }
        private void btnpaymentsrc_Click(object sender, EventArgs e)
        {

        }

        private void btnpaymentrel_Click(object sender, EventArgs e)
        {
            loadPBalance();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loadStudentListDeactivated()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM studentprofile INNER JOIN studdetails ON studentprofile.idstuddet = studdetails.idstddet " +
                    "INNER JOIN accountdetails ON accountdetails.spid = studentprofile.idstudentprofile WHERE studentprofile.Status = 0 " +
                    "AND studdetails.school_year = '" + lblsy.Text + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataSearch.DataSource = dt;
            }
            dataSearch.Columns["idstudentprofile"].Visible = false;
            //dataSearch.Columns["FirstName"].Visible = false;
            //dataSearch.Columns["LastName"].Visible = false;
            //dataSearch.Columns["MiddleName"].Visible = false;
            //dataSearch.Columns["fullname"].Visible = false;
            dataSearch.Columns["DateOfBirth"].Visible = false;
            dataSearch.Columns["PlaceOfBirth"].Visible = false;
            dataSearch.Columns["Sex"].Visible = false;
            dataSearch.Columns["Religion"].Visible = false;
            dataSearch.Columns["NickName"].Visible = false;
            dataSearch.Columns["Status"].Visible = false;
            dataSearch.Columns["idstuddet"].Visible = false;
            dataSearch.Columns["adid"].Visible = false;
            dataSearch.Columns["paid_amount"].Visible = false;
            dataSearch.Columns["payment_status"].Visible = false;
            dataSearch.Columns["spid"].Visible = false;
            dataSearch.Columns["did"].Visible = false;
            dataSearch.Columns["fid"].Visible = false;
            dataSearch.Columns["department"].Visible = false;
            //dataSearch.Columns["section"].Visible = false;
            dataSearch.Columns["level"].Visible = false;
            dataSearch.Columns["idstddet"].Visible = false;
            dataSearch.Columns["image_path"].Visible = false;
            dataSearch.Columns["level_dummyval"].HeaderText = "Level";
            dataSearch.ReadOnly = true;
            this.dataSearch.Refresh();
        }
        private void searchQueryStudent1(string a)
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM studentprofile INNER JOIN studdetails ON studentprofile.idstuddet = studdetails.idstddet " +
                    "INNER JOIN accountdetails ON accountdetails.spid = studentprofile.idstudentprofile WHERE FirstName LIKE '%"+a+"%' OR LastName LIKE '%"+a+"%' " +
                    "AND studentprofile.Status = 1 " +
                    "AND studdetails.school_year = '" + lblsy.Text + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataSearch.DataSource = dt;
            }
            dataSearch.Columns["idstudentprofile"].Visible = false;
            //dataSearch.Columns["FirstName"].Visible = false;
            //dataSearch.Columns["LastName"].Visible = false;
            //dataSearch.Columns["MiddleName"].Visible = false;
            //dataSearch.Columns["fullname"].Visible = false;
            dataSearch.Columns["DateOfBirth"].Visible = false;
            dataSearch.Columns["PlaceOfBirth"].Visible = false;
            dataSearch.Columns["Sex"].Visible = false;
            dataSearch.Columns["Religion"].Visible = false;
            dataSearch.Columns["NickName"].Visible = false;
            dataSearch.Columns["Status"].Visible = false;
            dataSearch.Columns["idstuddet"].Visible = false;
            dataSearch.Columns["adid"].Visible = false;
            dataSearch.Columns["paid_amount"].Visible = false;
            dataSearch.Columns["payment_status"].Visible = false;
            dataSearch.Columns["spid"].Visible = false;
            dataSearch.Columns["did"].Visible = false;
            dataSearch.Columns["fid"].Visible = false;
            dataSearch.Columns["department"].Visible = false;
            //dataSearch.Columns["section"].Visible = false;
            dataSearch.Columns["level"].Visible = false;
            dataSearch.Columns["idstddet"].Visible = false;
            dataSearch.Columns["image_path"].Visible = false;
            dataSearch.Columns["level_dummyval"].HeaderText = "Level";
            //dataSearch.Columns["level_dummyval"].Visible = false;
            dataSearch.ReadOnly = true;
            this.dataSearch.Refresh();
        }
        private void btnenablerr(Boolean a)
        {
            btnAddTransaction.Enabled = a;
            button1.Enabled = a;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                loadStudentListDeactivated();
                btnenablerr(false);
            }
            else
            {
                loadStudentProfileTable();
                btnenablerr(true);
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            searchQueryStudent1(txtSearch.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void feeSearch()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM feevalues WHERE fee_description LIKE '%" + txtfeesearch.Text + "%' " +
                    "OR misc_desc LIKE '%" + txtfeesearch.Text + "%' " +
                    "OR fee_type LIKE '%"+txtfeesearch.Text+"' AND syear = '" + syeartempo + "';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataFeeValue.DataSource = dt;
            }
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
            //dataFeeValue.ReadOnly = true;
            this.dataFeeValue.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            feeSearch();
        }
        private void disbsearch()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM disbursement WHERE syear = '" + syeartempo + "' AND Date_recorded = '"+searchtpexpense.Value.ToString("yyyy-MM-dd")+"';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void btnsdb_Click(object sender, EventArgs e)
        {
            disbsearch();
        }

        private void btnreldb_Click(object sender, EventArgs e)
        {
            loadDisbursementtbl();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
