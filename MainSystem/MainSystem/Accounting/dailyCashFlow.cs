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
    public partial class dailyCashFlow : Form
    {
        public Accounting.newfrmAccount reference { get; set; }
        public dailyCashFlow()
        {
            InitializeComponent();
        }
     
        private void dailyCashFlow_Load(object sender, EventArgs e)
        {

        }
    }
}
