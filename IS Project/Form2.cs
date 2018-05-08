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
    public partial class Form2 : Form
    {
        bool Flag = false;
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MINA-PC\\SQLEXPRESS;Initial Catalog=Vehicle managment project2;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            SqlCommand cmd = new SqlCommand("AddCustomers1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter namepara = new SqlParameter("@Name1", textBox1.Text);
            cmd.Parameters.Add(namepara);
            SqlParameter addresspara = new SqlParameter("@Address", textBox2.Text);
            cmd.Parameters.Add(addresspara);
            SqlParameter agepara = new SqlParameter("@Age", textBox3.Text);
            cmd.Parameters.Add(agepara);
            SqlParameter Emailpara = new SqlParameter("@Email", textBox4.Text);
            cmd.Parameters.Add(Emailpara);
            SqlParameter Creditpara = new SqlParameter("@CCN", textBox5.Text);
            cmd.Parameters.Add(Creditpara);
            SqlParameter Genderpara = new SqlParameter("@Gender", textBox6.Text);
            cmd.Parameters.Add(Genderpara);
            SqlParameter Nationalpara = new SqlParameter("@National", textBox7.Text);
            cmd.Parameters.Add(Nationalpara);
            SqlDataReader reader = cmd.ExecuteReader();
            Form3 form = new Form3();
            form.Show();
            this.Close();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            Application.Exit();
            con.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}