using System;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.View;

namespace CS6232_G2_Furniture_Rental
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
            Application.Run(new LoginForm());
        }
    }
}
