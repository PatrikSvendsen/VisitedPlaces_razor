using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisitedPlaces_razor.Migrations
{
    public partial class FixedNameConventioninCountryclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Continents_WorldRegionId",
                table: "Countries");

            migrationBuilder.RenameColumn(
                name: "WorldRegionId",
                table: "Countries",
                newName: "ContinentId");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_WorldRegionId",
                table: "Countries",
                newName: "IX_Countries_ContinentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Continents_ContinentId",
                table: "Countries",
                column: "ContinentId",
                principalTable: "Continents",
                principalColumn: "ContinentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Continents_ContinentId",
                table: "Countries");

            migrationBuilder.RenameColumn(
                name: "ContinentId",
                table: "Countries",
                newName: "WorldRegionId");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_ContinentId",
                table: "Countries",
                newName: "IX_Countries_WorldRegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Continents_WorldRegionId",
                table: "Countries",
                column: "WorldRegionId",
                principalTable: "Continents",
                principalColumn: "ContinentId");
        }
    }
}
