using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisitedPlaces_razor.Migrations
{
    public partial class AddedandRemovedpropertieswithinallClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryRegions_Countries_CountryId",
                table: "CountryRegions");

            migrationBuilder.DropColumn(
                name: "Population",
                table: "CountryRegions");

            migrationBuilder.DropColumn(
                name: "Population",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "SecondLanguage",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Population",
                table: "Continents");

            migrationBuilder.DropColumn(
                name: "Population",
                table: "Cities");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "CountryRegions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "IsCapital",
                table: "Cities",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "BestMemory",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryRegions_Countries_CountryId",
                table: "CountryRegions",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryRegions_Countries_CountryId",
                table: "CountryRegions");

            migrationBuilder.DropColumn(
                name: "BestMemory",
                table: "Cities");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "CountryRegions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Population",
                table: "CountryRegions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Population",
                table: "Countries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondLanguage",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Population",
                table: "Continents",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsCapital",
                table: "Cities",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Population",
                table: "Cities",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 1,
                column: "Population",
                value: 4400000000L);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 2,
                column: "Population",
                value: 746419440L);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 3,
                column: "Population",
                value: 1275920972L);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 4,
                column: "Population",
                value: 592296233L);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 5,
                column: "Population",
                value: 423581078L);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 6,
                column: "Population",
                value: 1000L);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 7,
                column: "Population",
                value: 41570842L);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryRegions_Countries_CountryId",
                table: "CountryRegions",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
