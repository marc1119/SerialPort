/*
Author: Marc-Antoine Beaudoin
Date: 2015-04-09
Ville: Sherbrooke
Version: 1.00
Id: Program.cs
*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleSerial
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
            Application.Run(new Form1());
        }
    }
}