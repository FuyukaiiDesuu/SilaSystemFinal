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
    public partial class newfrmEditAccount : Form
    {
        public Accounting.newfrmAccount reference { get; set; }
        public DataTable editacc = null;
        public newfrmEditAccount()
        {
            InitializeComponent();
        }

        private void newfrmEditAccount_Load(object sender, EventArgs e)
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
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            lblDate2.Text = DateTime.Now.ToString("tt");
            timer1.Start();
        }
    }
}
