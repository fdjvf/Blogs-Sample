using Blogs.Data.Abstract;
using Blogs.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogs.Data.Repositories
{
    public class CommentsRepository : BaseRepository<BlogsContext>, ICommentRepository
    {
        public CommentsRepository(BlogsContext blogContext) : base(blogContext)
        {

        }

        public async Task<IEnumerable<Comment>> GetCommentsByPostId(Guid postId)
        {
            var result = await Db.Comments.Where(comment => comment.PostId == postId && !comment.IsDeleted).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<(Guid postId, IEnumerable<Comment> comments)>> GetCommentsByPostIds(Guid[] postIds)
        {
            var comments = await Db.Comments.Where(comment => postIds.Contains(comment.PostId) && !comment.IsDeleted).ToListAsync();
            var groupedComments = comments.GroupBy(comment => comment.PostId, (postId, comments) => (postId, comments));
            return groupedComments;
        }

        public async Task SaveComment(Guid postId, string text, Guid? userId)
        {
            var newComment = new Comment
            {
                PostId = postId,
                Text = text,
                WriterId = userId
            };

            Db.Comments.Add(newComment);

            await Db.SaveChangesAsync();
        }
    }
}
