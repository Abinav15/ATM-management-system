using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Activated(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            account acc = new account();
            acc.Show();
            this.Hide();
        }
        public static string AccNumber;
        SqlConnection con = new SqlConnection(@"Data Source=desktop-ov7ui8i\sqlexpress01;Initial Catalog=ATMDb;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTb1 where Accnum = '" + AccNumTb.Text + "' and  PIN = " + pinTb.Text + "" , con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString()== "1")
            {
                AccNumber = AccNumTb.Text;
                HOMe home = new HOMe();
                home.Show();
                this.Hide();
                con.Close();

            }
            else
            {
                MessageBox.Show("Wrong Account Number or Pin code");
            }
            con.Close();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
