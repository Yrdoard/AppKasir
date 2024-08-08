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
    public partial class EditUser : Form
    {
        private User user;
        private Home homeForm;
        public EditUser(User user, Home home)
        {
            InitializeComponent();
            this.user = user;
            this.homeForm = home;
            LoadUserData();
        }

        public void LoadUserData()
        {
            TbName.Text = user.Name;
            comboBox1.Text = user.UserType;
            TbAddress.Text = user.Address;
            TbPhoneNumber.Text = user.PhoneNumber;
            TbUsername.Text = user.Username;
            TbPassword.Text = user.Password;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                user.Name = TbName.Text;
                user.UserType = comboBox1.Text;
                user.Address = TbAddress.Text;
                user.PhoneNumber = TbPhoneNumber.Text;
                user.Username = TbUsername.Text;
                user.Password = TbPassword.Text;
                

                Program.db.Update(user);
                Program.db.SaveChanges();
                homeForm.RDataUser();
                this.Close();
            }
        }
    }
}
