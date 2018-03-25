using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class AccountsPayable : Form
    {
        public AccountsPayable()
        {
            InitializeComponent();
        }

        private void PayableCancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void PayableViewbtn_Click(object sender, EventArgs e)
        {
            

               
                        
                        BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter puro = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter();
                        DataTable datatable = puro.POBeginEndDate(Convert.ToDateTime(AccountPDate1.Value), Convert.ToDateTime(AccountPDay2.Value));

                       


                       AccountPay rpt = new AccountPay();

                        AccountPaya account2 = new AccountPaya();
                        account2.SetDataSource(datatable);
                        rpt.Paya(account2);
                       
                        rpt.Show();

                    
            
            
        }

       
    }
}