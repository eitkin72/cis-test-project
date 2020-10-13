using CompanyInvoiceSystem.Common.Models.Api;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyInvoiceSystem.WebApi.Utils
{
    public static class RestServiceUtils
    {
        public static IActionResult CreateErrorResult(HttpRequestMessage request, Exception ex)
        {
            HttpResponseMessage response = request.CreateResponse(HttpStatusCode.InternalServerError,
                new ApiResponse
                {
                    ApiStatusCode = ErrorUtility.Parse((ex.InnerException ?? ex).Message),
                    ApiStatusMessage = ErrorUtility.GetMessage((ex.InnerException ?? ex).Message),
                    ExceptionDetails = new ApiExceptionDetails(ex)
                });
            return new ResponseMessageResult(response);
        }

        public static IHttpActionResult CreateErrorResult(HttpRequestMessage request, ApiException ex)
        {
            HttpResponseMessage response = request.CreateResponse(ex.HttpStatusCode,
                new ApiResponse
                {
                    ApiStatusCode = ex.ErrorCode,
                    ApiStatusMessage = ex.Message,
                    ExceptionDetails = new ApiExceptionDetails(ex)
                });
            return new ResponseMessageResult(response);
        }
    }
}
