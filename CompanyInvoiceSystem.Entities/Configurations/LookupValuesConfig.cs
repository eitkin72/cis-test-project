using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CompanyInvoiceSystem.Entities.Configurations
{
    public class LookupValuesConfig : IEntityTypeConfiguration<LookupValue>
    {
        public void Configure(EntityTypeBuilder<LookupValue> builder)
        {
            BuildTableConfig(builder);
            SeedData(builder);
        }

        private void BuildTableConfig(EntityTypeBuilder<LookupValue> builder)
        {            
            builder.ToTable(nameof(LookupValue));
            builder.Property(s => s.Id)
                .HasColumnName("LookupValueId");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.LookupType)
                .IsRequired();
            builder.Property(s => s.LookupKey)
                .IsRequired();
            builder.Property(s => s.LookupText)
                .IsRequired();            
        }
        
        private void SeedData(EntityTypeBuilder<LookupValue> builder)
        {
            builder.HasData(LookupValuesSeeder.Data);                      
        }
    }
}
