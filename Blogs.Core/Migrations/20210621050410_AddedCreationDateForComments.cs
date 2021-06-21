using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blogs.Data.Migrations
{
    public partial class AddedCreationDateForComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthTokens",
                keyColumn: "Id",
                keyValue: new Guid("f6a9c89b-4794-4f42-85a1-e4c27352cb33"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("23155173-0fd2-42b1-86b7-e600e8356cce"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("49475b36-05c5-4e1c-ae7f-414b75310960"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("53d2b62b-19e7-4f94-b867-547a6fd445e0"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("53ddab3f-a323-4f15-b9f1-d4aa8e4f61f9"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("69c8aef9-6480-44b0-856f-8f3bfcaac4c7"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("750197d3-6c5e-4547-bafc-b6c9c5e9b28e"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("d6710461-cfbe-4770-83f7-7ebed52d5c39"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("decd8182-e58e-4310-b5eb-a30135ea1ef8"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("fa5abf80-3135-41ec-8005-30cfc0a7ceab"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AuthTokens",
                columns: new[] { "Id", "ExpirationDate", "Token", "UserId" },
                values: new object[] { new Guid("e647d970-e4f4-41c2-920e-94c6d5a4ceae"), new DateTime(2021, 9, 21, 0, 4, 9, 871, DateTimeKind.Local).AddTicks(1482), "skzUF6rtAW", new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1") });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ApprovalDate", "IsDeleted", "StatusId", "Text", "Title", "WriterId" },
                values: new object[,]
                {
                    { new Guid("78eb3fe4-6b17-42e7-8010-1196c78e8ecd"), new DateTime(2021, 6, 19, 0, 4, 9, 874, DateTimeKind.Local).AddTicks(9549), false, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("8bb2b816-d96e-4ba9-b3c3-ec751747a170"), new DateTime(2021, 6, 19, 0, 4, 9, 875, DateTimeKind.Local).AddTicks(1260), false, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("805f7c86-1243-46fd-8d1a-b08b11673307"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("0429c664-ea5d-4b06-856f-0dc61267b023"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("0f49c40a-8f27-4319-a131-c34387588058"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 3", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("9a76fa8b-b112-4a3b-8771-0298bc81fb1a"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 4", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("2324e8a8-69c3-40fb-9c55-cfe72e28111d"), null, false, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("2d1c9447-54a3-4797-ab9f-abb742cd4206"), null, false, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("bfe97427-b4d4-42fd-b33f-58642f156554"), null, false, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 3", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthTokens",
                keyColumn: "Id",
                keyValue: new Guid("e647d970-e4f4-41c2-920e-94c6d5a4ceae"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("0429c664-ea5d-4b06-856f-0dc61267b023"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("0f49c40a-8f27-4319-a131-c34387588058"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("2324e8a8-69c3-40fb-9c55-cfe72e28111d"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("2d1c9447-54a3-4797-ab9f-abb742cd4206"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("78eb3fe4-6b17-42e7-8010-1196c78e8ecd"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("805f7c86-1243-46fd-8d1a-b08b11673307"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("8bb2b816-d96e-4ba9-b3c3-ec751747a170"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("9a76fa8b-b112-4a3b-8771-0298bc81fb1a"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("bfe97427-b4d4-42fd-b33f-58642f156554"));

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Comments");

            migrationBuilder.InsertData(
                table: "AuthTokens",
                columns: new[] { "Id", "ExpirationDate", "Token", "UserId" },
                values: new object[] { new Guid("f6a9c89b-4794-4f42-85a1-e4c27352cb33"), new DateTime(2021, 9, 20, 21, 22, 44, 314, DateTimeKind.Local).AddTicks(7838), "skzUF6rtAW", new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1") });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ApprovalDate", "IsDeleted", "StatusId", "Text", "Title", "WriterId" },
                values: new object[,]
                {
                    { new Guid("23155173-0fd2-42b1-86b7-e600e8356cce"), new DateTime(2021, 6, 18, 21, 22, 44, 318, DateTimeKind.Local).AddTicks(3446), false, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("69c8aef9-6480-44b0-856f-8f3bfcaac4c7"), new DateTime(2021, 6, 18, 21, 22, 44, 318, DateTimeKind.Local).AddTicks(5094), false, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("49475b36-05c5-4e1c-ae7f-414b75310960"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("decd8182-e58e-4310-b5eb-a30135ea1ef8"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("750197d3-6c5e-4547-bafc-b6c9c5e9b28e"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 3", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("fa5abf80-3135-41ec-8005-30cfc0a7ceab"), null, false, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 4", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("53d2b62b-19e7-4f94-b867-547a6fd445e0"), null, false, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("53ddab3f-a323-4f15-b9f1-d4aa8e4f61f9"), null, false, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("d6710461-cfbe-4770-83f7-7ebed52d5c39"), null, false, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 3", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") }
                });
        }
    }
}
