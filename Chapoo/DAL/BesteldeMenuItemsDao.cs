﻿using System;
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
        private MenuitemDAO mDAO = new MenuitemDAO();

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
            return new BesteldeMenuItems(bestellingid, aantal, opmerking, mDAO.GetItemById(itemid), status);
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
            MenuItem_idParam.Value = bm.MenuItem.Id;
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

        public List<BesteldeMenuItems> GetBesteldeMenuItems(int bestellingId, bool drank)
        {
            string dranken = "";
            if (drank)
                dranken = "= 'dranken'";

            else
                dranken = "!= 'dranken'";

            string queryString =
            "SELECT bm.* FROM Bestelde_MenuItems AS bm " +
            "INNER JOIN MenuItem AS m ON bm.MenuItem_id = m.MenuItem_id " +
            "WHERE Bestelling_id = @id AND m.Categorie " + dranken;

            string connString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            dbConnection = new SqlConnection(connString);

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
                    int bestellingid = (int)reader["Bestelling_id"];
                    int aantal = (int)reader["Aantal"];
                    string opmerking = (string)reader["Opmerking"];
                    int itemid = (int)reader["MenuItem_id"];
                    bool status = (bool)reader["Status"];
                    DateTime tijd = (DateTime)reader["Tijd"];
                    BesteldeMenuItems b = new BesteldeMenuItems(bestellingid, aantal, opmerking, mDAO.GetItemById(itemid), status);
                    besteldeMenuItems.Add(b);
                }

                // Call Close when done reading.
                reader.Close();
                dbConnection.Close();
                return besteldeMenuItems;
            }

        }


        public void veranderVoorraad(BesteldeMenuItems bm, bool positief)
        {
            string plus = " + ";
            string min = " - ";
            string huidig;

            if (positief)
            {
                huidig = plus;
            }
            else
            {
                huidig = min;
            }

            SqlCommand cmd = new SqlCommand("UPDATE MenuItem SET Voorraad = Voorraad "+ huidig +" @aantal WHERE Menuitem_id = @menuItem_id ", dbConnection);

            SqlParameter aantalParam = new SqlParameter("@aantal", System.Data.SqlDbType.Int, 32);
            SqlParameter idParam = new SqlParameter("@menuItem_id", System.Data.SqlDbType.Int, 32);

            idParam.Value = bm.MenuItem.Id;
            aantalParam.Value = bm.Aantal;

            cmd.Parameters.Add(aantalParam);
            cmd.Parameters.Add(idParam);

            dbConnection.Open();
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            dbConnection.Close();

        }

    }
}
