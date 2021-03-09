using EFInAWinFormsApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFInAWinFormsApp
{
    public class Startup
    {
        public static IConfiguration Config { get; set; }

        public Startup()
        {
            var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            Config = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EmployeeDbContext>(options =>
            {
                options.UseSqlServer(Config.GetConnectionString("DefaultConnection"));
            });
        }
    }
}
