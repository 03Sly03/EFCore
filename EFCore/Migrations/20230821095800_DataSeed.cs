using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo01.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "Firstname", "Lastname", "Phone" },
                values: new object[] { 1000, "john@doe.com", "John", "Doe", "0101010101" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1000);
        }
    }
}
