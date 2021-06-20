using System;
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
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:zemoga.database.windows.net,1433;Initial Catalog=Blogs;Persist Security Info=False;User ID=fvides;Password=tZFH6AAj2T;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");


            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.HasIndex(e => e.Email).IsUnique();

                entity.Property(e => e.Password).IsRequired().HasMaxLength(256);

                //seed the database with sample users
                entity.HasData(
                        new User[]
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
                        });
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.HasIndex(e => e.Name).IsUnique();

                //seed the database with sample roles
                entity.HasData(new Role[]{
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
                });

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

                entity.HasData(new AuthToken[]
                {
                    new AuthToken
                    {
                      //We add an auth token for the Editor User
                      Id=Guid.NewGuid(),
                      ExpirationDate=DateTime.Now.AddMonths(3),
                      Token="skzUF6rtAW",
                      UserId=new Guid("93DA2D99-6E0A-4AFE-A039-BA290F10CAC1")
                    }
                });
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
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasData(
                    Enum.GetValues(typeof(PostStatus))
                    .Cast<PostStatus>()
                    .Select(status => new Status
                    {
                        Id = status,
                        Name = status.ToString()
                    }
                    ));
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
