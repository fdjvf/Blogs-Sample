using Blogs.Services.Dto;
using System.Threading.Tasks;

namespace Blogs.Services.Abstract
{
    /// <summary>
    /// Services used by the API to get the Tokens related information (Including its owner) 
    /// </summary>
    public interface IAuthTokenService
    {
        Task<AuthTokenObject> GetTokenInfoAsync(string token);

    }
}
