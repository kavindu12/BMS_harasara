using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS_harasara
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
<<<<<<< HEAD
            Application.Run(new BMS_harasara.FinanceSub());
=======
            Application.Run(new inv_sub());
>>>>>>> 51f2e74ec6e9fde4be7c0782167c43e63604a896
        }
    }
}
