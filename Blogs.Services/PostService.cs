using AutoMapper;
using Blogs.Data.Abstract;
using Blogs.Data.Model;
using Blogs.Services.Abstract;
using Blogs.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogs.Services
{
    public class PostService : IPostService
    {
        private IPostRepository PostRepository { get; }
        private IMapper Mapper { get; }

        public PostService(IPostRepository postRepository, IMapper mapper)
        {
            PostRepository = postRepository;
            Mapper = mapper;
        }

        public async Task<IEnumerable<SummaryPostViewModel>> GetPublicPosts()
        {
            var publicPosts = await PostRepository.GetPostsByStatus(PostStatus.Approved);

            var result = Mapper.Map<IEnumerable<SummaryPostViewModel>>(publicPosts);

            return result;
        }

        public async Task<IEnumerable<SummaryPostViewModel>> GetPendingPosts()
        {
            var publicPosts = await PostRepository.GetPostsByStatus(PostStatus.PendingApproval);

            var result = Mapper.Map<IEnumerable<SummaryPostViewModel>>(publicPosts);

            return result;
        }

        public async Task<IEnumerable<SummaryPostViewModel>> GetPostsByWriterIdAndStatus(Guid writerId, PostStatus status)
        {
            var publicPosts = await PostRepository.GetPostsByWriterId(writerId);
            publicPosts = publicPosts.Where(post => post.StatusId == status);
            var result = Mapper.Map<IEnumerable<SummaryPostViewModel>>(publicPosts);

            return result;
        }
    }
}
