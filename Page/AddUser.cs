﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kasir.Models;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;

namespace Kasir.Page
{
    public partial class AddUser : Form
    {
        private Home homeForm;
        public AddUser(Home home)
        {
            InitializeComponent();
            homeForm = home;
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            Models.User user = new Models.User
            {
                Name = TbName.Text,
                UserType = comboBox1.Text,
                Address = TbAddress.Text,
                PhoneNumber = TbPhoneNumber.Text,
                Username = TbUsername.Text,
                Password = TbPassword.Text,
            };
            if (string.IsNullOrEmpty(TbName.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(TbAddress.Text) || string.IsNullOrEmpty(TbPassword.Text) || string.IsNullOrEmpty(TbPhoneNumber.Text) || string.IsNullOrEmpty(TbUsername.Text)){
                MessageBox.Show("Please enter valid user details.");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Program.db.Users.Add(user);
                    Program.db.SaveChanges();
                    homeForm.RDataUser();
                    this.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
