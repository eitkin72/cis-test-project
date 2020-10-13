using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyInvoiceSystem.WebApi.Migrations
{
    public partial class InvoicesTablesAndRelationshipAndSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("2ea2b7af-6fbc-4f56-a275-c124b7acf7c9"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("ae860ae3-9120-4b12-9cc1-a6e1396814ef"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("d99f9213-ddb9-4ea2-bcc6-3e411a78d9bd"));

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<Guid>(nullable: false),
                    InvoiceDate = table.Column<DateTime>(nullable: false),
                    InvoiceType = table.Column<int>(nullable: false),
                    TotalValue = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CompanyId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_Invoices_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LookupValue",
                columns: table => new
                {
                    LookupValueId = table.Column<Guid>(nullable: false),
                    LookupType = table.Column<string>(nullable: false),
                    LookupText = table.Column<string>(nullable: false),
                    LookupKey = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupValue", x => x.LookupValueId);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CompanyId",
                table: "Invoices",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "LookupValue");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("5a71a5a1-c7ae-4c0e-a6a0-416f4b0caab7"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("80a0c295-7775-4b2f-bba1-05033c5d33ad"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("cf52cbe9-b506-423c-9d62-55c8a25ebcd6"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("e9a600ef-aaf9-47cf-8d25-0926dd29298f"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("ecbc3acf-3cf1-4415-94d5-2112ed585538"));

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "EIN", "Name" },
                values: new object[] { new Guid("ae860ae3-9120-4b12-9cc1-a6e1396814ef"), 123456789, "AZ Tech" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "EIN", "Name" },
                values: new object[] { new Guid("2ea2b7af-6fbc-4f56-a275-c124b7acf7c9"), 100000001, "Brooklyn Trucks Inc." });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "EIN", "Name" },
                values: new object[] { new Guid("d99f9213-ddb9-4ea2-bcc6-3e411a78d9bd"), 100000331, "Alt Solutions" });
        }
    }
}
