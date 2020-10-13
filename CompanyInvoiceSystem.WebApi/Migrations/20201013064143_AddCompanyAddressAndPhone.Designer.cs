﻿// <auto-generated />
using System;
using CompanyInvoiceSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CompanyInvoiceSystem.WebApi.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20201013064143_AddCompanyAddressAndPhone")]
    partial class AddCompanyAddressAndPhone
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CompanyInvoiceSystem.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AddressStreet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressUnitNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EIN")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDomestic")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("INDEX_Companies__Company_NAME");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9068efc6-4fff-4b02-bacc-da4dcc824bc0"),
                            EIN = 123456789,
                            Name = "AZ Tech"
                        },
                        new
                        {
                            Id = new Guid("f7e575f9-3e93-4069-9b11-6a7a67516e05"),
                            EIN = 100000001,
                            Name = "Brooklyn Trucks Inc."
                        },
                        new
                        {
                            Id = new Guid("764e24fc-81e2-4c5f-9657-bcdb8b40edd3"),
                            EIN = 100000331,
                            Name = "Alt Solutions"
                        },
                        new
                        {
                            Id = new Guid("f64e04e4-3a68-461a-86d2-a34371b9ecc7"),
                            EIN = 432451389,
                            Name = "3A Logistics"
                        },
                        new
                        {
                            Id = new Guid("f827dbaf-f771-461f-9a35-979bcacfb968"),
                            EIN = 432451399,
                            Name = "3B Logistics"
                        });
                });

            modelBuilder.Entity("CompanyInvoiceSystem.Entities.Invoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("InvoiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("InvoiceType")
                        .HasColumnType("int");

                    b.Property<decimal?>("TotalValue")
                        .IsRequired()
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Invoices");

                    b.HasData(
                        new
                        {
                            Id = new Guid("43ca38fe-4ba1-4b49-969e-aa2eea9b9ded"),
                            CompanyId = new Guid("f7e575f9-3e93-4069-9b11-6a7a67516e05"),
                            InvoiceDate = new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InvoiceType = 2,
                            TotalValue = 3589.54m
                        },
                        new
                        {
                            Id = new Guid("07f548ae-01d3-40f0-82f0-1eb6c51e53bf"),
                            CompanyId = new Guid("f7e575f9-3e93-4069-9b11-6a7a67516e05"),
                            InvoiceDate = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InvoiceType = 2,
                            TotalValue = 5687.54m
                        },
                        new
                        {
                            Id = new Guid("2e9cad80-e35e-49f6-86b2-773a21a2c12b"),
                            CompanyId = new Guid("9068efc6-4fff-4b02-bacc-da4dcc824bc0"),
                            InvoiceDate = new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InvoiceType = 4,
                            TotalValue = 10000.54m
                        });
                });

            modelBuilder.Entity("CompanyInvoiceSystem.Entities.LookupValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LookupValueId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("LookupKey")
                        .HasColumnType("int");

                    b.Property<string>("LookupText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LookupType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LookupValue");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7a5661df-27ed-4ab2-87c3-683903c05fa0"),
                            LookupKey = 0,
                            LookupText = "None",
                            LookupType = "InvoiceType"
                        },
                        new
                        {
                            Id = new Guid("a69f394f-c24f-4919-906e-9cc5ed2b5bed"),
                            LookupKey = 1,
                            LookupText = "Credit",
                            LookupType = "InvoiceType"
                        },
                        new
                        {
                            Id = new Guid("e718f9aa-9a18-426d-8c13-457e1bec9776"),
                            LookupKey = 2,
                            LookupText = "Debit",
                            LookupType = "InvoiceType"
                        },
                        new
                        {
                            Id = new Guid("74e6f414-ab2b-4f90-9dc1-77ba6b295c61"),
                            LookupKey = 4,
                            LookupText = "Mixed",
                            LookupType = "InvoiceType"
                        },
                        new
                        {
                            Id = new Guid("36808cca-c484-40e2-a458-bc7b4517ecdc"),
                            LookupKey = 8,
                            LookupText = "Commercial",
                            LookupType = "InvoiceType"
                        });
                });

            modelBuilder.Entity("CompanyInvoiceSystem.Entities.Invoice", b =>
                {
                    b.HasOne("CompanyInvoiceSystem.Entities.Company", "Company")
                        .WithMany("Invoices")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}