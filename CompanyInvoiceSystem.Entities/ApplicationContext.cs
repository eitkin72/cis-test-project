using CompanyInvoiceSystem.Entities.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CompanyInvoiceSystem.Entities
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {}

        public DbSet<LookupValue> LookupValues { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new LookupValuesConfig())
                .ApplyConfiguration(new CompanyConfig())
                .ApplyConfiguration(new InvoiceConfig());             
        }        
    }
}
