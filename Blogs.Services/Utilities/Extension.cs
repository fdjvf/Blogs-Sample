using Blogs.Services.Dto;
using System;
using System.Linq;
using System.Security.Claims;

namespace Blogs.Services.Utilities
{
    public static class SecurityExtensions
    {
        public static Guid GetId(this ClaimsPrincipal principal)
        {
            var guidstr = principal.FindFirst("Id")?.Value;
            Guid.TryParse(guidstr, out Guid result);
            return result;
        }

        public static bool IsWriter(this ClaimsPrincipal principal)
        {
            return principal.IsInRole("Writer");
        }

        public static bool IsEditor(this ClaimsPrincipal principal)
        {
            return principal.IsInRole("Editor");
        }

        public static UserObject ToUserObject(this ClaimsPrincipal principal)
        {
            var userId = principal.GetId();
            var roles = principal.Claims.Where(cl => cl.Type == ClaimTypes.Role).Select(cl => cl.Value);
            var email = principal.Identity.Name;
            return new UserObject
            {
                Id = userId,
                Roles = roles,
                Email = email
            };
        }
    }
}

