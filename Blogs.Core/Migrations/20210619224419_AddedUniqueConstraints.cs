using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blogs.Core.Migrations
{
    public partial class AddedUniqueConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthTokens",
                keyColumn: "Id",
                keyValue: new Guid("83e763e7-42b6-4898-849e-0aa4a32d1200"));

            migrationBuilder.InsertData(
                table: "AuthTokens",
                columns: new[] { "Id", "ExpirationDate", "Token", "UserId" },
                values: new object[] { new Guid("40788c8e-3754-401b-8256-9426f5b25ae4"), new DateTime(2021, 9, 19, 17, 44, 19, 165, DateTimeKind.Local).AddTicks(4066), "skzUF6rtAW", new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1") });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                table: "Roles",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Roles_Name",
                table: "Roles");

            migrationBuilder.DeleteData(
                table: "AuthTokens",
                keyColumn: "Id",
                keyValue: new Guid("40788c8e-3754-401b-8256-9426f5b25ae4"));

            migrationBuilder.InsertData(
                table: "AuthTokens",
                columns: new[] { "Id", "ExpirationDate", "Token", "UserId" },
                values: new object[] { new Guid("83e763e7-42b6-4898-849e-0aa4a32d1200"), new DateTime(2021, 9, 19, 17, 28, 9, 268, DateTimeKind.Local).AddTicks(6025), "skzUF6rtAW", new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1") });
        }
    }
}
