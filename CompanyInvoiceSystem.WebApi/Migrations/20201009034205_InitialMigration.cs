using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyInvoiceSystem.WebApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    EIN = table.Column<int>(nullable: true),
                    IsDomestic = table.Column<bool>(nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateIndex(
                name: "INDEX_Companies__Company_NAME",
                table: "Companies",
                column: "Name",
                unique: true);

            migrationBuilder.Sql(@"CREATE PROCEDURE GetCompanies
                               AS
                               SELECT * FROM Companies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.Sql(@"DROP PROCEDURE GetCompanies");
        }
    }
}
