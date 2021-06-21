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
        Task<IEnumerable<SummaryPostViewModel>> GetPublicPosts();
        Task<IEnumerable<PostObject>> GetPendingPosts();

        Task<IEnumerable<SummaryPostViewModel>> GetPendingPostsByUser(UserObject user);
        Task<IEnumerable<SummaryPostViewModel>> GetPostsByWriterIdAndStatus(Guid writerId, PostStatus status);
        Task<PostViewModel> GetPostById(Guid postId);


        /// <summary>
        /// Create new post
        /// </summary>
        /// <param name="postView"></param>
        /// <param name="writerId"></param>
        /// <returns></returns>
        Task SavePost(PostViewModel postView, Guid writerId);

        /// <summary>
        /// Update an existing post
        /// </summary>
        /// <param name="postView"></param>
        /// <returns></returns>
        Task<PostObject> UpdatePost(PostViewModel postView);
    }
}
