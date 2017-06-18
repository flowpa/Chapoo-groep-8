using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL; 

namespace Logica
{
    public class AfrekenenLogica
    {
        private BonDAO bDAO; 
        BestellingService bestellingService = new BestellingService();

        public AfrekenenLogica()
        {
            
        }

        public List<MenuItem> GetBon(int tafelId)
        {
            List<MenuItem> bon = new List<MenuItem>();
            List<Bestelling> bestellingen = bestellingService.GetBestellingenVanTafel(tafelId);

            foreach (Bestelling bestelling in bestellingen)
            {
                bon.AddRange(bestelling.BesteldeItems);
            }

            return bon;
        }

        public Bon GetBonByBestellingId(int bestellingId)
        {
            bDAO = new BonDAO();
            Bon bon = bDAO.getBonByBestellingId(bestellingId);

            return bon; 
        }
    }
}
