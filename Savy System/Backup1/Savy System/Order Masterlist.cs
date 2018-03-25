using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Order_Masterlist : Form
    {

        public void AssignOrCOF(OrderCOF rpt)
        {
            crystalReportViewer1.ReportSource = rpt;
        }

        public void AssignOrName(OrderName rpt)
        {
            crystalReportViewer1.ReportSource = rpt;

        }

        public void AssignOrDate(OrderDate rpt)
        {
            crystalReportViewer1.ReportSource = rpt;
        }
        
        
        public Order_Masterlist()
        {
            InitializeComponent();
        }

        
    }
}