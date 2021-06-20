using Blogs.Data.Abstract;
using Blogs.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogs.Data.Repositories
{
    public class PostRepostiroy : BaseRepository<BlogsContext>, IPostRepository
    {
        public PostRepostiroy(BlogsContext blogsContext) : base(blogsContext)
        {

        }

        public async Task<List<Post>> GetPendingPostsByStatus(PostStatus status)
        {
            var posts = await Db.Posts.Where(post => post.StatusId == status && !post.IsDeleted).ToListAsync();
            return posts;
        }

        public async Task<List<Post>> GetPostsByWriterId(Guid writerId)
        {
            var posts = await Db.Posts.Where(post => post.WriterId == writerId && !post.IsDeleted).ToListAsync();
            return posts;
        }

        public async Task SavePost(string text, Guid writerId)
        {
            var newPost = new Post
            {
                Text = text,
                WriterId = writerId
            };
            Db.Posts.Add(newPost);
            await Db.SaveChangesAsync();
        }

        public async Task UpdatePost(Post updatedPost)
        {
            var originalPost = await Db.Posts.FirstOrDefaultAsync(post => post.Id == updatedPost.Id && !post.IsDeleted);
            if (originalPost != null)
            {
                originalPost.StatusId = updatedPost.StatusId;
                originalPost.WriterId = updatedPost.WriterId;
                originalPost.ApprovalDate = updatedPost.ApprovalDate;
                originalPost.Text = updatedPost.Text;
                await Db.SaveChangesAsync();
            }
        }

        public async Task SoftDeletePost(Guid postId)
        {
            var originalPost = await Db.Posts.FirstOrDefaultAsync(post => post.Id == postId && !post.IsDeleted);
            if (originalPost != null)
            {
                originalPost.IsDeleted = true;
                await Db.SaveChangesAsync();
            }
        }
    }
}
