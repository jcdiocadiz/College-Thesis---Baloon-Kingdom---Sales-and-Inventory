using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Choice_Order : Form
    {
        public Choice_Order()
        {
            InitializeComponent();
        }

        private void OrCancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrViewbtn_Click(object sender, EventArgs e)
        {
            
           

           if (OrViewrbtn.Checked == true)
            {
                BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter order2 = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                DataTable datatable = order2.ViewOrderline();

                Order_Masterlist rpt = new Order_Masterlist();
 
               
               OrderName nameor = new OrderName();
                nameor.SetDataSource(datatable);

                rpt.AssignOrName(nameor);

                rpt.Show();

            }

            else if (COFNorbtn.Checked == true)
            {
                if ((OrCOFFrmtxt.Text != "" && OrCOFUptxt.Text == "") || (OrCOFFrmtxt.Text == "" && OrCOFUptxt.Text != "") || (OrCOFFrmtxt.Text == "" && OrCOFUptxt.Text == ""))
                {
                    MessageBox.Show("Enter id first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    int a = Convert.ToInt32(OrCOFFrmtxt.Text);
                    int b = Convert.ToInt32(OrCOFUptxt.Text);

                    BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter orcof = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                    DataTable datatable = orcof.OrBeginEnd(a, b);

                    Order_Masterlist rpt = new Order_Masterlist();

                    OrderCOF coford = new OrderCOF();
                    coford.SetDataSource(datatable);

                    rpt.AssignOrCOF(coford);

                    rpt.Show();
                }
            }

            else
            {
               
                            BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter ordate = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                            DataTable datatable = ordate.OrDateBeginEnd(Convert.ToDateTime(OrderFrmpick.Value), Convert.ToDateTime(OrderUppick.Value));

                            Order_Masterlist rpt = new Order_Masterlist();

                            OrderDate dateor = new OrderDate();
                            dateor.SetDataSource(datatable);

                            rpt.AssignOrDate(dateor);

                            rpt.Show();
                        
                
            }

            
        }

        private void OrViewrbtn_CheckedChanged(object sender, EventArgs e)
        {
            
            OrderFrmpick.Enabled = false;
            OrderUppick.Enabled = false;
            OrCOFFrmtxt.Text = "";
            OrCOFUptxt.Text = "";
            OrCOFFrmtxt.Enabled = false;
            OrCOFUptxt.Enabled = false;
        }

        private void COFNorbtn_CheckedChanged(object sender, EventArgs e)
        {
            OrCOFFrmtxt.Enabled = true;
            OrCOFUptxt.Enabled = true;
           
            OrderFrmpick.Enabled = false;
            OrderUppick.Enabled = false;
        }

        private void OrDatebtn_CheckedChanged(object sender, EventArgs e)
        {
            OrderFrmpick.Enabled = true;
            OrderUppick.Enabled = true;
            OrCOFFrmtxt.Text = "";
            OrCOFUptxt.Text = "";
            OrCOFFrmtxt.Enabled = false;
            OrCOFUptxt.Enabled = false;
        }

        private void OrCOFFrmtxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (OrCOFFrmtxt.Text != " ")
            {
                str = OrCOFFrmtxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((OrCOFFrmtxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", OrCOFFrmtxt);
                    OrCOFFrmtxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", OrCOFFrmtxt);
                    OrCOFFrmtxt.Clear();
                }
                toolTip1.Hide(OrCOFFrmtxt);

            }
        }

        private void OrCOFUptxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (OrCOFUptxt.Text != " ")
            {
                str = OrCOFUptxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((OrCOFUptxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", OrCOFUptxt);
                    OrCOFUptxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", OrCOFUptxt);
                    OrCOFUptxt.Clear();
                }
                toolTip1.Hide(OrCOFUptxt);

            }
        }

      

       
    }
}