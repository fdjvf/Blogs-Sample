using AutoMapper;
using Blogs.Data.Abstract;
using Blogs.Services.Abstract;
using Blogs.Services.Dto;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blogs.Services
{
    public class UserService : IUserService
    {
        private IUserRepository UserRepository { get; }
        private IMapper Mapper { get; }

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            UserRepository = userRepository;
            Mapper = mapper;
        }

        public ClaimsPrincipal GetUserIdentity(UserObject user, string authType)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim(ClaimTypes.GivenName,user.Name),
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString())
            };

            foreach (var role in user.Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var mainIdentity = new ClaimsIdentity(claims, authType);

            var principal = new ClaimsPrincipal(mainIdentity);
            return principal;
        }

        public async Task<UserObject> ValidateUserCredentials(string email, string password)
        {
            var user = await UserRepository.GetUserByUserName(email);

            //Complicated password comparison
            if (user?.Password == password)
                return Mapper.Map<UserObject>(user);

            return null;
        }
    }
}
