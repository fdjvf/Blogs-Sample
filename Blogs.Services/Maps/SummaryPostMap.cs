using AutoMapper;
using Blogs.Data.Model;
using Blogs.Services.ViewModels;

namespace Blogs.Services.Maps
{
    /// <summary>
    /// Automatic mapping between <see cref="Post"/> and <see cref="SummaryPostViewModel"/>
    /// </summary>
    public class SummaryPostMap : Profile
    {
        public SummaryPostMap()
        {
            CreateMap<Post, SummaryPostViewModel>().
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.PublishedOn, opt => opt.MapFrom(src => src.ApprovalDate))
               .ForMember(dest => dest.WriterName, opt => opt.MapFrom(src => src.Writer.Name))
               .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
               .ForMember(dest => dest.ShortDescription, opt => opt.MapFrom(src => src.Text));
        }
    }
}