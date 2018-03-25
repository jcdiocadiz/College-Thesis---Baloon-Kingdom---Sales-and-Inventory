using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Customer_Masterlist : Form
    {
        public void AssignCustReport(CrystalReport1 rpt)
        {
            crystalReportViewer1.ReportSource = rpt;
        }

        public void AssignFname(CustomerFname rpt)

        {
            crystalReportViewer1.ReportSource = rpt;
        
        }

        public void AssignLname(CustomerLname rpt)

        {

            crystalReportViewer1.ReportSource = rpt;
        
        
        }


        public Customer_Masterlist()
        {
            InitializeComponent();
        }

       

       

       

       

        

       
       
    }
}