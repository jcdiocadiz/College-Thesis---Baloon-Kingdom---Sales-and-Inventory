using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class RcvPOMasterlist : Form
    {
        public void ViewAll(Receive rpt)
        {

            crystalReportViewer1.ReportSource = rpt;
        }


        public RcvPOMasterlist()
        {
            InitializeComponent();
        }

    }
}