using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisitedPlaces_razor.Migrations
{
    public partial class ChangeWorldRegionsToContinents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_WorldRegions_WorldRegionId",
                table: "Countries");

            migrationBuilder.DropTable(
                name: "WorldRegions");

            migrationBuilder.CreateTable(
                name: "Continents",
                columns: table => new
                {
                    ContinentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Population = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continents", x => x.ContinentId);
                });

            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "ContinentId", "Name", "Population" },
                values: new object[] { 1, "Asia", 4400000000L });

            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "ContinentId", "Name", "Population" },
                values: new object[] { 2, "Europe", 746419440L });

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Continents_WorldRegionId",
                table: "Countries",
                column: "WorldRegionId",
                principalTable: "Continents",
                principalColumn: "ContinentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Continents_WorldRegionId",
                table: "Countries");

            migrationBuilder.DropTable(
                name: "Continents");

            migrationBuilder.CreateTable(
                name: "WorldRegions",
                columns: table => new
                {
                    WorldRegionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Population = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorldRegions", x => x.WorldRegionId);
                });

            migrationBuilder.InsertData(
                table: "WorldRegions",
                columns: new[] { "WorldRegionId", "Name", "Population" },
                values: new object[] { 1, "Asia", 4400000000L });

            migrationBuilder.InsertData(
                table: "WorldRegions",
                columns: new[] { "WorldRegionId", "Name", "Population" },
                values: new object[] { 2, "Europe", 746419440L });

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_WorldRegions_WorldRegionId",
                table: "Countries",
                column: "WorldRegionId",
                principalTable: "WorldRegions",
                principalColumn: "WorldRegionId");
        }
    }
}
