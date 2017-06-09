using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class MedewerkerDAO
    {
        protected SqlConnection dbConnection;

        public MedewerkerDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        //Door: Juan
        //Haalt het wachtwoord op bij een bepaalde werknemerid
        public Medewerker GetWerknemerById(int werknemerId)

         {
            string queryString = "SELECT * FROM dbo.Werknemer WHERE Werknemer_id = @werknemer_id";

            using (dbConnection)
            {

                SqlCommand command = new SqlCommand(queryString, dbConnection);
                dbConnection.Open();

                SqlParameter werknemer_idParam = new SqlParameter("@werknemer_id", System.Data.SqlDbType.Int);

                werknemer_idParam.Value = werknemerId;

                command.Parameters.Add(werknemer_idParam);
                //command.Prepare();
                SqlDataReader reader = command.ExecuteReader();

                Medewerker medewerker;

              
                string voornaam = (string)reader["Voornaam"];
                string achternaam = (string)reader["Achternaam"];
                Functie functie = (Functie)reader["Functie"];
                medewerker = new Medewerker(werknemerId, voornaam, achternaam, functie);

                //if (medewerker.Functie == Functie.eigenaar)
                //{
                //    string wachtwoord = (string)reader["Wachtwoord"];
                //}

                reader.Close();
                dbConnection.Close();

                return medewerker;
            }
        }
    }
}


