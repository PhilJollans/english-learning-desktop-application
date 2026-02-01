using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EngApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSpacedRepetition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "EaseFactor",
                table: "Words",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Interval",
                table: "Words",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsNew",
                table: "Words",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "NextReviewDate",
                table: "Words",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Repetitions",
                table: "Words",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EaseFactor",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "Interval",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "IsNew",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "NextReviewDate",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "Repetitions",
                table: "Words");
        }
    }
}
