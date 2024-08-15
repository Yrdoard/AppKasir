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
            SetupAutoCompleteForProductSearch();
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
                int totalQuantityInGrid = 0;
                DataGridViewRow existingRow = null;

                foreach (DataGridViewRow row in homeForm.dataGridView3.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().ToLower() == productName)
                    {
                        totalQuantityInGrid += Convert.ToInt32(row.Cells[1].Value);
                        existingRow = row;
                    }
                }

                if (product.Stock >= totalQuantityInGrid + quantity)
                {
                    if (existingRow != null)
                    {
                        existingRow.Cells[1].Value = totalQuantityInGrid + quantity;
                        existingRow.Cells[2].Value = product.Price * (totalQuantityInGrid + quantity);
                    }
                    else
                    {
                        homeForm.dataGridView3.Rows.Add(product.Name, quantity, product.Price * quantity);
                    }
                    homeForm.UpdateTotalPrice();
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


        private void SetupAutoCompleteForProductSearch()
        {
            var productNames = Program.db.Products.Select(p => p.Name).ToArray();
            var autoCompleteSource = new AutoCompleteStringCollection();
            autoCompleteSource.AddRange(productNames);

            TbName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TbName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TbName.AutoCompleteCustomSource = autoCompleteSource;
        }
    }
}
