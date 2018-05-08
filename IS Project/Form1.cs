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
 
    public partial class Form1 : Form
    {
        bool Flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=MINA-PC\\SQLEXPRESS;Initial Catalog=Vehicle managment project2;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
       
      
            Flag = true;
            con.Open();
            Form3 form = new Form3();
            form.Show();
            this.Close();
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Flag = true;
            con.Open();
            Form2 form = new Form2();
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

 

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Flag == false)
            {
                Application.Exit();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}    
 