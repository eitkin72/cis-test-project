using CompanyInvoiceSystem.Entities.Enums;
using System;
using System.Runtime.Serialization;

namespace CompanyInvoiceSystem.Common.Models.DataContracts
{
    [DataContract]
    public class InvoiceUpdateServiceRequest
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public DateTime InvoiceDate { get; set; }

        [DataMember]
        public InvoiceType InvoiceType { get; set; }

        [DataMember]
        public decimal TotalValue { get; set; }
    }
}