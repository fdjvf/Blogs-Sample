using System;
using System.Collections.Generic;

namespace Blogs.Core.Model
{
    public class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
