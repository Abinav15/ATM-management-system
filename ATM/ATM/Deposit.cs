using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=desktop-ov7ui8i\sqlexpress01;Initial Catalog=ATMDb;Integrated Security=True");
        string Acc = Login.AccNumber;
        private void addtransaction()
        {
            string Trtype = "Deposit" ;
            try
            {
                con.Open();
                string query = "insert into TransactionTb1 values('" + Acc + "', '" +Trtype+ "', " + DepoAtmTb.Text + ",'" + DateTime.Today.Date.ToString()+ "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created SuccesFully");
                con.Close();
                
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DepoAtmTb.Text == "" || Convert.ToInt32(DepoAtmTb.Text) <= 0)
            {
                MessageBox.Show("Enter amount to Deposit ");
            }
            else
            {
               
                newbalance = oldbalance + Convert.ToInt32(DepoAtmTb.Text);
                try
                {
                    con.Open();
                    string query = "Update AccountTb1 set blance = " + newbalance + " where AccNum= '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Deposit");

                    
                    con.Close();
                    addtransaction();
                    HOMe home = new HOMe();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        int oldbalance, newbalance;
        private void getbalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select blance from AccountTb1 where AccNum = '" + Acc+ "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());

            con.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            getbalance();
        }
    }
}
