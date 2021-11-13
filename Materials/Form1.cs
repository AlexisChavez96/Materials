using Materials.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Materials
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();

            string consultar = "select * from [Materials].[dbo].[Buildings]";
            SqlCommand cmd2 = new SqlCommand(consultar, Conexion.Conectar());
            SqlDataReader dr = cmd2.ExecuteReader();
            dataGridView1.DataSource = llenar_grid();

            string consultarCostumers = "SELECT [PKCustomers],[Customer],[Prefix],[FKBuilding] FROM [Materials].[dbo].[Customers]";
            SqlCommand cmd3 = new SqlCommand(consultarCostumers, Conexion.Conectar());
            SqlDataReader drc = cmd3.ExecuteReader();
            dataGridView2.DataSource = llenar_grid_customer();


            if (drc.HasRows)
            {
                while (drc.Read())
                {
                    this.listBoxBuilding.Items.Add(drc.GetString(1));
                }
            }

            string consultarParts = "SELECT [PKCustomers],[Customer],[Prefix],[FKBuilding] FROM [Materials].[dbo].[Customers]";
            SqlCommand cmd4 = new SqlCommand(consultarParts, Conexion.Conectar());
            SqlDataReader drp = cmd4.ExecuteReader();
            dataGridView3.DataSource = llenar_grid_part();

            if (drp.HasRows)
            {
                while (drp.Read())
                {
                    this.listBoxCostumers.Items.Add(drp.GetString(1));
                }
            }

        }

        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "select * from Buildings";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "insert into [Materials].[dbo].[Buildings] values (@nameBuilding)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@nameBuilding", txtNameBuilding.Text);

            cmd1.ExecuteNonQuery();

            dataGridView1.DataSource = llenar_grid();

            string consultar = "select * from [Materials].[dbo].[Buildings]";
            SqlCommand cmd2 = new SqlCommand(consultar, Conexion.Conectar());
            SqlDataReader dr = cmd2.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    this.listBoxBuilding.Items.Add(dr.GetString(1));
                }
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBoxBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "insert into [Materials].[dbo].[Customers] values (@Customer, @Prefix, @FKBuilding)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@Customer", txtCostumer.Text);
            cmd1.Parameters.AddWithValue("@Prefix", txtPrefix.Text);
            cmd1.Parameters.AddWithValue("@FKBuilding", listBoxBuilding.SelectedIndex + 1);

            cmd1.ExecuteNonQuery();

            dataGridView2.DataSource = llenar_grid_customer();

            string consultar = "SELECT [PKCustomers],[Customer],[Prefix],[FKBuilding] FROM [Materials].[dbo].[Customers]";
            SqlCommand cmd2 = new SqlCommand(consultar, Conexion.Conectar());
            SqlDataReader dr = cmd2.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    this.listBoxCostumers.Items.Add(dr.GetString(1));
                }
            }

        }

        public DataTable llenar_grid_customer()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT [PKCustomers],[Customer],[Prefix],[FKBuilding] FROM [Materials].[dbo].[Customers]";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        public DataTable llenar_grid_part()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT [PKPartNumber],[PartNumber],[Available],[FKCustomer] FROM [Materials].[dbo].[PartNumbers]";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarPart_Click(object sender, EventArgs e)
        {

            Boolean available;

            if (checkBoxAvailable.Checked)
            {
                available = true;
            }
            else
            {
                available = false;
            }

            Conexion.Conectar();
            string insertar = "insert into [Materials].[dbo].[PartNumbers] values (@PartNumber, @Available, @FKCustomer)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@PartNumber", txtPartNumber.Text);
            cmd1.Parameters.AddWithValue("@Available", available);
            cmd1.Parameters.AddWithValue("@FKCustomer", listBoxCostumers.SelectedIndex + 1);

            cmd1.ExecuteNonQuery();

            dataGridView3.DataSource = llenar_grid_part();
        }

        private void listBoxPartNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
