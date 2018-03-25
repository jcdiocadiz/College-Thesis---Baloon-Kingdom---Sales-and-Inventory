using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Official_Receipt_Masterlist : Form
    {
        public void AssignORReport(OfficialReceipt rpt)
        {
            crystalReportViewer1.ReportSource = rpt;
        }

        public void AssignORRep(OfficialReceipt rpt)
        {
            crystalReportViewer1.ReportSource = rpt;

        }

        public Official_Receipt_Masterlist()
        {
            InitializeComponent();
        }

      
    }
}