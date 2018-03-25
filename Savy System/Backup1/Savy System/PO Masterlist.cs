using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class PO_Masterlist : Form
    {
        public void AssignPOReport(PONum rpt)
        {
            crystalReportViewer1.ReportSource = rpt;
        }

        public void AssignPOName(POSuppName rpt)
        {
            crystalReportViewer1.ReportSource = rpt;

        }

        public void AssignPODate(PODate rpt)
        {
            crystalReportViewer1.ReportSource = rpt;
        }
        
        
        public PO_Masterlist()
        {
            InitializeComponent();
        }

        
       

       
    }
}