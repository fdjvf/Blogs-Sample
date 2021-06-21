using Blogs.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Blogs.Web.ViewComponents
{
    public class CommentsViewComponent : ViewComponent
    {
        private ICommentsService CommentsService { get; }
        public CommentsViewComponent(ICommentsService service)
        {
            CommentsService = service;
        }

        public async Task<IViewComponentResult> InvokeAsync(Guid postId)
        {
            var postComments = await CommentsService.GetCommentsByPostIdAsync(postId);
            return View(postComments);
        }
    }
}
