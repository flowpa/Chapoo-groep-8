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
        MedewerkerDAO mDAO = new MedewerkerDAO();

        public bool checkMedewerker(int werknemer_id)
        {

            try
            {
                Medewerker m = mDAO.GetWerknemerById(werknemer_id);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
