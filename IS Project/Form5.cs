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

namespace IS_Project
{
    public partial class Form5 : Form
    {
        bool Flag = false;
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MINA-PC\\SQLEXPRESS;Initial Catalog=Vehicle managment project2;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            string insertString = @"insert into Customer_Service(Problem,customer_ID) values (@Problem,@CID)";
            SqlCommand cmd = new SqlCommand(insertString, con);
            SqlParameter problempara = new SqlParameter("@Problem", textBox1.Text);
            cmd.Parameters.Add(problempara);
            SqlParameter IDpara = new SqlParameter("@CID", textBox2.Text);
            cmd.Parameters.Add(IDpara);
            cmd.ExecuteNonQuery();
            MessageBox.Show("       Done");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            Application.Exit();
            con.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
