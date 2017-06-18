using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;
using Model;

namespace DAL
{
    public class BonDAO
    {
        protected SqlConnection dbConnection;

        public BonDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }
        //Juan

        public Bon getBonByBestellingId(int bestellingId)
        {
            string queryString = "SELECT * FROM dbo.Bon WHERE Bestelling_id = @bestelling_id";

            dbConnection.Open();

            SqlCommand command = new SqlCommand(queryString, dbConnection);

            SqlParameter bestelling_idParam = new SqlParameter("@bestelling_id", System.Data.SqlDbType.Int);

            bestelling_idParam.Value = bestellingId;

            command.Parameters.Add(bestelling_idParam);
            command.Prepare();

            SqlDataReader reader = command.ExecuteReader();

            Bon bon = null;

            if (reader.Read())
            {
                int bonId = (int)reader["Bon_id"];
                double fooi = (double)reader["Fooi"];
                bool isBetaald = (bool)reader["Is_betaald"];

                bon = new Bon(bonId, bestellingId, fooi, isBetaald); 
            }
            
            reader.Close();
            dbConnection.Close();

            return bon;
        }
    }
}
