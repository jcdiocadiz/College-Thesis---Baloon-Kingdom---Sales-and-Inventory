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
    public partial class UpdatQty : Form
    {
        static string str_conn = @"data source=JC-PC\SQLEXPRESS;initial catalog=BKDatabase; Integrated Security=True";
        private SqlConnection conn;
        private SqlDataReader dr;
        private SqlCommand cmd;
        string password;
       
        public UpdatQty(string id, string name, string pass)
        {
            InitializeComponent();
            idlbl.Text = id;
            txtname.Text = name;
            password = pass;
        }

     

        private void okbtn_Click(object sender, EventArgs e)
        {


            if (donebytxt.Text.Trim() == "" || reasontxt.Text.Trim() == "" || qtytxt.Text.Trim()=="")
            {
                MessageBox.Show("Cannot process this transaction. Please write fill up the given field.", "Transaction Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               Syspasstxt.Text = "";
             }

             else if (Syspasstxt.Text != password)
             {
                 MessageBox.Show("Cannot process this transaction. Make sure that your password is correct!.", "Transaction Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Syspasstxt.Text = "";
                 Syspasstxt.Focus();
             }
             else
             {
                 string trans;
                 if (addbtn.Checked == true)
                     trans = "Adding";
                 else
                     trans = "Subtracting";
                







                 int quantity = Convert.ToInt32(qtytxt.Text.Trim());
                 double qty = 0, stock = 0, bo = 0;
                 SqlCommand getinv = new SqlCommand("Select * from Inventory where [Item ID]=" + "'" + idlbl.Text.Trim() + "'", conn);
                 SqlDataReader drget = getinv.ExecuteReader();
                 while (drget.Read())
                 {
                     qty = Convert.ToDouble(drget["Quantity"].ToString());
                     stock = Convert.ToDouble(drget["Quantity in Stock"].ToString());
                     bo = Convert.ToDouble(drget["Back Order"].ToString());


                 }
                 drget.Close();

                 if (addbtn.Checked == true)
                 {
                     qty += quantity;
                     stock += Convert.ToDouble(quantity);
                     bo -= Convert.ToDouble(quantity);
                     if (bo < 0)
                         bo = 0;


                 }
                 else
                 {
                     qty -= quantity;
                     stock -= Convert.ToDouble(quantity);
                     if (stock == 0)
                     {
                         stock = 0;
                         bo += Convert.ToDouble(quantity);
                     }

                 }
                 BalloonKingdomDataSetTableAdapters.Inventory_TransactionsTableAdapter addInvItem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Inventory_TransactionsTableAdapter();
                 addInvItem.AddnewInventoryTrans(Convert.ToInt32(idlbl.Text), txtname.Text, trans, Convert.ToInt32(qtytxt.Text), DateTime.Now, donebytxt.Text.Trim(), reasontxt.Text.Trim());


                 BalloonKingdomDataSetTableAdapters.InventoryTableAdapter update = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                 update.UpdateInvQuantity(Convert.ToInt32(qty), Convert.ToDecimal(stock), Convert.ToInt32(bo), Convert.ToInt32(idlbl.Text.Trim()), Convert.ToInt32(idlbl.Text.Trim()));
                 MessageBox.Show("Successfully updated Inventory Item Quantity", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.Close();
             }
        }

        private void canbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Failed to update inventory!", "Transaction Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
     
            this.Close();
        }

        private void UpdatQty_Load(object sender, EventArgs e)
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

        private void qtytxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (qtytxt.Text != " ")
            {
                str = qtytxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((qtytxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", qtytxt);
                    qtytxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", qtytxt);
                    qtytxt.Clear();
                }
                toolTip1.Hide(qtytxt);

            }
        }


       
    }
}