using Blogs.Data.Enums;
using Blogs.Services.Abstract;
using Blogs.Services.Utilities;
using Blogs.Services.ViewModels;
using Blogs.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Blogs.Web.Controllers
{
    [Authorize]
    public class PostsController : Controller
    {
        private IPostService PostService { get; }
        public PostsController(IPostService postService)
        {
            PostService = postService;
        }

        [Authorize(Roles = "Writer")]
        [Route("[controller]/Approved")]
        public async Task<IActionResult> ApprovedPosts()
        {
            var myPosts = await PostService.GetPostsByWriterIdAndStatus(User.GetId(), PostStatus.Approved);
            return View(myPosts);
        }

        [Authorize(Roles = "Writer")]
        [Route("[controller]/Rejected")]
        public async Task<IActionResult> RejectedPosts()
        {
            var myPosts = await PostService.GetPostsByWriterIdAndStatus(User.GetId(), PostStatus.Rejected);
            return View(myPosts);
        }

        [Authorize]
        [Route("[controller]/Pending")]
        public async Task<IActionResult> PendingPosts()
        {
            var pendingPosts = await PostService.GetPendingPostsByUser(User.ToUserObject());
            return View(pendingPosts);
        }



        [Authorize(Roles = "Writer")]
        [Route("[controller]/Add")]
        public IActionResult CreatePost()
        {
            return View("AddPost");
        }

        [HttpPost]
        [Authorize(Roles = "Writer")]
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


        [Authorize(Roles = "Writer")]
        [Route("[controller]/Rejected/{Id}")]
        public async Task<IActionResult> EditRejectedPost(Guid id)
        {
            var rejectedPost = await PostService.GetPostById(id);
            if (rejectedPost != null)
            {
                if (rejectedPost.Status == PostStatus.Rejected && rejectedPost.WriterId == User.GetId())
                {
                    return View("EditPost", new EditPostViewModel
                    {
                        Post = rejectedPost,
                        Title = "Review Post",
                        AllowedPostStatus = new PostStatus[] { PostStatus.PendingApproval, PostStatus.Rejected },
                        RedirectAction = "Rejected"
                    });
                }
            }
            return RedirectToAction("AccessDenied", "Home");
        }


        [Authorize(Roles = "Editor")]
        [Route("[controller]/Pending/{Id}")]
        public async Task<IActionResult> EditPendingPost(Guid id)
        {
            var pendingPost = await PostService.GetPostById(id);
            if (pendingPost != null)
            {
                if (pendingPost.Status == PostStatus.PendingApproval)
                {
                    return View("EditPost", new EditPostViewModel
                    {
                        Post = pendingPost,
                        Title = "Approve Post",
                        AllowedPostStatus = new PostStatus[] { PostStatus.PendingApproval, PostStatus.Approved },
                        RedirectAction = "Pending"
                    });
                }
            }
            return RedirectToAction("AccessDenied", "Home");
        }

        [HttpPost]
        [Route("[controller]/Edit")]
        public async Task<IActionResult> EditPost(EditPostViewModel postView)
        {
            await PostService.UpdatePost(postView.Post);
            return RedirectToAction(postView.RedirectAction);
        }
    }
}
