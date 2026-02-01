using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EngApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPartOfSpeech : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PartOfSpeech",
                table: "Words",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "Unknown");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PartOfSpeech",
                table: "Words");
        }
    }
}
