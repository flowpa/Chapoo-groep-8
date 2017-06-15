using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logica
{
    public class BestellingService
    {
        private BestellingDAO bd = new BestellingDAO();
        private MenuitemDAO md = new MenuitemDAO();

        public List<Bestelling> VulDrankBestellingen()
        {
            List<Bestelling> b = new List<Bestelling>();
            List<MenuItem> m = md.GetAll();
            Bestelling i = new Bestelling(1, 1, 1, DateTime.Now, m);
            b.Add(i);
            //List<Bestelling> b = bd.GetOnvoltooideDrankBestellingen();

            return b;
        }

        public List<Bestelling> VulBestellingen(bool drank)
        {
            List<Bestelling> b = bd.GetOnvoltooideBestellingen(drank);

            return b;
        }

        public void BevestigBestelling(int id, bool drank)
        {
            bd.BevestigBestelling(id, drank);
        }

        public List<Bestelling> GetBestellingenVanTafel(int tafelId)
        {
            List<Bestelling> bestellingen = bd.GetBestellingenVanTafel(tafelId);

            return bestellingen;
        }
    }
}
