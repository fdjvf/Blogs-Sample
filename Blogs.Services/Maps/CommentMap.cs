using AutoMapper;
using Blogs.Data.Model;
using Blogs.Services.ViewModels;

namespace Blogs.Services.Maps
{
    /// <summary>
    /// Automatic mapping between <see cref="Comment"/> and <see cref="CommentViewModel"/>
    /// </summary>
    public class CommentMap : Profile
    {
        public CommentMap()
        {
            CreateMap<Comment, CommentViewModel>().
                ForMember(dest => dest.PostId, opt => opt.MapFrom(src => src.PostId))
               .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Text))
               .ForMember(dest => dest.WriterId, opt => opt.MapFrom(src => src.WriterId))
               .ForMember(dest => dest.CreationDate, opt => opt.MapFrom(src => src.CreationDate))
               .ForMember(dest => dest.WriterName, opt => opt.MapFrom(src => src.Writer.Name));
        }
    }
}
