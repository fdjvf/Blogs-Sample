using Blogs.Data.Enums;

namespace Blogs.Services.ViewModels
{
    /// <summary>
    /// Post model used for Edit UI interaction
    /// </summary>
    public class EditPostViewModel
    {
        public PostViewModel Post { get; set; }
        public string Title { get; set; }
        public PostStatus[] AllowedPostStatus { get; set; }
        public string RedirectAction { get; set; }
    }
}
