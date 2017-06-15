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

        public void MaakBesteldeMenuItemsLijst(List<MenuItem> menuItems)
        {
            
            List<BesteldeMenuItems> besteldeMenuItems = new List<BesteldeMenuItems>();

            foreach(MenuItem m in menuItems)
            {

                // moet nog bestelling id ophalen van ergens                

                BesteldeMenuItems b = new BesteldeMenuItems(1, 0, m.Opmerking,m.Id, false);

                besteldeMenuItems.Add(b);
 
            }
            BesteldeMenuItemsDao bmDAO = new BesteldeMenuItemsDao();
            besteldeMenuItems = berekenAantalBesteldeMenuItems(besteldeMenuItems);

            foreach (BesteldeMenuItems m in besteldeMenuItems)
            {

                bmDAO.WriteBesteldeMenuItem(m);

            }

            
        }

        public List<BesteldeMenuItems> berekenAantalBesteldeMenuItems(List<BesteldeMenuItems> l)
        {
            List<BesteldeMenuItems> geteldeLijst = new List<BesteldeMenuItems>();
            

            foreach (BesteldeMenuItems m in l)
            {              
                foreach (BesteldeMenuItems mi in l)
                {
                    if(m.MenuItemId == mi.MenuItemId && m.Opmerking == mi.Opmerking)
                    {
                        m.Aantal++;
                       
                    }
                } 
            }
            geteldeLijst = l.Distinct().ToList();

            
            //foreach (BesteldeMenuItems menuItem in l)
            //{
            //    geteldeLijst.Add(menuItem);   
            //}

            return geteldeLijst;
        }
    }
}
