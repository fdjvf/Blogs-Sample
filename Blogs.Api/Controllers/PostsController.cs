using Blogs.Api.Attributes;
using Blogs.Data.Enums;
using Blogs.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Blogs.Api.Controllers
{
    [ApiController]
    [AuthToken]
    [Route("[controller]/[action]")]
    public class PostsController : ControllerBase
    {
        IPostService PostService { get; }

        public PostsController(IPostService postService)
        {
            PostService = postService;
        }

        /// <summary>
        /// Returns all pending post
        /// </summary>
        public async Task<IActionResult> GetPendingPosts()
        {
            var pendingPosts = await PostService.GetPendingPosts();
            return Ok(new { Count = pendingPosts.Count(), Posts = pendingPosts });
        }

        /// <summary>
        /// Update a Post that is in Pending status to "Rejected" or "Approved" and returns the updated post.
        /// Returns BadRequest is the Post is not in Pending status
        /// </summary>
        /// <param name="postId">Post to update</param>
        /// <param name="postStatus">New post status</param>
        [HttpPost]
        [Route("{PostId}")]
        public async Task<IActionResult> UpdatePostStatus([FromRoute] Guid postId, [FromQuery] PostStatus postStatus)
        {
            if (postStatus == PostStatus.PendingApproval)
                return BadRequest("PostStatus value can only be 'Rejected' or 'Approved'.");

            var postToUpdate = await PostService.GetPostById(postId);

            if (postToUpdate.Status != PostStatus.PendingApproval)
                return BadRequest("Unable to update this Post because it's not pending approval.");

            postToUpdate.Status = postStatus;

            return Ok(await PostService.UpdatePost(postToUpdate));
        }
    }
}
