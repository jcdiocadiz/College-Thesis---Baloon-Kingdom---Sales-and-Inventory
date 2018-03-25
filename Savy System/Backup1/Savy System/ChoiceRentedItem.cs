using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class ChoiceRentedItem : Form
    {
        public ChoiceRentedItem()
        {
            InitializeComponent();
        }

        private void COF_CheckedChanged(object sender, EventArgs e)
        {
            RentalCOFtxt.Enabled = true;
        }

        private void RentalViewrbtn_CheckedChanged(object sender, EventArgs e)
        {
            RentalCOFtxt.Enabled = false;
            RentalCOFtxt.Text = "";
        }

        private void RentalCancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RentalViewbtn_Click(object sender, EventArgs e)
        {
            if (RentalViewrbtn.Checked == true)
            {
                RentalCOFtxt.Text = "";
                RentalCOFtxt.Enabled = false;

                BalloonKingdomDataSetTableAdapters.Rented_ItemsTableAdapter rent = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Rented_ItemsTableAdapter();
                DataTable datatable = rent.RentView();

                RentalMasterlist rpt = new RentalMasterlist();

                LostCOFNo re = new LostCOFNo();
                re.SetDataSource(datatable);

                rpt.RentViewAll(re);
                rpt.Show();



            }

            else
            {
                if (RentalCOFtxt.Text != "")
                {
                    int a = Convert.ToInt32(RentalCOFtxt.Text);
                    BalloonKingdomDataSetTableAdapters.Rented_ItemsTableAdapter los = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Rented_ItemsTableAdapter();
                    DataTable datatable = los.LostCOF(a);

                    RentalMasterlist rpt = new RentalMasterlist();

                    LostCOFNo re = new LostCOFNo();
                    re.SetDataSource(datatable);

                    rpt.RentViewAll(re);
                    rpt.Show();
                }

                else
                {

                    MessageBox.Show("Enter COF Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
            
            }
        }

        private void RentalCOFtxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (RentalCOFtxt.Text != " ")
            {
                str = RentalCOFtxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((RentalCOFtxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", RentalCOFtxt);
                    RentalCOFtxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", RentalCOFtxt);
                    RentalCOFtxt.Clear();
                }
                toolTip1.Hide(RentalCOFtxt);
            }

        }
    }
}