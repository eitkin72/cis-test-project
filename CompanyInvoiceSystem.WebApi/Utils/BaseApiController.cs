using CompanyInvoiceSystem.Common.Models.Api;
using CompanyInvoiceSystem.WebApi.Utils;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
//using System.Web.Http;

namespace CompanyInvoiceSystem.WebApi.Controllers
{
    public abstract class BaseApiController : ControllerBase
    {
        //////protected readonly ILogger Logger;

        //////protected BaseApiController(ILogger logger)
        //////{
        //////    Logger = logger;
        //////}

        public IActionResult ApiOk()
        {
            var response = new ApiResponse();

            return Ok(response);
        }

        protected IActionResult ApiOk<T>(T data, HttpStatusCode code = HttpStatusCode.OK)
        {
            ApiDataResponse<T> response = new ApiDataResponse<T> { Data = data, HttpStatusCode = code };
            return Ok(response);
        }

        protected async Task<IActionResult> GetActionResult<T>(Func<Task<T>> action)
        {
            try
            {
                T result = await action().ConfigureAwait(false);

                return ApiOk(result);
            }
            catch (ApiException ex)
            {
                ///Logger.Error(ex);
                return RestServiceUtils.CreateErrorResult(ControllerContext.Request, ex);
            }
            catch (Exception ex)
            {
                ///Logger.Error(ex);
                return RestServiceUtils.CreateErrorResult(ControllerContext.Request, ex);
            }
        }

        protected async Task<IActionResult> GetEmptyActionResult(Func<Task> action)
        {
            try
            {
                await action();

                return ApiOk();
            }
            catch (ApiException ex)
            {
                ///Logger.Error(ex);
                return RestServiceUtils.CreateErrorResult(ControllerContext.Request, ex);
            }
            catch (Exception ex)
            {
                ///Logger.Error(ex);
                return RestServiceUtils.CreateErrorResult(ControllerContext.Request, ex);
            }
        }
    }
}