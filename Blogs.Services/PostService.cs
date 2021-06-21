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

        public async Task<IEnumerable<PostObject>> GetPendingPostsAsync()
        {
            var pendingPosts = await PostRepository.GetPostsByStatus(PostStatus.PendingApproval);
            var result = Mapper.Map<IEnumerable<PostObject>>(pendingPosts);
            return result;
        }

        public async Task<PostViewModel> GetPostByIdAsync(Guid postId)
        {
            var post = await PostRepository.GetPostById(postId);
            var result = Mapper.Map<PostViewModel>(post);

            return result;
        }        

        public async Task<IEnumerable<SummaryPostViewModel>> GetPublicPostsAsync()
        {
            var publicPosts = await PostRepository.GetPostsByStatus(PostStatus.Approved);
            publicPosts = publicPosts.OrderByDescending(post => post.ApprovalDate);

            var result = Mapper.Map<IEnumerable<SummaryPostViewModel>>(publicPosts);

            return result;
        }

        public async Task<IEnumerable<SummaryPostViewModel>> GetPendingPostsByUserAsync(UserObject user)
        {
            var pendingPosts = await PostRepository.GetPostsByStatus(PostStatus.PendingApproval);
            pendingPosts = pendingPosts.OrderByDescending(post => post.SubmitDate);

            if (user.IsWriter)
            {
                pendingPosts = pendingPosts.Where(post => post.WriterId == user.Id);
            }
            else if (!user.IsEditor)//If the user is neither a Writer or a Editor, return empty list
            {
                pendingPosts = new List<Post>();
            }

            var result = Mapper.Map<IEnumerable<SummaryPostViewModel>>(pendingPosts);

            return result;
        }

        public async Task<IEnumerable<SummaryPostViewModel>> GetPostsByWriterIdAndStatusAsync(Guid writerId, PostStatus status)
        {
            var publicPosts = await PostRepository.GetPostsByWriterId(writerId);
            publicPosts = publicPosts.Where(post => post.StatusId == status);

            if (status== PostStatus.Approved)
                publicPosts = publicPosts.OrderByDescending(post => post.ApprovalDate);
            else
                publicPosts = publicPosts.OrderByDescending(post => post.SubmitDate);


            var result = Mapper.Map<IEnumerable<SummaryPostViewModel>>(publicPosts);

            return result;
        }

        public async Task SavePostAsync(PostViewModel postView, Guid writerId)
        {
            await PostRepository.SavePost(postView.Content, postView.Title, writerId);
        }

        public async Task<PostObject> UpdatePostAsync(PostViewModel postView)
        {

            var post = Mapper.Map<Post>(postView);
            if (postView.Status == PostStatus.Approved)
                post.ApprovalDate = DateTime.UtcNow;

            var updatedPost = await PostRepository.UpdatePost(post);

            return Mapper.Map<PostObject>(updatedPost);
        }

        public async Task DeletePostAsync(Guid postId)
        {
            await PostRepository.SoftDeletePost(postId);
        }
    }
}
