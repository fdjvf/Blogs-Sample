using Blogs.Services.Dto;
using System.Threading.Tasks;

namespace Blogs.Services.Abstract
{
    public interface IAuthTokenService
    {
        Task<AuthTokenObject> GetTokenInfo(string token);

    }
}
