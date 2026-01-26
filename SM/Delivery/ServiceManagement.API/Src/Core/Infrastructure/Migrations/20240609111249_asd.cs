using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _4EPlatForm.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class asd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_electronicsServicesMainclassiffcation",
                table: "electronicsServicesMainclassiffcation");

            migrationBuilder.DropIndex(
                name: "IX_electronicsServicesMainclassiffcation_MainClassificationId",
                table: "electronicsServicesMainclassiffcation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_electronicsServicesMainclassiffcation",
                table: "electronicsServicesMainclassiffcation",
                columns: new[] { "MainClassificationId", "electronicsServicesId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_electronicsServicesMainclassiffcation",
                table: "electronicsServicesMainclassiffcation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_electronicsServicesMainclassiffcation",
                table: "electronicsServicesMainclassiffcation",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_electronicsServicesMainclassiffcation_MainClassificationId",
                table: "electronicsServicesMainclassiffcation",
                column: "MainClassificationId");
        }
    }
}
