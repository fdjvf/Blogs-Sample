using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blogs.Data.Migrations
{
    public partial class AddedNameAndUserNameToUserObj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthTokens",
                keyColumn: "Id",
                keyValue: new Guid("a42da760-64e0-48df-8ddf-a22a1eb0d59f"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("1b3e3ab3-2dc8-42d7-9682-c277cf42a3f5"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("3d1b30fe-68f6-41ac-b86e-83c2ae427b15"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("487cdffa-ad78-4f8c-bcc2-44a318a9c507"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("4f6665a4-9be5-4093-84f6-9af406339dd7"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("6a33b6bb-aedd-4d6f-bd8d-3a5e789429cb"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("774adc80-7da6-4cf3-87c3-19f730ef78db"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("c1c06a65-ff72-4294-bc35-95a76a4330d2"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("f20db429-995a-41f6-b89e-f38ad7d30da8"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("fa2de858-550f-48c5-bdfa-d97c5945151a"));

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Email",
                table: "Users",
                newName: "IX_Users_UserName");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "Name", "UserName" },
                values: new object[] { "Writed Number 2", "writer2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1"),
                columns: new[] { "Name", "UserName" },
                values: new object[] { "Editor Number 1", "editor" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e720064a-0ef2-4070-a9be-39db075bd485"),
                columns: new[] { "Name", "UserName" },
                values: new object[] { "Writed Number 1", "writer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserName",
                table: "Users",
                newName: "IX_Users_Email");

            migrationBuilder.InsertData(
                table: "AuthTokens",
                columns: new[] { "Id", "ExpirationDate", "Token", "UserId" },
                values: new object[] { new Guid("a42da760-64e0-48df-8ddf-a22a1eb0d59f"), new DateTime(2021, 9, 20, 15, 46, 2, 977, DateTimeKind.Local).AddTicks(9358), "skzUF6rtAW", new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1") });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ApprovalDate", "IsDeleted", "StatusId", "Text", "Title", "WriterId" },
                values: new object[,]
                {
                    { new Guid("c1c06a65-ff72-4294-bc35-95a76a4330d2"), new DateTime(2021, 6, 18, 15, 46, 2, 981, DateTimeKind.Local).AddTicks(4578), false, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("774adc80-7da6-4cf3-87c3-19f730ef78db"), new DateTime(2021, 6, 18, 15, 46, 2, 981, DateTimeKind.Local).AddTicks(6214), false, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("4f6665a4-9be5-4093-84f6-9af406339dd7"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("1b3e3ab3-2dc8-42d7-9682-c277cf42a3f5"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("3d1b30fe-68f6-41ac-b86e-83c2ae427b15"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 3", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("f20db429-995a-41f6-b89e-f38ad7d30da8"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 4", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("6a33b6bb-aedd-4d6f-bd8d-3a5e789429cb"), null, false, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("487cdffa-ad78-4f8c-bcc2-44a318a9c507"), null, false, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("fa2de858-550f-48c5-bdfa-d97c5945151a"), null, false, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 3", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6dd192b3-fa1f-46b1-bc91-dbdbf8cd40ce"),
                column: "Email",
                value: "writer2@sample.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1"),
                column: "Email",
                value: "editor@sample.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e720064a-0ef2-4070-a9be-39db075bd485"),
                column: "Email",
                value: "writer@sample.com");
        }
    }
}
