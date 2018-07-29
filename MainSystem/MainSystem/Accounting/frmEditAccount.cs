﻿using System;
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
    public partial class frmEditAccount : Form
    {
        public Accounting.newfrmAccount reference {get; set;}
        public frmEditAccount()
        {
            InitializeComponent();
        }

        private void frmEditAccount_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            lblDate2.Text = DateTime.Now.ToString("tt");
            timer1.Start();
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
