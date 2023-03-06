namespace Winform3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            mm_cs_DataManipulation.ARecord aRecord = new mm_cs_DataManipulation.ARecord();
            aRecord.Run();

            mm_cs_DataManipulation.Mapping mapping = new mm_cs_DataManipulation.Mapping();
            mapping.Run();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}