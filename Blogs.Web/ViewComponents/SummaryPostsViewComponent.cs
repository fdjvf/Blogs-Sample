using Blogs.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Blogs.Web.ViewComponents
{
    public class SummaryPostsViewComponent : ViewComponent
    {
        public SummaryPostsViewComponent()
        {

        }

        public IViewComponentResult Invoke(IEnumerable<SummaryPostViewModel> posts)
        {
            return View(posts);
        }
    }
}
