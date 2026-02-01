using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EngApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUniqueIndexOnWordText : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Words_Text",
                table: "Words");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Words_Text",
                table: "Words",
                column: "Text",
                unique: true);
        }
    }
}
