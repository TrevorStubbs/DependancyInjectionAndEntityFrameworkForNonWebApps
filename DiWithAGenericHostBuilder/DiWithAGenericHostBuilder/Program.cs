using DiWithAGenericHostBuilder.Model.Interfaces;
using DiWithAGenericHostBuilder.Model.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiWithAGenericHostBuilder
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new HostBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<Form1>();
                    services.AddLogging(configure => configure.AddConsole());
                    services.AddScoped<IBusinessLayer, BusinessLayer>();
                    services.AddScoped<IDataLayer, DataLayer>();
                });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    // This is the entry point for all other forms
                    var form1 = services.GetRequiredService<Form1>();
                    Application.Run(form1);

                    Console.WriteLine("Success");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Error Occured: {ex.Message}");
                }
            }

        }
    }
}
