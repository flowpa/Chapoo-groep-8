using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Model;

namespace DAL
{
    public class BonDAO
    {
        protected SqlConnection dbConnection;
        private BesteldeMenuItemsDAO BesteldeMenuItemsDAO = new BesteldeMenuItemsDAO();
        private MenuitemDAO MenuitemDAO = new MenuitemDAO();

        public BonDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public void SafeBon(Bon bon)
        {
            string queryString =
            "UPDATE dbo.Bon " +
            "SET Is_betaald = 1, Fooi = @Fooi " +
            "WHERE Bon_id = @Bon_id";

            SqlCommand command = new SqlCommand(queryString, dbConnection);
            dbConnection.Open();

            command.Parameters.AddWithValue("@Bon_id", bon.Id);
            command.Parameters.AddWithValue("@Fooi", bon.Fooi);

            //command.Prepare();
            command.ExecuteNonQuery();

            dbConnection.Close();
        }

        //public void SafeBon(Bon bon)
        //{
        //    string queryString =
        //    "INSERT INTO dbo.Bon (Bestelling_id, Fooi, Is_betaald ) " +
        //    "VALUES (@Bestelling_id, @Fooi, @Is_betaald )";

        //    SqlCommand command = new SqlCommand(queryString, dbConnection);
        //    dbConnection.Open();

        //    command.Parameters.AddWithValue("@Bestelling_id", bon.Betstelling_id);
        //    command.Parameters.AddWithValue("@Fooi", bon.Fooi);
        //    command.Parameters.AddWithValue("@Is_betaald", 1);

        //    //command.Prepare();
        //    command.ExecuteNonQuery();

        //    dbConnection.Close();
        //}
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

            reader.Read();

            int bonId = (int)reader["Bon_id"];
            double fooi = (double)reader["Fooi"];
            bool isBetaald = (bool)reader["Is_betaald"];

            bon = new Bon(bonId, bestellingId, fooi, isBetaald);


            reader.Close();
            dbConnection.Close();

            return bon;
        }

        public void newBonByBestellingId(int bestellingId)
        {
            string queryString =
                "INSERT INTO dbo.Bon (Bestelling_id, Fooi, Is_betaald ) " +
                "VALUES (@Bestelling_id, @Fooi, @Is_betaald )";

            SqlCommand command = new SqlCommand(queryString, dbConnection);
            dbConnection.Open();

            command.Parameters.AddWithValue("@Bestelling_id", bestellingId);
            command.Parameters.AddWithValue("@Fooi", 0);
            command.Parameters.AddWithValue("@Is_betaald", 0);

            command.ExecuteNonQuery();

            dbConnection.Close();
        }

    }
}
