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
        private int betstelling_id;
        private double fooi;
        private bool isBetaald;
        private double totaalprijs;
        private double totaalBtwHoog;
        private double totaalBtwLaag;
        private double totaalBtw;
        private double totaalPrijsInclusief;

        List<Bestelling> bestellingenOpBon = new List<Bestelling>();

        public Bon(int id, int betstelling_id, double fooi, bool isBetaald)
        {
            this.id = id;
            this.betstelling_id = betstelling_id;
            this.fooi = fooi;
            this.isBetaald = isBetaald;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Betstelling_id
        {
            get { return betstelling_id; }
            set { betstelling_id = value; }
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

        public double Totaalprijs
        {
            get { return totaalprijs; }
            set { totaalprijs = value; }
        }

        public double TotaalBtwHoog
        {
            get { return totaalBtwHoog; }
            set { totaalBtwHoog = value; }
        }

        public double TotaalBtwLaag
        {
            get { return totaalBtwLaag; }
            set { totaalBtwLaag = value; }
        }

        public double TotaalBtw
        {
            get { return totaalBtw; }
            set { totaalBtw = value; }
        }

        public double TotaalPrijsInclusief
        {
            get { return totaalPrijsInclusief; }
            set { totaalPrijsInclusief = value; }
        }
        


    }
}
