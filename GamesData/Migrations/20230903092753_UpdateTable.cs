using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesData.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Developer",
                table: "Games",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Games",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Platforms",
                table: "Games",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RatingOnMetacritic",
                table: "Games",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Update",
                table: "Games",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "YearOfRelease",
                table: "Games",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Developer",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Platforms",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "RatingOnMetacritic",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Update",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "YearOfRelease",
                table: "Games");
        }
    }
}
