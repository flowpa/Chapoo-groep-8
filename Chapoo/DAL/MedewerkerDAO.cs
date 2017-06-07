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
    class MedewerkerDAO
    {
        protected SqlConnection dbConnection;

        //Door: Juan
        //Haalt een werknemer id op.
        public Medewerker GetWerknemerId(int Werknemer_id)
        {
            string connString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            dbConnection = new SqlConnection(connString);

            using (dbConnection)
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("SELECT Werknemer_id");
                sb.Append("FROM Werknemer");

                string queryString = sb.ToString();

                SqlCommand command = new SqlCommand(queryString, dbConnection);

            }
            //  return
        }

        //Door: Juan
        //Haalt het wachtwoord op bij een bepaalde werknemerid
        public Medewerker GetWerknemerById(int werknemerId)
        {

            using (dbConnection)
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("SELECT * ");
                sb.Append("FROM Werknemer ");
                sb.Append("WHERE Werknemer_id = @werknemer_id ");

                string queryString = sb.ToString();

                SqlCommand command = new SqlCommand(queryString, dbConnection);

                SqlParameter werknemer_idParam = new SqlParameter("@werknemer_id", System.Data.SqlDbType.Int);

                werknemer_idParam.Value = werknemerId;

                command.Parameters.Add(werknemer_idParam);
                command.Prepare();
                SqlDataReader reader = command.ExecuteReader();

                Medewerker medewerker;

                if (reader.Read())
                {
                    string voornaam = reader.GetString(1);
                    string achternaam = reader.GetString(2);
                    // Functie functie = reader.GetString(3));
                    Functie functie = Functie.eigenaar;
                    string wachtwoord = reader.GetString(4);
                    medewerker = new Medewerker(werknemerId, voornaam, achternaam, functie);
                }

                reader.Close();
                dbConnection.Close();

                return medewerker;
            }
             

        }
        //Werknemer_id, Voornaam, Achternaam, Functie, wachtwoord
    }
}


