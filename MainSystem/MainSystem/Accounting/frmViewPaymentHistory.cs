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
    public partial class frmViewPaymentHistory : Form
    {
        public Accounting.newfrmAccount reference { get; set; }
        public frmViewPaymentHistory()
        {
            InitializeComponent();
        }

        private void frmViewPaymentHistory_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }
    }
}
