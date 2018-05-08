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
    public partial class Form6 : Form
    {
        bool Flag = false;
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MINA-PC\\SQLEXPRESS;Initial Catalog=Vehicle managment project2;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            string insertString = @"insert into Vehicles(color,Sticker,Tires,Paint,Conditioner,car_lamp,fans,vehicle_producer_ID) values (@color,@Sticker,@Tires,@Paint,@Conditioner,@car_lamp,@fans,@VPID)";
            SqlCommand cmd = new SqlCommand(insertString, con);
            SqlParameter colorpara = new SqlParameter("@color", textBox1.Text);
            cmd.Parameters.Add(colorpara);
            SqlParameter stickerpara = new SqlParameter("@Sticker", textBox2.Text);
            cmd.Parameters.Add(stickerpara);
            SqlParameter tirespara = new SqlParameter("@Tires", textBox3.Text);
            cmd.Parameters.Add(tirespara);
            SqlParameter Paintpara = new SqlParameter("@Paint", textBox4.Text);
            cmd.Parameters.Add(Paintpara);
            SqlParameter conditionerpara = new SqlParameter("@Conditioner", textBox5.Text);
            cmd.Parameters.Add(conditionerpara);
            SqlParameter carlamppara = new SqlParameter("@car_lamp", textBox6.Text);
            cmd.Parameters.Add(carlamppara);
            SqlParameter fanspara = new SqlParameter("@fans", textBox7.Text);
            cmd.Parameters.Add(fanspara);
            SqlParameter VPIDpara = new SqlParameter("@VPID", textBox8.Text);
            cmd.Parameters.Add(VPIDpara);
            cmd.ExecuteNonQuery();
            MessageBox.Show("       Done.");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            con.Open(); 
            Application.Exit();
            con.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
