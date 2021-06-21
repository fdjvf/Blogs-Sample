using Blogs.Data.Abstract;
using Blogs.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogs.Data.Repositories
{
    internal class CommentsRepository : BaseRepository<BlogsContext>, ICommentRepository
    {
        public CommentsRepository(BlogsContext blogContext) : base(blogContext)
        {

        }

        public async Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(Guid postId)
        {
            var result = await Db.Comments.Include(comment => comment.Writer)
                .Where(comment => comment.PostId == postId && !comment.IsDeleted)
                .OrderByDescending(comment => comment.CreationDate)//Let's show most recent comments first
                .ToListAsync();
            return result;
        }

        public async Task SaveCommentAsync(Guid postId, string text, Guid? userId)
        {
            var newComment = new Comment
            {
                PostId = postId,
                Text = text,
                WriterId = userId,
                CreationDate = DateTime.UtcNow
            };

            Db.Comments.Add(newComment);

            await Db.SaveChangesAsync();
        }
    }
}
