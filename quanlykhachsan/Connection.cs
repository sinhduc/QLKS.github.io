using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace quanlykhachsan
{
    internal class Connection
    {
        private static string StringConnection = @"Data Source=YOUR-NAME;Initial Catalog=QLKS1;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(StringConnection);
        }
    }
}
