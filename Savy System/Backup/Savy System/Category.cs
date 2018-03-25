using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
namespace WindowsApplication1
{
    public partial class Category : Form
    {
        static string str_conn = @"data source=JC-PC\SQLEXPRESS;initial catalog=BKDatabase; Integrated Security=True";

        private SqlConnection conn;
        private SqlDataReader dr;
        private SqlCommand cmd;
        int catans = 0;
        string pass;


        public Category(string sypass)
        {
            InitializeComponent();
            pass = sypass;
        }

        private void Category_Load(object sender, EventArgs e)
        {
            try
            {

                conn = new SqlConnection();
                conn.ConnectionString = str_conn;
                conn.Open();
                if (conn.State != ConnectionState.Open)
                    MessageBox.Show("Unable to connect to database", "Connection Status");
            }
            catch (Exception x)
            { MessageBox.Show(x.GetBaseException().ToString(), "Connection status"); }



            cmd = new SqlCommand("select distinct [Category Name]  from Category", conn);
            dr = cmd.ExecuteReader();
            string catvalue;
            int i = 0;
            while (dr.Read())
            {
                catvalue = dr["Category Name"].ToString();
                ItemCatCombo.Items.Add(catvalue);
                CatNameCombo1.Items.Add(catvalue);
                if (i == 0)
                {
                    ItemCatCombo.Text = dr["Category Name"].ToString();
                    CatNameCombo1.Text = dr["Category Name"].ToString();
                }
                i++;
            }
            dr.Close();
        }

        private void ItemCatCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (dr.IsClosed == true)
            {
                SqlCommand cmd12 = new SqlCommand("select distinct [Sub Category]  from Category where [Category name]=" + "'" + ItemCatCombo.Text + "'", conn);
                SqlDataReader dr13 = cmd12.ExecuteReader();

                string[] subcat = new string[900000];
                int i = 0;

                while (dr13.Read())
                {
                    subcat[i] = dr13["Sub Category"].ToString();


                    i++;


                }

                dr13.Close();
                SubCatCombo.Items.Clear();
                SubCatCombo.Text = subcat[0];

                for (int a = 0; a < i; a++)
                {
                    if (subcat[a] != "")
                    {
                        SubCatCombo.Items.Add(subcat[a]);
                        SubCatCombo.Text = subcat[0];

                    }
                }
            }
        }

