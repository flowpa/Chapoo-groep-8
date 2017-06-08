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
    public class BesteldeMenuItemsDAO
    {
        protected SqlConnection dbConnection;

        public BesteldeMenuItemsDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public BesteldeMenuItems ReadBesteldeMenuItem(SqlDataReader reader)
        {
            int bestellingid = (int)reader["Bestelling_id"];
            int aantal = (int)reader["Aantal"];
            string opmerking = (string)reader["Opmerking"];
            int itemid = (int)reader["MenuItem_id"];
            bool status = (bool)reader["Status"];
            return new BesteldeMenuItems(bestellingid, aantal, opmerking, itemid, status);
        }

        public void WriteBesteldeMenuItems(List<BesteldeMenuItems> besteldeMenuItems)
        {
            string queryString =
            "INSERT INTO dbo.Bestelde_MenuItems (Bestelling_id, Aantal, Opmerking, MenuItem_id, Status) " +
            "VALUES (@id, @aantal, @opmerking, @menuItem_id, @status)";

            using (dbConnection)
            {
                SqlCommand command = new SqlCommand(queryString, dbConnection);
                dbConnection.Open();


                foreach (BesteldeMenuItems bm in besteldeMenuItems)
                {

                    SqlParameter IdParam = new SqlParameter("@id", System.Data.SqlDbType.Int);
                    SqlParameter AantalParam = new SqlParameter("@aantal", System.Data.SqlDbType.Int);
                    SqlParameter OpmerkingParam = new SqlParameter("@opmerking", System.Data.SqlDbType.NVarChar);
                    SqlParameter MenuItem_idParam = new SqlParameter("@menuItem_id", System.Data.SqlDbType.Int);
                    SqlParameter StatusParam = new SqlParameter("@status", System.Data.SqlDbType.Bit);


                    IdParam.Value = bm.BestellingId;
                    AantalParam.Value = bm.Aantal;
                    OpmerkingParam.Value = bm.Opmerking;
                    MenuItem_idParam.Value = bm.MenuItemId;
                    StatusParam.Value = bm.Geserveerd;

                    command.Parameters.Add(IdParam);
                    command.Parameters.Add(AantalParam);
                    command.Parameters.Add(OpmerkingParam);
                    command.Parameters.Add(MenuItem_idParam);
                    command.Parameters.Add(StatusParam);


                    command.Prepare();

                    command.ExecuteNonQuery();
                }

                // Call Close when done reading.
                
                dbConnection.Close();
               
            }
        }


    }
}
