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
        private int bestellingId; 
        private double fooi;
        private bool isBetaald; 
        

        List<Bestelling> bestellingenOpBon = new List<Bestelling>();

        public Bon(int id, int bestellingId, double fooi, bool isBetaald)
        {
            this.id = id;
            this.bestellingId = bestellingId;
            this.fooi = fooi;
            this.isBetaald = isBetaald;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int BestellingId
        {
            get { return bestellingId; }
            set { bestellingId = value; }
        }

        public double Fooi
        {
            get { return fooi; }
            set { fooi = value; }
        }

        public bool IsBetaald
        {
            get { return isBetaald; }
            set { isBetaald = value; }
        }

        public List<Bestelling> BestellingenOpBon
        {
            get { return bestellingenOpBon; }
            set { bestellingenOpBon = value; }
        }
    }
}
