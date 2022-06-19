using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieSearchAPI.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WatchList_List_ListId",
                table: "WatchList");

            migrationBuilder.DropForeignKey(
                name: "FK_WatchList_Movie_MovieId",
                table: "WatchList");

            migrationBuilder.DropIndex(
                name: "IX_WatchList_ListId",
                table: "WatchList");

            migrationBuilder.DropIndex(
                name: "IX_WatchList_MovieId",
                table: "WatchList");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_WatchList_ListId",
                table: "WatchList",
                column: "ListId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchList_MovieId",
                table: "WatchList",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_WatchList_List_ListId",
                table: "WatchList",
                column: "ListId",
                principalTable: "List",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WatchList_Movie_MovieId",
                table: "WatchList",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
