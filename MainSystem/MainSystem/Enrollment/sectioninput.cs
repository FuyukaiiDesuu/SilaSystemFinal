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
    public partial class sectioninput : Form
    {
        public frmSectionMgmt reference { get; set; }
        public string sectioninputt { get; set; }
        public sectioninput()
        {
            InitializeComponent();
        }

        private void sectioninput_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            sectioninputt = textBox1.Text;
            MessageBox.Show("Student/s Assigned to Section Sucessfully!");
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
