using System;
using System.Collections.Generic;

namespace Blogs.Data.Model
{
    /// <summary>
    /// Users that can manage the posts and comments in the Blog. Used for Auth purposes as well.
    /// </summary>
    public class User
    {
        public User()
        {
            Roles = new HashSet<Role>();
            Comments = new HashSet<Comment>();
            Posts = new HashSet<Post>();
            Tokens = new HashSet<AuthToken>();

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
