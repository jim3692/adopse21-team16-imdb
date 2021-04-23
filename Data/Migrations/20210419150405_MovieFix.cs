using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieLover.Data.Migrations
{
    public partial class MovieFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cover",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Movie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cover",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Movie");
        }
    }
}
