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

        public MenuItem ReadItem(SqlDataReader reader)
        {
            MenuItem m = new MenuItem();
            int id = (int)reader["MenuItem_id"];
            string naam = (string)reader["Naam"];
            //Categorie
            //Dagdeel
            //Is_alcoholisch
            float Prijs = (float)reader["Prijs"];
            int Voorraad = (int)reader["Voorraad"];
            string Omschrijving = (string)reader["Omschrijving"];
        }
    }
}
