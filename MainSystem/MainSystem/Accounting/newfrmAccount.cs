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
        public newfrmAccount()
        {
            InitializeComponent();
            loadStudentProfileTable();
        }

        private void newfrmAccount_Load(object sender, EventArgs e)
        {

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

            dataBalanceDetails.ReadOnly = true;
            dataBalanceDetails.Refresh();
        }
        public void loadPaymentDetails(string adid)
        {
            DataTable paymentDisplay = dbquery.paymentHistory(adid);
            this.dataPaymentHistory.DataSource = paymentDisplay;

            dataPaymentHistory.Columns["amount_paid"].HeaderText = "Amount Paid";
            dataPaymentHistory.Columns["current_balance"].HeaderText = "Current Balance";
            dataPaymentHistory.Columns["date_paid"].HeaderText = "Date Paid";
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
                dataPaymentHistory.DataSource = null;
                dataPaymentHistory.Refresh();
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
            transac = new Accounting.newfrmAddTransaction();
            transac.id = txtStudentID.Text.ToString();
            transac.name = fullname.ToString();
            transac.Show();
            transac.reference = this;
            this.Hide();
        }

        private void dataBalanceDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                loadPaymentDetails(dataBalanceDetails.SelectedRows[0].Cells["adid"].Value.ToString());
            }
            else
            { return; }
        }

        public Accounting.frmAddFee addfee;
        private void btnAddFee_Click(object sender, EventArgs e)
        {
            addfee = new Accounting.frmAddFee();
            addfee.Show();
            addfee.reference = this;
            this.Hide();
        }

        public Accounting.newfrmEditAccount editaccount;
        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            editaccount = new Accounting.newfrmEditAccount();
            editaccount.Show();
            editaccount.reference = this;
            this.Hide();
        }
    }
}
