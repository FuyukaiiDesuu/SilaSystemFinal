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
        public frmAddTransaction addtransac;
        public string uname;
        string fullname;

        string fee_type;
        string current_amount;
        string school_year_start;
        string school_year_end;
        string fid;
        string fee_description;
        
        public newfrmAccount(string uname)
        {
            InitializeComponent();
            loadStudentProfileTable();
            lblUser.Text = uname;
        }

        private void newfrmAccount_Load(object sender, EventArgs e)
        {
            loadFeeDetails();
            dataSearch.Rows[0].Selected = false;
            dataFeeValue.Rows[0].Selected = false;
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

            dataSearch.Columns["fullname"].DisplayIndex = 4;

            dataSearch.ReadOnly = true;
            this.dataSearch.Columns["fullname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataSearch.Refresh();
        }

        public void loadBalanceDetails(string student_id)
        {
            DataTable balanceDisplay = dbquery.balanceDetails(student_id);
            this.dataBalanceDetails.DataSource = balanceDisplay;

            dataBalanceDetails.Columns["Name"].HeaderText = "Name";
            dataBalanceDetails.Columns["fee_type"].HeaderText = "Grade Level";
            dataBalanceDetails.Columns["current_balance"].HeaderText = "Current Balance";
            dataBalanceDetails.Columns["paid_amount"].HeaderText = "Amount Paid";
            dataBalanceDetails.Columns["payment_status"].HeaderText = "Payment Status";
            dataBalanceDetails.Columns["adid"].Visible = false;
            dataBalanceDetails.Columns["fid"].Visible = false;

            dataBalanceDetails.ReadOnly = true;
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
            dataFeeValue.Columns["school_year_start"].HeaderText = "School Year Start";
            dataFeeValue.Columns["school_year_end"].HeaderText = "School Year End";

            dataFeeValue.Columns["fid"].Visible = false;
            dataFeeValue.Columns["date_modified"].Visible = false;
            dataFeeValue.Columns["date_created"].Visible = false;
            dataFeeValue.Columns["f_key"].Visible = false;

            dataFeeValue.ReadOnly = true;
            this.dataFeeValue.Refresh();
        }

        private void dataSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtStudentID.Text = dataSearch.SelectedRows[0].Cells["idstudentprofile"].Value.ToString();
                txtFirstName.Text = dataSearch.SelectedRows[0].Cells["FirstName"].Value.ToString();
                txtLastName.Text = dataSearch.SelectedRows[0].Cells["LastName"].Value.ToString();
                txtMiddleName.Text = dataSearch.SelectedRows[0].Cells["MiddleName"].Value.ToString();
                txtDateOfBirth.Text = dataSearch.SelectedRows[0].Cells["DateOfBirth"].Value.ToString();
                txtPlaceOfBirth.Text = dataSearch.SelectedRows[0].Cells["PlaceOfBirth"].Value.ToString();
                txtSex.Text = dataSearch.SelectedRows[0].Cells["Sex"].Value.ToString();
                txtReligion.Text = dataSearch.SelectedRows[0].Cells["Religion"].Value.ToString();
                txtNickName.Text = dataSearch.SelectedRows[0].Cells["NickName"].Value.ToString();
                fullname = dataSearch.SelectedRows[0].Cells["fullname"].Value.ToString();

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
            uname = holder.Rows[0]["last_name"].ToString() + ", " + holder.Rows[0]["first_name"].ToString();
            transac = new Accounting.newfrmAddTransaction();
            transac.uname = uname;
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
            DataTable holder = dbquery.User(uname);
            uname = holder.Rows[0]["last_name"].ToString() + ", " + holder.Rows[0]["first_name"].ToString();
            editaccount = new Accounting.newfrmEditAccount();
            editaccount.uname = uname;
            editaccount.id = txtStudentID.Text.ToString();
            editaccount.name = fullname.ToString();
            editaccount.Show();
            editaccount.reference = this;
            this.Hide();
        }

        private void dataFeeValue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnUpdateFee.Enabled = true;

                fid = dataFeeValue.Rows[e.RowIndex].Cells["fid"].Value.ToString();
                fee_type = dataFeeValue.Rows[e.RowIndex].Cells["fee_type"].Value.ToString();
                current_amount = dataFeeValue.Rows[e.RowIndex].Cells["current_amount"].Value.ToString();
                fee_description = dataFeeValue.Rows[e.RowIndex].Cells["fee_description"].Value.ToString();
                school_year_start = dataFeeValue.Rows[e.RowIndex].Cells["school_year_start"].Value.ToString();
                school_year_end = dataFeeValue.Rows[e.RowIndex].Cells["school_year_end"].Value.ToString();
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
            DataTable dt = new DataTable();
            DataTable holder = dbquery.User(uname);
            uname = holder.Rows[0]["last_name"].ToString() + ", " + holder.Rows[0]["first_name"].ToString();
            dt.Columns.Add("fid");
            dt.Columns.Add("fee_type");
            dt.Columns.Add("current_amount");
            dt.Columns.Add("school_year_start");
            dt.Columns.Add("school_year_end");
            dt.Columns.Add("fee_description");
            dt.Rows.Add(fid, fee_type, current_amount, school_year_start, school_year_end, fee_description);

            addfee = new Accounting.frmAddFee(false);
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
    }
}
