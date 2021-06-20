using System;
using System.Collections.Generic;

namespace Blogs.Services.Dto
{
    public class UserObject
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
