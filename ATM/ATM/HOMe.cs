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
    public partial class HOMe : Form
    {
        public HOMe()
        {
            InitializeComponent();
        }
        public static string AccNumber;
        private void HOMe_Load(object sender, EventArgs e)
        {
           AccNumlb.Text = "Account Number: " + Login.AccNumber;
            AccNumber = Login.AccNumber;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            HOMe home = new HOMe();
            home.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            this.Hide();
            bal.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit depo = new Deposit();
            depo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangePin pin = new ChangePin();
            this.Hide();
            pin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            withdraw wd = new withdraw();
            this.Hide();
            wd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FASTCASH fcash = new FASTCASH();
            this.Hide();
            fcash.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ministatement min = new  ministatement();
            this.Hide();
            min.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            account ac = new account();
            ac.Show();
            this.Hide();
        }
    }
}
