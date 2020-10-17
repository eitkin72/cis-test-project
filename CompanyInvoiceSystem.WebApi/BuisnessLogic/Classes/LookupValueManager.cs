using CompanyInvoiceSystem.Common.Models.DataContracts;
using CompanyInvoiceSystem.Entities;
using CompanyInvoiceSystem.Entities.Enums;
using CompanyInvoiceSystem.Entities.Utils;
using CompanyInvoiceSystem.WebApi.BuisnessLogic.Interfaces;
using CompanyInvoiceSystem.WebApi.Configurations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyInvoiceSystem.WebApi.BuisnessLogic.Classes
{
    public class LookupValueManager : ILookupValueManager
    {
        private readonly ApplicationContext _context;

        public LookupValueManager(ApplicationContext context)
        {
            _context = context;
        }

        public LookupValueServiceResponse GetLookupValues(LookupValueServiceRequest request)
        {
            LookupValueServiceResponse result = new LookupValueServiceResponse();
            result.LookupValues = new Dictionary<string, Dictionary<int, string>>();
            foreach (string type in request.EnumTypes)
            {                          
                var kvp = EnumUtils.EnumDictionaryByType(type);
                result.LookupValues.Add(type, kvp);
            }            
            return result;
        }
    }
}
