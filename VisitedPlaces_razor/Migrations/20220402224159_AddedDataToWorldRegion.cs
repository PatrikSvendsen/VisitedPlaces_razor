using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisitedPlaces_razor.Migrations
{
    public partial class AddedDataToWorldRegion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WorldRegions",
                columns: new[] { "WorldRegionId", "Name", "Population" },
                values: new object[] { 1, "Asia", 4400000000L });

            migrationBuilder.InsertData(
                table: "WorldRegions",
                columns: new[] { "WorldRegionId", "Name", "Population" },
                values: new object[] { 2, "Europe", 746419440L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorldRegions",
                keyColumn: "WorldRegionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WorldRegions",
                keyColumn: "WorldRegionId",
                keyValue: 2);
        }
    }
}
