using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Choice_PO : Form
    {
        public Choice_PO()
        {
            InitializeComponent();
        }

        private void POViewbtn_Click(object sender, EventArgs e)
        {
            

            if (POViewrbtn.Checked == true)
            {
                BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter po = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter();
                DataTable datatable = po.GetPORec();

                PO_Masterlist rpt = new PO_Masterlist();

                POSuppName poname = new POSuppName();
                poname.SetDataSource(datatable);

                rpt.AssignPOName(poname);
                rpt.Show();
            }
            
            else if(PONobtn.Checked == true)
            {
                if ((PONofrmtxt.Text != "" && PONouptxt.Text == "") || (PONofrmtxt.Text == "" && PONouptxt.Text != "") || (PONofrmtxt.Text == "" && PONouptxt.Text == ""))
                {

                    MessageBox.Show("Enter po no. first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    int a = Convert.ToInt32(PONofrmtxt.Text);
                    int b = Convert.ToInt32(PONouptxt.Text);

                    BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter purbegin = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter();
                    DataTable datatable = purbegin.POFBeginEnd(a, b);

                    PO_Masterlist rpt = new PO_Masterlist();
                    PONum ponum = new PONum();
                    ponum.SetDataSource(datatable);

                    rpt.AssignPOReport(ponum);
                    rpt.Show();
                }
            }

         

            else 
            {
               

                            BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter purend = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter();
                            DataTable datatable = purend.PODatebeginend(Convert.ToDateTime(POFrmpick.Value), Convert.ToDateTime(POUppick.Value));

                            PO_Masterlist rpt = new PO_Masterlist();
                            PODate podate = new PODate();
                            podate.SetDataSource(datatable);

                            rpt.AssignPODate(podate);
                            rpt.Show();
                        
                
            }

          

     
        }

        private void POCancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PONofrmtxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (PONofrmtxt.Text != " ")
            {
                str = PONofrmtxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((PONofrmtxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", PONofrmtxt);
                    PONofrmtxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", PONofrmtxt);
                    PONofrmtxt.Clear();
                }
                toolTip1.Hide(PONofrmtxt);

            }
        }

        private void PONouptxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (PONouptxt.Text != " ")
            {
                str = PONouptxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((PONouptxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", PONouptxt);
                    PONouptxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", PONouptxt);
                    PONouptxt.Clear();
                }
                toolTip1.Hide(PONouptxt);

            }
        }

      

        

        private void POViewrbtn_CheckedChanged(object sender, EventArgs e)
        {
            
            PONofrmtxt.Text = "";
            PONouptxt.Text = "";
            POFrmpick.Enabled = false;
            POUppick.Enabled = false;
            PONouptxt.Enabled = false;
            PONofrmtxt.Enabled = false;

        }

        private void PONobtn_CheckedChanged(object sender, EventArgs e)
        {
            PONofrmtxt.Enabled = true;
            PONouptxt.Enabled = true;
            POFrmpick.Enabled = false;
            POUppick.Enabled = false;
        }

        private void PODatebtn_CheckedChanged(object sender, EventArgs e)
        {


            POFrmpick.Enabled = true;
            POUppick.Enabled = true;
            PONofrmtxt.Text = "";
            PONouptxt.Text = "";
            PONofrmtxt.Enabled = false;
            PONofrmtxt.Enabled = false;
        }

        private void Choice_PO_Load(object sender, EventArgs e)
        {

        }

       
    }
}