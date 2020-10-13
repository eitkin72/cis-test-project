using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyInvoiceSystem.Entities.Configurations
{
    public class CompanyConfig : IEntityTypeConfiguration<Company>
    {       
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            BuildTableConfig(builder);
            SeedData(builder);
        }        

        private void BuildTableConfig(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Companies");
            builder.Property(s => s.Id)
                    .HasColumnName("CompanyId");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            builder.Property(s => s.EIN)
                    .IsRequired(false);
            builder.Ignore(s => s.TimeZone);


            builder.HasIndex(s => s.Name)
                    .HasName("INDEX_Companies__Company_NAME")
                    .IsUnique();

            builder.Property(s => s.IsDomestic)
                    .HasDefaultValue(true);

            // define dependencies
            builder
                .HasMany(s => s.Invoices)
                .WithOne(s => s.Company)
                .HasForeignKey(s => s.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

        }

        private void SeedData(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(CompanyDataSeeder.Data);           
        }
    }
}
