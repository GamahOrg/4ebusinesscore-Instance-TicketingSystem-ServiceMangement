using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _4EPlatForm.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddRequestersFlagToModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CanBeRequestedByAllUsers",
                table: "ServiceCatalogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanBeRequestedByAllUsers",
                table: "MainClassifications",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanBeRequestedByAllUsers",
                table: "Items",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanBeRequestedByAllUsers",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CanBeRequestedByAllUsers",
                table: "ServiceCatalogs");

            migrationBuilder.DropColumn(
                name: "CanBeRequestedByAllUsers",
                table: "MainClassifications");

            migrationBuilder.DropColumn(
                name: "CanBeRequestedByAllUsers",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CanBeRequestedByAllUsers",
                table: "Categories");
        }
    }
}
