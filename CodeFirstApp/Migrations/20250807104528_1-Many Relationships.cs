using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstApp.Migrations
{
    /// <inheritdoc />
    public partial class _1ManyRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "category",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "catid",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_catid",
                table: "Products",
                column: "catid");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_catid",
                table: "Products",
                column: "catid",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_catid",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_catid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "catid",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
