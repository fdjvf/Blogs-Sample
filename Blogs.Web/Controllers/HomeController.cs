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

        public async Task<IActionResult> Index()
        {
            var posts = await PostService.GetPublicPostsAsync();
            return View(posts);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
