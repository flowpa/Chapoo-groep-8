using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logica
{
    public class TafeloverzichtService
    {
        private Tafel t;

        TafelDAO tDAO = new TafelDAO();

        public Tafel getTafel(int tafelId)
        {
            t = tDAO.readTafel(tafelId);
            return t;
        }

        public bool checkTafelStatus(int tafelId)
        {
            t = tDAO.readTafel(tafelId);
            return t.IsBezet;

        }

        public void writeTafelStatus(int tafelId, bool isBezet)
        {
            tDAO.writeTafelStatus(tafelId, isBezet);
        }
    }
}
