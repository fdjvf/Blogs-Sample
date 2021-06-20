using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blogs.Data.Migrations
{
    public partial class AddedTitletoPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthTokens",
                keyColumn: "Id",
                keyValue: new Guid("40788c8e-3754-401b-8256-9426f5b25ae4"));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AuthTokens",
                columns: new[] { "Id", "ExpirationDate", "Token", "UserId" },
                values: new object[] { new Guid("d512c3b6-58fb-4313-a64c-3bc4e2829381"), new DateTime(2021, 9, 20, 10, 13, 10, 875, DateTimeKind.Local).AddTicks(233), "skzUF6rtAW", new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthTokens",
                keyColumn: "Id",
                keyValue: new Guid("d512c3b6-58fb-4313-a64c-3bc4e2829381"));

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Posts");

            migrationBuilder.InsertData(
                table: "AuthTokens",
                columns: new[] { "Id", "ExpirationDate", "Token", "UserId" },
                values: new object[] { new Guid("40788c8e-3754-401b-8256-9426f5b25ae4"), new DateTime(2021, 9, 19, 17, 44, 19, 165, DateTimeKind.Local).AddTicks(4066), "skzUF6rtAW", new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1") });
        }
    }
}
