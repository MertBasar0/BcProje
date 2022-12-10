using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BcProje.DataAccess.Migrations
{
    public partial class MigNine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Sales_SaleId",
                table: "Visits");

            migrationBuilder.DropIndex(
                name: "IX_Visits_SaleId",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "SaleId",
                table: "Visits");

            migrationBuilder.AddColumn<int>(
                name: "VisitId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_VisitId",
                table: "Sales",
                column: "VisitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Visits_VisitId",
                table: "Sales",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "VisitId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Visits_VisitId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_VisitId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "VisitId",
                table: "Sales");

            migrationBuilder.AddColumn<int>(
                name: "SaleId",
                table: "Visits",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Visits_SaleId",
                table: "Visits",
                column: "SaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Sales_SaleId",
                table: "Visits",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "SaleId");
        }
    }
}
