using RestaurantKuLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantKuUI
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
            RestaurantKuLibrary.GlobalConfig.IConnection(DatabaseType.Sql);
            Application.Run(new ManageEmployeeForm());
            
        }
    }
}
