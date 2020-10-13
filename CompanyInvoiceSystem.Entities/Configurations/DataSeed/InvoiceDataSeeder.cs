using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyInvoiceSystem.Entities.Configurations
{    
    public static class InvoiceDataSeeder
    {
        private static Guid notFoundGuid = new Guid();
        public static List<Invoice> Data;

        static InvoiceDataSeeder()
        {
            var _companyData = CompanyDataSeeder.Data;
            if (_companyData == null || !_companyData.Any()) return;

            Data = new List<Invoice>
            {
                new Invoice
                {
                    CompanyId = _companyData.FindParentByEID(100000001),
                    Id = Guid.NewGuid(),
                    InvoiceDate = DateTime.Parse("10/10/2019"),
                    TotalValue = 3589.54m,
                    InvoiceType = Enums.InvoiceType.Debit,
                },
                new Invoice
                {
                    CompanyId = _companyData.FindParentByEID(100000001),
                    Id = Guid.NewGuid(),
                    InvoiceDate = DateTime.Parse("1/10/2020"),
                    TotalValue = 5687.54m,
                    InvoiceType = Enums.InvoiceType.Debit,
                },

                new Invoice
                {
                    CompanyId = _companyData.FindParentByEID(123456789),
                    Id = Guid.NewGuid(),
                    InvoiceDate = DateTime.Parse("03/10/2020"),
                    TotalValue = 10000.54m,
                    InvoiceType = Enums.InvoiceType.Mixed,
                },
            };
            
            //// actually let's keep them to show seeding errors ???????  
            //// Data.RemoveAll(i => i.CompanyId == notFoundGuid);           
        }

        private static Guid FindParentByEID(this List<Company> parentSeeder, int? EIN)
        {
            var company = parentSeeder.FirstOrDefault(c => c.EIN.GetValueOrDefault(0) == EIN);
            return company == null ? notFoundGuid : company.Id;
        }
    }
}
