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
        public newfrmEditAccount reference { get; set; }
        public string syear { get; set; }
        public IDictionary<string, string> dic;
        //public newfrmEditAccount reference { get; set; }
        public SOAccount(IDictionary<string, string> d)
        {
            InitializeComponent();
            dic = d;
        }
        public string addeverything(string tuition, string regis, string others, string books)
        {
            Decimal t = Decimal.Parse(tuition);
            Decimal r = Decimal.Parse(regis);
            Decimal o = Decimal.Parse(others);
            Decimal b = Decimal.Parse(books);
            string final = Decimal.Round((t + r + o + b), 2).ToString();
            return "₱"+ final;
        }
        private void SOAccount_Load(object sender, EventArgs e)
        {
            SOA soa = new SOA();
            soa.SetParameterValue("fname", dic["fullname"]);
            soa.SetParameterValue("registration", dic["regis"]);
            soa.SetParameterValue("tuition", dic["tuition"]);
            soa.SetParameterValue("others", dic["others"]);
            soa.SetParameterValue("books", dic["books"]);
            soa.SetParameterValue("studlevel", dic["level"]);
            soa.SetParameterValue("section", dic["section"]);
            soa.SetParameterValue("datedue", dic["date"]);
            soa.SetParameterValue("schoolyear", "S.Y " + syear);
            soa.SetParameterValue("totalSum", addeverything(dic["tuition"].TrimStart('₱'), dic["regis"].TrimStart('₱'), dic["others"].TrimStart('₱'), dic["books"].TrimStart('₱')));

            crystalReportViewer1.ReportSource = soa;
            crystalReportViewer1.Refresh();
        }

        private void SOAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            reference.defaulttext();
        }
    }
}
