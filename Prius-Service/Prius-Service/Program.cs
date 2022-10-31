using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Prius_Service
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("hu-HU");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Menu.Instance);
        }
    }
}
