using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Choice_Supplier : Form
    {
        public Choice_Supplier()
        {
            InitializeComponent();
        }

        private void SuppCancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuppViewbtn_Click(object sender, EventArgs e)
        {
            
           
            if (SuppIDbtn.Checked == true)
            {
                if ((SupIDFrmtxt.Text != "" && SupIDUptxt.Text == "") || (SupIDFrmtxt.Text == "" && SupIDUptxt.Text != "") || (SupIDFrmtxt.Text == "" && SupIDUptxt.Text == ""))
                {
                    MessageBox.Show("Enter id first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    int a = Convert.ToInt32(SupIDFrmtxt.Text);
                    int b = Convert.ToInt32(SupIDUptxt.Text);

                    BalloonKingdomDataSetTableAdapters.SupplierTableAdapter supp = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.SupplierTableAdapter();
                    DataTable datatable = supp.SuppBeginEnd(a, b);

                    Supplier_Masterlist rpt = new Supplier_Masterlist();


                    SupplierID supprpt = new SupplierID();
                    supprpt.SetDataSource(datatable);

                    rpt.AssignSuppReport(supprpt);
                    rpt.Show();
                }
            }

            else if (Suppnmebtn.Checked == true)
            {
                if ((SupNameFrmtxt.Text != "" && SupNameUptxt.Text == "") || (SupNameFrmtxt.Text == "" && SupNameUptxt.Text != "") || (SupNameFrmtxt.Text == "" && SupNameUptxt.Text == ""))
                {
                    MessageBox.Show("Enter name first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                string a = Convert.ToString(SupNameFrmtxt.Text);
                string b = Convert.ToString(SupNameUptxt.Text);

                BalloonKingdomDataSetTableAdapters.SupplierTableAdapter sup = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.SupplierTableAdapter();
                DataTable datatable = sup.Supnme(a, b);

                Supplier_Masterlist rpt = new Supplier_Masterlist();


                SupplierName supprpt2 = new SupplierName();
                supprpt2.SetDataSource(datatable);

                rpt.AssignSuppname(supprpt2);
                rpt.Show();
            }

            else
            {
                BalloonKingdomDataSetTableAdapters.SupplierTableAdapter supp2 = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.SupplierTableAdapter();
                DataTable datatable = supp2.ViewAllSupplier();



                Supplier_Masterlist rpt = new Supplier_Masterlist();


                SupplierID supprpt = new SupplierID();
                supprpt.SetDataSource(datatable);

                rpt.AssignSuppReport(supprpt);
                rpt.Show();

            
            }

           
        }

        private void SuppIDbtn_CheckedChanged(object sender, EventArgs e)
        {
            SupNameFrmtxt.Text = "";
            SupNameUptxt.Text = "";
            SupNameFrmtxt.Enabled = false;
            SupNameUptxt.Enabled = false;

            SupIDFrmtxt.Enabled = true;
            SupIDUptxt.Enabled = true;

        }

        private void Suppnmebtn_CheckedChanged(object sender, EventArgs e)
        {
            SupIDFrmtxt.Text = "";
            SupIDUptxt.Text = "";
            SupIDUptxt.Enabled = false;
            SupIDFrmtxt.Enabled = false;
            SupNameFrmtxt.Enabled = true;
            SupNameUptxt.Enabled = true;

        }

        private void SupIDFrmtxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (SupIDFrmtxt.Text != " ")
            {
                str = SupIDFrmtxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((SupIDFrmtxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", SupIDFrmtxt);
                    SupIDFrmtxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", SupIDFrmtxt);
                    SupIDFrmtxt.Clear();
                }
                toolTip1.Hide(SupIDFrmtxt);

            }
        }

        private void SupIDUptxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (SupIDUptxt.Text != " ")
            {
                str = SupIDUptxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((SupIDFrmtxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", SupIDUptxt);
                    SupIDUptxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", SupIDUptxt);
                    SupIDUptxt.Clear();
                }
                toolTip1.Hide(SupIDUptxt);

            }
        }

        private void SupNameFrmtxt_TextChanged(object sender, EventArgs e)
        {

            try
            {
                int x = 0;
                string txt;
                if (SupNameFrmtxt.Text != "")
                {
                    txt = SupNameFrmtxt.Text;
                    x = txt.Length - 1;

                    if (SupNameFrmtxt.Text == "")
                    {
                        toolTip1.Show("Avoid special characters!", SupNameFrmtxt);
                        SupNameFrmtxt.Clear();
                        toolTip1.Hide(SupNameFrmtxt);
                    }

                    else if (char.IsWhiteSpace(txt[x]))
                    {
                        SupNameFrmtxt.Text = txt.Replace(txt[x], ' ');
                        toolTip1.Show("Avoid special characters!", SupNameFrmtxt);
                        toolTip1.Hide(SupNameFrmtxt);
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString(), "error");
            }

        }

        private void SupNameUptxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                string txt;
                if (SupNameUptxt.Text != "")
                {
                    txt = SupNameUptxt.Text;
                    x = txt.Length - 1;

                    if (SupNameUptxt.Text == "")
                    {
                        toolTip1.Show("Avoid special characters!", SupNameUptxt);
                        SupNameUptxt.Clear();
                        toolTip1.Hide(SupNameUptxt);
                    }

                    else if (char.IsWhiteSpace(txt[x]))
                    {
                        SupNameUptxt.Text = txt.Replace(txt[x], ' ');
                        toolTip1.Show("Avoid special characters!", SupNameUptxt);
                        toolTip1.Hide(SupNameUptxt);
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString(), "error");
            }
        }

        private void SupNameFrmtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz-'`.".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void SupNameUptxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz-'`.".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void Supviewalrbtn_CheckedChanged(object sender, EventArgs e)
        {
            SupIDFrmtxt.Text = "";
            SupIDUptxt.Text = "";
            SupNameFrmtxt.Text = "";
            SupNameUptxt.Text = "";
            SupIDUptxt.Enabled = false;
            SupIDFrmtxt.Enabled = false;
            SupNameFrmtxt.Enabled = false;
            SupNameUptxt.Enabled = false;
        }

       

       
    }
}