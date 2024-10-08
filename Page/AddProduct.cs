﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kasir.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kasir.Page
{
    public partial class AddProduct : Form
    {
        private Home homeForm;
        public AddProduct(Home home)
        {
            InitializeComponent();
            homeForm = home;
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Name = TbName.Text,
                Price = Convert.ToInt32(TbPrice.Text),
                Stock = Convert.ToInt32(TbStock.Text)
            };

            if (string.IsNullOrEmpty(TbName.Text) || string.IsNullOrEmpty(TbPrice.Text) || string.IsNullOrEmpty(TbStock.Text))
            {
                MessageBox.Show("Please enter valid user details.");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Program.db.Products.Add(product);
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
