using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exercice01_Adresses.Migrations
{
    public partial class StreetNumberIntToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "street_number",
                table: "addresse",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "addresse",
                keyColumn: "id",
                keyValue: 1,
                column: "street_number",
                value: "15");

            migrationBuilder.UpdateData(
                table: "addresse",
                keyColumn: "id",
                keyValue: 2,
                column: "street_number",
                value: "45");

            migrationBuilder.UpdateData(
                table: "addresse",
                keyColumn: "id",
                keyValue: 3,
                column: "street_number",
                value: "12");

            migrationBuilder.UpdateData(
                table: "addresse",
                keyColumn: "id",
                keyValue: 4,
                column: "street_number",
                value: "22");

            migrationBuilder.UpdateData(
                table: "addresse",
                keyColumn: "id",
                keyValue: 5,
                column: "street_number",
                value: "15");

            migrationBuilder.UpdateData(
                table: "addresse",
                keyColumn: "id",
                keyValue: 6,
                column: "street_number",
                value: "58");

            migrationBuilder.UpdateData(
                table: "addresse",
                keyColumn: "id",
                keyValue: 7,
                column: "street_number",
                value: "89");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "street_number",
                table: "addresse",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "addresse",
                keyColumn: "id",
                keyValue: 1,
                column: "street_number",
                value: 15);

            migrationBuilder.UpdateData(
                table: "addresse",
                keyColumn: "id",
                keyValue: 2,
                column: "street_number",
                value: 45);

            migrationBuilder.UpdateData(
                table: "addresse",
                keyColumn: "id",
                keyValue: 3,
                column: "street_number",
                value: 12);

            migrationBuilder.UpdateData(
                table: "addresse",
                keyColumn: "id",
                keyValue: 4,
                column: "street_number",
                value: 22);

            migrationBuilder.UpdateData(
                table: "addresse",
                keyColumn: "id",
                keyValue: 5,
                column: "street_number",
                value: 15);

            migrationBuilder.UpdateData(
                table: "addresse",
                keyColumn: "id",
                keyValue: 6,
                column: "street_number",
                value: 58);

            migrationBuilder.UpdateData(
                table: "addresse",
                keyColumn: "id",
                keyValue: 7,
                column: "street_number",
                value: 89);
        }
    }
}
