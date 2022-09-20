namespace MAIN
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        static public START.Start start = new START.Start();

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            start.StartPosition = FormStartPosition.CenterScreen;
            start.Location = new Point(100, 20);
            Application.Run(start);
        }
    }
}