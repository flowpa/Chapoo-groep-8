using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;


namespace Logica
{
    public class MenuKaart
    {
        private MenuitemDAO md;
        public List<MenuItem> VulMenuKaart(Catagorie c)
        {
            Dagdeel d = new Dagdeel();

            if(c == Catagorie.dranken)
            {
                d = Dagdeel.altijd;
            }

            md= new MenuitemDAO();

            if (d != Dagdeel.altijd)
            {
                if (DateTime.Now.Hour <= 16)
                {
                    d = Dagdeel.lunch;
                }
                else
                {
                    d = Dagdeel.diner;
                }
            }

            List<MenuItem> menuKaart = md.GetMenuItems(c,d);

            return menuKaart;
        }

        public List<MenuItem> VulDrankenKaart(Catagorie c, Dagdeel d)
        {
            md = new MenuitemDAO();
            List<MenuItem> menuKaart = md.GetMenuItems(c, d);

            return menuKaart;
        }

        public int aantal(int id)
        {
            md = new MenuitemDAO();

            MenuItem m = md.GetItemById(id);
            return m.Voorraad;
        }

        public List<BesteldeMenuItems> getBesteldeMenuItemsByBestellingId(int bestellingId, bool drank)
        {
            BesteldeMenuItemsDAO bmi = new BesteldeMenuItemsDAO();

            List<BesteldeMenuItems> besteldeItems = bmi.GetBesteldeMenuItems(bestellingId, drank);
            return besteldeItems;
        }       
        
        
    
    }
}
