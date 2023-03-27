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
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=desktop-ov7ui8i\sqlexpress01;Initial Catalog=ATMDb;Integrated Security=True");
        private void account_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccNumTb.Text == "" ||  AccNumTb.Text == "" || FanameTb.Text == "" || PhoneTb.Text == "" || Addresstb.Text == "" || occupationTb.Text == "" || pinTb.Text == "" )
            {
                MessageBox.Show("Missing information ");
            }
            else
            {
                try
                {
                    con.Open();
                    string query =  "insert into AccountTb1 values('"+AccNumTb.Text+"', '"+AccNametb.Text+"', '"+ FanameTb.Text+"','"+dobdate.Value.Date+"','"+PhoneTb.Text+"', '"+Addresstb.Text+"','"+eductioncb.SelectedItem.ToString()+"', '"+occupationTb.Text+"', '"+pinTb.Text+"', "+bal+")";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created SuccesFully");
                    con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch(Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
