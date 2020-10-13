using System;
using System.Runtime.Serialization;


namespace CompanyInvoiceSystem.Common.Models.DataContracts
{
    [DataContract]
    public class CompanyServiceRequest
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]       
        public string Name { get; set; }

        [DataMember]
        public int? EIN { get; set; }        
    }
}
