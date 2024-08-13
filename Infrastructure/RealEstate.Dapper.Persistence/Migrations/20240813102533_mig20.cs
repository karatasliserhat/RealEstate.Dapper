using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstate.Dapper.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Employees_EmployeeId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Products",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_EmployeeId",
                table: "Products",
                newName: "IX_Products_AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AppUsers_AppUserId",
                table: "Products",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AppUsers_AppUserId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "Products",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_AppUserId",
                table: "Products",
                newName: "IX_Products_EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Employees_EmployeeId",
                table: "Products",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
