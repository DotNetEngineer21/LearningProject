using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreOSR.Migrations
{
    public partial class Add_Employee_Updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Employee",
                nullable: false,
                defaultValue: 0);
        }
    }
}
