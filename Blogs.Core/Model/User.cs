using System;
using System.Collections.Generic;

namespace Blogs.Data.Model
{
    public class User
    {
        public User()
        {
            Roles = new HashSet<Role>();
            Comments = new HashSet<Comment>();
            Posts = new HashSet<Post>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<AuthToken> Tokens { get; set; }


    }
}
