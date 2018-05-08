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
    public partial class Form4 : Form
    {
        bool Flag = false;
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MINA-PC\\SQLEXPRESS;Initial Catalog=Vehicle managment project2;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            SqlCommand cmd = new SqlCommand("AddTypeofVehicle", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter carpara = new SqlParameter("@Car", textBox1.Text);
            cmd.Parameters.Add(carpara);
            SqlParameter motopara = new SqlParameter("@Moto", textBox2.Text);
            cmd.Parameters.Add(motopara);
            SqlParameter vehiclepara = new SqlParameter("@VP", textBox3.Text);
            cmd.Parameters.Add(vehiclepara);
            cmd.ExecuteNonQuery();
            Form6 form = new Form6();
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
