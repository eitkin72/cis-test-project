using CompanyInvoiceSystem.Common.Constants.Api.Routes;
using CompanyInvoiceSystem.Common.Models.DataContracts;
using CompanyInvoiceSystem.WebApi.BuisnessLogic.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CompanyInvoiceSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    //[Route(ApiRoutes.Company.Prefix)]
    [ApiController]
    [EnableCors]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyManager _companyManager;
        
        public CompanyController(ICompanyManager companyManager)
        {       
            _companyManager = companyManager;        
        }

        [HttpGet(ApiRoutes.Default)]
        public ActionResult<CompanyServiceResponse> Get() => Ok("Welcome!");

        [HttpGet(ApiRoutes.Company.GetCompany)]
        public ActionResult<CompanyServiceResponse> GetCompany([FromHeader] CompanyServiceRequest request)
            => Ok(_companyManager.GetCompany(request));

        [HttpGet(ApiRoutes.Company.GetCompanies)]
        public ActionResult<CompanyServiceResponse> GetCompanies() => Ok(_companyManager.GetCompanies());

        [HttpPut(ApiRoutes.Company.UpdateCompany)]
        public ActionResult<CompanyServiceResponse> UpdateCompany([FromBody] CompanyUpdateServiceRequest request)
            => Ok(_companyManager.UpdateCompany(request));


        [HttpPost(ApiRoutes.Company.CreateCompany)]
        public ActionResult<CompanyServiceResponse> CreateCompany([FromBody] CompanyCreateServiceRequest request)
            => Ok(_companyManager.CreateCompany(request));

    }
}
