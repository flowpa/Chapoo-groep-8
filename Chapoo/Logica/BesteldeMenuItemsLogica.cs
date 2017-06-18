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
        BesteldeMenuItemsDAO bmDAO = new BesteldeMenuItemsDAO();

        public void verzendBesteldeItems(List<BesteldeMenuItems> menuItems, bool positief)
        {
 
            foreach (BesteldeMenuItems m in menuItems)
            {

                bmDAO.WriteBesteldeMenuItem(m);
                VeranderVooraad(m, positief);

            }
            
        }

        public void VeranderVooraad(BesteldeMenuItems b, bool positief)
        {
            bmDAO.veranderVoorraad(b, positief);
        }
    }
}
