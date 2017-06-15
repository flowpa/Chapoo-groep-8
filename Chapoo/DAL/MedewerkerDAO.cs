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
        //Haalt de gevegevens van een werknemer op.
        public Medewerker GetWerknemerById(int werknemerId)

        {
            string queryString = "SELECT * FROM Werknemer WHERE Werknemer_id = @werknemer_id";

            dbConnection.Open();

            SqlCommand command = new SqlCommand(queryString, dbConnection);

            SqlParameter werknemer_idParam = new SqlParameter("@werknemer_id", System.Data.SqlDbType.Int);

            werknemer_idParam.Value = werknemerId;

            command.Parameters.Add(werknemer_idParam);
            command.Prepare();
            
            SqlDataReader reader = command.ExecuteReader();

            Medewerker medewerker = null;

            if (reader.Read())
            {
                string voornaam = (string)reader["Voornaam"];
                string achternaam = (string)reader["Achternaam"];
                Functie functie = (Functie)Enum.Parse(typeof(Functie),(string)reader["Functie"]);
                

                medewerker = new Medewerker(werknemerId, voornaam, achternaam, functie);
                
                if(medewerker.Functie == Functie.eigenaar)
                {
                    string wachtwoord = (string)reader["wachtwoord"];
                    medewerker.Wachtwoord = wachtwoord; 
                }
                else
                {
                    medewerker.Wachtwoord = null;
                }   
            }

            reader.Close();
            dbConnection.Close();
            
            return medewerker;
        }
    }
}


