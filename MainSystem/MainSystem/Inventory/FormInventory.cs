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
    public partial class FormInventory : Form
    {
        public frmMain reference { get; set; }
        public FormInventory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormInventory_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }

        public frmOrderList frmol;
        private void btnOrderList_Click(object sender, EventArgs e)
        {
            frmol = new frmOrderList();
            frmol.Show();
            frmol.reference = this;
            this.Hide();
        }

        public Stockin_out frmsinout;
        private void btnStockInOut_Click(object sender, EventArgs e)
        {
            frmsinout = new Stockin_out();
            frmsinout.Show();
            frmsinout.reference = this;
            this.Hide();
        }

        public frmItemCreate frmic;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmic = new frmItemCreate();
            frmic.Show();
            frmic.reference = this;
            this.Hide();
        }

        private void lblsodate_Click(object sender, EventArgs e)
        {

        }
    }
}
