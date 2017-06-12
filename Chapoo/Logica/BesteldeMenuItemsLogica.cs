using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logica
{
    public class BesteldeMenuItemsLogica
    {
        public List<BesteldeMenuItems> InsertBesteldeMenuItems(int BestellingsId, int aantal, string opmerking, int menuItemId, bool status)
        {
            //bestellingsId kan gehaald worden van 


            BesteldeMenuItemsDao bd = new BesteldeMenuItemsDao();
            


            List<BesteldeMenuItems> besteldeMenuItemsList = new List<BesteldeMenuItems>();

            bd.WriteBesteldeMenuItems(besteldeMenuItemsList);

            return besteldeMenuItemsList;
        }

       // public List<BesteldeMenuItems> VulBesteldeItemsList
    }
}
