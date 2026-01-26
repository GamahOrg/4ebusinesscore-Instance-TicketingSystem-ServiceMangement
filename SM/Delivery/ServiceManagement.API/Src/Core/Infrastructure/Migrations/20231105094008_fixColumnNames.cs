using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _4EPlatForm.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixColumnNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TechniciaId",
                table: "ItemTechnicians",
                newName: "TechnicianId");

            migrationBuilder.RenameColumn(
                name: "TechniciaId",
                table: "CategoryTechnicians",
                newName: "TechnicianId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TechnicianId",
                table: "ItemTechnicians",
                newName: "TechniciaId");

            migrationBuilder.RenameColumn(
                name: "TechnicianId",
                table: "CategoryTechnicians",
                newName: "TechniciaId");
        }
    }
}
