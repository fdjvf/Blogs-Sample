using Blogs.Services.Abstract;
using Blogs.Services.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blogs.Web.Controllers
{
    /// <summary>
    /// Controller used for Authentication purposes
    /// </summary>
    public class AccountController : Controller
    {
        private IUserService UserService { get; }
        public AccountController(IUserService userService)
        {
            UserService = userService;
        }

        /// <summary>
        /// Return the Login page for unauthenticated users
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");

            return View(new LoginViewModel());
        }

        /// <summary>
        /// Action user to valited the Login information and Signing in the user
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel loginInfo)
        {

            var user = await UserService.ValidateUserCredentials(loginInfo.UserName, loginInfo.Password);
            if (user != null)
            {
                var identity = UserService.GetUserIdentity(user, "Cookies");
                await HttpContext.SignInAsync("CookieAuth", identity);
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("WrongCredentials", "Wrong Credentials");
            return View(loginInfo);


        }

        /// <summary>
        /// Logout action. Only available for Authenticated users
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
