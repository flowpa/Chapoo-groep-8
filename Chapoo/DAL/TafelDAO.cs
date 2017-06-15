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
    public class TafelDAO
    {
        protected SqlConnection dbConnection;

        public TafelDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }
        
        public Tafel readTafel(int tafelid)
        {
            string queryString = "SELECT * FROM Tafel WHERE Tafel_id = @tafelId";

            dbConnection.Open();

            SqlCommand command = new SqlCommand(queryString, dbConnection);

            SqlParameter tafel_idParam = new SqlParameter("@tafelId", System.Data.SqlDbType.Int);

            tafel_idParam.Value = tafelid;

            command.Parameters.Add(tafel_idParam);
            command.Prepare();

            SqlDataReader reader = command.ExecuteReader();

            Tafel t = null;

            if(reader.Read())
            {
                int tafelNummer = (int)reader["Tafel_id"];
                bool isBezet = (bool)reader["Is_bezet"];
                 t = new Tafel(tafelNummer, isBezet);
            }

            reader.Close();
            dbConnection.Close();

            return t;
        }

        public void writeTafelStatus(int tafelId, bool isBezet)
        {
            string queryString =
            "UPDATE dbo.Tafel " +
            "SET Is_bezet = @isBezet " +
            "WHERE Tafel_id = @tafelId ";

            dbConnection.Open();

            SqlCommand command = new SqlCommand(queryString, dbConnection);

            SqlParameter tafelIdParam = new SqlParameter("@tafelId", System.Data.SqlDbType.Int);
            SqlParameter isBezetParam = new SqlParameter("@isBezet", System.Data.SqlDbType.Bit);

            tafelIdParam.Value = tafelId;
            isBezetParam.Value = isBezet;

            command.Prepare();
            command.ExecuteNonQuery();
            dbConnection.Close(); 
        }
    }
}
