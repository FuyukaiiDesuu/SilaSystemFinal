using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MainSystem
{
    public partial class createItem : Form
    {
        public MySqlConnection dbconnection;
        dbConnector connect = new dbConnector();
        public frmitemmanagement reference { get; set; }
        public createItem()
        {
            InitializeComponent();
        }
        private void gbItemDetails2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
