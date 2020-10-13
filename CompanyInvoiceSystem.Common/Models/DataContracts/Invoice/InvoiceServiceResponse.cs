using System;
using System.Runtime.Serialization;
using CompanyInvoiceSystem.Entities.Enums;

namespace CompanyInvoiceSystem.Common.Models.DataContracts
{
    [DataContract]
    public class InvoiceServiceResponse
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public Guid CompanyId { get; set; }

        [DataMember]
        public DateTime InvoiceDate { get; set; }

        [DataMember]
        public InvoiceType InvoiceType { get; set; }

        [DataMember]        
        public decimal TotalValue { get; set; }
    }
}
