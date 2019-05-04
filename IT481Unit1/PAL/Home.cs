using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT481Unit1.PAL
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer openForm = new Customer();
            openForm.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee openForm = new Employee();
            openForm.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product openForm = new Product();
            openForm.Show();
        }
    }
}
