using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class AccountReceive : Form
    {
        public void Acc(AccountRcv rpt)
        {

            crystalReportViewer1.ReportSource = rpt;
        }
        
        public AccountReceive()
        {
            InitializeComponent();
        }

      
    }
}