<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Inlogscherm s = new Inlogscherm();
            TafeloverzichtScherm t = new TafeloverzichtScherm();
            Application.Run(s);                // niet verwijderen. gwn veranderen.
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BestellingOpneemScherm b = new BestellingOpneemScherm();
            BestellingDrankForm d = new BestellingDrankForm();
            BestellingEtenForm e = new BestellingEtenForm();
            Afrekenen a = new Afrekenen();
            Application.Run(e);                // niet verwijderen. gwn veranderen.
        }
    }
}
>>>>>>> parent of 2f23fc4... Onderdeel afrekenen bijna klaar
