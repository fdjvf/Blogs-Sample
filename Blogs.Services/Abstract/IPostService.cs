using Blogs.Data.Model;
using Blogs.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blogs.Services.Abstract
{
    public interface IPostService
    {
        Task<IEnumerable<SummaryPostViewModel>> GetPublicPosts();
        Task<IEnumerable<SummaryPostViewModel>> GetPendingPosts();
        Task<IEnumerable<SummaryPostViewModel>> GetPostsByWriterIdAndStatus(Guid writerId,PostStatus status);

    }
}
