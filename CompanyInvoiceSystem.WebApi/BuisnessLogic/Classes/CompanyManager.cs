using CompanyInvoiceSystem.Common.Models.DataContracts;
using CompanyInvoiceSystem.Entities;
using CompanyInvoiceSystem.WebApi.BuisnessLogic.Interfaces;
using CompanyInvoiceSystem.WebApi.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyInvoiceSystem.WebApi.BuisnessLogic.Classes
{
    public class CompanyManager : ICompanyManager
    {
        private readonly ApplicationContext _context;

        public CompanyManager(ApplicationContext context)
        {
            _context = context;
        }

        public CompanyServiceResponse GetCompany(CompanyServiceRequest request)
        {
            var response = _context.Companies.FirstOrDefault(
                c => c.EIN == request.EIN || 
                c.Name == request.Name ||
                c.Id == request.Id);
            if (response == null) response = new Company();

            return AutoMapperConfig.Map<Company, CompanyServiceResponse>(response);
        }
       
        public IEnumerable<CompanyServiceResponse> GetCompanies() => 
            AutoMapperConfig.Map<IEnumerable<Company>, IEnumerable<CompanyServiceResponse>>(_context.Companies);


        public CompanyServiceResponse UpdateCompany(CompanyUpdateServiceRequest request)
        {
            var entity = AutoMapperConfig.Map<CompanyUpdateServiceRequest, Company>(request);
            var updated = _context.Update(entity);
            _context.SaveChanges();
            return AutoMapperConfig.Map<Company, CompanyServiceResponse>(updated.Entity);
        }

        public CompanyServiceResponse CreateCompany(CompanyCreateServiceRequest request)
        {
            var entity = AutoMapperConfig.Map<CompanyCreateServiceRequest, Company>(request);
            entity.Id = Guid.NewGuid();
            var updated = _context.Add(entity);
            _context.SaveChanges();
            return AutoMapperConfig.Map<Company, CompanyServiceResponse>(updated.Entity);
        }

    }
}
