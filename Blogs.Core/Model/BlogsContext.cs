using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Blogs.Data.Model
{
    public partial class BlogsContext : DbContext
    {
        public BlogsContext(DbContextOptions<BlogsContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<AuthToken> AuthTokens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Seed methods
            User[] SeedUsers()
            {
                return new User[]
                         {
                            new User
                            {
                                Id = new Guid("93DA2D99-6E0A-4AFE-A039-BA290F10CAC1"),
                                Email = "editor@sample.com",
                                Password = "1234",
                            },
                            new User
                            {
                                Id = new Guid("E720064A-0EF2-4070-A9BE-39DB075BD485"),
                                Email = "writer@sample.com",
                                Password = "1234",
                            }
                         };
            }

            Role[] SeedRoles()
            {
                return new Role[]{
                    new Role
                    {
                        Id=new Guid("1D696EB7-147E-4570-AF78-AB6F57770E60"),
                        Name="Writer"

                    },
                    new Role
                    {
                        Id=new Guid("C8BBC75B-B16F-4CD8-AA8E-42EE8ED9B184"),
                        Name="Editor"
                    }
                };
            }

            AuthToken[] SeedAuthTokens()
            {
                return new AuthToken[]
                {
                    new AuthToken
                    {
                      //We add an auth token for the Editor User
                      Id=Guid.NewGuid(),
                      ExpirationDate=DateTime.Now.AddMonths(3),
                      Token="skzUF6rtAW",
                      UserId=new Guid("93DA2D99-6E0A-4AFE-A039-BA290F10CAC1")
                    }
                };
            }

            Status[] SeedStatus()
            {
                return Enum.GetValues(typeof(PostStatus))
                     .Cast<PostStatus>()
                     .Select(status => new Status
                     {
                         Id = status,
                         Name = status.ToString()
                     }).ToArray();
            }

            IEnumerable<Post> SeedPosts()
            {
                var writerId = new Guid("E720064A-0EF2-4070-A9BE-39DB075BD485");
                var allPosts = new List<Post>();

                //Create some Approve posts
                for (int i = 1; i <= 2; i++)
                {
                    allPosts.Add(new Post
                    {
                        ApprovalDate = DateTime.Now.AddDays(-2),
                        Id = Guid.NewGuid(),
                        StatusId = PostStatus.Approved,
                        Title = $"Post Title {i}",
                        WriterId = writerId,
                        Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. 
                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. 
                            Donec mollis accumsan neque ac pharetra"
                    });
                }

                //Create some pending posts
                for (int i = 1; i <= 4; i++)
                {
                    allPosts.Add(new Post
                    {
                        ApprovalDate = DateTime.Now,
                        Id = Guid.NewGuid(),
                        StatusId = PostStatus.PendingApproval,
                        Title = $"Post Pending Title {i}",
                        WriterId = writerId,
                        Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. 
                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. 
                            Donec mollis accumsan neque ac pharetra"
                    });
                }

                //Create some rejected posts
                for (int i = 1; i <= 3; i++)
                {
                    allPosts.Add(new Post
                    {
                        ApprovalDate = DateTime.Now,
                        Id = Guid.NewGuid(),
                        StatusId = PostStatus.Rejected,
                        Title = $"Post Rejected Title {i}",
                        WriterId = writerId,
                        Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. 
                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. 
                            Donec mollis accumsan neque ac pharetra"
                    });
                }

                return allPosts;
            }
            #endregion

            //Model configurations
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.HasIndex(e => e.Email).IsUnique();

                entity.Property(e => e.Password).IsRequired().HasMaxLength(256);

                //seed the database with sample users
                entity.HasData(SeedUsers());
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.HasIndex(e => e.Name).IsUnique();

                //seed the database with sample roles
                entity.HasData(SeedRoles());

            });

            //Add initial roles to user
            modelBuilder.Entity("RoleUser").HasData(new[]
            {
                new {
                    RolesId=new Guid("C8BBC75B-B16F-4CD8-AA8E-42EE8ED9B184"),
                    UsersId= new Guid("93DA2D99-6E0A-4AFE-A039-BA290F10CAC1")
                },//User with Editor roles
                new {
                    RolesId=new Guid("1D696EB7-147E-4570-AF78-AB6F57770E60"),
                    UsersId=new Guid("E720064A-0EF2-4070-A9BE-39DB075BD485")
                },//User with Writer Role
            });

            //Add some tokens
            modelBuilder.Entity<AuthToken>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.ExpirationDate).IsRequired();
                entity.Property(e => e.Token).HasMaxLength(100).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tokens)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthToken_User");

                entity.HasData(SeedAuthTokens());
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comments_Posts");

                entity.HasOne(d => d.Writer)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.WriterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comments_User");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.Title).IsRequired().HasMaxLength(50);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Posts_Status");

                entity.HasOne(d => d.Writer)
                   .WithMany(p => p.Posts)
                   .HasForeignKey(d => d.WriterId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_Posts_User");

                entity.HasData(SeedPosts());
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasData(SeedStatus());
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
