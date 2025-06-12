namespace Dbex
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Application.Run(new Organizer());
            //Application.Run(new Admin_Login());
            Application.Run(new User());
            //Application.Run(new Roleselection());



            //Application.Run(new Ticket_Organizer());
            //Application.Run(new Ticket_Admin());
            //Application.Run(new Ticket_User());


            //Application.Run(new AdminDashboardForm());
            //Application.Run(new UserEventHomeForm3());
            //Application.Run(new DeleteEventForm());
            //Application.Run(new AdditemForm());

            //Application.Run(new AdditemForm());



        }
    }
}