using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _4EPlatForm.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addLangEn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CatalogDescriptionEn",
                table: "MainClassificationtTitleDetailes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryDescriptionEn",
                table: "MainClassificationtTitleDetailes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemDescriptionEn",
                table: "MainClassificationtTitleDetailes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainClassificationDescriptionEn",
                table: "MainClassificationtTitleDetailes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubjectDescriptionEn",
                table: "MainClassificationtTitleDetailes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleDescriptionEn",
                table: "MainClassificationtTitleDetailes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleEn",
                table: "MainClassificationtTitleDetailes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CatalogDescriptionEn",
                table: "MainClassificationtTitleDetailes");

            migrationBuilder.DropColumn(
                name: "CategoryDescriptionEn",
                table: "MainClassificationtTitleDetailes");

            migrationBuilder.DropColumn(
                name: "ItemDescriptionEn",
                table: "MainClassificationtTitleDetailes");

            migrationBuilder.DropColumn(
                name: "MainClassificationDescriptionEn",
                table: "MainClassificationtTitleDetailes");

            migrationBuilder.DropColumn(
                name: "SubjectDescriptionEn",
                table: "MainClassificationtTitleDetailes");

            migrationBuilder.DropColumn(
                name: "TitleDescriptionEn",
                table: "MainClassificationtTitleDetailes");

            migrationBuilder.DropColumn(
                name: "TitleEn",
                table: "MainClassificationtTitleDetailes");
        }
    }
}
