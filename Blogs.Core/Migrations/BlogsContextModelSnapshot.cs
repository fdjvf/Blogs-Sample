﻿// <auto-generated />
using System;
using Blogs.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blogs.Data.Migrations
{
    [DbContext(typeof(BlogsContext))]
    partial class BlogsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blogs.Data.Model.AuthToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AuthTokens");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4033ff31-88f3-4ad5-a74e-4c2ea4942ff2"),
                            ExpirationDate = new DateTime(2021, 9, 20, 12, 2, 0, 513, DateTimeKind.Local).AddTicks(5097),
                            Token = "skzUF6rtAW",
                            UserId = new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1")
                        });
                });

            modelBuilder.Entity("Blogs.Data.Model.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("WriterId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("WriterId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Blogs.Data.Model.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<DateTime?>("ApprovalDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("WriterId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("WriterId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c03aab66-3422-4c6a-89d2-6aa1eca1e4d5"),
                            ApprovalDate = new DateTime(2021, 6, 18, 12, 2, 0, 517, DateTimeKind.Local).AddTicks(3051),
                            IsDeleted = false,
                            StatusId = 1,
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Title 1",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("0d6dc1ab-c08f-4bc5-a5e8-e4e6172840a1"),
                            ApprovalDate = new DateTime(2021, 6, 18, 12, 2, 0, 517, DateTimeKind.Local).AddTicks(4698),
                            IsDeleted = false,
                            StatusId = 1,
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Title 2",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("124bc420-a47b-478b-9e66-c150cee690fc"),
                            ApprovalDate = new DateTime(2021, 6, 20, 12, 2, 0, 517, DateTimeKind.Local).AddTicks(4719),
                            IsDeleted = false,
                            StatusId = 0,
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Pending Title 1",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("9376453a-4a85-4df8-adb3-662262df1f59"),
                            ApprovalDate = new DateTime(2021, 6, 20, 12, 2, 0, 517, DateTimeKind.Local).AddTicks(4723),
                            IsDeleted = false,
                            StatusId = 0,
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Pending Title 2",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("aaf84276-dd75-4c67-8902-72b1c3037d65"),
                            ApprovalDate = new DateTime(2021, 6, 20, 12, 2, 0, 517, DateTimeKind.Local).AddTicks(4755),
                            IsDeleted = false,
                            StatusId = 0,
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Pending Title 3",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("9719132e-fc86-4877-834e-858eb830de3c"),
                            ApprovalDate = new DateTime(2021, 6, 20, 12, 2, 0, 517, DateTimeKind.Local).AddTicks(4761),
                            IsDeleted = false,
                            StatusId = 0,
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Pending Title 4",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("441fc7b1-e046-44f0-8a8b-b8b87cb5a9b1"),
                            ApprovalDate = new DateTime(2021, 6, 20, 12, 2, 0, 517, DateTimeKind.Local).AddTicks(4764),
                            IsDeleted = false,
                            StatusId = 2,
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Rejected Title 1",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("b51d405e-e808-4c2a-ade2-ad30e0584156"),
                            ApprovalDate = new DateTime(2021, 6, 20, 12, 2, 0, 517, DateTimeKind.Local).AddTicks(4768),
                            IsDeleted = false,
                            StatusId = 2,
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Rejected Title 2",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("90475ce1-dd72-4aa1-a17b-68a34d6caafc"),
                            ApprovalDate = new DateTime(2021, 6, 20, 12, 2, 0, 517, DateTimeKind.Local).AddTicks(4777),
                            IsDeleted = false,
                            StatusId = 2,
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Rejected Title 3",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        });
                });

            modelBuilder.Entity("Blogs.Data.Model.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1d696eb7-147e-4570-af78-ab6f57770e60"),
                            Name = "Writer"
                        },
                        new
                        {
                            Id = new Guid("c8bbc75b-b16f-4cd8-aa8e-42ee8ed9b184"),
                            Name = "Editor"
                        });
                });

            modelBuilder.Entity("Blogs.Data.Model.Status", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            Id = 0,
                            Name = "PendingApproval"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Approved"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Rejected"
                        });
                });

            modelBuilder.Entity("Blogs.Data.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1"),
                            Email = "editor@sample.com",
                            Password = "1234"
                        },
                        new
                        {
                            Id = new Guid("e720064a-0ef2-4070-a9be-39db075bd485"),
                            Email = "writer@sample.com",
                            Password = "1234"
                        });
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<Guid>("RolesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("RoleUser");

                    b.HasData(
                        new
                        {
                            RolesId = new Guid("c8bbc75b-b16f-4cd8-aa8e-42ee8ed9b184"),
                            UsersId = new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1")
                        },
                        new
                        {
                            RolesId = new Guid("1d696eb7-147e-4570-af78-ab6f57770e60"),
                            UsersId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        });
                });

            modelBuilder.Entity("Blogs.Data.Model.AuthToken", b =>
                {
                    b.HasOne("Blogs.Data.Model.User", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_AuthToken_User")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Blogs.Data.Model.Comment", b =>
                {
                    b.HasOne("Blogs.Data.Model.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .HasConstraintName("FK_Comments_Posts")
                        .IsRequired();

                    b.HasOne("Blogs.Data.Model.User", "Writer")
                        .WithMany("Comments")
                        .HasForeignKey("WriterId")
                        .HasConstraintName("FK_Comments_User");

                    b.Navigation("Post");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("Blogs.Data.Model.Post", b =>
                {
                    b.HasOne("Blogs.Data.Model.Status", "Status")
                        .WithMany("Posts")
                        .HasForeignKey("StatusId")
                        .HasConstraintName("FK_Posts_Status")
                        .IsRequired();

                    b.HasOne("Blogs.Data.Model.User", "Writer")
                        .WithMany("Posts")
                        .HasForeignKey("WriterId")
                        .HasConstraintName("FK_Posts_User")
                        .IsRequired();

                    b.Navigation("Status");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("Blogs.Data.Model.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blogs.Data.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blogs.Data.Model.Post", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Blogs.Data.Model.Status", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("Blogs.Data.Model.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Posts");

                    b.Navigation("Tokens");
                });
#pragma warning restore 612, 618
        }
    }
}
