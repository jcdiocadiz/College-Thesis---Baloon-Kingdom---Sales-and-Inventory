using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Choice_OR : Form
    {
        public Choice_OR()
        {
            InitializeComponent();
        }

        private void ORVibtn_Click(object sender, EventArgs e)
        {
            if (ORvirbtn.Checked == true)
            {
                ORnumtxt.Text = "";
                ORnumtxt.Enabled = false;

                BalloonKingdomDataSetTableAdapters.Official_ReceiptTableAdapter orview = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Official_ReceiptTableAdapter();
                DataTable datatable = orview.ViewAll();

                Official_Receipt_Masterlist rpt = new Official_Receipt_Masterlist();

                OfficialReceipt orpt = new OfficialReceipt();
                orpt.SetDataSource(datatable);

                rpt.AssignORReport(orpt);
                rpt.Show();





            }

            else
            {

                
                if ((ORnumtxt.Text != "" && ORUptxt.Text == "") || (ORnumtxt.Text == "" && ORUptxt.Text != "") ||(ORnumtxt.Text == "" && ORUptxt.Text == ""))
                {
                    MessageBox.Show("Please enter an OR ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {


                    int a = Convert.ToInt32(ORnumtxt.Text);
                    int b = Convert.ToInt32(ORUptxt.Text);
                    BalloonKingdomDataSetTableAdapters.Official_ReceiptTableAdapter ornum = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Official_ReceiptTableAdapter();
                    DataTable datatable = ornum.orselect(a,b);

                    Official_Receipt_Masterlist rpt = new Official_Receipt_Masterlist();

                    OfficialReceipt orpt = new OfficialReceipt();
                    orpt.SetDataSource(datatable);

                    rpt.AssignORReport(orpt);
                    rpt.Show();
                }




            }
        }

        private void ORCanbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ORIDrbtn_CheckedChanged(object sender, EventArgs e)
        {
            
                ORnumtxt.Enabled = true;
                ORUptxt.Enabled = true;

            
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

        private void ORvirbtn_CheckedChanged(object sender, EventArgs e)
        {
            ORnumtxt.Text = "";
            ORUptxt.Text = "";
            ORUptxt.Enabled = false;
            ORnumtxt.Enabled = false;
        }

        private void ORUptxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (ORUptxt.Text != " ")
            {
                str = ORUptxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((ORUptxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", ORUptxt);
                    ORUptxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", ORUptxt);
                    ORUptxt.Clear();
                }
                toolTip1.Hide(ORUptxt);

            }

            
        }

      

      

       
       
    }
    }
