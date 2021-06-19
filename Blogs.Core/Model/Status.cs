using System.Collections.Generic;

#nullable disable

namespace Blogs.Core.Model
{
    public enum PostStatus
    {
        PendingApproval = 0,
        Approved = 1,
        Rejected = 2
    }

    public partial class Status
    {
        public Status()
        {
            Posts = new HashSet<Post>();
        }

        public PostStatus Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
