using AutoMapper;
using Blogs.Data.Model;
using Blogs.Services.ViewModels;

namespace Blogs.Services.Maps
{

    /// <summary>
    /// Automatic mapping between <see cref="Post"/> and <see cref="PostViewModel"/>
    /// </summary>
    public class PostViewModelMap : Profile
    {
        public PostViewModelMap()
        {
            CreateMap<Post, PostViewModel>().
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
               .ForMember(dest => dest.WriterId, opt => opt.MapFrom(src => src.WriterId))
               .ForMember(dest => dest.WriterName, opt => opt.MapFrom(src => src.Writer.Name))
               .ForMember(dest => dest.ApprovalDate, opt => opt.MapFrom(src => src.ApprovalDate))
               .ForMember(dest => dest.SubmitDate, opt => opt.MapFrom(src => src.SubmitDate))
               .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Text))
               .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.StatusId))
               .ReverseMap()
               .ForMember(dest => dest.Status, opt => opt.Ignore());
        }
    }
}
