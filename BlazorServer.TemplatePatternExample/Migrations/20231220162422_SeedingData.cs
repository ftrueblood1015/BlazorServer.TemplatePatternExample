using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServer.TemplatePatternExample.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "Department", "Description", "IsActive", "Name" },
                values: new object[] { 1, "IT", "IT Manager", true, "Billy " });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Description", "IsActive", "ManagerId", "Name" },
                values: new object[] { 1, "IT", "IT Employee", true, 1, "Bob" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Description", "IsActive", "ManagerId", "Name" },
                values: new object[] { 2, "IT", "IT Employee", true, 1, "Thorton" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
