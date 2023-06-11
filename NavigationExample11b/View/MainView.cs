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
    public partial class MainView : Form
    {
        LoginController controller = new LoginController();
        public MainView()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            dgv.DataSource = controller.ReadAllUsers();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var user = new User(txtUsername.Text, txtPassword.Text);
            controller.CreateUser(user);
            RefreshData();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            User user = new User(txtUsername.Text, txtPassword.Text);
            controller.UpdateUser(id, user);
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            controller.DeleteUser(id);
            RefreshData();
        }
    }
}
