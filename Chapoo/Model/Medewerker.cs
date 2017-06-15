using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Medewerker
    {
        private int id;
        private string voornaam;
        private string achternaam;
        private Functie functie;
        private string wachtwoord; 

        public Medewerker(int id, string voornaam, string achternaam, Functie functie)
        {
            this.id = id;
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.functie = functie;
        }

        public int Id
        {
            get { return id; }
        }

        public string Voornaam
        {
            get { return voornaam; }
            //set { voornaam = value; }
        }

        public string Achternaam
        {
            get { return achternaam; }
            set { achternaam = value; }
        }

        public Functie Functie
        {
            get { return functie; }
            set { functie = value; }
        }

        public string Naam
        {
            get { return voornaam + " " + achternaam; }
        }

        public string Wachtwoord
        {
           get { return wachtwoord; }
           set { wachtwoord = value; }
        }

    }
}
