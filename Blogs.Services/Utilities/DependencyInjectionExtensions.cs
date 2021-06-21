using AutoMapper;
using Blogs.Data.Abstract;
using Blogs.Data.Model;
using Blogs.Data.Repositories;
using Blogs.Services;
using Blogs.Services.Abstract;
using Blogs.Services.Maps;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blogs.Data.Utilities
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContextPool<BlogsContext>(options =>
          options.UseSqlServer(configuration.GetConnectionString("BlogsDb"),
         x => x.MigrationsAssembly("Blogs.Data")));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<ICommentRepository, CommentsRepository>();
            services.AddScoped<IAuthTokenRepository, AuthTokenRepository>();

            return services;
        }

        public static IServiceCollection AddBlogServices(this IServiceCollection services)
        {

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<ICommentsService, CommentsService>();
            services.AddScoped<IAuthTokenService, AuthTokenService>();

            return services;
        }

        public static IMapperConfigurationExpression AddObjectAutoMappers(this IMapperConfigurationExpression config)
        {

            config.AddProfile<UserMap>();
            config.AddProfile<SummaryPostMap>();
            config.AddProfile<PostViewModelMap>();
            config.AddProfile<PostMap>();
            config.AddProfile<CommentMap>();
            config.AddProfile<AuthTokenMap>();
            return config;
        }
    }
}
