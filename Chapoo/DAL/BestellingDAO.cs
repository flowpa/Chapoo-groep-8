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

        public List<Bestelling> GetOnvoltooideBestellingen(Catagorie c)
        {
            List<Bestelling> bestellingen = new List<Bestelling>();
            List<BesteldeMenuItems> besteldemenuitems = new List<BesteldeMenuItems>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Bestelde_MenuItems AS bm " +
                                            "INNER JOIN MenuItem AS m ON bm.MenuItem_id = b.MenuItem_id " + 
                                            "WHERE bm.status = 0 AND m.Categorie = @c  ORDER BY Bestelling_id ASC", dbConnection);

            dbConnection.Open();
            SqlParameter cParam = new SqlParameter("@c", System.Data.SqlDbType.NVarChar);
            cParam.Value = c.ToString();

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
                                if(b.Opmerking != "")
                                {
                                    m.Opmerking = b.Opmerking;
                                }
                                b.Aantal = m.Aantal;
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

        public void BevestigBestelling(int id, Catagorie c)
        {
            SqlCommand cmd = new SqlCommand("UPDATE bm " +
                                            "SET bm.Status = 1 " +
                                            "FROM Bestelde_MenuItems AS bm " + 
                                            "INNER JOIN MenuItem AS m ON bm.MenuItem_id = m.MenuItem_id " +
                                            "WHERE bm.Bestelling_id = @id AND m.Categorie = @c", dbConnection);

            SqlParameter idParam = new SqlParameter("@id", System.Data.SqlDbType.Int);
            SqlParameter cParam = new SqlParameter("@c", System.Data.SqlDbType.NVarChar);
            idParam.Value = id;
            cParam.Value = c.ToString();

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            dbConnection.Close();
        }
    }
}
