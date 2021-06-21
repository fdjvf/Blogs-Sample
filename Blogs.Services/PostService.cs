using AutoMapper;
using Blogs.Data.Abstract;
using Blogs.Data.Enums;
using Blogs.Data.Model;
using Blogs.Services.Abstract;
using Blogs.Services.Dto;
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

        public async Task<IEnumerable<SummaryPostViewModel>> GetPendingPostsByUser(UserObject user)
        {
            var pendingPosts = await PostRepository.GetPostsByStatus(PostStatus.PendingApproval);

            if (user.Roles.Contains("Writer"))
            {
                pendingPosts = pendingPosts.Where(post => post.WriterId == user.Id);
            }
            else if (!user.Roles.Contains("Editor"))//If the user is neither a Writer or a Editor, return empty list
            {
                pendingPosts = new List<Post>();
            }

            var result = Mapper.Map<IEnumerable<SummaryPostViewModel>>(pendingPosts);

            return result;
        }

        public async Task<IEnumerable<SummaryPostViewModel>> GetPostsByWriterIdAndStatus(Guid writerId, PostStatus status)
        {
            var publicPosts = await PostRepository.GetPostsByWriterId(writerId);
            publicPosts = publicPosts.Where(post => post.StatusId == status);
            var result = Mapper.Map<IEnumerable<SummaryPostViewModel>>(publicPosts);

            return result;
        }

        public async Task SavePost(PostViewModel postView, Guid writerId)
        {
            await PostRepository.SavePost(postView.Content, postView.Title, writerId);
        }

        public async Task<PostObject> UpdatePost(PostViewModel postView)
        {

            var post = Mapper.Map<Post>(postView);
            if (postView.Status == PostStatus.Approved)
                post.ApprovalDate = DateTime.Now;

            var updatedPost = await PostRepository.UpdatePost(post);

            return Mapper.Map<PostObject>(updatedPost);
        }

        public async Task<PostViewModel> GetPostById(Guid postId)
        {
            var post = await PostRepository.GetPostById(postId);
            var result = Mapper.Map<PostViewModel>(post);

            return result;
        }

        public async Task<IEnumerable<PostObject>> GetPendingPosts()
        {
            var pendingPosts = await PostRepository.GetPostsByStatus(PostStatus.PendingApproval);
            var result = Mapper.Map<IEnumerable<PostObject>>(pendingPosts);
            return result;
        }
    }
}
