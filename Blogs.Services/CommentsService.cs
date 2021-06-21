using AutoMapper;
using Blogs.Data.Abstract;
using Blogs.Data.Model;
using Blogs.Services.Abstract;
using Blogs.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blogs.Services
{
    public class CommentsService : ICommentsService
    {
        private ICommentRepository CommentRepository { get; }
        private IMapper Mapper { get; }

        public CommentsService(ICommentRepository commentRepository, IMapper mapper)
        {
            CommentRepository = commentRepository;
            Mapper = mapper;
        }

        public async Task SaveComment(CommentViewModel commentViewModel)
        {
            await CommentRepository.SaveComment(commentViewModel.PostId, commentViewModel.Text, commentViewModel.WriterId);
        }

        public async Task<IEnumerable<CommentViewModel>> GetCommentsByPostId(Guid postId)
        {
            var comments = await CommentRepository.GetCommentsByPostId(postId);
            return Mapper.Map<IEnumerable<CommentViewModel>>(comments);
        }
    }
}
