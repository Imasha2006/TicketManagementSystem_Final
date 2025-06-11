using System;
using System.Windows.Forms;
using EventTicketingSystem.Forms;

namespace EventTicketingSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the Event Ticketing System application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enable modern Windows Forms styling
            Application.EnableVisualStyles();

            // Use default text rendering compatible with current OS
            Application.SetCompatibleTextRenderingDefault(false);

            // Start the application with the Login Form
            Application.Run(new TicketSaleForm());
        }
    }
}
