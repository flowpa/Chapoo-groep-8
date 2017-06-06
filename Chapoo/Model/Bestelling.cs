using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bestelling
    {
        private int id;
        private int medewerkersId;
        private int tafelId;
        private DateTime tijd;

        List<MenuItem> besteldeItems = new List<MenuItem>();

        public Bestelling(int id, int medewerkersId, int tafelId, DateTime tijd)
        {
            this.id = id;
            this.medewerkersId = medewerkersId;
            this.tafelId = tafelId;
            this.tijd = tijd;
        }

        public int Id
        {
            get { return id; }
        }

        public int MedewerkersId
        {
            get { return medewerkersId; }
            set { medewerkersId = value; }
        }

        public int TafelId
        {
            get { return tafelId; }
            set { tafelId = value; }
        }

        public DateTime Tijd
        {
            get { return tijd; }
            set { tijd = value; }
        }

        public List<MenuItem> GetBestelItems()
        {
            return besteldeItems;
        }

    }
}
