using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieSearchAPI.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_List_WatchList_WatchListId",
                table: "List");

            migrationBuilder.DropForeignKey(
                name: "FK_WatchList_Movie_MovieId",
                table: "WatchList");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_List_WatchListId",
                table: "List");

            migrationBuilder.DropColumn(
                name: "WatchListId",
                table: "List");

            migrationBuilder.AlterColumn<Guid>(
                name: "MovieId",
                table: "WatchList",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ListId",
                table: "WatchList",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "UserData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserData", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WatchList_ListId",
                table: "WatchList",
                column: "ListId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WatchList_List_ListId",
                table: "WatchList");

            migrationBuilder.DropForeignKey(
                name: "FK_WatchList_Movie_MovieId",
                table: "WatchList");

            migrationBuilder.DropTable(
                name: "UserData");

            migrationBuilder.DropIndex(
                name: "IX_WatchList_ListId",
                table: "WatchList");

            migrationBuilder.DropColumn(
                name: "ListId",
                table: "WatchList");

            migrationBuilder.AlterColumn<Guid>(
                name: "MovieId",
                table: "WatchList",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "WatchListId",
                table: "List",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserEmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_List_WatchListId",
                table: "List",
                column: "WatchListId");

            migrationBuilder.AddForeignKey(
                name: "FK_List_WatchList_WatchListId",
                table: "List",
                column: "WatchListId",
                principalTable: "WatchList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WatchList_Movie_MovieId",
                table: "WatchList",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
