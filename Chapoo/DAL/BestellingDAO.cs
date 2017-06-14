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
    public class BestellingDAO
    {
        protected SqlConnection dbConnection;


        public BestellingDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public Bestelling ReadBestelling(SqlDataReader reader)
        {
            int bestellingid = (int)reader["Bestelling_id"];
            int medewerkerid = (int)reader["Werknemer_id"];
            int tafelid = (int)reader["Tafel_id"];
            DateTime tijd = (DateTime)reader["Tijd"];

            return new Bestelling(bestellingid, medewerkerid, tafelid, tijd);
        }

        public Bestelling GetBestellingById(int id)
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

                while (reader.Read())
                {
                    int id = (int)reader["Bestelling_id"];
                    int medewerkersId = (int)reader["Werknemer_id"];
                    int TafelId = (int)reader["Tafel_id"];
                    DateTime tijd = (DateTime)reader["Tijd"];
                    Bestelling b = new Bestelling(id, medewerkersId, TafelId, tijd);
                    bestelingen.Add(b);
                }


                // Call Close when done reading.
                reader.Close();
                dbConnection.Close();
                return bestelingen;
            }
        }

        public void WriteBesteling(Bestelling nieuwBestelling)
        {
            string queryString =
            "INSERT INTO dbo.Bestelling (Werknemer_id, Tafel_id, Tijd ) " +
            "VALUES (@werknemer_id, @tafel_id, @tijd )";
            

            using (dbConnection)
            {
                SqlCommand command = new SqlCommand(queryString, dbConnection);
                dbConnection.Open();


                SqlParameter werknemerId = new SqlParameter("@werknemer_id", System.Data.SqlDbType.Int);
                SqlParameter tafelId = new SqlParameter("@tafel_id", System.Data.SqlDbType.Int);
                SqlParameter Tijd = new SqlParameter("@tijd", System.Data.SqlDbType.NVarChar);



                werknemerId.Value = nieuwBestelling.MedewerkersId;
                tafelId.Value = nieuwBestelling.TafelId;
                Tijd.Value = nieuwBestelling.Tijd;


                command.Parameters.Add(werknemerId);
                command.Parameters.Add(tafelId);
                command.Parameters.Add(Tijd);


                command.Prepare();

                command.ExecuteNonQuery();


                // Call Close when done reading.

                dbConnection.Close();


                
            }

            
           
        }

        public int GetBestellingIdByTijd(DateTime tijd)
        {
            string queryString =
            "SELECT * FROM dbo.Bestelling WHERE Tijd = @tijd;";


            using (dbConnection)
            {
                SqlCommand command = new SqlCommand(queryString, dbConnection);
                dbConnection.Open();

                SqlParameter BestellingTijdParam = new SqlParameter("@tijd", System.Data.SqlDbType.DateTime);
                BestellingTijdParam.Value = tijd;
                command.Parameters.Add(BestellingTijdParam);

                command.Prepare();
                SqlDataReader reader = command.ExecuteReader();

                int id = (int)reader["Bestelling_id"];
                            
                reader.Close();
                dbConnection.Close();
                return id;
            }

        }

    }
}
