using CompanyInvoiceSystem.Common.Models.DataContracts;
using System.Collections.Generic;

namespace CompanyInvoiceSystem.WebApi.BuisnessLogic.Interfaces
{
    public interface ICompanyManager
    {
        CompanyServiceResponse GetCompany(CompanyServiceRequest request);

        IEnumerable<CompanyServiceResponse> GetCompanies();

        CompanyServiceResponse UpdateCompany(CompanyUpdateServiceRequest request);

        CompanyServiceResponse CreateCompany(CompanyCreateServiceRequest request);
    }
}
