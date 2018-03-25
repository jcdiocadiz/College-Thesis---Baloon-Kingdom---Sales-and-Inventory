using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Lost_Item : Form
    {
        public void AssignLost(Lost rpt)
        {
            crystalReportViewer1.ReportSource = rpt;
        }

        public void AssignCOF(LostCOFNo rpt)
        {
            crystalReportViewer1.ReportSource = rpt;
        
        }

        public Lost_Item()
        {
            InitializeComponent();
        }


      

    }
}