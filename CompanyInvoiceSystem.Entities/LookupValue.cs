using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyInvoiceSystem.Entities
{
    [Table("LookupValues")]
    public class LookupValue
    {        
        public Guid Id { get; set; }

        [Required]
        public string LookupType { get; set; }

        [Required]
        public string LookupText { get; set; }

        [Required]
        public int LookupKey { get; set; }
    }
}
