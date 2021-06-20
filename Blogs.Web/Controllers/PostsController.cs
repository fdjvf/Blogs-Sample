using Blogs.Data.Model;
using Blogs.Services.Abstract;
using Blogs.Services.Utilities;
using Blogs.Services.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blogs.Web.Controllers
{
    [Authorize(Roles = "Writer")]
    public class PostsController : Controller
    {
        private IPostService PostService { get; }
        public PostsController(IPostService postService)
        {
            PostService = postService;
        }


        [Route("[controller]/Approved")]
        public async Task<IActionResult> ApprovedPosts()
        {
            var myPosts = await PostService.GetPostsByWriterIdAndStatus(User.GetId(), PostStatus.Approved);
            return View(myPosts);
        }

        [Route("[controller]/Rejected")]
        public async Task<IActionResult> RejectedPosts()
        {
            var myPosts = await PostService.GetPostsByWriterIdAndStatus(User.GetId(), PostStatus.Rejected);
            return View(myPosts);
        }

        [Authorize]
        [Authorize(Roles = "Writer,Editor")]
        [Route("[controller]/Pending")]
        public async Task<IActionResult> PendingPosts()
        {
            var pendingPosts = await PostService.GetPendingPostsByUser(User.ToUserObject());
            return View(pendingPosts);
        }

        [Route("[controller]/Add")]
        public IActionResult CreatePost()
        {
            return View("AddPost");
        }

        [HttpPost]
        [Route("[controller]/Add")]
        public async Task<IActionResult> CreatePost(PostViewModel postView)
        {
            if (ModelState.IsValid)
            {
                await PostService.SavePost(postView, User.GetId());
                return RedirectToAction("Pending");
            }

            return View("AddPost", postView);
        }
    }
}
