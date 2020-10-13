using CompanyInvoiceSystem.Entities.Enums;
using System;
using System.Runtime.Serialization;

namespace CompanyInvoiceSystem.Common.Models.DataContracts
{
    [DataContract]
    public class InvoiceCollectionServiceRequest
    {      
        [DataMember]
        public Guid CompanyId { get; set; }

        [DataMember]
        public decimal LowerTotal { get; set; }

        [DataMember]
        public decimal UpperTotal { get; set; }

        [DataMember]
        public InvoiceType InvoiceType { get; set; }
    }
}
