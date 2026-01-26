using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _4EPlatForm.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class removeModelMembersUniqueness : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ServiceCatalogTechnicians_ServiceCatalogId_TechnicianId",
                table: "ServiceCatalogTechnicians");

            migrationBuilder.DropIndex(
                name: "IX_ServiceCatalogRequesters_ServiceCatalogId_RequesterId",
                table: "ServiceCatalogRequesters");

            migrationBuilder.DropIndex(
                name: "IX_MainClassificationTechnicians_MainClassificationId_TechnicianId",
                table: "MainClassificationTechnicians");

            migrationBuilder.DropIndex(
                name: "IX_MainClassificationRequesters_MainClassificationId_RequesterId",
                table: "MainClassificationRequesters");

            migrationBuilder.DropIndex(
                name: "IX_ItemTechnicians_ItemId_TechnicianId",
                table: "ItemTechnicians");

            migrationBuilder.DropIndex(
                name: "IX_ItemRequesters_ItemId_RequesterId",
                table: "ItemRequesters");

            migrationBuilder.DropIndex(
                name: "IX_CategoryTechnicians_CategoryId_TechnicianId",
                table: "CategoryTechnicians");

            migrationBuilder.DropIndex(
                name: "IX_CategoryRequesters_CategoryId_RequesterId",
                table: "CategoryRequesters");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceCatalogTechnicians_ServiceCatalogId",
                table: "ServiceCatalogTechnicians",
                column: "ServiceCatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceCatalogRequesters_ServiceCatalogId",
                table: "ServiceCatalogRequesters",
                column: "ServiceCatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_MainClassificationTechnicians_MainClassificationId",
                table: "MainClassificationTechnicians",
                column: "MainClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_MainClassificationRequesters_MainClassificationId",
                table: "MainClassificationRequesters",
                column: "MainClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTechnicians_ItemId",
                table: "ItemTechnicians",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemRequesters_ItemId",
                table: "ItemRequesters",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTechnicians_CategoryId",
                table: "CategoryTechnicians",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryRequesters_CategoryId",
                table: "CategoryRequesters",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ServiceCatalogTechnicians_ServiceCatalogId",
                table: "ServiceCatalogTechnicians");

            migrationBuilder.DropIndex(
                name: "IX_ServiceCatalogRequesters_ServiceCatalogId",
                table: "ServiceCatalogRequesters");

            migrationBuilder.DropIndex(
                name: "IX_MainClassificationTechnicians_MainClassificationId",
                table: "MainClassificationTechnicians");

            migrationBuilder.DropIndex(
                name: "IX_MainClassificationRequesters_MainClassificationId",
                table: "MainClassificationRequesters");

            migrationBuilder.DropIndex(
                name: "IX_ItemTechnicians_ItemId",
                table: "ItemTechnicians");

            migrationBuilder.DropIndex(
                name: "IX_ItemRequesters_ItemId",
                table: "ItemRequesters");

            migrationBuilder.DropIndex(
                name: "IX_CategoryTechnicians_CategoryId",
                table: "CategoryTechnicians");

            migrationBuilder.DropIndex(
                name: "IX_CategoryRequesters_CategoryId",
                table: "CategoryRequesters");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceCatalogTechnicians_ServiceCatalogId_TechnicianId",
                table: "ServiceCatalogTechnicians",
                columns: new[] { "ServiceCatalogId", "TechnicianId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceCatalogRequesters_ServiceCatalogId_RequesterId",
                table: "ServiceCatalogRequesters",
                columns: new[] { "ServiceCatalogId", "RequesterId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MainClassificationTechnicians_MainClassificationId_TechnicianId",
                table: "MainClassificationTechnicians",
                columns: new[] { "MainClassificationId", "TechnicianId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MainClassificationRequesters_MainClassificationId_RequesterId",
                table: "MainClassificationRequesters",
                columns: new[] { "MainClassificationId", "RequesterId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemTechnicians_ItemId_TechnicianId",
                table: "ItemTechnicians",
                columns: new[] { "ItemId", "TechnicianId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemRequesters_ItemId_RequesterId",
                table: "ItemRequesters",
                columns: new[] { "ItemId", "RequesterId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTechnicians_CategoryId_TechnicianId",
                table: "CategoryTechnicians",
                columns: new[] { "CategoryId", "TechnicianId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoryRequesters_CategoryId_RequesterId",
                table: "CategoryRequesters",
                columns: new[] { "CategoryId", "RequesterId" },
                unique: true);
        }
    }
}
