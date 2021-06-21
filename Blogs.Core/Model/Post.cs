using Blogs.Data.Enums;
using System;
using System.Collections.Generic;

#nullable disable

namespace Blogs.Data.Model
{
    /// <summary>
    /// Posts created by an user. It has 1 to many relationship with Comments
    /// </summary>
    public partial class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }

        public Guid Id { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
        public bool IsDeleted { get; set; }

        /// <summary>
        /// By default, the status of a recently created post is <see cref="PostStatus.PendingApproval"/>
        /// </summary>
        public PostStatus StatusId { get; set; }

        /// <summary>
        /// Creator of the post
        /// </summary>
        public Guid WriterId { get; set; }

        /// <summary>
        /// Date the Editor decides to Approve the Post.
        /// </summary>
        public DateTime? ApprovalDate { get; set; }

        /// <summary>
        /// Date the writer creates the post for the first time.
        /// </summary>
        public DateTime SubmitDate { get; set; }

        public virtual Status Status { get; set; }
        public virtual User Writer { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
