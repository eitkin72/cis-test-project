using System;
using System.Runtime.Serialization;


namespace CompanyInvoiceSystem.Common.Models.DataContracts
{
    [DataContract]
    public class CompanyCreateServiceRequest
    {       
        [DataMember]       
        public string Name { get; set; }

        [DataMember]
        public int? EIN { get; set; }

        [DataMember]
        public TimeZoneInfo TimeZone { get; set; }

        [DataMember]
        public bool? IsDomestic { get; set; }

        [DataMember]
        public string AddressStreet { get; set; }

        [DataMember]
        public string AddressUnitNumber { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string ZipCode { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }
    }
}
