using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class RentalCheck : Form
    {
        public RentalCheck()
        {
            InitializeComponent();
        }

        private void RentalCancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RentalViewrbtn_CheckedChanged(object sender, EventArgs e)
        {
            
            RentalDatetxt.Text = "";
            RentalDatetxt.Enabled = false;
        }

        private void RentalDaterbtn_CheckedChanged(object sender, EventArgs e)
        {
            RentalDatetxt.Enabled = true;
            
        }

        private void RentalRangerbtn_CheckedChanged(object sender, EventArgs e)
        {
            RentalDatetxt.Text = "";
            RentalDatetxt.Enabled = false;
           
        }

        private void RentalViewbtn_Click(object sender, EventArgs e)
        {
            if (RentalViewrbtn.Checked == true)
            {
                BalloonKingdomDataSetTableAdapters.Rental_ChecklistTableAdapter view = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Rental_ChecklistTableAdapter();
                DataTable datatable = view.ViewRentalChecklist();

                Rental_Checklist_M rpt = new Rental_Checklist_M();

                ViewRental vi = new ViewRental();
                vi.SetDataSource(datatable);


                rpt.Checklist(vi);

                rpt.Show();

            }

            else 
            {
                if (RentalDatetxt.Text == "")
                {
                    MessageBox.Show("Enter date first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    int a = Convert.ToInt32(RentalDatetxt.Text);

                    BalloonKingdomDataSetTableAdapters.Rental_ChecklistTableAdapter rent = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Rental_ChecklistTableAdapter();
                    DataTable datatable = rent.COFRented(a);

                    Rental_Checklist_M rpt = new Rental_Checklist_M();

                    ViewRental vi = new ViewRental();
                    vi.SetDataSource(datatable);


                    rpt.Checklist(vi);

                    rpt.Show();





                
                }



            }


            
           
        }

        private void RentalDatetxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (RentalDatetxt.Text != " ")
            {
                str = RentalDatetxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((RentalDatetxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", RentalDatetxt);
                    RentalDatetxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", RentalDatetxt);
                    RentalDatetxt.Clear();
                }
                toolTip1.Hide(RentalDatetxt);

            }
        }
    }
}