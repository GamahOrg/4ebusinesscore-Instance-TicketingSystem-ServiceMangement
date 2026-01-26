using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _4EPlatForm.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editMainClassification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminName",
                table: "MainClassifications");

            migrationBuilder.AddColumn<Guid>(
                name: "Admin",
                table: "MainClassifications",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Admin",
                table: "MainClassifications");

            migrationBuilder.AddColumn<string>(
                name: "AdminName",
                table: "MainClassifications",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
