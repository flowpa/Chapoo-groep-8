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

        public Bestelling ReadBestelling(SqlDataReader reader)
        {
            Bestelling b = new Bestelling();
            int id = (int)reader["Bestelling_id"];
            int medewerkersId = (int)reader["Bestelling_id"];
            int Tafeld = (int)reader["Bestelling_id"];

        }
    }
}
