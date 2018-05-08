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
    public partial class Form8 : Form
    {
        bool Flag = false;
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MINA-PC\\SQLEXPRESS;Initial Catalog=Vehicle managment project2;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            string UpdateString = @"update Customer set Gender=@Gender where Name=@Name1";
            SqlCommand cmd = new SqlCommand(UpdateString, con);
            SqlParameter Namepara = new SqlParameter("@Name1", textBox3.Text);
            cmd.Parameters.Add(Namepara);
            SqlParameter Genderpara = new SqlParameter("@Gender", textBox9.Text);
            cmd.Parameters.Add(Genderpara);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            string UpdateString = @"update Customer set Address=@Address where Name=@Name1";
            SqlCommand cmd = new SqlCommand(UpdateString, con);
            SqlParameter Namepara = new SqlParameter("@Name1", textBox3.Text);
            cmd.Parameters.Add(Namepara);
            SqlParameter Addresspara = new SqlParameter("@Address", textBox4.Text);
            cmd.Parameters.Add(Addresspara);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            string UpdateString = @"update Customer set Credit_Card_Num=@CCN where Name=@Name1";
            SqlCommand cmd = new SqlCommand(UpdateString, con);
            SqlParameter Namepara = new SqlParameter("@Name1", textBox3.Text);
            cmd.Parameters.Add(Namepara);
            SqlParameter CCNpara = new SqlParameter("@CCN", textBox8.Text);
            cmd.Parameters.Add(CCNpara);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            string UpdateString = @"update Customer set Age=@Age where Name=@Name1";
            SqlCommand cmd = new SqlCommand(UpdateString, con);
            SqlParameter Namepara = new SqlParameter("@Name1", textBox3.Text);
            cmd.Parameters.Add(Namepara);
            SqlParameter Agepara = new SqlParameter("@Age", textBox7.Text);
            cmd.Parameters.Add(Agepara);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            string UpdateString = @"update Customer set NationalNumber=@NN where Name=@Name1";
            SqlCommand cmd = new SqlCommand(UpdateString, con);
            SqlParameter Namepara = new SqlParameter("@Name1", textBox3.Text);
            cmd.Parameters.Add(Namepara);
            SqlParameter Nationalpara = new SqlParameter("@NN", textBox6.Text);
            cmd.Parameters.Add(Nationalpara);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            string UpdateString = @"update Customer set Email=@Email where Name=@Name1";
            SqlCommand cmd = new SqlCommand(UpdateString, con);
            SqlParameter Namepara = new SqlParameter("@Name1", textBox3.Text);
            cmd.Parameters.Add(Namepara);
            SqlParameter Emailpara = new SqlParameter("@Email", textBox5.Text);
            cmd.Parameters.Add(Emailpara);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
