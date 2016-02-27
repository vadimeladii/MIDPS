using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class UpdateDB
    {
        SqlConnection sqlConnection = null;

        public UpdateDB()
        {
            sqlConnection = new ConnectionDB().openConnection();
        }

        public void magazin(int id,string nameMagazin)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("update Magazin set nameMagazin='"+nameMagazin+"' where idMagazin='"+id+"'",sqlConnection);
            sqlCommand.ExecuteNonQuery();

            sqlCommand.Dispose();
            sqlConnection.Close();
        }

        public void cereale(int id , string nameCereale , int cantitateCereale , String umiditateCereale)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("update Cereale set nameCereale='" + nameCereale + "'," +
                 "cantitateCereale='" + cantitateCereale + "', umiditateaCereale='" + umiditateCereale + "'" +
                 " where idCereale='" + id + "'",sqlConnection);
            sqlCommand.ExecuteNonQuery();

            sqlCommand.Dispose();
            sqlConnection.Close();
        }
    }
}
