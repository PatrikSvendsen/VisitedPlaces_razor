using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisitedPlaces_razor.Migrations
{
    public partial class AddedMoreDataContinents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "ContinentId", "Name", "Population" },
                values: new object[,]
                {
                    { 3, "Africa", 1275920972L },
                    { 4, "North America", 592296233L },
                    { 5, "South America", 423581078L },
                    { 6, "Antarctica", 1000L },
                    { 7, "Oceania", 41570842L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 7);
        }
    }
}
