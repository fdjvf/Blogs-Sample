using Blogs.Data.Model;
using Blogs.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Blogs.Web.Controllers
{
    public class PostsController : Controller
    {
        private IPostService PostService { get; }
        public PostsController(IPostService postService)
        {
            PostService = postService;
        }

        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> ApprovedPosts()
        {
            var myPosts = await PostService.GetPostsByWriterIdAndStatus(Guid.Parse(User.FindFirst("Id").Value), PostStatus.Approved);
            return View(myPosts);
        }

        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> RejectedPosts()
        {
            var myPosts = await PostService.GetPostsByWriterIdAndStatus(Guid.Parse(User.FindFirst("Id").Value), PostStatus.Rejected);
            return View(myPosts);
        }
        [Authorize(Roles = "Editor")]
        public async Task<IActionResult> PendingPosts()
        {
            var pendingPosts = await PostService.GetPendingPosts();
            return View(pendingPosts);
        }


        [Authorize(Roles = "Writer")]
        public IActionResult CreatePost()
        {
            return View();
        }

    }
}
