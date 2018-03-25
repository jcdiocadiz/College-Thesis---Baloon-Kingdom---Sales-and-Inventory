using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class ReceivePO : Form
    {
        public ReceivePO()
        {
            InitializeComponent();
        }

        private void RcvNobtn_CheckedChanged(object sender, EventArgs e)
        {
            RcvNofrmtxt.Enabled = true;
            RcvNouptxt.Enabled = true;
            RcvFrmpick.Enabled = false;
            RcvUppick.Enabled = false;
        }

        private void RcvNofrmtxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (RcvNofrmtxt.Text != " ")
            {
                str = RcvNofrmtxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((RcvNofrmtxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", RcvNofrmtxt);
                    RcvNofrmtxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", RcvNofrmtxt);
                    RcvNofrmtxt.Clear();
                }
                toolTip1.Hide(RcvNofrmtxt);

            }
        }

        private void RcvNouptxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (RcvNouptxt.Text != " ")
            {
                str = RcvNouptxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((RcvNouptxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", RcvNouptxt);
                    RcvNouptxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", RcvNouptxt);
                    RcvNouptxt.Clear();
                }
                toolTip1.Hide(RcvNouptxt);

            }
        }

        private void RcvViewrbtn_CheckedChanged(object sender, EventArgs e)
        {

            RcvNofrmtxt.Text = "";
            RcvNouptxt.Text = "";
            RcvNofrmtxt.Enabled = false;
            RcvNouptxt.Enabled = false;
            RcvFrmpick.Enabled = false;
            RcvUppick.Enabled = false;

        }

        private void RcvDatebtn_CheckedChanged(object sender, EventArgs e)
        {
            RcvNofrmtxt.Text = "";
            RcvNouptxt.Text = "";
            RcvNofrmtxt.Enabled = false;
            RcvNouptxt.Enabled = false;
            RcvFrmpick.Enabled = true;
            RcvUppick.Enabled =true;
        }

        private void POCancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void POViewbtn_Click(object sender, EventArgs e)
        {
            if (RcvViewrbtn.Checked == true)

            {
                BalloonKingdomDataSetTableAdapters.Receive_PO_ItemTableAdapter view = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Receive_PO_ItemTableAdapter();
                DataTable datatable = view.RcvViewAll();

                RcvPOMasterlist rpt = new RcvPOMasterlist();

                Receive po = new Receive();
                po.SetDataSource(datatable);
                rpt.ViewAll(po);
                rpt.Show();
            
            }

            else if (RcvNobtn.Checked == true)
            {
                if ((RcvNofrmtxt.Text != "" && RcvNouptxt.Text == "") || (RcvNofrmtxt.Text == "" && RcvNouptxt.Text != "") || (RcvNofrmtxt.Text == "" && RcvNouptxt.Text == ""))
                {
                    MessageBox.Show("Enter receive number. first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else

                {
                    int a = Convert.ToInt32(RcvNofrmtxt.Text);
                    int b = Convert.ToInt32(RcvNouptxt.Text);

                    BalloonKingdomDataSetTableAdapters.Receive_PO_ItemTableAdapter id = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Receive_PO_ItemTableAdapter();
                    DataTable datatable = id.RcvNo(a, b);

                    RcvPOMasterlist rpt = new RcvPOMasterlist();

                    Receive po2 = new Receive();
                    po2.SetDataSource(datatable);
                    rpt.ViewAll(po2);
                    rpt.Show();

                }
            }
            else
            {
                BalloonKingdomDataSetTableAdapters.Receive_PO_ItemTableAdapter date = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Receive_PO_ItemTableAdapter();
                DataTable datatable = date.RcvDate(Convert.ToDateTime(RcvFrmpick.Value), Convert.ToDateTime(RcvUppick.Value));

                RcvPOMasterlist rpt = new RcvPOMasterlist();

                Receive po3 = new Receive();
                po3.SetDataSource(datatable);
                rpt.ViewAll(po3);
                rpt.Show();


            }
        }
    }
}