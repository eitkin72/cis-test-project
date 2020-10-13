using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerInventory.WebApi.Entities
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {}

        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingCustomer(modelBuilder);
        }


        private void OnModelCreatingCustomer(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                    .ToTable("Customers");

            modelBuilder.Entity<Customer>()
                .Property(s => s.Id)
                .HasColumnName("CustomerId");
            modelBuilder.Entity<Customer>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<Customer>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Customer>()
                .Property(s => s.EIN)
                .IsRequired(false);
            modelBuilder.Entity<Customer>()
                .Ignore(s => s.TimeZone);


            modelBuilder.Entity<Customer>()
                .HasIndex(s => s.Name)
                .HasName("INDEX_CUSTOMERS__CUSTOMER_NAME")
                .IsUnique();

            modelBuilder.Entity<Customer>()
                .Property(s => s.IsDomestic)
                .HasDefaultValue(true);
        }
    }
}
