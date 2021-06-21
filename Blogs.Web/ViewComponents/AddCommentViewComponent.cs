using Blogs.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Blogs.Services.Utilities;

namespace Blogs.Web.ViewComponents
{
    /// <summary>
    /// View Component used to show a form for adding new comments to a Post
    /// </summary>
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
