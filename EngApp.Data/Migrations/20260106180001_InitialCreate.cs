using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EngApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Meaning = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    MySentence = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    DifficultyLevel = table.Column<int>(type: "int", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CorrectCount = table.Column<int>(type: "int", nullable: false),
                    WrongCount = table.Column<int>(type: "int", nullable: false),
                    ReviewCount = table.Column<int>(type: "int", nullable: false),
                    LastReviewedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Words_Text",
                table: "Words",
                column: "Text",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Words");
        }
    }
}
