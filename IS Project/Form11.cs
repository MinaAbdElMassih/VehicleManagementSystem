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
    public partial class Form11 : Form
    {
        public Form11()
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
            string UpdateString = @"update Category set Vehicle_producer=@VP where ID=@ID";
            SqlCommand cmd = new SqlCommand(UpdateString, con);
            SqlParameter IDpara = new SqlParameter("@ID", textBox1.Text);
            cmd.Parameters.Add(IDpara);
            SqlParameter VPpara = new SqlParameter("@VP", textBox4.Text);
            cmd.Parameters.Add(VPpara);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string UpdateString = @"update Category set Car=@car where ID=@ID";
            SqlCommand cmd = new SqlCommand(UpdateString, con);
            SqlParameter IDpara = new SqlParameter("@ID", textBox1.Text);
            cmd.Parameters.Add(IDpara);
            SqlParameter carpara = new SqlParameter("@car", textBox2.Text);
            cmd.Parameters.Add(carpara);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string UpdateString = @"update Category set Motorcycle=@mc where ID=@ID";
            SqlCommand cmd = new SqlCommand(UpdateString, con);
            SqlParameter IDpara = new SqlParameter("@ID", textBox1.Text);
            cmd.Parameters.Add(IDpara);
            SqlParameter mcpara = new SqlParameter("@mc", textBox3.Text);
            cmd.Parameters.Add(mcpara);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
