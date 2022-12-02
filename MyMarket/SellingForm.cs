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

namespace MyMarket
{
    public partial class SellingForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public SellingForm()
        {
            InitializeComponent();
        }

        private void getCategory()
        {
            string selectQuerry = "SELECT *FROM Category";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox_category.DataSource = table;
            comboBox_category.ValueMember = "CatName";
           
        }

        private void getTable()
        {
            string selectQuerry = "SELECT ProdName, ProdPrice FROM Product";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            getTable();
            getCategory();
        }

        private void dataGridView_product_Click(object sender, EventArgs e)
        {
            TextBox_name.Text = dataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_price.Text = dataGridView_product.SelectedRows[0].Cells[1].Value.ToString();
        }

        int grandTotal = 0, n = 0;

        private void button_addOrder_Click(object sender, EventArgs e)
        {
            int Total = Convert.ToInt32(TextBox_price.Text) * Convert.ToInt32(TextBox_quantity.Text);
            DataGridViewRow addRow = new DataGridViewRow();
            addRow.CreateCells(dataGridView_orders);
            addRow.Cells[0].Value =++n;
            addRow.Cells[1].Value = TextBox_name.Text;
            addRow.Cells[2].Value = TextBox_price.Text;
            addRow.Cells[3].Value = TextBox_quantity.Text;
            addRow.Cells[4].Value = Total;
            dataGridView_orders.Rows.Add(addRow);
            grandTotal += Total;
        }
    }
}
