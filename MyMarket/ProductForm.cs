﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyMarket
{
    public partial class ProductForm : Form
    {

        DBConnect dBCon = new DBConnect();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();

        }
        private void getCategory() {
            string selectQuerry = "SELECT *FROM Category";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_category.DataSource = table;
            comboBox_category.ValueMember = "CatName";
            comboBox_categories.DataSource = table;
            comboBox_categories.ValueMember = "CatName";

        }

        private void getTable()
        {
            string selectQuerry = "SELECT *FROM Category";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;
        }
        private void clear()
        {
            TextBox_id.Clear();
            TextBox_name.Clear();
            TextBox_price.Clear();
            TextBox_quantity.Clear();
            comboBox_category.SelectedIndex = 0;
        }


        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
            string insertQuery="INSERT INTO Product VALUES ('" +TextBox_id.Text+"','"+TextBox_name.Text+ "','" +TextBox_price.Text+"','"+TextBox_quantity.Text+"','"+comboBox_category.Text + "')";
            SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
            dBCon.OpenCon();
            command.ExecuteNonQuery();
            MessageBox.Show("Product Added Succesfuly");
            dBCon.CloseCon();
            getTable();
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if(TextBox_id.Text =="" || TextBox_name.Text =="" || TextBox_price.Text =="" ||TextBox_quantity.Text =="")
                {
                    MessageBox.Show("Missing İnformation");
                }
                else
                {
                string updateQuery = "UPDATE Product SET ProdName='" + TextBox_name.Text + "',ProdPrice='" + TextBox_price.Text + "',ProdQty='" + TextBox_quantity.Text + "',ProdCat='" + comboBox_category.Text + "'WHERE ProdId="+TextBox_id.Text+" '";

                SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Updated Succesfuly");
                dBCon.CloseCon();
                getTable();
                clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dataGridView_product_Click_1(object sender, EventArgs e)
        {
            TextBox_id.Text = dataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_name.Text = dataGridView_product.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_price.Text = dataGridView_product.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_quantity.Text = dataGridView_product.SelectedRows[0].Cells[3].Value.ToString();
            comboBox_category.SelectedValue = dataGridView_product.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

            try
            {
                if (TextBox_id.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {

            string deleteQuery = "DELETE FROM Product WHERE ProId=" + TextBox_id.Text + "";
            SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
            dBCon.OpenCon();
            command.ExecuteNonQuery();
            MessageBox.Show("Product Deleted Succesfuly");
            dBCon.CloseCon();
            getTable();
            clear();

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            getTable();

        }

        private void comboBox_categories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT *FROM Product WHERE ProdCat='"+comboBox_categories.SelectedValue.ToString()+"'";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button_seller_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }
    }
}
