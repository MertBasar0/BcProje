using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BcProje.DataAccess.Migrations
{
    public partial class MigFour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Employees_EmployeeId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_SoldProduct_Products_ProductId",
                table: "SoldProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_SoldProduct_Sales_SaleId",
                table: "SoldProduct");

            migrationBuilder.DropIndex(
                name: "IX_Customers_EmployeeId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SoldProduct",
                table: "SoldProduct");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "SoldProduct",
                newName: "soldProducts");

            migrationBuilder.RenameIndex(
                name: "IX_SoldProduct_ProductId",
                table: "soldProducts",
                newName: "IX_soldProducts_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_soldProducts",
                table: "soldProducts",
                columns: new[] { "SaleId", "ProductId" });

            migrationBuilder.CreateTable(
                name: "EmployeeCustomers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCustomers", x => new { x.EmployeeId, x.CustomerId });
                    table.ForeignKey(
                        name: "FK_EmployeeCustomers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeCustomers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCustomers_CustomerId",
                table: "EmployeeCustomers",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_soldProducts_Products_ProductId",
                table: "soldProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_soldProducts_Sales_SaleId",
                table: "soldProducts",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "SaleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_soldProducts_Products_ProductId",
                table: "soldProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_soldProducts_Sales_SaleId",
                table: "soldProducts");

            migrationBuilder.DropTable(
                name: "EmployeeCustomers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_soldProducts",
                table: "soldProducts");

            migrationBuilder.RenameTable(
                name: "soldProducts",
                newName: "SoldProduct");

            migrationBuilder.RenameIndex(
                name: "IX_soldProducts_ProductId",
                table: "SoldProduct",
                newName: "IX_SoldProduct_ProductId");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SoldProduct",
                table: "SoldProduct",
                columns: new[] { "SaleId", "ProductId" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_EmployeeId",
                table: "Customers",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Employees_EmployeeId",
                table: "Customers",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SoldProduct_Products_ProductId",
                table: "SoldProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SoldProduct_Sales_SaleId",
                table: "SoldProduct",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "SaleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
