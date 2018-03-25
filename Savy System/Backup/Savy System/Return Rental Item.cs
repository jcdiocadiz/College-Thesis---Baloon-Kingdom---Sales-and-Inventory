using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Return_Rental_Item : Form
    {
        public Return_Rental_Item()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    int x = 0;
                    string txt;
                    if (textBox1.Text != "")
                    {
                        txt = textBox1.Text;
                        x = txt.Length - 1;

                        if (textBox1.Text == "")
                        {
                            toolTip1.Show("Avoid special characters!", textBox1);
                            textBox1.Clear();
                            toolTip1.Hide(textBox1);
                        }

                        else if (char.IsWhiteSpace(txt[x]))
                        {
                            textBox1.Text = txt.Replace(txt[x], ' ');
                            toolTip1.Show("Avoid special characters!", textBox1);
                            toolTip1.Hide(textBox1);
                        }
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "error");
                }
        }

    }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
             if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz -'`".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                try
                {
                    int x = 0;
                    string txt;
                    if (textBox2.Text != "")
                    {
                        txt = textBox2.Text;
                        x = txt.Length - 1;

                        if (textBox2.Text == "")
                        {
                            toolTip1.Show("Avoid special characters!", textBox2);
                            textBox2.Clear();
                            toolTip1.Hide(textBox2);
                        }

                        else if (char.IsWhiteSpace(txt[x]))
                        {
                            textBox2.Text = txt.Replace(txt[x], ' ');
                            toolTip1.Show("Avoid special characters!", textBox2);
                            toolTip1.Hide(textBox2);
                        }
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "error");
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
             if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz -'`".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void RentReturnQtytxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (RentReturnQtytxt.Text != " ")
            {
                str = RentReturnQtytxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((RentReturnQtytxt.Text == " "))
                {
                    toolTip2.Show("Enter a number!", RentReturnQtytxt);
                    RentReturnQtytxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip2.Show("Enter a number!", RentReturnQtytxt);
                    RentReturnQtytxt.Clear();
                }
                toolTip2.Hide(RentReturnQtytxt);

            }

        }

        private void Return_Rental_Item_Load(object sender, EventArgs e)
        {

        }
}
}