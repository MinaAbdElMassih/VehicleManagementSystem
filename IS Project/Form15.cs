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
    public partial class Form15 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MINA-PC\\SQLEXPRESS;Initial Catalog=Vehicle managment project2;Integrated Security=True");

        public Form15()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Name,Age,Address,Email,NationalNumber,Credit_Card_Num,Gender from Customer",con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable customers = new DataTable();
            customers.Columns.Add("Name");
            customers.Columns.Add("Age");
            customers.Columns.Add("Address");
            customers.Columns.Add("Email");
            customers.Columns.Add("NationalNumber");
            customers.Columns.Add("Credit_Card_Num");
            customers.Columns.Add("Gender");
            DataRow row;
            while (reader.Read())
            {
                row = customers.NewRow();
                row["Name"] = reader["Name"];
                row["Age"] = reader["Age"];
                row["Address"] = reader["Address"];
                row["Email"] = reader["Email"];
                row["NationalNumber"] = reader["NationalNumber"];
                row["Credit_Card_Num"] = reader["Credit_Card_Num"];
                row["Gender"] = reader["Gender"];
                customers.Rows.Add(row);               
            }
            reader.Close();
            con.Close();
            dataGridView1.DataSource = customers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
