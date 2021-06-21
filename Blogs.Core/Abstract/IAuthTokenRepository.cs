using Blogs.Data.Model;
using System.Threading.Tasks;

namespace Blogs.Data.Abstract
{
    public interface IAuthTokenRepository
    {
        Task<AuthToken> GetAuthTokenByToken(string token);
    }
}
