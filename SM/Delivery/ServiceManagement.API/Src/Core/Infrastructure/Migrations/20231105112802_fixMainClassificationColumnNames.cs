using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _4EPlatForm.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixMainClassificationColumnNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TechniciaId",
                table: "ServiceCatalogTechnicians",
                newName: "TechnicianId");

            migrationBuilder.RenameColumn(
                name: "TechniciaId",
                table: "MainClassificationTechnicians",
                newName: "TechnicianId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TechnicianId",
                table: "ServiceCatalogTechnicians",
                newName: "TechniciaId");

            migrationBuilder.RenameColumn(
                name: "TechnicianId",
                table: "MainClassificationTechnicians",
                newName: "TechniciaId");
        }
    }
}
