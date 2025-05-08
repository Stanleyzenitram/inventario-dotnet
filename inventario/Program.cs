using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventario
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
            login obj = new login();
            if (obj.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
                return;
            }

            Application.Run(new Menu());

        }

        public static bool contectar()
        {
            return true;
        }

        public static bool ejecutar()
        {
            return true;
        }

        public static DateTime obtenerfecha()
        {
            return DateTime.Now;
        }
    }
}
