using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyInvoiceSystem.WebApi.Migrations
{
    public partial class InitialDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "EIN", "Name" },
                values: new object[] { new Guid("3574ce85-dedb-4bd8-93b5-080963ef2019"), 123456789, "AZ Tech" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "EIN", "Name" },
                values: new object[] { new Guid("a775f9ca-b24e-4273-ac40-bb46e1a7d37a"), 100000001, "Brooklyn Trucks" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("3574ce85-dedb-4bd8-93b5-080963ef2019"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("a775f9ca-b24e-4273-ac40-bb46e1a7d37a"));
        }
    }
}
