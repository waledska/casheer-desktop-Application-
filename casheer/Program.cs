using casheer.screens.Users;
using casheer.screens.menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using casheer.screens;
using Menu = casheer.screens.menu.Menu;
using casheer.screens.clients;
using casheer.screens.products;

namespace casheer
{
    internal static class Program
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
