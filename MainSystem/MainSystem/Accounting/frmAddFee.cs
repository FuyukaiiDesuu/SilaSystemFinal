using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem.Accounting
{
    public partial class frmAddFee : Form
    {
        public Accounting.newfrmAccount reference { get; set; }

        public DataTable dtadd = null;
        DbQueries dbquery = new DbQueries();
        bool checker;
        public frmAddFee(bool feeCheck)
        {
            InitializeComponent();
            checker = feeCheck;
        }

        private void frmAddFee_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            dateYearStart.MinDate = DateTime.Now;

            if (checker == false)
            {
                cmbGradeLevel.Text = dtadd.Rows[0]["fee_type"].ToString();
                txtAmount.Text = dtadd.Rows[0]["current_amount"].ToString();
                txtFeeDescription.Text = dtadd.Rows[0]["fee_description"].ToString();
                dateYearStart.Value = Convert.ToDateTime(dtadd.Rows[0]["school_year_start"]);
                dateYearEnd.Value = Convert.ToDateTime(dtadd.Rows[0]["school_year_end"]);
                btnAdd.Text = "Update";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            lblDate2.Text = DateTime.Now.ToString("tt");
            timer1.Start();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checker == true)
            {
                dbquery.updateFee(cmbGradeLevel.Text, txtFeeDescription.Text, txtAmount.Text, lblDate.Text, dateYearStart.Value.ToShortDateString(), dateYearEnd.Value.ToShortDateString());
                MessageBox.Show("Successfully Added");
                reference.Show();
                reference.loadFeeDetails();
                this.Close();
            }
            else
            {
                dbquery.updateNewFee(dtadd.Rows[0]["fid"].ToString(), cmbGradeLevel.Text, txtFeeDescription.Text, txtAmount.Text, lblDate.Text, dateYearStart.Value.ToShortDateString(), dateYearEnd.Value.ToShortDateString());
                MessageBox.Show("Successfully Updated");
                reference.Show();
                reference.loadFeeDetails();
                this.Close();
            }
        }

        private void dateYearStart_ValueChanged(object sender, EventArgs e)
        {
            dateYearEnd.Enabled = true;
            dateYearEnd.MinDate = dateYearStart.Value;
        }
    }
}
