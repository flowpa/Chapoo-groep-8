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

        public List<Bestelling> VulEtenBestellingen()
        {
            List<Bestelling> b = bd.GetOnvoltooideEtenBestellingen();

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
