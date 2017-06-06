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
    class MenuitemDAO
    {
        protected SqlConnection dbConnection;

        public MenuitemDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
            dbConnection = new SqlConnection(connString);
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
