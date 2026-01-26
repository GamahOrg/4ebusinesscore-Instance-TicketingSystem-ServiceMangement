using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _4EPlatForm.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IsIintegrated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsIintegrated",
                table: "Items",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WorkspaceServiceID",
                table: "Items",
                type: "uniqueidentifier",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsIintegrated",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "WorkspaceServiceID",
                table: "Items");
        }
    }
}
