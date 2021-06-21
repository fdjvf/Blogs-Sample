using Blogs.Services.Abstract;
using Blogs.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blogs.Web.Controllers
{
    public class CommentsController : Controller
    {
        private ICommentsService CommentsService { get; }
        public CommentsController(ICommentsService service)
        {
            CommentsService = service;
        }

        public async Task<IActionResult> CreateComment(CommentViewModel commentView)
        {           
            await CommentsService.SaveComment(commentView);
            return RedirectToAction("Detailed", "Posts", new { Id = commentView.PostId });
        }
    }
}