        private void SubCatCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpecCatCombo.Items.Clear();
            SqlCommand cmd17 = new SqlCommand("select distinct [Specific Category]  from Category where [Sub Category]=" + "'" + SubCatCombo.Text + "'" + "AND [Category Name]=" + "'" + ItemCatCombo.Text+ "'", conn);
           SqlDataReader dr17 = cmd17.ExecuteReader();
            string[] catvalue = new string[999999];
            int i = 0;
            while (dr17.Read())
            {
                catvalue[i] = dr17["Specific Category"].ToString();
             
                i++;
            }
            dr17.Close();
            for (int a = 0; a < i; a++)
            {
                SpecCatCombo.Text = catvalue[0];
                if (catvalue[a] != "")
                    SpecCatCombo.Items.Add(catvalue[a]);


            }
            SpecCatCombo.Text = catvalue[0];
        }

        private void Clrbtn_Click(object sender, EventArgs e)
        {
            SubCatCombo.Text = "";
            SpecCatCombo.Text = "";
            FROMGrpBox.Text = "";
            ItemCatCombo.Text = "";
            CatNameCombo1.Text = "";
            SubComboBox.Text = "";
            SpecificCatTxt.Text = "";
            TOGrpBox.Enabled = false;
            FROMGrpBox.Enabled = false;
            UpdateBtn.Enabled = true;
            AddBtn.Enabled = true;
            TOGrpBox.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            headerLbl.Text = "Adding Category";
            FROMGrpBox.Enabled = true;
            FROMGrpBox.Text = "Adding New Category";
            catans = 1;
            SubCatCombo.DropDownStyle = ComboBoxStyle.DropDown;
            SpecCatCombo.DropDownStyle = ComboBoxStyle.DropDown;
            AddBtn.Enabled = false;
            UpdateBtn.Enabled = false;
            btnSave.Enabled = true;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            headerLbl.Text = "Updating Category";
            FROMGrpBox.Enabled = true;
            FROMGrpBox.Text = "FROM";
            TOGrpBox.Enabled = true;
            TOGrpBox.Text = "TO";
            catans = 2;
            SubCatCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            SpecCatCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdateBtn.Enabled = false;
            AddBtn.Enabled = false;
            btnSave.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passtxt.Text!=pass)
            {
                MessageBox.Show("Wrong System Password.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passtxt.Text = "";
                passtxt.Focus();
            }
            else
            {

                passtxt.Text = "";
                passtxt.Focus();
            if (catans == 1)
            {

                int match = 0;
                SqlCommand cmdmat = new SqlCommand("Select * from Category", conn);
                SqlDataReader drmat = cmdmat.ExecuteReader();
                while (drmat.Read())
                {
                    if (ItemCatCombo.Text == drmat["Category Name"].ToString() && SubCatCombo.Text == drmat["Sub Category"].ToString() && SpecCatCombo.Text == drmat["Specific Category"].ToString())
                        match = 1;

                }
                drmat.Close();

                if (match == 1)
                {
                    MessageBox.Show("This category is already existing. Please try to add another one.", "Already Existing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (ItemCatCombo.Text == "" && SubCatCombo.Text == "")
                    {
                        MessageBox.Show("Please fill up the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        string specad;
                        if (SpecCatCombo.Text == "")
                            specad = "None";
                        else
                            specad = SpecCatCombo.Text.Trim();
                        if (SubCatCombo.Text.Trim() != "")
                        {
                            BalloonKingdomDataSetTableAdapters.CategoryTableAdapter addcat = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CategoryTableAdapter();
                            addcat.AddNewCategory(ItemCatCombo.Text.Trim(), SubCatCombo.Text.Trim(), specad);
                            MessageBox.Show("New Category has been added", "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SubCatCombo.Text = "";
                            SpecCatCombo.Text = "";
                            FROMGrpBox.Text = "";
                            ItemCatCombo.Text = "";
                            CatNameCombo1.Text = "";
                            SubComboBox.Text = "";
                            SpecificCatTxt.Text = "";
                            TOGrpBox.Enabled = false;
                            FROMGrpBox.Enabled = false;
                            TOGrpBox.Text = "";
                            UpdateBtn.Enabled = true;
                            AddBtn.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Please fill required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                        
                        }
                    }
                }

            }
                //for update
                else
                {

                    if (CatNameCombo1.Text.Trim() != "" && SubComboBox.Text.Trim() != "" && SpecificCatTxt.Text.Trim() != "" && SubCatCombo.Text.Trim() != "" && SpecCatCombo.Text.Trim() != "" && ItemCatCombo.Text != "" && CatNameCombo1.Text!="")
                    {

                        SqlCommand cmdup = new SqlCommand("Update Category set [Category Name]=" + "'" + CatNameCombo1.Text + "'" + "," + "[Sub Category]=" + "'" + SubComboBox.Text.Trim() + "'" + "," + "[Specific Category]=" + "'" + SpecificCatTxt.Text.Trim() + "'" + "where [Category Name]=" + "'" + ItemCatCombo.Text + "'" + "AND [Sub Category]=" + "'" + SubCatCombo.Text + "'" + "AND [Specific Category]=" + "'" + SpecCatCombo.Text + "'", conn);
                        cmdup.ExecuteNonQuery();
                        MessageBox.Show("Category has been successfully updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //update inventoty item category
                        SqlCommand cmdinvup = new SqlCommand("Update Inventory set [Category Name]=" + "'" + CatNameCombo1.Text + "'" + "," + "[Sub Category]=" + "'" + SubComboBox.Text.Trim() + "'" + "," + "[Specific Category]=" + "'" + SpecificCatTxt.Text.Trim() + "'" + "where [Category Name]=" + "'" + ItemCatCombo.Text + "'" + "AND [Sub Category]=" + "'" + SubCatCombo.Text + "'" + "AND [Specific Category]=" + "'" + SpecCatCombo.Text + "'", conn);
                        cmdinvup.ExecuteNonQuery();
                        SubComboBox.Text = "";
                        SpecificCatTxt.Text = "";
                        CatNameCombo1.Text = "";
                        UpdateBtn.Enabled = true;
                        AddBtn.Enabled = true;
                        SubCatCombo.Text = "";
                        SpecCatCombo.Text = "";
                        FROMGrpBox.Text = "";
                        ItemCatCombo.Text = "";
                        CatNameCombo1.Text = "";
                        SubComboBox.Text = "";
                        SpecificCatTxt.Text = "";
                        TOGrpBox.Enabled = false;
                        FROMGrpBox.Enabled = false;
                        UpdateBtn.Enabled = true;
                        AddBtn.Enabled = true;
                        TOGrpBox.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Please fill required fields.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                    }
            
            }
            
            }
        }

        private void CatNameCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (dr.IsClosed == true)
            {
                SqlCommand cmdsub= new SqlCommand("select distinct [Sub Category]  from Category where [Category name]=" + "'" + ItemCatCombo.Text + "'", conn);
                SqlDataReader drsub = cmdsub.ExecuteReader();

                string[] subcat = new string[900000];
                int i = 0;

                while (drsub.Read())
                {
                    subcat[i] = drsub["Sub Category"].ToString();


                    i++;


                }

                drsub.Close();
                SubComboBox.Items.Clear();
                SubComboBox.Text = subcat[0];

                for (int a = 0; a < i; a++)
                {
                    if (subcat[a] != "")
                    {
                        SubComboBox.Items.Add(subcat[a]);
                        SubComboBox.Text = subcat[0];

                    }
                }
            }
        }

        private void SubComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpecificCatTxt.Items.Clear();
            SqlCommand cmdsp = new SqlCommand("select distinct [Specific Category]  from Category where [Sub Category]=" + "'" + SubCatCombo.Text + "'" + "AND [Category Name]=" + "'" + CatNameCombo1.Text + "'", conn);
            SqlDataReader drsp = cmdsp.ExecuteReader();
            string[] catvalue = new string[999999];
            int i = 0;
            while (drsp.Read())
            {
                catvalue[i] = drsp["Specific Category"].ToString();

                i++;
            }
            drsp.Close();
            for (int a = 0; a < i; a++)
            {
                SpecificCatTxt.Text = catvalue[0];
                if (catvalue[a] != "")
                    SpecificCatTxt.Items.Add(catvalue[a]);


            }
            SpecificCatTxt.Text = catvalue[0];
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}