using Blogs.Services.Abstract;
using Blogs.Web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blogs.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private IUserService UserService { get; }
        public AccountController(IUserService userService)
        {
            UserService = userService;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");

            return View(new LoginViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel loginInfo)
        {
            if (ModelState.IsValid)
            {
                var user = await UserService.ValidateUserCredentials(loginInfo.Email, loginInfo.Password);
                if (user != null)
                {
                    var identity = UserService.GetUserIdentity(user,"Cookies");
                    await HttpContext.SignInAsync("CookieAuth", identity);
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("WrongCredentials", "Wrong Credentials");
            }
            return View(loginInfo);


        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
