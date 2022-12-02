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
    public partial class LoginForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public static string sellerName;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label_clear_MouseEnter(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Red;

        }

        private void label_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.White;
        }

        private void label_clear_Click(object sender, EventArgs e)
        {
            TextBox_username.Clear();
            TextBox_password.Clear();

        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            if(comboBox_role.SelectedItem.ToString()=="ADMİN")
            {
                if(TextBox_username.Text=="Admin" || TextBox_password.Text=="Admin123")
                {
                    ProductForm product = new ProductForm();
                    product.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("İf you are admin please enter the correct password...");
                }
            }
            else
            {
                string selectQuery = "SELECT *FROM Seller WHERE SellerName='" + TextBox_username.Text + "'AND SellerPas='" + TextBox_password.Text + "'";
                
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery,dBCon.GetCon());
                DataTable table = new DataTable();
                adapter.Fill(table);
                if(table.Rows.Count>0)
                {

                    sellerName = TextBox_username.Text;
                    SellingForm selling = new SellingForm();
                    selling.Show();
                    this.Hide();
                }else
                {
                    MessageBox.Show("Wrong password or Username");
                }
            }
        }
    }
}
