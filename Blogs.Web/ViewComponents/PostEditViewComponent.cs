using Blogs.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blogs.Web.ViewComponents
{
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
