using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class InvFrmUpdate : Form
    {

        string password;
        int catans;
        string ItemCatCombo;
        string SubCatCombo;
        string SpecCatCombo;
        string AdItemNametxt; 
        string AdType;
        string AdSizeStand;
        string InvUnitcombo;
        string AdColorExist;
        string AdCusWidtxt;
        string AdInvHeighttxt;
        string AdSuppExist;
        string InvItemIDtxt;

        public InvFrmUpdate(string pass1,int catans1, string ItemCatCombo1,string SubCatCombo1,string SpecCatCombo1, string AdItemNametxt1, string AdType1, string AdSizeStand1, string InvUnitcombo1, string AdColorExist1, string AdCusWidtxt1, string AdInvHeighttxt1, string AdSuppExist1, string InvItemIDtxt1)
        {
            InitializeComponent();
            password = pass1;
            catans = catans1;
            ItemCatCombo = ItemCatCombo1;
            SubCatCombo = SubCatCombo1;
            SpecCatCombo = SpecCatCombo1;
            AdItemNametxt = AdItemNametxt1;
            AdType = AdType1;
            AdSizeStand = AdSizeStand1;
            InvUnitcombo = InvUnitcombo1;
            AdColorExist = AdColorExist1;
            AdCusWidtxt = AdCusWidtxt1;
            AdInvHeighttxt = AdInvHeighttxt1;
            AdSuppExist = AdSuppExist1;
            InvItemIDtxt = InvItemIDtxt1;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (passtxt.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up the password field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passtxt.Focus();
                passtxt.Text = "";
            
            }
            else if (passtxt.Text.Trim() != password)
            {
                MessageBox.Show("Invalid System Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passtxt.Text = "";
                passtxt.Focus();
            }
            else
            {
                if (catans != 1)
                {

                    BalloonKingdomDataSetTableAdapters.CategoryTableAdapter addNewCat = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CategoryTableAdapter();
                    addNewCat.AddNewCategory(ItemCatCombo, SubCatCombo, SpecCatCombo);
                }
                BalloonKingdomDataSetTableAdapters.InventoryTableAdapter updateInv = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                updateInv.UpdateInventoryRecord(ItemCatCombo, SubCatCombo, SpecCatCombo, AdItemNametxt, AdType, AdSizeStand, InvUnitcombo, AdColorExist, Convert.ToDecimal(AdCusWidtxt), Convert.ToDecimal(AdInvHeighttxt), AdSuppExist,Convert.ToInt32(InvItemIDtxt),Convert.ToInt32(InvItemIDtxt));
                BalloonKingdomDataSetTableAdapters.ItemTableAdapter updateItem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.ItemTableAdapter();
                updateItem.UpdateCartItems(ItemCatCombo, SubCatCombo, SpecCatCombo, AdItemNametxt, AdSuppExist, Convert.ToDecimal(AdCusWidtxt), Convert.ToDecimal(AdInvHeighttxt), AdSizeStand, AdColorExist, AdType, InvUnitcombo, Convert.ToInt32(InvItemIDtxt));

                MessageBox.Show("Record has been successfully updated.", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Failed to update inventoty!", "Transaction Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            this.Close();
        }

        private void InvFrmUpdate_Load(object sender, EventArgs e)
        {

        }

       
    }
}