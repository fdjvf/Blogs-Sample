using Blogs.Data.Enums;
using Blogs.Services.Abstract;
using Blogs.Services.Utilities;
using Blogs.Services.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Blogs.Web.Controllers
{
    /// <summary>
    /// Controller that manages all the Post interactions. Most of the actions
    /// here required the user to be authenticated
    /// </summary>
    [Authorize]
    public class PostsController : Controller
    {
        private IPostService PostService { get; }
        public PostsController(IPostService postService)
        {
            PostService = postService;
        }

        /// <summary>
        /// Returns a detailed view of a post. 
        /// Any user can see detailed approved posts
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [Route("[controller]/Detailed/{Id}")]
        public async Task<IActionResult> GetPost(Guid id)
        {
            var approvedPost = await PostService.GetPostByIdAsync(id);
            if (approvedPost != null)
            {
                if (approvedPost.Status == PostStatus.Approved)
                {
                    return View("DetailedPost", approvedPost);
                }
            }

            return RedirectToAction("AccessDenied", "Home");
        }

        /// <summary>
        /// Gets all the posts created by the current Writer Users and that
        /// also have been approved by an Editor
        /// Only for Writers
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = "Writer")]
        [Route("[controller]/Approved")]
        public async Task<IActionResult> ApprovedPosts()
        {
            var myPosts = await PostService.GetPostsByWriterIdAndStatusAsync(User.GetId(), PostStatus.Approved);
            return View(myPosts);
        }

        /// <summary>
        /// Gets all the posts created by the current Writer Users and that
        /// also have been rejected by an Editor
        /// Only for Writers
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = "Writer")]
        [Route("[controller]/Rejected")]
        public async Task<IActionResult> RejectedPosts()
        {
            var myPosts = await PostService.GetPostsByWriterIdAndStatusAsync(User.GetId(), PostStatus.Rejected);
            return View(myPosts);
        }

        /// <summary>
        /// If the user is an Editor, it will return all pendind posts
        /// otherwise, it will return all pending posts wrote by the current user.
        /// Only for Writers/Editors
        /// </summary>
        /// <returns></returns>
        [Route("[controller]/Pending")]
        public async Task<IActionResult> PendingPosts()
        {
            var pendingPosts = await PostService.GetPendingPostsByUserAsync(User.ToUserObject());
            return View(pendingPosts);
        }

        /// <summary>
        /// Returns a form to create a new post 
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = "Writer")]
        [Route("[controller]/Add")]
        public IActionResult CreatePost()
        {
            return View("AddPost");
        }

        /// <summary>
        /// Creates a new post written by the current user
        /// Only writers can create posts
        /// </summary>
        /// <param name="postView"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "Writer")]
        [Route("[controller]/Add")]
        public async Task<IActionResult> CreatePost(PostViewModel postView)
        {
            await PostService.SavePostAsync(postView, User.GetId());
            return RedirectToAction("Pending");
        }

        /// <summary>
        /// Returns a view to edit rejected posts
        /// Only for Writers
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize(Roles = "Writer")]
        [Route("[controller]/Rejected/{Id}")]
        public async Task<IActionResult> EditRejectedPost(Guid id)
        {
            var rejectedPost = await PostService.GetPostByIdAsync(id);
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

        // <summary>
        /// Returns a view to approve/reject pending posts
        /// Only for Editors
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize(Roles = "Editor")]
        [Route("[controller]/Pending/{Id}")]
        public async Task<IActionResult> EditPendingPost(Guid id)
        {
            var pendingPost = await PostService.GetPostByIdAsync(id);
            if (pendingPost != null)
            {
                if (pendingPost.Status == PostStatus.PendingApproval)
                {
                    return View("EditPost", new EditPostViewModel
                    {
                        Post = pendingPost,
                        Title = "Approve Post",
                        AllowedPostStatus = new PostStatus[] { PostStatus.Rejected, PostStatus.Approved },
                        RedirectAction = "Pending"
                    });
                }
            }
            return RedirectToAction("AccessDenied", "Home");
        }

        /// <summary>
        /// Edits a post
        /// </summary>
        /// <param name="postView"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[controller]/Edit")]
        public async Task<IActionResult> EditPost(EditPostViewModel postView)
        {
            await PostService.UpdatePostAsync(postView.Post);
            return RedirectToAction(postView.RedirectAction);
        }

        /// <summary>
        /// Edits a post
        /// </summary>
        /// <param name="postView"></param>
        /// <returns></returns>
        [Authorize(Roles = "Editor")]
        [Route("[controller]/Remove/{Id}")]
        public async Task<IActionResult> DeletePost(Guid id)
        {
            await PostService.DeletePostAsync(id);
            return RedirectToAction("Index","Home");
        }
    }
}
