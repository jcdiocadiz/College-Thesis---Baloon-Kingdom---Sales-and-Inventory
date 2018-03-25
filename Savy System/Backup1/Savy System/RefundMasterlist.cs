using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class RefundMasterlist : Form
    {
        public void RefundViewAll(RefundView rpt)
        {

            crystalReportViewer1.ReportSource = rpt;
        
        } 
        public RefundMasterlist()
        {
            InitializeComponent();
        }

       
    }
}