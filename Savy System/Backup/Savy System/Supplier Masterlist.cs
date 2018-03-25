using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Supplier_Masterlist : Form
    {
        public void AssignSuppReport(SupplierID rpt)
        {
            crystalReportViewer1.ReportSource = rpt;
        }

        public void AssignSuppname(SupplierName rpt)
        {
            crystalReportViewer1.ReportSource = rpt;

        }


        public Supplier_Masterlist()
        {
            InitializeComponent();
        }

       

      

       
    }
}