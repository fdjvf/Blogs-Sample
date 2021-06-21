using AutoMapper;
using Blogs.Data.Model;
using Blogs.Services.Dto;
using System.Linq;

namespace Blogs.Services.Maps
{
    public class UserMap : Profile
    {
        public UserMap()
        {
            CreateMap<User, UserObject>().
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
               .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
               .ForMember(dest => dest.Roles, opt => opt.MapFrom(src => src.Roles.Select(x => x.Name)));
        }
    }
}
