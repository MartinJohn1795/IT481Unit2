using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using IT481Unit1.DAL;

namespace IT481Unit1.BLL
{
    public class EmployeeBLL
    {
        public DataTable GetEmployee()
        {
            try
            {
                CustomerDAL objdal = new CustomerDAL();
                return objdal.ReadCustomer();
            }
            catch
            {
                throw;
            }
        }
    }
}
