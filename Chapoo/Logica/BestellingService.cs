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
