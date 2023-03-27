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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=desktop-ov7ui8i\sqlexpress01;Initial Catalog=ATMDb;Integrated Security=True");
        string Acc = Login.AccNumber;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ChangePin_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            HOMe home = new HOMe();
            this.Hide();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pin1Tb.Text == "" || pin2Tb.Text == "")
            {
                MessageBox.Show("Enter And Conform the new pin ");
            }
            else if (pin2Tb.Text !=pin1Tb.Text)
            {
                MessageBox.Show("pin1 and pin2 are different");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Update AccountTb1 set pin = " + pin1Tb.Text + " where AccNum= '" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("pin Successfuly update");


                    con.Close();
                    Login home = new Login();
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
