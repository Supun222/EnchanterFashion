﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enchanter_Fashion.inventory;


namespace Enchanter_Fashion
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

            //Application.Run(new Form1());
            //displaypanel
            Application.Run(new displaypanel());
            //Application.Run(new form_dashboard());
            //Application.Run(new testing());
        }
    }
}
