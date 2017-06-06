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
        private float fooi;

        List<Bestelling> bestellingenOpBon = new List<Bestelling>();

        public Bon(int id)
        {
            this.id = id;
        }

        public int Id
        {
            get { return id; }
        }

        public float Fooi
        {
            get
            {
                return fooi;
            }
            set
            {
                foreach(Bestelling b in bestellingenOpBon)
                {
                    fooi += b.GetBestelItems
                }
            }
        }

       

    }
}
