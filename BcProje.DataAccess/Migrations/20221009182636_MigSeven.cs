using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BcProje.DataAccess.Migrations
{
    public partial class MigSeven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DoctorName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoctorName",
                table: "Customers");
        }
    }
}
