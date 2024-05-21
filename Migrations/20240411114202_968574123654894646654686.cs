using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RJ35.Migrations
{
    /// <inheritdoc />
    public partial class _968574123654894646654686 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_DeviceType_DeviceType",
                table: "Devices");

            migrationBuilder.RenameColumn(
                name: "DeviceType",
                table: "Devices",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Devices_DeviceType",
                table: "Devices",
                newName: "IX_Devices_TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_DeviceType_TypeId",
                table: "Devices",
                column: "TypeId",
                principalTable: "DeviceType",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_DeviceType_TypeId",
                table: "Devices");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Devices",
                newName: "DeviceType");

            migrationBuilder.RenameIndex(
                name: "IX_Devices_TypeId",
                table: "Devices",
                newName: "IX_Devices_DeviceType");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_DeviceType_DeviceType",
                table: "Devices",
                column: "DeviceType",
                principalTable: "DeviceType",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
