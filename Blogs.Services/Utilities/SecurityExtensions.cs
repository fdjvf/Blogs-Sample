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
            var guidstr = principal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
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
            return new UserObject
            {
                Id = userId,
                Roles = roles,
                UserName = principal.Identity.Name,
                Name = principal.FindFirst(ClaimTypes.GivenName)?.Value
            };
        }
    }
}

