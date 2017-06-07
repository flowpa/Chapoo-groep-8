using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
 
namespace Logica
{
    public class Inloggen
    {
        public void checkMedewerker(int werknemer_id)
        {
            MedewerkerDAO mDAO = new MedewerkerDAO();
            
            try
            {
                Medewerker m = mDAO.GetWerknemerById(werknemer_id);

                
/*    
                switch (Functie)
                {
                    case Functie.eigenaar:
                        break;
                    case Functie.kok:
                        break;
                    case Functie.barman:
                        break;
                    case Functie.bediende:
                       
                        break;
                    default:
                        break;
                }
                */
            }
            catch
            {
                //Error
            }

        }
    }
}
