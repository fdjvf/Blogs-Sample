using Blogs.Services.Dto;
using System;
using System.Linq;
using System.Security.Claims;

namespace Blogs.Services.Utilities
{
    public static class SecurityExtensions
    {
        /// <summary>
        /// Get current user unique identifier
        /// </summary>
        /// <param name="principal"></param>
        /// <returns></returns>
        public static Guid GetId(this ClaimsPrincipal principal)
        {
            var guidstr = principal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            _ = Guid.TryParse(guidstr, out Guid result);
            return result;
        }

        /// <summary>
        /// Check wheter the user has the Writer role
        /// </summary>
        /// <param name="principal"></param>
        /// <returns></returns>
        public static bool IsWriter(this ClaimsPrincipal principal)
        {
            return principal.IsInRole("Writer");
        }

        /// <summary>
        /// Check wheter the user has the Editor role
        /// </summary>
        /// <param name="principal"></param>
        /// <returns></returns>
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

