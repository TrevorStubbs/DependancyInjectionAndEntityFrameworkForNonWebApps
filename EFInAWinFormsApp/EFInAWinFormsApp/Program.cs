using EFInAWinFormsApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFInAWinFormsApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = CreateHostBuilder(args);
            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var logger = services.GetRequiredService<ILogger<Form1>>();
                    var employeeContext = services.GetRequiredService<EmployeeDbContext>();
                    Application.Run(new Form1(employeeContext));

                    Console.WriteLine("Success");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Occurred");
                }
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            var startup = new Startup();

            var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    startup.ConfigureServices(services);                    
                });

            return host;
        }
    }
}
