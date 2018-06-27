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
    public partial class Stockin_out : Form
    {
        public FormInventory reference { get; set; }
        public Stockin_out()
        {
            InitializeComponent();
        }

        private void btnback2_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Hide();
        }
    }
}
