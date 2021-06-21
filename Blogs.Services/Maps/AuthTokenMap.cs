using AutoMapper;
using Blogs.Data.Model;
using Blogs.Services.Dto;
using System.Linq;

namespace Blogs.Services.Maps
{
    public class AuthTokenMap : Profile
    {
        public AuthTokenMap()
        {
            CreateMap<AuthToken, AuthTokenObject>().
              ForMember(dest => dest.Token, opt => opt.MapFrom(src => src.Token))
             .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
             .ForMember(dest => dest.ExpirationDate, opt => opt.MapFrom(src => src.ExpirationDate))
             .ForMember(dest => dest.Roles, opt => opt.MapFrom(src => src.User.Roles.Select(r => r.Name)));
        }
    }
}
