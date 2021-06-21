using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Blogs.Data.Enums
{
    public enum PostStatus
    {
        [Display(Name = "Pending Approval")]
        PendingApproval = 0,
        Approved = 1,
        Rejected = 2
    }
}
