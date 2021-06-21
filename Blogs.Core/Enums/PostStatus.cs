using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Blogs.Data.Enums
{
    /// <summary>
    /// Possible statuses a Post can have between submission and publication.
    /// </summary>
    public enum PostStatus
    {
        [Display(Name = "Pending Approval")]
        PendingApproval = 0,
        Approved = 1,
        Rejected = 2
    }
}
