using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstate.Dapper.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductDetails_ProductDetailId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ProductDetailId",
                table: "Products",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductDetailId",
                table: "Products",
                newName: "IX_Products_EmployeeId");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductId",
                table: "ProductDetails",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Products_ProductId",
                table: "ProductDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Employees_EmployeeId",
                table: "Products",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Products_ProductId",
                table: "ProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Employees_EmployeeId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetails_ProductId",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductDetails");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Products",
                newName: "ProductDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_EmployeeId",
                table: "Products",
                newName: "IX_Products_ProductDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductDetails_ProductDetailId",
                table: "Products",
                column: "ProductDetailId",
                principalTable: "ProductDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
