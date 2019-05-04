using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IT481Unit1.BLL;

namespace IT481Unit1.PAL
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            CustomerBLL objBLL = new CustomerBLL();
            dataGridView1.DataSource = objBLL.GetCustomer();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home openForm = new Home();
            openForm.Show();
        }
    }
}
