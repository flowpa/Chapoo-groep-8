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

        public MenuItem ReadMenuItem(SqlDataReader reader)
        {
            int id = reader.GetInt32(0);
            string naam = reader.GetString(1);
            bool alcohol = reader.GetBoolean(4);
            float prijs = reader.GetFloat(5);
            int voorraad = reader.GetInt32(6);
            string omschrijving = reader.GetString(7);

            MenuItem m = new MenuItem(id, naam, catagorie, dagdeel, alcohol, prijs, voorraad, omschrijving);

            return m;
        }

        public List<MenuItem> GetMenuItems(Catagorie c, Dagdeel d)
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
                
                while (reader.Read())
                {

                    MenuItem m = ReadMenuItem(reader);
                    
                    menuKaart.Add(m);
                }


                // Call Close when done reading.
                reader.Close();
                dbConnection.Close();
                return menuKaart;
            }
        }
    }
}
