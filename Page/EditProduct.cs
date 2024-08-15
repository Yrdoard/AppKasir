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
    public partial class EditProduct : Form
    {
        private Product product;
        private Home homeForm;

        public EditProduct(Product product, Home home)
        {
            InitializeComponent();
            this.product = product;
            this.homeForm = home;
            LoadProductData();
        }

        private void LoadProductData()
        {
            TbName.Text = product.Name;
            TbPrice.Text = product.Price.ToString();
            TbStock.Text = product.Stock.ToString();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            product.Name = TbName.Text;
            product.Price = Convert.ToInt32(TbPrice.Text);
            product.Stock = Convert.ToInt32(TbStock.Text);

            if(string.IsNullOrEmpty(TbName.Text) || string.IsNullOrEmpty(TbPrice.Text) || string.IsNullOrEmpty(TbStock.Text))
            {
                MessageBox.Show("Please enter valid product details.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Program.db.SaveChanges();
                    homeForm.RDataProduct();
                    this.Close();
                }
            }
        }

        private void Tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
