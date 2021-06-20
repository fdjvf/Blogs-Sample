using Blogs.Data.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blogs.Data.Abstract
{
    interface ICommentRepository
    {
        /// <summary>
        /// Get all comments of a post
        /// </summary>
        /// <returns></returns>
        Task<List<Comment>> GetCommentsByPostId(Guid postId);

        /// <summary>
        /// Create a new comment in a post
        /// </summary>
        /// <param name="postId"></param>
        /// <param name="text">Comments</param>
        /// <param name="userId">This value can be null for anonymous users.</param>
        Task SaveComment(Guid postId, string text, Guid? userId);

        /// <summary>
        /// Get comments using posts Ids
        /// </summary>
        /// <param name="postIds"></param>
        /// <returns></returns>
        Task<IEnumerable<(Guid postId, IEnumerable<Comment> comments)>> GetCommentsByPostIds(Guid[] postIds);
    }
}
