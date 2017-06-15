using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

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

        public void WriteBesteldeMenuItem(BesteldeMenuItems bm)
        {
            string queryString =
            "INSERT INTO dbo.Bestelde_MenuItems (Bestelling_id, Aantal, Opmerking, MenuItem_id, Status, Tijd) " +
            "VALUES (@bestelling_id, @aantal, @opmerking, @menuItem_id, @status, @tijd)";



            SqlCommand command = new SqlCommand(queryString, dbConnection);
            dbConnection.Open();


            SqlParameter Bestelling_idParam = new SqlParameter("@bestelling_id", SqlDbType.Int, 32);
            SqlParameter AantalParam = new SqlParameter("@aantal", SqlDbType.Int, 32);
            SqlParameter OpmerkingParam = new SqlParameter("@opmerking", SqlDbType.NVarChar, 255);
            SqlParameter MenuItem_idParam = new SqlParameter("@menuItem_id", SqlDbType.Int, 32);
            SqlParameter StatusParam = new SqlParameter("@status", SqlDbType.Bit, 2);
            SqlParameter TijdParam = new SqlParameter("@tijd", SqlDbType.DateTime);




            Bestelling_idParam.Value = bm.BestellingId;
            AantalParam.Value = bm.Aantal;
            OpmerkingParam.Value = bm.Opmerking;
            MenuItem_idParam.Value = bm.MenuItemId;
            StatusParam.Value = 0;
            TijdParam.Value = DateTime.Now;


            command.Parameters.Add(Bestelling_idParam);
            command.Parameters.Add(AantalParam);
            command.Parameters.Add(OpmerkingParam);
            command.Parameters.Add(MenuItem_idParam);
            command.Parameters.Add(StatusParam);
            command.Parameters.Add(TijdParam);


            command.Prepare();

            command.ExecuteNonQuery();


            // Call Close when done reading.

            dbConnection.Close();


        }

        public List<BesteldeMenuItems> GetBesteldeMenuItems(int bestellingId)
        {
            string queryString =
            "SELECT * FROM dbo.Bestelde_MenuItems WHERE Bestelling_id = @id;";


            using (dbConnection)
            {
                SqlCommand command = new SqlCommand(queryString, dbConnection);
                dbConnection.Open();

                SqlParameter BestellingIdParam = new SqlParameter("@id", System.Data.SqlDbType.Int, 32);
                BestellingIdParam.Value = bestellingId;
                command.Parameters.Add(BestellingIdParam);

                command.Prepare();
                SqlDataReader reader = command.ExecuteReader();

                List<BesteldeMenuItems> besteldeMenuItems = new List<BesteldeMenuItems>();

                while (reader.Read())
                {
                    BesteldeMenuItems b = ReadBesteldeMenuItem(reader);
                    besteldeMenuItems.Add(b);
                }

                // Call Close when done reading.
                reader.Close();
                dbConnection.Close();
                return besteldeMenuItems;
            }

        }


    }
}
