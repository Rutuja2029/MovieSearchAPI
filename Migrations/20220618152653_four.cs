using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieSearchAPI.Migrations
{
    public partial class four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ListName",
                table: "WatchList",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListName",
                table: "WatchList");
        }
    }
}
