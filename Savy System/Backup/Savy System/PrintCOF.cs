using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class PrintCOF : Form
    {
        public PrintCOF()
        {
            InitializeComponent();
        }

        private void PrintCOFtxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (PrintCOFtxt.Text != " ")
            {
                str = PrintCOFtxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((PrintCOFtxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", PrintCOFtxt);
                    PrintCOFtxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", PrintCOFtxt);
                    PrintCOFtxt.Clear();
                }
                toolTip1.Hide(PrintCOFtxt);

            }
        }

        private void PrintCancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefundViewbtn_Click(object sender, EventArgs e)
        {
            string co = Convert.ToString(PrintCOFtxt.Text.Trim());

            COF_Printing coff = new COF_Printing(co);
            coff.ShowDialog();
        }

        private void PrintCOF_Load(object sender, EventArgs e)
        {

        }
    }
}