using CompanyInvoiceSystem.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CompanyInvoiceSystem.Entities
{
    //(дата инвойса, ввод типа инвойса (credit, debit, mixed, commercial), сумма).
    [Table("Invoices")]
    public class Invoice : BaseEntity
    {        
        public override Guid Id { get; set; }

        [Required]
        public DateTime InvoiceDate { get; set; }

        [Required]
        public InvoiceType InvoiceType { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TotalValue { get; set; }

        // primary classes references
        [ForeignKey(nameof(Entities.Company))]
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }

    }
}
