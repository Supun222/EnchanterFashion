using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enchanter_Fashion.Display_Board;
using Enchanter_Fashion.inventory;
using Enchanter_Fashion.Massage;
using Enchanter_Fashion.Signup_and_Registration;

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
            //hellow
            //Application.Run(new Form1());
            //displaypanel
            //Application.Run(new displaypanel());
            //Application.Run(new form_dashboard());
            Application.Run(new testing());
            //Application.Run(new DIMassage());
            //Application.Run(new addarrivals());
            //Application.Run(new passwordrecovery());
        }
    }
}
