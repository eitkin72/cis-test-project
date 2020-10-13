using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerInventory.WebApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    EIN = table.Column<int>(nullable: true),
                    IsDomestic = table.Column<bool>(nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateIndex(
                name: "INDEX_CUSTOMERS__CUSTOMER_NAME",
                table: "Customers",
                column: "Name",
                unique: true);

            migrationBuilder.Sql(@"CREATE PROCEDURE MyCustomProcedure
                               AS
                               SELECT * FROM Customers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.Sql(@"DROP PROCEDURE MyCustomProcedure");
        }
    }
}
