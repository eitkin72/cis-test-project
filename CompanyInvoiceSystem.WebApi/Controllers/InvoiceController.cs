using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyInvoiceSystem.Common.Constants.Api.Routes;
using CompanyInvoiceSystem.Common.Models.DataContracts;
using CompanyInvoiceSystem.WebApi.BuisnessLogic.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyInvoiceSystem.WebApi.Controllers
{
    [Route(ApiRoutes.Invoice.Prefix)]
    [ApiController]
    [EnableCors]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceManager _invoiceManager;
       
        public InvoiceController(IInvoiceManager invoiceManager)
        {       
            _invoiceManager = invoiceManager;
        }

        [HttpGet]
        public ActionResult<CompanyServiceResponse> Get() => Ok("Welcome to InvoiceController! ");

        [HttpGet(ApiRoutes.Invoice.GetInvoice)]        
        public ActionResult<InvoiceServiceResponse> GetInvoice(Guid id)
            => Ok(_invoiceManager.GetInvoice(id));

        [HttpGet(ApiRoutes.Invoice.GetInvoices)]
        public ActionResult<InvoiceServiceResponse> GetInvoices([FromHeader] InvoiceCollectionServiceRequest request) 
            => Ok(_invoiceManager.GetInvoices(request));

        [HttpPut(ApiRoutes.Invoice.UpdateInvoice)]
        public ActionResult<InvoiceServiceResponse> UpdateInvoice([FromBody] InvoiceUpdateServiceRequest request)
            => Ok(_invoiceManager.UpdateInvoice(request));

        [HttpPost(ApiRoutes.Invoice.CreateInvoice)]
        public ActionResult<InvoiceServiceResponse> CreateInvoice([FromBody] InvoiceCreateServiceRequest request)
            => _invoiceManager.CreateInvoice(request);                    
    }
}
