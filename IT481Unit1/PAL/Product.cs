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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home openForm = new Home();
            openForm.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductBLL objBLL = new ProductBLL();
            dataGridView1.DataSource = objBLL.GetProduct();
        }
    }
}
