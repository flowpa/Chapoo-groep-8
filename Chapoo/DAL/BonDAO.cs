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
            "INSERT INTO dbo.Bon (Bestelling_id, Fooi, Is_betaald ) " +
            "VALUES (@Bestelling_id, @Fooi, @Is_betaald )";
            
            SqlCommand command = new SqlCommand(queryString, dbConnection);
            dbConnection.Open();

            command.Parameters.AddWithValue("@Bestelling_id", bon.Betstelling_id);
            command.Parameters.AddWithValue("@Fooi", bon.Fooi);
            command.Parameters.AddWithValue("@Is_betaald", 1);

            //command.Prepare();
            command.ExecuteNonQuery();

            dbConnection.Close();
        }
    }
}
