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
    public partial class frmEmployee : Form
    {
        public frmMain reference { get; set; }

        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmaddemp = new frmAddEmployee();
            frmaddemp.Show();
            frmaddemp.reference = this;
            this.Hide();
        }
        public frmAddEmployee frmaddemp;

        private void btnView_Click(object sender, EventArgs e)
        {
            frmviewemp = new frmViewArchivedEmployee();
            frmviewemp.Show();
            frmviewemp.reference = this;
            this.Hide();
        }
        public frmViewArchivedEmployee frmviewemp;
        
    }
}
