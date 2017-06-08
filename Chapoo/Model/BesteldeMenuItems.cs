using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BesteldeMenuItems
    {
        private int bestellingId;
        private int aantal;
        private string opmerking;
        private int menuItemId;
        private bool geserveerd;

        public BesteldeMenuItems(int bestellingId, int aantal, string opmerking, int menuItemId, bool geserveerd)
        {
            this.bestellingId = bestellingId;
            this.aantal = aantal;
            this.opmerking = opmerking;
            this.menuItemId = menuItemId;
            this.geserveerd = geserveerd;
        }

        public int BestellingId
        {
            get { return bestellingId; }
        }
        
        public int Aantal
        {
            get { return aantal; }
            set { aantal = value; }
        }

        public string Opmerking
        {
            get { return opmerking; }
            set { opmerking = value; }
        }

        public int MenuItemId
        {
            get { return menuItemId; }
        }


    }
}
