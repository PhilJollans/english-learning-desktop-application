using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EngApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDifficultyLevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DifficultyLevel",
                table: "Words");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DifficultyLevel",
                table: "Words",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
