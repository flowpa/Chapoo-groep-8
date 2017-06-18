﻿using System;
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
        private BesteldeMenuItemsDAO BesteldeMenuItemsDAO = new BesteldeMenuItemsDAO();
        private MenuitemDAO MenuitemDAO = new MenuitemDAO();

        public BestellingDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public Bestelling ReadBestelling(SqlDataReader reader, List<MenuItem> besteldeItems)
        {
            int bestellingid = (int)reader["Bestelling_id"];
            int medewerkerid = (int)reader["Werknemer_id"];
            int tafelid = (int)reader["Tafel_id"];
            DateTime tijd = (DateTime)reader["Tijd"];

            Bestelling b = new Bestelling(bestellingid, medewerkerid, tafelid, tijd);
            b.BesteldeItems = besteldeItems;
            return b;
        }

        public List<Bestelling> GetBestellingen(bool drank, bool status)
        {
            List<Bestelling> bestellingen = new List<Bestelling>();
            List<BesteldeMenuItems> besteldemenuitems = new List<BesteldeMenuItems>();

            string dranken = "";
            if (drank)
                dranken = "= 'dranken'";

            else
                dranken = "!= 'dranken'";

            SqlCommand cmd = new SqlCommand("SELECT * FROM Bestelde_MenuItems AS bm " +
                                            "INNER JOIN MenuItem AS m ON bm.MenuItem_id = m.MenuItem_id " + 
                                            "WHERE bm.status = @status AND m.Categorie "+ dranken + " ORDER BY Bestelling_id ASC", dbConnection);
            SqlParameter statusParam = new SqlParameter("@status", System.Data.SqlDbType.Bit);
            statusParam.Value = status;

            dbConnection.Open();
            cmd.Parameters.Add(statusParam);
            cmd.Prepare();
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                BesteldeMenuItems bestelde = BesteldeMenuItemsDAO.ReadBesteldeMenuItem(reader);
                besteldemenuitems.Add(bestelde);
            }

            reader.Close();

            List<MenuItem> AllMenuItems = MenuitemDAO.GetAll();

            cmd = new SqlCommand("SELECT DISTINCT b.* FROM Bestelling AS b " +
                                 "INNER JOIN Bestelde_MenuItems AS bm ON b.Bestelling_id=bm.Bestelling_id " +
                                 "INNER JOIN MenuItem AS m ON bm.MenuItem_id = m.MenuItem_id " +
                                 "WHERE bm.Status= @status AND m.Categorie " + dranken, dbConnection);
            statusParam = new SqlParameter("@status", System.Data.SqlDbType.Bit);
            statusParam.Value = status;
            cmd.Parameters.Add(statusParam);
            reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                int bestellingid = (int)reader["Bestelling_id"];
                List<MenuItem> besteldeItems = new List<MenuItem>();

                foreach (BesteldeMenuItems b in besteldemenuitems)
                {
                    if (b.BestellingId == bestellingid)
                    {
                        foreach (MenuItem m in AllMenuItems)
                        {
                            if (b.MenuItem.Id == m.Id)
                            {
                                m.Aantal = b.Aantal;
                                if (b.Opmerking != "")
                                {
                                    m.Opmerking = b.Opmerking;
                                }
                                
                                besteldeItems.Add(m);
                            }
                        }
                    }
                    else
                        break;
                }
                Bestelling bestelling = ReadBestelling(reader, besteldeItems);
                bestellingen.Add(bestelling);
            }
            reader.Close();
            dbConnection.Close();
            return bestellingen;
        }

        public void BevestigBestelling(int id, bool drank)
        {
            string dranken = "";
            if (drank)
                dranken = "= 'dranken'";

            else
                dranken = "!= 'dranken'";

            SqlCommand cmd = new SqlCommand("UPDATE bm " +
                                            "SET bm.Status = 1 " +
                                            "FROM Bestelde_MenuItems AS bm " + 
                                            "INNER JOIN MenuItem AS m ON bm.MenuItem_id = m.MenuItem_id " +
                                            "WHERE bm.Bestelling_id = @id AND m.Categorie " + dranken, dbConnection);

            SqlParameter idParam = new SqlParameter("@id", System.Data.SqlDbType.Int, 32);
            idParam.Value = id;
            cmd.Parameters.Add(idParam);

            dbConnection.Open();
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            dbConnection.Close();   
        }

        public List<Bestelling> GetBestellingenVanTafel(int tafelId)
        {
            List<Bestelling> bestellingen = new List<Bestelling>();
            List<BesteldeMenuItems> besteldemenuitems = new List<BesteldeMenuItems>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Bestelde_MenuItems AS bm " +
                                            "INNER JOIN Bestelling AS b ON b.Bestelling_id = bm.Bestelling_id " +
                                            "WHERE bm.status = 1 AND b.Tafel_id = @tafel_id", dbConnection);

            cmd.Parameters.AddWithValue("@tafel_id", tafelId);

            dbConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                BesteldeMenuItems bestelde = BesteldeMenuItemsDAO.ReadBesteldeMenuItem(reader);
                besteldemenuitems.Add(bestelde);
            }

            reader.Close();

            List<MenuItem> allMenuItems = MenuitemDAO.GetAll();

            cmd = new SqlCommand("SELECT * FROM Bestelling " +
                                 "WHERE Tafel_id = @tafel_id", dbConnection);

            cmd.Parameters.AddWithValue("@tafel_id", tafelId);

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int bestellingId = (int)reader["Bestelling_id"];
                List<BesteldeMenuItems> bMenuItems = besteldemenuitems.Where(bm => bm.BestellingId == bestellingId).ToList();
                List<MenuItem> besteldeItems = new List<MenuItem>();

                foreach (BesteldeMenuItems bItem in bMenuItems)
                {
                    MenuItem item = allMenuItems.Where(mi => mi.Id == bItem.MenuItem.Id).FirstOrDefault();

                    for (int i = 0; i <= bItem.Aantal; i++)
                    {
                        besteldeItems.Add(item);
                    }
                }

                Bestelling bestelling = ReadBestelling(reader, besteldeItems);
                bestellingen.Add(bestelling);
            }
            dbConnection.Close();

            return bestellingen;
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
                Bestelling b = null;
                if (reader.Read())
                {
                    int medewerkersId = (int)reader["Werknemer_id"];
                    int TafelId = (int)reader["Tafel_id"];
                    DateTime tijd = (DateTime)reader["Tijd"];
                    b = new Bestelling(id, medewerkersId, TafelId, tijd);
                }

                // Call Close when done reading.
                reader.Close();
                dbConnection.Close();
                return b;
            }

        }

        public List<Bestelling> GetBestellingen()
        {
            string queryString =
            "SELECT * FROM dbo.Bestelling;";

            using (dbConnection)
            {
                SqlCommand command = new SqlCommand(queryString, dbConnection);
                dbConnection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.

                List<Bestelling> bestellingen = new List<Bestelling>();

                while (reader.Read())
                {
                    int id = (int)reader["Bestelling_id"];
                    int medewerkersId = (int)reader["Werknemer_id"];
                    int TafelId = (int)reader["Tafel_id"];
                    DateTime tijd = (DateTime)reader["Tijd"];
                    Bestelling b = new Bestelling(id, medewerkersId, TafelId, tijd);
                    bestellingen.Add(b);
                }


                // Call Close when done reading.
                reader.Close();
                dbConnection.Close();
                return bestellingen;
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


                SqlParameter werknemerId = new SqlParameter("@werknemer_id", System.Data.SqlDbType.Int, 32);
                SqlParameter tafelId = new SqlParameter("@tafel_id", System.Data.SqlDbType.Int, 32);
                SqlParameter Tijd = new SqlParameter("@tijd", System.Data.SqlDbType.DateTime);



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
