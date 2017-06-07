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
    class BestellingDAO
    {
        protected SqlConnection dbConnection;

        public BestellingDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public Bestelling ReadBestelling(int id)
        {
            string queryString =
            "SELECT * FROM dbo.Bestelling WHERE Bestelling_id = @id;";
            

            using (dbConnection)
            {
                SqlCommand command = new SqlCommand(queryString, dbConnection);
                dbConnection.Open();

                SqlParameter BestellingIdParam = new SqlParameter("@id", System.Data.SqlDbType.Int);
                BestellingIdParam.Value = id;
                command.Parameters.Add(BestellingIdParam);

                command.Prepare();
                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                // de code hieronder heb ik laten staan voor als iemand daar een voorbeeld van wilde. groetjes florian.

                //while (reader.Read())
                //{
                //}

                int medewerkersId = (int)reader["Werknemer_id"];
                int TafelId = (int)reader["Tafel_id"];
                DateTime tijd = (DateTime)reader["Tijd"];
                Bestelling b = new Bestelling(id, medewerkersId, TafelId, tijd);
                // Call Close when done reading.
                reader.Close();
                dbConnection.Close();
                return b;
            }

        }

        public List<Bestelling> ReadBestellingen()
        {
            string queryString =
            "SELECT * FROM dbo.Bestelling;";

            using (dbConnection)
            {
                SqlCommand command = new SqlCommand(queryString, dbConnection);
                dbConnection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.

                List<Bestelling> bestelingen = new List<Bestelling>();
                Bestelling b;
                while (reader.Read())
                {
                    int id = (int)reader["Bestelling_id"];
                    int medewerkersId = (int)reader["Werknemer_id"];
                    int TafelId = (int)reader["Tafel_id"];
                    DateTime tijd = (DateTime)reader["Tijd"];
                    b = new Bestelling(id, medewerkersId, TafelId, tijd);
                    bestelingen.Add(b);
                }

                
                // Call Close when done reading.
                reader.Close();
                dbConnection.Close();
                return bestelingen;
            }

        }
    }
}
