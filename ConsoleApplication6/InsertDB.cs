using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class InsertDB
    {
        private SqlConnection sqlConnection;

        public InsertDB()
        {
            sqlConnection = new ConnectionDB().openConnection();
        }

        public void magazin()
        {
            sqlConnection.Open();
            SqlCommand insertCommand = new SqlCommand("INSERT INTO Magazin(idMagazin, nameMagazin) VALUES (@0, @1)", sqlConnection);

            Console.WriteLine("Introduce id Magazinului : ");
            int idMagazin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce numele Magazinului : ");
            string nameMagazin = Console.ReadLine();

            insertCommand.Parameters.Add(new SqlParameter("0", idMagazin));
            insertCommand.Parameters.Add(new SqlParameter("1", nameMagazin));
            insertCommand.ExecuteNonQuery();

            sqlConnection.Close();
            insertCommand.Dispose();
        }

        public void cereale()
        {
            sqlConnection.Open();
            SqlCommand insertCommand = new SqlCommand("INSERT INTO Cereale(idCereale, nameCereale,cantitateCereale,umiditateaCereale) VALUES (@0, @1 , @2 , @3)", sqlConnection);

            Console.WriteLine("Introduce id Cerealului : ");
            int idCereale = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce numele Cerealei : ");
            string nameCereale = Console.ReadLine();
            Console.WriteLine("Introduce cantitate de cereale");
            int cantitateCereale= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce numele Cerealei : ");
            string umiditateaCereale = Console.ReadLine();

            insertCommand.Parameters.Add(new SqlParameter("0", idCereale));
            insertCommand.Parameters.Add(new SqlParameter("1", nameCereale));
            insertCommand.Parameters.Add(new SqlParameter("2", cantitateCereale));
            insertCommand.Parameters.Add(new SqlParameter("3", umiditateaCereale));

            insertCommand.ExecuteNonQuery();

            sqlConnection.Close();
            insertCommand.Dispose();
        }
    }
}

