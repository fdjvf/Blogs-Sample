using Blogs.Data.Abstract;
using Blogs.Data.Model;
using Blogs.Services.Abstract;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blogs.Services
{
    public class UserService : IUserService
    {
        private IUserRepository UserRepository { get; }

        public UserService(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public ClaimsPrincipal GetUserIdentity(User user,string authType)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,user.Email),
                new Claim(ClaimTypes.Email,user.Email)
            };

            foreach (var role in user.Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role.Name));
            }

            var mainIdentity = new ClaimsIdentity(claims, authType);

            var principal = new ClaimsPrincipal(mainIdentity);

            return principal;
        }

        public async Task<User> ValidateUserCredentials(string email, string password)
        {
            var user = await UserRepository.GetUserByEmail(email);

            //Complicated password comparison
            if (user?.Password == password)
                return user;

            return null;
        }
    }
}
