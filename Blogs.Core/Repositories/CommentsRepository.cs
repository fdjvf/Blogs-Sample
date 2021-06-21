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

        public async Task<IEnumerable<Comment>> GetCommentsByPostId(Guid postId)
        {
            var result = await Db.Comments.Include(comment => comment.Writer)
                .Where(comment => comment.PostId == postId && !comment.IsDeleted).ToListAsync();
            return result;
        }

        public async Task SaveComment(Guid postId, string text, Guid? userId)
        {
            var newComment = new Comment
            {
                PostId = postId,
                Text = text,
                WriterId = userId,
                CreationDate = DateTime.Now
            };

            Db.Comments.Add(newComment);

            await Db.SaveChangesAsync();
        }
    }
}
