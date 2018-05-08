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
    public partial class Form9 : Form
    {
        bool Flag = false;
        public Form9()
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
            string UpdateString = @"update Vehicles set fans=@Fans where ID=@ID";
            SqlCommand cmd = new SqlCommand(UpdateString, con);
            SqlParameter IDpara = new SqlParameter("@ID", textBox9.Text);
            cmd.Parameters.Add(IDpara);
            SqlParameter Fanspara = new SqlParameter("@Fans", textBox7.Text);
            cmd.Parameters.Add(Fanspara);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            string UpdateString = @"update Vehicles set car_lamp=@carlamp where ID=@ID";
            SqlCommand cmd = new SqlCommand(UpdateString, con);
            SqlParameter IDpara = new SqlParameter("@ID", textBox9.Text);
            cmd.Parameters.Add(IDpara);
            SqlParameter carlpara = new SqlParameter("@carlamp", textBox6.Text);
            cmd.Parameters.Add(carlpara);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            string UpdateString = @"update Vehicles set Conditioner=@conditioner where ID=@ID";
            SqlCommand cmd = new SqlCommand(UpdateString, con);
            SqlParameter IDpara = new SqlParameter("@ID", textBox9.Text);
            cmd.Parameters.Add(IDpara);
            SqlParameter conditionerpara = new SqlParameter("@conditioner", textBox5.Text);
            cmd.Parameters.Add(conditionerpara);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            string UpdateString = @"update Vehicles set Paint=@paint where ID=@ID";
            SqlCommand cmd = new SqlCommand(UpdateString, con);
            SqlParameter IDpara = new SqlParameter("@ID", textBox9.Text);
            cmd.Parameters.Add(IDpara);
            SqlParameter paintlpara = new SqlParameter("@paint", textBox4.Text);
            cmd.Parameters.Add(paintlpara);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            string UpdateString = @"update Vehicles set Tires=@tires where ID=@ID";
            SqlCommand cmd = new SqlCommand(UpdateString, con);
            SqlParameter IDpara = new SqlParameter("@ID", textBox9.Text);
            cmd.Parameters.Add(IDpara);
            SqlParameter tirepara = new SqlParameter("@tires", textBox3.Text);
            cmd.Parameters.Add(tirepara);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            string UpdateString = @"update Vehicles set Sticker=@Sticker where ID=@ID";
            SqlCommand cmd = new SqlCommand(UpdateString, con);
            SqlParameter IDpara = new SqlParameter("@ID", textBox9.Text);
            cmd.Parameters.Add(IDpara);
            SqlParameter Stickerpara = new SqlParameter("@Sticker", textBox2.Text);
            cmd.Parameters.Add(Stickerpara);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            string UpdateString = @"update Vehicles set color=@color where ID=@ID";
            SqlCommand cmd = new SqlCommand(UpdateString, con);
            SqlParameter IDpara = new SqlParameter("@ID", textBox9.Text);
            cmd.Parameters.Add(IDpara);
            SqlParameter colorpara = new SqlParameter("@color", textBox1.Text);
            cmd.Parameters.Add(colorpara);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            Flag = true;
            string UpdateString = @"update Vehicles set vehicle_producer_ID=@VPID where ID=@ID";
            SqlCommand cmd = new SqlCommand(UpdateString, con);
            SqlParameter IDpara = new SqlParameter("@ID", textBox9.Text);
            cmd.Parameters.Add(IDpara);
            SqlParameter VPIDpara = new SqlParameter("@VPID", textBox6.Text);
            cmd.Parameters.Add(VPIDpara);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }
    }
}
