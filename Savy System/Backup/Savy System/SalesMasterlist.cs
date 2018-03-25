using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class SalesMasterlist : Form
    {
        public void SaleRep(SalesReport rpt)

        {
            crystalReportViewer1.ReportSource = rpt;
        
        }
        
        public SalesMasterlist()
        {
            InitializeComponent();
        }

        
    }
}