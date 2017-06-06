using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    class Medewerker
    {
        private int id;
        private string voornaam;
        private string achternaam;
        private Functie functie;

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
    }
}
