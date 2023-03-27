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
    public partial class ministatement : Form
    {
        public ministatement()
        {
            InitializeComponent();
        }
         SqlConnection con = new SqlConnection(@"Data Source=desktop-ov7ui8i\sqlexpress01;Initial Catalog=ATMDb;Integrated Security=True");
        string Acc = Login.AccNumber;
        private void populate()
        {
            con.Open();
            string query = "select * from TransactionTb1 where AccNum = '" + Acc + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MinistatementGDV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void transactionTb1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transactionTb1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTMDbDataSet);

        }

        private void ministatement_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            HOMe home = new HOMe();
            this.Hide();
            home.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
