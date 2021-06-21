using AutoMapper;
using Blogs.Data.Model;
using Blogs.Services.Dto;

namespace Blogs.Services.Maps
{
    /// <summary>
    /// Automatic mapping between <see cref="Post"/> and <see cref="PostObject"/>
    /// </summary>
    public class PostMap : Profile
    {
        public PostMap()
        {
            CreateMap<Post, PostObject>().
               ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
              .ForMember(dest => dest.WriterName, opt => opt.MapFrom(src => src.Writer.Name))
              .ForMember(dest => dest.SubmitDate, opt => opt.MapFrom(src => src.SubmitDate));

        }
    }
}
