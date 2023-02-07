using NavigationExample11b.Controller;
using NavigationExample11b.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigationExample11b.View
{
    public partial class RegisterView : Form
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username == string.Empty)
            {
                MessageBox.Show("Please enter your username");
            }
            User user = new User(username, password);
            LoginController.AddUser(user);
            LoginViewcs m = new LoginViewcs();
            this.Hide();
            m.Show();
        }
    }
}
