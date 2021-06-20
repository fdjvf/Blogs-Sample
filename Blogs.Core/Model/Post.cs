using System;
using System.Collections.Generic;

#nullable disable

namespace Blogs.Data.Model
{
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
        public PostStatus StatusId { get; set; }
        public Guid WriterId { get; set; }
        public DateTime? ApprovalDate { get; set; }

        public virtual Status Status { get; set; }
        public virtual User Writer { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
