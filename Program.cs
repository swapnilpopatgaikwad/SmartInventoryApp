using SmartInventoryApp.Forms;

namespace SmartInventoryApp
{
    //https://chatgpt.com/share/68393498-f4bc-800e-b376-dafbfbd2121f
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
            Application.Run(new ProductsForm());
        }
    }
}