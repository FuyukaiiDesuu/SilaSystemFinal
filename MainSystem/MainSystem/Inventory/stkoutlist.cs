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

namespace MainSystem.Inventory
{
    public partial class stkoutlist : Form
    {
        public MySqlConnection dbconnection;
        public FormInventory reference { get; set; }
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;
        public string invid;
        public stkoutlist(string a)
        {
            InitializeComponent();
            invid = a;
        }

        private void stkoutlist_Load(object sender, EventArgs e)
        {
            readdata();
            dgvstkout.DefaultCellStyle.ForeColor = Color.Black;
            dgvstkout.DefaultCellStyle.Font = new Font("Tahoma", 14f);
            dgvstkout.ClearSelection();
        }
        private void readdata()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT item_code, itemname, description, stockout_date, stkout.quantity, statusout FROM stkout INNER JOIN inventory ON stkout.inventory_id = inventory.invID INNER JOIN itemdetails " +
                    "ON inventory.item_id = itemdetails.itemID WHERE inventory.invID = '"+invid+"';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dgvstkout.DataSource = dt;
            }
        }

        private void btnbak_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
