using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Blogs.Data.Model
{
    public enum PostStatus
    {
        [Display(Name = "Pending Approval")]
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
