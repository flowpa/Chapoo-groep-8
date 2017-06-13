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
        private BestellingDAO bd = new BestellingDAO();

        public List<Bestelling> VulBestellingen(Catagorie c)
        {
            List<Bestelling> b = bd.GetOnvoltooideBestellingen(c);

            return b;
        }

        public void BevestigBestelling(int id, Catagorie c)
        {
            bd.BevestigBestelling(id, c);
        }
    }
}
