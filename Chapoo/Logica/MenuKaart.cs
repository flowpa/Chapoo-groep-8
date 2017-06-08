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
        public List<MenuItem> VulMenuKaart(Catagorie c, Dagdeel d)
        {
            MenuitemDAO md = new MenuitemDAO();

            if (DateTime.Now.Hour <= 16)
            {
                d = Dagdeel.lunch;
            }
            else
            {
                d = Dagdeel.diner;
            }

            
            List<MenuItem> menuKaart = md.GetMenuItems(c,d);

            return menuKaart;
        }
        public List<MenuItem> VulDrankenKaart(Catagorie c, Dagdeel d)
        {
            MenuitemDAO md = new MenuitemDAO();
            List<MenuItem> menuKaart = md.GetMenuItems(c, d);

            return menuKaart;
        }
    }
}
