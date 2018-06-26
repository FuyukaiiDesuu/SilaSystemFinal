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
    public partial class frmAccount : Form
    {
        public frmMain reference { get; set; }
        public frmAccount()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            frmAddTransaction addTransaction = new frmAddTransaction();
            addTransaction.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Hide();
        }
    }
}
