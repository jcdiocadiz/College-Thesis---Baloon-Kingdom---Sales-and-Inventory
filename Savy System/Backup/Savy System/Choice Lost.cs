using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Choice_Lost : Form
    {
        public Choice_Lost()
        {
            InitializeComponent();
        }

        private void LostViewbtn_Click(object sender, EventArgs e)
        {
            if (LostViewrbtn.Checked == true)
            {
                LostQtytxt.Clear();
                LostItemtxt.Clear();
                LostQtytxt.Enabled = false;
                LostItemtxt.Enabled = false;

                BalloonKingdomDataSetTableAdapters.InventoryTableAdapter lost = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                DataTable datatable = lost.ViewLostQty();

                Lost_Item rpt = new Lost_Item();

                Lost lostit = new Lost();
                lostit.SetDataSource(datatable);

                rpt.AssignLost(lostit);

                rpt.Show();
            }

            else if (LostQtyrbtn.Checked == true)
            {
               

                if (LostQtytxt.Text != "")
                {
                    int a = Convert.ToInt32(LostQtytxt.Text);
                    BalloonKingdomDataSetTableAdapters.Rented_ItemsTableAdapter los = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Rented_ItemsTableAdapter();
                    DataTable datatable = los.LostCOF(a);

                    
                    
                    Lost_Item rpt = new Lost_Item();
                    LostCOFNo loss = new LostCOFNo();
                    loss.SetDataSource(datatable);
                    

                    rpt.AssignCOF(loss);

                    rpt.Show();
                }

                else
                {
                    MessageBox.Show("Please enter COF Number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else

            {
                
                if (LostItemtxt.Text != "")
                {
                    int a = Convert.ToInt32(LostItemtxt.Text);
                    BalloonKingdomDataSetTableAdapters.InventoryTableAdapter lostitem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                    DataTable datatable = lostitem.Itemid(a);


                    Lost_Item rpt = new Lost_Item();
                    Lost losts = new Lost();
                    losts.SetDataSource(datatable);

                    rpt.AssignLost(losts);

                    rpt.Show();
                }

                else
                {
                    MessageBox.Show("Please enter Item ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                }
            
            }

        }

        private void LostQtytxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (LostQtytxt.Text != " ")
            {
                str = LostQtytxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((LostQtytxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", LostQtytxt);
                    LostQtytxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", LostQtytxt);
                    LostQtytxt.Clear();
                }
                toolTip1.Hide(LostQtytxt);
            }


        }

        private void LostCancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LostQtyrbtn_CheckedChanged(object sender, EventArgs e)
        {
            LostQtytxt.Enabled = true;
            LostItemtxt.Clear();
            LostItemtxt.Enabled = false;
        }

        private void LostViewrbtn_CheckedChanged(object sender, EventArgs e)
        {
            LostQtytxt.Clear();
            LostQtytxt.Enabled = false;
        }

        private void LostItemtxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (LostItemtxt.Text != " ")
            {
                str = LostItemtxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((LostItemtxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", LostItemtxt);
                    LostItemtxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", LostItemtxt);
                    LostItemtxt.Clear();
                }
                toolTip1.Hide(LostItemtxt);
            }
        }

        private void LostItemrbtn_CheckedChanged(object sender, EventArgs e)
        {
            LostQtytxt.Enabled = false;
            LostQtytxt.Clear();
            LostItemtxt.Enabled = true;
        }
    }
}