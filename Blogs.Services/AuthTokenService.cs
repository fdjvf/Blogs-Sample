using AutoMapper;
using Blogs.Data.Abstract;
using Blogs.Services.Abstract;
using Blogs.Services.Dto;
using System.Threading.Tasks;

namespace Blogs.Services
{
    public class AuthTokenService : IAuthTokenService
    {
        private IAuthTokenRepository AuthTokenRepository { get; }
        private IMapper Mapper { get; }

        public AuthTokenService(IAuthTokenRepository authTokenRepository, IMapper mapper)
        {
            AuthTokenRepository = authTokenRepository;
            Mapper = mapper;
        }

        public async Task<AuthTokenObject> GetTokenInfoAsync(string token)
        {
            var authtoken = await AuthTokenRepository.GetAuthTokenByTokenAsync(token);
            return Mapper.Map<AuthTokenObject>(authtoken);
        }
    }
}
