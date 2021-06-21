using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blogs.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuthTokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthToken_User",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    WriterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApprovalDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SubmitDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Status",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Posts_User",
                        column: x => x.WriterId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RolesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RoleUser_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    WriterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_User",
                        column: x => x.WriterId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1d696eb7-147e-4570-af78-ab6f57770e60"), "Writer" },
                    { new Guid("c8bbc75b-b16f-4cd8-aa8e-42ee8ed9b184"), "Editor" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 0, "PendingApproval" },
                    { 1, "Approved" },
                    { 2, "Rejected" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1"), "Editor Number 1", "1234", "editor" },
                    { new Guid("e720064a-0ef2-4070-a9be-39db075bd485"), "Writer Number 1", "1234", "writer" },
                    { new Guid("6dd192b3-fa1f-46b1-bc91-dbdbf8cd40ce"), "Writer Number 2", "1234", "writer2" }
                });

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

            migrationBuilder.InsertData(
                table: "RoleUser",
                columns: new[] { "RolesId", "UsersId" },
                values: new object[,]
                {
                    { new Guid("c8bbc75b-b16f-4cd8-aa8e-42ee8ed9b184"), new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1") },
                    { new Guid("1d696eb7-147e-4570-af78-ab6f57770e60"), new Guid("e720064a-0ef2-4070-a9be-39db075bd485") },
                    { new Guid("1d696eb7-147e-4570-af78-ab6f57770e60"), new Guid("6dd192b3-fa1f-46b1-bc91-dbdbf8cd40ce") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthTokens_Token",
                table: "AuthTokens",
                column: "Token",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuthTokens_UserId",
                table: "AuthTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_WriterId",
                table: "Comments",
                column: "WriterId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_StatusId",
                table: "Posts",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_WriterId",
                table: "Posts",
                column: "WriterId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                table: "Roles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UsersId",
                table: "RoleUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
