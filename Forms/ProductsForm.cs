using Microsoft.Data.SqlClient;
using SmartInventoryApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SmartInventoryApp.Forms
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            using SqlConnection con = DbHelper.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProducts.DataSource = dt;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using SqlConnection con = DbHelper.GetConnection();
            string sql = "INSERT INTO Products (Name, Description, Price, Stock) VALUES (@Name, @Desc, @Price, @Stock)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Desc", txtDescription.Text);
            cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
            cmd.Parameters.AddWithValue("@Stock", int.Parse(txtStock.Text));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            LoadProducts();
            MessageBox.Show("Product added successfully.");
        }
    }
}
