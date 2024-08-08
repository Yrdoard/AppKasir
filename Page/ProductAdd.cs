using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir.Page
{
    public partial class ProductAdd : Form
    {
        private Home homeForm;
        public ProductAdd(Home home)
        {
            InitializeComponent();
            homeForm = home;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string productName = TbName.Text.ToLower();
            int quantity;

            if (string.IsNullOrEmpty(productName) || !int.TryParse(TbQuantity.Text, out quantity))
            {
                MessageBox.Show("Please enter valid product details.");
                return;
            }

            var product = Program.db.Products.FirstOrDefault(x => x.Name.ToLower().Contains(productName));

            if (product != null)
            {
                if (product.Stock >= quantity)
                {
                    homeForm.dataGridView3.Rows.Add(product.Name, quantity, product.Price * quantity);
                    Close();
                }
                else
                {
                    MessageBox.Show("Insufficient stock.");
                }
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
        }
    }
}
