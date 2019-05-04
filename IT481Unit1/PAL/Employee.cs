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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home openForm = new Home();
            openForm.Show();
        }

        private void btnViewEmployees_Click(object sender, EventArgs e)
        {
            EmployeeBLL objBLL = new EmployeeBLL();
            dataGridView1.DataSource=objBLL.GetEmployee();
        }
    }
}
