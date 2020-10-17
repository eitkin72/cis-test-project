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
    [Route(ApiRoutes.LookupValue.Prefix)]
    [ApiController]
    [EnableCors]
    public class LookupValueController : ControllerBase
    {
        private readonly ILookupValueManager _lookupValuesManager;

        public LookupValueController(ILookupValueManager lookupValuesManager)
        {
            _lookupValuesManager = lookupValuesManager;
        }

        [HttpGet]
        public ActionResult<String> Get() => Ok("Welcome to LookupValueController! ");

        [HttpPost(ApiRoutes.LookupValue.GetLookupValues)]
        public ActionResult<LookupValueServiceResponse> GetLookupValues([FromBody] LookupValueServiceRequest request)
        {
            //var param = new LookupValueServiceRequest() { EnumTypes = new string[] { request } };                    
            return Ok(_lookupValuesManager.GetLookupValues(request));
        }
                      
    }
}
