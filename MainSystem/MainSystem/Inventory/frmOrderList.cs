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
    public partial class frmOrderList : Form
    {
        public FormInventory reference { get; set; }

        public frmOrderList()
        {
            InitializeComponent();
        }

        private void lblDate2_Click(object sender, EventArgs e)
        {

        }

        private void lbldateReq_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Hide();
        }
    }
}
