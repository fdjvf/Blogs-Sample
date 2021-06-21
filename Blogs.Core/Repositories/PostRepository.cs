using Blogs.Data.Abstract;
using Blogs.Data.Enums;
using Blogs.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogs.Data.Repositories
{
    internal class PostRepository : BaseRepository<BlogsContext>, IPostRepository
    {
        public PostRepository(BlogsContext blogsContext) : base(blogsContext)
        {

        }

        public async Task<IEnumerable<Post>> GetPostsByStatus(PostStatus status)
        {
            var posts = await Db.Posts.Include(post => post.Writer)
                .Where(post => post.StatusId == status && !post.IsDeleted).OrderBy(post => post.Title).ToListAsync();
            return posts;
        }

        public async Task<IEnumerable<Post>> GetPostsByWriterId(Guid writerId)
        {
            var posts = await Db.Posts.Where(post => post.WriterId == writerId && !post.IsDeleted).OrderBy(post => post.Title).ToListAsync();
            return posts;
        }

        public async Task SavePost(string text, string title, Guid writerId)
        {
            var newPost = new Post
            {
                Text = text,
                WriterId = writerId,
                StatusId = PostStatus.PendingApproval,
                Title = title
            };
            Db.Posts.Add(newPost);
            await Db.SaveChangesAsync();
        }

        public async Task UpdatePost(Post updatedPost)
        {
            var originalPost = await GetPostById(updatedPost.Id);
            if (originalPost != null)
            {
                originalPost.StatusId = updatedPost.StatusId;
                originalPost.WriterId = updatedPost.WriterId;
                originalPost.ApprovalDate = updatedPost.ApprovalDate;
                originalPost.Text = updatedPost.Text;
                originalPost.Title = updatedPost.Title;
                await Db.SaveChangesAsync();
            }
        }

        public async Task SoftDeletePost(Guid postId)
        {
            var originalPost = await GetPostById(postId);
            if (originalPost != null)
            {
                originalPost.IsDeleted = true;
                await Db.SaveChangesAsync();
            }
        }

        public async Task<Post> GetPostById(Guid postId)
        {
            var post = await Db.Posts.FirstOrDefaultAsync(post => post.Id == postId && !post.IsDeleted);
            return post;
        }
    }
}
