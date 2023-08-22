using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exercice01_Adresses.Migrations
{
    public partial class TablesAndColumnsNameChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adresses");

            migrationBuilder.CreateTable(
                name: "addresse",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    street_number = table.Column<int>(type: "int", nullable: false),
                    street_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    additional_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    postal_code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresse", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "addresse",
                columns: new[] { "id", "additional_address", "city", "postal_code", "street_name", "street_number" },
                values: new object[,]
                {
                    { 1, null, "Maz", "62670", "rue de la sorbonne", 15 },
                    { 2, null, "Paris", "75000", "Avenue du poulet", 45 },
                    { 3, null, "Marseille", "13000", "rue Victor Hugo", 12 },
                    { 4, null, "Lens", "62800", "Boulevard des coqs", 22 },
                    { 5, null, "Arras", "62000", "rue du sapin", 15 },
                    { 6, null, "Lille", "59000", "rue des choux", 58 },
                    { 7, null, "Maz", "62670", "rue Vigny", 89 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "addresse");

            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdditionalAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Adresses",
                columns: new[] { "Id", "AdditionalAddress", "City", "PostalCode", "StreetName", "StreetNumber" },
                values: new object[,]
                {
                    { 1, null, "Maz", "62670", "rue de la sorbonne", 15 },
                    { 2, null, "Paris", "75000", "Avenue du poulet", 45 },
                    { 3, null, "Marseille", "13000", "rue Victor Hugo", 12 },
                    { 4, null, "Lens", "62800", "Boulevard des coqs", 22 },
                    { 5, null, "Arras", "62000", "rue du sapin", 15 },
                    { 6, null, "Lille", "59000", "rue des choux", 58 },
                    { 7, null, "Maz", "62670", "rue Vigny", 89 }
                });
        }
    }
}
