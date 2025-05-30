using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SmartInventoryApp.Data;
using SmartInventoryApp.Forms;
using SmartInventoryApp.Services;

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
            var host = CreateHostBuilder().Build();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var form = host.Services.GetRequiredService<MainForm>();
            Application.Run(form);
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<InventoryContext>(); // register EF DbContext
                    services.AddScoped<ProductService>();       // optional service layer
                    services.AddSingleton<MainForm>();          // register the main form
                });
        }
    }
}