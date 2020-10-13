using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyInvoiceSystem.WebApi.Migrations
{
    public partial class UseMigrationConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("3574ce85-dedb-4bd8-93b5-080963ef2019"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("a775f9ca-b24e-4273-ac40-bb46e1a7d37a"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "EIN", "Name" },
                values: new object[] { new Guid("3574ce85-dedb-4bd8-93b5-080963ef2019"), 123456789, "AZ Tech" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "EIN", "Name" },
                values: new object[] { new Guid("a775f9ca-b24e-4273-ac40-bb46e1a7d37a"), 100000001, "Brooklyn Trucks" });
        }
    }
}
