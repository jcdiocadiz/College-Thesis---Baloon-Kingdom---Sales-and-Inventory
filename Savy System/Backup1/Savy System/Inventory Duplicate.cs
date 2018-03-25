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
    public partial class InvDupFrm : Form
    {

        static string str_conn = WindowsApplication1.Properties.Settings.Default.BKDatabaseConnectionString; private SqlConnection conn;
        private SqlDataReader dr;
        private SqlCommand cmd;
       string syspass;

        public InvDupFrm(string id, string name, string qty, string pass)
        {
            InitializeComponent();
            IDtxt.Text = Convert.ToString(id);
            ItemNmetxt.Text = name;
            qtytxt.Text = qty;
            syspass = pass;

        }

        private void InvDupFrm_Load(object sender, EventArgs e)
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

        private void okbtn_Click(object sender, EventArgs e)
        {
            if (donebytxt.Text.Trim() == "")
            {
                MessageBox.Show("Cannot process this transaction. Please write your name in the given field.", "Transaction Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (SyspassTxt.Text != syspass)
            {
                MessageBox.Show("Cannot process this transaction. Make sure that your password is correct!.", "Transaction Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SyspassTxt.Text = "";
            
            }
            else
            {

                int InvQty = 0;
                double stockQty = 0, total = 0, totalstock = 0;
                double UP = 0;
                string status;


                SqlCommand cmd25 = new SqlCommand("Select * from Inventory where [Item ID]=" + "'" + Convert.ToString(IDtxt.Text) + "'", conn);
                SqlDataReader dr25 = cmd25.ExecuteReader();
                while (dr25.Read())
                {
                    InvQty = Convert.ToInt32(dr25["Quantity"].ToString());
                    stockQty = Convert.ToDouble(dr25["Quantity in Stock"].ToString());
                    UP = Convert.ToDouble(dr25["Unit Price"].ToString());


                }

                dr25.Close();

                total = Convert.ToDouble(InvQty) + Convert.ToDouble(qtytxt.Text.Trim());
                totalstock = stockQty + Convert.ToDouble(qtytxt.Text.Trim());

                if (total != 0)
                {
                    status = "available";
                }
                else
                    status = "unavailable";
                BalloonKingdomDataSetTableAdapters.InventoryTableAdapter updateDuplicateItem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();



                updateDuplicateItem.UpdateDuplicateItem(Convert.ToInt32(total), Convert.ToInt32(totalstock), status, Convert.ToInt32(IDtxt.Text), Convert.ToInt32(IDtxt.Text));

                MessageBox.Show("Duplicate Item has been updated!", "Inventory Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           

                BalloonKingdomDataSetTableAdapters.Inventory_TransactionsTableAdapter addDupItem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Inventory_TransactionsTableAdapter();
                addDupItem.AddnewInventoryTrans(Convert.ToInt32(IDtxt.Text), ItemNmetxt.Text, "Adding", Convert.ToInt32(qtytxt.Text), DateTime.UtcNow, donebytxt.Text.Trim(),"Add Quantity to Duplicate Item");
                updateDuplicateItem.UpdateDuplicateItem(Convert.ToInt32(total), Convert.ToInt32(totalstock), status, Convert.ToInt32(IDtxt.Text), Convert.ToInt32(IDtxt.Text));

                                   
                this.Close();
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Failed to add quantity to duplicated item.", "Transaction Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();

        }

      
    }
}