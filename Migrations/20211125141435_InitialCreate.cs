using Microsoft.EntityFrameworkCore.Migrations;

namespace MountainBikeTrailHeads.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trailhead",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    TrailCount = table.Column<int>(nullable: false),
                    TotalDistance = table.Column<int>(nullable: false),
                    TotalDescent = table.Column<int>(nullable: false),
                    CityNear = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longiture = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trailhead", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trailhead");
        }
    }
}
