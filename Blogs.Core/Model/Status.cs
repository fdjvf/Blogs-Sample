using Blogs.Data.Enums;
using System.Collections.Generic;

#nullable disable

namespace Blogs.Data.Model
{
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
