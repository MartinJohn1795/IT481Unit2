using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IT481Unit1.DAL
{
    public class EmployeeDAL
    {
        DataTable dt = new DataTable();

        public DataTable ReadEmployee()
        {
            Connection conn = new Connection();
            if(ConnectionState.Closed == conn.con.State)
            {
                conn.con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from Employees", conn.con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }
        }
    }
}
