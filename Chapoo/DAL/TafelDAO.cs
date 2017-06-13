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
    class TafelDAO
    {
        protected SqlConnection dbConnection;

        public TafelDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public Tafel getTafel(SqlDataReader reader)
        {
            int tafelNummer = (int)reader["Tafel_id"];
            bool isBezet = (bool)reader["Is_bezet"];

            Tafel t = new Tafel(tafelNummer, isBezet);
            return t;
        }

        public void writeTafelStatus(int tafelId, bool toggle)
        {
            string queryString =
            "UPDATE dbo.Tafel  " +
            "SET Is_bezet = @toggle " +
            "WHERE Tafel_id = @tafelId";

            dbConnection.Open();

            SqlCommand command = new SqlCommand(queryString, dbConnection);

            SqlParameter tafelIdParam = new SqlParameter("@tafelId", System.Data.SqlDbType.Int);
            SqlParameter isBezetParam = new SqlParameter("@toggle", System.Data.SqlDbType.Bit);

            //tafelIdParam = tafelId;
            

        }
    }
}
