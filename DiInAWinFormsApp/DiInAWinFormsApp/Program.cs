using DiInAWinFormsApp.Model;
using DiInAWinFormsApp.Model.Interfaces;
using DiInAWinFormsApp.Model.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiInAWinFormsApp
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

            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider sp = services.BuildServiceProvider())
            {
                var form1 = sp.GetRequiredService<Form1>();
                Application.Run(form1);
            }

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddLogging(configure => configure.AddConsole())
                .AddScoped<IBusinessLayer, BusinessLayer>()
                .AddScoped<IBusinessLayer, BusinessLayer>()
                .AddSingleton<IDataLayer, DataLayer>()
                .AddScoped<Form1>();
            
        }
    }
}
