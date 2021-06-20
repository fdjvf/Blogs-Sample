using Blogs.Data.Model;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blogs.Services.Abstract
{
    public interface IUserService
    {
        Task<User> ValidateUserCredentials(string email, string password);
        ClaimsPrincipal GetUserIdentity(User user, string authType);
    }
}
