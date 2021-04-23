using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieLover.Data.Migrations
{
    public partial class fixsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Score",
                table: "Movie",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "Movie",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
