using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RJ35.Migrations
{
    /// <inheritdoc />
    public partial class _968574123654894646 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_DeviceType_ProductId",
                table: "Devices");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_DeviceType",
                table: "Devices",
                column: "DeviceType");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_DeviceType_DeviceType",
                table: "Devices",
                column: "DeviceType",
                principalTable: "DeviceType",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_DeviceType_DeviceType",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Devices_DeviceType",
                table: "Devices");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_DeviceType_ProductId",
                table: "Devices",
                column: "ProductId",
                principalTable: "DeviceType",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
