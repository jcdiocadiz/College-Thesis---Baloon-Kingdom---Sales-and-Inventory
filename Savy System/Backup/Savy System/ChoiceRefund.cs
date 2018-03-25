using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class ChoiceRefund : Form
    {
        public ChoiceRefund()
        {
            InitializeComponent();
        }

        private void RefundViewrbtn_CheckedChanged(object sender, EventArgs e)
        {
            RefundCOFtxt.Text = "";
            RefundCOFtxt.Enabled = false;
        }

        private void RefundCOFrbtn_CheckedChanged(object sender, EventArgs e)
        {
            RefundCOFtxt.Enabled = true;
        }

        private void RefundCancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefundViewbtn_Click(object sender, EventArgs e)
        {
            if (RefundViewrbtn.Checked == true)
            {
                BalloonKingdomDataSetTableAdapters.Rental_RefundTableAdapter rf = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Rental_RefundTableAdapter();
                DataTable datatable = rf.View();
                
                RefundMasterlist rpt = new RefundMasterlist();
                RefundView view = new RefundView();
                view.SetDataSource(datatable);
                rpt.RefundViewAll(view);
                rpt.Show();
            }

            else
            {
                if (RefundCOFtxt.Text != "")
                {
                    int a = Convert.ToInt32(RefundCOFtxt.Text);
                    BalloonKingdomDataSetTableAdapters.Rental_RefundTableAdapter rf = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Rental_RefundTableAdapter();
                    DataTable datatable = rf.Refund(a);

                    RefundMasterlist rpt = new RefundMasterlist();
                    RefundView view = new RefundView();
                    view.SetDataSource(datatable);
                    rpt.RefundViewAll(view);
                    rpt.Show();
                }

                else
                {
                    MessageBox.Show("Enter COF number first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                }
            
            
            }
        }

        private void RefundCOFtxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (RefundCOFtxt.Text != " ")
            {
                str = RefundCOFtxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((RefundCOFtxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", RefundCOFtxt);
                    RefundCOFtxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", RefundCOFtxt);
                    RefundCOFtxt.Clear();
                }
                toolTip1.Hide(RefundCOFtxt);

            }

        }
    }
}