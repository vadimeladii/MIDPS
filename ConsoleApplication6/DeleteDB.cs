using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class DeleteDB
    {
        private SqlConnection sqlConnection;

        public DeleteDB()
        {
            sqlConnection = new ConnectionDB().openConnection();
        }

        public void deleteMagazin(int id)
        {
            sqlConnection.Open();
            SqlCommand deleteCommand = new SqlCommand("delete  from Magazin  where idMagazin='"+id+"' ", sqlConnection);
            deleteCommand.ExecuteNonQuery();

            deleteCommand.Dispose();
            sqlConnection.Close();
        }

        public void cereale(int id)
        {
            sqlConnection.Open();
            SqlCommand deleteCommand = new SqlCommand("delete  from Cereale  where idCereale='" + id + "' ", sqlConnection);
            deleteCommand.ExecuteNonQuery();

            deleteCommand.Dispose();
            sqlConnection.Close();
        }
    }
}
