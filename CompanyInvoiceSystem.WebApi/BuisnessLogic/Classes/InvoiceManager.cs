using CompanyInvoiceSystem.Common.Models.DataContracts;
using CompanyInvoiceSystem.Entities;
using CompanyInvoiceSystem.Entities.Enums;
using CompanyInvoiceSystem.WebApi.BuisnessLogic.Interfaces;
using CompanyInvoiceSystem.WebApi.Configurations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyInvoiceSystem.WebApi.BuisnessLogic.Classes
{
    public class InvoiceManager : IInvoiceManager
    {
        private readonly ApplicationContext _context;

        public InvoiceManager(ApplicationContext context)
        {
            _context = context;
        }

        public InvoiceServiceResponse GetInvoice(Guid id)
        {
            var response = _context.Invoices.FirstOrDefault(i => i.Id == id);

            return AutoMapperConfig.Map<Invoice, InvoiceServiceResponse>(response);
        }

        public IEnumerable<InvoiceServiceResponse> GetInvoices(InvoiceCollectionServiceRequest request)
        {
            request.UpperTotal = request.UpperTotal == 0 ? decimal.MaxValue : request.UpperTotal;

            var entities = _context.Invoices
                .Where(i => request.CompanyId == Guid.Empty || i.CompanyId == request.CompanyId)
                .Where(i => request.InvoiceType == InvoiceType.None || i.InvoiceType == (i.InvoiceType & request.InvoiceType))
                .Where(i => i.TotalValue >= request.LowerTotal && i.TotalValue <= request.UpperTotal)
                .Where(i => i.TotalValue >= request.LowerTotal && i.TotalValue <= request.UpperTotal);                    

            return AutoMapperConfig.Map<IEnumerable<Invoice>, IEnumerable<InvoiceServiceResponse>>(entities);
        }

        public InvoiceServiceResponse UpdateInvoice(InvoiceUpdateServiceRequest request)
        {            
            var entity = AutoMapperConfig.Map<InvoiceUpdateServiceRequest, Invoice>(request);
            var origEntity = _context.Invoices.FirstOrDefault(i => i.Id == request.Id);           
            if (origEntity == null) throw new Exception();
            _context.Entry(origEntity).State = EntityState.Detached;
            entity.CompanyId = origEntity.CompanyId;
                        
            var updated = _context.Update(entity);
            _context.SaveChanges();
            return AutoMapperConfig.Map<Invoice, InvoiceServiceResponse>(updated.Entity);
        }

        public InvoiceServiceResponse CreateInvoice(InvoiceCreateServiceRequest request)
        {
            var entity = AutoMapperConfig.Map<InvoiceCreateServiceRequest, Invoice>(request);
            entity.Id = Guid.NewGuid();
            var updated = _context.Add(entity);
            _context.SaveChanges();
            return AutoMapperConfig.Map<Invoice, InvoiceServiceResponse>(updated.Entity);
        }

                      
    }
}
