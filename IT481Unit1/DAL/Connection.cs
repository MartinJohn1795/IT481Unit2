using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IT481Unit1.DAL
{
    public class Connection
    {
       public SqlConnection con = new SqlConnection("Data Source=DESKTOP-56MKEJ8\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
    }
}
