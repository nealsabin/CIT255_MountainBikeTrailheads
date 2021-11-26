using Microsoft.EntityFrameworkCore.Migrations;

namespace MountainBikeTrailHeads.Migrations
{
    public partial class TypoFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Longiture",
                table: "Trailhead");

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Trailhead",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Trailhead");

            migrationBuilder.AddColumn<double>(
                name: "Longiture",
                table: "Trailhead",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
