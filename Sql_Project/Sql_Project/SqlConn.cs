using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sql_Project
{
    class SqlConn
    {
        public SqlConnection connection()
        {
            SqlConnection conn = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=OBS;Integrated Security=True");
            conn.Open();
            return conn;
        }
    }
}
