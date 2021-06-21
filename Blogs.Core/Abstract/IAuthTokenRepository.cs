using Blogs.Data.Model;
using System.Threading.Tasks;

namespace Blogs.Data.Abstract
{
    /// <summary>
    /// Manages access to <see cref="AuthToken"/> objects
    ///</summary>
    public interface IAuthTokenRepository
    {
        /// <summary>
        /// Get user's token information. Used for Auth validation
        /// </summary>
        Task<AuthToken> GetAuthTokenByTokenAsync(string token);
    }
}
