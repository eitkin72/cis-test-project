using CompanyInvoiceSystem.Entities;
using CompanyInvoiceSystem.Entities.Enums;
using CompanyInvoiceSystem.Entities.Utils;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace CompanyInvoiceSystem.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            CreateHostBuilder(args)
                .Build()
                .MigrateDatabase()
                .Run();            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
