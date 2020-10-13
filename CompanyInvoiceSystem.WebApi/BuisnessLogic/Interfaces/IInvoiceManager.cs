using CompanyInvoiceSystem.Common.Models.DataContracts;
using System;
using System.Collections.Generic;

namespace CompanyInvoiceSystem.WebApi.BuisnessLogic.Interfaces
{
    public interface IInvoiceManager
    {
        InvoiceServiceResponse GetInvoice(Guid id);

        IEnumerable<InvoiceServiceResponse> GetInvoices(InvoiceCollectionServiceRequest request);

        InvoiceServiceResponse UpdateInvoice(InvoiceUpdateServiceRequest request);

        InvoiceServiceResponse CreateInvoice(InvoiceCreateServiceRequest request);

    }
}
