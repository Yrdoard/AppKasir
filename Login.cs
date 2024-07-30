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
            User user = Program.db.Users.FirstOrDefault(value => value.Username == TbUsername.Text && value.Password == TbPassword.Text);
            if (user == null)
            {
                MessageBox.Show("Username atau password salah");
                return;
            }
            if (user.UserType == "Admin")
            {
                new Home().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Anda tidak memiliki akses");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
