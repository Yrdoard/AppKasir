using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kasir.Models;

namespace Kasir.Page
{
    public partial class Home : Form
    {
        private Product selectedProduct;
        private User selectedUser;
        private DataGridViewRow selectedRow;
        public Home()
        {
            InitializeComponent();
            RDataProduct();
            RDataUser();
        }

        public void RDataProduct()
        {
            productBindingSource.DataSource = Program.db.Products.ToList();
        }

        public void RDataUser()
        {
            userBindingSource.DataSource = Program.db.Users.ToList();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(this);
            addProduct.ShowDialog();
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dataGridView2.Rows[e.RowIndex];
                selectedProduct = (Product)selectedRow.DataBoundItem;
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dataGridView1.Rows[e.RowIndex];
                selectedUser = (User)selectedRow.DataBoundItem;
            }
        }

        private void EditProduct_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                EditProduct editProduct = new EditProduct(selectedProduct, this);
                editProduct.ShowDialog();
                RDataProduct();
            }
            else
            {
                MessageBox.Show("Please select a product to edit.");
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Program.db.Products.Remove(selectedProduct);
                    Program.db.SaveChanges();
                    RDataProduct();
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ProductSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbSearch.Text))
            {
                RDataProduct();
            }
            else
            {
                string searchText = TbSearch.Text.ToLower();
                productBindingSource.DataSource = Program.db.Products
                    .Where(x => x.Name.ToLower().Contains(searchText))
                    .ToList();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(this);
            addUser.ShowDialog();
        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                EditUser editUser = new EditUser(selectedUser, this);
                editUser.ShowDialog();
                RDataUser();
            }
            else
            {
                MessageBox.Show("Please select a product to edit.");
            }
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void UserSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
