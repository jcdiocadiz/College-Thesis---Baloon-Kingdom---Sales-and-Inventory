using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class AccountPay : Form
    {
       public void Paya (AccountPaya rpt)
       {
       
       crystalReportViewer1.ReportSource = rpt;
       }
        
        public AccountPay()
        {
            InitializeComponent();
        }

        private void AccountPay_Load(object sender, EventArgs e)
        {

        }

       

       
    }
}