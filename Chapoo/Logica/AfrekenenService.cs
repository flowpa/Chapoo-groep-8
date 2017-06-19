using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logica
{
    public class AfrekenenService
    {
        BestellingService bestellingService;
        BonDAO bonDAO;
        Bon bon;

        public AfrekenenService()
        {
            bestellingService = new BestellingService();
            bonDAO = new BonDAO();
        }

        public List<BesteldeMenuItems> GetBon(int tafelId)
        {
            List<BesteldeMenuItems> bonLijst = new List<BesteldeMenuItems>();
            List<Bestelling> bestellingen = bestellingService.GetBestellingenVanTafel(tafelId);

            if (bestellingen.Count == 0)
            {
                return bonLijst;
            }

            // onthoud bestlling id
            //bon = new Bon();
            bon.BestellingenOpBon = bestellingen;
            bon.Betstelling_id = bestellingen[0].Id;

            foreach (Bestelling bestelling in bestellingen)
            {
                bonLijst.AddRange(bestelling.BesteldeItems);
            }

            return bonLijst;
        }

        public Bon BerekenBedragen(List<BesteldeMenuItems> bonLijst)
        {
            if (bonLijst.Count == 0)
            {
                //return new Bon();
            }

            double btwHoog = 0.21;
            double btwLaag = 0.06;

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

        public void SafeBonNaarDb()
        {
            bonDAO.SafeBon(bon);
        }

        //Juan

        public Bon getBonByBestellingId(int bestellingId)
        {
            bonDAO = new BonDAO();
            Bon bon = bonDAO.getBonByBestellingId(bestellingId);
            return bon;
        }

        public void newBonByBestellingId(int bestellingId)
        {
            bonDAO = new BonDAO();
            bonDAO.newBonByBestellingId(bestellingId);
        }
    }

   
}
