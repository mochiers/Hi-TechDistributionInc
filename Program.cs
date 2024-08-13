using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_TechDistributionInc.GUI;

namespace Hi_TechDistributionInc
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
            //Application.Run(new LoginForm());
            //Application.Run(new EmployeeMaintenance());
            //Application.Run(new CustomerMaintenance());
            Application.Run(new InventoryMaintenance());
        }
    }
}
