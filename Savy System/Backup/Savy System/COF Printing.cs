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
    public partial class COF_Printing : Form
    {
        static string str_conn = @"data source=JC-PC\SQLEXPRESS;initial catalog=BKDatabase; Integrated Security=True";

        SqlConnection conn;
         //SqlDataReader dr;
        SqlDataAdapter da;
        SqlCommand cmd;

        string cofNo;
       int x;

        public void AssignCOFPrint(COF rpt)
        {

            crystalReportViewer1.ReportSource = rpt;
        }

        public COF_Printing(string strCof)
        {
            this.cofNo = strCof;
            InitializeComponent();
        }


        private void COF_Printing_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = str_conn;
                conn.Open();
               

                //BalloonKingdomDataSetTableAdapters.COFItemOrderlineTableAdapter ord = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.COFItemOrderlineTableAdapter();
                //DataTable datatable = ord.cofanditem(cofNo);

                //BalloonKingdomDataSetTableAdapters.ordersTableAdapter ord = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.ordersTableAdapter();
                //    DataTable datatable = ord.tryone(cofNo);

                //BalloonKingdomDataSetTableAdapters.orderanditemTableAdapter orr = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.orderanditemTableAdapter();
                //DataTable datatable = orr.Pasta(cofNo);
                //BalloonKingdomDataSetTableAdapters.TryTryAgainTableAdapter add = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.TryTryAgainTableAdapter();
                //DataTable datatable = add.pestepeste(cofNo);;
               
                //BalloonKingdomDataSetTableAdapters.OrderNatinTableAdapter are = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderNatinTableAdapter();
                //    DataTable datatable = are.patay(cofNo);

                    //BalloonKingdomDataSetTableAdapters.cNewSelectCommandTableAdapter are = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.cNewSelectCommandTableAdapter();
                    //DataTable datatable = are.pagodnako(cofNo);

                x = Convert.ToInt32(cofNo);
                //cmd = new SqlCommand("SELECT        Orderline.[COF Number], Orderline.Lastname, Orderline.[First Name], Orderline.[Middle Initial], Orderline.[Order Date], Orderline.[Event Date], Orderline.Theme, Orderline.[Color Motif], Orderline.Venue, Item.[COF Number] AS Expr1, Item.[Item Name], Item.Quantity, Item.[Unit Cost], Item.[Sub Cost], Invoice.[COF Number] AS Expr2, Invoice.[Order Amount], Invoice.[Service Charge], Invoice.Total FROM Orderline INNER JOIN  Item ON Orderline.[COF Number] = Item.[COF Number] INNER JOIN Invoice ON Orderline.[COF Number] = Invoice.[COF Number]  WHERE Orderline.[COF Number]='" + x + "'",conn);
                //cmd.CommandType = CommandType.Text;
                //da = new SqlDataAdapter(cmd);
                //BalloonKingdomDataSet ds = new BalloonKingdomDataSet();
                //da.Fill(ds, "fNewSelectCommand");

                BalloonKingdomDataSetTableAdapters.jNewSelectCommandTableAdapter or = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.jNewSelectCommandTableAdapter();
                    DataTable datatable = or.OrderlineItems(x);
                COF cust = new COF();
                cust.SetDataSource(datatable);

               //COF3 cust = new COF3();
               //cust.SetDataSource(datatable);
              
                crystalReportViewer1.ReportSource = cust;

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