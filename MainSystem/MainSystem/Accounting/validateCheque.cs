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
    public partial class validateCheque : Form
    {
        public MySqlConnection dbconnection;
        public MySqlDataAdapter adapter;
        public DataTable dt;
        public Accounting.newfrmAccount reference { get; set; }
        public validateCheque()
        {
            InitializeComponent();
        }

        private void validateCheque_Load(object sender, EventArgs e)
        {

        }
    }
}
