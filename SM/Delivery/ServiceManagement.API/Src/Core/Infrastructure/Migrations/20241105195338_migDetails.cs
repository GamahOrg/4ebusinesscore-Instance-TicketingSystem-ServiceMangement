using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _4EPlatForm.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class migDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainClassificationtTitleDetailes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainClassificationDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatalogDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultCheck = table.Column<bool>(type: "bit", nullable: true),
                    ServiceType = table.Column<int>(type: "int", nullable: false),
                    MainClassificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainClassificationtTitleDetailes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainClassificationtTitleDetailes_MainClassifications_MainClassificationId",
                        column: x => x.MainClassificationId,
                        principalTable: "MainClassifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MainClassificationtTitleDetailes_MainClassificationId",
                table: "MainClassificationtTitleDetailes",
                column: "MainClassificationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainClassificationtTitleDetailes");
        }
    }
}
