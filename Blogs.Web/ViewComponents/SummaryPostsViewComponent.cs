using Blogs.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Blogs.Web.ViewComponents
{
    /// <summary>
    /// View component used to shows a summary of post
    /// </summary>
    public class SummaryPostsViewComponent : ViewComponent
    {
        public SummaryPostsViewComponent()
        {

        }

        public IViewComponentResult Invoke(IEnumerable<SummaryPostViewModel> posts, string editAction)
        {
            return View((posts, editAction));
        }
    }
}
