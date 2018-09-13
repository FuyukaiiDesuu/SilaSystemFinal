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
    public partial class TenderedForm : Form
    {
        public string amount { get; set; }
        public string tndr { get; set; }
        public Accounting.newfrmAddTransaction reference { get; set; }
        public TenderedForm()
        {
            InitializeComponent();
           
            
        }
        public string calculate()
        {
            Decimal a = Decimal.Round(Decimal.Parse(amount.TrimStart('₱')),2);
            Decimal t = Decimal.Round(Decimal.Parse(tndr.TrimStart('₱')), 2);
            Decimal total = Decimal.Round((t - a), 2);
            return total.ToString(); 
        }
        private void TenderedForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = tndr;
            textBox3.Text = amount;
            textBox2.Text = "₱" + calculate();
        }

        private void btnAddFee_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
