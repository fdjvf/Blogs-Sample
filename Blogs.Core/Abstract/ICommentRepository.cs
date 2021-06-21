using Blogs.Data.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blogs.Data.Abstract
{
    /// <summary>
    /// Manages access to <see cref="Comment"/> objects
    ///</summary>
    public interface ICommentRepository
    {
        /// <summary>
        /// Get all comments of a post
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Comment>> GetCommentsByPostIdAsync(Guid postId);

        /// <summary>
        /// Create a new comment in a post
        /// </summary>
        /// <param name="postId"></param>
        /// <param name="text">Comment content</param>
        /// <param name="userId">This value can be null for anonymous users.</param>
        Task SaveCommentAsync(Guid postId, string text, Guid? userId);

    }
}
