using NavigationExample11b.Controller;
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

        private void MainView_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.GetAll();
        }
    }
}
