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
        //private int menuItemId; // aanpassen naar Menu object (niet int)
        private MenuItem menuItem;
        private bool geserveerd;

        public BesteldeMenuItems(int bestellingId, int aantal, string opmerking, MenuItem menuItem, bool geserveerd)
        {
            this.bestellingId = bestellingId;
            this.aantal = aantal;
            this.opmerking = opmerking;
            this.menuItem = menuItem;
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

        public MenuItem MenuItem
        {
            get { return menuItem; }
            set { menuItem = value; }
        }

        public bool Geserveerd
        {
            get { return geserveerd; }
            set { geserveerd = value; }
        }      
    }
}
