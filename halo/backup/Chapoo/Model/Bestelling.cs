﻿using System;
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
        private List<MenuItem> besteldeItems;

        public Bestelling(int id, int medewerkersId, int tafelId, DateTime tijd, List<MenuItem> besteldeItems)
        {
            this.id = id;
            this.medewerkersId = medewerkersId;
            this.tafelId = tafelId;
            this.tijd = tijd;
            this.besteldeItems = besteldeItems;
        }

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

        public List<MenuItem> BesteldeItems
        {
            get { return besteldeItems; }
            set { besteldeItems = value; }
        }

        public override string ToString()
        {
            string s = @tafelId.ToString() + "\n";

            foreach (MenuItem m in besteldeItems)
            {
                s += m.Aantal + "    " + m.Naam + "\n";
                if (m.Opmerking != "")
                {
                    s += "!!!" + m.Opmerking + "!!!" + "\n";
                } 
            }

            return s;
        }
        
        public List<string> ToStringList()
        {
            List<string> ls = new List<string>();

            ls.Add(@tafelId.ToString());

            foreach (MenuItem m in besteldeItems)
            {
                ls.Add(m.Aantal + "    " + m.Naam);

                if(m.Opmerking != "")
                    ls.Add("!!!" + m.Opmerking + "!!!");
            }

            return ls;
        }
    }
}
