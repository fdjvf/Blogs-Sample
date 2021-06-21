using Blogs.Services.Abstract;
using Blogs.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blogs.Web.Controllers
{
    /// <summary>
    /// Controller to manage the Post's comments
    /// </summary>
    public class CommentsController : Controller
    {
        private ICommentsService CommentsService { get; }
        public CommentsController(ICommentsService service)
        {
            CommentsService = service;
        }

        /// <summary>
        /// Action to create a new comment in a post
        /// </summary>
        /// <param name="commentView"></param>
        /// <returns></returns>
        public async Task<IActionResult> CreateComment(CommentViewModel commentView)
        {           
            await CommentsService.SaveCommentAsync(commentView);
            return RedirectToAction("Detailed", "Posts", new { Id = commentView.PostId });
        }
    }
}
