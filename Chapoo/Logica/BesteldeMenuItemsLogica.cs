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
        public void verzendBesteldeItems(List<BesteldeMenuItems> menuItems)
        {
 
            BesteldeMenuItemsDAO bmDAO = new BesteldeMenuItemsDAO();
           

            foreach (BesteldeMenuItems m in menuItems)
            {

                bmDAO.WriteBesteldeMenuItem(m);

            }

            
        }
    }
}
