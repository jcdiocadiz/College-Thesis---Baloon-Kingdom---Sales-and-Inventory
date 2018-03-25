using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class InvAddFrm : Form
    {
        int iid, iqty, istock;
        string icat, isub, ispec, iname, itype, isize, iunit, istatus, icolor, isup, password;
        double iunitprice, isellingprice, iwidth, iheight;


        public InvAddFrm(int id, string itemcatcombo, string SubCatCombo, string spec, string AdItemName, string AdType, string AdSizeStand, int Qty,  string InvUnitcombo, double AdUnitPrice, double Selling, string status, string AdColorExist, double InvWidth, double InvHeight, string AdSuppExist, string pass)
        {
            InitializeComponent();
            iid = id;
            password = pass;
            IDtxt.Text = Convert.ToString(id);
            ItemNmetxt.Text = AdItemName;
            qtytxt.Text = Convert.ToString(Qty);
            icat = itemcatcombo;
            isub = SubCatCombo;
            ispec = spec;
            iname = AdItemName;
            itype = AdType;
            isize = AdSizeStand;
            iqty = Qty;
            istock = Qty;
            iunit = InvUnitcombo;
            istatus = status;
            icolor = AdColorExist;
            isup = AdSuppExist;
            iunitprice = AdUnitPrice;
            isellingprice = Selling;
            iwidth = InvWidth;
            iheight = InvHeight;
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            if (donebytxt.Text.Trim() == "" || reasontxt.Text.Trim()=="")
            {
                MessageBox.Show("Cannot process this transaction. Please write fill up the given field.", "Transaction Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SyspassTxt.Text = "";
             }

            else if (SyspassTxt.Text != password)
            {
                MessageBox.Show("Cannot process this transaction. Make sure that your password is correct!.", "Transaction Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SyspassTxt.Text = "";
            SyspassTxt.Focus();
            }
            else
            {

                BalloonKingdomDataSetTableAdapters.Inventory_TransactionsTableAdapter addDupItem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Inventory_TransactionsTableAdapter();
                addDupItem.AddnewInventoryTrans(Convert.ToInt32(IDtxt.Text), ItemNmetxt.Text, "Adding", Convert.ToInt32(qtytxt.Text), DateTime.Now, donebytxt.Text.Trim(), reasontxt.Text.Trim());
               
            BalloonKingdomDataSetTableAdapters.InventoryTableAdapter addnewitem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
            addnewitem.AddNewInventoryRec(iid, icat, isub, ispec, iname, itype, isize, iqty, iunit, Convert.ToDecimal(iunitprice), Convert.ToDecimal(isellingprice), Convert.ToDecimal(istock), istatus, icolor, Convert.ToDecimal(iwidth), Convert.ToDecimal(iheight),isup);
            MessageBox.Show("New Item has been added!", "Inventory Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Failed to add item to inventory!", "Transaction Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();

        }

        private void InvAddFrm_Load(object sender, EventArgs e)
        {

        }
    }
}