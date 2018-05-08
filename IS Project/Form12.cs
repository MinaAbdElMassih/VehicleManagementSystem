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
    public partial class Form12 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MINA-PC\\SQLEXPRESS;Initial Catalog=Vehicle managment project2;Integrated Security=True");

        bool Flag = false;
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            string deleteString = @"delete from Customer where Name=@Name1";
            SqlCommand cmd = new SqlCommand(deleteString, con);
            SqlParameter Namepara = new SqlParameter("@Name1", textBox3.Text);
            cmd.Parameters.Add(Namepara);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted");
        }
         
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
