using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class AccountsReceivable : Form
    {
        public AccountsReceivable()
        {
            InitializeComponent();
        }

      

        private void SalesViewbtn_Click(object sender, EventArgs e)
        {
          

                            
                                BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter acct = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                                DataTable datatable = acct.Account(Convert.ToDateTime(AccountRcvD1.Value), Convert.ToDateTime(AccountRcvD2.Value));


                                AccountReceive rpt = new AccountReceive();

                                AccountRcv account = new AccountRcv();
                                account.SetDataSource(datatable);

                                rpt.Acc(account);
                                rpt.Show();
                            
                        
            
            
            
        }

        private void SalesCancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      



        
    }
}