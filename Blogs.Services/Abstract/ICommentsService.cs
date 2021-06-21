using Blogs.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blogs.Services.Abstract
{
    /// <summary>
    /// Service to manage comments between the UI and the Data Layer
    /// </summary>
    public interface ICommentsService
    {
        /// <summary>
        /// Saves a post's new comment from the UI
        /// </summary>
        /// <param name="newComment"></param>
        Task SaveCommentAsync(CommentViewModel newComment);

        /// <summary>
        /// Returns a post's comment to be displayed in the UI
        /// </summary>
        /// <param name="postId"></param>
        Task<IEnumerable<CommentViewModel>> GetCommentsByPostIdAsync(Guid postId);

    }
}
