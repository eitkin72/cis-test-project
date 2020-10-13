using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyInvoiceSystem.WebApi.Migrations
{
    public partial class AddCompanyAddressAndPhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("5a71a5a1-c7ae-4c0e-a6a0-416f4b0caab7"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("cf52cbe9-b506-423c-9d62-55c8a25ebcd6"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("ecbc3acf-3cf1-4415-94d5-2112ed585538"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: new Guid("c81d53c5-14fd-4cbd-b9e9-5859fb67113d"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: new Guid("f1132f45-9435-4689-a260-00b95923ebc2"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: new Guid("fe5e1800-d848-474b-8ccd-0bb08246b2e8"));

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "LookupValueId",
                keyValue: new Guid("0780a2d7-4da4-48e4-be6e-f3cc5e31ebbf"));

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "LookupValueId",
                keyValue: new Guid("1905c769-3e21-4357-b3f8-78cc85591e9d"));

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "LookupValueId",
                keyValue: new Guid("1b6501d6-89e9-47d7-82c9-12f4b898634d"));

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "LookupValueId",
                keyValue: new Guid("9ff1e123-9beb-49ea-9e56-f376936223db"));

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "LookupValueId",
                keyValue: new Guid("c24e292e-cd04-46ef-8785-38e65a79d84c"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("80a0c295-7775-4b2f-bba1-05033c5d33ad"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("e9a600ef-aaf9-47cf-8d25-0926dd29298f"));

            migrationBuilder.AddColumn<string>(
                name: "AddressStreet",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressUnitNumber",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Companies",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "AddressStreet", "AddressUnitNumber", "City", "EIN", "Name", "PhoneNumber", "State", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("9068efc6-4fff-4b02-bacc-da4dcc824bc0"), null, null, null, 123456789, "AZ Tech", null, null, null },
                    { new Guid("f7e575f9-3e93-4069-9b11-6a7a67516e05"), null, null, null, 100000001, "Brooklyn Trucks Inc.", null, null, null },
                    { new Guid("764e24fc-81e2-4c5f-9657-bcdb8b40edd3"), null, null, null, 100000331, "Alt Solutions", null, null, null },
                    { new Guid("f64e04e4-3a68-461a-86d2-a34371b9ecc7"), null, null, null, 432451389, "3A Logistics", null, null, null },
                    { new Guid("f827dbaf-f771-461f-9a35-979bcacfb968"), null, null, null, 432451399, "3B Logistics", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "LookupValue",
                columns: new[] { "LookupValueId", "LookupKey", "LookupText", "LookupType" },
                values: new object[,]
                {
                    { new Guid("7a5661df-27ed-4ab2-87c3-683903c05fa0"), 0, "None", "InvoiceType" },
                    { new Guid("a69f394f-c24f-4919-906e-9cc5ed2b5bed"), 1, "Credit", "InvoiceType" },
                    { new Guid("e718f9aa-9a18-426d-8c13-457e1bec9776"), 2, "Debit", "InvoiceType" },
                    { new Guid("74e6f414-ab2b-4f90-9dc1-77ba6b295c61"), 4, "Mixed", "InvoiceType" },
                    { new Guid("36808cca-c484-40e2-a458-bc7b4517ecdc"), 8, "Commercial", "InvoiceType" }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "CompanyId", "InvoiceDate", "InvoiceType", "TotalValue" },
                values: new object[] { new Guid("2e9cad80-e35e-49f6-86b2-773a21a2c12b"), new Guid("9068efc6-4fff-4b02-bacc-da4dcc824bc0"), new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 10000.54m });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "CompanyId", "InvoiceDate", "InvoiceType", "TotalValue" },
                values: new object[] { new Guid("43ca38fe-4ba1-4b49-969e-aa2eea9b9ded"), new Guid("f7e575f9-3e93-4069-9b11-6a7a67516e05"), new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3589.54m });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "CompanyId", "InvoiceDate", "InvoiceType", "TotalValue" },
                values: new object[] { new Guid("07f548ae-01d3-40f0-82f0-1eb6c51e53bf"), new Guid("f7e575f9-3e93-4069-9b11-6a7a67516e05"), new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5687.54m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("764e24fc-81e2-4c5f-9657-bcdb8b40edd3"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("f64e04e4-3a68-461a-86d2-a34371b9ecc7"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("f827dbaf-f771-461f-9a35-979bcacfb968"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: new Guid("07f548ae-01d3-40f0-82f0-1eb6c51e53bf"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: new Guid("2e9cad80-e35e-49f6-86b2-773a21a2c12b"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: new Guid("43ca38fe-4ba1-4b49-969e-aa2eea9b9ded"));

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "LookupValueId",
                keyValue: new Guid("36808cca-c484-40e2-a458-bc7b4517ecdc"));

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "LookupValueId",
                keyValue: new Guid("74e6f414-ab2b-4f90-9dc1-77ba6b295c61"));

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "LookupValueId",
                keyValue: new Guid("7a5661df-27ed-4ab2-87c3-683903c05fa0"));

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "LookupValueId",
                keyValue: new Guid("a69f394f-c24f-4919-906e-9cc5ed2b5bed"));

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "LookupValueId",
                keyValue: new Guid("e718f9aa-9a18-426d-8c13-457e1bec9776"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("9068efc6-4fff-4b02-bacc-da4dcc824bc0"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("f7e575f9-3e93-4069-9b11-6a7a67516e05"));

            migrationBuilder.DropColumn(
                name: "AddressStreet",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "AddressUnitNumber",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Companies");

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "EIN", "Name" },
                values: new object[,]
                {
                    { new Guid("e9a600ef-aaf9-47cf-8d25-0926dd29298f"), 123456789, "AZ Tech" },
                    { new Guid("80a0c295-7775-4b2f-bba1-05033c5d33ad"), 100000001, "Brooklyn Trucks Inc." },
                    { new Guid("5a71a5a1-c7ae-4c0e-a6a0-416f4b0caab7"), 100000331, "Alt Solutions" },
                    { new Guid("ecbc3acf-3cf1-4415-94d5-2112ed585538"), 432451389, "3A Logistics" },
                    { new Guid("cf52cbe9-b506-423c-9d62-55c8a25ebcd6"), 432451399, "3B Logistics" }
                });

            migrationBuilder.InsertData(
                table: "LookupValue",
                columns: new[] { "LookupValueId", "LookupKey", "LookupText", "LookupType" },
                values: new object[,]
                {
                    { new Guid("1905c769-3e21-4357-b3f8-78cc85591e9d"), 0, "None", "InvoiceType" },
                    { new Guid("9ff1e123-9beb-49ea-9e56-f376936223db"), 1, "Credit", "InvoiceType" },
                    { new Guid("1b6501d6-89e9-47d7-82c9-12f4b898634d"), 2, "Debit", "InvoiceType" },
                    { new Guid("c24e292e-cd04-46ef-8785-38e65a79d84c"), 4, "Mixed", "InvoiceType" },
                    { new Guid("0780a2d7-4da4-48e4-be6e-f3cc5e31ebbf"), 8, "Commercial", "InvoiceType" }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "CompanyId", "InvoiceDate", "InvoiceType", "TotalValue" },
                values: new object[] { new Guid("fe5e1800-d848-474b-8ccd-0bb08246b2e8"), new Guid("e9a600ef-aaf9-47cf-8d25-0926dd29298f"), new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 10000.54m });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "CompanyId", "InvoiceDate", "InvoiceType", "TotalValue" },
                values: new object[] { new Guid("f1132f45-9435-4689-a260-00b95923ebc2"), new Guid("80a0c295-7775-4b2f-bba1-05033c5d33ad"), new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3589.54m });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "CompanyId", "InvoiceDate", "InvoiceType", "TotalValue" },
                values: new object[] { new Guid("c81d53c5-14fd-4cbd-b9e9-5859fb67113d"), new Guid("80a0c295-7775-4b2f-bba1-05033c5d33ad"), new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5687.54m });
        }
    }
}
