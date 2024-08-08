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
using Kasir.Page;

namespace Kasir
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User? user = Program.db.Users.FirstOrDefault(value => value.Username == TbUsername.Text && value.Password == TbPassword.Text);
            if (TbUsername.Text.Length == 0 || TbPassword.Text.Length == 0)
            {
                MessageBox.Show("Username & Password undefined");
                return;
            }

            if (user == null)
            {
                MessageBox.Show("Username & Password is null");
                return;
            }

            switch (user.UserType)
            {
                case "Admin":
                    Home home = new Home(user);
                    home.Show();
                    this.Hide();
                    break;

                case "Staff":
                    Home homeStaff = new Home(user);
                    homeStaff.Show();
                    this.Hide();
                    break;

                default:
                    MessageBox.Show("User Type not defined");
                    break;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
