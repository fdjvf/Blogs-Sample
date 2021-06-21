using Blogs.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Blogs.Services.Utilities;

namespace Blogs.Web.ViewComponents
{
    public class AddCommentViewComponent : ViewComponent
    {
        public AddCommentViewComponent()
        {

        }

        public IViewComponentResult Invoke(CommentViewModel newComment)
        {
            newComment.WriterId = !User.Identity.IsAuthenticated ? null : UserClaimsPrincipal.GetId();
            return View(newComment);
        }
    }
}
