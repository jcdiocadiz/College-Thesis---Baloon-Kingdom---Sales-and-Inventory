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
    public partial class frmDeliverRental : Form
    {
        static string str_conn = WindowsApplication1.Properties.Settings.Default.BKDatabaseConnectionString;
        private SqlConnection conn;
        private SqlDataReader dr;
        private SqlCommand cmd;
        double renta = 0;

        int c = 0;
        string[] unit = new string[3000];
        string[] itemid = new string[3000];
        string[] itemnme = new string[3000];
        string[] cat = new string[3000];
        string[] subcat = new string[3000];
        string[] speccat = new string[3000];
        string[] quanti = new string[3000];
        string idstat = "No";
        string password;

        public frmDeliverRental(string COF, string ID, string RentAmt, string pass)
        {
            InitializeComponent();
            renta = Convert.ToDouble(RentAmt);
            COFNumLbl.Text = COF;
            password = pass;
            CustIDlbl.Text = ID;
            RentAmtTxt.Text = RentAmt;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200;  // CS_NOCLOSE   
                return parms;
            }
        }


        private void frmDeliverRental_Load(object sender, EventArgs e)
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

            renta *= 3;

            RentSecurityAmt.Text = Convert.ToString(renta);
            BalloonKingdomDataSetTableAdapters.ItemTableAdapter viewrent = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.ItemTableAdapter();
            RentDataGrid.DataSource = viewrent.ViewRentItem(Convert.ToInt32(COFNumLbl.Text));


            int totquanti = 0;
            SqlCommand extract = new SqlCommand("Select * from Item where [COF Number]=" + "'" + COFNumLbl.Text + "'" + "And Type='Rental'", conn);
            SqlDataReader drex = extract.ExecuteReader();
            while (drex.Read())
            {
                unit[c] = drex["Unit"].ToString();
                itemid[c] = drex["Item ID"].ToString();
                itemnme[c] = drex["Item Name"].ToString();
                cat[c] = drex["Category Name"].ToString();
                subcat[c] = drex["Sub Category"].ToString();
                speccat[c] = drex["Specific Category"].ToString();
                quanti[c] = drex["Quantity"].ToString();
                totquanti += Convert.ToInt32(drex["Quantity"].ToString());
                c++;
            }
            drex.Close();
            OverallQtyTxt.Text = Convert.ToString(totquanti);

        }

        private void RentOKBtn_Click(object sender, EventArgs e)
        {
            if (DeliveredByTxt.Text.Trim() == "" || RecordedByTxt.Text.Trim() == "" || PickByTxt.Text.Trim() == "")
            {
                MessageBox.Show("Please fill-up the required fields.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (Syspasstxt.Text.Trim()!=password)
            {
                MessageBox.Show("Invalid System Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Syspasstxt.Text = "";

            }
            else
            {
                string id;
                int a = 0, id2 = 0;

                SqlCommand cmd5 = new SqlCommand("Select * from [Rental Checklist]", conn);
                SqlDataReader dr8 = cmd5.ExecuteReader();
                while (dr8.Read())
                {
                    id = dr8["Checklist Number"].ToString();
                    id2 = Convert.ToInt32(id);
                    if (a < id2)
                        a = id2;



                }
                dr8.Close();
                a++;


                for (int b = 0; b < c; b++)
                {

                    BalloonKingdomDataSetTableAdapters.Rental_ChecklistTableAdapter addrent = new WindowsApplication1.BalloonKingdomDataSetTableAdapters.Rental_ChecklistTableAdapter();
                    addrent.AddChecklist(a, Convert.ToInt32(COFNumLbl.Text), Convert.ToInt32(itemid[b]), cat[b], subcat[b], speccat[b], itemnme[b], DateReleased.Value, TimeReleased.Value, unit[b], Convert.ToInt32(quanti[b]), DeliveredByTxt.Text.Trim(), PickByTxt.Text, RecordedByTxt.Text.Trim(), idstat, Convert.ToDecimal(RentSecurityAmt.Text.Trim()));
                    a++;



                }


                MessageBox.Show("Item has been successfully delivered and this transaction is recorded in Rental Checklist", "Delivery Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                SqlCommand uporstat = new SqlCommand("Update Orderline set Status='Waiting' where [COF Number]=" + "'" + COFNumLbl.Text + "'", conn);
                uporstat.ExecuteNonQuery();
            }
        }

        private void GetIDChk_CheckedChanged(object sender, EventArgs e)
        {

            if (GetIDChk.Checked == true)
                idstat = "Yes";
            else
                idstat = "No";

        }

        private void PickByTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz -'.".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void PickByTxt_TextChanged(object sender, EventArgs e)
        {
            if (PickByTxt.Text != "")
            {
                try
                {
                    int x = 0;
                    string txt;
                    if (PickByTxt.Text != "")
                    {
                        txt = PickByTxt.Text;
                        x = txt.Length - 1;

                        if (PickByTxt.Text == "")
                        {
                            toolTip1.Show("Avoid special characters!", PickByTxt);
                            PickByTxt.Clear();
                            toolTip1.Hide(PickByTxt);
                        }

                        else if (char.IsWhiteSpace(txt[x]))
                        {
                            PickByTxt.Text = txt.Replace(txt[x], ' ');
                            toolTip1.Show("Avoid special characters!", PickByTxt);
                            toolTip1.Hide(PickByTxt);
                        }
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "error");
                }
            }




        }

        private void DeliveredByTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz -'.".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void RecordedByTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (int)Keys.Back || (e.KeyChar == (int)Keys.Delete) || (e.KeyChar == (int)Keys.Tab)))
                return;

            if ("*ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz -'.".IndexOf(e.KeyChar) < 1)
                e.Handled = true;
        }

        private void DeliveredByTxt_TextChanged(object sender, EventArgs e)
        {
            if (DeliveredByTxt.Text != "")
            {
                try
                {
                    int x = 0;
                    string txt;
                    if (DeliveredByTxt.Text != "")
                    {
                        txt = DeliveredByTxt.Text;
                        x = txt.Length - 1;

                        if (DeliveredByTxt.Text == "")
                        {
                            toolTip1.Show("Avoid special characters!", DeliveredByTxt);
                            DeliveredByTxt.Clear();
                            toolTip1.Hide(DeliveredByTxt);
                        }

                        else if (char.IsWhiteSpace(txt[x]))
                        {
                            DeliveredByTxt.Text = txt.Replace(txt[x], ' ');
                            toolTip1.Show("Avoid special characters!", DeliveredByTxt);
                            toolTip1.Hide(DeliveredByTxt);
                        }
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "error");
                }
            }


        }

        private void RecordedByTxt_TextChanged(object sender, EventArgs e)
        {
            if (RecordedByTxt.Text != "")
            {
                try
                {
                    int x = 0;
                    string txt;
                    if (RecordedByTxt.Text != "")
                    {
                        txt = RecordedByTxt.Text;
                        x = txt.Length - 1;

                        if (RecordedByTxt.Text == "")
                        {
                            toolTip1.Show("Avoid special characters!", RecordedByTxt);
                            DeliveredByTxt.Clear();
                            toolTip1.Hide(RecordedByTxt);
                        }

                        else if (char.IsWhiteSpace(txt[x]))
                        {
                            RecordedByTxt.Text = txt.Replace(txt[x], ' ');
                            toolTip1.Show("Avoid special characters!", RecordedByTxt);
                            toolTip1.Hide(RecordedByTxt);
                        }
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "error");
                }
            }
        }
    }
}