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
            Inlogscherm i = new Inlogscherm();
            Application.Run(i);                // niet verwijderen. gwn veranderen.
        }
    }
}

