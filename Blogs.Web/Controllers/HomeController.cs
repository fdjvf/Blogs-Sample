using Blogs.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blogs.Web.Controllers
{
    public class HomeController : Controller
    {
        private IPostService PostService { get; }

        public HomeController(IPostService postService)
        {
            PostService = postService;
        }

        /// <summary>
        /// Shows all the posts that are approved and can be viewed
        /// by both anonymous and authenticated users.
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            var posts = await PostService.GetPublicPostsAsync();
            return View(posts);
        }

        /// <summary>
        /// Shows a denied page whenever a user tries to access a page they
        /// do not have access to
        /// </summary>
        /// <returns></returns>
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
