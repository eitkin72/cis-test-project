using CompanyInvoiceSystem.Entities.Enums;
using System;
using System.Runtime.Serialization;

namespace CompanyInvoiceSystem.Common.Models.DataContracts
{
    [DataContract]
    public class LookupValueServiceRequest
    {      
        [DataMember]
        public string[] EnumTypes { get; set; }        
    }
}
