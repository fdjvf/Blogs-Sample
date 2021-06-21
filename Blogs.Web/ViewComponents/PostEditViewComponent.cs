using Blogs.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blogs.Web.ViewComponents
{
    /// <summary>
    /// View Component used to manage edition of a Post by both Writers and Editors
    /// </summary>
    public class PostEditViewComponent : ViewComponent
    {
        public PostEditViewComponent()
        {

        }

        public IViewComponentResult Invoke(EditPostViewModel postEditViewModel)
        {
            return View(postEditViewModel);
        }
    }
}
