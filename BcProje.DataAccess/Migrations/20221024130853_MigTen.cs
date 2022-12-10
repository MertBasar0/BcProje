using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BcProje.DataAccess.Migrations
{
    public partial class MigTen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleProducts_Employees_EmployeeId",
                table: "SaleProducts");

            migrationBuilder.DropIndex(
                name: "IX_SaleProducts_EmployeeId",
                table: "SaleProducts");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "SaleProducts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "SaleProducts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SaleProducts_EmployeeId",
                table: "SaleProducts",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleProducts_Employees_EmployeeId",
                table: "SaleProducts",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }
    }
}
