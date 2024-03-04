using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traversal.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Core_Conrete_Add_Reservation_Entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Destinations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_AppUserId",
                table: "Destinations",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_AspNetUsers_AppUserId",
                table: "Destinations",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_AspNetUsers_AppUserId",
                table: "Destinations");

            migrationBuilder.DropIndex(
                name: "IX_Destinations_AppUserId",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Destinations");
        }
    }
}
