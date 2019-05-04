using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using IT481Unit1.DAL;

namespace IT481Unit1.BLL
{
    public class ProductBLL
    {
        public DataTable GetProduct()
        {
            try
            {
                ProductDAL objdal = new ProductDAL();
                return objdal.ReadProduct();
            }
            catch
            {
                throw;
            }
        }
    }
}
