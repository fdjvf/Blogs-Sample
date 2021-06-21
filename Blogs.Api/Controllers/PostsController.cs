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

        public async Task<IActionResult> GetPendingPosts()
        {
            var pendingPosts = await PostService.GetPendingPosts();
            return Ok(new { Count = pendingPosts.Count(), Posts = pendingPosts });
        }

        [HttpPost]
        [Route("{PostId}")]
        public async Task<IActionResult> UpdatePostStatus([FromRoute] Guid postId, [FromQuery] PostStatus postStatus)
        {
            if (postStatus == PostStatus.PendingApproval)
                return BadRequest("PostStatus can only be 'Rejected' or 'Approved'.");

            var postToUpdate = await PostService.GetPostById(postId);

            if (postToUpdate.Status != PostStatus.PendingApproval)
                return BadRequest("Unable to update this because it's not pending approval.");

            postToUpdate.Status = postStatus;

            return Ok(await PostService.UpdatePost(postToUpdate));
        }
    }
}
