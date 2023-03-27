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
    public partial class FASTCASH : Form
    {
        public FASTCASH()
        {
            InitializeComponent();
        }

       

        private void label5_Click(object sender, EventArgs e)
        {
            HOMe home = new HOMe();
            this.Hide();
            home.Show();
        }
        SqlConnection con = new SqlConnection(@"Data Source=desktop-ov7ui8i\sqlexpress01;Initial Catalog=ATMDb;Integrated Security=True");
        string Acc = Login.AccNumber;
        int bal;
        private void getbalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select blance from AccountTb1 where AccNum = '" + Acc + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balancelb1.Text = " Balance Rs " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();

        }
        private void FASTCASH_Load(object sender, EventArgs e)
        {
            getbalance();
        }
        
        private void addtransaction1()
        {
            string Trtype = "WithDraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTb1 values('" + Acc + "', '" + Trtype + "', " + 100 + ",'" + DateTime.Today.Date.ToString() + "')";

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
        private void addtransaction2()
        {
            string Trtype = "WithDraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTb1 values('" + Acc + "', '" + Trtype + "', " + 500 + ",'" + DateTime.Today.Date.ToString() + "')";

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
        private void addtransaction3()
        {
            string Trtype = "WithDraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTb1 values('" + Acc + "', '" + Trtype + "', " + 1000 + ",'" + DateTime.Today.Date.ToString() + "')";

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
        private void addtransaction4()
        {
            string Trtype = "WithDraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTb1 values('" + Acc + "', '" + Trtype + "', " + 2000 + ",'" + DateTime.Today.Date.ToString() + "')";

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
        private void addtransaction5()
        {
            string Trtype = "WithDraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTb1 values('" + Acc + "', '" + Trtype + "', " + 5000 + ",'" + DateTime.Today.Date.ToString() + "')";

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
        private void addtransaction6()
        {
            string Trtype = "WithDraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTb1 values('" + Acc + "', '" + Trtype + "', " + 10000 + ",'" + DateTime.Today.Date.ToString() + "')";

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


        private void button1_Click(object sender, EventArgs e)
        {
            if (bal < 100)
            {
                MessageBox.Show("balance caa not br negitive");
            }
            else
            {
               int  newbalance = bal - 100;
                try
                {
                    con.Open();
                    string query = "Update AccountTb1 set blance = " + newbalance + " where AccNum= '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");


                    con.Close();
                    addtransaction1();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (bal < 500)
            {
                MessageBox.Show("balance caa not br negitive");
            }
            else
            {
                int newbalance = bal - 500;
                try
                {
                    con.Open();
                    string query = "Update AccountTb1 set blance = " + newbalance + " where AccNum= '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");


                    con.Close();

                    addtransaction2();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("balance caa not br negitive");
            }
            else
            {
                int newbalance = bal - 1000;
                try
                {
                    con.Open();
                    string query = "Update AccountTb1 set blance = " + newbalance + " where AccNum= '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");


                    con.Close();
                    addtransaction3();
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (bal < 2000)
            {
                MessageBox.Show("balance caa not br negitive");
            }
            else
            {
                int newbalance = bal - 2000;
                try
                {
                    con.Open();
                    string query = "Update AccountTb1 set blance = " + newbalance + " where AccNum= '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");


                    con.Close();
                    addtransaction4();
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (bal < 5000)
            {
                MessageBox.Show("balance caa not br negitive");
            }
            else
            {
                int newbalance = bal - 5000;
                try
                {
                    con.Open();
                    string query = "Update AccountTb1 set blance = " + newbalance + " where AccNum= '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");


                    con.Close();
                    addtransaction5();
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (bal < 10000)
            {
                MessageBox.Show("balance caa not br negitive");
            }
            else
            {
                int newbalance = bal - 10000;
                try
                {
                    con.Open();
                    string query = "Update AccountTb1 set blance = " + newbalance + " where AccNum= '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Withdraw");


                    con.Close();
                    addtransaction6();
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

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
