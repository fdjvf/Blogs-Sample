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

        public async Task<AuthToken> GetAuthTokenByTokenAsync(string token)
        {
            return await Db.AuthTokens
                .Include(at => at.User)
                .ThenInclude(at => at.Roles)//We do this include, because later we need to validate the user's roles as well.
                .FirstOrDefaultAsync(at => at.Token == token);
        }
    }
}
