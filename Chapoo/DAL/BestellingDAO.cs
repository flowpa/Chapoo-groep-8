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

        public List<Bestelling> GetOnvoltooideDrankBestellingen()
        {
            List<Bestelling> bestellingen = new List<Bestelling>();
            List<BesteldeMenuItems> besteldemenuitems = new List<BesteldeMenuItems>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Bestelde_MenuItems AS bm " +
                                            "INNER JOIN MenuItem AS m ON bm.MenuItem_id = b.MenuItem_id " + 
                                            "WHERE bm.status = 0 AND m.Categorie = dranken  ORDER BY Bestelling_id ASC", dbConnection);

            dbConnection.Open();
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
                                besteldeItems.Add(m);
                            }

                            else
                                break;
                        }
                    }
                    else
                        break;
                }
                Bestelling bestelling = ReadBestelling(reader, besteldeItems);
                bestellingen.Add(bestelling);
            }

            return bestellingen;
        }

        public List<Bestelling> GetOnvoltooideEtenkBestellingen()
        {
            List<Bestelling> bestellingen = new List<Bestelling>();
            List<BesteldeMenuItems> besteldemenuitems = new List<BesteldeMenuItems>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Bestelde_MenuItems AS bm " +
                                            "INNER JOIN MenuItem AS m ON bm.MenuItem_id = b.MenuItem_id " +
                                            "WHERE bm.status = 0 AND m.Categorie != dranken  ORDER BY Bestelling_id ASC", dbConnection);

            dbConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
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

            while (reader.Read())
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
                                besteldeItems.Add(m);
                            }

                            else
                                break;
                        }
                    }
                    else
                        break;
                }
                Bestelling bestelling = ReadBestelling(reader, besteldeItems);
                bestellingen.Add(bestelling);
            }

            return bestellingen;
        }

        public void BevestigDrankBestelling(int id)
        {
            SqlCommand cmd = new SqlCommand("UPDATE bm " +
                                            "SET bm.Status = 1 " +
                                            "FROM Bestelde_MenuItems AS bm" + 
                                            "INNER JOIN MenuItem AS m ON bm.MenuItem_id = m.MenuItem_id " +
                                            "WHERE bm.Bestelling_id = @id AND m.Categorie = dranken ", dbConnection);

            SqlParameter idParam = new SqlParameter("@id", System.Data.SqlDbType.Int);
            idParam.Value = id;
            cmd.ExecuteNonQuery();
        }

        public void BevestigEtenBestelling(int id)
        {
            SqlCommand cmd = new SqlCommand("UPDATE bm " +
                                            "SET bm.Status = 1 " +
                                            "FROM Bestelde_MenuItems AS bm" +
                                            "INNER JOIN MenuItem AS m ON bm.MenuItem_id = m.MenuItem_id " +
                                            "WHERE bm.Bestelling_id = @id AND m.Categorie != dranken ", dbConnection);

            SqlParameter idParam = new SqlParameter("@id", System.Data.SqlDbType.Int);
            idParam.Value = id;
            cmd.ExecuteNonQuery();
        }
    }
}
