using System;
using System.Threading.Tasks;
using AddingEFToANonASPProgram.Data;
using AddingEFToANonASPProgram.Model.Interfaces;
using AddingEFToANonASPProgram.Model.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AddingEFToANonASPProgram
{
    public class Program
    {        
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            await CreateHostBuilder(args).Build().RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder().ConfigureServices((IServiceCollection services) =>
            {
                services.AddTransient<IHello, HelloService>();

                services.AddDbContext<HostDbContext>(options =>
                    options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=hostTestDb;Trusted_Connection=True;MultipleActiveResultSets=true"));

            });
    }
}
