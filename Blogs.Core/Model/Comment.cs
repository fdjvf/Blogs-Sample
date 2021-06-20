using System;

#nullable disable

namespace Blogs.Data.Model
{
    public partial class Comment
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? WriterId { get; set; }
        public Guid PostId { get; set; }

        public virtual Post Post { get; set; }
        public virtual User Writer { get; set; }
    }
}
