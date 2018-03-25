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

    public partial class PODeliverPic : Form
    {
        static string str_conn = @"data source=.\SQLEXPRESS;initial catalog=BKDatabase; Integrated Security=True";

        private SqlConnection conn;
        private SqlDataReader dr;
        private SqlCommand cmd;
        private SqlCommand cmd12;
        private SqlDataReader dr13;

        private SqlCommand cmd17;
        private SqlDataReader dr17;
        //variables of customer
        //  String id, name, first, mid, last, add, email, cp, hn;
        int accust = 1;
        //Choose whether you will save or update in customer
        int custAnswer = 0, suppAnswer = 0, InvAnswer = 0;
        //inventory variables
        double InvWidth = 0, InvHeight = 0;
        //ordering variable
        int custOrdering = 0;

        string fn, mi, ln;
        int b = 0, bg = 0, order = 0, rent = 0, totqty = 0;
        int totalitem = 0,  itemNum = 0, invitemnum = 0, Itembo = 0;
        int payans = 0;
        double totamt = 0;
        double stockorder; int orqty;
        BalloonKingdomDataSetTableAdapters.InventoryTableAdapter getAllInvData = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
        //Security variables
        string username;
        //ordering variables
        int POFID = 0;
        //returned items variable
        double itemlost = 0;
        string returnid = "No";
        //purchasing
        int undersup = 0;
        string syspass;

        public PODeliverPic(string passwrd)
        {
            InitializeComponent();
            syspass = passwrd;

        }
protected override CreateParams CreateParams  
               {            get                
               { CreateParams parms = base.CreateParams;  
                   parms.ClassStyle |= 0x200;  // CS_NOCLOSE   
                   return parms;               
               }            
               }


        private void Savy_System_Load(object sender, EventArgs e)
        {

               
            // TODO: This line of code loads data into the 'balloonKingdomDataSet3.Purchase' table. You can move, or remove it, as needed.
            this.purchaseTableAdapter.Fill(this.balloonKingdomDataSet3.Purchase);
            // TODO: This line of code loads data into the 'balloonKingdomDataSet3.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.balloonKingdomDataSet3.Customer);
            // TODO: This line of code loads data into the 'balloonKingdomDataSet3.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.balloonKingdomDataSet3.Supplier);
            // TODO: This line of code loads data into the 'balloonKingdomDataSet3.Orderline' table. You can move, or remove it, as needed.
            //this.orderlineTableAdapter.Fill(this.balloonKingdomDataSet3.Orderline);
            //// TODO: This line of code loads data into the 'balloonKingdomDataSet.Orderline' table. You can move, or remove it, as needed.
            //this.orderlineTableAdapter.Fill(this.balloonKingdomDataSet.Orderline);
            //// TODO: This line of code loads data into the 'balloonKingdomDataSet2.Inventory' table. You can move, or remove it, as needed.
            //this.inventoryTableAdapter.Fill(this.balloonKingdomDataSet2.Inventory);
            //// TODO: This line of code loads data into the 'balloonKingdomDataSet2.Inventory' table. You can move, or remove it, as needed.
            //this.inventoryTableAdapter.Fill(this.balloonKingdomDataSet2.Inventory);
            //// TODO: This line of code loads data into the 'balloonKingdomDataSet1.Inventory' table. You can move, or remove it, as needed.
            //this.inventoryTableAdapter.Fill(this.balloonKingdomDataSet.Inventory);
            //// TODO: This line of code loads data into the 'balloonKingdomDataSet.Inventory' table. You can move, or remove it, as needed.
            //this.inventoryTableAdapter.Fill(this.balloonKingdomDataSet.Inventory);
            //// TODO: This line of code loads data into the 'balloonKingdomDataSet.Supplier' table. You can move, or remove it, as needed.
            //this.supplierTableAdapter.Fill(this.balloonKingdomDataSet.Supplier);
            //// TODO: This line of code loads data into the 'balloonKingdomDataSet.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.balloonKingdomDataSet.Customer);
            //// TODO: This line of code loads data into the 'balloonKingdomDataSet.Category' table. You can move, or remove it, as needed.
            //// this.categoryTableAdapter.Fill(this.balloonKingdomDataSet.Category);

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
                if (i == 0)
                {
                    ItemCatCombo.Text = "";
                }
                i++;
            }
            dr.Close();



            SqlCommand cmd2 = new SqlCommand("select Name from Supplier", conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();

            string Supvalue;
            i = 0;
            while (dr2.Read())
            {
                Supvalue = dr2["Name"].ToString();
                AdSuppExist.Items.Add(Supvalue);
                if (i == 0)
                {
                    AdSuppExist.Text = "";
                }
                i++;
            }
            dr2.Close();


            //combo box in orderline
            AdType.Text = "";
            InvUnitcombo.Text = "";
            AdSizeStand.Text = "";

            //display active customer

            BalloonKingdomDataSetTableAdapters.CustomerTableAdapter viewall = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
            SearchCustdataGridView1.DataSource = viewall.ViewAllCustRec();
            BalloonKingdomDataSetTableAdapters.InventoryTableAdapter getAllInvData = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
            InvDataGrid.DataSource = getAllInvData.GetAllInventoryRec();

            BalloonKingdomDataSetTableAdapters.InventoryTableAdapter getData = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
            orderandrentdatagrid.DataSource = getData.GetAllInventoryRec();
            BalloonKingdomDataSetTableAdapters.SupplierTableAdapter viewallsup = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.SupplierTableAdapter();
            SearchSupplierDataGrid.DataSource = viewallsup.ViewAllSupplier();
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            BackgndPanel.Visible = false;
            OrderingPanel.Visible = false;
            CustomerPanel.Visible = true;
            Inventorypanel.Visible = false;
            Orderpanel.Visible = false;
            Supplierpanel.Visible = false;
            SecurityPanel.Visible = false;
            PurchasingPanel.Visible = false;
            ReturnRentPanel.Visible = false;
            customerSearchtxt.Text = "";
            //string[] idcust = new string[6000];
            //int a = 0;
            //SqlCommand getid = new SqlCommand("Select * from Customer", conn);
            //SqlDataReader drid = getid.ExecuteReader();
            //while (drid.Read())
            //{

            //    idcust[a] = drid["Customer ID"].ToString();
            //    a++;

            //}
            //drid.Close();

            //for (int b = 0; b < a; b++)
            //{
            //    int ornum = 0, proc = 0, canc = 0, pend = 0, wait = 0;

            //    SqlCommand getorder = new SqlCommand("Select * from Orderline where [Customer ID]=" + "'" + idcust[b] + "'", conn);
            //    SqlDataReader drgetor = getorder.ExecuteReader();
            //    while (drgetor.Read())
            //    {
            //        if (drgetor["Status"].ToString() == "Pending")
            //            pend++;
            //        else if (drgetor["Status"].ToString() == "Cancelled")
            //            canc++;

            //        else if (drgetor["Status"].ToString() == "Processed")
            //            proc++;
            //        else if (drgetor["Status"].ToString() == "Waiting")
            //            wait++;

            //        ornum++;
            //    }
            //    drgetor.Close();

            //    BalloonKingdomDataSetTableAdapters.CustomerTableAdapter updateor = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
            //    updateor.UpdateCustOrder(ornum, canc, proc, pend, wait, Convert.ToInt32(idcust[b]));
            //}
            //BalloonKingdomDataSetTableAdapters.CustomerTableAdapter view = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
            //SearchCustdataGridView1.DataSource = view.ViewCustomers();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            custdellabel.Visible = true;
            custupdlabel.Visible = true;
            UpdateCustbtn.Visible = true;
            DeleteCustbtn.Visible = true;
            customerSearchtxt.Focus();
        }








        private void searchpick_Click(object sender, EventArgs e)
        {
            deletepick.Visible = true;
            deletelbl.Visible = true;
            updatelbl.Visible = true;
            updatepick.Visible = true;


        }

        private void createpick_Click(object sender, EventArgs e)
        {
            CustomerPanel.Visible = true;
            Orderpanel.Visible = false;
            //deletepick.Visible = false;
            //deletelbl.Visible = false;
            //updatelbl.Visible = false;
            //updatepick.Visible = false;

        }

        private void supplierpic_Click(object sender, EventArgs e)
        {
            OrderingPanel.Visible = false;
            Supplierpanel.Visible = true;
            Orderpanel.Visible = false;
            CustomerPanel.Visible = false;
            Inventorypanel.Visible = false;
            PurchasingPanel.Visible = false;

            BackgndPanel.Visible = false;

            SecurityPanel.Visible = false;
            ReturnRentPanel.Visible = false;
        }










        private void AddCustbtn_Click(object sender, EventArgs e)
        {
            AdCustFname.Focus();
            custAnswer = 1;
            customerSearchtxt.Text = "";
            CustIDtxt.Text = "***Auto-generating ID***";
            AdCustFname.Focus();
            AdCustFname.Text = "";
            AdCustMidtxt.Text = "";
            AdCustLasttxt.Text = "";
            AdCustAddtxt.Text = "";
            AdCustHnumtxt.Text = "";
            AdCustCnumtxt.Text = "";
            AdCustEadtxt.Text = "";

            AdCustFname.Enabled = true;
            AdCustMidtxt.Enabled = true;
            AdCustLasttxt.Enabled = true;
            AdCustAddtxt.Enabled = true;
            AdCustHnumtxt.Enabled = true;
            AdCustCnumtxt.Enabled = true;
            AdCustEadtxt.Enabled = true;








        }

        private void customerSearchtxt_TextChanged(object sender, EventArgs e)
        {
            if (customerSearchtxt.Text != "")
            {


                try
                {
                    int a = Convert.ToInt32(customerSearchtxt.Text.Trim());
                    BalloonKingdomDataSetTableAdapters.CustomerTableAdapter searchCustbyId = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
                    SearchCustdataGridView1.DataSource = searchCustbyId.SearchCustByID(a);

                    AdCustFname.Enabled = false;
                    AdCustMidtxt.Enabled = false;
                    AdCustLasttxt.Enabled = false;
                    AdCustAddtxt.Enabled = false;
                    AdCustHnumtxt.Enabled = false;
                    AdCustCnumtxt.Enabled = false;
                    AdCustEadtxt.Enabled = false;
                    CustSavelbl.Visible = false;
                    custSavebtn.Visible = false;

                }
                catch
                {

                    BalloonKingdomDataSetTableAdapters.CustomerTableAdapter cusadapter = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
                    SearchCustdataGridView1.DataSource = cusadapter.SearchCustByLastAndFirst(customerSearchtxt.Text.Trim(), customerSearchtxt.Text.Trim());

                    AdCustFname.Enabled = false;
                    AdCustMidtxt.Enabled = false;
                    AdCustLasttxt.Enabled = false;
                    AdCustAddtxt.Enabled = false;
                    AdCustHnumtxt.Enabled = false;
                    AdCustCnumtxt.Enabled = false;
                    AdCustEadtxt.Enabled = false;
                    CustSavelbl.Visible = false;
                    custSavebtn.Visible = false;
                }





            }
            else
            {
                BalloonKingdomDataSetTableAdapters.CustomerTableAdapter viewall = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
                SearchCustdataGridView1.DataSource = viewall.ViewAllCustRec();
                CustSavelbl.Visible = false;
                custSavebtn.Visible = false;
                AdCustFname.Enabled = false;
                AdCustMidtxt.Enabled = false;
                AdCustLasttxt.Enabled = false;
                AdCustAddtxt.Enabled = false;
                AdCustHnumtxt.Enabled = false;
                AdCustCnumtxt.Enabled = false;
                AdCustEadtxt.Enabled = false;
                CustIDtxt.Text = "";
                AdCustFname.Text = "";
                AdCustMidtxt.Text = "";
                AdCustLasttxt.Text = "";
                AdCustAddtxt.Text = "";
                AdCustHnumtxt.Text = "";
                AdCustCnumtxt.Text = "";
                AdCustEadtxt.Text = "";
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustClearbtn_Click(object sender, EventArgs e)
        {

            customerSearchtxt.Text = "";
            if (custAnswer != 1)
                CustIDtxt.Text = "";
            AdCustFname.Text = "";
            AdCustMidtxt.Text = "";
            AdCustLasttxt.Text = "";
            AdCustAddtxt.Text = "";
            AdCustHnumtxt.Text = "";
            AdCustCnumtxt.Text = "";
            AdCustEadtxt.Text = "";
            BalloonKingdomDataSetTableAdapters.CustomerTableAdapter viewall = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
            SearchCustdataGridView1.DataSource = viewall.ViewAllCustRec();
        }

        private void custSavebtn_Click(object sender, EventArgs e)
        {
            String id;
            int a = 0, id2;

            if (custAnswer == 1)
            {

                try
                {

                    if ((AdCustHnumtxt.Text != "" && AdCustHnumtxt.TextLength > 9) || (AdCustHnumtxt.TextLength < 7 && AdCustHnumtxt.Text != ""))
                    {
                        MessageBox.Show("Contact number must be at least 9 or 7 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdSuppnumtxt.Focus();
                        return;
                    }


                    if ((AdCustCnumtxt.Text != "" && AdCustCnumtxt.TextLength < 11) || (AdCustCnumtxt.TextLength > 11 && AdCustCnumtxt.Text != ""))
                    {
                        MessageBox.Show("Contact number must be at least 11(Mobile) characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdSuppnumtxt.Focus();
                        return;
                    }

                    else
                    {
                        SqlCommand cmd3 = new SqlCommand("Select * from Customer", conn);
                        SqlDataReader dr4 = cmd3.ExecuteReader();
                        while (dr4.Read())
                        {
                            id = dr4["Customer ID"].ToString();
                            id2 = Convert.ToInt32(id);
                            if (a < id2)
                                a = id2;


                        }
                        dr4.Close();
                        a++;


                        BalloonKingdomDataSetTableAdapters.CustomerTableAdapter addnewcust = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
                        addnewcust.AddNewCustomer(a, AdCustLasttxt.Text.Trim(), AdCustMidtxt.Text.Trim(), AdCustFname.Text.Trim(), AdCustAddtxt.Text.Trim(), AdCustHnumtxt.Text.Trim(), AdCustCnumtxt.Text.Trim(), AdCustEadtxt.Text.Trim());


                        MessageBox.Show("New Customer has been added!", "Customer Account Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CustIDtxt.Text = "";
                        AdCustFname.Text = "";
                        AdCustMidtxt.Text = "";
                        AdCustLasttxt.Text = "";
                        AdCustAddtxt.Text = "";
                        AdCustHnumtxt.Text = "";
                        AdCustCnumtxt.Text = "";
                        AdCustEadtxt.Text = "";
                        custSavebtn.Visible = false;
                        CustSavelbl.Visible = false;
                    }
                }
                catch (Exception x)
                {

                    MessageBox.Show(x.GetBaseException().ToString(), "connection status");

                }
            }
            else
            {
                if (AdCustAddtxt.Text == "" || AdCustLasttxt.Text == "" || AdCustFname.Text == "")
                    MessageBox.Show("Please Fill up the Required fields", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                    BalloonKingdomDataSetTableAdapters.CustomerTableAdapter updateCustAccount = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
                    updateCustAccount.UpdateCustomerAcct(AdCustLasttxt.Text.Trim(), AdCustMidtxt.Text.Trim(), AdCustFname.Text.Trim(), AdCustAddtxt.Text.Trim(), AdCustHnumtxt.Text.Trim(), AdCustCnumtxt.Text.Trim(), AdCustEadtxt.Text.Trim(), Convert.ToInt32(CustIDtxt.Text));






                    MessageBox.Show("Record has been successfully updated.", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateCustbtn.Enabled = true;
                    CustIDtxt.Text = "";
                    AdCustFname.Text = "";
                    AdCustMidtxt.Text = "";
                    AdCustLasttxt.Text = "";
                    AdCustAddtxt.Text = "";
                    AdCustHnumtxt.Text = "";
                    AdCustCnumtxt.Text = "";
                    AdCustEadtxt.Text = "";
                    CustSavelbl.Visible = false;
                    custSavebtn.Visible = false;
                    AdCustFname.Enabled = false;
                    AdCustMidtxt.Enabled = false;
                    AdCustLasttxt.Enabled = false;
                    AdCustAddtxt.Enabled = false;
                    AdCustHnumtxt.Enabled = false;
                    AdCustCnumtxt.Enabled = false;
                    AdCustEadtxt.Enabled = false;
                }

            }

            BalloonKingdomDataSetTableAdapters.CustomerTableAdapter viewall = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
            SearchCustdataGridView1.DataSource = viewall.ViewAllCustRec();
            custAnswer = 0;
            CustSavelbl.Visible = false;
            custSavebtn.Visible = false;
            AdCustFname.Enabled = false;
            AdCustMidtxt.Enabled = false;
            AdCustLasttxt.Enabled = false;
            AdCustAddtxt.Enabled = false;
            AdCustHnumtxt.Enabled = false;
            AdCustCnumtxt.Enabled = false;
            AdCustEadtxt.Enabled = false;
            CustIDtxt.Text = "";
            AdCustFname.Text = "";
            AdCustMidtxt.Text = "";
            AdCustLasttxt.Text = "";
            AdCustAddtxt.Text = "";
            AdCustHnumtxt.Text = "";
            AdCustCnumtxt.Text = "";
            AdCustEadtxt.Text = "";

            customerSearchtxt.Text = "";
        }

        private void AdCustFname_TextChanged(object sender, EventArgs e)
        {
            if (AdCustLasttxt.Text != "" && AdCustFname.Text != "" && AdCustAddtxt.Text != "" && CustIDtxt.Text == "***Auto-generating ID***" || custAnswer == 2)
            {
                try
                {
                    int x = 0;
                    string txt;
                    if (AdCustFname.Text != "")
                    {
                        txt = AdCustFname.Text;
                        x = txt.Length - 1;

                        if (AdCustFname.Text == "")
                        {
                            toolTip1.Show("Avoid special characters!", AdCustFname);
                            AdCustFname.Clear();
                            toolTip1.Hide(AdCustFname);
                        }

                        else if (char.IsWhiteSpace(txt[x]))
                        {
                            AdCustFname.Text = txt.Replace(txt[x], ' ');
                            toolTip1.Show("Avoid special characters!", AdCustFname);
                            toolTip1.Hide(AdCustFname);
                        }
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "error");
                }

                custSavebtn.Visible = true;
                CustSavelbl.Visible = true;
            }
            else
            {

                custSavebtn.Visible = false;
                CustSavelbl.Visible = false;

            }
        }

        private void AdCustLasttxt_TextChanged(object sender, EventArgs e)
        {
            if (AdCustLasttxt.Text != "" && AdCustFname.Text != "" && AdCustAddtxt.Text != "" && CustIDtxt.Text == "***Auto-generating ID***" || custAnswer == 2)
            {
                try
                {
                    int x = 0;
                    string txt;
                    if (AdCustLasttxt.Text != "")
                    {
                        txt = AdCustLasttxt.Text;
                        x = txt.Length - 1;

                        if (AdCustLasttxt.Text == "")
                        {
                            toolTip1.Show("Avoid special characters!", AdCustLasttxt);
                            AdCustLasttxt.Clear();
                            toolTip1.Hide(AdCustLasttxt);
                        }

                        else if (char.IsWhiteSpace(txt[x]))
                        {
                            AdCustLasttxt.Text = txt.Replace(txt[x], ' ');
                            toolTip1.Show("Avoid special characters!", AdCustLasttxt);
                            toolTip1.Hide(AdCustLasttxt);
                        }
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "error");
                }

                custSavebtn.Visible = true;
                CustSavelbl.Visible = true;
            }
            else
            {

                custSavebtn.Visible = false;
                CustSavelbl.Visible = false;

            }
        }

        private void AdCustAddtxt_TextChanged(object sender, EventArgs e)
        {
            if (AdCustLasttxt.Text != "" && AdCustFname.Text != "" && AdCustAddtxt.Text != "" && CustIDtxt.Text == "***Auto-generating ID***" || custAnswer == 2)
            {

                try
                {
                    int x = 0;
                    string txt;
                    if (AdCustAddtxt.Text != "")
                    {
                        txt = AdCustAddtxt.Text;
                        x = txt.Length - 1;

                        if (AdCustAddtxt.Text == "")
                        {
                            toolTip1.Show("Avoid special characters!", AdCustAddtxt);
                            AdCustAddtxt.Clear();
                            toolTip1.Hide(AdCustAddtxt);
                        }

                        else if (char.IsWhiteSpace(txt[x]))
                        {
                            AdCustAddtxt.Text = txt.Replace(txt[x], ' ');
                            toolTip1.Show("Avoid special characters!", AdCustAddtxt);
                            toolTip1.Hide(AdCustAddtxt);
                        }
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "error");
                }

                custSavebtn.Visible = true;
                CustSavelbl.Visible = true;

            }

            else
            {

                custSavebtn.Visible = false;
                CustSavelbl.Visible = false;

            }
        }

        private void UpdateCustbtn_Click(object sender, EventArgs e)
        {



            if (AdCustLasttxt.Text != "" && AdCustFname.Text != "" && AdCustAddtxt.Text != "")
            {
                UpdateCustbtn.Enabled = false;
                custSavebtn.Visible = true;
                CustSavelbl.Visible = true;
                custAnswer = 2;
                AdCustFname.Enabled = true;
                AdCustMidtxt.Enabled = true;
                AdCustLasttxt.Enabled = true;
                AdCustAddtxt.Enabled = true;
                AdCustHnumtxt.Enabled = true;
                AdCustCnumtxt.Enabled = true;
                AdCustEadtxt.Enabled = true;
            }
            else
            {
                if (AdCustAddtxt.Text == "" || AdCustLasttxt.Text == "" || AdCustFname.Text == "")
                    MessageBox.Show("Please Choose a customer to update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CustSearchbtn_Click(object sender, EventArgs e)
        {
            BalloonKingdomDataSetTableAdapters.CustomerTableAdapter viewall = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
            SearchCustdataGridView1.DataSource = viewall.ViewAllCustRec();

            CustSavelbl.Visible = false;
            custSavebtn.Visible = false;
            AdCustFname.Enabled = false;
            AdCustMidtxt.Enabled = false;
            AdCustLasttxt.Enabled = false;
            AdCustAddtxt.Enabled = false;
            AdCustHnumtxt.Enabled = false;
            AdCustCnumtxt.Enabled = false;
            AdCustEadtxt.Enabled = false;
            customerSearchtxt.Text = "";
            if (custAnswer != 1)
                CustIDtxt.Text = "";
            AdCustFname.Text = "";
            AdCustMidtxt.Text = "";
            AdCustLasttxt.Text = "";
            AdCustAddtxt.Text = "";
            AdCustHnumtxt.Text = "";
            AdCustCnumtxt.Text = "";
            AdCustEadtxt.Text = "";


        }

        private void DeleteCustbtn_Click(object sender, EventArgs e)
        {
            if (CustIDtxt.Text == "" || CustIDtxt.Text == "***Auto-generating ID***")
            {

                MessageBox.Show("Please Choose customer to deactivate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                CustSavelbl.Visible = false;
                custSavebtn.Visible = false;
                AdCustFname.Enabled = false;
                AdCustMidtxt.Enabled = false;
                AdCustLasttxt.Enabled = false;
                AdCustAddtxt.Enabled = false;
                AdCustHnumtxt.Enabled = false;
                AdCustCnumtxt.Enabled = false;
                AdCustEadtxt.Enabled = false;
                customerSearchtxt.Text = "";
                if (custAnswer != 1)
                    CustIDtxt.Text = "";
                AdCustFname.Text = "";
                AdCustMidtxt.Text = "";
                AdCustLasttxt.Text = "";
                AdCustAddtxt.Text = "";
                AdCustHnumtxt.Text = "";
                AdCustCnumtxt.Text = "";
                AdCustEadtxt.Text = "";

            }
            else if (SearchCustdataGridView1.SelectedRows[0].Cells[8].Value.ToString()!="Active")
            {

                MessageBox.Show("Cannot deactivate already deactivated customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                CustSavelbl.Visible = false;
                custSavebtn.Visible = false;
                AdCustFname.Enabled = false;
                AdCustMidtxt.Enabled = false;
                AdCustLasttxt.Enabled = false;
                AdCustAddtxt.Enabled = false;
                AdCustHnumtxt.Enabled = false;
                AdCustCnumtxt.Enabled = false;
                AdCustEadtxt.Enabled = false;
                customerSearchtxt.Text = "";
                if (custAnswer != 1)
                    CustIDtxt.Text = "";
                AdCustFname.Text = "";
                AdCustMidtxt.Text = "";
                AdCustLasttxt.Text = "";
                AdCustAddtxt.Text = "";
                AdCustHnumtxt.Text = "";
                AdCustCnumtxt.Text = "";
                AdCustEadtxt.Text = "";


            }
            else
            {
                int ans;
                ans = Convert.ToInt16(MessageBox.Show("Are you sure you want to deactivate this account?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (ans == 6)
                {
                    BalloonKingdomDataSetTableAdapters.CustomerTableAdapter deactivateCustomerAccount = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
                    deactivateCustomerAccount.DeactivateCust("Inactive", Convert.ToInt32(CustIDtxt.Text.Trim()));
                    MessageBox.Show("Customer Account has been Deactivated", "Deactivation Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BalloonKingdomDataSetTableAdapters.CustomerTableAdapter viewall = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
                    SearchCustdataGridView1.DataSource = viewall.ViewAllCustRec();
                }
            }
        }

        private void AddSuppbtn_Click(object sender, EventArgs e)
        {
            suppAnswer = 1;
            searchsuppliertxt.Text = "";
            AdSuppidtxt.Text = "***Auto-generating ID***";
            AdSuppnametxt.Focus();
            AdSuppnametxt.Text = "";
            AdSuppnumtxt.Text = "";
            AdSuppaddtxt.Text = "";
            AdSuppEadtxt.Text = "";

            AdSuppnametxt.Enabled = true;
            AdSuppnumtxt.Enabled = true;
            AdSuppaddtxt.Enabled = true;
            AdSuppEadtxt.Enabled = true;
            SupActLbl.Text = "Adding New Supplier Account.";

        }

        private void clearSuppbtn_Click(object sender, EventArgs e)
        {
            AdSuppidtxt.Text = "";
            AdSuppnametxt.Text = "";
            AdSuppnumtxt.Text = "";
            AdSuppaddtxt.Text = "";
            AdSuppEadtxt.Text = "";
            SupActLbl.Text = "Clicked the Button Clear.";
        }

        private void saveSuppbtn_Click(object sender, EventArgs e)
        {
            String id;
            int a = 0, id2, i = 0;




            if (suppAnswer == 1)
            {





                try
                {

                    
                        if (AdSuppnumtxt.TextLength > 11 || AdSuppnumtxt.TextLength < 9)
                        {
                            MessageBox.Show("Contact number must be at least 11(Mobile) or 9(Telephone) characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            AdSuppnumtxt.Focus();
                            return;
                        }

                    
                    else
                    {



                        int match = 0;
                        SqlCommand cmd5 = new SqlCommand("Select * from Supplier", conn);
                        SqlDataReader dr8 = cmd5.ExecuteReader();
                        while (dr8.Read())
                        {
                            id = dr8["Supplier ID"].ToString();
                            id2 = Convert.ToInt32(id);
                            if (a < id2)
                                a = id2;

                            if (AdSuppnametxt.Text == dr8["Name"].ToString())
                                match = 1;


                        }
                        dr8.Close();
                        a++;
                        if (match == 1)
                        {
                            MessageBox.Show("Cannot continue. This supplier is already been added.", "Already Taken!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            AdSuppnametxt.Text = "";
                            AdSuppnumtxt.Text = "";
                            AdSuppaddtxt.Text = "";
                            AdSuppEadtxt.Text = "";

                        }
                        else
                        {
                            BalloonKingdomDataSetTableAdapters.SupplierTableAdapter addnewsupp = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.SupplierTableAdapter();
                            addnewsupp.AddNewSupplier(a, AdSuppnametxt.Text.Trim(), AdSuppaddtxt.Text.Trim(), AdSuppnumtxt.Text.Trim(), AdSuppEadtxt.Text.Trim());


                            MessageBox.Show("New Supplier has been added!", "Supplier Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SupActLbl.Text = "Successfully Added a Supplier Account.";
                            saveSuppbtn.Visible = false;
                            saveSupplbl.Visible = false;

                            AdSuppidtxt.Text = "";
                            AdSuppnametxt.Text = "";
                            AdSuppnumtxt.Text = "";
                            AdSuppaddtxt.Text = "";
                            AdSuppEadtxt.Text = "";
                            saveSuppbtn.Visible = true;
                            saveSupplbl.Visible = true;
                        }
                    }
                    }
                
                catch (Exception x)
                {

                    MessageBox.Show(x.GetBaseException().ToString(), "connection status");

                }
            }

            else
            {



                BalloonKingdomDataSetTableAdapters.SupplierTableAdapter updateSupplierAcct = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.SupplierTableAdapter();
                updateSupplierAcct.UpdateSupplierAccount(Convert.ToInt32(AdSuppidtxt.Text), AdSuppnametxt.Text.Trim(), AdSuppaddtxt.Text.Trim(), AdSuppnumtxt.Text.Trim(), AdSuppEadtxt.Text.Trim(), Convert.ToInt32(AdSuppidtxt.Text));

                MessageBox.Show("Record has been successfully updated.", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SupActLbl.Text = "Successfully updated a Supplier Account.";

                saveSuppbtn.Visible = false;
                saveSupplbl.Visible = false;
                UpdateSuppbtn.Enabled = true;
                AdSuppidtxt.Text = "";
                AdSuppnametxt.Text = "";
                AdSuppnumtxt.Text = "";
                AdSuppaddtxt.Text = "";
                AdSuppEadtxt.Text = "";

                saveSuppbtn.Visible = true;
                saveSupplbl.Visible = true;
                AdSuppnametxt.Enabled = false;
                AdSuppnumtxt.Enabled = false;
                AdSuppaddtxt.Enabled = false;
                AdSuppEadtxt.Enabled = false;

            }
            AdSuppExist.Items.Clear();
            SqlCommand cmd19 = new SqlCommand("select Name from Supplier", conn);
            SqlDataReader dr19 = cmd19.ExecuteReader();
            string Supvalue;
            i = 0;
            while (dr19.Read())
            {
                Supvalue = dr19["Name"].ToString();
                AdSuppExist.Items.Add(Supvalue);
                if (i == 0)
                {
                    AdSuppExist.Text = dr19["Name"].ToString();
                }
                i++;
            }
            dr19.Close();


            BalloonKingdomDataSetTableAdapters.SupplierTableAdapter viewall = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.SupplierTableAdapter();
            SearchSupplierDataGrid.DataSource = viewall.ViewAllSupplier();
            suppAnswer = 0;
            saveSuppbtn.Visible = false;
            saveSupplbl.Visible = false;
            AdSuppnametxt.Enabled = false;
            AdSuppnumtxt.Enabled = false;
            AdSuppaddtxt.Enabled = false;
            AdSuppEadtxt.Enabled = false;
            AdSuppidtxt.Text = "";
            AdSuppnametxt.Text = "";
            AdSuppnumtxt.Text = "";
            AdSuppaddtxt.Text = "";
            AdSuppEadtxt.Text = "";

            searchsuppliertxt.Text = "";

        }

        private void searchSuppbtn_Click(object sender, EventArgs e)
        {
            BalloonKingdomDataSetTableAdapters.SupplierTableAdapter viewall = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.SupplierTableAdapter();
            SearchSupplierDataGrid.DataSource = viewall.ViewAllSupplier();
            suppAnswer = 0;
            saveSuppbtn.Visible = false;
            saveSupplbl.Visible = false;
            AdSuppnametxt.Enabled = false;
            AdSuppnumtxt.Enabled = false;
            AdSuppaddtxt.Enabled = false;
            AdSuppEadtxt.Enabled = false;
            AdSuppidtxt.Text = "";
            AdSuppnametxt.Text = "";
            AdSuppnumtxt.Text = "";
            AdSuppaddtxt.Text = "";
            AdSuppEadtxt.Text = "";

            searchsuppliertxt.Text = "";
            SupActLbl.Text = "Viewing All Records";
        }

        private void searchsuppliertxt_TextChanged(object sender, EventArgs e)
        {
            if (searchsuppliertxt.Text.Trim() != "")
            {
                try
                {
                    int sersup = Convert.ToInt32(searchsuppliertxt.Text.Trim());

                    BalloonKingdomDataSetTableAdapters.SupplierTableAdapter searchSupplierbyid = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.SupplierTableAdapter();
                    SearchSupplierDataGrid.DataSource = searchSupplierbyid.GetSupplierByID(sersup);


                }
                catch
                {

                    BalloonKingdomDataSetTableAdapters.SupplierTableAdapter searchSupplier = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.SupplierTableAdapter();
                    SearchSupplierDataGrid.DataSource = searchSupplier.GetSupplierByName(searchsuppliertxt.Text.Trim());
                    SupActLbl.Text = "Searching an account";
                }
            }
            else
            {
                BalloonKingdomDataSetTableAdapters.SupplierTableAdapter viewall = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.SupplierTableAdapter();
                SearchSupplierDataGrid.DataSource = viewall.ViewAllSupplier();

            }

        }

        private void UpdateSuppbtn_Click(object sender, EventArgs e)
        {

            if (AdSuppnametxt.Text != "")
            {
                UpdateSuppbtn.Enabled = false;
                saveSuppbtn.Visible = true;
                saveSupplbl.Visible = true;
                suppAnswer = 2;
                AdSuppnametxt.Enabled = true;
                AdSuppnumtxt.Enabled = true;
                AdSuppaddtxt.Enabled = true;
                AdSuppEadtxt.Enabled = true;
                SupActLbl.Text = "Updating Supplier Account.";
            }
            else
            {
                if (AdSuppnametxt.Text == "")
                    MessageBox.Show("Please Choose a suppier to update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //private void DelSuppbtn_Click(object sender, EventArgs e)
        //{
        //    if (AdSuppidtxt.Text == "" || AdSuppidtxt.Text == "***Auto-generating ID***")
        //    {

        //        MessageBox.Show("Please Choose customer to deactivate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //    }
        //    else
        //    {
        //        int ans;
        //        ans = Convert.ToInt16(MessageBox.Show("Are you sure you want to deactivate this account?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
        //        if (ans == 6)
        //        {
        //            int i = 0;
        //            BalloonKingdomDataSetTableAdapters.SupplierTableAdapter deactivateSupplierAccount = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.SupplierTableAdapter();
        //            deactivateSupplierAccount.DeactivateSupplier("Inactive", Convert.ToInt32(AdSuppidtxt.Text.Trim()), Convert.ToInt32(AdSuppidtxt.Text.Trim()));
        //            MessageBox.Show("Supplier Account has been deactivated", "Deactivate Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            BalloonKingdomDataSetTableAdapters.SupplierTableAdapter viewall = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.SupplierTableAdapter();
        //            SearchSupplierDataGrid.DataSource = viewall.ViewAllSupplier();
        //            SqlCommand cmd29 = new SqlCommand("select Name from Supplier", conn);
        //            SqlDataReader dr29 = cmd29.ExecuteReader();
        //            AdSuppExist.Items.Clear();
        //            string Supvalue;
        //            i = 0;
        //            while (dr29.Read())
        //            {
        //                Supvalue = dr29["Name"].ToString();
        //                AdSuppExist.Items.Add(Supvalue);
        //                if (i == 0)
        //                {
        //                    AdSuppExist.Text = dr29["Name"].ToString();
        //                }
        //                i++;
        //            }
        //            dr29.Close();
        //        }
        //    }
        //}

        private void openInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }



        private void AdSuppnametxt_TextChanged(object sender, EventArgs e)
        {
            if (AdSuppnametxt.Text != "")
            {
                try
                {
                    int x = 0;
                    string txt;
                    if (AdSuppnametxt.Text != "")
                    {
                        txt = AdSuppnametxt.Text;
                        x = txt.Length - 1;

                        if (AdSuppnametxt.Text == "")
                        {
                            toolTip1.Show("Avoid special characters!", AdSuppnametxt);
                            AdSuppnametxt.Clear();
                            toolTip1.Hide(AdSuppnametxt);
                        }

                        else if (char.IsWhiteSpace(txt[x]))
                        {
                            AdSuppnametxt.Text = txt.Replace(txt[x], ' ');
                            toolTip1.Show("Avoid special characters!", AdSuppnametxt);
                            toolTip1.Hide(AdSuppaddtxt);
                        }
                    }

                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "error");
                }

                saveSuppbtn.Visible = true;
                saveSupplbl.Visible = true;
            }


            else
            {
                saveSuppbtn.Visible = false;
                saveSupplbl.Visible = false;
            }


        }

        private void AdSuppnumtxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (AdSuppnumtxt.Text != " ")
            {
                str = AdSuppnumtxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((AdSuppnumtxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", AdSuppnumtxt);
                    AdSuppnumtxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", AdSuppnumtxt);
                    AdSuppnumtxt.Clear();
                }
                toolTip1.Hide(AdSuppnumtxt);

                saveSuppbtn.Visible = true;
                saveSupplbl.Visible = true;

            }



            else
            {
                saveSuppbtn.Visible = false;
                saveSupplbl.Visible = false;
            }

        }


        private void AdSuppaddtxt_TextChanged(object sender, EventArgs e)
        {
            if (AdSuppnametxt.Text != "")
            {
                try
                {
                    int x = 0;
                    string txt;
                    if (AdSuppaddtxt.Text != "")
                    {
                        txt = AdSuppaddtxt.Text;
                        x = txt.Length - 1;

                        if (AdSuppaddtxt.Text == "")
                        {
                            toolTip1.Show("Avoid special characters!", AdSuppaddtxt);
                            AdSuppaddtxt.Clear();
                            toolTip1.Hide(AdSuppaddtxt);
                        }

                        else if (char.IsWhiteSpace(txt[x]))
                        {
                            AdSuppaddtxt.Text = txt.Replace(txt[x], ' ');
                            toolTip1.Show("Avoid special characters!", AdSuppaddtxt);
                            toolTip1.Hide(AdSuppaddtxt);
                        }
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "error");
                }

                saveSuppbtn.Visible = true;
                saveSupplbl.Visible = true;
            }
            else
            {
                saveSuppbtn.Visible = false;
                saveSupplbl.Visible = false;
            }

        }

        private void ItemCatCombo_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (dr.IsClosed == true)
            {
                cmd12 = new SqlCommand("select distinct [Sub Category]  from Category where [Category name]=" + "'" + ItemCatCombo.Text + "'", conn);
                dr13 = cmd12.ExecuteReader();

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
                if (Sellingtxt.Text.Trim() != "" && AdItemNametxt.Text.Trim() != "" && InvAnswer == 0 || InvAnswer == 1 && QtyTxt.Text.Trim() != "" && AdUnitPricetxt.Text.Trim() != "" && ItemCatCombo.Text.Trim() != "" && SubCatCombo.Text.Trim() != "" && AdType.Text.Trim() != "" && AdSuppExist.Text.Trim() != "" && InvUnitcombo.Text.Trim() != "")
                {
                    InvSaveandUpdatebtn.Visible = true;
                    invsavelbl.Visible = true;
                }
                else
                {
                    InvSaveandUpdatebtn.Visible = false;
                    invsavelbl.Visible = false;
                }
            }

        }

        private void SubCatCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpecCatCombo.Items.Clear();

            if (dr13.IsClosed == true && ItemCatCombo.Text != "")
            {

                cmd17 = new SqlCommand("select distinct [Specific Category]  from Category where [Sub Category]=" + "'" + SubCatCombo.Text + "'" + "AND [Category Name]=" + "'" + ItemCatCombo.Text + "'", conn);
                dr17 = cmd17.ExecuteReader();
                string[] catvalue = new string[999999];
                int i = 0;
                while (dr17.Read())
                {
                    catvalue[i] = dr17["Specific Category"].ToString();
                    //SubCatCombo.Items.Add(catvalue);
                    //if (i == 0)
                    //{
                    //    SubCatCombo.Text = dr17["Specific Category"].ToString();
                    //}
                    i++;
                }
                dr17.Close();
                for (int a = 0; a < i; a++)
                {
                    SpecCatCombo.Text = catvalue[0];
                    if (catvalue[a] != "")
                        SpecCatCombo.Items.Add(catvalue[a]);

                }
                if (Sellingtxt.Text.Trim() != "" && AdItemNametxt.Text.Trim() != "" && InvUnitcombo.Text.Trim() != "" && InvAnswer == 0 || InvAnswer == 1 && QtyTxt.Text.Trim() != "" && AdUnitPricetxt.Text.Trim() != "" && ItemCatCombo.Text.Trim() != "" && SubCatCombo.Text.Trim() != "" && AdType.Text.Trim() != "" && AdSuppExist.Text.Trim() != "")
                {
                    InvSaveandUpdatebtn.Visible = true;
                    invsavelbl.Visible = true;
                }
                else
                {
                    InvSaveandUpdatebtn.Visible = false;
                    invsavelbl.Visible = false;
                }
            }
        }

        private void InvSearchtxt_TextChanged(object sender, EventArgs e)
        {
            if (InvSearchtxt.Text == "")
            {


                InvDataGrid.DataSource = getAllInvData.GetAllInventoryRec();

                InvItemIDtxt.Text = "";
                ItemCatCombo.Enabled = false;
                SubCatCombo.Enabled = false;
                SpecCatCombo.Enabled = false;
                AdItemNametxt.Enabled = false;
                AdType.Enabled = false;
                InvUnitcombo.Enabled = false;
                QtyTxt.Enabled = false;
                AdUnitPricetxt.Enabled = false;
                Sellingtxt.Enabled = false;
                AdSuppExist.Enabled = false;
                AdSizeStand.Enabled = false;
                AdCusWidtxt.Enabled = false;
                AdInvHeighttxt.Enabled = false;
                AdColorExist.Enabled = false;

                ItemCatCombo.Text = "";
                SubCatCombo.Text = "";
                SpecCatCombo.Text = "";
                AdItemNametxt.Text = "";
                AdType.Text = "";
                InvUnitcombo.Text = "";
                QtyTxt.Text = "";
                AdUnitPricetxt.Text = "";
                Sellingtxt.Text = "";
                AdSuppExist.Text = "";
                AdSizeStand.Text = "";
                AdCusWidtxt.Text = "";
                AdInvHeighttxt.Text = "";
                AdColorExist.Text = "";
            }
            else
            {
                try
                {
                    int a = Convert.ToInt32(InvSearchtxt.Text.Trim());
                    BalloonKingdomDataSetTableAdapters.InventoryTableAdapter SearchInvById = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                    InvDataGrid.DataSource = SearchInvById.SearchByID(Convert.ToInt32(InvSearchtxt.Text.Trim()));


                }
                catch
                {


                    BalloonKingdomDataSetTableAdapters.InventoryTableAdapter SearchInvByCategoryAndName = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                    InvDataGrid.DataSource = SearchInvByCategoryAndName.SearchInvByCategoryAndName(InvSearchtxt.Text.Trim(), InvSearchtxt.Text.Trim(), InvSearchtxt.Text.Trim(), InvSearchtxt.Text.Trim());
                }
            }
        }




        //}
        /*else
        {
            if (AdCustAddtxt.Text == "" || AdCustLasttxt.Text == "" || AdCustFname.Text == "")
                MessageBox.Show("Please Fill up the Required fields", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                BalloonKingdomDataSetTableAdapters.CustomerTableAdapter updateCustAccount = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
                updateCustAccount.UpdateCustomerAcct(Convert.ToInt32(CustIDtxt.Text), AdCustLasttxt.Text.Trim(), AdCustMidtxt.Text.Trim(), AdCustFname.Text.Trim(), AdCustAddtxt.Text.Trim(), AdCustHnumtxt.Text.Trim(), AdCustCnumtxt.Text.Trim(), AdCustEadtxt.Text.Trim(), Convert.ToInt32(CustIDtxt.Text));

                MessageBox.Show("Record has been successfully updated.", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateCustbtn.Enabled = true;
                CustIDtxt.Text = "";
                AdCustFname.Text = "";
                AdCustMidtxt.Text = "";
                AdCustLasttxt.Text = "";
                AdCustAddtxt.Text = "";
                AdCustHnumtxt.Text = "";
                AdCustCnumtxt.Text = "";
                AdCustEadtxt.Text = "";
                CustSavelbl.Visible = false;
                custSavebtn.Visible = false;
                AdCustFname.Enabled = false;
                AdCustMidtxt.Enabled = false;
                AdCustLasttxt.Enabled = false;
                AdCustAddtxt.Enabled = false;
                AdCustHnumtxt.Enabled = false;
                AdCustCnumtxt.Enabled = false;
                AdCustEadtxt.Enabled = false;
            }

        }*/


        private void QtyTxt_TextChanged(object sender, EventArgs e)
        {

            if (QtyTxt.Text != "")
            {
                try
                {
                    int a = Convert.ToInt32(QtyTxt.Text);
                    if (Sellingtxt.Text.Trim() != "" && InvUnitcombo.Text.Trim() != "" && AdItemNametxt.Text.Trim() != "" && InvAnswer == 0 || InvAnswer == 1 && QtyTxt.Text.Trim() != "" && AdUnitPricetxt.Text.Trim() != "" && ItemCatCombo.Text.Trim() != "" && SubCatCombo.Text.Trim() != "" && AdType.Text.Trim() != "" && AdSuppExist.Text.Trim() != "")
                    {
                        InvSaveandUpdatebtn.Visible = true;
                        invsavelbl.Visible = true;


                    }
                    else
                    {
                        InvSaveandUpdatebtn.Visible = false;
                        invsavelbl.Visible = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid Entry: Please enter integer and non-negative value only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QtyTxt.Text = "";
                    QtyTxt.Focus();
                    Sellingtxt.Text = "";
                }



            }






        }

        private void AdCusWidtxt_TextChanged(object sender, EventArgs e)
        {
            if (AdCusWidtxt.Text != "")
            {
                try
                {
                    double a = Convert.ToDouble(AdCusWidtxt.Text);

                }
                catch
                {
                    MessageBox.Show("Invalid Entry: Please enter numberic and non-negative data only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AdCusWidtxt.Text = "";
                    AdCusWidtxt.Focus();
                }
            }

        }

        private void AdCusLentxt_TextChanged(object sender, EventArgs e)
        {
            if (AdInvHeighttxt.Text != "")
            {
                try
                {
                    double a = Convert.ToDouble(AdInvHeighttxt.Text);

                }
                catch
                {
                    MessageBox.Show("Invalid Entry: Please enter numberic data only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AdInvHeighttxt.Text = "";
                    AdInvHeighttxt.Focus();
                }
            }

        }

        private void InvViewAllbtn_Click(object sender, EventArgs e)
        {
            BalloonKingdomDataSetTableAdapters.InventoryTableAdapter getAllInvData = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
            InvDataGrid.DataSource = getAllInvData.GetAllInventoryRec();

            InvItemIDtxt.Text = "";
            ItemCatCombo.Enabled = false;
            SubCatCombo.Enabled = false;
            SpecCatCombo.Enabled = false;
            AdItemNametxt.Enabled = false;
            AdType.Enabled = false;
            InvUnitcombo.Enabled = false;
            QtyTxt.Enabled = false;
            AdUnitPricetxt.Enabled = false;
            Sellingtxt.Enabled = false;
            AdSuppExist.Enabled = false;
            AdSizeStand.Enabled = false;
            AdCusWidtxt.Enabled = false;
            AdInvHeighttxt.Enabled = false;
            AdColorExist.Enabled = false;

            ItemCatCombo.Text = "";
            SubCatCombo.Text = "";
            SpecCatCombo.Text = "";
            AdItemNametxt.Text = "";
            AdType.Text = "";
            InvUnitcombo.Text = "";
            QtyTxt.Text = "";
            AdUnitPricetxt.Text = "";
            Sellingtxt.Text = "";
            AdSuppExist.Text = "";
            AdSizeStand.Text = "";
            AdCusWidtxt.Text = "";
            AdInvHeighttxt.Text = "";
            AdColorExist.Text = "";

        }



        private void AddInvbtn_Click(object sender, EventArgs e)
        {
            InvAnswer = 0;
            InvItemIDtxt.Text = "***Auto-Generating ID***";
            ItemCatCombo.Enabled = true;
            Sellingtxt.Enabled = true;
            SubCatCombo.Enabled = true;
            SpecCatCombo.Enabled = true;
            AdItemNametxt.Enabled = true;
            AdType.Enabled = true;
            InvUnitcombo.Enabled = true;
            QtyTxt.Enabled = true;
            AdUnitPricetxt.Enabled = true;
            AdSuppExist.Enabled = true;
            AdSizeStand.Enabled = true;
            AdCusWidtxt.Enabled = true;
            AdInvHeighttxt.Enabled = true;
            AdColorExist.Enabled = true;
            ItemCatCombo.Text = "";
            SubCatCombo.Text = "";
            SpecCatCombo.Text = "";
            AdItemNametxt.Text = "";
            AdType.Text = "";
            InvUnitcombo.Text = "";
            QtyTxt.Text = "";
            AdUnitPricetxt.Text = "";
            Sellingtxt.Text = "";
            AdSuppExist.Text = "";
            AdSizeStand.Text = "";
            AdCusWidtxt.Text = "";
            AdInvHeighttxt.Text = "";
            AdColorExist.Text = "";


        }
        private void InvSaveandUpdatebtn_Click(object sender, EventArgs e)
        {
            String id, status = "unavailable";
            int a = 0, id2, stockqty = 0, qty = 0;
            if (InvAnswer == 0)
            {
                try
                {
                    SqlCommand cmd3 = new SqlCommand("Select * from Inventory", conn);
                    SqlDataReader dr4 = cmd3.ExecuteReader();
                    while (dr4.Read())
                    {
                        id = dr4["Item ID"].ToString();
                        id2 = Convert.ToInt32(id);
                        if (a < id2)
                            a = id2;


                    }
                    dr4.Close();
                    a++;

                    qty = Convert.ToInt32(QtyTxt.Text.Trim());
                    if (qty > 0)
                        status = "available";
                    stockqty += qty;

                    if (AdInvHeighttxt.Text == "")
                    { InvHeight = 0.00; }
                    else
                    {
                        InvHeight = Convert.ToDouble(AdInvHeighttxt.Text.Trim());
                    }
                    //search the same name of item in the inventory
                    SqlCommand cmd23 = new SqlCommand("Select * from Inventory where [Category Name]=" + "'" + ItemCatCombo.Text.Trim() + "'" + "AND [Sub Category]=" + "'" + SubCatCombo.Text.Trim() + "'" + "AND [Specific Category]=" + "'" + SpecCatCombo.Text.Trim() + "'" + "AND [Item Name]=" + "'" + AdItemNametxt.Text.Trim() + "'", conn);
                    SqlDataReader dr23 = cmd23.ExecuteReader();
                    string CatName = "", SubCat = "", SpecCat = "", ItemNme = "", Color = "";


                    while (dr23.Read())
                    {


                        if (ItemCatCombo.Text == dr23["Category Name"].ToString())
                            CatName = "Yes";
                        else
                            CatName = "No";

                        if (SubCatCombo.Text == dr23["Sub Category"].ToString())
                            SubCat = "Yes";
                        else
                            SubCat = "No";

                        if (SpecCatCombo.Text== dr23["Specific Category"].ToString())
                            SpecCat = "Yes";
                        else
                            SpecCat = "No";


                        if (AdItemNametxt.Text == dr23["Item Name"].ToString())
                            ItemNme = "Yes";
                        else
                            ItemNme = "No";

                        if (AdColorExist.Text == dr23["Color"].ToString())
                            Color = "Yes";
                        else
                            Color = "No";


                    }
                    dr23.Close();


                    if (AdCusWidtxt.Text == "")
                    { InvHeight = 0.00; }
                    else
                    {


                        InvWidth = Convert.ToDouble(AdCusWidtxt.Text.Trim());
                    }

                    if (CatName == "Yes" && SubCat == "Yes" && SpecCat == "Yes" && ItemNme == "Yes" && Color == "Yes")
                    {

                        int ans;
                        ans = Convert.ToInt16(MessageBox.Show("This Item is already Existed! Do you want to add the quantity to the old item?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
                        if (ans == 6)
                        {
                            if (qty == 0)
                            {
                                MessageBox.Show("Cannot Add 0 value to the existing item.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                InvItemIDtxt.Text = "";
                                ItemCatCombo.Enabled = false;
                                SubCatCombo.Enabled = false;
                                SpecCatCombo.Enabled = false;
                                AdItemNametxt.Enabled = false;
                                AdType.Enabled = false;
                                InvUnitcombo.Enabled = false;
                                QtyTxt.Enabled = false;
                                Sellingtxt.Enabled = false;
                                AdUnitPricetxt.Enabled = false;
                                AdSuppExist.Enabled = false;
                                AdSizeStand.Enabled = false;
                                AdCusWidtxt.Enabled = false;
                                AdInvHeighttxt.Enabled = false;
                                AdColorExist.Enabled = false;

                                ItemCatCombo.Text = "";
                                SubCatCombo.Text = "";
                                SpecCatCombo.Text = "";
                                AdItemNametxt.Text = "";
                                AdType.Text = "";
                                InvUnitcombo.Text = "";
                                QtyTxt.Text = "";
                                AdUnitPricetxt.Text = "";
                                Sellingtxt.Text = "";
                                AdSuppExist.Text = "";
                                AdSizeStand.Text = "";
                                AdCusWidtxt.Text = "";
                                AdInvHeighttxt.Text = "";
                                AdColorExist.Text = "";

                                InvSaveandUpdatebtn.Visible = false;
                                invsavelbl.Visible = false;

                            }
                            else
                            {
                               

                                string id24 = "";
                                SqlCommand cmd24 = new SqlCommand("Select * from Inventory where [Category Name]=" + "'" + ItemCatCombo.Text.Trim() + "'" + "AND [Sub Category]=" + "'" + SubCatCombo.Text.Trim() + "'" + "AND [Specific Category]=" + "'" + SpecCatCombo.Text.Trim() + "'" + "AND [Item Name]=" + "'" + AdItemNametxt.Text.Trim() + "'" + "And Color=" + "'" + AdColorExist.Text.Trim() + "'", conn);
                                SqlDataReader dr24 = cmd24.ExecuteReader();

                                while (dr24.Read())
                                {

                                    id24 = dr24["Item ID"].ToString();


                                }
                                dr24.Close();
                            
                                InvDupFrm showinvdup = new InvDupFrm(id24, AdItemNametxt.Text, QtyTxt.Text.Trim(), syspass);
                                showinvdup.ShowDialog();  
                                ItemCatCombo.Enabled = false;
                                SubCatCombo.Enabled = false;
                                SpecCatCombo.Enabled = false;
                                AdItemNametxt.Enabled = false;
                                AdType.Enabled = false;
                                InvUnitcombo.Enabled = false;
                                QtyTxt.Enabled = false;
                                Sellingtxt.Enabled = false;
                                AdUnitPricetxt.Enabled = false;
                                AdSuppExist.Enabled = false;
                                AdSizeStand.Enabled = false;
                                AdCusWidtxt.Enabled = false;
                                AdInvHeighttxt.Enabled = false;
                                AdColorExist.Enabled = false;

                                InvSaveandUpdatebtn.Visible = false;
                                invsavelbl.Visible = false;
                                BalloonKingdomDataSetTableAdapters.InventoryTableAdapter getAllInvData = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                                InvDataGrid.DataSource = getAllInvData.GetAllInventoryRec();

                            }
                        }

                    }
                    else
                    {
                        int catans = 0;

                        SqlCommand cmd214 = new SqlCommand("Select * from Category where [Sub Category]=" + "'" + SubCatCombo.Text.Trim() + "'" + "AND [Specific Category]=" + "'" + SpecCatCombo.Text.Trim() + "'", conn);
                        SqlDataReader dr214 = cmd214.ExecuteReader();

                        while (dr214.Read())
                        {

                            if (SubCatCombo.Text.Trim() == dr214["Sub Category"].ToString() && SpecCatCombo.Text.Trim() == dr214["Specific Category"].ToString())
                                catans = 1;
                        }
                        dr214.Close();
                        string spec;
                        if (SpecCatCombo.Text.Trim() == "")
                            spec = "None";
                        else
                            spec = SpecCatCombo.Text.Trim();
                        if (catans != 1)
                        {

                            BalloonKingdomDataSetTableAdapters.CategoryTableAdapter addNewCat = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CategoryTableAdapter();
                            addNewCat.AddNewCategory(ItemCatCombo.Text.Trim(), SubCatCombo.Text.Trim(), spec);


                        }

                        InvAddFrm showaddinvitem = new InvAddFrm(a, ItemCatCombo.Text.Trim(), SubCatCombo.Text.Trim(), spec, AdItemNametxt.Text.Trim(), AdType.Text.Trim(), AdSizeStand.Text.Trim(), Convert.ToInt32(QtyTxt.Text.Trim()), InvUnitcombo.Text.Trim(), Convert.ToDouble(Sellingtxt.Text.Trim()), Convert.ToInt32(QtyTxt.Text.Trim()), status, AdColorExist.Text.Trim(), Convert.ToDouble(InvWidth), Convert.ToDouble(InvHeight), AdSuppExist.Text.Trim(), syspass);
                        showaddinvitem.ShowDialog();
                        ItemCatCombo.Enabled = false;
                        SubCatCombo.Enabled = false;
                        SpecCatCombo.Enabled = false;
                        AdItemNametxt.Enabled = false;
                        AdType.Enabled = false;
                        Sellingtxt.Enabled = false;
                        InvUnitcombo.Enabled = false;
                        QtyTxt.Enabled = false;
                        AdUnitPricetxt.Enabled = false;
                        AdSuppExist.Enabled = false;
                        AdSizeStand.Enabled = false;
                        AdCusWidtxt.Enabled = false;
                        AdInvHeighttxt.Enabled = false;
                        AdColorExist.Enabled = false;
                    }

                    InvSaveandUpdatebtn.Visible = false;
                    invsavelbl.Visible = false;
                    BalloonKingdomDataSetTableAdapters.InventoryTableAdapter getAllInvData2 = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                    InvDataGrid.DataSource = getAllInvData2.GetAllInventoryRec();


                }
                catch (Exception x)
                {

                    MessageBox.Show(x.GetBaseException().ToString(), "connection status");

                }
            }
            else
            {

                int catans = 0;

                SqlCommand cmd224 = new SqlCommand("Select * from Category where [Sub Category]=" + "'" + SubCatCombo.Text.Trim() + "'" + "AND [Specific Category]=" + "'" + SpecCatCombo.Text.Trim() + "'", conn);
                SqlDataReader dr224 = cmd224.ExecuteReader();

                while (dr224.Read())
                {

                    if (SubCatCombo.Text.Trim() == dr224["Sub Category"].ToString() && SpecCatCombo.Text.Trim() == dr224["Specific Category"].ToString())
                        catans = 1;
                }
                dr224.Close();

               

                InvFrmUpdate showupdate = new InvFrmUpdate(syspass,catans,ItemCatCombo.Text.Trim(), SubCatCombo.Text.Trim(), SpecCatCombo.Text.Trim(), AdItemNametxt.Text.Trim(), AdType.Text.Trim(), AdSizeStand.Text.Trim(), InvUnitcombo.Text.Trim(), AdColorExist.Text.Trim(), AdCusWidtxt.Text.Trim(), AdInvHeighttxt.Text.Trim(), AdSuppExist.Text.Trim(), InvItemIDtxt.Text.Trim());
               showupdate.ShowDialog();

                InvItemIDtxt.Text = "";
                ItemCatCombo.Enabled = false;
                SubCatCombo.Enabled = false;
                SpecCatCombo.Enabled = false;
                AdItemNametxt.Enabled = false;
                AdType.Enabled = false;
                InvUnitcombo.Enabled = false;
                QtyTxt.Enabled = false;
                AdUnitPricetxt.Enabled = false;
                AdSuppExist.Enabled = false;
                AdSizeStand.Enabled = false;
                AdCusWidtxt.Enabled = false;
                AdInvHeighttxt.Enabled = false;
                AdColorExist.Enabled = false;
                Sellingtxt.Enabled = false;
                ItemCatCombo.Text = "";
                SubCatCombo.Text = "";
                SpecCatCombo.Text = "";
                AdItemNametxt.Text = "";
                AdType.Text = "";
                InvUnitcombo.Text = "";
                QtyTxt.Text = "";
                AdUnitPricetxt.Text = "";
                Sellingtxt.Text = "";
                AdSuppExist.Text = "";
                AdSizeStand.Text = "";
                AdCusWidtxt.Text = "";
                AdInvHeighttxt.Text = "";
                AdColorExist.Text = "";

                InvSaveandUpdatebtn.Visible = false;
                invsavelbl.Visible = false;
                BalloonKingdomDataSetTableAdapters.InventoryTableAdapter getAllInvData = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                InvDataGrid.DataSource = getAllInvData.GetAllInventoryRec();

            }
        }

        private void AdProdtxt_TextChanged(object sender, EventArgs e)
        {
            if (Sellingtxt.Text.Trim() != "" && InvUnitcombo.Text.Trim() != "" && AdItemNametxt.Text.Trim() != "" && InvAnswer == 0 || InvAnswer == 1 && QtyTxt.Text.Trim() != "" && AdUnitPricetxt.Text.Trim() != "" && ItemCatCombo.Text.Trim() != "" && SubCatCombo.Text.Trim() != "" && AdType.Text.Trim() != "" && AdSuppExist.Text.Trim() != "")
            {
                try
                {
                    int x = 0;
                    string txt;
                    if (AdItemNametxt.Text.Trim() != "")
                    {
                        txt = AdItemNametxt.Text;
                        x = txt.Length - 1;

                        if (AdItemNametxt.Text == "")
                        {
                            toolTip1.Show("Avoid special characters!", AdItemNametxt);
                            AdItemNametxt.Clear();
                            toolTip1.Hide(AdItemNametxt);
                        }

                        else if (char.IsWhiteSpace(txt[x]))
                        {
                            AdItemNametxt.Text = txt.Replace(txt[x], ' ');
                            toolTip1.Show("Avoid special characters!", AdItemNametxt);
                            toolTip1.Hide(AdItemNametxt);
                        }
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "error");
                }

                InvSaveandUpdatebtn.Visible = true;
                invsavelbl.Visible = true;
            }
            else
            {
                InvSaveandUpdatebtn.Visible = false;
                invsavelbl.Visible = false;
            }
        }


        private void UpdateInvbtn_Click(object sender, EventArgs e)
        {
            if (InvItemIDtxt.Text == "" || InvItemIDtxt.Text == "***Auto-Generating ID***")
            {
                MessageBox.Show("Please Select Item to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InvAnswer = 1;
                ItemCatCombo.Enabled = true;
                SubCatCombo.Enabled = true;
                SpecCatCombo.Enabled = true;
                AdItemNametxt.Enabled = true;
                AdType.Enabled = true;
                InvUnitcombo.Enabled = true;
                AdSuppExist.Enabled = true;
                AdSizeStand.Enabled = true;
                AdCusWidtxt.Enabled = true;
                AdInvHeighttxt.Enabled = true;
                AdColorExist.Enabled = true;
                InvSaveandUpdatebtn.Visible = true;
                invsavelbl.Visible = true;


            }
        }

        private void InvDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InvAnswer = 2;
            ItemCatCombo.Enabled = false;
            SubCatCombo.Enabled = false;
            SpecCatCombo.Enabled = false;
            AdItemNametxt.Enabled = false;
            AdType.Enabled = false;
            InvUnitcombo.Enabled = false;
            QtyTxt.Enabled = false;
            AdUnitPricetxt.Enabled = false;
            AdSuppExist.Enabled = false;
            AdSizeStand.Enabled = false;
            AdCusWidtxt.Enabled = false;
            Sellingtxt.Enabled = false;
            AdInvHeighttxt.Enabled = false;
            AdColorExist.Enabled = false;

            InvItemIDtxt.Text = InvDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            ItemCatCombo.Text = InvDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            SubCatCombo.Text = InvDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            SpecCatCombo.Text = InvDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            AdItemNametxt.Text = InvDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            AdType.Text = InvDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            AdSizeStand.Text = InvDataGrid.SelectedRows[0].Cells[6].Value.ToString();
            QtyTxt.Text = InvDataGrid.SelectedRows[0].Cells[7].Value.ToString();
            InvUnitcombo.Text = InvDataGrid.SelectedRows[0].Cells[8].Value.ToString();
            AdUnitPricetxt.Text = InvDataGrid.SelectedRows[0].Cells[9].Value.ToString();
            Sellingtxt.Text = InvDataGrid.SelectedRows[0].Cells[10].Value.ToString();
            InvQtyStockLbl.Text = InvDataGrid.SelectedRows[0].Cells[11].Value.ToString();
            InvQtyOrderLbl.Text = InvDataGrid.SelectedRows[0].Cells[12].Value.ToString();
            InvStatusLbl.Text = InvDataGrid.SelectedRows[0].Cells[13].Value.ToString();
            AdColorExist.Text = InvDataGrid.SelectedRows[0].Cells[14].Value.ToString();
            AdCusWidtxt.Text = InvDataGrid.SelectedRows[0].Cells[15].Value.ToString();
            AdInvHeighttxt.Text = InvDataGrid.SelectedRows[0].Cells[16].Value.ToString();
            AdSuppExist.Text = InvDataGrid.SelectedRows[0].Cells[17].Value.ToString();
            InvLostLbl.Text = InvDataGrid.SelectedRows[0].Cells[18].Value.ToString();
            InvReturnLbl.Text = InvDataGrid.SelectedRows[0].Cells[19].Value.ToString();
            InvBackOrderItemLbl.Text = InvDataGrid.SelectedRows[0].Cells[20].Value.ToString();


        }

        private void InvClearbtn_Click(object sender, EventArgs e)
        {
            InvSearchtxt.Text = "";
            InvItemIDtxt.Text = "";
            ItemCatCombo.Enabled = false;
            SubCatCombo.Enabled = false;
            SpecCatCombo.Enabled = false;
            AdItemNametxt.Enabled = false;
            AdType.Enabled = false;
            InvUnitcombo.Enabled = false;
            QtyTxt.Enabled = false;
            AdUnitPricetxt.Enabled = false;
            AdSuppExist.Enabled = false;
            AdSizeStand.Enabled = false;
            AdCusWidtxt.Enabled = false;
            AdInvHeighttxt.Enabled = false;
            AdColorExist.Enabled = false;

            ItemCatCombo.Text = "";
            SubCatCombo.Text = "";
            SpecCatCombo.Text = "";
            AdItemNametxt.Text = "";
            AdType.Text = "";
            InvUnitcombo.Text = "";
            QtyTxt.Text = "";
            AdUnitPricetxt.Text = "";
            Sellingtxt.Text = "";
            AdSuppExist.Text = "";
            AdSizeStand.Text = "";
            AdCusWidtxt.Text = "";
            AdInvHeighttxt.Text = "";
            AdColorExist.Text = "";
            BalloonKingdomDataSetTableAdapters.InventoryTableAdapter getAllInvData = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
            InvDataGrid.DataSource = getAllInvData.GetAllInventoryRec();


        }

        private void deleteInvbtn_Click(object sender, EventArgs e)
        {
            if (InvItemIDtxt.Text == "" || InvItemIDtxt.Text == "***Auto-generating ID***")
            {

                MessageBox.Show("Please Choose an Item to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int ans;
                ans = Convert.ToInt16(MessageBox.Show("Are you sure you want to delete this Item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (ans == 6)
                {
                    BalloonKingdomDataSetTableAdapters.InventoryTableAdapter deleteInvItem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                    deleteInvItem.DeleteInvItem(Convert.ToInt32(InvItemIDtxt.Text.Trim()));
                    InvItemIDtxt.Text = "";
                    ItemCatCombo.Enabled = false;
                    SubCatCombo.Enabled = false;
                    SpecCatCombo.Enabled = false;
                    AdItemNametxt.Enabled = false;
                    AdType.Enabled = false;
                    InvUnitcombo.Enabled = false;
                    QtyTxt.Enabled = false;
                    AdUnitPricetxt.Enabled = false;
                    Sellingtxt.Enabled = false;
                    AdSuppExist.Enabled = false;
                    AdSizeStand.Enabled = false;
                    AdCusWidtxt.Enabled = false;
                    AdInvHeighttxt.Enabled = false;
                    AdColorExist.Enabled = false;

                    ItemCatCombo.Text = "";
                    SubCatCombo.Text = "";
                    SpecCatCombo.Text = "";
                    AdItemNametxt.Text = "";
                    AdType.Text = "";
                    InvUnitcombo.Text = "";
                    QtyTxt.Text = "";
                    AdUnitPricetxt.Text = "";
                    Sellingtxt.Text = "";
                    AdSuppExist.Text = "";
                    AdSizeStand.Text = "";
                    AdCusWidtxt.Text = "";
                    AdInvHeighttxt.Text = "";
                    AdColorExist.Text = "";
                }
            }
        }



        private void createAnOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderingPanel.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ans;
            ans = Convert.ToInt16(MessageBox.Show("Are you sure you want to exit this program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (ans == 6)
            {


                this.Close();

            }
        }

        private void OrderSearchCustTxt_TextChanged(object sender, EventArgs e)
        {

            cmd = new SqlCommand("select distinct [Category Name]  from Category", conn);
            dr = cmd.ExecuteReader();
            string catvalue;
            int i = 0;
            while (dr.Read())
            {
                catvalue = dr["Category Name"].ToString();
                ItemCatCombo.Items.Add(catvalue);
                if (i == 0)
                {
                    ItemCatCombo.Text = "";
                }
                i++;
            }
            dr.Close();
        }

        private void OrderCustSearchtcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Search customer in order
            //if (OrderCustSearchtcombo.Text != "")
            //{
            //}
            //else
            //{
            //    OrderCustSearchtcombo.Items.Clear();
            //    OrderCustSearchtcombo.Text = "";

            //}

            //SqlCommand cmd123 = new SqlCommand("select * from Customer where [Last Name]=" + "'" + OrderCustSearchtcombo.Text+"'", conn);
            //SqlDataReader dr123 = cmd123.ExecuteReader();
            //string custvalue;
            ////int i = 0;
            //while (dr123.Read())
            //{
            //    //OrderCustSearchtcombo.Items.Add(dr123["LastName"].ToString() + " " + dr123["FirstName"].ToString() + " " + dr123["Middle Initial"].ToString() + ".");
            //    //COFTheme.Text = Convert.ToString(i);
            //    //dr123["Customer ID"].ToString();
            //    OrderCustSearchtcombo.Items.Add(dr123["Last Name"].ToString());
            //    CustIDlabel.Text = dr123["Customer ID"].ToString();
            //    //i++;
            //}
            //dr123.Close();
        }

        private void CustOrderbtn_Click(object sender, EventArgs e)
        {
            if (AdCustFname.Text == "")
            {
                CustSavelbl.Visible = false;
                custSavebtn.Visible = false;
                AdCustFname.Enabled = false;
                AdCustMidtxt.Enabled = false;
                AdCustLasttxt.Enabled = false;
                AdCustAddtxt.Enabled = false;
                AdCustHnumtxt.Enabled = false;
                AdCustCnumtxt.Enabled = false;
                AdCustEadtxt.Enabled = false;
                customerSearchtxt.Text = "";
                if (custAnswer != 1)
                    CustIDtxt.Text = "";
                AdCustFname.Text = "";
                AdCustMidtxt.Text = "";
                AdCustLasttxt.Text = "";
                AdCustAddtxt.Text = "";
                AdCustHnumtxt.Text = "";
                AdCustCnumtxt.Text = "";
                AdCustEadtxt.Text = "";
                MessageBox.Show("Please choose a customer to order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BalloonKingdomDataSetTableAdapters.CustomerTableAdapter viewall = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
                SearchCustdataGridView1.DataSource = viewall.ViewAllCustRec();



            }
            else
            {

                if (custAnswer == 3)
                {

                    int ans = Convert.ToInt32(MessageBox.Show("Are you sure you want to order with this customer?", "Order?", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                    if (ans == 6)
                    {
                        custOrdering = 4;
                        CustIDlabel.Text = CustIDtxt.Text;
                        FirstNameLbl.Text = AdCustFname.Text;
                        LastNameLbl.Text = AdCustLasttxt.Text;
                        MiddleInitialLbl.Text = AdCustMidtxt.Text;
                        fn = AdCustFname.Text;
                        mi = AdCustMidtxt.Text;
                        ln = AdCustLasttxt.Text;

                        MessageBox.Show("You choose " + AdCustFname.Text + " " + AdCustMidtxt.Text + ". " + AdCustLasttxt.Text + " as your customer that will order.", "Customer Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CustActLbl.Text = AdCustFname.Text + " " + AdCustMidtxt.Text + ". " + AdCustLasttxt.Text + " currently ordering.";
                        CustIDtxt.Text = "";
                        AdCustFname.Text = "";
                        AdCustMidtxt.Text = "";
                        AdCustLasttxt.Text = "";
                        AdCustAddtxt.Text = "";
                        AdCustHnumtxt.Text = "";
                        AdCustCnumtxt.Text = "";
                        AdCustEadtxt.Text = "";
                        CustomerPanel.Visible = false;
                        OrderingPanel.Visible = true;
                        COFThemetxt.Focus();
                        CustOrderbtn.Visible = false;
                        orderlabel.Visible = false;

                        //renew ordering
                        CartBoxMsg.Visible = true;
                        CartGBox.Visible = false;
                        PaymentGBox.Visible = false;
                        payBoxMsg.Visible = true;
                        DateofOrderPick.Value = DateTime.Today;
                        DateofOrderPick.Enabled = false;
                        DateOfEventPick.Value = DateTime.Today;
                        DateOfEventPick.Enabled = true;
                        DateOfEventPick.Enabled = true;
                        timepick.Value = DateTime.Today;
                        timepick.Enabled = true;
                        COFThemetxt.Text = "";
                        COFThemetxt.Enabled = true;
                        ColorMotifCombo.Text = "";
                        ColorMotifCombo.Enabled = true;
                        COFVenuetxt.Text = "";
                        COFVenuetxt.Enabled = true;
                        NextORBtn.Visible = true;
                        CancelORBtn.Visible = true;
                        OrderProdID.Text = "";
                        CatName.Text = "";
                        SubCat.Text = "";
                        SpecificCat.Text = "";
                        OrderProdName.Text = "";
                        colortxt.Text = "";
                        SupplierTxt.Text = "";
                        SizeTxt.Text = "";
                        qtyOrTxt.Text = "";
                        Widthtxt.Text = "";
                        Heighttxt.Text = "";
                        Typetxt.Text = "";
                        OrderStatus.Text = "";
                        OrderStock.Text = "";
                        unitTxt.Text = "";
                        OrderUnitPrice.Text = "";
                        OrderQty.Text = "";
                        OrderSubcost.Text = "";
                        OrderQty.Enabled = false;

                        OrderingTab.SelectedTab = COFpage;

                        customerSearchtxt.Text = "";
                    }

                }
                else
                {

                    CustSavelbl.Visible = false;
                    custSavebtn.Visible = false;
                    AdCustFname.Enabled = false;
                    AdCustMidtxt.Enabled = false;
                    AdCustLasttxt.Enabled = false;
                    AdCustAddtxt.Enabled = false;
                    AdCustHnumtxt.Enabled = false;
                    AdCustCnumtxt.Enabled = false;
                    AdCustEadtxt.Enabled = false;
                    customerSearchtxt.Text = "";
                    if (custAnswer != 1)
                        CustIDtxt.Text = "";
                    AdCustFname.Text = "";
                    AdCustMidtxt.Text = "";
                    AdCustLasttxt.Text = "";
                    AdCustAddtxt.Text = "";
                    AdCustHnumtxt.Text = "";
                    AdCustCnumtxt.Text = "";
                    AdCustEadtxt.Text = "";
                    // MessageBox.Show("Please choose a customer to order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BalloonKingdomDataSetTableAdapters.CustomerTableAdapter viewall = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
                    SearchCustdataGridView1.DataSource = viewall.ViewAllCustRec();
                }
            }
        }


        private void OrderlineToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OrderingPanel.Visible = false;
            Orderpanel.Visible = true;
            CustomerPanel.Visible = false;
            Inventorypanel.Visible = false;
            Supplierpanel.Visible = false;
            SecurityPanel.Visible = false;
            PurchasingPanel.Visible = false;
            BackgndPanel.Visible = false;
            ReturnRentPanel.Visible = false;
        }

        private void CurrentorderingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (custOrdering == 4)
            {
                OrderingPanel.Visible = true;
                CustomerPanel.Visible = false;
                Inventorypanel.Visible = false;
                Orderpanel.Visible = false;
                Supplierpanel.Visible = false;
                SecurityPanel.Visible = false;
                PurchasingPanel.Visible = false;
                BackgndPanel.Visible = false;
                ReturnRentPanel.Visible = false;

            }
            else
            {
                MessageBox.Show("Please Select a customer to Order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (DateOfEventPick.Value != null && COFThemetxt.Text != "" && ColorMotifCombo.Text != "" && COFVenuetxt.Text != "")
            {


                if (DateOfEventPick.Value < DateTime.Today)
                {
                    MessageBox.Show("Cannot proceed because the event date is a past date. Please select a date of event equal or greater than today.", "EVENT DATE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    String id;
                    int a = 0, id2;


                    SqlCommand cmd21 = new SqlCommand("Select * from orderline", conn);
                    SqlDataReader dr21 = cmd21.ExecuteReader();
                    while (dr21.Read())
                    {
                        id = dr21["COF Number"].ToString();
                        id2 = Convert.ToInt32(id);
                        if (a < id2)
                            a = id2;


                    }
                    dr21.Close();
                    a++;


                    int ans;
                    ans = Convert.ToInt16(MessageBox.Show("Are you sure you want to proceed to order? If yes, there would be no return in editing the COF form field.", "PROCEED TO ORDER", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                    if (ans == 6)
                    {

                        BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter InsertOrder = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                        InsertOrder.InsertOrderRec(a, Convert.ToInt32(CustIDlabel.Text), LastNameLbl.Text, FirstNameLbl.Text, MiddleInitialLbl.Text, DateTime.Now, DateOfEventPick.Value, timepick.Value, COFThemetxt.Text, ColorMotifCombo.Text, COFVenuetxt.Text);
                        OrderingTab.SelectedTab = OrderRentpage;
                        COFlabel.Text = Convert.ToString(a);

                        COFThemetxt.Enabled = false;
                        DateOfEventPick.Enabled = false;
                        timepick.Enabled = false;
                        COFThemetxt.Enabled = false;
                        COFVenuetxt.Enabled = false;
                        CartGBox.Visible = true;
                        ColorMotifCombo.Enabled = false;
                        CartBoxMsg.Visible = false;
                        NextORBtn.Visible = false;
                        CancelORBtn.Visible = false;
                        BalloonKingdomDataSetTableAdapters.ItemTableAdapter view = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.ItemTableAdapter();
                        CartdataGridView.DataSource = view.ViewCartCOF1(Convert.ToInt32(COFlabel.Text));
                    }
                }
            }

            else
            {
                MessageBox.Show("Please fill up the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void ordersearchtxt_TextChanged(object sender, EventArgs e)
        {

            OrderQty.Enabled = false;

            if (bg == 1)
                OrderQty.Enabled = true;
            if (ordersearchtxt.Text == "")
            {

                BalloonKingdomDataSetTableAdapters.InventoryTableAdapter getData = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                orderandrentdatagrid.DataSource = getData.GetAllInventoryRec();
                OrderProdID.Text = "";
                CatName.Text = "";
                SubCat.Text = "";
                SpecificCat.Text = "";
                OrderProdName.Text = "";
                colortxt.Text = "";
                SupplierTxt.Text = "";
                SizeTxt.Text = "";
                qtyOrTxt.Text = "";
                Widthtxt.Text = "";
                Heighttxt.Text = "";
                Typetxt.Text = "";
                OrderStatus.Text = "";
                OrderStock.Text = "";
                unitTxt.Text = "";
                OrderUnitPrice.Text = "";
                OrderQty.Text = "";
                OrderSubcost.Text = "";
                OrderQty.Enabled = false;


            }
            else
            {
                try
                {
                    int a = Convert.ToInt32(ordersearchtxt.Text.Trim());
                    BalloonKingdomDataSetTableAdapters.InventoryTableAdapter SearchInvById = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                    orderandrentdatagrid.DataSource = SearchInvById.SearchByID(Convert.ToInt32(ordersearchtxt.Text.Trim()));


                }
                catch
                {


                    BalloonKingdomDataSetTableAdapters.InventoryTableAdapter SearchInvByCategoryAndName = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                    orderandrentdatagrid.DataSource = SearchInvByCategoryAndName.SearchInvByCategoryAndName(ordersearchtxt.Text.Trim(), ordersearchtxt.Text.Trim(), ordersearchtxt.Text.Trim(), ordersearchtxt.Text.Trim());
                }
            }
        }




        private void OrderSearchbtn_Click(object sender, EventArgs e)
        {
            BalloonKingdomDataSetTableAdapters.InventoryTableAdapter getAllInvData1 = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
            orderandrentdatagrid.DataSource = getAllInvData1.ShowOrderInv();


        }

        private void SearchCustdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CustIDtxt.Text = SearchCustdataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                AdCustFname.Text = SearchCustdataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                AdCustMidtxt.Text = SearchCustdataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                AdCustLasttxt.Text = SearchCustdataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                AdCustAddtxt.Text = SearchCustdataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                AdCustHnumtxt.Text = SearchCustdataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                AdCustCnumtxt.Text = SearchCustdataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                AdCustEadtxt.Text = SearchCustdataGridView1.SelectedRows[0].Cells[7].Value.ToString();

                CustStatLbl.Text = SearchCustdataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                NumOrCustLbl.Text = SearchCustdataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                ProcOrderLbl.Text = SearchCustdataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                PendOrCustLbl.Text = SearchCustdataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                CanOrCustLbl.Text = SearchCustdataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                WaitingOrCusLbl.Text = SearchCustdataGridView1.SelectedRows[0].Cells[13].Value.ToString();
                custAnswer = 3;
                UpdateCustbtn.Enabled = true;
            }
            catch { }
        }

        private void SearchSupplierDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AdSuppidtxt.Text = SearchSupplierDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            AdSuppnametxt.Text = SearchSupplierDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            AdSuppnumtxt.Text = SearchSupplierDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            AdSuppaddtxt.Text = SearchSupplierDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            AdSuppEadtxt.Text = SearchSupplierDataGrid.SelectedRows[0].Cells[4].Value.ToString();

            SupActLbl.Text = "Selected Supplier DataGrid";
        }

        private void OrderQty_TextChanged(object sender, EventArgs e)
        {
            if (OrderQty.Text != "")
            {




                try
                {
                    int x = 0;
                    string txt;
                    if (OrderQty.Text != "")
                    {
                        txt = OrderQty.Text;
                        x = txt.Length - 1;

                        if (OrderQty.Text == "")
                        {
                            toolTip1.Show("Avoid special characters!", OrderQty);
                            OrderQty.Clear();
                            toolTip1.Hide(OrderQty);
                        }

                        else if (char.IsWhiteSpace(txt[x]))
                        {
                            OrderQty.Text = txt.Replace(txt[x], ' ');
                            toolTip1.Show("Avoid special characters!", OrderQty);
                            toolTip1.Hide(OrderQty);
                        }
                    }

                    try
                    {
                        int a = Convert.ToInt32(OrderQty.Text);
                        double unit = Convert.ToDouble(OrderUnitPrice.Text);
                        double total = 0;
                        total = a * unit;

                        OrderSubcost.Text = Convert.ToString(total);
                    }

                    catch
                    {

                        OrderQty.Text = "";
                        OrderQty.Focus();

                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "error");

                    OrderQty.Text = "";
                    OrderQty.Focus();

                    OrderSubcost.Text = "";
                }

            }
            else
            {
                QtyTxt.Focus();

                OrderSubcost.Text = "";
            }
        }

        private void AdUnitPricetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sellingtxt_TextChanged(object sender, EventArgs e)
        {
            if (Sellingtxt.Text != "")
            {
                try
                {
                    double a = Convert.ToDouble(Sellingtxt.Text);

                    if (Sellingtxt.Text.Trim() != "" && InvUnitcombo.Text.Trim() != "" && AdItemNametxt.Text.Trim() != "" && InvAnswer == 0 || InvAnswer == 1 && QtyTxt.Text.Trim() != "" && AdUnitPricetxt.Text.Trim() != "" && ItemCatCombo.Text.Trim() != "" && SubCatCombo.Text.Trim() != "" && AdType.Text.Trim() != "" && AdSuppExist.Text.Trim() != "")
                    {
                        InvSaveandUpdatebtn.Visible = true;
                        invsavelbl.Visible = true;
                    }
                    else
                    {
                        InvSaveandUpdatebtn.Visible = false;
                        invsavelbl.Visible = false;
                    }

                }
                catch
                {
                    MessageBox.Show("Invalid Entry: Please enter numeric and non-negative data only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Sellingtxt.Text = "";
                    Sellingtxt.Focus();
                }
            }
        }

        private void AdType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Sellingtxt.Text.Trim() != "" && AdItemNametxt.Text.Trim() != "" && InvUnitcombo.Text.Trim() != "" && InvAnswer == 0 || InvAnswer == 1 && QtyTxt.Text.Trim() != "" && AdUnitPricetxt.Text.Trim() != "" && ItemCatCombo.Text.Trim() != "" && SubCatCombo.Text.Trim() != "" && AdType.Text.Trim() != "" && AdSuppExist.Text.Trim() != "")
            {
                InvSaveandUpdatebtn.Visible = true;
                invsavelbl.Visible = true;
            }
            else
            {
                InvSaveandUpdatebtn.Visible = false;
                invsavelbl.Visible = false;
            }
        }

        private void AdSuppExist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Sellingtxt.Text.Trim() != "" && AdItemNametxt.Text.Trim() != "" && InvUnitcombo.Text.Trim() != "" && InvAnswer == 0 || InvAnswer == 1 && QtyTxt.Text.Trim() != "" && AdUnitPricetxt.Text.Trim() != "" && ItemCatCombo.Text.Trim() != "" && SubCatCombo.Text.Trim() != "" && AdType.Text.Trim() != "" && AdSuppExist.Text.Trim() != "")
            {
                InvSaveandUpdatebtn.Visible = true;
                invsavelbl.Visible = true;
            }
            else
            {
                InvSaveandUpdatebtn.Visible = false;
                invsavelbl.Visible = false;
            }
        }

        private void InvUnitcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Sellingtxt.Text.Trim() != "" && AdItemNametxt.Text.Trim() != "" && InvUnitcombo.Text.Trim() != "" && InvAnswer == 0 || InvAnswer == 1 && QtyTxt.Text.Trim() != "" && AdUnitPricetxt.Text.Trim() != "" && ItemCatCombo.Text.Trim() != "" && SubCatCombo.Text.Trim() != "" && AdType.Text.Trim() != "" && AdSuppExist.Text.Trim() != "")
            {
                InvSaveandUpdatebtn.Visible = true;
                invsavelbl.Visible = true;
            }
            else
            {
                InvSaveandUpdatebtn.Visible = false;
                invsavelbl.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


            int c = 0;
            SqlCommand cmditemindex = new SqlCommand("Select * from Item where [COF Number]=" + "'" + COFlabel.Text + "'", conn);
            SqlDataReader dritemindex = cmditemindex.ExecuteReader();
            while (dritemindex.Read())
            {

                if (OrderProdID.Text == dritemindex["Item ID"].ToString())
                    c = 1;


            }
            dritemindex.Close();

            String id;
            int a = 0, id2, qtytest = 0;

            if (OrderQty.Text != "")
                qtytest = Convert.ToInt32(OrderQty.Text);

            if (qtytest <= 0)
            {
                MessageBox.Show("Cannot add item to cart without specifying the amount of quantity. Please enter valid number not less than 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                OrderQty.Text = "";
                OrderQty.Focus();

            }
            else
            {

                if (bg != 1)
                {

                    SqlCommand cmd55 = new SqlCommand("Select * from Item", conn);
                    SqlDataReader dr55 = cmd55.ExecuteReader();
                    while (dr55.Read())
                    {
                        id = dr55["Item Number"].ToString();
                        id2 = Convert.ToInt32(id);
                        if (a < id2)
                            a = id2;



                    }
                    dr55.Close();
                    a++;

                    //try
                    //{
                    if (OrderSubcost.Text == "" && OrderQty.Text == "")
                    {
                        MessageBox.Show("Please Enter the quantity of items to order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        OrderQty.Focus();

                    }
                    else
                    {

                        if (c == 1)
                        {

                            MessageBox.Show("Already Taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            c = 0;
                            double av = 0, or = 0, totor = 0; int qtyitem = 0, totst = 0, back = 0;

                            string type = "";


                            SqlCommand cmd221 = new SqlCommand("Select * from Inventory where [Item ID]=" + "'" + OrderProdID.Text.Trim() + "'", conn);
                            SqlDataReader dr221 = cmd221.ExecuteReader();
                            while (dr221.Read())
                            {
                                av = Convert.ToDouble(dr221["Quantity in Stock"].ToString());

                                or = Convert.ToDouble(dr221["Quantity in Order"].ToString());

                                back = Convert.ToInt32(dr221["Back Order"].ToString());

                                type = dr221["Item Type"].ToString();

                            }
                            dr221.Close();

                            qtyitem = Convert.ToInt32(OrderQty.Text.Trim());

                            int test = 0, backorinv = 0, backitem = 0;

                            test = Convert.ToInt32(av) - qtyitem;
                            string doans = "yes";
                            if (test < 0)
                            {

                                if (type == "Rental")
                                {

                                    int ans = Convert.ToInt16(MessageBox.Show("Rental equipment is out of stock. Would you like to continue by ordering the said equipement to your supplier later?", "Not Enough supply!", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                                    if (ans == 6)
                                    {
                                        totor = or + qtyitem + test;
                                        backorinv = back + qtyitem - Convert.ToInt32(av);
                                        backitem = qtyitem - Convert.ToInt32(av);
                                        totst = 0;
                                    }
                                    else
                                        doans = "no";
                                }
                                else
                                {

                                    int ans = Convert.ToInt16(MessageBox.Show("This particular item is out of stock. Would you like to continue and reorder item from your supplier later?", "Not Enough supply!", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                                    if (ans == 6)
                                    {
                                        totor = or + qtyitem + test;
                                        backorinv = back + qtyitem - Convert.ToInt32(av);
                                        backitem = qtyitem - Convert.ToInt32(av);
                                        totst = 0;
                                    }
                                    else
                                        doans = "no";
                                }

                            }
                            else
                            {
                                totst = Convert.ToInt32(av) - qtyitem;
                                totor = or + qtyitem;
                                backorinv = 0;
                                backitem = 0;


                            }





                            if (doans == "yes")
                            {
                                BalloonKingdomDataSetTableAdapters.InventoryTableAdapter upditem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                                upditem.UpdateInvItem(Convert.ToInt32(totst), Convert.ToInt32(totor), Convert.ToInt32(OrderProdID.Text), Convert.ToInt32(OrderProdID.Text));



                                BalloonKingdomDataSetTableAdapters.ItemTableAdapter additem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.ItemTableAdapter();
                                additem.AddItemtoCart(a, Convert.ToInt32(OrderProdID.Text), Convert.ToInt32(COFlabel.Text), CatName.Text.Trim(), SubCat.Text.Trim(), SpecificCat.Text.Trim(), OrderProdName.Text.Trim(), SupplierTxt.Text.Trim(), Convert.ToDecimal(Widthtxt.Text.Trim()), Convert.ToDecimal(Heighttxt.Text.Trim()), SizeTxt.Text.Trim(), colortxt.Text.Trim(), Typetxt.Text.Trim(), unitTxt.Text.Trim(), Convert.ToInt32(OrderQty.Text.Trim()), Convert.ToDecimal(OrderUnitPrice.Text.Trim()), Convert.ToDecimal(OrderSubcost.Text.Trim()));

                                BalloonKingdomDataSetTableAdapters.InventoryTableAdapter backorder = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                                backorder.UpdateBackOrder(backorinv, Convert.ToInt32(OrderProdID.Text), Convert.ToInt32(OrderProdID.Text));

                                BalloonKingdomDataSetTableAdapters.InventoryTableAdapter getData = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                                orderandrentdatagrid.DataSource = getData.GetAllInventoryRec();




                                SqlCommand cmd25 = new SqlCommand("update Item set [Back Order] =" + "'" + Convert.ToString(backitem) + "'" + "where [COF Number] =" + "'" + COFlabel.Text + "'" + "AND [Item ID]=" + "'" + OrderProdID.Text + "'", conn);
                                cmd25.ExecuteNonQuery();




                                BalloonKingdomDataSetTableAdapters.ItemTableAdapter view = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.ItemTableAdapter();
                                CartdataGridView.DataSource = view.ViewCartCOF1(Convert.ToInt32(COFlabel.Text));

                                SqlCommand cmd221a = new SqlCommand("Select * from Item where [COF Number] =" + "'" + COFlabel.Text + "'",conn);
                                SqlDataReader dr222 = cmd221a.ExecuteReader();
                                double totamt12 = 0;
                                while (dr222.Read())
                                { 
                                totamt12 +=Convert.ToDouble(dr222["Sub Cost"].ToString());
                                
                                
                                }
                                dr222.Close();

                                SqlCommand cmdupor = new SqlCommand("update Orderline set [Total]=" + "'" + Convert.ToString(totamt12) + "'" + "," + "[Overall Total]=" + "'" + Convert.ToString(totamt12) + "'", conn);
                                cmdupor.ExecuteNonQuery();

                                    order = 0;
                                rent = 0;
                                totalitem = 0;
                                totamt = 0;
                                totqty = 0;
                                SqlCommand cmd57 = new SqlCommand("Select * from Item where [COF Number]=" + "'" + COFlabel.Text + "'", conn);
                                SqlDataReader dr57 = cmd57.ExecuteReader();
                                while (dr57.Read())
                                {

                                    if (dr57["Type"].ToString() == "Ordering")
                                    {
                                        order++;
                                    }
                                    else
                                    {
                                        rent++;
                                    }
                                    totalitem++;
                                    totamt += Convert.ToDouble(dr57["Sub Cost"].ToString());

                                    totqty += Convert.ToInt32(dr57["Quantity"].ToString());

                                }
                                dr57.Close();


                                rentLbl.Text = Convert.ToString(rent);
                                orderLbl.Text = Convert.ToString(order);
                                totalItemlbl.Text = Convert.ToString(totalitem);
                                totalAmtLbl.Text = Convert.ToString(totamt);
                                TotalAmtTxt.Text = Convert.ToString(totamt);
                                PaymentTotal.Text = Convert.ToString(totamt);
                                serbtn.Checked = false;
                                totqtytxt.Text = Convert.ToString(totqty);



                                OrderProdID.Text = "";
                                CatName.Text = "";
                                SubCat.Text = "";
                                SpecificCat.Text = "";
                                OrderProdName.Text = "";
                                colortxt.Text = "";
                                SupplierTxt.Text = "";
                                SizeTxt.Text = "";
                                qtyOrTxt.Text = "";
                                Widthtxt.Text = "";
                                Heighttxt.Text = "";
                                Typetxt.Text = "";
                                OrderStatus.Text = "";
                                OrderStock.Text = "";
                                unitTxt.Text = "";
                                OrderUnitPrice.Text = "";
                                OrderQty.Text = "";
                                OrderSubcost.Text = "";
                                OrderQty.Enabled = false;
                                AddItembtn.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        private void CartdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            itemNum = Convert.ToInt32(CartdataGridView.SelectedRows[0].Cells[0].Value.ToString());
            OrderProdID.Text = CartdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            CatName.Text = CartdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            SubCat.Text = CartdataGridView.SelectedRows[0].Cells[4].Value.ToString();
            SpecificCat.Text = CartdataGridView.SelectedRows[0].Cells[5].Value.ToString();
            OrderProdName.Text = CartdataGridView.SelectedRows[0].Cells[6].Value.ToString();

            SupplierTxt.Text = CartdataGridView.SelectedRows[0].Cells[7].Value.ToString();
            Widthtxt.Text = CartdataGridView.SelectedRows[0].Cells[8].Value.ToString();
            Heighttxt.Text = CartdataGridView.SelectedRows[0].Cells[9].Value.ToString();
            SizeTxt.Text = CartdataGridView.SelectedRows[0].Cells[10].Value.ToString();
            colortxt.Text = CartdataGridView.SelectedRows[0].Cells[11].Value.ToString();
            Typetxt.Text = CartdataGridView.SelectedRows[0].Cells[12].Value.ToString();
            unitTxt.Text = CartdataGridView.SelectedRows[0].Cells[13].Value.ToString();
            OrderUnitPrice.Text = CartdataGridView.SelectedRows[0].Cells[15].Value.ToString();
            OrderQty.Text = CartdataGridView.SelectedRows[0].Cells[14].Value.ToString();
            orqty = Convert.ToInt32(CartdataGridView.SelectedRows[0].Cells[14].Value.ToString());
            OrderSubcost.Text = CartdataGridView.SelectedRows[0].Cells[16].Value.ToString();
            Itembo = Convert.ToInt32(CartdataGridView.SelectedRows[0].Cells[17].Value.ToString());
            backorcartlbl.Text = CartdataGridView.SelectedRows[0].Cells[17].Value.ToString();
            AddItembtn.Enabled = false;

            Removeitembtn.Enabled = true;

            qtyOrTxt.Text = "";
            OrderQty.Enabled = true;
            OrderStock.Text = "";
            bg = 1;
            ordersearchtxt.Text = CartdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            OrderQty.Focus();


        }





        private void AdCustFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz -'`".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void AdCustMidtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                string txt;
                if (AdCustMidtxt.Text != "")
                {
                    txt = AdCustMidtxt.Text;
                    x = txt.Length - 1;

                    if (AdCustMidtxt.Text == "")
                    {
                        toolTip1.Show("Avoid special characters!", AdCustMidtxt);
                        AdCustMidtxt.Clear();
                        toolTip1.Hide(AdCustMidtxt);
                    }

                    else if (char.IsWhiteSpace(txt[x]))
                    {
                        AdCustMidtxt.Text = txt.Replace(txt[x], ' ');
                        toolTip1.Show("Avoid special characters!", AdCustMidtxt);
                        toolTip1.Hide(AdCustMidtxt);
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString(), "error");
            }

        }

        private void AdCustMidtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz -'`.".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void AdCustLasttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz -'.".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void AdCustHnumtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*1234567890()".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void AdCustHnumtxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (AdCustHnumtxt.Text != " ")
            {
                str = AdCustHnumtxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((AdCustHnumtxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", AdCustHnumtxt);
                    AdCustHnumtxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", AdCustHnumtxt);
                    AdCustHnumtxt.Clear();
                }
                toolTip1.Hide(AdCustHnumtxt);

            }


        }

        private void AdCustCnumtxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (AdCustCnumtxt.Text != " ")
            {
                str = AdCustCnumtxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((AdCustHnumtxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", AdCustCnumtxt);
                    AdCustCnumtxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", AdCustCnumtxt);
                    AdCustCnumtxt.Clear();
                }
                toolTip1.Hide(AdCustCnumtxt);

            }
        }

        private void AdCustCnumtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*1234567890".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void AdCustAddtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz-,'` 1234567890.".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void AdCustEadtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                string txt;
                if (AdCustEadtxt.Text != "")
                {
                    txt = AdCustEadtxt.Text;
                    x = txt.Length - 1;

                    if (AdCustEadtxt.Text == "")
                    {
                        toolTip1.Show("Avoid special characters!", AdCustEadtxt);
                        AdCustEadtxt.Clear();
                        toolTip1.Hide(AdCustEadtxt);
                    }

                    else if (char.IsWhiteSpace(txt[x]))
                    {
                        AdCustEadtxt.Text = txt.Replace(txt[x], ' ');
                        toolTip1.Show("Avoid special characters!", AdCustEadtxt);
                        toolTip1.Hide(AdCustEadtxt);
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString(), "error");
            }
        }

        private void AdCustEadtxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz_@1234567890.".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }


        private void COFThemetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz .-'`".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void COFVenuetxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                string txt;
                if (COFVenuetxt.Text != "")
                {
                    txt = COFVenuetxt.Text;
                    x = txt.Length - 1;

                    if (COFVenuetxt.Text == "")
                    {
                        toolTip1.Show("Avoid special characters!", COFVenuetxt);
                        COFVenuetxt.Clear();
                        toolTip1.Hide(COFVenuetxt);
                    }

                    else if (char.IsWhiteSpace(txt[x]))
                    {
                        COFVenuetxt.Text = txt.Replace(txt[x], ' ');
                        toolTip1.Show("Avoid special characters!", COFVenuetxt);
                        toolTip1.Hide(COFVenuetxt);
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString(), "error");
            }
        }

        private void COFVenuetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz -'`,1234567890.".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }



        private void PaymentService_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*1234567890.".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void AdSuppnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz 1234567890.-'`".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void AdSuppnumtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*1234567890*".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void AdSuppaddtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz 1234567890.,-'`".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void AdSuppEadtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                string txt;
                if (AdSuppEadtxt.Text != "")
                {
                    txt = AdSuppEadtxt.Text;
                    x = txt.Length - 1;

                    if (AdSuppEadtxt.Text == "")
                    {
                        toolTip1.Show("Avoid special characters!", AdSuppEadtxt);
                        AdSuppEadtxt.Clear();
                        toolTip1.Hide(AdSuppEadtxt);
                    }

                    else if (char.IsWhiteSpace(txt[x]))
                    {
                        AdSuppEadtxt.Text = txt.Replace(txt[x], ' ');
                        toolTip1.Show("Avoid special characters!", AdSuppEadtxt);
                        toolTip1.Hide(AdSuppEadtxt);
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString(), "error");
            }
        }

        private void AdSuppEadtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz1234567890._@".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void AdItemNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz 1234567890.-".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void OrderClearbtn_Click(object sender, EventArgs e)
        {
            AddItembtn.Enabled = false;
            Removeitembtn.Enabled = false;
            //BalloonKingdomDataSetTableAdapters.InventoryTableAdapter getAllInvData = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
            //orderandrentdatagrid.DataSource = getAllInvData.GetAllInventoryRec();

            OrderProdID.Text = "";
            CatName.Text = "";
            SubCat.Text = "";
            SpecificCat.Text = "";
            OrderProdName.Text = "";
            colortxt.Text = "";
            SupplierTxt.Text = "";
            SizeTxt.Text = "";
            qtyOrTxt.Text = "";
            Widthtxt.Text = "";
            Heighttxt.Text = "";
            Typetxt.Text = "";
            OrderStatus.Text = "";
            OrderStock.Text = "";
            unitTxt.Text = "";
            OrderUnitPrice.Text = "";
            OrderQty.Text = "";
            OrderSubcost.Text = "";
            OrderQty.Enabled = false;

        }


        private void orbtn_CheckedChanged(object sender, EventArgs e)
        {
            double temp = 0, tota = 0, down2 = 0, servc = 0;

            if (TotalAmtTxt.Text == "")
                totamt = 0;
            else
            totamt = Convert.ToDouble(TotalAmtTxt.Text);

            if (serbtn.Checked == true)
            {


                tota = totamt;
                temp = tota * 0.1;

                SerTxt.Text = Convert.ToString(temp);

                tota = totamt + temp;
                down2 = tota / 2;






                if (orbtn.Checked == true)
                {
                    ORLbl.Text = "Yes";
                    tota += Convert.ToDouble(VATAmttxt.Text);


                }
                else
                    ORLbl.Text = "No";

                PaymentTotal.Text = Convert.ToString(tota);

                Overalltxt.Text = Convert.ToString(tota);
                if (downRadiobtn.Checked == true)
                {
                    PaymentDownPayment.Text = Convert.ToString(down2);

                    PaymentBalance.Text = Convert.ToString(tota - down2);
                }
                else
                {
                    PaymentDownPayment.Text = "0";
                    PaymentBalance.Text = "0";
                }


            }
            else
            {

                SerTxt.Text = "0";


                tota = totamt + servc;
                down2 = tota / 2;
                PaymentDownPayment.Text = Convert.ToString(down2);


                PaymentBalance.Text = Convert.ToString(tota - down2);


                if (orbtn.Checked == true)
                {
                    tota += Convert.ToDouble(VATAmttxt.Text);
                    ORLbl.Text = "Yes";

                }
                else
                    ORLbl.Text = "No";

                PaymentTotal.Text = Convert.ToString(tota);
                Overalltxt.Text = Convert.ToString(tota);
                if (downRadiobtn.Checked == true)
                {
                    PaymentDownPayment.Text = Convert.ToString(down2);

                    PaymentBalance.Text = Convert.ToString(tota - down2);
                }
                else
                {
                    PaymentDownPayment.Text = "0";
                    PaymentBalance.Text = "0";
                }

            }
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            payans = 0;
            //if (orbtn.Checked == false || PaymentService.Text == "")
            //{
            PaymentDownPayment.Enabled = true;

            //    double totalamout1 = Convert.ToDouble(TotalAmtTxt.Text);
            //    PaymentDownPayment.Text = Convert.ToString(totalamout1 /= 2);

            //}
            ////else
            ////{
            //    double totalamout = 0, downpayment = 0, balance = 0, servc = 0, downval = 0;
            //    PaymentDownPayment.Enabled = true;
            //    totalamout = Convert.ToDouble(TotalAmtTxt.Text);
            double downval = Convert.ToDouble(PaymentTotal.Text);
            //    downval /= 2;
            //    PaymentDownPayment.Text = Convert.ToString(downval);
            //    if (PaymentDownPayment.Text == "")
            //        downpayment = 0;
            //    else
            //        downpayment = Convert.ToDouble(PaymentDownPayment.Text);

            //    if (PaymentService.Text == "")
            //        servc = 0;
            //    else
            //        servc = Convert.ToDouble(PaymentService.Text);

            //    balance = totalamout - downpayment;
            PaymentDownPayment.Text = Convert.ToString(downval /= 2);
            //    PaymentTotal.Text = Convert.ToString(totalamout + servc);
            //}
        }

        private void PaymentDownPayment_TextChanged(object sender, EventArgs e)
        {
            double total = 0, amt1 = 0, down = 0;



            try
            {
                amt1 = Convert.ToDouble(PaymentTotal.Text);
                down = Convert.ToDouble(PaymentDownPayment.Text);
                if (down > amt1)
                {
                    PaymentDownPayment.Text = "";
                }
                //else if (down < amt)
                //{
                //    PaymentDownPayment.Text = "";

                //}
                else
                {
                    total = amt1 - down;
                    PaymentBalance.Text = Convert.ToString(total);
                }
            }
            catch
            {
                PaymentDownPayment.Text = "";
            }

        }

        private void fullRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            payans = 1;
            PaymentDownPayment.Text = "0";
            PaymentDownPayment.Enabled = false;
            PaymentBalance.Text = "0";
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            double totam = Convert.ToDouble(totalAmtLbl.Text);
            if (totam > 0)
            {
                TotalAmtTxt.Text = totalAmtLbl.Text;
                Overalltxt.Text = totalAmtLbl.Text;
                PaymentGBox.Visible = true;
                OrderingTab.SelectedTab = Paymentpage;
                payBoxMsg.Visible = false;
                OrderProdID.Text = "";
                CatName.Text = "";
                SubCat.Text = "";
                SpecificCat.Text = "";
                OrderProdName.Text = "";
                colortxt.Text = "";
                SupplierTxt.Text = "";
                SizeTxt.Text = "";
                qtyOrTxt.Text = "";
                Widthtxt.Text = "";
                Heighttxt.Text = "";
                Typetxt.Text = "";
                OrderStatus.Text = "";
                OrderStock.Text = "";
                unitTxt.Text = "";
                OrderUnitPrice.Text = "";
                OrderQty.Text = "";
                OrderSubcost.Text = "";
                OrderQty.Enabled = false;
            }
            else
            {
                MessageBox.Show("Cannot proceed to payment without any item to pay.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                OrderProdID.Text = "";
                CatName.Text = "";
                SubCat.Text = "";
                SpecificCat.Text = "";
                OrderProdName.Text = "";
                colortxt.Text = "";
                SupplierTxt.Text = "";
                SizeTxt.Text = "";
                qtyOrTxt.Text = "";
                Widthtxt.Text = "";
                Heighttxt.Text = "";
                Typetxt.Text = "";
                OrderStatus.Text = "";
                OrderStock.Text = "";
                unitTxt.Text = "";
                OrderUnitPrice.Text = "";
                OrderQty.Text = "";
                OrderSubcost.Text = "";
                OrderQty.Enabled = false;

            }
        }

        private void PaymentTotal_TextChanged(object sender, EventArgs e)
        {


            double down = Convert.ToDouble(PaymentTotal.Text);

            PaymentDownPayment.Text = Convert.ToString(down /= 2);
        }

        private void EditQtyTxt_Click(object sender, EventArgs e)
        {

            int qtytest = Convert.ToInt32(OrderQty.Text);
            if (qtytest <= 0)
            {
                MessageBox.Show("Cannot update quantity item into 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OrderQty.Text = "";
                OrderQty.Focus();
            }
            else
            {
                if (bg == 1)
                {
                    double qtyitem = 0;
                    double totor = 0, totst = 0;


                    double backord = 0;
                    SqlCommand cmd221 = new SqlCommand("Select * from Inventory where [Item ID]=" + "'" + OrderProdID.Text.Trim() + "'", conn);
                    SqlDataReader dr221 = cmd221.ExecuteReader();
                    while (dr221.Read())
                    {
                        totst = Convert.ToDouble(dr221["Quantity in Stock"].ToString());

                        totor = Convert.ToDouble(dr221["Quantity in Order"].ToString());
                        backord = Convert.ToDouble(dr221["Back Order"].ToString());

                    }
                    dr221.Close();


                    double boitem = 0;
                    SqlCommand cmd55 = new SqlCommand("Select * from Item where [Item Number]=" + "'" + Convert.ToString(itemNum) + "'", conn);
                    SqlDataReader dr55 = cmd55.ExecuteReader();
                    while (dr55.Read())
                    {
                        boitem = Convert.ToDouble(dr55["Back Order"].ToString());


                    }
                    dr55.Close();
                    qtyitem = Convert.ToInt32(OrderQty.Text.Trim());

                    //deducting qty in inventory and adding it to qty in order
                    double upqty = Convert.ToDouble(qtyitem) - Convert.ToDouble(orqty);


                    if (upqty > 0)
                    {
                        totst -= upqty;

                        if (totst < 0)
                        {

                            backord = backord - totst;
                            boitem = 0 - totst;

                            totor += upqty - boitem;
                            totst = 0;

                        }
                        else
                        {
                            totor += upqty;

                        }
                    }
                    else
                    {
                        double WBOInv = 0, WBOItem = 0;
                        WBOInv = backord + upqty;

                        if (WBOInv > 0)
                        {
                            backord = WBOInv;



                            WBOItem = boitem + upqty;
                            if (WBOItem < 0)
                                boitem = 0;
                            else
                                boitem = WBOItem;

                        }
                        else
                        {

                            backord = 0;
                            boitem = 0;
                            totor += WBOInv;
                            totst -= WBOInv;

                        }

                    }



                    SqlCommand cmd25 = new SqlCommand("update Item set [Back Order] =" + "'" + Convert.ToString(boitem) + "'" + "where [COF Number] =" + "'" + COFlabel.Text + "'" + "AND [Item ID]=" + "'" + OrderProdID.Text + "'", conn);
                    cmd25.ExecuteNonQuery();





                    if (backord > 0)
                        MessageBox.Show("Please reorder some of your items from your supplier to accodomodate the orders.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    BalloonKingdomDataSetTableAdapters.InventoryTableAdapter backorder = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                    backorder.UpdateBackOrder(Convert.ToInt32(backord), Convert.ToInt32(OrderProdID.Text), Convert.ToInt32(OrderProdID.Text));




                    BalloonKingdomDataSetTableAdapters.InventoryTableAdapter upditem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                    upditem.UpdateInvItem(Convert.ToDecimal(totst), Convert.ToDecimal(totor), Convert.ToInt32(OrderProdID.Text), Convert.ToInt32(OrderProdID.Text));


                    BalloonKingdomDataSetTableAdapters.ItemTableAdapter editQty = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.ItemTableAdapter();
                    editQty.UpdateItemQty(Convert.ToInt32(OrderQty.Text.Trim()), Convert.ToDecimal(OrderUnitPrice.Text.Trim()), Convert.ToDecimal(OrderSubcost.Text.Trim()), itemNum);
                    MessageBox.Show("Successfully updated the quantity", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BalloonKingdomDataSetTableAdapters.ItemTableAdapter showItem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.ItemTableAdapter();
                    CartdataGridView.DataSource = showItem.ShowItems(Convert.ToInt32(COFlabel.Text));

                    BalloonKingdomDataSetTableAdapters.InventoryTableAdapter getData = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                    orderandrentdatagrid.DataSource = getData.GetAllInventoryRec();
                    ordersearchtxt.Text = OrderProdID.Text;
                    AddItembtn.Enabled = false;
                    Removeitembtn.Enabled = false;
                    order = 0;
                    rent = 0;
                    totalitem = 0;
                    totamt = 0;
                    totqty = 0;
                    SqlCommand cmd57 = new SqlCommand("Select * from Item where [COF Number]=" + "'" + COFlabel.Text + "'", conn);
                    SqlDataReader dr57 = cmd57.ExecuteReader();
                    while (dr57.Read())
                    {

                        if (dr57["Type"].ToString() == "Ordering")
                        {
                            order++;
                        }
                        else
                        {
                            rent++;
                        }
                        totalitem++;
                        totamt += Convert.ToDouble(dr57["Sub Cost"].ToString());

                        totqty += Convert.ToInt32(dr57["Quantity"].ToString());

                    }
                    dr57.Close();


                    rentLbl.Text = Convert.ToString(rent);
                    orderLbl.Text = Convert.ToString(order);
                    totalItemlbl.Text = Convert.ToString(totalitem);
                    totalAmtLbl.Text = Convert.ToString(totamt);
                    TotalAmtTxt.Text = Convert.ToString(totamt);
                    PaymentTotal.Text = Convert.ToString(totamt);
                    serbtn.Checked = false;
                    totqtytxt.Text = Convert.ToString(totqty);
                }
                BalloonKingdomDataSetTableAdapters.ItemTableAdapter view = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.ItemTableAdapter();
                CartdataGridView.DataSource = view.ViewCartCOF1(Convert.ToInt32(COFlabel.Text));

                OrderProdID.Text = "";
                CatName.Text = "";
                SubCat.Text = "";
                SpecificCat.Text = "";
                OrderProdName.Text = "";
                colortxt.Text = "";
                SupplierTxt.Text = "";
                SizeTxt.Text = "";
                qtyOrTxt.Text = "";
                Widthtxt.Text = "";
                Heighttxt.Text = "";
                Typetxt.Text = "";
                OrderStatus.Text = "";
                OrderStock.Text = "";
                unitTxt.Text = "";
                OrderUnitPrice.Text = "";
                OrderQty.Text = "";
                OrderSubcost.Text = "";
                OrderQty.Enabled = false;
            }

        }

        private void orderandrentdatagrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            bg = 0;
            OrderQty.Text = "";
            AddItembtn.Enabled = true;

            Removeitembtn.Enabled = false;
            SizeTxt.Text = orderandrentdatagrid.SelectedRows[0].Cells[6].Value.ToString();
            SupplierTxt.Text = orderandrentdatagrid.SelectedRows[0].Cells[17].Value.ToString();
            OrderProdID.Text = orderandrentdatagrid.SelectedRows[0].Cells[0].Value.ToString();
            invitemnum = Convert.ToInt32(orderandrentdatagrid.SelectedRows[0].Cells[0].Value.ToString());
            OrderProdName.Text = orderandrentdatagrid.SelectedRows[0].Cells[4].Value.ToString();
            SubCat.Text = orderandrentdatagrid.SelectedRows[0].Cells[2].Value.ToString();
            Typetxt.Text = orderandrentdatagrid.SelectedRows[0].Cells[5].Value.ToString();
            OrderStatus.Text = orderandrentdatagrid.SelectedRows[0].Cells[13].Value.ToString();
            OrderStock.Text = orderandrentdatagrid.SelectedRows[0].Cells[11].Value.ToString();
            OrderUnitPrice.Text = orderandrentdatagrid.SelectedRows[0].Cells[10].Value.ToString();
            CatName.Text = orderandrentdatagrid.SelectedRows[0].Cells[1].Value.ToString();
            //SubCat.Text = InvDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            SpecificCat.Text = orderandrentdatagrid.SelectedRows[0].Cells[3].Value.ToString();
            colortxt.Text = orderandrentdatagrid.SelectedRows[0].Cells[14].Value.ToString();
            Widthtxt.Text = orderandrentdatagrid.SelectedRows[0].Cells[15].Value.ToString();
            Heighttxt.Text = orderandrentdatagrid.SelectedRows[0].Cells[16].Value.ToString();
            unitTxt.Text = orderandrentdatagrid.SelectedRows[0].Cells[8].Value.ToString();
            qtyOrTxt.Text = orderandrentdatagrid.SelectedRows[0].Cells[12].Value.ToString();
            stockorder = Convert.ToDouble(orderandrentdatagrid.SelectedRows[0].Cells[11].Value.ToString());
            OrderQty.Enabled = true;
            OrderQty.Focus();
            backorinvlbl.Text = orderandrentdatagrid.SelectedRows[0].Cells[20].Value.ToString();
        }

        private void SearchDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            COForderlinetxt.Text = OrderlineDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            ORCustID.Text = "";
            ORCustID.Text = OrderlineDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            DateOfOrdertxt.Text = OrderlineDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            ORLbl.Text = OrderlineDataGrid.SelectedRows[0].Cells[18].Value.ToString();
            Fnameorderlinetxt.Text = OrderlineDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            MidNameOLTxt.Text = OrderlineDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            LNOrderLineTxt.Text = OrderlineDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            EventDateOLTxt.Text = OrderlineDataGrid.SelectedRows[0].Cells[6].Value.ToString();
            ThemeOLTxt.Text = OrderlineDataGrid.SelectedRows[0].Cells[8].Value.ToString();
            EventTimePickOL.Text = OrderlineDataGrid.SelectedRows[0].Cells[7].Value.ToString();
            ORMotifTxt.Text = OrderlineDataGrid.SelectedRows[0].Cells[9].Value.ToString();
            VenueOLTxt.Text = OrderlineDataGrid.SelectedRows[0].Cells[10].Value.ToString();
            ORVATAmtTxt.Text = OrderlineDataGrid.SelectedRows[0].Cells[22].Value.ToString();
            ORDiscountTxt.Text = OrderlineDataGrid.SelectedRows[0].Cells[19].Value.ToString();
            PORefAmtTxt.Text = OrderlineDataGrid.SelectedRows[0].Cells[21].Value.ToString();
            PayStatLbl.Text = OrderlineDataGrid.SelectedRows[0].Cells[17].Value.ToString();
            OrOrAmttxt.Text = OrderlineDataGrid.SelectedRows[0].Cells[12].Value.ToString();
            OrBaltxt.Text = OrderlineDataGrid.SelectedRows[0].Cells[11].Value.ToString();
            OrServicetxt.Text = OrderlineDataGrid.SelectedRows[0].Cells[15].Value.ToString();
            OrDowntxt.Text = OrderlineDataGrid.SelectedRows[0].Cells[13].Value.ToString();
            OrFulltxt.Text = OrderlineDataGrid.SelectedRows[0].Cells[14].Value.ToString();
            TotAmtOLLbl.Text = OrderlineDataGrid.SelectedRows[0].Cells[16].Value.ToString();
            POOveAllLbl.Text = OrderlineDataGrid.SelectedRows[0].Cells[20].Value.ToString();


        }

        private void COForderlinetxt_TextChanged(object sender, EventArgs e)
        {
            if (COForderlinetxt.Text != "")
            {
                BalloonKingdomDataSetTableAdapters.ItemTableAdapter showOrderItem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.ItemTableAdapter();
                ItemDataGrid.DataSource = showOrderItem.ShowItems(Convert.ToInt32(COForderlinetxt.Text));
                order = 0;
                rent = 0;
                totalitem = 0;
                totamt = 0;
                totqty = 0;
                SqlCommand cmd57 = new SqlCommand("Select * from Item where [COF Number]=" + "'" + COForderlinetxt.Text + "'", conn);
                SqlDataReader dr57 = cmd57.ExecuteReader();
                while (dr57.Read())
                {

                    if (dr57["Type"].ToString() == "Ordering")
                    {
                        order++;
                    }
                    else
                    {
                        rent++;
                    }
                    totalitem++;
                    totamt += Convert.ToDouble(dr57["Sub Cost"].ToString());

                    totqty += Convert.ToInt32(dr57["Quantity"].ToString());

                }
                dr57.Close();


                RentOLLbl.Text = Convert.ToString(rent);
                OrderOLLbl.Text = Convert.ToString(order);
                TotItemOLLbl.Text = Convert.ToString(totalitem);
                TotAmtOLLbl.Text = Convert.ToString(totamt);
                QtyOLLbl.Text = Convert.ToString(totqty);
            }
        }


        private void ProcessOrderBtn_Click(object sender, EventArgs e)
        {
            int ans45 = Convert.ToInt32(MessageBox.Show("Are you sure you want to place this order?","Placing an order",MessageBoxButtons.YesNo,MessageBoxIcon.Question));
            if (ans45 == 6)
            {
                string OR = "No", status, ans = "";
                double downpay = 0, fullpay = 0, servc = 0;
                if (PaymentDownPayment.Text == "")
                {
                    downpay = 0;
                    ans = "yes";


                }
                else if (Convert.ToDouble(PaymentDownPayment.Text) < (Convert.ToDouble(TotalAmtTxt.Text) / 2))
                {

                    ans = "no";

                }
                else
                    downpay = Convert.ToDouble(PaymentDownPayment.Text);




                if (orbtn.Checked == true)
                {
                    OR = "Yes"; ans = "yes";
                    ORLbl.Text = "Yes";
                }
                else
                    ORLbl.Text = "No";
                if (fullRadioBtn.Checked == true)
                {
                    fullpay = Convert.ToDouble(PaymentTotal.Text);
                    PaymentBalance.Text = "0";
                    status = "Pending";
                    ans = "yes";
                    OrFulltxt.Text = "0";

                }
                else
                {
                    fullpay = 0;
                    status = "Pending";
                    ans = "yes";

                }

                if (ans != "no")
                {
                    SqlCommand cmdor = new SqlCommand("Select [Official Receipt] from Orderline where [COF Number]=" + "'" + COFlabel.Text + "'", conn);
                    string orans = Convert.ToString(cmdor.ExecuteScalar());
                    if(orans=="Yes")
                    {
                    
                        SqlCommand uporamt = new SqlCommand("update [Official Receipt] set [Order Amount]="+"'"+TotalAmtTxt.Text+"'"+","+"[Service Charge]="+"'"+SerTxt.Text+"'"+","+"[Total]="+"'"+Overalltxt.Text+"'"+","+"[VAT Amount]="+"'"+VATAmttxt.Text+"'"+","+"[Vat Percentage]="+"'"+VATPercenttxt.Text+"'",conn);
                        uporamt.ExecuteNonQuery();
                        MessageBox.Show("Official Receipt record has been updated with the new amount of order.","Official Receipt Update",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                    if (orbtn.Checked == true)
                    {
                        string COFN, VATPer, VATAmt, SerCh, Tot, OrderAmt;
                        COFN = COFlabel.Text;
                        SerCh = SerTxt.Text;
                        VATPer = VATPercenttxt.Text;
                        VATAmt = VATAmttxt.Text;
                        Tot = PaymentTotal.Text;
                        OrderAmt = TotalAmtTxt.Text;
                        frmOR showOR = new frmOR(COFN, VATPer, VATAmt, SerCh, Tot, OrderAmt, syspass);
                        showOR.ShowDialog();

                      

                    }
                    else
                    {
                        string COFN1, SerCh1, Tot1, OrderAmt1;
                        COFN1 = COFlabel.Text;

                        Tot1 = PaymentTotal.Text;
                        OrderAmt1 = TotalAmtTxt.Text;

                        String id;
                        int a = 0, id2;


                        SqlCommand cmd21 = new SqlCommand("Select * from Invoice", conn);
                        SqlDataReader dr21 = cmd21.ExecuteReader();
                        while (dr21.Read())
                        {
                            id = dr21["Invoice ID"].ToString();
                            id2 = Convert.ToInt32(id);
                            if (a < id2)
                                a = id2;


                        }
                        dr21.Close();
                        a++;

                        SerCh1 = SerTxt.Text;
                        BalloonKingdomDataSetTableAdapters.InvoiceTableAdapter addinvoice = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InvoiceTableAdapter();
                        addinvoice.AddInvoice(a, Convert.ToInt32(COFN1), DateTime.Today, DateTime.Today, Convert.ToDecimal(OrderAmt1), Convert.ToDecimal(SerCh1), Convert.ToDecimal(Tot1));


                    }}
                    BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter processOrdering = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                    processOrdering.PlacingOrder(Convert.ToDecimal(PaymentBalance.Text.Trim()), Convert.ToDecimal(TotalAmtTxt.Text.Trim()), Convert.ToDecimal(PaymentDownPayment.Text.Trim()), Convert.ToDecimal(fullpay), Convert.ToDecimal(SerTxt.Text.Trim()), Convert.ToDecimal(TotalAmtTxt.Text.Trim()), "Pending", OR, Convert.ToDecimal(DisAmttxt.Text.Trim()), Convert.ToDecimal(Overalltxt.Text.Trim()), Convert.ToDecimal(VATAmttxt.Text.Trim()), Convert.ToDecimal(VATPercenttxt.Text.Trim()), Convert.ToInt32(COFlabel.Text.Trim()), Convert.ToInt32(COFlabel.Text));

                    {
                        string co = Convert.ToString(COFlabel.Text);
                        COF_Printing coff = new COF_Printing(co);
                        coff.ShowDialog();


                        //MessageBox.Show("You choose invoice rather than official receipt. This invoice is successully generated and stored.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                    MessageBox.Show("Successfully Placed the order. View the orderline to see the status of the order created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OrDowntxt.Text = Convert.ToString(downpay);
                    OrServicetxt.Text = Convert.ToString(servc);
                    OrderOLLbl.Text = Convert.ToString(order);
                    RentOLLbl.Text = Convert.ToString(rent);
                    TotItemOLLbl.Text = Convert.ToString(totalitem);
                    TotAmtOLLbl.Text = Convert.ToString(totamt);
                    QtyOLLbl.Text = Convert.ToString(totqty);
                    PayStatLbl.Text = status;
                    ORMotifTxt.Text = ColorMotifCombo.Text;
                    ORCustID.Text = CustIDlabel.Text;



                    OrderingPanel.Visible = false;
                    Orderpanel.Visible = true;
                    BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter ViewOrderlinerec = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                    OrderlineDataGrid.DataSource = ViewOrderlinerec.ViewOrderline();
                    CustOrderbtn.Visible = true;
                    orderlabel.Visible = true;
                    CustActLbl.Text = fn + " " + mi + ". " + ln + " had finished ordering";
                    //transfering
                    COForderlinetxt.Text = COFlabel.Text;
                    DateOfOrdertxt.Value = DateofOrderPick.Value;
                    Fnameorderlinetxt.Text = FirstNameLbl.Text;
                    MidNameOLTxt.Text = MiddleInitialLbl.Text;
                    LNOrderLineTxt.Text = LastNameLbl.Text;
                    EventDateOLTxt.Value = DateOfEventPick.Value;
                    ThemeOLTxt.Text = COFThemetxt.Text;
                    EventTimePickOL.Value = timepick.Value;
                    VenueOLTxt.Text = COFVenuetxt.Text;
                    OrOrAmttxt.Text = TotalAmtTxt.Text;
                    OrBaltxt.Text = PaymentBalance.Text;
                    if (downRadiobtn.Checked == true)
                    {
                        OrDowntxt.Text = PaymentDownPayment.Text;
                        OrFulltxt.Text = "";
                    }
                    else
                    {
                        OrFulltxt.Text = PaymentTotal.Text;
                    }
                    CartBoxMsg.Visible = true;
                    CartGBox.Visible = false;
                    PaymentGBox.Visible = false;
                    payBoxMsg.Visible = true;
                    DateofOrderPick.Value = DateTime.Today;
                    DateofOrderPick.Enabled = true;
                    DateOfEventPick.Value = DateTime.Today;
                    DateOfEventPick.Enabled = true;
                    DateOfEventPick.Enabled = true;
                    timepick.Value = DateTime.Today;
                    timepick.Enabled = true;
                    COFThemetxt.Text = "";
                    COFThemetxt.Enabled = true;
                    ColorMotifCombo.Text = "";
                    ColorMotifCombo.Enabled = true;
                    COFVenuetxt.Text = "";
                    COFVenuetxt.Enabled = true;
                    NextORBtn.Visible = true;
                    CancelORBtn.Visible = true;
                    OrderProdID.Text = "";
                    CatName.Text = "";
                    SubCat.Text = "";
                    SpecificCat.Text = "";
                    OrderProdName.Text = "";
                    colortxt.Text = "";
                    SupplierTxt.Text = "";
                    SizeTxt.Text = "";
                    qtyOrTxt.Text = "";
                    Widthtxt.Text = "";
                    Heighttxt.Text = "";
                    Typetxt.Text = "";
                    OrderStatus.Text = "";
                    OrderStock.Text = "";
                    unitTxt.Text = "";
                    OrderUnitPrice.Text = "";
                    OrderQty.Text = "";
                    OrderSubcost.Text = "";
                    OrderQty.Enabled = false;

                    OrderingTab.SelectedTab = COFpage;
                    custOrdering = 0;
                    customerSearchtxt.Text = "";
                    Searchordertxt.Text = COFlabel.Text;

                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter ViewOrderlinerec = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
            OrderlineDataGrid.DataSource = ViewOrderlinerec.ViewOrderline();
        }

        private void Searchordertxt_TextChanged(object sender, EventArgs e)
        {
            if (Searchordertxt.Text != "")
            {
                try
                {
                    int a = Convert.ToInt32(Searchordertxt.Text);
                    BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter searchCOF = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                    OrderlineDataGrid.DataSource = searchCOF.SearchByCOF(a);

                    COForderlinetxt.Text = Convert.ToString(a);
                }
                catch
                {
                    Searchordertxt.Text = "";
                }
            }
            else
            {
                BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter ViewOrderlinerec = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                OrderlineDataGrid.DataSource = ViewOrderlinerec.ViewOrderline();
                ItemDataGrid.DataSource = "none";
            }
        }









        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            string ans = "";
            SqlCommand cmdpass = new SqlCommand("Select * from Security", conn);
            SqlDataReader drpass = cmdpass.ExecuteReader();
            while (drpass.Read())
            {
                if (username == drpass["Username"].ToString() && passtxt1.Text.Trim() == drpass["Password"].ToString())
                {
                    ans = "True";
                }


            }
            drpass.Close();
            if (ans == "True" && passtxt2.Text==conpasstxt.Text)
            {
                BalloonKingdomDataSetTableAdapters.SecurityTableAdapter changepass = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.SecurityTableAdapter();
                changepass.UpdatePassword(passtxt2.Text.Trim(), username, username);
                notibox.Visible = true;
                MessageBox.Show("You have successfully changed your password.", "Transaction succeed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
         
                NotiLbl.Text = "Successfully changed the password.";
                passtxt1.Text = "";
                passtxt2.Text = "";
                conpasstxt.Text = "";
            }
            else if (conpasstxt.Text.Trim() != passtxt2.Text)
            {
                MessageBox.Show("Wrong Password Confirmation", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                notibox.Visible = true;
                NotiLbl.Text = "Make sure that your new password is correct or maybe you are in Caps Lock Mode. Please try again.";
                passtxt1.Text = "";
                passtxt2.Text = "";

                conpasstxt.Text = "";
            }
            else if(passtxt1.Text.Trim()=="" || passtxt2.Text.Trim()=="" || conpasstxt.Text=="")
            {
                MessageBox.Show("Fill up the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                notibox.Visible = true;
                NotiLbl.Text = "Please fill up the required field.";
                passtxt1.Text = "";
                passtxt2.Text = "";

                conpasstxt.Text = "";
            
            }
            else
            {
                MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                notibox.Visible = true;
                NotiLbl.Text = "Attempted to change the Password but failed.";
                passtxt1.Text = "";
                passtxt2.Text = "";
                conpasstxt.Text = "";

            }
        }

        private void AdminToolStrip_Click(object sender, EventArgs e)
        {
            OrderingPanel.Visible = false;
            Supplierpanel.Visible = false;
            Orderpanel.Visible = false;
            CustomerPanel.Visible = false;
            Inventorypanel.Visible = false;
            SecurityPanel.Visible = true;
            PurchasingPanel.Visible = false;
            BackgndPanel.Visible = false;
            ReturnRentPanel.Visible = false;
        }

        private void OrderSearchBtn_Click_1(object sender, EventArgs e)
        {
            BalloonKingdomDataSetTableAdapters.InventoryTableAdapter getData = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
            orderandrentdatagrid.DataSource = getData.GetAllInventoryRec();
            OrderProdID.Text = "";
            CatName.Text = "";
            SubCat.Text = "";
            SpecificCat.Text = "";
            OrderProdName.Text = "";
            colortxt.Text = "";
            SupplierTxt.Text = "";
            SizeTxt.Text = "";
            qtyOrTxt.Text = "";
            Widthtxt.Text = "";
            Heighttxt.Text = "";
            Typetxt.Text = "";
            OrderStatus.Text = "";
            OrderStock.Text = "";
            unitTxt.Text = "";
            OrderUnitPrice.Text = "";
            OrderQty.Text = "";
            OrderSubcost.Text = "";
            OrderQty.Enabled = false;

        }

        private void OLClearBtn_Click(object sender, EventArgs e)
        {
            ORLbl.Text = "None";
            QtyOLLbl.Text = "None";
            PayStatLbl.Text = "None";
            TotItemOLLbl.Text = "None";
            RentOLLbl.Text = "None";
            OrderOLLbl.Text = "None";
            TotAmtOLLbl.Text = "None";
            POOveAllLbl.Text = "None";
            Searchordertxt.Text = "";
            DateOfOrdertxt.Value = DateTime.Today;
            Fnameorderlinetxt.Text = "";
            MidNameOLTxt.Text = "";
            LNOrderLineTxt.Text = "";
            EventDateOLTxt.Value = DateTime.Today;
            ThemeOLTxt.Text = "";
            EventTimePickOL.Value = DateTime.Today;
            VenueOLTxt.Text = "";
            COForderlinetxt.Text = "";
            ORCustID.Text = "";
            OrOrAmttxt.Text = "";
            OrBaltxt.Text = "";
            OrServicetxt.Text = "";
            PORefAmtTxt.Text = "";
            OrDowntxt.Text = "";
            OrFulltxt.Text = "";
            TotAmtOLLbl.Text = "None";
            ORMotifTxt.Text = "";
            ORVATAmtTxt.Text = "";
            ORDiscountTxt.Text = "";
        }

        private void Removeitembtn_Click(object sender, EventArgs e)
        {


            double av = 0, or = 0; int boinv = 0;



            SqlCommand cmd221 = new SqlCommand("Select * from Inventory where [Item ID]=" + "'" + OrderProdID.Text.Trim() + "'", conn);
            SqlDataReader dr221 = cmd221.ExecuteReader();
            while (dr221.Read())
            {
                av = Convert.ToDouble(dr221["Quantity in Stock"].ToString());

                or = Convert.ToDouble(dr221["Quantity in Order"].ToString());
                boinv = Convert.ToInt32(dr221["Back Order"].ToString());

            }
            dr221.Close();

            int quanti = Convert.ToInt32(orqty);


            int boitem = 0;
            SqlCommand cmd55 = new SqlCommand("Select * from Item where [Item Number]=" + "'" + Convert.ToString(itemNum) + "'", conn);
            SqlDataReader dr55 = cmd55.ExecuteReader();
            while (dr55.Read())
            {
                boitem = Convert.ToInt32(dr55["Back Order"].ToString());


            }
            dr55.Close();

            int tot = 0;
            if (boitem > 0)
            {
                tot = orqty - boitem;
                boinv -= boitem;
                or -= tot;
                av += tot;



            }

            else
            {
                or = or - orqty;
                av += Convert.ToDouble(orqty);

            }


            boitem = 0;



            BalloonKingdomDataSetTableAdapters.InventoryTableAdapter backorder = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
            backorder.UpdateBackOrder(boinv, Convert.ToInt32(OrderProdID.Text), Convert.ToInt32(OrderProdID.Text));

            SqlCommand cmd25 = new SqlCommand("update Item set [Back Order] =" + "'" + Convert.ToString(boitem) + "'" + " where [COF Number] =" + "'" + COFlabel.Text + "'" + "AND [Item ID]=" + "'" + OrderProdID.Text + "'", conn);
            cmd25.ExecuteNonQuery();




            BalloonKingdomDataSetTableAdapters.InventoryTableAdapter upditem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
            upditem.UpdateInvItem(Convert.ToInt32(av), Convert.ToInt32(or), Convert.ToInt32(OrderProdID.Text), Convert.ToInt32(OrderProdID.Text));
            Removeitembtn.Enabled = false;

            BalloonKingdomDataSetTableAdapters.InventoryTableAdapter getData = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
            orderandrentdatagrid.DataSource = getData.GetAllInventoryRec();

            BalloonKingdomDataSetTableAdapters.ItemTableAdapter deleteItem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.ItemTableAdapter();
            deleteItem.DeleteCartItem(Convert.ToInt32(COFlabel.Text.Trim()), Convert.ToInt32(OrderProdID.Text.Trim()));

            BalloonKingdomDataSetTableAdapters.ItemTableAdapter view = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.ItemTableAdapter();
            CartdataGridView.DataSource = view.ViewCartCOF1(Convert.ToInt32(COFlabel.Text));
            order = 0;
            rent = 0;
            totalitem = 0;
            totamt = 0;
            totqty = 0;
            SqlCommand cmd57 = new SqlCommand("Select * from Item where [COF Number]=" + "'" + COFlabel.Text + "'", conn);
            SqlDataReader dr57 = cmd57.ExecuteReader();
            while (dr57.Read())
            {

                if (dr57["Type"].ToString() == "Ordering")
                {
                    order++;
                }
                else
                {
                    rent++;
                }
                totalitem++;
                totamt += Convert.ToDouble(dr57["Sub Cost"].ToString());
                totqty += Convert.ToInt32(dr57["Quantity"].ToString());


            }
            dr57.Close();
            if (totamt == 0)
            {
                payBoxMsg.Visible = true;
                PaymentGBox.Visible = false;
            }
            else
            {
                payBoxMsg.Visible = false;
                PaymentGBox.Visible = true;
            }


            rentLbl.Text = Convert.ToString(rent);
            orderLbl.Text = Convert.ToString(order);
            totalItemlbl.Text = Convert.ToString(totalitem);
            totalAmtLbl.Text = Convert.ToString(totamt);
            TotalAmtTxt.Text = Convert.ToString(totamt);

            totqtytxt.Text = Convert.ToString(totqty);

            PaymentTotal.Text = Convert.ToString(totamt);
            serbtn.Checked = false;
            OrderProdID.Text = "";
            CatName.Text = "";
            SubCat.Text = "";
            SpecificCat.Text = "";
            OrderProdName.Text = "";
            colortxt.Text = "";
            SupplierTxt.Text = "";
            SizeTxt.Text = "";
            qtyOrTxt.Text = "";
            Widthtxt.Text = "";
            Heighttxt.Text = "";
            Typetxt.Text = "";
            OrderStatus.Text = "";
            OrderStock.Text = "";
            unitTxt.Text = "";
            OrderUnitPrice.Text = "";
            OrderQty.Text = "";
            OrderSubcost.Text = "";
            OrderQty.Enabled = false;

            ordersearchtxt.Text = OrderProdID.Text;

        }

        private void PurchaseBtn_Click(object sender, EventArgs e)
        {

            PurSuppNameCombo.Items.Clear();
            string[] sup = new string[5000];
            int a = 0;
            SqlCommand cmdsup = new SqlCommand("Select distinct Supplier from Inventory where [Back Order]>0", conn);
            SqlDataReader drsup = cmdsup.ExecuteReader();
            while (drsup.Read())
            {
                sup[a] = drsup["Supplier"].ToString();
                a++;
            }


            drsup.Close();
            for (int b = 0; b < a; b++)
            {
                if (sup[b] != "")
                    PurSuppNameCombo.Items.Add(sup[b]);

            }
            PurSuppNameCombo.Text = sup[1];
            PurchasingPanel.Visible = true;
            BackOrderDataGrid.Enabled = false;
            OrderingPanel.Visible = false;
            CustomerPanel.Visible = false;
            Inventorypanel.Visible = false;
            Orderpanel.Visible = false;
            Supplierpanel.Visible = false;
            SecurityPanel.Visible = false;
            BackgndPanel.Visible = false;
            ReturnRentPanel.Visible = false;
            PurSuppIDtxt.Text = "";
PurContxt.Text = "";
PurAddtxt.Text = "";
            PurItemIDtxt.Text = "";
            PurCatNametxt.Text = "";
            PurSpecCattxt.Text = "";
            PurSubCattxt.Text = "";
            PurItemNametxt.Text = "";
            PurSizetxt.Text = "";
            PurtTypetxt.Text = "";
            PurColortxt.Text = "";
            PurHeighttxt.Text = "";
            PurQtyStocktxt.Text = "";
            PurWidthtxt.Text = "";
            PurQtytxt.Text = "";
            PurUnitText.Text = "";
            PurUnitPricetxt.Text = "";
            UnitPrceTxt.Text = "";
            PurFilterSupcomb.Text = "With Back Order";
            PurFilterSupcomb.Enabled = true;
PurSuppNameCombo.Enabled = true;
POChooseSupbtn.Enabled = true;
        }

        private void CreatePOPic_Click(object sender, EventArgs e)
        {
            CreatePOPanel.Visible = true;
            ReceivedPOPanel.Visible = false;
            ViewPOPanel.Visible = false;
            ReturnRentPanel.Visible = false;
        }

        private void ReceivedPOPic_Click(object sender, EventArgs e)
        {
            CreatePOPanel.Visible = false;
            ReceivedPOPanel.Visible = false;
            ViewPOPanel.Visible = true;
            ReturnRentPanel.Visible = false;
        }

        private void PurQtytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*1234567890".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void PurQtytxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                string txt;
                if (PurQtytxt.Text != "")
                {
                    txt = PurQtytxt.Text;
                    x = txt.Length - 1;

                    if (PurQtytxt.Text == "")
                    {
                        toolTip1.Show("Avoid special characters!", PurQtytxt);
                        PurQtytxt.Clear();
                        toolTip1.Hide(PurQtytxt);
                    }

                    else if (char.IsWhiteSpace(txt[x]))
                    {
                        PurQtytxt.Text = txt.Replace(txt[x], ' ');
                        toolTip1.Show("Avoid special characters!", PurQtytxt);
                        toolTip1.Hide(PurQtytxt);
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString(), "error");
            }

        }

        private void PurUnittxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                string txt;
                if (PurUnitPricetxt.Text != "")
                {
                    txt = PurUnitPricetxt.Text;
                    x = txt.Length - 1;

                    if (PurUnitPricetxt.Text == "")
                    {
                        toolTip1.Show("Avoid special characters!", PurUnitPricetxt);
                        PurUnitPricetxt.Clear();
                        toolTip1.Hide(PurUnitPricetxt);
                    }

                    else if (char.IsWhiteSpace(txt[x]))
                    {
                        PurUnitPricetxt.Text = txt.Replace(txt[x], ' ');
                        toolTip1.Show("Avoid special characters!", PurUnitPricetxt);
                        toolTip1.Hide(PurUnitPricetxt);
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString(), "error");
            }
        }

        private void PurUnittxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*1234567890.".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void PurDowntxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*1234567890.".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void PurDowntxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                string txt;
                if (PurDowntxt.Text != "")
                {
                    txt = PurDowntxt.Text;
                    x = txt.Length - 1;

                    if (PurDowntxt.Text == "")
                    {
                        toolTip1.Show("Avoid special characters!", PurDowntxt);
                        PurUnitPricetxt.Clear();
                        toolTip1.Hide(PurDowntxt);
                    }

                    else if (char.IsWhiteSpace(txt[x]))
                    {
                        PurDowntxt.Text = txt.Replace(txt[x], ' ');
                        toolTip1.Show("Avoid special characters!", PurDowntxt);
                        toolTip1.Hide(PurDowntxt);
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString(), "error");
            }
            double downpur = 0;

            try
            {
                downpur = Convert.ToDouble(PurDowntxt.Text.Trim());
                if (PurDowntxt.Text == "")
                    downpur = 0;
                else
                {
                    double balpur = Convert.ToDouble(PurBalLabel.Text);
                    double totamt = Convert.ToDouble(PurTotalLbl.Text);
                    double idealdown = totamt / 2;



                    if (downpur > totamt)
                    {
                        MessageBox.Show("You have entered amount greater than the total amout or less than 50% of the total order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        PurDowntxt.Text = "";
                        PurBalLabel.Text = Convert.ToString(idealdown);


                    }
                    else
                    {

                        double totbal = balpur - downpur;
                        PurBalLabel.Text = Convert.ToString(totbal);
                    }
                }

            }
            catch
            {


            }




        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            username = "Administrator";
            passbox.Text = "Change password of Administrator";
            passbox.Visible = true;
            notibox.Visible = false;

            passtxt1.Focus();
        }

        private void CustRepBtn_Click(object sender, EventArgs e)
        {

            username = "Customer Representative";

            passbox.Text = "Change password of Customer Representative";
            passbox.Visible = true;

            notibox.Visible = false;

            passtxt1.Focus();
        }

        private void SupContBtn_Click(object sender, EventArgs e)
        {
            username = "Supplies Controller";

            passbox.Text = "Change password of Supplier Controller";
            passbox.Visible = true;

            notibox.Visible = false;

            passtxt1.Focus();
        }

        private void GuestBtn_Click(object sender, EventArgs e)
        {
            username = "Guest";

            passbox.Text = "Change password of Guest";

            notibox.Visible = false;
            passbox.Visible = true;

            passtxt1.Focus();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Security showsecu = new Security();
            this.Hide();
            showsecu.ShowDialog();
            this.Close();
        }

        private void OrderQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*1234567890".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            string[] itemid = new string[3000];
            string[] backor = new string[3000];
            int a=0;
            SqlCommand getinv = new SqlCommand("Select * from Inventory", conn);
            SqlDataReader drgeti = getinv.ExecuteReader();
            while (drgeti.Read())
            { 
            
            itemid[a] = drgeti["Item ID"].ToString();
            backor[a] = drgeti["Back Order"].ToString();
                       a++;    
            }
            drgeti.Close();
            string avail = "";
            for(int b=0; b<=a; b++)
            {
            if(Convert.ToInt32(backor[b])>0)
                avail ="Out of Stock";
            else               
                avail = "Available";
              SqlCommand updinv = new SqlCommand("Update Inventory set Status="+"'"+avail+"'"+"where [Item ID]="+"'"+itemid[b]+"'",conn);
              updinv.ExecuteNonQuery();
            }
            BalloonKingdomDataSetTableAdapters.InventoryTableAdapter getAllInvData = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
            InvDataGrid.DataSource = getAllInvData.GetAllInventoryRec();

          
       
    }



       

 



        private void OrderCancelbtn_Click(object sender, EventArgs e)
        {
            int ans = Convert.ToInt16(MessageBox.Show("Are you sure that you want to cancel ordering? This ordering will not be saved. ", "Cancel!", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (ans == 6)
            {

                int[] id = new int[3000];
                int[] bo = new int[3000];
                int[] qty = new int[300];
                int a = 0;
                SqlCommand cmd321 = new SqlCommand("Select * from Item where [COF Number]=" + "'" + COFlabel.Text.Trim() + "'", conn);
                SqlDataReader dr321 = cmd321.ExecuteReader();
                while (dr321.Read())
                {

                    id[a] = Convert.ToInt32(dr321["Item ID"].ToString());
                    bo[a] = Convert.ToInt32(dr321["Back Order"].ToString());
                    qty[a] = Convert.ToInt32(dr321["Quantity"].ToString());
                    a++;
                }
                dr321.Close();
                double invst = 0, invor = 0, invbo = 0;
                for (int c = 0; c < a; c++)
                {

                    SqlCommand cmd111 = new SqlCommand("Select * from Inventory where [Item ID]=" + "'" + Convert.ToString(id[b]) + "'", conn);
                    SqlDataReader dr111 = cmd111.ExecuteReader();
                    while (dr111.Read())
                    {

                        invst = Convert.ToDouble(dr111["Quantity in Stock"].ToString());

                        invor = Convert.ToDouble(dr111["Quantity in Order"].ToString());
                        invbo = Convert.ToDouble(dr111["Back Order"].ToString());


                    }
                    dr111.Close();
                    int tot = 0;
                    if (bo[c] > 0)
                    {
                        tot = qty[c] - bo[c];
                        invbo -= bo[c];
                        invor -= tot;
                        invst += tot;


                    }
                    else
                    {
                        invor = invor - qty[c];
                        invst += Convert.ToDouble(qty[c]);

                    }

                    bo[c] = 0;

                    //update inv backorder
                    BalloonKingdomDataSetTableAdapters.InventoryTableAdapter backorder = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                    backorder.UpdateBackOrder(Convert.ToInt32(invbo), id[c], id[c]);



                    //update item back order
                    SqlCommand cmd25 = new SqlCommand("update Item set [Back Order] =" + "'" + Convert.ToString(bo[c]) + "'" + " where [COF Number] =" + "'" + COFlabel.Text + "'" + "AND [Item ID]=" + "'" + id[c] + "'", conn);
                    cmd25.ExecuteNonQuery();


                    //update inventory order and stock

                    BalloonKingdomDataSetTableAdapters.InventoryTableAdapter upditem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                    upditem.UpdateInvItem(Convert.ToInt32(invst), Convert.ToInt32(invor), id[c], id[c]);
                    Removeitembtn.Enabled = false;

                    //delete from item
                    BalloonKingdomDataSetTableAdapters.ItemTableAdapter deleteItem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.ItemTableAdapter();
                    deleteItem.DeleteCartItem(Convert.ToInt32(COFlabel.Text.Trim()), id[c]);


                    //elete COF
                    BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter deleteorder = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                    deleteorder.DeleteCOF(Convert.ToInt32(COFlabel.Text.Trim()));
                }



                OrderingPanel.Visible = false;
                Orderpanel.Visible = true;
                BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter ViewOrderlinerec = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                OrderlineDataGrid.DataSource = ViewOrderlinerec.ViewOrderline();
                CustOrderbtn.Visible = true;
                orderlabel.Visible = true;
                CustActLbl.Text = fn + " " + mi + ". " + ln + " had finished ordering";
                //transfering
                COForderlinetxt.Text = COFlabel.Text;
                DateOfOrdertxt.Value = DateofOrderPick.Value;
                Fnameorderlinetxt.Text = FirstNameLbl.Text;
                MidNameOLTxt.Text = MiddleInitialLbl.Text;
                LNOrderLineTxt.Text = LastNameLbl.Text;
                EventDateOLTxt.Value = DateOfEventPick.Value;
                ThemeOLTxt.Text = COFThemetxt.Text;
                EventTimePickOL.Value = timepick.Value;
                VenueOLTxt.Text = COFVenuetxt.Text;
                CartBoxMsg.Visible = true;
                CartGBox.Visible = false;
                PaymentGBox.Visible = false;
                payBoxMsg.Visible = true;
                DateofOrderPick.Value = DateTime.Today;
                DateofOrderPick.Enabled = true;
                DateOfEventPick.Value = DateTime.Today;
                DateOfEventPick.Enabled = true;
                DateOfEventPick.Enabled = true;
                timepick.Value = DateTime.Today;
                timepick.Enabled = true;
                COFThemetxt.Text = "";
                COFThemetxt.Enabled = true;
                ColorMotifCombo.Text = "";
                ColorMotifCombo.Enabled = true;
                COFVenuetxt.Text = "";
                COFVenuetxt.Enabled = true;
                NextORBtn.Visible = true;
                CancelORBtn.Visible = true;
                OrderProdID.Text = "";
                CatName.Text = "";
                SubCat.Text = "";
                SpecificCat.Text = "";
                OrderProdName.Text = "";
                colortxt.Text = "";
                SupplierTxt.Text = "";
                SizeTxt.Text = "";
                qtyOrTxt.Text = "";
                Widthtxt.Text = "";
                Heighttxt.Text = "";
                Typetxt.Text = "";
                OrderStatus.Text = "";
                OrderStock.Text = "";
                unitTxt.Text = "";
                OrderUnitPrice.Text = "";
                OrderQty.Text = "";
                OrderSubcost.Text = "";
                OrderQty.Enabled = false;


                OrderingTab.SelectedTab = COFpage;
                custOrdering = 0;
                customerSearchtxt.Text = "";

            }




        }

        private void button4_Click(object sender, EventArgs e)
        {

            int ans = Convert.ToInt16(MessageBox.Show("Are you sure that you want to cancel ordering? This ordering will not be saved. ", "Cancel!", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (ans == 6)
            {

                int[] id = new int[3000];
                int[] bo = new int[3000];
                int[] qty = new int[300];
                int a = 0;
                SqlCommand cmd321 = new SqlCommand("Select * from Item where [COF Number]=" + "'" + COFlabel.Text.Trim() + "'", conn);
                SqlDataReader dr321 = cmd321.ExecuteReader();
                while (dr321.Read())
                {

                    id[a] = Convert.ToInt32(dr321["Item ID"].ToString());
                    bo[a] = Convert.ToInt32(dr321["Back Order"].ToString());
                    qty[a] = Convert.ToInt32(dr321["Quantity"].ToString());
                    a++;
                }
                dr321.Close();
                double invst = 0, invor = 0, invbo = 0;
                for (int c = 0; c < a; c++)
                {

                    SqlCommand cmd111 = new SqlCommand("Select * from Inventory where [Item ID]=" + "'" + Convert.ToString(id[b]) + "'", conn);
                    SqlDataReader dr111 = cmd111.ExecuteReader();
                    while (dr111.Read())
                    {

                        invst = Convert.ToDouble(dr111["Quantity in Stock"].ToString());

                        invor = Convert.ToDouble(dr111["Quantity in Order"].ToString());
                        invbo = Convert.ToDouble(dr111["Back Order"].ToString());


                    }
                    dr111.Close();
                    int tot = 0;
                    if (bo[c] > 0)
                    {
                        tot = qty[c] - bo[c];
                        invbo -= bo[c];
                        invor -= tot;
                        invst += tot;


                    }
                    else
                    {
                        invor = invor - qty[c];
                        invst += Convert.ToDouble(qty[c]);

                    }

                    bo[c] = 0;

                    //update inv backorder
                    BalloonKingdomDataSetTableAdapters.InventoryTableAdapter backorder = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                    backorder.UpdateBackOrder(Convert.ToInt32(invbo), id[c], id[c]);



                    //update item back order
                    SqlCommand cmd25 = new SqlCommand("update Item set [Back Order] =" + "'" + Convert.ToString(bo[c]) + "'" + " where [COF Number] =" + "'" + COFlabel.Text + "'" + "AND [Item ID]=" + "'" + id[c] + "'", conn);
                    cmd25.ExecuteNonQuery();


                    //update inventory order and stock

                    BalloonKingdomDataSetTableAdapters.InventoryTableAdapter upditem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                    upditem.UpdateInvItem(Convert.ToInt32(invst), Convert.ToInt32(invor), id[c], id[c]);
                    Removeitembtn.Enabled = false;

                    //delete from item
                    BalloonKingdomDataSetTableAdapters.ItemTableAdapter deleteItem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.ItemTableAdapter();
                    deleteItem.DeleteCartItem(Convert.ToInt32(COFlabel.Text.Trim()), id[c]);


                    //elete COF
                    BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter deleteorder = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                    deleteorder.DeleteCOF(Convert.ToInt32(COFlabel.Text.Trim()));
                }



                OrderingPanel.Visible = false;
                Orderpanel.Visible = true;
                BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter ViewOrderlinerec = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                OrderlineDataGrid.DataSource = ViewOrderlinerec.ViewOrderline();
                CustOrderbtn.Visible = true;
                orderlabel.Visible = true;
                CustActLbl.Text = fn + " " + mi + ". " + ln + " had finished ordering";
                //transfering
                COForderlinetxt.Text = COFlabel.Text;
                DateOfOrdertxt.Value = DateofOrderPick.Value;
                Fnameorderlinetxt.Text = FirstNameLbl.Text;
                MidNameOLTxt.Text = MiddleInitialLbl.Text;
                LNOrderLineTxt.Text = LastNameLbl.Text;
                EventDateOLTxt.Value = DateOfEventPick.Value;
                ThemeOLTxt.Text = COFThemetxt.Text;
                EventTimePickOL.Value = timepick.Value;
                VenueOLTxt.Text = COFVenuetxt.Text;
                CartBoxMsg.Visible = true;
                CartGBox.Visible = false;
                PaymentGBox.Visible = false;
                payBoxMsg.Visible = true;
                DateofOrderPick.Value = DateTime.Today;
                DateofOrderPick.Enabled = true;
                DateOfEventPick.Value = DateTime.Today;
                DateOfEventPick.Enabled = true;
                DateOfEventPick.Enabled = true;
                timepick.Value = DateTime.Today;
                timepick.Enabled = true;
                COFThemetxt.Text = "";
                COFThemetxt.Enabled = true;
                ColorMotifCombo.Text = "";
                ColorMotifCombo.Enabled = true;
                COFVenuetxt.Text = "";
                COFVenuetxt.Enabled = true;
                NextORBtn.Visible = true;
                CancelORBtn.Visible = true;
                OrderProdID.Text = "";
                CatName.Text = "";
                SubCat.Text = "";
                SpecificCat.Text = "";
                OrderProdName.Text = "";
                colortxt.Text = "";
                SupplierTxt.Text = "";
                SizeTxt.Text = "";
                qtyOrTxt.Text = "";
                Widthtxt.Text = "";
                Heighttxt.Text = "";
                Typetxt.Text = "";
                OrderStatus.Text = "";
                OrderStock.Text = "";
                unitTxt.Text = "";
                OrderUnitPrice.Text = "";
                OrderQty.Text = "";
                OrderSubcost.Text = "";
                OrderQty.Enabled = false;


                OrderingTab.SelectedTab = COFpage;
                custOrdering = 0;
                customerSearchtxt.Text = "";

            }

        }

        private void CancelORBtn_Click(object sender, EventArgs e)
        {
            BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter ViewOrderlinerec = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
            OrderlineDataGrid.DataSource = ViewOrderlinerec.ViewOrderline();
            CustOrderbtn.Visible = true;
            orderlabel.Visible = true;
            CustActLbl.Text = fn + " " + mi + ". " + ln + " had finished ordering";
            //transfering
            COForderlinetxt.Text = "";
            DateOfOrdertxt.Value = DateTime.Today;
            Fnameorderlinetxt.Text = "None";
            MidNameOLTxt.Text = "None";
            LNOrderLineTxt.Text = "None";
            EventDateOLTxt.Value = DateTime.Today;
            ThemeOLTxt.Text = "";
            EventTimePickOL.Value = DateTime.Today;
            VenueOLTxt.Text = "";
            CartBoxMsg.Visible = true;
            CartGBox.Visible = false;
            PaymentGBox.Visible = false;
            payBoxMsg.Visible = true;
            DateofOrderPick.Value = DateTime.Today;
            DateofOrderPick.Enabled = true;
            DateOfEventPick.Value = DateTime.Today;
            DateOfEventPick.Enabled = true;
            DateOfEventPick.Enabled = true;
            timepick.Value = DateTime.Today;
            timepick.Enabled = true;
            COFThemetxt.Text = "";
            COFThemetxt.Enabled = true;
            ColorMotifCombo.Text = "";
            ColorMotifCombo.Enabled = true;
            COFVenuetxt.Text = "";
            COFVenuetxt.Enabled = true;
            NextORBtn.Visible = true;
            CancelORBtn.Visible = true;
            OrderProdID.Text = "";
            CatName.Text = "";
            SubCat.Text = "";
            SpecificCat.Text = "";
            OrderProdName.Text = "";
            colortxt.Text = "";
            SupplierTxt.Text = "";
            SizeTxt.Text = "";
            qtyOrTxt.Text = "";
            Widthtxt.Text = "";
            Heighttxt.Text = "";
            Typetxt.Text = "";
            OrderStatus.Text = "";
            OrderStock.Text = "";
            unitTxt.Text = "";
            OrderUnitPrice.Text = "";
            OrderQty.Text = "";
            OrderSubcost.Text = "";
            OrderQty.Enabled = false;


            OrderingTab.SelectedTab = COFpage;
            custOrdering = 0;
            customerSearchtxt.Text = "";


            OrderingPanel.Visible = false;
            CustomerPanel.Visible = true;

        }

        private void PurSuppNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PurFilterSupcomb.Text == "W/O Back Order")
            {
                BalloonKingdomDataSetTableAdapters.InventoryTableAdapter shownoback = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                BackOrderDataGrid.DataSource = shownoback.ShowSupWithoutBO(PurSuppNameCombo.Text.Trim());
            }

            else
            {

                BalloonKingdomDataSetTableAdapters.InventoryTableAdapter displayitems = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                BackOrderDataGrid.DataSource = displayitems.DisplayTobePurchasedItems(PurSuppNameCombo.Text.Trim());
            }

            SqlCommand cmd2sup = new SqlCommand("Select * from Supplier where Name=" + "'" + PurSuppNameCombo.Text.Trim() + "'", conn);
            SqlDataReader dr2sup = cmd2sup.ExecuteReader();
            while (dr2sup.Read())
            {
                PurSuppIDtxt.Text = dr2sup["Supplier ID"].ToString();
                PurContxt.Text = dr2sup["Contact"].ToString();
                PurAddtxt.Text = dr2sup["Address"].ToString();

            }
           dr2sup.Close();




        }


        private void BackOrderDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PurItemIDtxt.Text = BackOrderDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            PurCatNametxt.Text = BackOrderDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            PurSubCattxt.Text = BackOrderDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            PurSpecCattxt.Text = BackOrderDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            PurItemNametxt.Text = BackOrderDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            PurtTypetxt.Text = BackOrderDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            PurSizetxt.Text = BackOrderDataGrid.SelectedRows[0].Cells[6].Value.ToString();
            PurQtytxt.Text = BackOrderDataGrid.SelectedRows[0].Cells[7].Value.ToString();
            PurUnitText.Text = BackOrderDataGrid.SelectedRows[0].Cells[8].Value.ToString();
            UnitPrceTxt.Enabled = false;

            UnitPrceTxt.Text = "";
            PurQtyStocktxt.Text = BackOrderDataGrid.SelectedRows[0].Cells[11].Value.ToString();
            PurUnitPricetxt.Text = BackOrderDataGrid.SelectedRows[0].Cells[9].Value.ToString();
            PurColortxt.Text = BackOrderDataGrid.SelectedRows[0].Cells[14].Value.ToString();
            PurWidthtxt.Text = BackOrderDataGrid.SelectedRows[0].Cells[15].Value.ToString();
            PurHeighttxt.Text = BackOrderDataGrid.SelectedRows[0].Cells[16].Value.ToString();
            PurtoOrderTxt.Text = BackOrderDataGrid.SelectedRows[0].Cells[20].Value.ToString();

            POOldPbtn.Visible = true;
            PurUnitPricetxt.Visible = true;
            UnitPrceLbl.Visible = false;
            POAdItembtn.Enabled = true;
            PODelItembtn.Enabled = false;
            PONewPbtn.Visible = true;
            PurtoOrderTxt.Enabled = true;

            ItemInfoBox.Enabled = true;
            PurtoOrderTxt.Focus();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            ChoiceCustomer showchoice = new ChoiceCustomer();

            showchoice.ShowDialog();

            //trial tri = new trial();
            //tri.ShowDialog();




        }



        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Choice_Supplier showsupp = new Choice_Supplier();

            showsupp.ShowDialog();

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoiceInventory showinv = new ChoiceInventory();
            showinv.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Choice_Order showor = new Choice_Order();
            showor.ShowDialog();
        }

        private void pOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Choice_PO showpo = new Choice_PO();
            showpo.ShowDialog();
        }

        private void lostItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Choice_Lost lo = new Choice_Lost();
            lo.ShowDialog();
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (COForderlinetxt.Text == "")
            {
                MessageBox.Show("Please select an order in the orderline to update its paymnent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (PayStatLbl.Text == "Cancelled")
            {
                MessageBox.Show("Cannot update the payment of a cancelled order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PayStatLbl.Text == "Pending")
            {
                MessageBox.Show("Cannot update the not yet delivered order. Please deliver this order first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int ans1 = Convert.ToInt32(MessageBox.Show("Are you sure you want to update the payment of this order?", "Update Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (ans1 == 6)
                {

                    string rentstat = "Waiting";
                    SqlCommand cmdget = new SqlCommand("Select * from [Rented Items] where [COF Number]=" + "'" + COForderlinetxt.Text + "'", conn);
                    SqlDataReader drget = cmdget.ExecuteReader();
                    while (drget.Read())
                    {

                        rentstat = drget["Status"].ToString();



                    }
                    drget.Close();
                    int rentqty = Convert.ToInt32(RentOLLbl.Text);
                    int orqty = Convert.ToInt32(OrderOLLbl.Text);


                    if (PayStatLbl.Text == "Waiting")
                    {


                        double downst = Convert.ToDouble(OrDowntxt.Text);

                        if ((rent > 0 && rentstat == "Waiting") && (rent > 0))
                        {


                            MessageBox.Show("This Order has rental item/s to return", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ReturnRentPanel.Visible = true;
                            Orderpanel.Visible = false;
                            CustIDlbl.Text = ORCustID.Text;
                            COFNumLbl.Text = COForderlinetxt.Text;
                            CustIDlabel.Text = ORCustID.Text;

                            //overallrentedLbl.Text = Convert.ToString(rent);
                            //int a = 0, id2 = 0;
                            //string id;
                            //SqlCommand cmdrenti = new SqlCommand("Select * from [Rented Items]", conn);
                            //SqlDataReader drrenti = cmdrenti.ExecuteReader();
                            //while (drrenti.Read())
                            //{
                            //    id = drrenti["Returned Item ID"].ToString();
                            //    id2 = Convert.ToInt32(id);
                            //    if (a < id2)
                            //        a = id2;



                            //}
                            //drrenti.Close();
                            //a++;
                            BalloonKingdomDataSetTableAdapters.ItemTableAdapter showrent = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.ItemTableAdapter();
                            RentDataGrid.DataSource = showrent.ViewRentItem(Convert.ToInt32(COFNumLbl.Text));

                            double returned = 0, lost1 = 0, qtyite;
                            double total = 0, unit = 0, totalamount = 0, overall = 0;
                            SqlCommand cmditem = new SqlCommand("Select * from Item where [COF Number]=" + "'" + COFNumLbl.Text + "'" + "and Type='Rental'", conn);
                            SqlDataReader dritem = cmditem.ExecuteReader();
                            while (dritem.Read())
                            {
                                returned += Convert.ToDouble(dritem["Returned Item"].ToString());
                                lost1 += Convert.ToDouble(dritem["Lost Item"].ToString());
                                unit = Convert.ToDouble(dritem["Unit Cost"].ToString());
                                qtyite = Convert.ToDouble(dritem["Quantity"].ToString());
                                totalamount += qtyite * unit;
                                total += Convert.ToDouble(lost1) * unit;
                                overall += qtyite;
                            }
                            dritem.Close();

                            returnedLbl.Text = Convert.ToString(returned);
                            RetLostItemLbl.Text = Convert.ToString(lost1);
                            Totlbl.Text = Convert.ToString(total);
                            RentAmtTotLbl.Text = Convert.ToString(totalamount);
                            overallrentedLbl.Text = Convert.ToString(overall);

                            SqlCommand rentchklst = new SqlCommand("Select distinct [Deposit Amount]  from [Rental Checklist] where [COF Number]=" + "'" + COFNumLbl.Text + "'", conn);
                            double deposit = Convert.ToDouble(rentchklst.ExecuteScalar());
                            DepositRentTxt.Text = Convert.ToString(deposit);
                        }


                        else if (downst == 0)
                        {

                            MessageBox.Show("This Order is already fully paid. Please try another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter ViewOrderlinerec = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                            OrderlineDataGrid.DataSource = ViewOrderlinerec.ViewOrderline();
                        }
                        else
                        {
                            int ans = Convert.ToInt32(MessageBox.Show("Are you sure you want to fully paid this order?", "Update Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                            if (ans == 6)
                            {
                                MessageBox.Show("Successfully processed your order", "Full payment Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                SqlCommand gettot = new SqlCommand("Select Total from Orderline where [COF Number]=" + "'" + COForderlinetxt.Text + "'", conn);
                                int full = Convert.ToInt32(gettot.ExecuteScalar());


                                SqlCommand updatepay = new SqlCommand("Update Orderline set Status='Processed', [Down payment]='0.00', [Full payment]=" + "'" + Convert.ToString(full) + "'" + "where [COF Number]=" + "'" + COForderlinetxt.Text + "'", conn);
                                updatepay.ExecuteNonQuery();

                                BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter ViewOrderlinerec = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                                OrderlineDataGrid.DataSource = ViewOrderlinerec.ViewOrderline();
                            }
                        }
                    }


                    else if (PayStatLbl.Text == "pending")
                    {

                        MessageBox.Show("Please deliver the order to customer first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter ViewOrderlinerec = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                        OrderlineDataGrid.DataSource = ViewOrderlinerec.ViewOrderline();

                    }
                    else if (PayStatLbl.Text == "Processed")
                    {
                        MessageBox.Show("This item is already been processed. Please try anther one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter ViewOrderlinerec = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                        OrderlineDataGrid.DataSource = ViewOrderlinerec.ViewOrderline();
                    }
                }
                ORLbl.Text = "None";
                QtyOLLbl.Text = "None";
                PayStatLbl.Text = "None";
                TotItemOLLbl.Text = "None";
                RentOLLbl.Text = "None";
                OrderOLLbl.Text = "None";
                TotAmtOLLbl.Text = "None";
                POOveAllLbl.Text = "None";
                Searchordertxt.Text = "";
                DateOfOrdertxt.Value = DateTime.Today;
                Fnameorderlinetxt.Text = "";
                MidNameOLTxt.Text = "";
                LNOrderLineTxt.Text = "";
                EventDateOLTxt.Value = DateTime.Today;
                ThemeOLTxt.Text = "";
                EventTimePickOL.Value = DateTime.Today;
                VenueOLTxt.Text = "";
                COForderlinetxt.Text = "";
                ORCustID.Text = "";
                OrOrAmttxt.Text = "";
                OrBaltxt.Text = "";
                OrServicetxt.Text = "";
                PORefAmtTxt.Text = "";
                OrDowntxt.Text = "";
                OrFulltxt.Text = "";
                TotAmtOLLbl.Text = "None";
                ORMotifTxt.Text = "";
                ORVATAmtTxt.Text = "";
                ORDiscountTxt.Text = "";

            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter viewcan = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
            OrderlineDataGrid.DataSource = viewcan.ViewCancelledOrder();
            ORLbl.Text = "None";
            QtyOLLbl.Text = "None";
            PayStatLbl.Text = "None";
            TotItemOLLbl.Text = "None";
            RentOLLbl.Text = "None";
            OrderOLLbl.Text = "None";
            TotAmtOLLbl.Text = "None";
            POOveAllLbl.Text = "None";
            Searchordertxt.Text = "";
            DateOfOrdertxt.Value = DateTime.Today;
            Fnameorderlinetxt.Text = "";
            MidNameOLTxt.Text = "";
            LNOrderLineTxt.Text = "";
            EventDateOLTxt.Value = DateTime.Today;
            ThemeOLTxt.Text = "";
            EventTimePickOL.Value = DateTime.Today;
            VenueOLTxt.Text = "";
            COForderlinetxt.Text = "";
            ORCustID.Text = "";
            OrOrAmttxt.Text = "";
            OrBaltxt.Text = "";
            OrServicetxt.Text = "";
            PORefAmtTxt.Text = "";
            OrDowntxt.Text = "";
            OrFulltxt.Text = "";
            TotAmtOLLbl.Text = "None";
            ORMotifTxt.Text = "";
            ORVATAmtTxt.Text = "";
            ORDiscountTxt.Text = "";
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter viewpend = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
            OrderlineDataGrid.DataSource = viewpend.ViewPendingOrder();
            ORLbl.Text = "None";
            QtyOLLbl.Text = "None";
            PayStatLbl.Text = "None";
            TotItemOLLbl.Text = "None";
            RentOLLbl.Text = "None";
            OrderOLLbl.Text = "None";
            TotAmtOLLbl.Text = "None";
            POOveAllLbl.Text = "None";
            Searchordertxt.Text = "";
            DateOfOrdertxt.Value = DateTime.Today;
            Fnameorderlinetxt.Text = "";
            MidNameOLTxt.Text = "";
            LNOrderLineTxt.Text = "";
            EventDateOLTxt.Value = DateTime.Today;
            ThemeOLTxt.Text = "";
            EventTimePickOL.Value = DateTime.Today;
            VenueOLTxt.Text = "";
            COForderlinetxt.Text = "";
            ORCustID.Text = "";
            OrOrAmttxt.Text = "";
            OrBaltxt.Text = "";
            OrServicetxt.Text = "";
            PORefAmtTxt.Text = "";
            OrDowntxt.Text = "";
            OrFulltxt.Text = "";
            TotAmtOLLbl.Text = "None";
            ORMotifTxt.Text = "";
            ORVATAmtTxt.Text = "";
            ORDiscountTxt.Text = "";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter viewproc = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
            OrderlineDataGrid.DataSource = viewproc.ViewProcessedOrder();
            ORLbl.Text = "None";
            QtyOLLbl.Text = "None";
            PayStatLbl.Text = "None";
            TotItemOLLbl.Text = "None";
            RentOLLbl.Text = "None";
            OrderOLLbl.Text = "None";
            TotAmtOLLbl.Text = "None";
            POOveAllLbl.Text = "None";
            Searchordertxt.Text = "";
            DateOfOrdertxt.Value = DateTime.Today;
            Fnameorderlinetxt.Text = "";
            MidNameOLTxt.Text = "";
            LNOrderLineTxt.Text = "";
            EventDateOLTxt.Value = DateTime.Today;
            ThemeOLTxt.Text = "";
            EventTimePickOL.Value = DateTime.Today;
            VenueOLTxt.Text = "";
            COForderlinetxt.Text = "";
            ORCustID.Text = "";
            OrOrAmttxt.Text = "";
            OrBaltxt.Text = "";
            OrServicetxt.Text = "";
            PORefAmtTxt.Text = "";
            OrDowntxt.Text = "";
            OrFulltxt.Text = "";
            TotAmtOLLbl.Text = "None";
            ORMotifTxt.Text = "";
            ORVATAmtTxt.Text = "";
            ORDiscountTxt.Text = "";

        }

        private void PurFilterSupcomb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PurFilterSupcomb.Text == "With Back Order")
            {

                PurSuppNameCombo.Items.Clear();
                string[] sup = new string[5000];
                int a = 0;
                SqlCommand cmdsup = new SqlCommand("Select distinct Supplier from Inventory where [Back Order]>0", conn);
                SqlDataReader drsup = cmdsup.ExecuteReader();
                while (drsup.Read())
                {
                    sup[a] = drsup["Supplier"].ToString();
                    a++;
                }


                drsup.Close();
                for (int b = 0; b < a; b++)
                {
                    if (sup[b] != "")
                        PurSuppNameCombo.Items.Add(sup[b]);

                }


            }
            else
            {

                PurSuppNameCombo.Items.Clear();
                string[] supwo = new string[5000];
                int a1 = 0;
                SqlCommand cmdsupwo = new SqlCommand("Select distinct Supplier from Inventory where [Back Order]=0", conn);
                SqlDataReader drsupwo = cmdsupwo.ExecuteReader();
                while (drsupwo.Read())
                {
                    supwo[a1] = drsupwo["Supplier"].ToString();
                    a1++;
                }


                drsupwo.Close();
                for (int b = 0; b < a1; b++)
                {
                    if (supwo[b] != "")
                        PurSuppNameCombo.Items.Add(supwo[b]);

                }


            }

            BackOrderDataGrid.DataSource = "none";
            PurchasingPanel.Visible = true;
            OrderingPanel.Visible = false;
            CustomerPanel.Visible = false;
            Inventorypanel.Visible = false;
            Orderpanel.Visible = false;
            Supplierpanel.Visible = false;
            SecurityPanel.Visible = false;
            BackgndPanel.Visible = false;
            PurItemIDtxt.Text = "";
            PurCatNametxt.Text = "";
            PurSpecCattxt.Text = "";
            PurSubCattxt.Text = "";
            PurItemNametxt.Text = "";
            PurSizetxt.Text = "";
            PurtTypetxt.Text = "";
            PurColortxt.Text = "";
            PurHeighttxt.Text = "";
            PurQtyStocktxt.Text = "";
            PurWidthtxt.Text = "";
            PurQtytxt.Text = "";
            PurUnitText.Text = "";
            PurUnitPricetxt.Text = "";
            UnitPrceTxt.Text = "";
        }

        private void PurtoOrderTxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (PurtoOrderTxt.Text != " ")
            {
                str = PurtoOrderTxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((PurtoOrderTxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", PurtoOrderTxt);
                    PurtoOrderTxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", PurtoOrderTxt);
                    PurtoOrderTxt.Clear();
                }
                toolTip1.Hide(PurtoOrderTxt);

            }

            try
            {
                double sub1 = 0;
                if (PONewPbtn.Checked == true)
                {
                    sub1 = Convert.ToDouble(PurtoOrderTxt.Text) * Convert.ToDouble(UnitPrceTxt.Text);
                    posubtotlbl.Text = Convert.ToString(sub1);
                }
                else
                {
                    sub1 = Convert.ToDouble(PurtoOrderTxt.Text) * Convert.ToDouble(PurUnitPricetxt.Text);
                    posubtotlbl.Text = Convert.ToString(sub1);
                }
            }
            catch
            {
                UnitPrceTxt.Text = "";
            }




        }

        private void PurtoOrderTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*1234567890*".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void POOldPbtn_CheckedChanged(object sender, EventArgs e)
        {
            double sub = 0;

            if (POOldPbtn.Checked == true)
                UnitPrceTxt.Enabled = false;

            sub = Convert.ToDouble(PurtoOrderTxt.Text) * Convert.ToDouble(PurUnitPricetxt.Text);
            posubtotlbl.Text = Convert.ToString(sub);


        }

        private void SelingPrceTxt_TextChanged(object sender, EventArgs e)
        {

            if (PONewPbtn.Checked == true)
            {
                double sub1 = 0;

                try
                {
                    int x = 0;
                    string txt;
                    if (UnitPrceTxt.Text != "")
                    {
                        txt = UnitPrceTxt.Text;
                        x = txt.Length - 1;

                        if (UnitPrceTxt.Text == "")
                        {
                            toolTip1.Show("Avoid special characters!", UnitPrceTxt);
                            UnitPrceTxt.Clear();
                            toolTip1.Hide(UnitPrceTxt);
                        }

                        else if (char.IsWhiteSpace(txt[x]))
                        {
                            UnitPrceTxt.Text = txt.Replace(txt[x], ' ');
                            toolTip1.Show("Avoid special characters!", UnitPrceTxt);
                            toolTip1.Hide(UnitPrceTxt);
                        }
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "error");
                }
                try
                {
                    sub1 = Convert.ToDouble(PurtoOrderTxt.Text) * Convert.ToDouble(UnitPrceTxt.Text);
                    posubtotlbl.Text = Convert.ToString(sub1);
                }
                catch
                {
                    UnitPrceTxt.Text = "";
                }
            }
        }

        private void SelingPrceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*1234567890.*".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void PONewPbtn_CheckedChanged(object sender, EventArgs e)
        {
            UnitPrceTxt.Enabled = true;
            UnitPrceTxt.Text = "";
            posubtotlbl.Text = "0";
            UnitPrceTxt.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string answ = "no";
            SqlCommand cmdpoc = new SqlCommand("Select * from [PO Items] where [POF Number]=" + "'" + Convert.ToString(POFID) + "'", conn);
            SqlDataReader drpoc = cmdpoc.ExecuteReader();
            while (drpoc.Read())
            {
                if (PurItemIDtxt.Text.Trim() == drpoc["Item ID"].ToString())
                    answ = "yes";


            }
            drpoc.Close();

            int or = Convert.ToInt32(PurtoOrderTxt.Text);
            if (answ == "yes")
            {

                MessageBox.Show("This Item is already taken. Please select another one", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                POAdItembtn.Enabled = false;
            }
            else if (or <= 0)
            {

                MessageBox.Show("Cannot purchase in 0 quantity. Please enter at least 1 or above.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                int id = 0, a = 0, ans = 0;
                double unit = 0;
                SqlCommand cmdpoi = new SqlCommand("Select * from [PO Items]", conn);
                SqlDataReader drpoi = cmdpoi.ExecuteReader();
                while (drpoi.Read())
                {
                    id = Convert.ToInt32(drpoi["PO Item ID"].ToString());
                    if (a < id)
                        a = id;


                }
                drpoi.Close();
                a++;
                if (POOldPbtn.Checked == true)
                {
                    unit = Convert.ToDouble(PurUnitPricetxt.Text.Trim());
                    ans = 0;
                }
                else
                {
                    if (UnitPrceTxt.Text != "")
                    { unit = Convert.ToDouble(UnitPrceTxt.Text.Trim()); ans = 0; }
                    else
                    {
                        MessageBox.Show("Please Enter new Unit Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ans = 1;
                        UnitPrceTxt.Focus();
                    }

                }
                if (ans != 1)
                {
                    BalloonKingdomDataSetTableAdapters.PO_ItemsTableAdapter addpoitem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PO_ItemsTableAdapter();
                    addpoitem.AddPOItem(Convert.ToInt32(PurItemIDtxt.Text.Trim()), a, POFID, PurCatNametxt.Text.Trim(), PurSpecCattxt.Text.Trim(), PurSubCattxt.Text.Trim(), PurItemNametxt.Text.Trim(), PurSizetxt.Text.Trim(), PurColortxt.Text.Trim(), Convert.ToDecimal(PurHeighttxt.Text.Trim()), Convert.ToDecimal(PurWidthtxt.Text.Trim()), Convert.ToInt32(PurtoOrderTxt.Text.Trim()), PurUnitText.Text.Trim(), Convert.ToDecimal(unit), Convert.ToDecimal(posubtotlbl.Text.Trim()), Convert.ToInt32(PurtoOrderTxt.Text.Trim()));
                    BalloonKingdomDataSetTableAdapters.PO_ItemsTableAdapter viewpoitems = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PO_ItemsTableAdapter();
                    POItemCart.DataSource = viewpoitems.ViewPOItems(POFID);
                    POAdItembtn.Enabled = false;
                    PurdownRBtn.Checked = true;
                    double puramt1 = 0;
                    int purqty = 0;
                    PurProcessBtn.Enabled = true;
                    POPayBox.Enabled = true;
                    //compute purchase amount
                    SqlCommand puramt = new SqlCommand("select * from [PO Items] where [POF Number]=" + "'" + Convert.ToString(POFID) + "'", conn);
                    SqlDataReader drpuramt = puramt.ExecuteReader();
                    while (drpuramt.Read())
                    {
                        puramt1 += Convert.ToDouble(drpuramt["Sub Total"].ToString());
                        purqty += Convert.ToInt32(drpuramt["Quantity"].ToString());



                    }
                    drpuramt.Close();

                    PurAmtLbl.Text = Convert.ToString(puramt1);
                    double puramount = Convert.ToDouble(PurAmtLbl.Text.Trim());
                    double vatper = Convert.ToDouble(PurVattxt.Text.Trim());
                    double per = vatper / 100;

                    double vattot = per * puramount;
                    PurTotLabel.Text = Convert.ToString(vattot);
                    double totalamt = vattot + puramount;
                    PurTotalLbl.Text = Convert.ToString(totalamt);
                    double down = totalamt / 2;
                    PurDowntxt.Text = Convert.ToString(down);
                    PurBalLabel.Text = Convert.ToString(down);


                }
            }

        }



        private void POChooseSupbtn_Click(object sender, EventArgs e)
        {

            if (PurFilterSupcomb.Text.Trim() == "" || PurSuppNameCombo.Text.Trim() == "")
            {
                MessageBox.Show("Please Select your Supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (PurSuppIDtxt.Text == "")
            { }
            else
            {
                int ans;
                ans = Convert.ToInt16(MessageBox.Show("Are you sure you want to choose this supplier?", "Choose Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (ans == 6)
                {   
                    int id = 0, a12 = 0;
                    SqlCommand cmdpo = new SqlCommand("Select * from [Purchase]", conn);
                    SqlDataReader drpo = cmdpo.ExecuteReader();
                    while (drpo.Read())
                    {
                        id = Convert.ToInt32(drpo["POF Number"].ToString());
                        if (a12 < id)
                            a12 = id;


                    }
                    drpo.Close();
                    a12++;

                    BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter addPOF = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter();
                    addPOF.AddPOF(a12, DateTime.Now, DateTime.Now, Convert.ToInt32(PurSuppIDtxt.Text.Trim()), PurSuppNameCombo.Text.Trim(), PurAddtxt.Text.Trim(), PurContxt.Text.Trim());
                    POFID = a12;
                    PurFilterSupcomb.Enabled = false;
                    PurSuppNameCombo.Enabled = false;
                    POChooseSupbtn.Enabled = false;

                    BackOrderDataGrid.Enabled = true;

                    CancelPOPic.Enabled = true;
                    if (PurFilterSupcomb.Text == "W/O Back Order")
                    {
                        BalloonKingdomDataSetTableAdapters.InventoryTableAdapter shownoback = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                        BackOrderDataGrid.DataSource = shownoback.ShowSupWithoutBO(PurSuppNameCombo.Text.Trim());
                    }

                    else
                    {

                        BalloonKingdomDataSetTableAdapters.InventoryTableAdapter displayitems = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                        BackOrderDataGrid.DataSource = displayitems.DisplayTobePurchasedItems(PurSuppNameCombo.Text.Trim());
                    }

                    SqlCommand cmd2sup = new SqlCommand("Select * from Supplier where Name=" + "'" + PurSuppNameCombo.Text.Trim() + "'", conn);
                    SqlDataReader dr2sup = cmd2sup.ExecuteReader();
                    while (dr2sup.Read())
                    {
                        PurSuppIDtxt.Text = dr2sup["Supplier ID"].ToString();
                        PurContxt.Text = dr2sup["Contact"].ToString();
                        PurAddtxt.Text = dr2sup["Address"].ToString();

                    }
                    dr2sup.Close();
                    SearchGroupBox.Enabled = true;

                }
            }
        }

        private void updatepick_Click(object sender, EventArgs e)
        {
            if (PayStatLbl.Text == "Pending")
            {
                if (ORCustID.Text == "")
                { MessageBox.Show("Please Select the Orderline data first before you update your order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    int ans = Convert.ToInt32(MessageBox.Show("Are you sure you want to Update this order?", "Update Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

                    if (ans == 6)
                    {
                       

                        totamt = 0;
                        custOrdering = 4;
                        NextORBtn.Enabled = false;
                        CancelORBtn.Enabled = false;
                        Orderpanel.Visible = false;
                        OrderingPanel.Visible = true;
                        COFlabel.Text = COForderlinetxt.Text;

                     


                        SqlCommand cmdtamt = new SqlCommand("Select * from Item where [COF Number]=" + "'" + COForderlinetxt.Text + "'", conn);
                        SqlDataReader drcmd1 = cmdtamt.ExecuteReader();
                        double totamt1 = 0;
                        int qtytot = 0;
                        int itemcnt = 0;
                        while (drcmd1.Read())
                        {
                            totamt1 += Convert.ToDouble(drcmd1["Sub Cost"].ToString());
                            qtytot += Convert.ToInt32(drcmd1["Quantity"].ToString());
                            itemcnt++;
                        }
                        drcmd1.Close();
                        totalAmtLbl.Text = Convert.ToString(totamt1);
                        totqtytxt.Text = Convert.ToString(qtytot);
                        totalItemlbl.Text = Convert.ToString(itemcnt);
                        TotalAmtTxt.Text = Convert.ToString(totamt1);


                        DateofOrderPick.Value = DateOfOrdertxt.Value;
                        LastNameLbl.Text = LNOrderLineTxt.Text;
                        OrderingTab.SelectedTab = OrderRentpage;
                        CartBoxMsg.Visible = false;
                        CartGBox.Visible = true;
                        PaymentGBox.Visible = true;
                        payBoxMsg.Visible = false;
                        CustIDlabel.Text = ORCustID.Text;
                        FirstNameLbl.Text = Fnameorderlinetxt.Text;

                        CustOrderbtn.Visible = false;
                        orderlabel.Visible = false;
                        CustActLbl.Text = "A customer is currently updating an order.";

                        MiddleInitialLbl.Text = MidNameOLTxt.Text;
                        DateOfEventPick.Value = EventDateOLTxt.Value;
                        DateOfEventPick.Enabled = false;
                        timepick.Value = EventTimePickOL.Value;
                        timepick.Enabled = false;
                        COFThemetxt.Text = ThemeOLTxt.Text;
                        COFThemetxt.Enabled = false;
                        ColorMotifCombo.Text = ORMotifTxt.Text;
                        ColorMotifCombo.Enabled = false;
                        COFVenuetxt.Text = VenueOLTxt.Text;
                        COFVenuetxt.Enabled = false;
                        TotalAmtTxt.Text = OrOrAmttxt.Text;

                        PaymentDownPayment.Text = OrDowntxt.Text;
                        PaymentBalance.Text = OrBaltxt.Text;
                        PaymentTotal.Text = TotAmtOLLbl.Text;

                        if (PaymentBalance.Text == "0")
                        {
                            fullRadioBtn.Checked = true;


                        }
                        else
                        {
                            downRadiobtn.Checked = true;
                        }


                        if (ORLbl.Text == "Yes")
                            serbtn.Checked = true;
                        else
                            serbtn.Checked = false;
                        BalloonKingdomDataSetTableAdapters.ItemTableAdapter viewcart = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.ItemTableAdapter();
                        CartdataGridView.DataSource = viewcart.ViewCartCOF1(Convert.ToInt32(COFlabel.Text.Trim()));
                        ORLbl.Text = "None";
                        QtyOLLbl.Text = "None";
                        PayStatLbl.Text = "None";
                        TotItemOLLbl.Text = "None";
                        RentOLLbl.Text = "None";
                        OrderOLLbl.Text = "None";
                        TotAmtOLLbl.Text = "None";
                        POOveAllLbl.Text = "None";
                        Searchordertxt.Text = "";
                        DateOfOrdertxt.Value = DateTime.Today;
                        Fnameorderlinetxt.Text = "";
                        MidNameOLTxt.Text = "";
                        LNOrderLineTxt.Text = "";
                        EventDateOLTxt.Value = DateTime.Today;
                        ThemeOLTxt.Text = "";
                        EventTimePickOL.Value = DateTime.Today;
                        VenueOLTxt.Text = "";
                        COForderlinetxt.Text = "";
                        ORCustID.Text = "";
                        OrOrAmttxt.Text = "";
                        OrBaltxt.Text = "";
                        OrServicetxt.Text = "";
                        PORefAmtTxt.Text = "";
                        OrDowntxt.Text = "";
                        OrFulltxt.Text = "";
                        TotAmtOLLbl.Text = "None";
                        ORMotifTxt.Text = "";
                        ORVATAmtTxt.Text = "";
                        ORDiscountTxt.Text = "";

                        


                    }
                }
            }
            else
            {

                MessageBox.Show("Cannot update already processed or delivered order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void POItemCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PurItemIDtxt.Text = POItemCart.SelectedRows[0].Cells[0].Value.ToString();
            PurCatNametxt.Text = POItemCart.SelectedRows[0].Cells[3].Value.ToString();
            PurSpecCattxt.Text = POItemCart.SelectedRows[0].Cells[4].Value.ToString();
            PurSubCattxt.Text = POItemCart.SelectedRows[0].Cells[5].Value.ToString();
            PurItemNametxt.Text = POItemCart.SelectedRows[0].Cells[6].Value.ToString();
            PurSizetxt.Text = POItemCart.SelectedRows[0].Cells[7].Value.ToString();
            PurColortxt.Text = POItemCart.SelectedRows[0].Cells[8].Value.ToString();
            PurHeighttxt.Text = POItemCart.SelectedRows[0].Cells[9].Value.ToString();
            PurWidthtxt.Text = POItemCart.SelectedRows[0].Cells[10].Value.ToString();
            PurtoOrderTxt.Text = POItemCart.SelectedRows[0].Cells[11].Value.ToString();
            PurUnitText.Text = POItemCart.SelectedRows[0].Cells[12].Value.ToString();
            UnitPrceTxt.Text = POItemCart.SelectedRows[0].Cells[13].Value.ToString();
            posubtotlbl.Text = POItemCart.SelectedRows[0].Cells[14].Value.ToString();
            UnitPrceTxt.Enabled = true;
            POAdItembtn.Enabled = false;
            PODelItembtn.Enabled = true;
            POOldPbtn.Visible = false;
            PurtoOrderTxt.Enabled = true;
            PurUnitPricetxt.Visible = false;
            UnitPrceLbl.Visible = true;
            POUpdateQty.Enabled = true;
            PONewPbtn.Visible = false;
            PurtoOrderTxt.Focus();
        }



        private void PODelItembtn_Click(object sender, EventArgs e)
        {
            SqlCommand delpoi = new SqlCommand("delete from [PO Items] where [Item ID]=" + "'" + PurItemIDtxt.Text.Trim() + "'" + "AND [POF Number]=" + "'" + Convert.ToString(POFID) + "'", conn);
            delpoi.ExecuteNonQuery();
            BalloonKingdomDataSetTableAdapters.PO_ItemsTableAdapter viewpoitems = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PO_ItemsTableAdapter();
            POItemCart.DataSource = viewpoitems.ViewPOItems(POFID);
            double puramt1 = 0;
            int purqty = 0;
            //compute purchase amount
            SqlCommand puramt = new SqlCommand("select * from [PO Items] where [POF Number]=" + "'" + Convert.ToString(POFID) + "'", conn);
            SqlDataReader drpuramt = puramt.ExecuteReader();
            while (drpuramt.Read())
            {
                puramt1 += Convert.ToDouble(drpuramt["Sub Total"].ToString());
                purqty += Convert.ToInt32(drpuramt["Quantity"].ToString());


            }
            drpuramt.Close();

            PurAmtLbl.Text = Convert.ToString(puramt1);
            PurdownRBtn.Checked = true;
            double puramount = Convert.ToDouble(PurAmtLbl.Text.Trim());
            double vatper = Convert.ToDouble(PurVattxt.Text.Trim());
            double per = vatper / 100;

            double vattot = per * puramount;
            PurTotLabel.Text = Convert.ToString(vattot);
            double totalamt = vattot + puramount;
            PurTotalLbl.Text = Convert.ToString(totalamt);
            double down = totalamt / 2;
            PurDowntxt.Text = Convert.ToString(down);
            PurBalLabel.Text = Convert.ToString(down);

        }

       

        private void PurAmtLbl_Click(object sender, EventArgs e)
        {

            double puramount = Convert.ToDouble(PurAmtLbl.Text.Trim());
            double vatper = Convert.ToDouble(PurVattxt.Text.Trim());
            double per = vatper / 100;

            double vattot = per * puramount;
            PurTotLabel.Text = Convert.ToString(vattot);
            double totalamt = vattot + puramount;
            PurTotalLbl.Text = Convert.ToString(totalamt);
            double down = totalamt / 2;
            PurDowntxt.Text = Convert.ToString(down);
            PurBalLabel.Text = Convert.ToString(down);

        }

        private void PurVattxt_TextChanged(object sender, EventArgs e)
        {
            int vatper = 0;
            try
            {
                if (PurVattxt.Text.Trim() == "")
                    vatper = 0;
                else
                    vatper = Convert.ToInt32(PurVattxt.Text.Trim());
                if (vatper < 0 || vatper > 100)
                {
                    MessageBox.Show("Invalid entry. Please enter number between 0 and 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PurVattxt.Text = "";
                    PurVattxt.Focus();


                }
                else
                {


                    double puramount = Convert.ToDouble(PurAmtLbl.Text.Trim());

                    double per = Convert.ToDouble(vatper) / 100;

                    double vattot = per * puramount;
                    PurTotLabel.Text = Convert.ToString(vattot);
                    double totalamt = vattot + puramount;
                    PurTotalLbl.Text = Convert.ToString(totalamt);
                    double down = totalamt / 2;
                    if (PurFullRbtn.Checked == true)
                    {
                        PurDowntxt.Text = "0";
                        PurBalLabel.Text = "0";
                    }
                    else
                    {
                        PurDowntxt.Text = Convert.ToString(down);
                        PurBalLabel.Text = Convert.ToString(down);
                    }
                }
            }
            catch
            {
                PurVattxt.Text = "";

            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PurDowntxt.Enabled = false;
            PurDowntxt.Text = "0";
            PurBalLabel.Text = "0";
        }

        private void PurdownRBtn_CheckedChanged(object sender, EventArgs e)
        {
            PurDowntxt.Enabled = true;
            double puramount = Convert.ToDouble(PurAmtLbl.Text.Trim());
            int vatper = Convert.ToInt32(PurVattxt.Text.Trim());
            double per = Convert.ToDouble(vatper) / 100;

            double vattot = per * puramount;
            PurTotLabel.Text = Convert.ToString(vattot);
            double totalamt = vattot + puramount;
            PurTotalLbl.Text = Convert.ToString(totalamt);
            double down = totalamt / 2;
            PurDowntxt.Text = Convert.ToString(down);
            PurBalLabel.Text = Convert.ToString(down);
        }

        private void PODataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VPONumtxt.Text = PODataGrid.SelectedRows[0].Cells[0].Value.ToString();
            VPODatePur.Value = Convert.ToDateTime(PODataGrid.SelectedRows[0].Cells[1].Value.ToString());
            VPOTimePurc.Value = Convert.ToDateTime(PODataGrid.SelectedRows[0].Cells[2].Value.ToString());
            VPOSupnme.Text = PODataGrid.SelectedRows[0].Cells[4].Value.ToString();
            VPOSupId.Text = PODataGrid.SelectedRows[0].Cells[3].Value.ToString();
            VOPurQty.Text = PODataGrid.SelectedRows[0].Cells[7].Value.ToString();
            VOPurTotAmt.Text = PODataGrid.SelectedRows[0].Cells[8].Value.ToString();
            VOPurVatAmt.Text = PODataGrid.SelectedRows[0].Cells[9].Value.ToString();
            VPOVatPer.Text = PODataGrid.SelectedRows[0].Cells[10].Value.ToString();
            VPOStatus.Text = PODataGrid.SelectedRows[0].Cells[11].Value.ToString();
            VPOBalance.Text = PODataGrid.SelectedRows[0].Cells[12].Value.ToString();
            VPODeposit.Text = PODataGrid.SelectedRows[0].Cells[13].Value.ToString();
            VPOFullPaymnt.Text = PODataGrid.SelectedRows[0].Cells[14].Value.ToString();
            UndersupplyTxt.Text = PODataGrid.SelectedRows[0].Cells[17].Value.ToString();




        }

        private void VPONumtxt_TextChanged(object sender, EventArgs e)
        {
            if (VPONumtxt.Text != "")
            {
                BalloonKingdomDataSetTableAdapters.PO_ItemsTableAdapter viewpo = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PO_ItemsTableAdapter();
                POitemsdatagrid.DataSource = viewpo.ViewPOItems(Convert.ToInt32(VPONumtxt.Text.Trim()));
            }
            else
            {
                POitemsdatagrid.DataSource = "none";

            }
        }

        private void POitemsdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            POItemIDtxt.Text = POitemsdatagrid.SelectedRows[0].Cells[0].Value.ToString();
            POCatNametxt.Text = POitemsdatagrid.SelectedRows[0].Cells[3].Value.ToString();
            POSubCatTxt.Text = POitemsdatagrid.SelectedRows[0].Cells[5].Value.ToString();
            POSpecCatTxt.Text = POitemsdatagrid.SelectedRows[0].Cells[4].Value.ToString();
            POItmNmeTxt.Text = POitemsdatagrid.SelectedRows[0].Cells[6].Value.ToString();
            POSizeTxt.Text = POitemsdatagrid.SelectedRows[0].Cells[7].Value.ToString();
            POColorTxt.Text = POitemsdatagrid.SelectedRows[0].Cells[8].Value.ToString();
            POHeightTxt.Text = POitemsdatagrid.SelectedRows[0].Cells[9].Value.ToString();
            POWidthTxt.Text = POitemsdatagrid.SelectedRows[0].Cells[10].Value.ToString();
            POUnitTxt.Text = POitemsdatagrid.SelectedRows[0].Cells[12].Value.ToString();
            POQtyTxt.Text = POitemsdatagrid.SelectedRows[0].Cells[11].Value.ToString();
            POUnitPrcTxt.Text = POitemsdatagrid.SelectedRows[0].Cells[13].Value.ToString();
            POSubtotalLbl.Text = POitemsdatagrid.SelectedRows[0].Cells[14].Value.ToString();
            POQtyRcvTxt.Text = POitemsdatagrid.SelectedRows[0].Cells[15].Value.ToString();
            POUnderSupTxt.Text = POitemsdatagrid.SelectedRows[0].Cells[16].Value.ToString();


        }


        private void POViewAllBtn_Click(object sender, EventArgs e)
        {
            BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter getrec = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter();
            PODataGrid.DataSource = getrec.GetPORec();
            if (VPOSupId.Text != "")
            {
                BalloonKingdomDataSetTableAdapters.PO_ItemsTableAdapter viewitem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PO_ItemsTableAdapter();
                viewitem.ViewPOItems(Convert.ToInt32(VPONumtxt.Text));
                POitemsdatagrid.DataSource = "none";
            } VPONumtxt.Text = "";
            VPOSupnme.Text = "";
            VPOSupId.Text = "";
            VPODatePur.Value = DateTime.Today;
            VPOTimePurc.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;
            VOPurQty.Text = "";
            VOPurTotAmt.Text = "";
            VPOVatPer.Text = "";
            VOPurVatAmt.Text = "";
            VPOBalance.Text = "";
            VPODeposit.Text = "";
            VPOFullPaymnt.Text = "";
            VPOStatus.Text = "None";
            POItemIDtxt.Text = "";
            POCatNametxt.Text = "";
            POSpecCatTxt.Text = "";
            POSubCatTxt.Text = "";
            POItmNmeTxt.Text = "";
            POItmTypTxt.Text = "";
            POSizeTxt.Text = "";
            POColorTxt.Text = "";
            POHeightTxt.Text = "";
            POWidthTxt.Text = "";
            POUnitTxt.Text = "";
            POQtyTxt.Text = "";
            POUnitPrcTxt.Text = "";
            POSubtotalLbl.Text = "None";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            int ans = Convert.ToInt32(MessageBox.Show("Are you sure you want to process this purchase order?", "Process", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (ans == 6)
            {
                int totqty = 0;
                SqlCommand cmdtotqty = new SqlCommand("Select * from [PO Items] where [POF Number]=" + "'" + Convert.ToString(POFID) + "'", conn);
                SqlDataReader drtotqty = cmdtotqty.ExecuteReader();
                while (drtotqty.Read())
                {
                    totqty += Convert.ToInt32(drtotqty["Quantity"].ToString());



                }
                drtotqty.Close();
                double down = 0, full = 0;
                if (PurdownRBtn.Checked == true)
                {
                    down = Convert.ToDouble(PurDowntxt.Text.Trim());
                    full = 0;
                }
                else
                {
                    down = 0;
                    full = Convert.ToDouble(PurTotalLbl.Text.Trim());
                }


                CreatePOPanel.Visible = false;
                ViewPOPanel.Visible = true;
                BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter procPO = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter();
                procPO.ProcessPO(totqty, Convert.ToDecimal(PurAmtLbl.Text.Trim()), Convert.ToDecimal(PurTotLabel.Text), Convert.ToInt32(PurVattxt.Text.Trim()), "Pending", Convert.ToDecimal(PurBalLabel.Text.Trim()), Convert.ToDecimal(down), Convert.ToDecimal(full), Convert.ToDecimal(totqty), POFID);
                BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter getrec = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter();
                PODataGrid.DataSource = getrec.GetPORec();

                int pof = POFID;
                POF_Printing poff = new POF_Printing(pof);
                poff.ShowDialog();


                BackOrderDataGrid.DataSource = "none";
                POItemCart.DataSource = "none";
                PurItemIDtxt.Text = "";
                PurCatNametxt.Text = "";
                PurSpecCattxt.Text = "";
                PurSubCattxt.Text = "";
                PurItemNametxt.Text = "";
                PurtTypetxt.Text = "";
                PurSizetxt.Text = "";
                PurColortxt.Text = "";
                PurHeighttxt.Text = "";
                PurWidthtxt.Text = "";
                PurUnitText.Text = "";
                PurQtytxt.Text = "";
                PurtoOrderTxt.Text = "";
                PurQtyStocktxt.Text = "";
                PurUnitPricetxt.Text = "";
                UnitPrceTxt.Text = "";
                posubtotlbl.Text = "None";
                PurAmtLbl.Text = "None";
                PurVattxt.Text = "12";
                POSearchTxt.Text = "";
                PurTotLabel.Text = "None";
                PurDowntxt.Text = "";
                PurdownRBtn.Checked = true;
                PurBalLabel.Text = "None";
                PurTotalLbl.Text = "None";
                POUpdateQty.Enabled = false;
                PurProcessBtn.Enabled = false;
                CancelPOPic.Enabled = false;
                SearchGroupBox.Enabled = false;
                ItemInfoBox.Enabled = false;
                POPayBox.Enabled = false;

            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            VPONumtxt.Text = "";
            VPOSupnme.Text = "";
            VPOSupId.Text = "";
            VPODatePur.Value = DateTime.Today.Date;
            VPOTimePurc.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Today.Date;
            dateTimePicker1.Value = DateTime.Now;
            VOPurQty.Text = "";
            VOPurTotAmt.Text = "";
            VPOVatPer.Text = "";
            VOPurVatAmt.Text = "";
            VPOBalance.Text = "";
            VPODeposit.Text = "";
            VPOFullPaymnt.Text = "";
            VPOStatus.Text = "None";
            POItemIDtxt.Text = "";
            POCatNametxt.Text = "";
            POSpecCatTxt.Text = "";
            POSubCatTxt.Text = "";
            POItmNmeTxt.Text = "";
            POItmTypTxt.Text = "";
            POSizeTxt.Text = "";
            POColorTxt.Text = "";
            POHeightTxt.Text = "";
            POWidthTxt.Text = "";
            POUnitTxt.Text = "";
            POQtyTxt.Text = "";
            POUnitPrcTxt.Text = "";
            POSubtotalLbl.Text = "None";
            UndersupplyTxt.Text = "";
        }

        private void RcvItemsPanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand under = new SqlCommand("Select * from ");

            RcvPOItemIDtxt.Text = RcvItemsPanel.SelectedRows[0].Cells[0].Value.ToString();
            POUndersuppTxt.Text = RcvItemsPanel.SelectedRows[0].Cells[16].Value.ToString();
            RcvQtytxt.Text = RcvItemsPanel.SelectedRows[0].Cells[11].Value.ToString();
            RcvFullybtn.Enabled = true;
            RcvQtyRcvtxt.Enabled = true;
            int un = Convert.ToInt32(RcvItemsPanel.SelectedRows[0].Cells[16].Value.ToString());
            if (un == 0)
            {
                RcvFullybtn.Enabled = false;
                RcvQtyRcvtxt.Enabled = false;
            }
            else
            {
                RcvFullybtn.Enabled = true;
                RcvQtyRcvtxt.Enabled = true;
                RcvQtyRcvtxt.Focus();
            }
        }

        private void RcvFullybtn_Click(object sender, EventArgs e)
        {
            int recv = Convert.ToInt32(RcvQtyRcvtxt.Text.Trim());
            int pun = Convert.ToInt32(POUndersuppTxt.Text.Trim());
            if (recv > pun)
            {
                MessageBox.Show("Cannot input received greater than the undersupplied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RcvQtyRcvtxt.Text = "";
                RcvQtyRcvtxt.Focus();
                purpasstxt.Text = "";
            }
            else if (purpasstxt.Text!=syspass)
            {
             MessageBox.Show("Invalid System Password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RcvQtyRcvtxt.Text = "";
                RcvQtyRcvtxt.Focus();

                purpasstxt.Text = "";
            
            }
            else if(purpasstxt.Text=="" || RcvQtyRcvtxt.Text.Trim()=="")
            {
                MessageBox.Show("Please fill up the required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RcvQtyRcvtxt.Text = "";
                RcvQtyRcvtxt.Focus();

                purpasstxt.Text = "";

            }
            else
            {



                undersup = pun - recv;



                SqlCommand updatercv = new SqlCommand("update [PO Items] set [Quantity Received]=" + "'" + RcvQtyRcvtxt.Text + "'" + "," + " [Undersupplied]=" + "'" + Convert.ToString(undersup) + "'" + "where [Item ID]=" + "'" + RcvPOItemIDtxt.Text + "'", conn);
                updatercv.ExecuteNonQuery();

                SqlCommand qty = new SqlCommand("Select Quantity from Inventory where [item ID]=" + "'" + RcvPOItemIDtxt.Text + "'", conn);
                int qty1 = Convert.ToInt32(qty.ExecuteScalar());
                SqlCommand stoc = new SqlCommand("Select [Quantity in Stock] from Inventory where [item ID]=" + "'" + RcvPOItemIDtxt.Text + "'", conn);
                double stock = Convert.ToDouble(stoc.ExecuteScalar());

                SqlCommand bo = new SqlCommand("Select [Back Order] from Inventory where [item ID]=" + "'" + RcvPOItemIDtxt.Text + "'", conn);
                double back = Convert.ToDouble(bo.ExecuteScalar());
                qty1 += recv;
                stock += Convert.ToDouble(recv);
                double totbac = 0;
                totbac = back - recv;
                if (totbac < 0)
                    totbac = 0;
               
                SqlCommand updatercvinv = new SqlCommand("update Inventory set [Quantity]=" + "'" + Convert.ToString(qty1) + "'" + "," + " [Quantity in Stock]=" + "'" + Convert.ToString(stock) + "'" +","+"[Back Order]="+"'"+Convert.ToString(totbac)+"'"+ "where [Item ID]=" + "'" + RcvPOItemIDtxt.Text + "'", conn);
                updatercvinv.ExecuteNonQuery();

                RcvFullybtn.Enabled = false;
                MessageBox.Show("Successfully received item.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RcvQtyRcvtxt.Enabled = false;
                RcvQtyRcvtxt.Text = "";
                BalloonKingdomDataSetTableAdapters.PO_ItemsTableAdapter viewitem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PO_ItemsTableAdapter();
                RcvItemsPanel.DataSource = viewitem.ViewPOItems(Convert.ToInt32(VPONumtxt.Text));

            }
        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderingPanel.Visible = false;
            Orderpanel.Visible = false;
            CustomerPanel.Visible = false;
            Inventorypanel.Visible = true;
            Supplierpanel.Visible = false;
            PurchasingPanel.Visible = false;
            BackgndPanel.Visible = false;
            ReturnRentPanel.Visible = false;
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category cat = new Category(syspass);
            cat.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (POSearchTxt.Text != "")
            {

                try
                {
                    int a = Convert.ToInt32(InvSearchtxt.Text.Trim());
                    BalloonKingdomDataSetTableAdapters.InventoryTableAdapter SearchInvById = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                    BackOrderDataGrid.DataSource = SearchInvById.SearchByID(Convert.ToInt32(POSearchTxt.Text.Trim()));

                    //int a = Convert.ToInt32(POSearchTxt.Text.Trim());
                    //BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter SearchPO = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter();
                    //BackOrderDataGrid.DataSource = SearchPO.SearchPOFnum(a);


                }
                catch
                {


                    BalloonKingdomDataSetTableAdapters.InventoryTableAdapter SearchInvByCategoryAndName = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                    BackOrderDataGrid.DataSource = SearchInvByCategoryAndName.SearchInvByCategoryAndName(POSearchTxt.Text.Trim(), POSearchTxt.Text.Trim(), POSearchTxt.Text.Trim(), POSearchTxt.Text.Trim());
                }
                
                
                
                
                
                


            }
            else
            {
                BalloonKingdomDataSetTableAdapters.InventoryTableAdapter getAllInvData = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                BackOrderDataGrid.DataSource = getAllInvData.GetAllInventoryRec();
            }


       

        }

        private void CancelPOPic_Click(object sender, EventArgs e)
        {

            int ans = Convert.ToInt32(MessageBox.Show("Are you sure you want to quit this purchase ordering?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (ans == 6)
            {

                SqlCommand cmddelpo = new SqlCommand("delete from [PO Items] where [POF Number]=" + "'" + Convert.ToString(POFID) + "'", conn);
                cmddelpo.ExecuteNonQuery();
                BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter delpo = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter();
                delpo.DeletePO(Convert.ToInt32(POFID));
                BackOrderDataGrid.DataSource = "none";

                POItemCart.DataSource = "none";
                PurItemIDtxt.Text = "";
                ItemInfoBox.Enabled = false;
                POPayBox.Enabled = false;
                PurCatNametxt.Text = "";
                PurSpecCattxt.Text = "";
                PurSubCattxt.Text = "";
                PurItemNametxt.Text = "";
                PurtTypetxt.Text = "";
                PurSizetxt.Text = "";
                PurColortxt.Text = "";
                PurHeighttxt.Text = "";
                PurWidthtxt.Text = "";
                PurUnitText.Text = "";
                PurQtytxt.Text = "";
                PurtoOrderTxt.Text = "";
                PurQtyStocktxt.Text = "";
                PurUnitPricetxt.Text = "";
                UnitPrceTxt.Text = "";
                posubtotlbl.Text = "None";
                PurAmtLbl.Text = "None";
                PurVattxt.Text = "12";
                POSearchTxt.Text = "";
                PurTotLabel.Text = "None";
                PurDowntxt.Text = "";
                PurdownRBtn.Checked = true;
                PurBalLabel.Text = "None";
                PurTotalLbl.Text = "None";
                POUpdateQty.Enabled = false;
                PurProcessBtn.Enabled = false;
                CancelPOPic.Enabled = false;
                POChooseSupbtn.Enabled = true;
                PurFilterSupcomb.Enabled = true;
                PurSuppNameCombo.Enabled = true;
                SearchGroupBox.Enabled = false;
                ItemInfoBox.Enabled = false;
                POPayBox.Enabled = false;

            }
        }

        private void RentDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemNamelbl.Text = RentDataGrid.SelectedRows[0].Cells[6].Value.ToString();
            RentItemIDlbl.Text = RentDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            CatNamelbl.Text = RentDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            SpecCatlbl.Text = RentDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            SubCatlbl.Text = RentDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            QtyOrlbl.Text = RentDataGrid.SelectedRows[0].Cells[14].Value.ToString();
            Unitlbl.Text = RentDataGrid.SelectedRows[0].Cells[15].Value.ToString();
            Lostlbl.Text = RentDataGrid.SelectedRows[0].Cells[18].Value.ToString();

            UnitRetLBL.Text = RentDataGrid.SelectedRows[0].Cells[13].Value.ToString();
            RentStatusGrpBox.Enabled = true;
            RentOKBtn.Enabled = true;

            //SqlCommand cmdgetid = new SqlCommand("Select * from [Rental Checklist] where [COF Number]=" + "'" + COFNumLbl.Text + "'" + "And [Item ID]=" + "'" + RentItemIDlbl.Text+ "'", conn);
            //SqlDataReader drgid = cmdgetid.ExecuteReader();
            //while (drgid.Read())
            //{ 
            //if(drgid["ID"]=="Yes")



            //}
            //drgid.Close();
            //int retit = Convert.ToInt32(RentDataGrid.SelectedRows[0].Cells[19].Value.ToString());
            //int qty = Convert.ToInt32(RentDataGrid.SelectedRows[0].Cells[14].Value.ToString());
            //if (retit != qty)
            //{
            //    RentStatusGrpBox.Enabled = true;
            //    RentOKBtn.Enabled = true;
            //}
            //else
            //{
            //    RentStatusGrpBox.Enabled = false;
            //    RentOKBtn.Enabled = false;

            //}
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

            int qty = Convert.ToInt32(QtyOrlbl.Text);
            double unit = Convert.ToDouble(Unitlbl.Text);
            int ret = 0, tot = 0;
            double subtot = 0;
            try
            {
                if (RentReturnQtytxt.Text == "")
                    ret = 0;
                else
                    ret = Convert.ToInt32(RentReturnQtytxt.Text.Trim());
                if (ret > qty)
                {
                    RentReturnQtytxt.Text = "";
                    ret = 0;
                }
                else
                {
                    tot = qty - ret;
                    itemlost = tot;
                    subtot = Convert.ToDouble(tot) * unit;
                    SubCostlbl.Text = Convert.ToString(subtot);

                }
            }
            catch
            {
                RentReturnQtytxt.Text = "";

            }
        }

        private void RentOKBtn_Click(object sender, EventArgs e)
        {

            int lost = 0, ret = 0, qty = 0;
            double sto = 0, or = 0;

            double retu = 0, lostite = 0;
            SqlCommand cmdinv = new SqlCommand("Select * from Inventory where [Item ID]=" + "'" + RentItemIDlbl.Text + "'", conn);
            SqlDataReader drinv = cmdinv.ExecuteReader();
            while (drinv.Read())
            {

                lost = Convert.ToInt32(drinv["Lost Item"].ToString());
                ret = Convert.ToInt32(drinv["Returned Item"].ToString());
                qty = Convert.ToInt32(drinv["Quantity"].ToString());

                sto = Convert.ToDouble(drinv["Quantity in Stock"].ToString());

                or = Convert.ToDouble(drinv["Quantity in Order"].ToString());
            }
            drinv.Close();

            double lostitem = 0, qtyitem = 0;
            SqlCommand cmditem2 = new SqlCommand("Select * from Item where [COF Number]=" + "'" + COFNumLbl.Text + "'" + "AND [Item ID]=" + "'" + RentItemIDlbl.Text + "'", conn);
            SqlDataReader dritem2 = cmditem2.ExecuteReader();
            while (dritem2.Read())
            {
                retu = Convert.ToDouble(dritem2["Returned Item"].ToString());
                lostite = Convert.ToDouble(dritem2["Lost Item"].ToString());
                qtyitem = Convert.ToDouble(dritem2["Quantity"].ToString());

            }
            dritem2.Close();
            lostitem = lostite;
            if (ReturnedRtbn.Checked == true)
            {
                try
                {
                    double retTxt = Convert.ToDouble(RentReturnQtytxt.Text);



                    sto += Convert.ToDouble(RentReturnQtytxt.Text);

                    qty += Convert.ToInt32(RentReturnQtytxt.Text);
                    retu += retTxt;
                    ret += Convert.ToInt32(RentReturnQtytxt.Text);
                    lostite = qtyitem - retu;
                    lost = lost - Convert.ToInt32(lostitem) + Convert.ToInt32(lostite);

                    if (retu > Convert.ToDouble(QtyOrlbl.Text))
                    { MessageBox.Show("Cannot return greater than what is rented!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {
                        SqlCommand updateitem = new SqlCommand("Update Item set [Lost Item]=" + "'" + Convert.ToString(lostite) + "'" + "," + "[Returned Item]=" + "'" + Convert.ToString(retu) + "'" + "where [COF Number]=" + "'" + COFNumLbl.Text + "'" + "AND [Item ID]=" + "'" + RentItemIDlbl.Text + "'", conn);
                        updateitem.ExecuteNonQuery();
                        BalloonKingdomDataSetTableAdapters.InventoryTableAdapter upinvretandlos = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                        upinvretandlos.UpdateInvLostandRet(qty, Convert.ToDecimal(sto), lost, ret, Convert.ToInt32(RentItemIDlbl.Text), Convert.ToInt32(RentItemIDlbl.Text));

                    }

                }
                catch
                { }
            }
            else if (RemoveRbtn.Checked == true)
            {
                double remitem = 0;
                if (RemoveTxt.Text == "")
                    remitem = 0;
                else
                    remitem = Convert.ToDouble(RemoveTxt.Text);
                retu -= remitem;
                lostite += remitem;
                int varnew = Convert.ToInt32(lostite) - lost;

                qty -= varnew;
                sto -= varnew;


                lost += Convert.ToInt32(RemoveTxt.Text);

                ret -= Convert.ToInt32(RemoveTxt.Text);

                if (retu < 0)
                { MessageBox.Show("Cannot remove item greater than returned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    SqlCommand updateitem = new SqlCommand("Update Item set [Lost Item]=" + "'" + Convert.ToString(lostite) + "'" + "," + "[Returned Item]=" + "'" + Convert.ToString(retu) + "'" + "where [COF Number]=" + "'" + COFNumLbl.Text + "'" + "AND [Item ID]=" + "'" + RentItemIDlbl.Text + "'", conn);
                    updateitem.ExecuteNonQuery();


                    BalloonKingdomDataSetTableAdapters.InventoryTableAdapter upinvretandlos = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                    upinvretandlos.UpdateInvLostandRet(qty, Convert.ToDecimal(sto), lost, ret, Convert.ToInt32(RentItemIDlbl.Text), Convert.ToInt32(RentItemIDlbl.Text));


                }

            }



            double returned = 0, lost1 = 0;
            double total = 0, unit = 0;
            SqlCommand cmditem1 = new SqlCommand("Select * from Item where [COF Number]=" + "'" + COFNumLbl.Text + "'", conn);
            SqlDataReader dritem1 = cmditem1.ExecuteReader();
            while (dritem1.Read())
            {
                returned += Convert.ToDouble(dritem1["Returned Item"].ToString());
                lost1 += Convert.ToDouble(dritem1["Lost Item"].ToString());
                unit = Convert.ToDouble(dritem1["Unit Cost"].ToString());
                total += Convert.ToDouble(lost1) * unit;
            }
            dritem1.Close();
            double depo = Convert.ToDouble(DepositRentTxt.Text);
            double refund = 0;
            refund = depo - total;
            refundRenttxt.Text = Convert.ToString(refund);
            returnedLbl.Text = Convert.ToString(returned);
            RetLostItemLbl.Text = Convert.ToString(lost1);
            Totlbl.Text = Convert.ToString(total);


            BalloonKingdomDataSetTableAdapters.ItemTableAdapter showrent = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.ItemTableAdapter();
            RentDataGrid.DataSource = showrent.ViewRentItem(Convert.ToInt32(COFNumLbl.Text));

            RentOKBtn.Enabled = false;
            RentStatusGrpBox.Enabled = false;
            RentProcessbtn.Enabled = true;
            RentReturnQtytxt.Text = "";
            RemoveTxt.Text = "";


        }

        private void RentProcessbtn_Click(object sender, EventArgs e)
        {


            if (ReturnRentCHKTxt.Text.Trim() == "" || RecReturnChkTxt.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up the required fields in the recording info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                int ans = Convert.ToInt32(MessageBox.Show("Are you sure you want to process this payment?", "Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (ans == 6)
                {
                    string[] retu = new string[3000];
                    string[] itid = new string[3000];
                    string[] lostch = new string[3000];
                    int c = 0;
                    SqlCommand cmdret = new SqlCommand("Select * from Item where [COF Number]=" + "'" + COFNumLbl.Text + "'", conn);
                    SqlDataReader drret = cmdret.ExecuteReader();
                    while (drret.Read())
                    {
                        itid[c] = drret["Item ID"].ToString();
                        retu[c] = drret["Returned Item"].ToString();
                        lostch[c] = drret["Lost Item"].ToString();
                        c++;

                    }
                    drret.Close();






                    int id2 = 0, a = 0;
                    string id;
                    SqlCommand cmdrepro = new SqlCommand("Select * from [Rented Items]", conn);
                    SqlDataReader drrepro = cmdrepro.ExecuteReader();
                    while (drrepro.Read())
                    {
                        id = drrepro["Returned Item ID"].ToString();
                        id2 = Convert.ToInt32(id);
                        if (a < id2)
                            a = id2;


                    }
                    drrepro.Close();
                    a++;
                    double amt = 0, paym = 0;
                    string stat = "None";
                    amt = Convert.ToDouble(RentAmtTotLbl.Text);
                    double indlost = Convert.ToDouble(Totlbl.Text);
                    if (indlost > 0)
                    {

                        paym = indlost;
                        stat = "Paid";
                        PayStatLbl.Text = "Processed";
                        MessageBox.Show("Lost Items has been paid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand gettot = new SqlCommand("Select Total from Orderline where [COF Number]=" + "'" + COFNumLbl.Text + "'", conn);
                        int full = Convert.ToInt32(gettot.ExecuteScalar());

                        SqlCommand updatepay = new SqlCommand("Update Orderline set Status='Processed', [Down payment]='0.00', [Full payment]=" + "'" + Convert.ToString(full) + "'" + "where [COF Number]=" + "'" + COFNumLbl.Text + "'", conn);
                        updatepay.ExecuteNonQuery();
                        BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter ViewOrderlinerec = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                        OrderlineDataGrid.DataSource = ViewOrderlinerec.ViewOrderline();
                    }
                    else
                    {

                        paym = 0;
                        stat = "Processed";
                        PayStatLbl.Text = "Processed";
                        MessageBox.Show("Rented item has been successfully returned to inventory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand gettot = new SqlCommand("Select Total from Orderline where [COF Number]=" + "'" + COFNumLbl.Text + "'", conn);
                        int full = Convert.ToInt32(gettot.ExecuteScalar());


                        SqlCommand updatepay = new SqlCommand("Update Orderline set Status='Processed', [Down payment]='0.00', [Full payment]=" + "'" + Convert.ToString(full) + "'" + "where [COF Number]=" + "'" + COFNumLbl.Text + "'", conn);
                        updatepay.ExecuteNonQuery();
                        BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter ViewOrderlinerec = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                        OrderlineDataGrid.DataSource = ViewOrderlinerec.ViewOrderline();
                    }


                    SqlCommand addsub = new SqlCommand("Select sum([Sub Cost]) from Item where [COF Number]=" + "'" + COFNumLbl.Text + "'" + "AND Type='Rental'", conn);
                    double totrentamt = Convert.ToDouble(addsub.ExecuteScalar());

                    BalloonKingdomDataSetTableAdapters.Rented_ItemsTableAdapter addnewrentitem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Rented_ItemsTableAdapter();
                    addnewrentitem.AddNewRent(a, Convert.ToInt32(COFNumLbl.Text), Convert.ToInt32(CustIDlbl.Text), DateTime.Today, DateTime.Today, Convert.ToInt32(overallrentedLbl.Text), Convert.ToInt32(returnedLbl.Text), Convert.ToInt32(RetLostItemLbl.Text.Trim()), Convert.ToDecimal(amt), Convert.ToDecimal(paym), stat);

                    for (b = 0; b < c; b++)
                    {
                        SqlCommand upchk = new SqlCommand("Update [Rental Checklist] set [Quantity IN]=" + "'" + retu[b] + "'" + "," + "[Date IN]=" + "'" + DateINPic.Value + "'" + "," + "[Time IN]=" + "'" + TimeINDP.Value + "'" + "," + "[Quantity Missing]=" + "'" + lostch[b] + "'" + "," + "[Returned By]=" + "'" + ReturnRentCHKTxt.Text.Trim() + "'" + "," + "[Recorded Return By]=" + "'" + RecReturnChkTxt.Text.Trim() + "'" + "," + "[ID]=" + "'" + returnid + "'" + "," + "[Refund Amount]=" + "'" + refundRenttxt.Text + "'" + "," + "[Rental Amount]=" + "'" + Convert.ToString(totrentamt) + "'", conn);
                        upchk.ExecuteNonQuery();
                    }

                    int ida = 0, d = 0;
                    string idd;
                    SqlCommand cmdrepro1 = new SqlCommand("Select * from [Rental Refund]", conn);
                    SqlDataReader drrepro1 = cmdrepro1.ExecuteReader();
                    while (drrepro1.Read())
                    {
                        idd = drrepro1["Rental Refund ID"].ToString();
                        ida = Convert.ToInt32(idd);
                        if (d < ida)
                            d = ida;


                    }
                    drrepro1.Close();
                    d++;
                    BalloonKingdomDataSetTableAdapters.Rental_RefundTableAdapter addrental = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Rental_RefundTableAdapter();
                    addrental.AddRentalRefund(d, Convert.ToInt32(COFNumLbl.Text), DateTime.Today, DateTime.Today, Convert.ToDecimal(refundRenttxt.Text), Convert.ToDecimal(RentAmtTotLbl.Text));
                    COFNumLbl.Text = "None";
                    CustIDlbl.Text = "None";

                    RentItemIDlbl.Text = "None";
                    ItemNamelbl.Text = "None";
                    CatNamelbl.Text = "None";
                    SpecCatlbl.Text = "None";
                    SubCatlbl.Text = "None";
                    Lostlbl.Text = "None";

                    QtyOrlbl.Text = "0";
                    Unitlbl.Text = "0";

                    SubCostlbl.Text = "0.00";
                    Totlbl.Text = "0.00";

                    RentReturnQtytxt.Text = "";
                    RemoveTxt.Text = "";

                    ReturnedRtbn.Checked = true;
                    RentProcessbtn.Enabled = false;
                    RentOKBtn.Enabled = false;

                    ReturnRentPanel.Visible = false;
                    Orderpanel.Visible = true;

                }

            }
            BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter ViewOrderlinerec1 = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
            OrderlineDataGrid.DataSource = ViewOrderlinerec1.ViewOrderline();

        }

        private void VATPercenttxt_TextChanged(object sender, EventArgs e)
        {
            double totamt = 0, vat = 0, per = 0;
            totamt = Convert.ToDouble(TotalAmtTxt.Text);
            if (VATPercenttxt.Text != "")
                vat = Convert.ToDouble(VATPercenttxt.Text);
            else
                vat = 0;
            per = vat / 100;
            vat = totamt * per;

            VATAmttxt.Text = Convert.ToString(vat);
        }



        private void returnRentItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (COFNumLbl.Text != "None")
            { 
             BackgndPanel.Visible = false;
                OrderingPanel.Visible = false;
                CustomerPanel.Visible = false;
                Inventorypanel.Visible = false;
                Orderpanel.Visible = false;
                Supplierpanel.Visible = false;
                SecurityPanel.Visible = false;
                PurchasingPanel.Visible = false;
                ReturnRentPanel.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            RentReturnQtytxt.Enabled = true;
            RemoveTxt.Enabled = false;
            RentReturnQtytxt.Text = "";
            RentReturnQtytxt.Focus();
        }

        private void RemoveRbtn_CheckedChanged(object sender, EventArgs e)
        {

            RentReturnQtytxt.Enabled = false;
            RemoveTxt.Enabled = true;
            RemoveTxt.Text = "";
            RemoveTxt.Focus();

        }

        private void deletepick_Click(object sender, EventArgs e)
        {
            if (PayStatLbl.Text == "Processed" || PayStatLbl.Text == "Waiting" || PayStatLbl.Text == "Cancelled")
            {
                MessageBox.Show("Cannot cancel Processed, Waiting or already Cancelled order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (COForderlinetxt.Text == "")
            {

                MessageBox.Show("Please select Order to cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int ans = Convert.ToInt32(MessageBox.Show("Are you sure you want to cancel this order. Note: Ordered items will be returned to inventory.", "Delete prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (ans == 6)
                {

                    int[] id = new int[3000];
                    int[] bo = new int[3000];
                    int[] qty = new int[300];
                    int a = 0;
                    SqlCommand cmd321 = new SqlCommand("Select * from Item where [COF Number]=" + "'" + COForderlinetxt.Text.Trim() + "'", conn);
                    SqlDataReader dr321 = cmd321.ExecuteReader();
                    while (dr321.Read())
                    {

                        id[a] = Convert.ToInt32(dr321["Item ID"].ToString());
                        bo[a] = Convert.ToInt32(dr321["Back Order"].ToString());
                        qty[a] = Convert.ToInt32(dr321["Quantity"].ToString());
                        a++;
                    }
                    dr321.Close();
                    double invst = 0, invor = 0, invbo = 0;
                    for (int c = 0; c < a; c++)
                    {

                        SqlCommand cmd111 = new SqlCommand("Select * from Inventory where [Item ID]=" + "'" + Convert.ToString(id[b]) + "'", conn);
                        SqlDataReader dr111 = cmd111.ExecuteReader();
                        while (dr111.Read())
                        {

                            invst = Convert.ToDouble(dr111["Quantity in Stock"].ToString());

                            invor = Convert.ToDouble(dr111["Quantity in Order"].ToString());
                            invbo = Convert.ToDouble(dr111["Back Order"].ToString());


                        }
                        dr111.Close();
                        int tot = 0;
                        if (bo[c] > 0)
                        {
                            tot = qty[c] - bo[c];
                            invbo -= bo[c];
                            invor -= tot;
                            invst += tot;


                        }
                        else
                        {
                            invor = invor - qty[c];
                            invst += Convert.ToDouble(qty[c]);

                        }

                        bo[c] = 0;

                        //update inv backorder
                        BalloonKingdomDataSetTableAdapters.InventoryTableAdapter backorder = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                        backorder.UpdateBackOrder(Convert.ToInt32(invbo), id[c], id[c]);



                        //update item back order
                        SqlCommand cmd25 = new SqlCommand("update Item set [Back Order] =" + "'" + Convert.ToString(bo[c]) + "'" + " where [COF Number] =" + "'" + COForderlinetxt.Text + "'" + "AND [Item ID]=" + "'" + id[c] + "'", conn);
                        cmd25.ExecuteNonQuery();


                        //update inventory order and stock

                        BalloonKingdomDataSetTableAdapters.InventoryTableAdapter upditem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                        upditem.UpdateInvItem(Convert.ToInt32(invst), Convert.ToInt32(invor), id[c], id[c]);
                        Removeitembtn.Enabled = false;


                        SqlCommand updateCOF = new SqlCommand("Update Orderline set Status='Cancelled', Balance='0' where [COF Number]=" + "'" + COForderlinetxt.Text.Trim() + "'", conn);
                        updateCOF.ExecuteNonQuery();
                        //update orderline amounts
                        SqlCommand getdown = new SqlCommand("Select [Down payment] from Orderline where [COF Number]=" + "'" + COForderlinetxt.Text.Trim() + "'", conn);
                        double overdown = Convert.ToDouble(getdown.ExecuteScalar());

                        SqlCommand getfull = new SqlCommand("Select [Down payment] from Orderline where [COF Number]=" + "'" + COForderlinetxt.Text.Trim() + "'", conn);
                        double overfull = Convert.ToDouble(getfull.ExecuteScalar());

                        double overtot = overdown + overfull;

                        SqlCommand getref = new SqlCommand("Select [Refund] from Orderline where [COF Number]=" + "'" + COForderlinetxt.Text.Trim() + "'", conn);
                        double refun = Convert.ToDouble(getref.ExecuteScalar());

                        double totser = overtot * 0.20;
                        refun += overtot - totser;


                        SqlCommand updateorder = new SqlCommand("Update Orderline set [Service Charge]=" + "'" + Convert.ToString(totser) + "'" + "," + "[Refund]=" + "'" + Convert.ToString(refun) + "'" + ",[Full payment]=0, [Down payment]=0 where [COF Number]=" + "'" + COForderlinetxt.Text.Trim() + "'", conn);
                        updateorder.ExecuteNonQuery();
                        ORLbl.Text = "None";
                        QtyOLLbl.Text = "None";
                        PayStatLbl.Text = "None";
                        TotItemOLLbl.Text = "None";
                        RentOLLbl.Text = "None";
                        OrderOLLbl.Text = "None";
                        TotAmtOLLbl.Text = "None";
                        POOveAllLbl.Text = "None";
                        Searchordertxt.Text = "";
                        DateOfOrdertxt.Value = DateTime.Today;
                        Fnameorderlinetxt.Text = "";
                        MidNameOLTxt.Text = "";
                        LNOrderLineTxt.Text = "";
                        EventDateOLTxt.Value = DateTime.Today;
                        ThemeOLTxt.Text = "";
                        EventTimePickOL.Value = DateTime.Today;
                        VenueOLTxt.Text = "";
                        COForderlinetxt.Text = "";
                        ORCustID.Text = "";
                        OrOrAmttxt.Text = "";
                        OrBaltxt.Text = "";
                        OrServicetxt.Text = "";
                        PORefAmtTxt.Text = "";
                        OrDowntxt.Text = "";
                        OrFulltxt.Text = "";
                        TotAmtOLLbl.Text = "None";
                        ORMotifTxt.Text = "";
                        ORVATAmtTxt.Text = "";
                        ORDiscountTxt.Text = "";

                       

                    }
                    MessageBox.Show("Order has been successfully cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter ViewOrderlinerec = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                    OrderlineDataGrid.DataSource = ViewOrderlinerec.ViewOrderline();
                }
            }
















        }



        private void DoneBtn_Click(object sender, EventArgs e)
        {
            ReceivedPOPanel.Visible = false;
            ViewPOPanel.Visible = true;
            SqlCommand sumunder = new SqlCommand("Select sum(Undersupplied) from Purchase where [POF Number]=" + "'" + RcvPOIDtxt.Text + "'", conn);
            int undersupp = Convert.ToInt32(sumunder.ExecuteScalar());

            SqlCommand updatepof = new SqlCommand("Update Purchase set Undersupplied=" + "'" + Convert.ToString(undersup) + "'" + "where [POF Number]=" + "'" + RcvPOIDtxt.Text + "'", conn);
            updatepof.ExecuteNonQuery();
            BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter getrec = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter();
            PODataGrid.DataSource = getrec.GetPORec();
            if (VPOSupId.Text != "")
            {
                BalloonKingdomDataSetTableAdapters.PO_ItemsTableAdapter viewitem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PO_ItemsTableAdapter();
                viewitem.ViewPOItems(Convert.ToInt32(VPONumtxt.Text));
                POitemsdatagrid.DataSource = "none";
            } VPONumtxt.Text = "";
            VPOSupnme.Text = "";
            VPOSupId.Text = "";
            VPODatePur.Value = DateTime.Today;
            VPOTimePurc.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;
            VOPurQty.Text = "";
            VOPurTotAmt.Text = "";
            VPOVatPer.Text = "";
            VOPurVatAmt.Text = "";
            VPOBalance.Text = "";
            VPODeposit.Text = "";
            VPOFullPaymnt.Text = "";
            VPOStatus.Text = "None";
            POItemIDtxt.Text = "";
            POCatNametxt.Text = "";
            POSpecCatTxt.Text = "";
            POSubCatTxt.Text = "";
            POItmNmeTxt.Text = "";
            POItmTypTxt.Text = "";
            POSizeTxt.Text = "";
            POColorTxt.Text = "";
            POHeightTxt.Text = "";
            POWidthTxt.Text = "";
            POUnitTxt.Text = "";
            POQtyTxt.Text = "";
            POUnitPrcTxt.Text = "";
            POSubtotalLbl.Text = "None";


        }

        private void orbtn_CheckedChanged_1(object sender, EventArgs e)
        {


            double total = 0, serv = 0, down = 0;
            if (orbtn.Checked == true)
            {
                ORLbl.Text = "Yes";

                double per = 0, vat1 = 0;
                double tota = Convert.ToDouble(TotalAmtTxt.Text);
                if (VATPercenttxt.Text == "")
                    per = 0;
                else
                    per = Convert.ToDouble(VATPercenttxt.Text) / 100;
                vat1 = per * tota;
                VATAmttxt.Text = Convert.ToString(vat1);

                double vat = Convert.ToDouble(VATAmttxt.Text);

                totamt = Convert.ToDouble(TotalAmtTxt.Text);
                if (SerTxt.Text == "")
                    serv = 0;
                else
                    serv = Convert.ToDouble(SerTxt.Text);



                total = vat + serv + totamt;
                PaymentTotal.Text = Convert.ToString(total);
                Overalltxt.Text=Convert.ToString(total);
                down = total / 2;
                VatBox.Enabled = true;


                if (downRadiobtn.Checked == true)
                {
                    PaymentDownPayment.Text = Convert.ToString(down);

                    PaymentBalance.Text = Convert.ToString(tota - down);
                }
                else
                {
                    PaymentDownPayment.Text = "0";
                    PaymentBalance.Text = "0";
                }

            }
            else
            {
                ORLbl.Text = "No";
                if (SerTxt.Text == "")
                    serv = 0;
                else
                    serv = Convert.ToDouble(SerTxt.Text);
                VATAmttxt.Text = "0";

                double tota = Convert.ToDouble(TotalAmtTxt.Text);
                total = tota + serv;

                PaymentTotal.Text = Convert.ToString(total);
                Overalltxt.Text = Convert.ToString(total);
                down = total / 2;

                if (downRadiobtn.Checked == true)
                {
                    PaymentDownPayment.Text = Convert.ToString(down);

                    PaymentBalance.Text = Convert.ToString(tota - down);
                }
                else
                {
                    PaymentDownPayment.Text = "0";
                    PaymentBalance.Text = "0";
                }

            }
        }


        //           
        //        }

        //        else
        //        {
        //            VatBox.Enabled = false;
        //            VATAmttxt.Text = "0";
        //        }
        //    }


       
      

        private void COFThemetxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WaitingCartPic_Click(object sender, EventArgs e)
        {
            BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter viewwait = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
            OrderlineDataGrid.DataSource = viewwait.ViewWaitingOrder();
            ORLbl.Text = "None";
            QtyOLLbl.Text = "None";
            PayStatLbl.Text = "None";
            TotItemOLLbl.Text = "None";
            RentOLLbl.Text = "None";
            OrderOLLbl.Text = "None";
            TotAmtOLLbl.Text = "None";
            POOveAllLbl.Text = "None";
            Searchordertxt.Text = "";
            DateOfOrdertxt.Value = DateTime.Today;
            Fnameorderlinetxt.Text = "";
            MidNameOLTxt.Text = "";
            LNOrderLineTxt.Text = "";
            EventDateOLTxt.Value = DateTime.Today;
            ThemeOLTxt.Text = "";
            EventTimePickOL.Value = DateTime.Today;
            VenueOLTxt.Text = "";
            COForderlinetxt.Text = "";
            ORCustID.Text = "";
            OrOrAmttxt.Text = "";
            OrBaltxt.Text = "";
            OrServicetxt.Text = "";
            PORefAmtTxt.Text = "";
            OrDowntxt.Text = "";
            OrFulltxt.Text = "";
            TotAmtOLLbl.Text = "None";
            ORMotifTxt.Text = "";
            ORVATAmtTxt.Text = "";
            ORDiscountTxt.Text = "";
        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            double amt = Convert.ToDouble(OrOrAmttxt.Text);

            if (COForderlinetxt.Text == "")
            { MessageBox.Show("Cannot cancel processed order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (amt<=0)
            {
                MessageBox.Show("Cannot deliver unfinished ordering transaction. Please update this order to process this transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else
            {
                string renst = "Waiting";
                SqlCommand cmdget = new SqlCommand("Select * from [Rented Items] where [COF Number]=" + "'" + COForderlinetxt.Text + "'", conn);
                SqlDataReader drget = cmdget.ExecuteReader();
                while (drget.Read())
                {

                    renst = drget["Status"].ToString();



                }
                drget.Close();

                if ((PayStatLbl.Text == "Pending" && PayStatLbl.Text != "Processed") && (renst != "Processed" || renst != "Paid"))
                {
                    int ans = Convert.ToInt32(MessageBox.Show("Are you sure that the order is delivered? The quantity of this order will be deducted from the Inventory.", "Deliver Order Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                    if (ans == 6)
                    {




                        string[] itid = new string[3000];
                        string[] qtyr = new string[3000];
                        int c = 0;
                        SqlCommand cmdgetr = new SqlCommand("Select * from Item where [COF Number]=" + "'" + COForderlinetxt.Text + "'", conn);
                        SqlDataReader drgetr = cmdgetr.ExecuteReader();
                        while (drgetr.Read())
                        {

                            itid[c] = drgetr["Item ID"].ToString();
                            qtyr[c] = drgetr["Quantity"].ToString();

                            c++;

                        }
                        drgetr.Close();

                        for (int b = 0; b < c; b++)
                        {
                            double order = 0, total3 = 0, stock = 0, total4 = 0;
                            SqlCommand cmdgetin = new SqlCommand("Select * from Inventory where [Item ID]=" + "'" + itid[b] + "'", conn);
                            SqlDataReader drgetin = cmdgetin.ExecuteReader();
                            while (drgetin.Read())
                            {
                                order = Convert.ToDouble(drgetin["Quantity in Order"].ToString());
                                stock = Convert.ToDouble(drgetin["Quantity"].ToString());
                            }
                            drgetin.Close();

                            total3 = order - Convert.ToDouble(qtyr[b]);
                            total4 = stock - Convert.ToDouble(qtyr[b]);
                            SqlCommand upin = new SqlCommand("Update Inventory set [Quantity in Order]=" + "'" + Convert.ToString(total3) + "'" + "," + "[Quantity]=" + "'" + Convert.ToString(total4) + "'" + "where [Item ID]=" + "'" + itid[b] + "'", conn);
                            upin.ExecuteNonQuery();


                            SqlCommand upditem = new SqlCommand("Update Orderline set Status='Pending' where [COF Number]=" + "'" + COForderlinetxt.Text + "'", conn);
                            upditem.ExecuteNonQuery();

                        }
                        MessageBox.Show("Successfully delivered the order. Order items in this COF will be deducted from the inventory.", "Deliver Order Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        int rentaleq = Convert.ToInt32(RentOLLbl.Text);
                        if (rentaleq > 0 && PayStatLbl.Text == "Pending")
                        {
                            double totalsub = 0;
                            SqlCommand rentalamt = new SqlCommand("Select * from Item where [COF Number]=" + "'" + COForderlinetxt.Text + "'" + "AND Type='Rental'", conn);
                            SqlDataReader drrentamt = rentalamt.ExecuteReader();
                            while (drrentamt.Read())
                            {
                                totalsub += Convert.ToDouble(drrentamt["Sub Cost"].ToString());


                            }
                            drrentamt.Close();

                            string COFNumber, CustId, RentAmt;
                            COFNumber = COForderlinetxt.Text;
                            CustId = ORCustID.Text;
                            RentAmt = Convert.ToString(totalsub);

                            frmDeliverRental showdeliverrent = new frmDeliverRental(COFNumber, CustId, RentAmt,syspass);
                            showdeliverrent.ShowDialog();
                            //PayStatLbl.Text = "Waiting";
                            //SqlCommand upor = new SqlCommand("Update Orderline set Status='Waiting' where [COF Number]=" + "'" + COForderlinetxt.Text + "'", conn);
                            //upor.ExecuteNonQuery();

                        }

                    }
                    ORLbl.Text = "None";
                    QtyOLLbl.Text = "None";
                    PayStatLbl.Text = "None";
                    TotItemOLLbl.Text = "None";
                    RentOLLbl.Text = "None";
                    OrderOLLbl.Text = "None";
                    TotAmtOLLbl.Text = "None";
                    POOveAllLbl.Text = "None";
                    Searchordertxt.Text = "";
                    DateOfOrdertxt.Value = DateTime.Today;
                    Fnameorderlinetxt.Text = "";
                    MidNameOLTxt.Text = "";
                    LNOrderLineTxt.Text = "";
                    EventDateOLTxt.Value = DateTime.Today;
                    ThemeOLTxt.Text = "";
                    EventTimePickOL.Value = DateTime.Today;
                    VenueOLTxt.Text = "";
                    COForderlinetxt.Text = "";
                    ORCustID.Text = "";
                    OrOrAmttxt.Text = "";
                    OrBaltxt.Text = "";
                    OrServicetxt.Text = "";
                    PORefAmtTxt.Text = "";
                    OrDowntxt.Text = "";
                    OrFulltxt.Text = "";
                    TotAmtOLLbl.Text = "None";
                    ORMotifTxt.Text = "";
                    ORVATAmtTxt.Text = "";
                    ORDiscountTxt.Text = "";
                    BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter ViewOrderlinerec = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.OrderlineTableAdapter();
                    OrderlineDataGrid.DataSource = ViewOrderlinerec.ViewOrderline();
                }
            }
        }

        private void ReturnIDChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ReturnIDChkBox.Checked == true)
                returnid = "Yes";
            else
                returnid = "No";
        }
        private void ViewInactivCustPic_Click(object sender, EventArgs e)
        {
            BalloonKingdomDataSetTableAdapters.CustomerTableAdapter viewinactiv = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
            SearchCustdataGridView1.DataSource = viewinactiv.View_InactiveCust();
            customerSearchtxt.Text = "";
            if (custAnswer != 1)
                CustIDtxt.Text = "";
            AdCustFname.Text = "";
            AdCustMidtxt.Text = "";
            AdCustLasttxt.Text = "";
            AdCustAddtxt.Text = "";
            AdCustHnumtxt.Text = "";
            AdCustCnumtxt.Text = "";
            AdCustEadtxt.Text = "";
            ActivateCustPic.Enabled = true;
            accust = 0;
        }

        private void ActivateCustPic_Click(object sender, EventArgs e)
        {
            if (accust == 0)
            {
                int ans = Convert.ToInt32(MessageBox.Show("Are you sure you want to activate this account?", "Activate Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (ans == 6)
                {
                    BalloonKingdomDataSetTableAdapters.CustomerTableAdapter activate = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
                    activate.ActivateCustomer(Convert.ToInt32(CustIDtxt.Text));
                    MessageBox.Show("Successfully activated account!", "Activated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CustSavelbl.Visible = false;
                    custSavebtn.Visible = false;
                    AdCustFname.Enabled = false;
                    AdCustMidtxt.Enabled = false;
                    AdCustLasttxt.Enabled = false;
                    AdCustAddtxt.Enabled = false;
                    AdCustHnumtxt.Enabled = false;
                    AdCustCnumtxt.Enabled = false;
                    AdCustEadtxt.Enabled = false;
                    customerSearchtxt.Text = "";
                    if (custAnswer != 1)
                        CustIDtxt.Text = "";
                    AdCustFname.Text = "";
                    AdCustMidtxt.Text = "";
                    AdCustLasttxt.Text = "";
                    AdCustAddtxt.Text = "";
                    AdCustHnumtxt.Text = "";
                    AdCustCnumtxt.Text = "";
                    AdCustEadtxt.Text = "";
                    BalloonKingdomDataSetTableAdapters.CustomerTableAdapter viewall = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
                    SearchCustdataGridView1.DataSource = viewall.ViewAllCustRec();
                    ActivateCustPic.Enabled = false;
                    accust = 1;
                }
            }

        }

        private void orderinglist_Click(object sender, EventArgs e)
        {
            string[] idcust = new string[6000];
            int a = 0;
            SqlCommand getid = new SqlCommand("Select * from Customer", conn);
            SqlDataReader drid = getid.ExecuteReader();
            while (drid.Read())
            {

                idcust[a] = drid["Customer ID"].ToString();
                a++;

            }
            drid.Close();

            for (int b = 0; b < a; b++)
            {
                int ornum = 0, proc = 0, canc = 0, pend = 0, wait = 0;

                SqlCommand getorder = new SqlCommand("Select * from Orderline where [Customer ID]=" + "'" + idcust[b] + "'", conn);
                SqlDataReader drgetor = getorder.ExecuteReader();
                while (drgetor.Read())
                {
                    if (drgetor["Status"].ToString() == "Pending")
                        pend++;
                    else if (drgetor["Status"].ToString() == "Cancelled")
                        canc++;

                    else if (drgetor["Status"].ToString() == "Processed")
                        proc++;
                    else if (drgetor["Status"].ToString() == "Waiting")
                        wait++;

                    ornum++;
                }
                drgetor.Close();

                BalloonKingdomDataSetTableAdapters.CustomerTableAdapter updateor = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
                updateor.UpdateCustOrder(ornum, canc, proc, pend, wait, Convert.ToInt32(idcust[b]));
            }
            BalloonKingdomDataSetTableAdapters.CustomerTableAdapter view = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.CustomerTableAdapter();
            SearchCustdataGridView1.DataSource = view.ViewCustomers();

        }

        private void RcvQtyRcvtxt_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            string str;
            if (RcvQtyRcvtxt.Text != " ")
            {
                str = RcvQtyRcvtxt.Text;
                bool bl = Int64.TryParse(str, out i);

                if ((RcvQtyRcvtxt.Text == " "))
                {
                    toolTip1.Show("Enter a number!", RcvQtyRcvtxt);
                    RcvQtyRcvtxt.Clear();

                }

                else if (bl == false)
                {
                    toolTip1.Show("Enter a number!", RcvQtyRcvtxt);
                    RcvQtyRcvtxt.Clear();
                }
                toolTip1.Hide(RcvQtyRcvtxt);

            }
        }

        private void Printbtn_Click(object sender, EventArgs e)
        {
            //if (COForderlinetxt.Text == "")
            //{
            //    MessageBox.Show("Choose customer first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //}

            //else
            //{

            //    string OrderNo = COForderlinetxt.Text;
            //    //calls te form frmOrderSlip passing order no as the reference
            //    COF_Printing rpt = new COF_Printing(OrderNo);
            //    rpt.ShowDialog();

            //}
        }

        private void officialReceiptToolStripMenuItem1_Click(object sender, EventArgs e)
        {



            Choice_OR or = new Choice_OR();
            or.ShowDialog();
        }

        private void rentalChecklistToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RentalCheck chek = new RentalCheck();
            chek.ShowDialog();
        }

        private void ReturnRentCHKTxt_TextChanged(object sender, EventArgs e)
        {
            if (ReturnRentCHKTxt.Text != "")
            {
                try
                {
                    int x = 0;
                    string txt;
                    if (ReturnRentCHKTxt.Text != "")
                    {
                        txt = ReturnRentCHKTxt.Text;
                        x = txt.Length - 1;

                        if (ReturnRentCHKTxt.Text == "")
                        {
                            toolTip2.Show("Avoid special characters!", ReturnRentCHKTxt);
                            ReturnRentCHKTxt.Clear();
                            toolTip2.Hide(ReturnRentCHKTxt);
                        }

                        else if (char.IsWhiteSpace(txt[x]))
                        {
                            ReturnRentCHKTxt.Text = txt.Replace(txt[x], ' ');
                            toolTip2.Show("Avoid special characters!", ReturnRentCHKTxt);
                            toolTip2.Hide(ReturnRentCHKTxt);
                        }
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "error");
                }
            }











        }

        private void ReturnRentCHKTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz .-'`".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void RecReturnChkTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz .-'`".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void RecReturnChkTxt_TextChanged(object sender, EventArgs e)
        {
            if (RecReturnChkTxt.Text != "")
            {
                try
                {
                    int x = 0;
                    string txt;
                    if (RecReturnChkTxt.Text != "")
                    {
                        txt = RecReturnChkTxt.Text;
                        x = txt.Length - 1;

                        if (RecReturnChkTxt.Text == "")
                        {
                            toolTip2.Show("Avoid special characters!", RecReturnChkTxt);
                            RecReturnChkTxt.Clear();
                            toolTip2.Hide(RecReturnChkTxt);
                        }

                        else if (char.IsWhiteSpace(txt[x]))
                        {
                            RecReturnChkTxt.Text = txt.Replace(txt[x], ' ');
                            toolTip2.Show("Avoid special characters!", RecReturnChkTxt);
                            toolTip2.Hide(RecReturnChkTxt);
                        }
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "error");
                }
            }
        }

        private void viewSalesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoiceSalesReport sales = new ChoiceSalesReport();
            sales.ShowDialog();
        }

        private void accountsReceivableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountsReceivable accou = new AccountsReceivable();
            accou.ShowDialog();
        }

        private void accountsPayableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountsPayable pay2 = new AccountsPayable();
            pay2.ShowDialog();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int ans;
            ans = Convert.ToInt16(MessageBox.Show("Are you sure you want to exit this program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (ans == 6)
            {


                this.Close();

            }
        }

        private void logoffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Security showsecu = new Security();
            this.Hide();
            showsecu.ShowDialog();
            this.Close();
        }

        private void UpdInvQtyPic_Click(object sender, EventArgs e)
        {
            if (InvItemIDtxt.Text == "")
            { MessageBox.Show("Please Select Inventory Item to update its quantity", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                string IteID = InvItemIDtxt.Text;

                UpdatQty showqty = new UpdatQty(IteID, AdItemNametxt.Text.Trim(), syspass);
                showqty.ShowDialog();
                BalloonKingdomDataSetTableAdapters.InventoryTableAdapter getAllInvData = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.InventoryTableAdapter();
                InvDataGrid.DataSource = getAllInvData.GetAllInventoryRec();


            }
        }

        private void rentedItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoiceRentedItem ch = new ChoiceRentedItem();
            ch.ShowDialog();
        }

        private void rentalRefundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoiceRefund ree = new ChoiceRefund();
            ree.ShowDialog();
        }

       
        private void POUpdateQty_Click(object sender, EventArgs e)
        {
            SqlCommand cmduppqty = new SqlCommand("Update [PO Items] set Quantity=" + "'" + PurtoOrderTxt.Text.Trim() + "'" + "," + "[Unit Price]=" + "'" + UnitPrceTxt.Text.Trim() + "'" + "where [Item ID]=" + "'" + PurItemIDtxt.Text.Trim() + "'" + "AND [POF Number]=" + "'" + Convert.ToString(POFID) + "'", conn);
            cmduppqty.ExecuteNonQuery();
            BalloonKingdomDataSetTableAdapters.PO_ItemsTableAdapter viewpoitems = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PO_ItemsTableAdapter();
            POItemCart.DataSource = viewpoitems.ViewPOItems(POFID);
            MessageBox.Show("Item ID No. " + PurItemIDtxt.Text.Trim() + " quantity has been successfully updated to " + PurtoOrderTxt.Text.Trim() + " and unit price to" + UnitPrceTxt.Text.Trim(), "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            POUpdateQty.Enabled = false;
            PurQtytxt.Enabled = false;
            UnitPrceTxt.Enabled = false;
            PurtoOrderTxt.Enabled = false;
        }

        private void receivePurchasedOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceivePO rc = new ReceivePO();
            rc.ShowDialog();
        }

        private void ViewPORcvbtn_Click(object sender, EventArgs e)
        {
            double under = 0;
            try
            {
                under = Convert.ToDouble(UndersupplyTxt.Text);
            }
            catch
            {

                MessageBox.Show("Please Select Purchase Order to receive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (under > 0)
            {
                if (VPONumtxt.Text == "")
                {
                    MessageBox.Show("Please Select COF to receive items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    ReceivedPOPanel.Visible = true;
                    CreatePOPanel.Visible = false;
                    ViewPOPanel.Visible = false;
                    BalloonKingdomDataSetTableAdapters.PO_ItemsTableAdapter viewitem = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PO_ItemsTableAdapter();
                    RcvItemsPanel.DataSource = viewitem.ViewPOItems(Convert.ToInt32(VPONumtxt.Text));

                    BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter uppostat = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.PurchaseTableAdapter();
                    uppostat.UpdatePOStatus("Fully Paid", Convert.ToInt32(VPONumtxt.Text));

                    RcvPOIDtxt.Text = VPONumtxt.Text;
                    RcvSuppNametxt.Text = VPOSupnme.Text;
                    RcvSuppIDtxt.Text = VPOSupId.Text;
                    dateTimePicker4.Value = VPODatePur.Value;
                    dateTimePicker3.Value = VPOTimePurc.Value;
                    RcvPOAmttxt.Text = VOPurTotAmt.Text;
                    RcvVATPertxt.Text = VPOVatPer.Text;
                    RcvVATAmttxt.Text = VOPurVatAmt.Text;
                    RcvDowntxt.Text = VPODeposit.Text;
                    RcvBaltxt.Text = VPOBalance.Text;
                    RcvTottxt.Text = VPOFullPaymnt.Text;

                }
            }
        }

        private void Discountbtn_CheckedChanged(object sender, EventArgs e)
        {
            double dis = 0, totaldis = 0;

            if (Discountbtn.Checked == true)
            {

                DisAmttxt.Enabled = true;


                if (DisAmttxt.Text == "")
                {
                    dis = 0;

                }
                else
                {

                    dis = Convert.ToDouble(DisAmttxt.Text);

                    totaldis = Convert.ToDouble(PaymentTotal.Text) - dis;




                    Overalltxt.Text = Convert.ToString(totaldis);


                }

            }

            else

                DisAmttxt.Enabled = false;
            dis = 0;
            DisAmttxt.Text = "0";
        }

        private void DisAmttxt_TextChanged(object sender, EventArgs e)
        {
            double dis = 0, totaldis = 0;

            if (DisAmttxt.Text == "")
            {
                dis = 0;

                Overalltxt.Text = PaymentTotal.Text;

            }
            else
            {

                dis = Convert.ToDouble(DisAmttxt.Text);

                totaldis = Convert.ToDouble(PaymentTotal.Text) - dis;




                Overalltxt.Text = Convert.ToString(totaldis);


            }

        }

        private void printCOFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintCOF showcof = new PrintCOF();
            showcof.ShowDialog();
        }

        private void printPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPO showpof = new PrintPO();
            showpof.ShowDialog();
        }

        private void btnrecok_Click(object sender, EventArgs e)
        {
            if (recsyspasstxt.Text.Trim() == "" || ReturnRentCHKTxt.Text.Trim() == "" || RecReturnChkTxt.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up the required fields.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                recsyspasstxt.Text = "";
                ReturnRentCHKTxt.Text = "";
                RecReturnChkTxt.Text = "";
            }
            else if (recsyspasstxt.Text != syspass)
            {
                MessageBox.Show("Wrong System Password. Please try Again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                recsyspasstxt.Text = "";
                ReturnRentCHKTxt.Text = "";
                RecReturnChkTxt.Text = "";
            
            }
            else
            {
                RentOKBtn.Enabled = true;
            
            }
        }

        private void rentalRefundToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRentalChcklst showchklst = new frmRentalChcklst();
            showchklst.ShowDialog();
        }

     

     
     

      

       

      

       

    
      

        

     

    
    

       

       
    }
}

    

     
  
  
  
        


        
