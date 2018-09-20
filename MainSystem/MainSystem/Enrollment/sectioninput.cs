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
    public partial class sectioninput : Form
    {
        public frmSectionMgmt reference { get; set; }
        public string sectioninputt { get; set; }
        public MySqlConnection dbconnection;
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;
        public sectioninput()
        {
            InitializeComponent();
        }

        private void sectioninput_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Confirm Adding Into Section?", "WARNING!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                var x = "";
                int index = comboBox2.Text.IndexOf('-');
                if (index >= 0)
                {
                   x = comboBox2.Text.Substring(0, index);
                }
                sectioninputt = x;
                MessageBox.Show("Student/s Assigned to Section Sucessfully!");
                this.Dispose();
            }
            else
            {
                button2.PerformClick();
            }
            
           
        }
        public List<string> sec = new List<string>();
        public string hehe;
        private void comboloader()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM sectionnames WHERE department = '"+(comboBox1.SelectedIndex + 1)+"';";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        comboBox2.Items.Add(row["section_name"].ToString() + "-" + row["gradelevel"].ToString());
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Wish To Cancel?", "WARNING!", MessageBoxButtons.OK);
            if(dr == DialogResult.OK)
            {
                this.Dispose();
            }
            else
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboloader();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
