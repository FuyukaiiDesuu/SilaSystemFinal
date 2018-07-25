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
    public partial class frmNewEntry : Form
    {
        public Stockin_out reference { get; set; }
        public frmNewEntry(IDictionary<string, string> dic)
        {
            InitializeComponent();
            txtitemname.Text = dic["name"];
            txtdesc.Text = dic["desc"];
    
        }

        private void frmNewEntry_Load(object sender, EventArgs e)
        {
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Hide();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {

        }
    }
}

