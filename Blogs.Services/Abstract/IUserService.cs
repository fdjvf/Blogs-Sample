using Blogs.Services.Dto;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blogs.Services.Abstract
{
    /// <summary>
    /// Service use for Auth purposes
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Checks wheter a user exist with that specific userName and Password
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<UserObject> ValidateUserCredentials(string userName, string password);

        /// <summary>
        /// Creates an User Identity base on the information of an already authenticated user.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="authType"></param>
        /// <returns></returns>
        ClaimsPrincipal GetUserIdentity(UserObject user, string authType);
    }
}
