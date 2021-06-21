using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blogs.Data.Migrations
{
    public partial class ModifiedSeedUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthTokens",
                keyColumn: "Id",
                keyValue: new Guid("cbf250d4-74dd-43d7-bccf-b02ff9df487b"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("0b667eff-e21d-48db-875b-d91e4db0b022"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("4a35e36a-67d3-40d3-a1e6-145daffc586b"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("693a8514-4bc7-4ef3-9abf-7f5abf5815fd"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("754b840a-a355-44c6-9200-b1c61153ea2e"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("76e58855-f3d1-4472-a33e-b9e08b1556f5"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("7b14136b-17c1-40b1-be4e-b08cfcf149e2"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("a81be856-51fc-4fe9-bac8-09c6f3fa1ccf"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("b793d98b-2849-461d-90cd-d57d681c1fd0"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("f8cc5f0b-a5d3-4fea-be0d-67bee518744b"));

            migrationBuilder.InsertData(
                table: "AuthTokens",
                columns: new[] { "Id", "ExpirationDate", "Token", "UserId" },
                values: new object[] { new Guid("cd2c5c8d-8aff-44b5-9f81-87e4833955cc"), new DateTime(2021, 9, 20, 21, 20, 47, 472, DateTimeKind.Local).AddTicks(7564), "skzUF6rtAW", new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1") });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ApprovalDate", "IsDeleted", "StatusId", "Text", "Title", "WriterId" },
                values: new object[,]
                {
                    { new Guid("9e5200f2-99ba-4734-aa23-939c6f0b25c2"), new DateTime(2021, 6, 18, 21, 20, 47, 476, DateTimeKind.Local).AddTicks(4628), false, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("d8479f2c-e081-4cde-9ff3-70357d5a365a"), new DateTime(2021, 6, 18, 21, 20, 47, 476, DateTimeKind.Local).AddTicks(6306), false, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("4214ceaf-f9e6-44f6-b844-6b21062c87a5"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("35e15cca-33f5-4a7f-afd0-74563d83bd3e"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("d7411aee-8531-4d97-85a2-2b3f78cf0216"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 3", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("27967d76-1ada-44ec-8f42-56249c4dcc4f"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 4", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("ad40d949-081f-44a4-b517-e9b787f4a3ae"), null, false, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("a092eff1-f7de-40b3-8832-c84c4c9925bd"), null, false, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("2fff1add-4d6d-41de-8812-2880af88a2de"), null, false, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 3", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6dd192b3-fa1f-46b1-bc91-dbdbf8cd40ce"),
                column: "Name",
                value: "Writer Number 2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e720064a-0ef2-4070-a9be-39db075bd485"),
                column: "Name",
                value: "Writer Number 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthTokens",
                keyColumn: "Id",
                keyValue: new Guid("cd2c5c8d-8aff-44b5-9f81-87e4833955cc"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("27967d76-1ada-44ec-8f42-56249c4dcc4f"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("2fff1add-4d6d-41de-8812-2880af88a2de"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("35e15cca-33f5-4a7f-afd0-74563d83bd3e"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("4214ceaf-f9e6-44f6-b844-6b21062c87a5"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("9e5200f2-99ba-4734-aa23-939c6f0b25c2"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("a092eff1-f7de-40b3-8832-c84c4c9925bd"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("ad40d949-081f-44a4-b517-e9b787f4a3ae"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("d7411aee-8531-4d97-85a2-2b3f78cf0216"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("d8479f2c-e081-4cde-9ff3-70357d5a365a"));

            migrationBuilder.InsertData(
                table: "AuthTokens",
                columns: new[] { "Id", "ExpirationDate", "Token", "UserId" },
                values: new object[] { new Guid("cbf250d4-74dd-43d7-bccf-b02ff9df487b"), new DateTime(2021, 9, 20, 21, 5, 42, 313, DateTimeKind.Local).AddTicks(4125), "skzUF6rtAW", new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1") });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ApprovalDate", "IsDeleted", "StatusId", "Text", "Title", "WriterId" },
                values: new object[,]
                {
                    { new Guid("754b840a-a355-44c6-9200-b1c61153ea2e"), new DateTime(2021, 6, 18, 21, 5, 42, 317, DateTimeKind.Local).AddTicks(5829), false, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("76e58855-f3d1-4472-a33e-b9e08b1556f5"), new DateTime(2021, 6, 18, 21, 5, 42, 317, DateTimeKind.Local).AddTicks(7719), false, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("f8cc5f0b-a5d3-4fea-be0d-67bee518744b"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("7b14136b-17c1-40b1-be4e-b08cfcf149e2"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("0b667eff-e21d-48db-875b-d91e4db0b022"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 3", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("4a35e36a-67d3-40d3-a1e6-145daffc586b"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 4", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("a81be856-51fc-4fe9-bac8-09c6f3fa1ccf"), null, false, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("693a8514-4bc7-4ef3-9abf-7f5abf5815fd"), null, false, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("b793d98b-2849-461d-90cd-d57d681c1fd0"), null, false, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 3", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6dd192b3-fa1f-46b1-bc91-dbdbf8cd40ce"),
                column: "Name",
                value: "Writed Number 2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e720064a-0ef2-4070-a9be-39db075bd485"),
                column: "Name",
                value: "Writed Number 1");
        }
    }
}
