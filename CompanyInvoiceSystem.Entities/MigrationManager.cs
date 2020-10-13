﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace CompanyInvoiceSystem.Entities
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var appContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>())
                {
                    try
                    {
                        appContext.Database.Migrate();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return host;
        }       
    }
}
