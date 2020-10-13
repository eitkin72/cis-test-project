using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
//using Microsoft.AspNetCore.Http;

namespace CompanyInvoiceSystem.Entities
{
    [Table("Companies")]
    public class Company : BaseEntity
    {
        public override Guid Id { get; set; }
        
        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters")]
        public string Name { get; set; }
        
        [Description("Federal TaxId")]
        public int? EIN { get; set; }
        
        [NotMapped]
        public TimeZoneInfo TimeZone { get; set; }

        [DefaultValue(true)]
        public bool? IsDomestic { get; set; }

        public string AddressStreet { get; set; }

        public string AddressUnitNumber { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string PhoneNumber { get; set; }

        // Dependency classes
        public ICollection<Invoice> Invoices { get; set; }
    }
}
