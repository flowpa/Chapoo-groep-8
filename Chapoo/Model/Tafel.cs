using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Tafel
    {
        private int nummer;
        private bool isBezet;

        public Tafel(int nummer, bool isBezet)
        {
            this.nummer = nummer;
            this.isBezet = isBezet;
        }

        public int Nummer
        {
            get { return nummer; }
        }

        public bool IsBezet
        {
            get { return isBezet; }
            set { isBezet = value; }
        }
    }
}
