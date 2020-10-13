using CompanyInvoiceSystem.Entities.Enums;
using CompanyInvoiceSystem.Entities.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyInvoiceSystem.Entities.Configurations
{    
    public static class LookupValuesSeeder
    {        
        public static List<LookupValue> Data;

        static LookupValuesSeeder()
        {
            Data = new List<LookupValue>();
            Data.AddEnumToSeed<InvoiceType>();              
        }

        private static IEnumerable<LookupValue> GetLookupValues<T>(this Dictionary<int, string> dictionary)
        {
            var invoiceTypes = EnumUtils.EnumDictionary<T>();

            return dictionary.Select(kvp => 
                new LookupValue { 
                    Id = new Guid(),
                    LookupType = nameof(T),
                    LookupKey = kvp.Key,
                    LookupText = kvp.Value,
                });
        }

        private static IEnumerable<LookupValue> AddEnumToSeed<T>(this List<LookupValue> data)
        {
            var dictionary = EnumUtils.EnumDictionary<T>();            
            data.AddRange(
                dictionary.Select(kvp =>
                    new LookupValue
                    {
                        Id = Guid.NewGuid(),
                        LookupType = typeof(T).Name,
                        LookupKey = kvp.Key,
                        LookupText = kvp.Value,
                    }));
            return data;
        }
    }
}
