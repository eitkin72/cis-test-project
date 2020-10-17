using CompanyInvoiceSystem.Common.Models.DataContracts;
using System.Collections.Generic;

namespace CompanyInvoiceSystem.WebApi.BuisnessLogic.Interfaces
{
    public interface ILookupValueManager
    {
        LookupValueServiceResponse GetLookupValues(LookupValueServiceRequest request);
    }
}