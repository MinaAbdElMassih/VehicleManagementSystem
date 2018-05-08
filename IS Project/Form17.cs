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
    public partial class Form17 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MINA-PC\\SQLEXPRESS;Initial Catalog=Vehicle managment project2;Integrated Security=True");

        public Form17()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Car,Motorcycle,Vehicle_producer from Category", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable customers = new DataTable();
            customers.Columns.Add("Car");
            customers.Columns.Add("Motorcycle");
            customers.Columns.Add("Vehicle_producer");
            DataRow row;
            while (reader.Read())
            {
                row = customers.NewRow();
                row["Car"] = reader["Car"];
                row["Motorcycle"] = reader["Motorcycle"];
                row["Vehicle_producer"] = reader["Vehicle_producer"];               
                customers.Rows.Add(row);
            }
            reader.Close();
            con.Close();
            dataGridView1.DataSource = customers;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            Application.Exit();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
