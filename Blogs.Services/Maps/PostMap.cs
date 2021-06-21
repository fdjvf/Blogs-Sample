using AutoMapper;
using Blogs.Data.Model;
using Blogs.Services.ViewModels;

namespace Blogs.Services.Maps
{
    public class PostMap : Profile
    {
        public PostMap()
        {
            CreateMap<Post, PostViewModel>().
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))               
               .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
               .ForMember(dest => dest.WriterId, opt => opt.MapFrom(src => src.WriterId))
               .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Text))
               .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.StatusId))
               .ReverseMap()
               .ForMember(dest => dest.Status, opt => opt.Ignore())
               ;
        }
    }
}
