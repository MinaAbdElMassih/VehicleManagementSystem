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
    public partial class Form3 : Form
    {
        bool Flag = false;
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MINA-PC\\SQLEXPRESS;Initial Catalog=Vehicle managment project2;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            Form4 form = new Form4();
            form.Show();
            this.Close();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            Form5 form = new Form5();
            form.Show();
            this.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            Application.Exit();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            Form7 form = new Form7();
            form.Show();
            this.Close();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            Form10 form = new Form10();
            form.Show();
            this.Close();
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            Form16 form = new Form16();
            form.Show();
            this.Close();
            con.Close();
        }
    }
}
