﻿using System;
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
    public partial class Stockin_out : Form
    {
        public FormInventory reference { get; set; }
        public Stockin_out()
        {
            InitializeComponent();
        }
        dbConnector connect = new dbConnector();
        MySqlDataAdapter adapter;
        DataTable dt;

        private void btnback2_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Hide();
        }

        private void Stockin_out_Load(object sender, EventArgs e)
        {
            readData();
            readData2();
        }
        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            newent = new frmNewEntry(forreturn);
            newent.Show();
            newent.reference = this;
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void readData()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM itemdetails WHERE itemstatus = 1";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["itemID"].Visible = false;
            }
        }
        public frmNewEntry newent;
        IDictionary<string, string> forreturn;
        private void items(string id, string name, string desc)
        {
            forreturn = new Dictionary<string, string>();
            forreturn.Add("ayd", id);
            forreturn.Add("name", name);
            forreturn.Add("desc", desc);
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            items(dataGridView1.Rows[e.RowIndex].Cells["item_code"].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells["itemname"].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells["description"].Value.ToString());
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void readData2()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM stkin";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
                //dataGridView2.Columns["itemID"].Visible = false;
            }
        }
    }
}
