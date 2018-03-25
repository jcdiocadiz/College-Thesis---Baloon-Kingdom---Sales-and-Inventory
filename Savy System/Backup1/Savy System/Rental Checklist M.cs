using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Rental_Checklist_M : Form
    {
        public void Checklist(ViewRental rpt)
        {

            crystalReportViewer1.ReportSource = rpt;
        }
        
        public Rental_Checklist_M()
        {
            InitializeComponent();
        }

        
    }
}