using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WindowsApplication1
{
    public partial class frmRentalChcklst : Form
    {
        static string str_conn = @"data source=JC-PC\SQLEXPRESS;initial catalog=BKDatabase; Integrated Security=True";

        private SqlConnection conn;
        private SqlDataReader dr;
        private SqlCommand cmd;


        public frmRentalChcklst()
        {
            InitializeComponent();
        }

        private void frmRentalChcklst_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'balloonKingdomDataSet.Rental_Checklist' table. You can move, or remove it, as needed.
           // this.rental_ChecklistTableAdapter.Fill(this.balloonKingdomDataSet.Rental_Checklist);

            try
            {

                conn = new SqlConnection();
                conn.ConnectionString = str_conn;
                conn.Open();
                if (conn.State != ConnectionState.Open)
                    MessageBox.Show("Unable to connect to database", "Connection Status");
            }
            catch (Exception x)
            { MessageBox.Show(x.GetBaseException().ToString(), "Connection status"); }

            BalloonKingdomDataSetTableAdapters.Rental_ChecklistTableAdapter viewrentalchklst = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Rental_ChecklistTableAdapter();
          CheckListDataGV.DataSource = viewrentalchklst.ViewRentalChecklist();



        }

        private void CheckListDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
            COFNumCHLbl.Text= CheckListDataGV.SelectedRows[0].Cells[1].Value.ToString();
            ItemIDCHLbl.Text= CheckListDataGV.SelectedRows[0].Cells[2].Value.ToString();
            CatNameCHLbl.Text= CheckListDataGV.SelectedRows[0].Cells[3].Value.ToString();
            SubCatCHLbl.Text= CheckListDataGV.SelectedRows[0].Cells[4].Value.ToString();
            SpeCatCHLbl.Text= CheckListDataGV.SelectedRows[0].Cells[5].Value.ToString();
            ItemNmeChLbl.Text= CheckListDataGV.SelectedRows[0].Cells[6].Value.ToString();

            DateReleaseDpic.Value = Convert.ToDateTime(CheckListDataGV.SelectedRows[0].Cells[7].Value.ToString());
            TimeReleasedDpic.Value =Convert.ToDateTime(CheckListDataGV.SelectedRows[0].Cells[8].Value.ToString());

            IssuedByCHLbl.Text=CheckListDataGV.SelectedRows[0].Cells[15].Value.ToString();
            PickedUpByCHLbl.Text=CheckListDataGV.SelectedRows[0].Cells[16].Value.ToString();
            IDChLbl.Text=CheckListDataGV.SelectedRows[0].Cells[20].Value.ToString();
            RecordedByCHLbl.Text=CheckListDataGV.SelectedRows[0].Cells[17].Value.ToString();
            RentAmtLbl.Text = CheckListDataGV.SelectedRows[0].Cells[23].Value.ToString();

            try
            {
                DateRetunCHDPic.Value = Convert.ToDateTime(CheckListDataGV.SelectedRows[0].Cells[12].Value.ToString());
                TimeReturnDPic.Value = Convert.ToDateTime(CheckListDataGV.SelectedRows[0].Cells[13].Value.ToString());
            }
            catch { }
            RcvByCHLbl.Text=CheckListDataGV.SelectedRows[0].Cells[18].Value.ToString();
            RecordRetCHLbl.Text=CheckListDataGV.SelectedRows[0].Cells[19].Value.ToString();
            RefundCHLbl.Text = CheckListDataGV.SelectedRows[0].Cells[22].Value.ToString();


        }

        private void ProcRefundBtn_Click(object sender, EventArgs e)
        {

            SqlCommand getref = new SqlCommand("Select distinct [Refund Amount] from [Rental Checklist] where [COF Number]=" + "'" + COFNumCHLbl.Text+ "'", conn);
            double refun = Convert.ToDouble(getref.ExecuteScalar());

            string id;
            int id2 = 0, a = 0;
            SqlCommand cmd5 = new SqlCommand("Select * from [Rental Refund]", conn);
            SqlDataReader dr8 = cmd5.ExecuteReader();
            while (dr8.Read())
            {
                id = dr8["Rental Refund ID"].ToString();
                id2 = Convert.ToInt32(id);
                if (a < id2)
                    a = id2;



            }
            dr8.Close();
            a++;

            BalloonKingdomDataSetTableAdapters.Rental_RefundTableAdapter addref = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Rental_RefundTableAdapter();
            addref.AddRentalRefund(a, Convert.ToInt32(COFNumCHLbl.Text), DateTime.Today, DateTime.Today, Convert.ToDecimal(refun), Convert.ToDecimal(RentAmtLbl.Text));

        }

       

    }
}