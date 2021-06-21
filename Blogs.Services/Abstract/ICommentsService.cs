using Blogs.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blogs.Services.Abstract
{
    public interface ICommentsService
    {
        Task SaveComment(CommentViewModel newComment);

        Task<IEnumerable<CommentViewModel>> GetCommentsByPostId(Guid postId);

    }
}
