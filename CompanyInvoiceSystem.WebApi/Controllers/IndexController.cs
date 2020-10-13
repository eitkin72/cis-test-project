//using System.Web.Http;
using CompanyInvoiceSystem.Common.Models.DataContracts;
using CompanyInvoiceSystem.WebApi.BuisnessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CompanyInvoiceSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    //[Route("[controller]")]
    [ApiController]    
    public class IndexController /// : BaseApiController
    {
        private readonly ICompanyManager _companyManager;
        //private readonly ApplicationContext _context;

        public IndexController(ICompanyManager companyManager)
        {
            //_context = context;
            _companyManager = companyManager;
        }

        [HttpGet]
        public ActionResult<CompanyServiceResponse> Get()
        {
            //return Ok("Welcome");
            //////var companiesWithInvoices = _context.Companies
            //////    .AsNoTracking()
            //////    .Where(c => c.Invoices.Any())
            //////    .Include(i => i.Invoices)
            //////    .ToList();
            //////var companiesWithOutInvoices = _context.Companies
            //////    .AsNoTracking()
            //////    .Where(c => !c.Invoices.Any())
            //////    .ToList();

            //////var grouped = new
            //////{
            //////    HaveInvoices = companiesWithInvoices,
            //////    NoInvoices = companiesWithOutInvoices
            //////};

            //////return Ok(grouped);
            
            var request = new CompanyServiceRequest { EIN = 100000331 };
            var response = _companyManager.GetCompany(request);

            return Ok();       




            //////////var companies = _context.Companies.Where(c => c.Name == "AZ Tech");

            //////////var countInvoices = companies
            //////////    .Select(c => new
            //////////    {
            //////////        c.Name,
            //////////        c.EIN,
            //////////        InvoiceCount = c.Invoices.Count
            //////////    });

            //////////return Ok(countInvoices);




            

            //////////var entity = _context.Model
            //////////    .FindEntityType(typeof(Company).FullName);

            //////////var tableName = entity.GetTableName();
            //////////var schemaName = entity.GetSchema();
            //////////var key = entity.FindPrimaryKey();
            //////////var properties = entity.GetProperties();

            //////////return Ok(new { 
            //////////    Entity = entity,
            //////////    TableName = tableName,
            //////////    SchemaName = schemaName,
            //////////    Key = key,
            //////////    Properties = properties,

            //////////});
        }
    }
}
