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

            return new Bestelling(bestellingid, medewerkerid, tafelid, tijd, besteldeItems);
        }

        public List<Bestelling> GetOnvoltooideBestellingen(bool drank)
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
                                            "WHERE bm.status = 0 AND m.Categorie "+ dranken + " ORDER BY Bestelling_id ASC", dbConnection);

            dbConnection.Open();
            cmd.Prepare();
             SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                BesteldeMenuItems bestelde = BesteldeMenuItemsDAO.ReadBesteldeMenuItem(reader);
                besteldemenuitems.Add(bestelde);
            }

            reader.Close();
            dbConnection.Close();

            List<MenuItem> AllMenuItems = MenuitemDAO.GetAll();

            cmd = new SqlCommand("SELECT DISTINCT b.* FROM Bestelling AS b " +
                                 "INNER JOIN Bestelde_MenuItems AS bm ON b.Bestelling_id=bm.Bestelling_id " + 
                                 "WHERE bm.Status=0", dbConnection);
            dbConnection.Open();
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
                            if (b.MenuItemId == m.Id)
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
            SqlCommand cmd = new SqlCommand("UPDATE bm " +
                                            "SET bm.Status = 1 " +
                                            "FROM Bestelde_MenuItems AS bm " + 
                                            "INNER JOIN MenuItem AS m ON bm.MenuItem_id = m.MenuItem_id " +
                                            "WHERE bm.Bestelling_id = @id AND m.Categorie @drank", dbConnection);

            SqlParameter idParam = new SqlParameter("@id", System.Data.SqlDbType.Int, 32);
            idParam.Value = id;
            string dranken = "";
            if (drank)
                dranken = "= 'dranken'";

            else
                dranken = "!= 'dranken'";

            SqlParameter drankParam = new SqlParameter("@drank", System.Data.SqlDbType.NVarChar, 50);
            drankParam.Value = dranken;

            cmd.Parameters.Add(idParam);
            cmd.Parameters.Add(drankParam);
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
                    MenuItem item = allMenuItems.Where(mi => mi.Id == bItem.MenuItemId).FirstOrDefault();

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
    }
}
