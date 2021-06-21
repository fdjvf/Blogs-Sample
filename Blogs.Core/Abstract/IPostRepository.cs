using Blogs.Data.Enums;
using Blogs.Data.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blogs.Data.Abstract
{
    /// <summary>
    /// Manages access to <see cref="Post"/> objects
    ///</summary>
    public interface IPostRepository
    {
        /// <summary>
        /// Get all posts by using the writer's Id
        /// </summary>
        /// <param name="writerId"></param>
        /// <returns></returns>
        Task<IEnumerable<Post>> GetPostsByWriterId(Guid writerId);

        /// <summary>
        /// Get posts that are have a specific Status
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Post>> GetPostsByStatus(PostStatus status);

        /// <summary>
        /// Get post by Id
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        Task<Post> GetPostById(Guid postId);

        /// <summary>
        /// Creates new post
        /// </summary>
        /// <param name="text">Post content</param>
        /// <param name="writerId">Writer's post</param>
        /// <param name="title">Title of the post</param>
        /// <returns></returns>
        Task SavePost(string text, string title, Guid writerId);

        /// <summary>
        /// Apply update to an existing post.
        /// </summary>
        /// <param name="updatedPost"></param>
        /// <returns></returns>
        Task<Post> UpdatePost(Post updatedPost);

        /// <summary>
        /// Soft delete a post by Id
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        Task SoftDeletePost(Guid postId);        
    }
}
