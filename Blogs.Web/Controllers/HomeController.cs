using Blogs.Services.Abstract;
using Blogs.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
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
            var posts = await PostService.GetPublicPosts();
            return View(posts);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
