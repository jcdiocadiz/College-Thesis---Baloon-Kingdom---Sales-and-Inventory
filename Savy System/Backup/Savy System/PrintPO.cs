using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class PrintPO : Form
    {
        public PrintPO()
        {
            InitializeComponent();
        }

        private void PrintPOFtxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (PrintPOFtxt.Text != " ")
            {
                str = PrintPOFtxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((PrintPOFtxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", PrintPOFtxt);
                    PrintPOFtxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", PrintPOFtxt);
                    PrintPOFtxt.Clear();
                }
                toolTip1.Hide(PrintPOFtxt);

            }

        }

        private void PrintCancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void POPrintbtn_Click(object sender, EventArgs e)
        {
            int pof = Convert.ToInt32(PrintPOFtxt.Text);
            POF_Printing poff = new POF_Printing(pof);
            poff.ShowDialog();
        }
    }
}