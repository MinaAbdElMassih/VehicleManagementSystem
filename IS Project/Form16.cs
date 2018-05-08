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
    public partial class Form16 : Form
    {
        bool Flag = false;
        public Form16()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MINA-PC\\SQLEXPRESS;Initial Catalog=Vehicle managment project2;Integrated Security=True");

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            Form15 form = new Form15();
            form.Show();
            this.Close();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            Form17 form = new Form17();
            form.Show();
            this.Close();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            Form18 form = new Form18();
            form.Show();
            this.Close();
            con.Close();
        }
    }
}
