using Blogs.Data.Model;
using Blogs.Services.ViewModels;

namespace Blogs.Web.ViewModels
{
    public class EditPostViewModel
    {
        public PostViewModel Post { get; set; }
        public string Title { get; set; }
        public PostStatus[] AllowedPostStatus { get; set; }
        public string RedirectAction { get; set; }
    }
}
