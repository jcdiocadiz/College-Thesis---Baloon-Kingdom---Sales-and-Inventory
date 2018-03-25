using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsApplication1
{
    public partial class ChoiceSalesReport : Form
    {

        public ChoiceSalesReport()
        {
            InitializeComponent();
        }

        private void SalesCancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalesViewbtn_Click(object sender, EventArgs e)
        {


                    BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter or = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                    DataTable datatable = or.tryMonths(Convert.ToDateTime(SalesBegin.Value), Convert.ToDateTime(SalesEnd.Value));

                    SalesMasterlist rpt = new SalesMasterlist();

                    SalesReport sale = new SalesReport();
                    sale.SetDataSource(datatable);

                    rpt.SaleRep(sale);
                    rpt.Show();



                    
                
            }
        }

       
     

        

       

       
    }








   
