using Blogs.Data.Enums;
using Blogs.Services.Dto;
using Blogs.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blogs.Services.Abstract
{
    public interface IPostService
    {
        /// <summary>
        /// Gets all pending posts. Used by the REST API to return a list of <see cref="PostObject"/>
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<PostObject>> GetPendingPostsAsync();

        /// <summary>
        /// Gets all posts that have been approved to be displayed in the UI
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<SummaryPostViewModel>> GetPublicPostsAsync();

        /// <summary>
        /// Get all pendind posts by a user to be displayed in the UI
        /// </summary>
        /// <param name="user">If the user is an Editor, it returns all pendined posts. Otherwise it returns only the posts wrotes
        /// by the user and in Pending status.
        /// </param>
        /// <returns></returns>
        Task<IEnumerable<SummaryPostViewModel>> GetPendingPostsByUserAsync(UserObject user);


        /// <summary>
        /// Get all posts written by an user and with a specific status.
        /// </summary>
        Task<IEnumerable<SummaryPostViewModel>> GetPostsByWriterIdAndStatusAsync(Guid writerId, PostStatus status);

        /// <summary>
        /// Gets a post by Id to be displayed in aEdit UI
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        Task<PostViewModel> GetPostByIdAsync(Guid postId);


        /// <summary>
        /// Create new post
        /// </summary>
        /// <param name="postView"></param>
        /// <param name="writerId"></param>
        /// <returns></returns>
        Task SavePostAsync(PostViewModel postView, Guid writerId);

        /// <summary>
        /// Update an existing post
        /// </summary>
        /// <param name="postView"></param>
        /// <returns></returns>
        Task<PostObject> UpdatePostAsync(PostViewModel postView);

        /// <summary>
        /// Removes a post
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        Task DeletePostAsync(Guid postId);
    }
}
