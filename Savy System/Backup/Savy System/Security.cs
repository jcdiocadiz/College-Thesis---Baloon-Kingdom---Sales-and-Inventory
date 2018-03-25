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
    public partial class Security : Form
    {

        //static string str_conn = @"data source=.\SQLEXPRESS;initial catalog=BKDatabase; Integrated Security=True";

        static string str_conn = WindowsApplication1.Properties.Settings.Default.BKDatabaseConnectionString;
        private SqlConnection conn;
        private SqlDataReader dr;
        private SqlCommand cmd;

        public Security()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from Security", conn);
            dr = cmd.ExecuteReader();
            string ans = "";
            while (dr.Read())
            {
                if (userbox.Text == dr["Username"].ToString() && passtxt.Text.Trim() == dr["Password"].ToString())
                    ans = "True";
            }
            dr.Close();
            if (ans == "True")
            {
                PODeliverPic showsavy = new PODeliverPic(passtxt.Text);
                this.Hide();
                showsavy.ShowDialog();
                this.Close();
            }
            else
            {

                MessageBox.Show("Wrong Password", "Log-In Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                passtxt.Text = "";
                userbox.Text = "Administrator";
            }
        }

        private void Security_Load(object sender, EventArgs e)
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
            

            userbox.Text = "Administrator";
        }

      
       
    }
}