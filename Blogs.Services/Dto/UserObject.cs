using System;
using System.Collections.Generic;
using System.Linq;

namespace Blogs.Services.Dto
{
    /// <summary>
    /// DTO of User Model. Use in the Auth process to create the Identity of a already authenticated user.
    /// </summary>
    public class UserObject
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public IEnumerable<string> Roles { get; set; }
        public bool IsWriter => Roles.Contains("Writer");
        public bool IsEditor => Roles.Contains("Editor");
    }
}
