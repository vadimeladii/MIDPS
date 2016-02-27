using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class SelectDB
    {
        private SqlConnection sqlConnection;

        public SelectDB()
        {
            sqlConnection = new ConnectionDB().openConnection();
        }

        public void magazinTout()
        {
            Magazin magazin = null;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from Magazin", sqlConnection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                Program.getListMagazin().Clear();
                while (reader.Read())
                {
                    magazin=new Magazin();
                    magazin.id = Int32.Parse(reader[0].ToString());
                    magazin.nameMagazin = reader[1].ToString();
                    Program.getListMagazin().Add(magazin);  
                }
                 Program.magazinPrimar = magazin;
            }
          
            sqlCommand.Dispose();
            sqlConnection.Close();
        } 

        public void cereale()
        {
            Cereale cereale;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from Cereale", sqlConnection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                Program.getListCereale().Clear();
                while (reader.Read())
                {
                    cereale = new Cereale();
                    cereale.id = Int32.Parse(reader[0].ToString());
                    cereale.nameComponentProdus = reader[1].ToString();
                    cereale.cantitateaProdus = Int32.Parse(reader[2].ToString());
                    cereale.cantitateUmiditate = reader[3].ToString();
                    Program.getListCereale().Add(cereale);
                }
            }
            sqlCommand.Dispose();
            sqlConnection.Close();
        }

        public void cerealeMagazinID(int id)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from Cereale where idCereale in (select idCereale from InteractionMagazinCereale where InteractionMagazinCereale.idMagazin='"+id+"')", sqlConnection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                Program.magazinPrimar.getListCereale().Clear();
                while (reader.Read())
                {
                    Cereale cereale = new Cereale();
                    cereale.id = Int32.Parse(reader[0].ToString());
                    cereale.nameComponentProdus = reader[1].ToString();
                    cereale.cantitateaProdus = Int32.Parse(reader[2].ToString());
                    cereale.cantitateUmiditate = reader[3].ToString();
                    Program.magazinPrimar.getListCereale().Add(cereale);
                }
            }
            sqlCommand.Dispose();
            sqlConnection.Close();
        }
    }
}
