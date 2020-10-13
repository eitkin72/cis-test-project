using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Runtime.Serialization;


namespace CompanyInvoiceSystem.Common.Models.DataContracts
{
    [DataContract]
    public class CompanyServiceResponse
    {
        [DataMember]
        public Guid? Id { get; set; }

        [DataMember]
        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters")]
        public string Name { get; set; }

        [DataMember]
        [Description("Federal TaxID")]
        public int? EIN { get; set; }

        [DataMember]
        public TimeZoneInfo TimeZone { get; set; }

        [DataMember]
        [DefaultValue(true)]
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
