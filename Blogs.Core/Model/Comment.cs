using System;

#nullable disable

namespace Blogs.Data.Model
{
    /// <summary>
    /// Comments created by an user (authenticated or anonymous) in a Post
    /// </summary>
    public partial class Comment
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public bool IsDeleted { get; set; }
        /// <summary>
        /// WriterId can be null for Anonymous users
        /// </summary>
        public Guid? WriterId { get; set; }
        public Guid PostId { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual Post Post { get; set; }
        public virtual User Writer { get; set; }
    }
}
