using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CompanyInvoiceSystem.Entities.Enums;

namespace CompanyInvoiceSystem.Common.Models.DataContracts
{
    [DataContract]    
    public class LookupValueServiceResponse
    {
        [DataMember]
        public Dictionary<string, Dictionary<int, string>> LookupValues { get; set; }
    }




}
