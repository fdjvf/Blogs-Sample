using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blogs.Data.Migrations
{
    public partial class ChangeFromDateTimeNowToUtc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthTokens",
                keyColumn: "Id",
                keyValue: new Guid("3cf45bae-9167-4010-ad38-eaad4974fd88"));

            migrationBuilder.DeleteData(
                table: "AuthTokens",
                keyColumn: "Id",
                keyValue: new Guid("d0abe929-4a71-4250-9c0b-404baa25465f"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("382e5826-b839-4df6-9146-25a4a20320d0"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("5136d26b-bd2a-4a1d-865d-64d72a424e8f"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("8cc79c13-2f5b-4a1e-819d-f19f995859fe"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("c13e6148-479c-4f18-b085-b14e06e5cabe"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("cf321898-5aa1-4f2a-a902-60984c05af43"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("d978e6b3-6409-49c1-9642-ddc3477a2f43"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("dfd60ef4-58ea-4f48-a8f6-8d65afda5af3"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("e3f449f4-0580-456c-a6c2-11ef7d352c1d"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("ef510b14-9140-45e9-9842-01c83dce0ded"));

            migrationBuilder.InsertData(
                table: "AuthTokens",
                columns: new[] { "Id", "ExpirationDate", "Token", "UserId" },
                values: new object[,]
                {
                    { new Guid("a66b4f70-cd47-49b4-a658-5b068e5fbd14"), new DateTime(2021, 9, 21, 16, 42, 24, 325, DateTimeKind.Utc).AddTicks(5166), "skzUF6rtAW", new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1") },
                    { new Guid("72ac1666-be46-48d1-ab24-d7e91daf1724"), new DateTime(2021, 9, 21, 16, 42, 24, 325, DateTimeKind.Utc).AddTicks(6653), "wrZTLJRCob", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ApprovalDate", "IsDeleted", "StatusId", "SubmitDate", "Text", "Title", "WriterId" },
                values: new object[,]
                {
                    { new Guid("553d1bae-2d51-4537-a513-a9d3ec784059"), new DateTime(2021, 6, 19, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(1151), false, 1, new DateTime(2021, 6, 18, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(3335), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("e0db5f33-11e5-4370-b44b-49ce7fc41d08"), new DateTime(2021, 6, 19, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(3967), false, 1, new DateTime(2021, 6, 18, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(3981), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("c50e9903-8de0-435b-aca4-896369387962"), null, false, 0, new DateTime(2021, 6, 17, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(3986), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("1a217727-17ab-47ce-a5ee-b6665aea8f2d"), null, false, 0, new DateTime(2021, 6, 17, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(3989), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("3fe177a0-b0d3-45ef-9560-c8bca83c4fd8"), null, false, 0, new DateTime(2021, 6, 17, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(3991), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 3", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("f5227d24-ff33-4421-a9ed-7884142b3767"), null, false, 0, new DateTime(2021, 6, 17, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(3996), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 4", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("8a6fc8b1-ab89-4540-bda8-f49d7f03f82b"), null, false, 2, new DateTime(2021, 6, 16, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(4004), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("8789ee6b-a13d-422f-8bb2-e20e7311f1b9"), null, false, 2, new DateTime(2021, 6, 16, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(4007), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("597dcc4c-2cb9-4098-8513-2757495cf317"), null, false, 2, new DateTime(2021, 6, 16, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(4009), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 3", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuthTokens",
                keyColumn: "Id",
                keyValue: new Guid("72ac1666-be46-48d1-ab24-d7e91daf1724"));

            migrationBuilder.DeleteData(
                table: "AuthTokens",
                keyColumn: "Id",
                keyValue: new Guid("a66b4f70-cd47-49b4-a658-5b068e5fbd14"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("1a217727-17ab-47ce-a5ee-b6665aea8f2d"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("3fe177a0-b0d3-45ef-9560-c8bca83c4fd8"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("553d1bae-2d51-4537-a513-a9d3ec784059"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("597dcc4c-2cb9-4098-8513-2757495cf317"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("8789ee6b-a13d-422f-8bb2-e20e7311f1b9"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("8a6fc8b1-ab89-4540-bda8-f49d7f03f82b"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("c50e9903-8de0-435b-aca4-896369387962"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("e0db5f33-11e5-4370-b44b-49ce7fc41d08"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("f5227d24-ff33-4421-a9ed-7884142b3767"));

            migrationBuilder.InsertData(
                table: "AuthTokens",
                columns: new[] { "Id", "ExpirationDate", "Token", "UserId" },
                values: new object[,]
                {
                    { new Guid("d0abe929-4a71-4250-9c0b-404baa25465f"), new DateTime(2021, 9, 21, 1, 30, 19, 795, DateTimeKind.Local).AddTicks(1895), "skzUF6rtAW", new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1") },
                    { new Guid("3cf45bae-9167-4010-ad38-eaad4974fd88"), new DateTime(2021, 9, 21, 1, 30, 19, 795, DateTimeKind.Local).AddTicks(8566), "wrZTLJRCob", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ApprovalDate", "IsDeleted", "StatusId", "SubmitDate", "Text", "Title", "WriterId" },
                values: new object[,]
                {
                    { new Guid("ef510b14-9140-45e9-9842-01c83dce0ded"), new DateTime(2021, 6, 19, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(2214), false, 1, new DateTime(2021, 6, 18, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(3822), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("382e5826-b839-4df6-9146-25a4a20320d0"), new DateTime(2021, 6, 19, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(4262), false, 1, new DateTime(2021, 6, 18, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(4279), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("e3f449f4-0580-456c-a6c2-11ef7d352c1d"), null, false, 0, new DateTime(2021, 6, 17, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(4283), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("cf321898-5aa1-4f2a-a902-60984c05af43"), null, false, 0, new DateTime(2021, 6, 17, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(4286), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("5136d26b-bd2a-4a1d-865d-64d72a424e8f"), null, false, 0, new DateTime(2021, 6, 17, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(4289), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 3", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("dfd60ef4-58ea-4f48-a8f6-8d65afda5af3"), null, false, 0, new DateTime(2021, 6, 17, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(4294), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Pending Title 4", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("c13e6148-479c-4f18-b085-b14e06e5cabe"), null, false, 2, new DateTime(2021, 6, 16, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(4303), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 1", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("8cc79c13-2f5b-4a1e-819d-f19f995859fe"), null, false, 2, new DateTime(2021, 6, 16, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(4306), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 2", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("d978e6b3-6409-49c1-9642-ddc3477a2f43"), null, false, 2, new DateTime(2021, 6, 16, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(4309), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra", "Post Rejected Title 3", new Guid("e720064a-0ef2-4070-a9be-39db075bd485") }
                });
        }
    }
}
