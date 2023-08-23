using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exercice02_Hotel.Migrations
{
    public partial class DataSeedClientsRooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "client",
                columns: new[] { "id", "firstname", "lastname", "phone" },
                values: new object[,]
                {
                    { 1, "Alberto", "Enrique", "0612234578" },
                    { 2, "Marcel", "Patoulacy", "1234567890" },
                    { 3, "Edwardo", "Sanchez", "9876543210" },
                    { 4, "Jane", "Doe", "0689564578" },
                    { 5, "Sahra", "New", "0789564512" }
                });

            migrationBuilder.InsertData(
                table: "room",
                columns: new[] { "id", "number_of_bed", "price", "status" },
                values: new object[,]
                {
                    { 1, 2, 44.99m, 1 },
                    { 2, 1, 31.99m, 2 },
                    { 3, 1, 31.99m, 3 },
                    { 4, 1, 31.99m, 2 },
                    { 5, 1, 31.99m, 2 },
                    { 6, 2, 44.99m, 2 },
                    { 7, 2, 44.99m, 3 },
                    { 8, 3, 64.99m, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "client",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "room",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "room",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "room",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "room",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "room",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "room",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "room",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "room",
                keyColumn: "id",
                keyValue: 8);
        }
    }
}
