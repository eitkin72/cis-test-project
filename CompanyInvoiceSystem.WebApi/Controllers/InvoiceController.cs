using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyInvoiceSystem.Common.Models.DataContracts;
using CompanyInvoiceSystem.WebApi.BuisnessLogic.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyInvoiceSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
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

        [HttpGet(nameof(GetInvoice))]        
        public ActionResult<InvoiceServiceResponse> GetInvoice(Guid id)
            => Ok(_invoiceManager.GetInvoice(id));                    

        [HttpGet(nameof(GetInvoices))]
        public ActionResult<InvoiceServiceResponse> GetInvoices([FromHeader] InvoiceCollectionServiceRequest request) 
            => Ok(_invoiceManager.GetInvoices(request));   
        
        [HttpPut(nameof(UpdateInvoice))]
        public ActionResult<InvoiceServiceResponse> UpdateInvoice([FromBody] InvoiceUpdateServiceRequest request)
            => Ok(_invoiceManager.UpdateInvoice(request));
    
        [HttpPost(nameof(CreateInvoice))]
        public ActionResult<InvoiceServiceResponse> CreateInvoice([FromBody] InvoiceCreateServiceRequest request)
            => _invoiceManager.CreateInvoice(request);                    
    }
}
