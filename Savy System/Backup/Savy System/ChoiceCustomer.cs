using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class ChoiceCustomer : Form
    {
        public ChoiceCustomer()
        {
            InitializeComponent();
        }

        private void CustViewbtn_Click(object sender, EventArgs e)
        {
            

            if (CustIDrbtn.Checked == true)
            {

                CustIDfrmtxt.Text = "";
                CustIDuptxt.Text = "";
                CustLasFrmtxt.Text = "";
                CustLasUptxt.Text = "";
                CustIDfrmtxt.Enabled = false;
                CustIDuptxt.Enabled = false;
                CustLasFrmtxt.Enabled = false;
                CustLasUptxt.Enabled = false;

                BalloonKingdomDataSetTableAdapters.CustomerTableAdapter cust2 = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
                DataTable datatable = cust2.ViewCustomer();

                Customer_Masterlist rpt = new Customer_Masterlist();


                CrystalReport1 custrpt = new CrystalReport1();
                custrpt.SetDataSource(datatable);

                rpt.AssignCustReport(custrpt);
                rpt.Show();

            }

            else if (Custidbtn.Checked == true)
            {
                if (CustIDfrmtxt.Text != "" && CustIDuptxt.Text == "")
                {

                    MessageBox.Show("Enter up to id first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                }

                else if (CustIDfrmtxt.Text == "" && CustIDuptxt.Text != "")
                {

                    MessageBox.Show("Enter from id first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (CustIDfrmtxt.Text == "" && CustIDuptxt.Text == "")
                {

                    MessageBox.Show("Enter from and up to id first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
              
                    else
                    {
                    int a = Convert.ToInt32(CustIDfrmtxt.Text);
                    int b = Convert.ToInt32(CustIDuptxt.Text);

                    BalloonKingdomDataSetTableAdapters.CustomerTableAdapter bend2 = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
                    DataTable datatable = bend2.CustIDBeginEnd(a, b);

                    Customer_Masterlist rpt = new Customer_Masterlist();


                    CustomerFname custrpt2 = new CustomerFname();
                    custrpt2.SetDataSource(datatable);

                    rpt.AssignFname(custrpt2);
                    rpt.Show();
                    }
                }

            

            else
            {
                if (CustLasFrmtxt.Text!="" && CustLasUptxt.Text=="")
                {

                    MessageBox.Show("Enter up to name first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else if (CustLasFrmtxt.Text == "" && CustLasUptxt.Text != "")
                {

                    MessageBox.Show("Enter from name first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (CustLasFrmtxt.Text == "" && CustLasUptxt.Text == "")
                {

                    MessageBox.Show("Enter from and up to name first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    string a = Convert.ToString(CustLasFrmtxt.Text);
                    string b = Convert.ToString(CustLasUptxt.Text);

                    BalloonKingdomDataSetTableAdapters.CustomerTableAdapter bend = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
                    DataTable datatable = bend.CustBeginEnd(a, b);

                    Customer_Masterlist rpt = new Customer_Masterlist();

                    CustomerLname custrpt3 = new CustomerLname();
                    custrpt3.SetDataSource(datatable);

                    rpt.AssignLname(custrpt3);
                    rpt.Show();
                }
            }

           

           
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancelbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lnamebtn_CheckedChanged(object sender, EventArgs e)
        {
            CustLasFrmtxt.Enabled = true;
            CustLasUptxt.Enabled = true;
            CustIDfrmtxt.Text = "";
            CustIDuptxt.Text = "";
            CustIDfrmtxt.Enabled = false;
            CustIDuptxt.Enabled = false;
        }

        private void Custidbtn_CheckedChanged(object sender, EventArgs e)
        {
            CustIDfrmtxt.Enabled = true;
            CustIDuptxt.Enabled = true;
            CustLasFrmtxt.Text = "";
            CustLasUptxt.Text = "";
            CustLasFrmtxt.Enabled = false;
            CustLasUptxt.Enabled = false;
        }

        private void CustIDfrmtxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (CustIDfrmtxt.Text != " ")
            {
                str = CustIDfrmtxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((CustIDfrmtxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", CustIDfrmtxt);
                    CustIDfrmtxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", CustIDfrmtxt);
                    CustIDfrmtxt.Clear();
                }
                toolTip1.Hide(CustIDfrmtxt);

            }
        }

        private void CustLasFrmtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                string txt;
                if (CustLasFrmtxt.Text != "")
                {
                    txt = CustLasFrmtxt.Text;
                    x = txt.Length - 1;

                    if (CustLasFrmtxt.Text == "")
                    {
                        toolTip1.Show("Avoid special characters!", CustLasFrmtxt);
                        CustLasFrmtxt.Clear();
                        toolTip1.Hide(CustLasFrmtxt);
                    }

                    else if (char.IsWhiteSpace(txt[x]))
                    {
                        CustLasFrmtxt.Text = txt.Replace(txt[x], ' ');
                        toolTip1.Show("Avoid special characters!", CustLasFrmtxt);
                        toolTip1.Hide(CustLasFrmtxt);
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString(), "error");
            }


        }

        

         

        private void CustLasFrmtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
             if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz-'`.".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void CustLasUptxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz-'`.".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void CustLasUptxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                string txt;
                if (CustLasUptxt.Text != "")
                {
                    txt = CustLasUptxt.Text;
                    x = txt.Length - 1;

                    if (CustLasUptxt.Text == "")
                    {
                        toolTip1.Show("Avoid special characters!", CustLasUptxt);
                        CustLasUptxt.Clear();
                        toolTip1.Hide(CustLasUptxt);
                    }

                    else if (char.IsWhiteSpace(txt[x]))
                    {
                        CustLasUptxt.Text = txt.Replace(txt[x], ' ');
                        toolTip1.Show("Avoid special characters!", CustLasUptxt);
                        toolTip1.Hide(CustLasUptxt);
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString(), "error");
            }
        }

        private void CustIDuptxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (CustIDuptxt.Text != " ")
            {
                str = CustIDuptxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((CustIDuptxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", CustIDuptxt);
                    CustIDuptxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", CustIDuptxt);
                    CustIDuptxt.Clear();
                }
                toolTip1.Hide(CustIDuptxt);

            }
        }

}
}