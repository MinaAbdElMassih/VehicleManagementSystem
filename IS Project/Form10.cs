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
    public partial class Form10 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MINA-PC\\SQLEXPRESS;Initial Catalog=Vehicle managment project2;Integrated Security=True");
        bool Flag = false;
        public Form10()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            Form12 form = new Form12();
            form.Show();
            this.Close();
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            Form12 form = new Form12();
            form.Show();
            this.Close();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            Form12 form = new Form12();
            form.Show();
            this.Close();
            con.Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
