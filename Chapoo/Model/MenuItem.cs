using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItem
    {
        protected int id;
        protected string naam;
        protected Catagorie catagorie;
        protected Dagdeel dagdeel;
        protected bool isAlcoholisch;
        protected double prijs;
        protected int voorraad;
        protected string omschrijving;

        public MenuItem(int id, string naam, Catagorie catagorie, Dagdeel dagdeel, bool isAlcoholisch, double prijs, int voorraad, string omschrijving)
        {
            this.id = id;
            this.naam = naam;
            this.catagorie = catagorie;
            this.dagdeel = dagdeel;
            this.prijs = prijs;
            this.voorraad = voorraad;
            this.omschrijving = omschrijving;
        }

        public int Id
        {
            get { return id; }
        }

        public string Naam
        {
            get { return naam; }
            //set { naam = value; }
        }

        public Catagorie Catagorie
        {
            get { return catagorie; }
            //set { catagorie = value; }
        }

        public Dagdeel Dagdeel
        {
            get { return dagdeel; }
            //set { dagdeel = value; }
        }

        public double Prijs
        {
            get { return prijs; }
            //set { prijs = value; }
        }

        public int Voorraad
        {
            get { return voorraad; }
            //set { voorraad = value; }
        }

        public string Omschrijving
        {
            get { return omschrijving; }
            //set { omschrijving = value; }
        }

        public override string ToString()
        {
            return Naam + ", " + Prijs + "        " + omschrijving;
        }

    }
}
