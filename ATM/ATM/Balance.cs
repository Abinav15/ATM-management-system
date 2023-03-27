using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=desktop-ov7ui8i\sqlexpress01;Initial Catalog=ATMDb;Integrated Security=True");
        private void getbalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select blance from AccountTb1 where AccNum = '" +AccNumberlb1.Text+ "'" , con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
           Balancelb1.Text = "Rs "+ dt.Rows[0][0].ToString();

            con.Close();

        }

        private void label13_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            HOMe home = new HOMe();
            home.Show();
            this.Hide();
        }

        private void AccNumberlbt_Click(object sender, EventArgs e)
        {

        }

        private void Balance_Load(object sender, EventArgs e)
        {
            AccNumberlb1.Text = HOMe.AccNumber;
            getbalance();
        }

       

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Balancelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
