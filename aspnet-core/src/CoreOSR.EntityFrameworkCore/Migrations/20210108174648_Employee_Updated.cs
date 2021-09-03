using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreOSR.Migrations
{
    public partial class Employee_Updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ReportsTo",
                table: "Employee",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ReportsTo",
                table: "Employee",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
