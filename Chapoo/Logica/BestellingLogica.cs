using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logica
{
    public class BestellingLogica
    {
        BestellingDAO b = new BestellingDAO();
        public Tafel HaalTafelOp()
        {
            // moet eigenlijk data ophalen van een label van juan
            Tafel t = new Tafel(10, true);

            return t;
        }

        public Medewerker HaalMedewerkerOp()
        {
            // moet eigenlijk object data ophalen van een label van juan
            Medewerker m = new Medewerker(3, "halo", "van halo", Functie.bediende);

            return m;
        }

        public void WriteBestelling(Medewerker m, Tafel t)
        {
            BestellingDAO bDAO = new BestellingDAO();

            Bestelling bestelling = new Bestelling(0, m.Id, t.Nummer, DateTime.Now);


            bDAO.WriteBesteling(bestelling);
            int bestellingId = bDAO.GetBestellingIdByTijd(bestelling.Tijd);


            // moet nog de huidige bestelling toevoegen aan een bon
        }

    }
}
