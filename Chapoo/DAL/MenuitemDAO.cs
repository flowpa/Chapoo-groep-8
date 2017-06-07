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
    public class MenuitemDAO
    {
        protected SqlConnection dbConnection;

        public MenuitemDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public List<MenuItem> ReadMenuItems(Catagorie c, Dagdeel d)
        {
            string queryString =
            "SELECT * FROM dbo.MenuItem WHERE Categorie = @catagorie AND Dagdeel = @dagdeel";

            using (dbConnection)
            {
                SqlCommand command = new SqlCommand(queryString, dbConnection);
                dbConnection.Open();

                SqlParameter CatagorieParam = new SqlParameter("@catagorie", System.Data.SqlDbType.NVarChar);
                SqlParameter DagdeelParam = new SqlParameter("@dagdeel", System.Data.SqlDbType.NVarChar);

                CatagorieParam.Value = c.ToString();
                DagdeelParam.Value = d.ToString();


                command.Parameters.Add(CatagorieParam);
                command.Parameters.Add(DagdeelParam);

                command.Prepare();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.

                List<MenuItem> menuKaart = new List<MenuItem>();
                MenuItem m;
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string naam = reader.GetString(1);
                    bool alcohol = reader.GetBoolean(4);
                    float prijs = reader.GetFloat(5);
                    int voorraad = reader.GetInt32(6);
                    string omschrijving = reader.GetString(7);

                    m = new MenuItem(id, naam, c, d, alcohol, prijs,voorraad, omschrijving);
                    menuKaart.Add(m);
                }


                // Call Close when done reading.
                reader.Close();
                dbConnection.Close();
                return menuKaart;
            }
        }


        public MenuItem ReadMenuItem(SqlDataReader reader)
        {
            int id = (int)reader["MenuItem_id"];
            string naam = (string)reader["Naam"];
            Catagorie categorie = (Catagorie)Enum.Parse(typeof(Catagorie), (string)reader["Categorie"]);
            Dagdeel dagdeel = (Dagdeel)Enum.Parse(typeof(Dagdeel), (string)reader["Dagdeel"]);
            bool isAlcoholisch = (bool)reader["Is_alcoholisch"];
            float prijs = (float)reader["Prijs"];
            int voorraad = (int)reader["Voorraad"];
            string omschrijving = (string)reader["Omschrijving"];

            return new MenuItem(id, naam, categorie, dagdeel, isAlcoholisch, prijs, voorraad, omschrijving);
        }
    }
}
