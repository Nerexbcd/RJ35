using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RJ35.Migrations
{
    /// <inheritdoc />
    public partial class _98454778892 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserNotifications_User_RJ35WebUserID",
                table: "UserNotifications");

            migrationBuilder.RenameColumn(
                name: "RJ35WebUserID",
                table: "UserNotifications",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserNotifications_RJ35WebUserID",
                table: "UserNotifications",
                newName: "IX_UserNotifications_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserNotifications_User_UserId",
                table: "UserNotifications",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserNotifications_User_UserId",
                table: "UserNotifications");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserNotifications",
                newName: "RJ35WebUserID");

            migrationBuilder.RenameIndex(
                name: "IX_UserNotifications_UserId",
                table: "UserNotifications",
                newName: "IX_UserNotifications_RJ35WebUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserNotifications_User_RJ35WebUserID",
                table: "UserNotifications",
                column: "RJ35WebUserID",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
