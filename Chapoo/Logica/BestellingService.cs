using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logica
{
    class BestellingService
    {
        private BestellingDAO bd;

        public List<Bestelling> VulDrankBestellingen()
        {
            List<Bestelling> b = bd.GetOnvoltooideDrankBestellingen();

            return b;
        }

        public List<Bestelling> VulEtenBestellingen()
        {
            List<Bestelling> b = bd.GetOnvoltooideEtenkBestellingen();

            return b;
        }

        public void BevestigDrankBestelling(int id)
        {
            bd.BevestigDrankBestelling(id);
        }

        public void BevestigEtenBestelling(int id)
        {
            bd.BevestigEtenBestelling(id);
        }
    }
}
