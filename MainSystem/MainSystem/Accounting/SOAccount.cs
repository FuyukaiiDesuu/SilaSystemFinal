using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem.Accounting
{
    public partial class SOAccount : Form
    {
        public SOAccount()
        {
            InitializeComponent();
        }

        private void SOAccount_Load(object sender, EventArgs e)
        {
            SOA soa = new SOA();
            soa.SetParameterValue("fname", "BENJO");
            soa.SetParameterValue("registration", "BENJO");
            soa.SetParameterValue("tuition", "BENJO");
            soa.SetParameterValue("others", "BENJO");
            soa.SetParameterValue("books", "BENJO");
            soa.SetParameterValue("studlevel", "BENJO");
            soa.SetParameterValue("datedue", "BENJO");
            crystalReportViewer1.ReportSource = soa;
            crystalReportViewer1.Refresh();
        }
    }
}
