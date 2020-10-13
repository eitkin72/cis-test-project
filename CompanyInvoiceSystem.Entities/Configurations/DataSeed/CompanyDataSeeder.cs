using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyInvoiceSystem.Entities.Configurations
{    
    public static class CompanyDataSeeder
    {
        public static List<Company> Data;
        public static List<Company> DataFromCtx;


        static CompanyDataSeeder()
        {
            Data = new List<Company>
            {
                new Company
                {
                    Id = Guid.NewGuid(),
                    Name = "AZ Tech",
                    EIN = 123456789,
                    TimeZone = TimeZoneInfo.GetSystemTimeZones().First(),   
                    AddressStreet = "100 Main St",
                    AddressUnitNumber = "12 Floor",
                    City = "New York",
                    State = "NY",
                    ZipCode = "10002",
                    PhoneNumber = "212-500-5000",
                },
                new Company
                {
                    Id = Guid.NewGuid(),
                    Name = "Brooklyn Trucks Inc.",
                    EIN = 100000001,
                    TimeZone = TimeZoneInfo.GetSystemTimeZones().First(),
                    AddressStreet = "100 Coyle St",
                    AddressUnitNumber = "#10",
                    City = "New York",
                    State = "NY",
                    ZipCode = "10012",
                    PhoneNumber = "212-300-3000",
                },
                new Company
                {
                    Id = Guid.NewGuid(),
                    Name = "Alt Solutions",
                    EIN = 100000331,
                    TimeZone = TimeZoneInfo.GetSystemTimeZones().First(),
                    AddressStreet = "112 Adams St",
                    AddressUnitNumber = "Unit 101",
                    City = "New York",
                    State = "NY",
                    ZipCode = "10012",
                    PhoneNumber = "212-200-2000",
                },
                new Company
                {
                    Id = Guid.NewGuid(),
                    Name = "3A Logistics",
                    EIN = 432451389,
                    TimeZone = TimeZoneInfo.GetSystemTimeZones().First(),
                    PhoneNumber = "333-533-3333",
                },
                new Company
                {
                    Id = Guid.NewGuid(),
                    Name = "3B Logistics",
                    EIN = 432451399,
                    TimeZone = TimeZoneInfo.GetSystemTimeZones().First()
                },
            };
        }

        
        public static void SeedData(ApplicationContext ctx)
        {
            if (!ctx.Companies.Any())
            {
                ctx.Companies.AddRange(Data);
                ctx.SaveChanges();
            }
        }
    }
}
