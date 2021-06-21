using Blogs.Data.Abstract;
using Blogs.Data.Model;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Blogs.Data.Repositories
{
    internal class AuthTokenRepository : BaseRepository<BlogsContext>, IAuthTokenRepository
    {
        public AuthTokenRepository(BlogsContext blogContext) : base(blogContext)
        {

        }

        public async Task<AuthToken> GetAuthTokenByToken(string token)
        {
            return await Db.AuthTokens
                .Include(at => at.User)
                .ThenInclude(at => at.Roles)
                .FirstOrDefaultAsync(at => at.Token == token);
        }
    }
}
