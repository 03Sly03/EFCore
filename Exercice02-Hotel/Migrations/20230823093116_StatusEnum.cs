using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exercice02_Hotel.Migrations
{
    public partial class StatusEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "room",
                keyColumn: "id",
                keyValue: 2,
                column: "status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "room",
                keyColumn: "id",
                keyValue: 3,
                column: "status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "room",
                keyColumn: "id",
                keyValue: 4,
                column: "status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "room",
                keyColumn: "id",
                keyValue: 5,
                column: "status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "room",
                keyColumn: "id",
                keyValue: 6,
                column: "status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "room",
                keyColumn: "id",
                keyValue: 7,
                column: "status",
                value: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "room",
                keyColumn: "id",
                keyValue: 2,
                column: "status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "room",
                keyColumn: "id",
                keyValue: 3,
                column: "status",
                value: 3);

            migrationBuilder.UpdateData(
                table: "room",
                keyColumn: "id",
                keyValue: 4,
                column: "status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "room",
                keyColumn: "id",
                keyValue: 5,
                column: "status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "room",
                keyColumn: "id",
                keyValue: 6,
                column: "status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "room",
                keyColumn: "id",
                keyValue: 7,
                column: "status",
                value: 3);
        }
    }
}
