using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class ConnectionDB
    {
        SqlConnection sqlConnection = null;

        public SqlConnection openConnection()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Util.STRIN_CONNECTION_DB;
            //sqlConnection.Open();
            return sqlConnection;
        }
        
    }
}
