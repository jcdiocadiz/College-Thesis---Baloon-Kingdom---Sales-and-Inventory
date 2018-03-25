using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class ChoiceInventory : Form
    {
        public ChoiceInventory()
        {
            InitializeComponent();
        }

        private void InvCancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InvViewbtn_Click(object sender, EventArgs e)
        {

            if (ItemIDbtn.Checked == true)
            {

                if (InvFrmtxt.Text != "" && InvUptxt.Text == "")
                {
                    MessageBox.Show("Enter up to item id first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (InvFrmtxt.Text == "" && InvUptxt.Text != "")
                {
                    MessageBox.Show("Enter from item id first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (InvFrmtxt.Text == "" && InvUptxt.Text == "")
                {
                    MessageBox.Show("Enter from and up to item id first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {


                    int a = Convert.ToInt32(InvFrmtxt.Text);
                    int b = Convert.ToInt32(InvUptxt.Text);

                    BalloonKingdomDataSetTableAdapters.InventoryTableAdapter begin = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                    DataTable datatable = begin.InvBeginEnd(a, b);

                    Inventory_Masterlist rpt = new Inventory_Masterlist();

                    InventoryID invrpt = new InventoryID();
                    invrpt.SetDataSource(datatable);

                    rpt.AssignInvReport(invrpt);
                    rpt.Show();
                }
            }

            else if (Itemnmebtn.Checked == true)
            {
                BalloonKingdomDataSetTableAdapters.InventoryTableAdapter inv2 = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                DataTable datatable = inv2.GetAllInventoryRec();


                Inventory_Masterlist rpt = new Inventory_Masterlist();


                ItemName invname = new ItemName();
                invname.SetDataSource(datatable);

                rpt.AssignInvname(invname);
                rpt.Show();

            }
            else
            {
                BalloonKingdomDataSetTableAdapters.InventoryTableAdapter inv2 = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                DataTable datatable = inv2.GetAllInventoryRec();


                Inventory_Masterlist rpt = new Inventory_Masterlist();


                ItemStatus invstat = new ItemStatus();
                invstat.SetDataSource(datatable);

                rpt.AssignInvStat(invstat);
                rpt.Show();
            }


        }

        private void InvFrmtxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (InvFrmtxt.Text != " ")
            {
                str = InvFrmtxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((InvFrmtxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", InvFrmtxt);
                    InvFrmtxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", InvFrmtxt);
                    InvFrmtxt.Clear();
                }
                toolTip1.Hide(InvFrmtxt);

            }
        }

        private void InvUptxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (InvUptxt.Text != " ")
            {
                str = InvUptxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((InvUptxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", InvUptxt);
                    InvUptxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", InvUptxt);
                    InvUptxt.Clear();
                }
                toolTip1.Hide(InvUptxt);

            }
        }

        private void ItemIDbtn_CheckedChanged(object sender, EventArgs e)
        {
            InvFrmtxt.Enabled = true;
            InvUptxt.Enabled = true;
        }

        private void Itemnmebtn_CheckedChanged(object sender, EventArgs e)
        {
            InvFrmtxt.Text = "";
            InvUptxt.Text = "";
            InvFrmtxt.Enabled = false;
            InvUptxt.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            InvFrmtxt.Text = "";
            InvUptxt.Text = "";
            InvFrmtxt.Enabled = false;
            InvUptxt.Enabled = false;
        }

        private void InvUptxt_TextChanged_1(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (InvUptxt.Text != " ")
            {
                str = InvUptxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((InvUptxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", InvUptxt);
                    InvUptxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", InvUptxt);
                    InvUptxt.Clear();
                }
                toolTip1.Hide(InvUptxt);
            }
        }
    }
}