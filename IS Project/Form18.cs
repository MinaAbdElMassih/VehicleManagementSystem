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
    public partial class Form18 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MINA-PC\\SQLEXPRESS;Initial Catalog=Vehicle managment project2;Integrated Security=True");

        public Form18()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select color ,vehicle_producer_ID, Sticker,Tires,Paint,Conditioner,car_lamp,fans from Vehicles", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable customers = new DataTable();
            customers.Columns.Add("color");
            customers.Columns.Add("vehicle_producer_ID");
            customers.Columns.Add("Sticker");
            customers.Columns.Add("Tires");
            customers.Columns.Add("Paint");
            customers.Columns.Add("Conditioner");
            customers.Columns.Add("car_lamp");
            customers.Columns.Add("fans");
            DataRow row;
            while (reader.Read())
            {
                row = customers.NewRow();
                row["color"] = reader["color"];
                row["vehicle_producer_ID"] = reader["vehicle_producer_ID"];
                row["Sticker"] = reader["Sticker"];
                row["Tires"] = reader["Tires"];
                row["Paint"] = reader["Paint"];
                row["Conditioner"] = reader["Conditioner"];
                row["car_lamp"] = reader["car_lamp"];
                row["fans"] = reader["fans"];
                customers.Rows.Add(row);
            }
            reader.Close();
            con.Close();
            dataGridView1.DataSource = customers;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
