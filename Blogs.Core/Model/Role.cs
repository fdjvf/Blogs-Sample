using System;
using System.Collections.Generic;

namespace Blogs.Data.Model
{
    /// <summary>
    /// Roles available in the system and that can be asigned to users. Uses for Auth purposes 
    /// to validate when a user is a Writer or Editor
    /// </summary>
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
