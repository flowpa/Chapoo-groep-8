using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Logica
{
    public class AfrekenenService
    {
        BestellingService bestellingService = new BestellingService();

       

        public AfrekenenService()
        {
            
        }

        public List<BesteldeMenuItems> GetBon(int tafelId)
        {
            List<BesteldeMenuItems> bon = new List<BesteldeMenuItems>();
            List<Bestelling> bestellingen = bestellingService.GetBestellingenVanTafel(tafelId);

            foreach (Bestelling bestelling in bestellingen)
            {
                bon.AddRange(bestelling.BesteldeItems);
            }

            return bon;
        }

        public Bon BerekenBedragen(List<BesteldeMenuItems> bonLijst)
        {
            double btwHoog = 0.21;
            double btwLaag = 0.06;

            Bon bon = new Bon();

            foreach (BesteldeMenuItems item in bonLijst)
            {
                double prijs = (double)item.Aantal * item.MenuItem.Prijs;
                bon.Totaalprijs += prijs;

                if (item.MenuItem.IsAlcoholisch)
                {
                    bon.TotaalBtwHoog += prijs * btwHoog;
                }
                else
                {
                    bon.TotaalBtwLaag += prijs * btwLaag;
                }
            }

            bon.TotaalPrijsInclusief = bon.Totaalprijs + bon.TotaalBtwLaag + bon.TotaalBtwHoog;
            bon.TotaalBtw = bon.TotaalBtwLaag + bon.TotaalBtwHoog;

            return bon;
        }
    }
}
