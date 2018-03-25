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
    public partial class POF_Printing : Form
    {
            static string str_conn = @"data source=JC-PC\SQLEXPRESS;initial catalog=BKDatabase; Integrated Security=True";

            SqlConnection conn;

            int pofNo;
            //int x;

            public void Purchase(POF rpt)
            {
                crystalReportViewer1.ReportSource = rpt;

            }

            public POF_Printing(int strpof)
            {
                this.pofNo = strpof;
                InitializeComponent();
            }

            private void POF_Printing_Load(object sender, EventArgs e)
            {
                try
                {
                    conn = new SqlConnection();
                    conn.ConnectionString = str_conn;
                    conn.Open();
                    //x = Convert.ToInt32(pofNo);
                    // cmd = new SqlCommand("SELECT Item.[COF Number], Item.[Item Name], Item.Quantity, Item.[Unit Cost], Item.[Sub Cost], Orderline.[COF Number] AS Expr1, Orderline.Lastname, Orderline.[First Name], Orderline.[Middle Initial], Orderline.[Order Date], Orderline.[Event Date], Orderline.[Event Time], Orderline.Theme, Orderline.[Color Motif], Orderline.Venue, Orderline.Balance, Orderline.[Full payment], Orderline.[Down payment], Orderline.[Order Amount], Orderline.[Service Charge], Orderline.Total, Orderline.Discount, Orderline.[Overall Total], Orderline.[Vat Amount] FROM Item INNER JOIN Orderline ON Item.[COF Number] = Orderline.[COF Number] WHERE Orderline.[COF Number]='" + cofNo + "'",conn);
                    // cmd.CommandType = CommandType.Text;
                    // da = new SqlDataAdapter(cmd);
                    // BalloonKingdomDataSet ds = new BalloonKingdomDataSet();
                    //da.Fill(ds, "orders");

                    BalloonKingdomDataSetTableAdapters.Purchase_OrderlineTableAdapter order = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Purchase_OrderlineTableAdapter();
                    DataTable datatable = order.POpurchase(pofNo);

                    POF pur = new POF();
                    pur.SetDataSource(datatable);

                    crystalReportViewer1.ReportSource = pur;

                    //rpt.AssignCOFPrint(cust);
                    //rpt.Show();
                    //crystalReportViewer1.Zoom(90);
                    //cmd.Dispose();
                    conn.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString());
                }
            }


        }
      
   
}