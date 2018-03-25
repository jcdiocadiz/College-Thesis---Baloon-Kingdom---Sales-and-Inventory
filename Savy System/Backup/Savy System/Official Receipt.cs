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
    public partial class frmOR : Form
    {
        static string str_conn = @"data source=.\SQLEXPRESS;initial catalog=BKDatabase; Integrated Security=True";

        private SqlConnection conn;
        private SqlCommand cmd;
        string password;

        public frmOR(string COFNum, string VATPer, string VATAmt, string SerCh, string Tot, string OrderAmt, string pass)
        {
            InitializeComponent();

            COFNumLbl.Text = COFNum;
            password = pass;
            VatPerLbl.Text = VATPer;
            VATAmtLbl.Text = VATAmt;
            ServChLbl.Text = SerCh;
            TotLbl.Text = Tot;
            OrderAmtLbl.Text = OrderAmt;

        }

        private void frmOR_Load(object sender, EventArgs e)
        {
         
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

              

              

            
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            if (ORnumtxt.Text == "" || Syspasstxt.Text == "" || Recordtxt.Text=="")
            {
                MessageBox.Show("Please fill up the required fields.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                ORnumtxt.Focus();
            }
            else if (Syspasstxt.Text.Trim()!=password)
            {
                MessageBox.Show("Invalid password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Syspasstxt.Text = "";
            }

            else
            {
                String id;
                int a = 0, id2;



 cmd = new SqlCommand("Select * from [Official Receipt]", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    id = dr["OR ID"].ToString();
                    id2 = Convert.ToInt32(id);
                    if (a < id2)
                        a = id2;

                }
                dr.Close();
                a++;
                 
                 BalloonKingdomDataSetTableAdapters.Official_ReceiptTableAdapter addor = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Official_ReceiptTableAdapter();
                 addor.AddOfficialReceipt(a, DateTime.Now, ORnumtxt.Text.Trim(), Convert.ToInt32(COFNumLbl.Text), Convert.ToDecimal(VatPerLbl.Text), Convert.ToDecimal(VATAmtLbl.Text), Convert.ToDecimal(OrderAmtLbl.Text), Convert.ToDecimal(ServChLbl.Text), Convert.ToDecimal(TotLbl.Text), Recordtxt.Text.Trim());
            MessageBox.Show("Successfully entered your OR number!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

}

        private void ORnumtxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (ORnumtxt.Text != " ")
            {
                str = ORnumtxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((ORnumtxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", ORnumtxt);
                    ORnumtxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", ORnumtxt);
                    ORnumtxt.Clear();
                }
                toolTip1.Hide(ORnumtxt);

            }
        }
    }
}