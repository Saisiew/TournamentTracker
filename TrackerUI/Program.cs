using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the database connections
            TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.Sql);
            Application.Run(new TournamentDashboardForm());


            
            // included in this line is Hold the application open until this instance is closed out.
        }
    }
}
