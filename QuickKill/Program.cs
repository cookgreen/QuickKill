namespace QuickKill
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

            frmAIApiSetup apiApiSetupWin = new frmAIApiSetup();
            if (apiApiSetupWin.ShowDialog() == DialogResult.OK)
            {
                frmMain mainWindow = new frmMain(apiApiSetupWin.AiApi);
                Application.Run(mainWindow);
            }
        }
    }
}