using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Inventory_Masterlist : Form
    {

        public void AssignInvReport(InventoryID rpt)
        {
            crystalReportViewer1.ReportSource = rpt;
        }

        public void AssignInvname(ItemName rpt)
        {
            crystalReportViewer1.ReportSource = rpt;

        }

        public void AssignInvStat(ItemStatus rpt)
        {
            crystalReportViewer1.ReportSource = rpt;
        }
        
        
        public Inventory_Masterlist()
        {
            InitializeComponent();
        }

        

        


        

       
    }
}