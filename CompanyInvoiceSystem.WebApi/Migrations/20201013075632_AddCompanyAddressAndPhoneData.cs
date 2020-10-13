using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyInvoiceSystem.WebApi.Migrations
{
    public partial class AddCompanyAddressAndPhoneData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "AddressStreet", "AddressUnitNumber", "City", "EIN", "Name", "PhoneNumber", "State", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("00e629dd-4728-47b7-a4cc-8ec2ec1bd578"), "100 Main St", "12 Floor", "New York", 123456789, "AZ Tech", "212-500-5000", "NY", "10002" },
                    { new Guid("402f8243-c49e-415f-80c9-e4fa960be72f"), "100 Coyle St", "#10", "New York", 100000001, "Brooklyn Trucks Inc.", "212-300-3000", "NY", "10012" },
                    { new Guid("97db1d64-348a-4b3f-aa65-3464da8be0ad"), "112 Adams St", "Unit 101", "New York", 100000331, "Alt Solutions", "212-200-2000", "NY", "10012" },
                    { new Guid("00483bda-812d-450d-8a9a-d8d02ce0a0d8"), null, null, null, 432451389, "3A Logistics", "333-533-3333", null, null },
                    { new Guid("a4293a2a-6dda-4d44-a07c-38ffc27bc485"), null, null, null, 432451399, "3B Logistics", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "LookupValue",
                columns: new[] { "LookupValueId", "LookupKey", "LookupText", "LookupType" },
                values: new object[,]
                {
                    { new Guid("d883a416-567b-4214-832c-55725541abc0"), 0, "None", "InvoiceType" },
                    { new Guid("f5da5828-53a7-4f99-9730-c81fd6f03ee4"), 1, "Credit", "InvoiceType" },
                    { new Guid("67b0e591-18c5-4878-9eae-07d70b41bd33"), 2, "Debit", "InvoiceType" },
                    { new Guid("02bad192-acc7-4392-900f-2d7c4abba52f"), 4, "Mixed", "InvoiceType" },
                    { new Guid("a7f4aeb1-9d7e-4ef6-b38e-b0f6836ffd58"), 8, "Commercial", "InvoiceType" }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "CompanyId", "InvoiceDate", "InvoiceType", "TotalValue" },
                values: new object[] { new Guid("53c31f39-af20-4d36-b9f5-6970c62a0db7"), new Guid("00e629dd-4728-47b7-a4cc-8ec2ec1bd578"), new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 10000.54m });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "CompanyId", "InvoiceDate", "InvoiceType", "TotalValue" },
                values: new object[] { new Guid("54598cb0-62fb-4be2-bb17-9a2706518bfa"), new Guid("402f8243-c49e-415f-80c9-e4fa960be72f"), new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3589.54m });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "InvoiceId", "CompanyId", "InvoiceDate", "InvoiceType", "TotalValue" },
                values: new object[] { new Guid("29ec7d04-fade-4443-b4ca-810710eff715"), new Guid("402f8243-c49e-415f-80c9-e4fa960be72f"), new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5687.54m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("00483bda-812d-450d-8a9a-d8d02ce0a0d8"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("97db1d64-348a-4b3f-aa65-3464da8be0ad"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("a4293a2a-6dda-4d44-a07c-38ffc27bc485"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: new Guid("29ec7d04-fade-4443-b4ca-810710eff715"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: new Guid("53c31f39-af20-4d36-b9f5-6970c62a0db7"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "InvoiceId",
                keyValue: new Guid("54598cb0-62fb-4be2-bb17-9a2706518bfa"));

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "LookupValueId",
                keyValue: new Guid("02bad192-acc7-4392-900f-2d7c4abba52f"));

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "LookupValueId",
                keyValue: new Guid("67b0e591-18c5-4878-9eae-07d70b41bd33"));

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "LookupValueId",
                keyValue: new Guid("a7f4aeb1-9d7e-4ef6-b38e-b0f6836ffd58"));

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "LookupValueId",
                keyValue: new Guid("d883a416-567b-4214-832c-55725541abc0"));

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "LookupValueId",
                keyValue: new Guid("f5da5828-53a7-4f99-9730-c81fd6f03ee4"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("00e629dd-4728-47b7-a4cc-8ec2ec1bd578"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("402f8243-c49e-415f-80c9-e4fa960be72f"));

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
    }
}
