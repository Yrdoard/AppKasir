using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Kasir.Models;

namespace Kasir.Page
{
    public partial class Home : Form
    {
        public decimal totalPrice = 0;
        private User loggedInUser;
        private Login login;
        private Product selectedProduct;
        private User selectedUser;
        private DataGridViewRow selectedRow;
        public Home(User user, Login _login)
        {
            InitializeComponent();
            loggedInUser = user;
            login = _login;
            RDataSale();
            RDataProduct();
            RDataUser();
            if (loggedInUser.UserType != "Admin")
            {
                tabControl1.TabPages.Remove(tabPage1);
                button4.Visible = false;
                button5.Visible = false;
                button7.Visible = false;
                label4.Visible = false;
            }
        }

        public void RDataProduct()
        {
            productBindingSource.DataSource = Program.db.Products.ToList();
        }

        public void RDataUser()
        {
            userBindingSource.DataSource = Program.db.Users.ToList();
        }

        public void RDataSale()
        {
            dataGridView4.DataSource = Program.db.Sales.Select(x => new
            {
                Id = x.Id,
                SaleDate = x.SaleDate,
                TotalPrice = x.TotalPrice,
                Costumer = x.Costumer.Name
            }).ToList();
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
                TbSearch.Text = string.Empty;
            }
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            ProductAdd productAdd = new ProductAdd(this);
            productAdd.ShowDialog();
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
            if (selectedUser != null)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Program.db.Users.Remove(selectedUser);
                    Program.db.SaveChanges();
                    RDataUser();
                }
            }
            else
            {
                MessageBox.Show("Please select a User to delete.");
            }
        }

        private void UserSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbSearchUser.Text))
            {
                RDataUser();
            }
            else
            {
                string searchText = TbSearchUser.Text.ToLower();
                userBindingSource.DataSource = Program.db.Users
                    .Where(x => x.Name.ToLower().Contains(searchText))
                    .ToList();
                TbSearchUser.Text = string.Empty;
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Costumer? costumer = null;
            decimal discount = 0;

            if (!string.IsNullOrEmpty(TbMember.Text))
            {
                string phoneNumber = TbMember.Text;

                costumer = Program.db.Costumers.FirstOrDefault(c => c.PhoneNumber == phoneNumber);

                if (costumer == null)
                {
                    MessageBox.Show("Member not found.");
                    return;
                }
                else
                {
                    // Apply 10% discount if member is found
                    discount = 0.10m;
                }
            }

            if (dataGridView3.Rows.Count == 0)
            {
                MessageBox.Show("Please add products to the cart first.");
                return;
            }

            Sale sale = new Sale
            {
                SaleDate = DateTime.Now,
                TotalPrice = totalPrice,
                Costumer = costumer
            };

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    string productName = row.Cells[0].Value.ToString();
                    if (int.TryParse(row.Cells[1].Value.ToString(), out int quantity))
                    {
                        Product product = Program.db.Products.FirstOrDefault(p => p.Name == productName);

                        if (product != null)
                        {
                            product.Stock -= quantity;
                            if (product.Stock < 0)
                            {
                                product.Stock = 0;
                            }

                            SaleDetail saleDetail = new SaleDetail
                            {
                                Sale = sale,
                                Productid = product,
                                Quantity = quantity,
                                SubTotalPrice = product.Price,
                                User = loggedInUser
                            };

                            Program.db.SaleDetails.Add(saleDetail);
                        }
                        else
                        {
                            MessageBox.Show("Product not found: " + productName);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid quantity for product: " + productName);
                    }
                }
            }

            if (decimal.TryParse(textBox3.Text, out decimal amountPaid))
            {
                if (amountPaid < totalPrice)
                {
                    MessageBox.Show("The amount paid is less than the total price. Please enter a valid amount.");
                    return;
                }
                decimal discountAmount = totalPrice * discount;
                decimal change = amountPaid - discountAmount;

                ReceiptForm receiptForm = new ReceiptForm(dataGridView3.Rows, totalPrice, amountPaid, change, discount);
                receiptForm.ShowDialog();

                dataGridView3.Rows.Clear();
                textBox3.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Invalid amount entered. Please enter a valid number.");
            }

            Program.db.Sales.Add(sale);
            Program.db.SaveChanges();
            RDataProduct();
            RDataSale();
            UpdateTotalPrice();
            TbMember.Text = string.Empty;
        }

        public void UpdateTotalPrice()
        {
            totalPrice = 0;
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    totalPrice += Convert.ToDecimal(row.Cells[2].Value);
                }
            }
            textBox2.Text = totalPrice.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            login.Show();
            Close();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                dataGridView3.Rows.RemoveAt(e.RowIndex);
                UpdateTotalPrice();
            }
        }

    }
}
