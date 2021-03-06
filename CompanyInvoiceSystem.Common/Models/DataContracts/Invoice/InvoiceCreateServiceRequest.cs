﻿using CompanyInvoiceSystem.Entities.Enums;
using System;
using System.Runtime.Serialization;

namespace CompanyInvoiceSystem.Common.Models.DataContracts
{
    [DataContract]
    public class InvoiceCreateServiceRequest
    {        
        [DataMember]
        public DateTime InvoiceDate { get; set; }

        [DataMember]
        public InvoiceType InvoiceType { get; set; }

        [DataMember]
        public decimal TotalValue { get; set; }

        [DataMember]
        public Guid CompanyId { get; set; }
    }
}
