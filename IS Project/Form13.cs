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
    public partial class Form13 : Form
    {
        bool Flag = false;
        SqlConnection con = new SqlConnection("Data Source=MINA-PC\\SQLEXPRESS;Initial Catalog=Vehicle managment project2;Integrated Security=True");

        public Form13()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            string deleteString = @"delete from Category where ID=@ID";
            SqlCommand cmd = new SqlCommand(deleteString, con);
            SqlParameter IDpara = new SqlParameter("@ID", textBox1.Text);
            cmd.Parameters.Add(IDpara);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted");
        }
    }
}
