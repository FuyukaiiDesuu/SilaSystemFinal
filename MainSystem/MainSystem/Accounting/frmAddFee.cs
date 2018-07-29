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
        public frmAddFee()
        {
            InitializeComponent();
        }

        private void lblFeeDescription_Click(object sender, EventArgs e)
        {

        }

        private void frmAddFee_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
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
    }
}
