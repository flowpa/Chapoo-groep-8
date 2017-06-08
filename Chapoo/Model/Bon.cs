using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bon
    {
        private int id;
        private double fooi;

        List<Bestelling> bestellingenOpBon = new List<Bestelling>();

        public Bon(int id)
        {
            this.id = id;
        }

        public int Id
        {
            get { return id; }
        }

        public List<Bestelling> BestellingenOpBon
        {
            get { return bestellingenOpBon; }
            set { bestellingenOpBon = value; }
        }

        //public double Fooi
        //{
        //    get { return fooi; }
        //    set { fooi = value; }
        //}

       

    }
}
