using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
//using Microsoft.AspNetCore.Http;

namespace CustomerInventory.WebApi.Entities
{
    [Table("Customers")]
    public class Customer
    {
        [Column("CustomerId")]
        public Guid Id { get; set; }
        
        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters")]
        public string Name { get; set; }
        
        [Description("Federal TaxId")]
        public int? EIN { get; set; }
        
        [NotMapped]
        public TimeZoneInfo TimeZone { get; set; }

        public bool? IsDomestic { get; set; }
    }
}
