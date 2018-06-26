using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem
{
    public partial class frmMain : Form
    {
        public FormLogin reference { get; set; }
        public frmMain(string uname)
        {
            InitializeComponent();
            lblusername.Text = uname;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnEnrollmentForm_Click(object sender, EventArgs e)
        {
            frmEnroll = new EnrollmentConsole();
            frmEnroll.Show();
            frmEnroll.reference = this;
            this.Hide();

        }
        public EnrollmentConsole frmEnroll;

        private void btnEmployeeForm_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLGOUT_Click(object sender, EventArgs e)
        {
            this.Close();
            reference.Show();
        }
        public FormInventory frminv;
        private void btnInventoryForm_Click(object sender, EventArgs e)
        {
            frminv = new FormInventory();
            frminv.Show();
            frminv.reference = this;
            this.Hide();
            
        }
        public frmAccount frmacc;
        private void btnAccountForm_Click(object sender, EventArgs e)
        {
            frmacc = new frmAccount();
            frmacc.Show();
            frmacc.reference = this;
            this.Hide();
        }
    }
}
