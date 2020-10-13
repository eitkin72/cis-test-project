using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;


namespace CompanyInvoiceSystem.Entities.Configurations
{
    public class InvoiceConfig : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            BuildTableConfig(builder);
            SeedData(builder);
        }

        private void BuildTableConfig(EntityTypeBuilder<Invoice> builder)
        {            
            builder.ToTable("Invoices");
            builder.Property(s => s.Id)
                .HasColumnName("InvoiceId");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.InvoiceDate)
                .IsRequired();
            builder.Property(s => s.InvoiceType)
                .IsRequired();
            builder.Property(s => s.TotalValue)
                .IsRequired();            
        }
        
        private void SeedData(EntityTypeBuilder<Invoice> builder)
        {
            builder.HasData(InvoiceDataSeeder.Data);                      
        }
    }
}
