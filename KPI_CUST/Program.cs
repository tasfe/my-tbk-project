using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KPI_CUST
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
            Application.Run(new GetKPI_CUST());
        }
    }
}
